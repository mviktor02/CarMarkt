using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarMarktClient
{
  static class Program
  {
    static GrpcChannel channel = GrpcChannel.ForAddress("https://localhost:5001");
    public static CarMarkt.CarMarktClient client;
    public static bool shouldExitOnClose = true;
    public static string SessionId { get; set; }
    public static string Username { get; set; }
    public static LogInForm logInForm;

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      client = new CarMarkt.CarMarktClient(channel);
      Application.SetHighDpiMode(HighDpiMode.SystemAware);
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new LogInForm());
    }

  }
}
