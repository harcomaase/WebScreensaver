using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebScreensaver
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main(string[] args)
    {
      if (args.Length > 0)
      {
        String param = args[0].ToLower().Trim();
        switch (param)
        {
          case "/s":
            start();
            break;
          case "/c":
            MessageBox.Show("No options available yet :)", "WebApp Screensaver", MessageBoxButtons.OK, MessageBoxIcon.Information);
            break;
          case "/p":
            MessageBox.Show("Preview not available yet :)", "WebApp Screensaver", MessageBoxButtons.OK, MessageBoxIcon.Information);
            break;
        }
      }
      else
      {
        start();
      }
    }

    static void start()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new Form1());
    }
  }
}
