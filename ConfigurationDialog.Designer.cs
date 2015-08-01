namespace WebScreensaver
{
  partial class ConfigurationDialog
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
      this.HeadingLabel = new System.Windows.Forms.Label();
      this.HeadingLabel2 = new System.Windows.Forms.Label();
      this.urlInput = new System.Windows.Forms.TextBox();
      this.urlInputLabel = new System.Windows.Forms.Label();
      this.cancelButton = new System.Windows.Forms.Button();
      this.acceptButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // HeadingLabel
      // 
      this.HeadingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.HeadingLabel.AutoSize = true;
      this.HeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.HeadingLabel.Location = new System.Drawing.Point(22, 9);
      this.HeadingLabel.Name = "HeadingLabel";
      this.HeadingLabel.Size = new System.Drawing.Size(266, 29);
      this.HeadingLabel.TabIndex = 0;
      this.HeadingLabel.Text = "WebScreensaver v0.1";
      // 
      // HeadingLabel2
      // 
      this.HeadingLabel2.AutoSize = true;
      this.HeadingLabel2.Location = new System.Drawing.Point(202, 38);
      this.HeadingLabel2.Name = "HeadingLabel2";
      this.HeadingLabel2.Size = new System.Drawing.Size(85, 13);
      this.HeadingLabel2.TabIndex = 1;
      this.HeadingLabel2.Text = "by Marco Haase";
      this.HeadingLabel2.Click += new System.EventHandler(this.HeadingLabel2_Click);
      // 
      // urlInput
      // 
      this.urlInput.Location = new System.Drawing.Point(27, 150);
      this.urlInput.Name = "urlInput";
      this.urlInput.Size = new System.Drawing.Size(260, 20);
      this.urlInput.TabIndex = 2;
      this.urlInput.Text = "http://pipi/turtle";
      // 
      // urlInputLabel
      // 
      this.urlInputLabel.AutoSize = true;
      this.urlInputLabel.Location = new System.Drawing.Point(27, 131);
      this.urlInputLabel.Name = "urlInputLabel";
      this.urlInputLabel.Size = new System.Drawing.Size(204, 13);
      this.urlInputLabel.TabIndex = 3;
      this.urlInputLabel.Text = "Please enter the address of the webpage:";
      // 
      // cancelButton
      // 
      this.cancelButton.Location = new System.Drawing.Point(27, 208);
      this.cancelButton.Name = "cancelButton";
      this.cancelButton.Size = new System.Drawing.Size(75, 23);
      this.cancelButton.TabIndex = 4;
      this.cancelButton.Text = "Cancel";
      this.cancelButton.UseVisualStyleBackColor = true;
      this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
      // 
      // acceptButton
      // 
      this.acceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.acceptButton.Location = new System.Drawing.Point(211, 208);
      this.acceptButton.Name = "acceptButton";
      this.acceptButton.Size = new System.Drawing.Size(75, 23);
      this.acceptButton.TabIndex = 5;
      this.acceptButton.Text = "Accept";
      this.acceptButton.UseVisualStyleBackColor = false;
      this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
      // 
      // ConfigurationDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(317, 261);
      this.Controls.Add(this.acceptButton);
      this.Controls.Add(this.cancelButton);
      this.Controls.Add(this.urlInputLabel);
      this.Controls.Add(this.urlInput);
      this.Controls.Add(this.HeadingLabel2);
      this.Controls.Add(this.HeadingLabel);
      this.Name = "ConfigurationDialog";
      this.Text = "ConfigurationDialog";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label HeadingLabel;
    private System.Windows.Forms.Label HeadingLabel2;
    private System.Windows.Forms.TextBox urlInput;
    private System.Windows.Forms.Label urlInputLabel;
    private System.Windows.Forms.Button cancelButton;
    private System.Windows.Forms.Button acceptButton;


  }
}