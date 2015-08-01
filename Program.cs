using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebScreensaver
{
  static class Program
  {
    private const String FALLBACK_URL = "http://pipi/turtle";

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main(string[] args)
    {
      Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\WebScreensaver");
      
      String displayUrl = key == null || key.GetValue("displayUrl") == null ? FALLBACK_URL : (String) key.GetValue("displayUrl");

      if (args.Length > 0)
      {
        String param = args[0].ToLower().Trim();
        switch (param)
        {
          case "/s":
            start(displayUrl);
            break;
          case "/c":
            configure(displayUrl);
            break;
          case "/p":
            if (args.Length < 2)
            {
              MessageBox.Show("Error while rendering screensaver preview");
              //preview implemented later. this feels kind of unneccessary
            }
            break;
        }
      }
      else
      {
        configure(displayUrl);
        //start(displayUrl);
      }
    }

    static void start(String displayUrl)
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new Form1(displayUrl));
    }

    static void configure(String displayUrl)
    {
      Application.Run(new ConfigurationDialog(displayUrl));
    }
  }
}
