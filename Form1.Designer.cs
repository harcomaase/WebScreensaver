namespace WebScreensaver
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }


    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.webBrowser1 = new System.Windows.Forms.WebBrowser();
      this.SuspendLayout();
      // 
      // webBrowser1
      // 
      this.webBrowser1.AllowNavigation = false;
      this.webBrowser1.AllowWebBrowserDrop = false;
      this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
      this.webBrowser1.Location = new System.Drawing.Point(0, 0);
      this.webBrowser1.Margin = new System.Windows.Forms.Padding(0);
      this.webBrowser1.Name = "webBrowser1";
      this.webBrowser1.ScrollBarsEnabled = false;
      this.webBrowser1.Size = new System.Drawing.Size(1024, 768);
      this.webBrowser1.TabIndex = 0;
      this.webBrowser1.TabStop = false;
      this.webBrowser1.Url = new System.Uri("http://pipi/turtle/", System.UriKind.Absolute);
      this.webBrowser1.WebBrowserShortcutsEnabled = false;
      this.webBrowser1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CausesValidation = false;
      this.ClientSize = new System.Drawing.Size(1008, 729);
      this.Controls.Add(this.webBrowser1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "Form1";
      this.Text = "WebScreensaver";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResizeBegin += new System.EventHandler(this.Form1_MouseEnter);
      this.ResizeEnd += new System.EventHandler(this.Form1_MouseEnter);
      this.Click += new System.EventHandler(this.Form1_MouseEnter);
      this.DoubleClick += new System.EventHandler(this.Form1_MouseEnter);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
      this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
      this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
      this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
      this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
      this.MouseCaptureChanged += new System.EventHandler(this.Form1_MouseEnter);
      this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
      this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
      this.MouseLeave += new System.EventHandler(this.Form1_MouseEnter);
      this.MouseHover += new System.EventHandler(this.Form1_MouseEnter);
      this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
      this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
      this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.WebBrowser webBrowser1;
  }
}

