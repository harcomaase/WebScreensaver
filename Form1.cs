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
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void ExitApplication()
    {
      Application.Exit();
    }

    private void Form1_MouseMove(object sender, MouseEventArgs e)
    {
      ExitApplication();
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
      ExitApplication();
    }

    private void Form1_MouseEnter(object sender, EventArgs e)
    {
      ExitApplication();
    }

    private void Form1_KeyPress(object sender, KeyPressEventArgs e)
    {
      
    }

    private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
    {
      ExitApplication();
    }
  }
}
