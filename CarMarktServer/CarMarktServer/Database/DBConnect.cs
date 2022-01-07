using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CarMarktServer
{
  public class DBConnect
  {
    private MySqlConnection connection;
    private string server;
    private string database;
    private string uid;

    static readonly string[] bodyTypes = Enum.GetNames(typeof(Body));
    static readonly string[] fuelTypes = Enum.GetNames(typeof(Fuel));

    public DBConnect()
    {
      Initialize();
    }

    private void Initialize()
    {
      server = "localhost";
      database = "carmarkt";
      uid = "root";
      string connectionString;
      connectionString = "SERVER=" + server + ";" + "DATABASE=" +
      database + ";" + "UID=" + uid + ";";

      connection = new MySqlConnection(connectionString);
    }

    private bool OpenConnection()
    {
      try
      {
        connection.Open();
        return true;
      }
      catch (MySqlException ex)
      {
        //0: Cannot connect to server.
        //1045: Invalid user name and/or password.
        switch (ex.Number)
        {
          case 0:
            Console.WriteLine("Cannot connect to server. Contact administrator");
            break;

          case 1045:
            Console.WriteLine("Invalid username/password, please try again");
            break;
        }
        return false;
      }
    }

    private bool CloseConnection()
    {
      try
      {
        connection.Close();
        return true;
      }
      catch (MySqlException ex)
      {
        Console.WriteLine(ex.Message);
        return false;
      }
    }

    public bool InsertUser(string username, string password)
    {
      string query = "INSERT INTO users (name, password) VALUES ('"+username+"', '"+CreateSha256Hash(password)+"')";
      return ExecuteNonQuery(query);
    }

    public bool InsertCar(FullCarData data)
    {
      string query = "INSERT INTO cars (make, model, body, fuel, year, price, description, phone, owner)" +
        "VALUES ("
        + "'" + data.PartialData.Make + "', "
        + "'" + data.PartialData.Model + "', "
        + "'" + Convert.ToString(data.PartialData.Body) + "', "
        + "'" + Convert.ToString(data.PartialData.Fuel) + "', "
        + "'" + Convert.ToString(data.PartialData.Year) + "', "
        + "'" + Convert.ToString(data.PartialData.Price) + "', "
        + "\"" + data.Description + "\", "
        + "'" + data.PhoneNumber + "', "
        + "'" + data.OwnerName + "'" +
        ")";
      return ExecuteNonQuery(query);
    }

    public bool InsertComment(CommentMessage message)
    {
      string query = "INSERT INTO comments (code, message, owner, time) VALUES ("
        + "'" + message.Code + "', "
        + "\"" + message.Message + "\", "
        + "'" + message.Owner + "', "
        + "'" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "'" +
        ")";
      return ExecuteNonQuery(query);
    }

    public bool DeleteCar(RemovalData data)
    {
      string query = "DELETE FROM cars WHERE code="+data.Code+" and owner='"+data.OwnerName+"'";
      return ExecuteNonQuery(query);
    }

    public List<PartialCarData> SelectForListings()
    {
      string query = "SELECT code, make, model, body, fuel, year, price FROM cars";

      List<PartialCarData> list = new List<PartialCarData>();

      if (OpenConnection())
      {
        MySqlCommand cmd = new MySqlCommand(query, connection);
        MySqlDataReader dataReader = cmd.ExecuteReader();

        while (dataReader.Read())
        {
          PartialCarData data = GetPartialDataFromReader(dataReader);
          list.Add(data);
        }

        dataReader.Close();

        CloseConnection();
      }
      return list;
    }

    public FullCarData SelectForView(uint code)
    {
      FullCarData data = null;
      string query = "SELECT code, make, model, body, fuel, year, price, description, phone, owner FROM cars WHERE code = " + code;

      if (OpenConnection())
      {

        MySqlCommand cmd = new MySqlCommand(query, connection);
        MySqlDataReader dataReader = cmd.ExecuteReader();

        while (dataReader.Read())
        {
          data = new FullCarData();
          data.PartialData = GetPartialDataFromReader(dataReader);
          data.Description = dataReader["description"].ToString();
          data.PhoneNumber = dataReader["phone"].ToString();
          data.OwnerName = dataReader["owner"].ToString();
        }

        dataReader.Close();

        CloseConnection();
      }
      return data;
    }

    public List<CommentMessage> SelectCommentsForView(uint code)
    {
      List<CommentMessage> messages = new List<CommentMessage>();
      string query = "SELECT code, message, owner, time FROM comments WHERE code=" + code;

      if (OpenConnection())
      {

        MySqlCommand cmd = new MySqlCommand(query, connection);
        MySqlDataReader dataReader = cmd.ExecuteReader();

        while (dataReader.Read())
        {
          CommentMessage message = new CommentMessage();
          message.Code = uint.Parse(dataReader["code"].ToString());
          message.Message = dataReader["message"].ToString();
          message.Owner = dataReader.IsDBNull(dataReader.GetOrdinal("owner")) ? "[deleted]" : dataReader["owner"].ToString();
          message.Time = dataReader.GetDateTime("time").ToString();
          messages.Add(message);
        }

        dataReader.Close();

        CloseConnection();
      }
      return messages;
    }

    public int SelectUser(string username, string password)
    {
      string query = "SELECT Count(*) FROM users WHERE name='" + username + "' and password='"+CreateSha256Hash(password)+"'";
      return ExecuteCountQuery(query);
    }

    public bool SelectUserAlreadyExists(string username)
    {
      string query = "SELECT Count(*) FROM usernames WHERE name='" + username + "'";
      return ExecuteCountQuery(query) == 1;
    }

    public bool SelectCarAlreadyExists(uint code)
    {
      string query = "SELECT Count(*) FROM cars WHERE code=" + code + "";
      return ExecuteCountQuery(query) == 1;
    }

    private static string CreateSha256Hash(string data)
    {
      using SHA256 sha256Hash = SHA256.Create();
      byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(data));

      StringBuilder builder = new StringBuilder();
      for (int i = 0; i < bytes.Length; i++)
      {
        builder.Append(bytes[i].ToString("x2"));
      }
      return builder.ToString();
    }

    private static PartialCarData GetPartialDataFromReader(MySqlDataReader dataReader)
    {
      PartialCarData partialData = new PartialCarData();
      partialData.Code = uint.Parse(dataReader["code"].ToString());
      partialData.Make = dataReader["make"].ToString();
      partialData.Model = dataReader["model"].ToString();
      partialData.Body = uint.Parse(dataReader["body"].ToString());
      partialData.Fuel = uint.Parse(dataReader["fuel"].ToString());
      partialData.Year = uint.Parse(dataReader["year"].ToString());
      partialData.Price = uint.Parse(dataReader["price"].ToString());
      return partialData;
    }

    private bool ExecuteNonQuery(string query)
    {
      if (OpenConnection())
      {
        MySqlCommand cmd = new MySqlCommand(query, connection);
        int i = cmd.ExecuteNonQuery();
        CloseConnection();
        return i == 1;
      }
      return false;
    }

    private int ExecuteCountQuery(string query)
    {
      int count = -1;
      if (OpenConnection())
      {
        MySqlCommand cmd = new MySqlCommand(query, connection);
        count = int.Parse(cmd.ExecuteScalar() + "");

        CloseConnection();
      }
      return count;
    }
  }
}
