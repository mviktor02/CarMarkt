using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarMarktServer
{
  public class CarMarktService : CarMarkt.CarMarktBase
  {

    static readonly Dictionary<string, string> sessions = new Dictionary<string, string>();
    static DBConnect dbConnection = new DBConnect();
    static readonly char[] validUsernameChars = new char[] { '.', '_', '-' };
    static readonly char[] validPasswordChars = new char[] { '.', '_', '-', '*', '+', '/', '?', '!', '~', '|', '<', '>', '$', '€', '=', '(', ')', '%', '[', ']', '{', '}' };

    private static bool IsUsernameValid(string username)
    {
      if (string.IsNullOrEmpty(username)) return false;
      lock (validUsernameChars)
      {
        foreach (char c in username)
        {
          if (!(char.IsLetterOrDigit(c) || char.IsControl(c) || validUsernameChars.Contains(c)))
          {
            return false;
          }
        }
        return true;
      }
    }
    private static bool IsPasswordValid(string password)
    {
      if (string.IsNullOrEmpty(password)) return false;
      lock (validPasswordChars)
      {
        foreach (char c in password)
        {
          if (!(char.IsLetterOrDigit(c) || char.IsControl(c) || validPasswordChars.Contains(c)))
          {
            return false;
          }
        }
        return true;
      }
    }

    public override Task<Session_Id> Register(User user, ServerCallContext context)
    {
      lock (dbConnection)
      {
        if (!IsUsernameValid(user.Name) || !IsPasswordValid(user.Password) || dbConnection.SelectUserAlreadyExists(user.Name))
        {
          return Task.FromResult(new Session_Id { Id = "" });
        }
        else
        {
          dbConnection.InsertUser(user.Name, user.Password);
          string id = Guid.NewGuid().ToString();
          lock (sessions)
          {
            sessions.Add(id, user.Name);
          }
          return Task.FromResult(new Session_Id { Id = id });
        }
      }
    }

    public override Task<Session_Id> Login(User user, ServerCallContext context)
    {
      if (!IsUsernameValid(user.Name) || !IsPasswordValid(user.Password))
      {
        return Task.FromResult(new Session_Id { Id = "" });
      }
      int count;
      lock (dbConnection)
      {
        count = dbConnection.SelectUser(user.Name, user.Password);
      }

      if (count == 1)
      {
        string id = Guid.NewGuid().ToString();
        lock (sessions)
        {
          sessions.Add(id, user.Name);
        }
        return Task.FromResult(new Session_Id { Id = id });
      }
      else
      {
        return Task.FromResult(new Session_Id { Id = "" });
      }
    }

    public override Task<Result> Logout(Session_Id request, ServerCallContext context)
    {
      lock (sessions)
      {
        sessions.Remove(request.Id);
      }
      return Task.FromResult(new Result { Message = "Successfully Logged Out!" });
    }

    public override async Task RefreshListings(Empty request, IServerStreamWriter<PartialCarData> responseStream, ServerCallContext context)
    {
      List<PartialCarData> cars;
      lock (dbConnection)
      {
        cars = dbConnection.SelectForListings();
      }
      foreach (var car in cars)
        await responseStream.WriteAsync(car);
    }

    public override Task<FullCarData> ViewListing(CarCode carCode, ServerCallContext context)
    {
      FullCarData data;
      lock (dbConnection)
      {
        data = dbConnection.SelectForView(carCode.Code);
      }

      if (data != null)
      {
        return Task.FromResult(data);
      }
      else
      {
        return Task.FromResult(new FullCarData
        {
          PartialData = null
        });
      }
    }

    public override Task<Result> AddListing(FullCarData data, ServerCallContext context)
    {
      if (!isLoggedIn(data.Session, data.OwnerName))
      {
        return Task.FromResult(new Result { Message = "Please log in" });
      }
      else
      {
        lock (dbConnection)
        {
          if(dbConnection.InsertCar(data))
          {
            return Task.FromResult(new Result { Message = "Successfully added listing" });
          }
          else
          {
            return Task.FromResult(new Result { Message = "ERROR: Couldn't add listing" });
          }
        }
      }
    }

    public override Task<Result> RemoveListing(RemovalData data, ServerCallContext context)
    {
      if (!isLoggedIn(data.OwnerId, data.OwnerName))
      {
        return Task.FromResult(new Result { Message = "Please log in" });
      }
      else
      {
        lock (dbConnection)
        {
          if (dbConnection.DeleteCar(data))
          {
            return Task.FromResult(new Result { Message = "Successfully removed listing" });
          }
          else
          {
            return Task.FromResult(new Result { Message = "ERROR: Couldn't remove listing. You are either not the owner or a server-side error occured." });
          }
        }
      }
    }

    public override Task<Result> Comment(CommentMessage comment, ServerCallContext context)
    {
      if (!isLoggedIn(comment.OwnerId, comment.Owner))
      {
        return Task.FromResult(new Result { Message = "Please log in" });
      }
      else
      {
        lock (dbConnection)
        {
          if (dbConnection.InsertComment(comment))
          {
            return Task.FromResult(new Result { Message = "Successfully commented" });
          }
          else
          {
            return Task.FromResult(new Result { Message = "ERROR: Couldn't comment" });
          }
        }
      }
    }

    public override async Task ViewComments(CarCode carCode, IServerStreamWriter<CommentMessage> responseStream, ServerCallContext context)
    {
      List<CommentMessage> comments;
      lock (dbConnection)
      {
        comments = dbConnection.SelectCommentsForView(carCode.Code);
      }
      foreach (var comment in comments)
        await responseStream.WriteAsync(comment);
    }

    private bool isLoggedIn(Session_Id session, string name) => isLoggedIn(session.Id, name);

    private bool isLoggedIn(string id, string name)
    {
      lock (sessions)
      {
        return sessions[id] == name;
      }
    }
  }
}
