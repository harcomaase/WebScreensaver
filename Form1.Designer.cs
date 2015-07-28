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
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1008, 729);
      this.Controls.Add(this.webBrowser1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.WebBrowser webBrowser1;
  }
}

