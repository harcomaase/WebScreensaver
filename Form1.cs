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
      ApplicationMouseHandler mouseHandler = new ApplicationMouseHandler();
      mouseHandler.mouseMoved += new MouseMovementEvent(mouseMovement);
      Application.AddMessageFilter(mouseHandler);

      InitializeComponent();
    }

    private Point mousePosition = new Point(-1,-1);
    private const int DEVIATION_IN_PIXEL = 3;

    private void mouseMovement()
    {
      int x = Cursor.Position.X;
      int y = Cursor.Position.Y;

      if (mousePosition.X == -1 && mousePosition.Y == -1)
      {
        mousePosition.X = x;
        mousePosition.Y = y;
        return;
      }

      if (Math.Abs(mousePosition.X - x) > DEVIATION_IN_PIXEL || Math.Abs(mousePosition.Y - y) > DEVIATION_IN_PIXEL)
      {
        ExitApplication();
      }
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
      ExitApplication();
    }

    private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
    {
      ExitApplication();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      Cursor.Hide();
    }
  }

  public delegate void MouseMovementEvent();

  public class ApplicationMouseHandler : IMessageFilter
   {
      private const int WM_MOUSEMOVE = 0x0200;

      public event MouseMovementEvent mouseMoved;

      #region IMessageFilter Members

      public bool PreFilterMessage(ref Message m)
      {
         if (m.Msg == WM_MOUSEMOVE)
         {
            if (mouseMoved != null)
            {
               mouseMoved();
            }
         }
         return false;
      }

      #endregion
   }
}
