using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebScreensaver
{
  public partial class ConfigurationDialog : Form
  {
    public ConfigurationDialog(String displayUrl)
    {
      InitializeComponent();
      this.urlInput.Text = displayUrl;
    }

    private void HeadingLabel2_Click(object sender, EventArgs e)
    {

    }

    private void acceptButton_Click(object sender, EventArgs e)
    {
      Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\\WebScreensaver");
      key.SetValue("displayUrl", this.urlInput.Text);
      Close();
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}
