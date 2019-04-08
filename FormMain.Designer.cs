namespace ngPiPa
{
  sealed partial class FormMain
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      this.splitColorSelector = new System.Windows.Forms.SplitContainer();
      this.splitToolSelector = new System.Windows.Forms.SplitContainer();
      this.button1 = new System.Windows.Forms.Button();
      this.buttonColor_e0e0e0 = new System.Windows.Forms.Button();
      this.buttonColor_c0c0c0 = new System.Windows.Forms.Button();
      this.buttonColor_808080 = new System.Windows.Forms.Button();
      this.buttonColor_404040 = new System.Windows.Forms.Button();
      this.pictureBoxSelectedColor = new System.Windows.Forms.PictureBox();
      this.buttonColor_000000 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.splitColorSelector)).BeginInit();
      this.splitColorSelector.Panel1.SuspendLayout();
      this.splitColorSelector.Panel2.SuspendLayout();
      this.splitColorSelector.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitToolSelector)).BeginInit();
      this.splitToolSelector.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedColor)).BeginInit();
      this.SuspendLayout();
      // 
      // splitColorSelector
      // 
      this.splitColorSelector.BackColor = System.Drawing.Color.Gray;
      this.splitColorSelector.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitColorSelector.Location = new System.Drawing.Point(0, 0);
      this.splitColorSelector.Name = "splitColorSelector";
      this.splitColorSelector.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitColorSelector.Panel1
      // 
      this.splitColorSelector.Panel1.Controls.Add(this.splitToolSelector);
      // 
      // splitColorSelector.Panel2
      // 
      this.splitColorSelector.Panel2.BackColor = System.Drawing.Color.Silver;
      this.splitColorSelector.Panel2.Controls.Add(this.button1);
      this.splitColorSelector.Panel2.Controls.Add(this.buttonColor_e0e0e0);
      this.splitColorSelector.Panel2.Controls.Add(this.buttonColor_c0c0c0);
      this.splitColorSelector.Panel2.Controls.Add(this.buttonColor_808080);
      this.splitColorSelector.Panel2.Controls.Add(this.buttonColor_404040);
      this.splitColorSelector.Panel2.Controls.Add(this.pictureBoxSelectedColor);
      this.splitColorSelector.Panel2.Controls.Add(this.buttonColor_000000);
      this.splitColorSelector.Size = new System.Drawing.Size(1027, 519);
      this.splitColorSelector.SplitterDistance = 459;
      this.splitColorSelector.TabIndex = 0;
      // 
      // splitToolSelector
      // 
      this.splitToolSelector.BackColor = System.Drawing.Color.Gray;
      this.splitToolSelector.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitToolSelector.Location = new System.Drawing.Point(0, 0);
      this.splitToolSelector.Name = "splitToolSelector";
      // 
      // splitToolSelector.Panel1
      // 
      this.splitToolSelector.Panel1.BackColor = System.Drawing.Color.Silver;
      // 
      // splitToolSelector.Panel2
      // 
      this.splitToolSelector.Panel2.BackColor = System.Drawing.Color.Silver;
      this.splitToolSelector.Size = new System.Drawing.Size(1027, 459);
      this.splitToolSelector.SplitterDistance = 91;
      this.splitToolSelector.TabIndex = 0;
      // 
      // button1
      // 
      this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.button1.BackColor = System.Drawing.Color.White;
      this.button1.Location = new System.Drawing.Point(353, 3);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(50, 50);
      this.button1.TabIndex = 6;
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.buttonColor_Select_Click);
      // 
      // buttonColor_e0e0e0
      // 
      this.buttonColor_e0e0e0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.buttonColor_e0e0e0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.buttonColor_e0e0e0.Location = new System.Drawing.Point(297, 3);
      this.buttonColor_e0e0e0.Name = "buttonColor_e0e0e0";
      this.buttonColor_e0e0e0.Size = new System.Drawing.Size(50, 50);
      this.buttonColor_e0e0e0.TabIndex = 5;
      this.buttonColor_e0e0e0.UseVisualStyleBackColor = false;
      this.buttonColor_e0e0e0.Click += new System.EventHandler(this.buttonColor_Select_Click);
      // 
      // buttonColor_c0c0c0
      // 
      this.buttonColor_c0c0c0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.buttonColor_c0c0c0.BackColor = System.Drawing.Color.Silver;
      this.buttonColor_c0c0c0.Location = new System.Drawing.Point(241, 3);
      this.buttonColor_c0c0c0.Name = "buttonColor_c0c0c0";
      this.buttonColor_c0c0c0.Size = new System.Drawing.Size(50, 50);
      this.buttonColor_c0c0c0.TabIndex = 4;
      this.buttonColor_c0c0c0.UseVisualStyleBackColor = false;
      this.buttonColor_c0c0c0.Click += new System.EventHandler(this.buttonColor_Select_Click);
      // 
      // buttonColor_808080
      // 
      this.buttonColor_808080.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.buttonColor_808080.BackColor = System.Drawing.Color.Gray;
      this.buttonColor_808080.Location = new System.Drawing.Point(185, 3);
      this.buttonColor_808080.Name = "buttonColor_808080";
      this.buttonColor_808080.Size = new System.Drawing.Size(50, 50);
      this.buttonColor_808080.TabIndex = 3;
      this.buttonColor_808080.UseVisualStyleBackColor = false;
      this.buttonColor_808080.Click += new System.EventHandler(this.buttonColor_Select_Click);
      // 
      // buttonColor_404040
      // 
      this.buttonColor_404040.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.buttonColor_404040.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.buttonColor_404040.Location = new System.Drawing.Point(129, 3);
      this.buttonColor_404040.Name = "buttonColor_404040";
      this.buttonColor_404040.Size = new System.Drawing.Size(50, 50);
      this.buttonColor_404040.TabIndex = 2;
      this.buttonColor_404040.UseVisualStyleBackColor = false;
      this.buttonColor_404040.Click += new System.EventHandler(this.buttonColor_Select_Click);
      // 
      // pictureBoxSelectedColor
      // 
      this.pictureBoxSelectedColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.pictureBoxSelectedColor.BackColor = System.Drawing.Color.Black;
      this.pictureBoxSelectedColor.Location = new System.Drawing.Point(4, 4);
      this.pictureBoxSelectedColor.Name = "pictureBoxSelectedColor";
      this.pictureBoxSelectedColor.Size = new System.Drawing.Size(50, 50);
      this.pictureBoxSelectedColor.TabIndex = 1;
      this.pictureBoxSelectedColor.TabStop = false;
      // 
      // buttonColor_000000
      // 
      this.buttonColor_000000.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.buttonColor_000000.BackColor = System.Drawing.Color.Black;
      this.buttonColor_000000.Location = new System.Drawing.Point(73, 3);
      this.buttonColor_000000.Name = "buttonColor_000000";
      this.buttonColor_000000.Size = new System.Drawing.Size(50, 50);
      this.buttonColor_000000.TabIndex = 0;
      this.buttonColor_000000.UseVisualStyleBackColor = false;
      this.buttonColor_000000.Click += new System.EventHandler(this.buttonColor_Select_Click);
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.ClientSize = new System.Drawing.Size(1027, 519);
      this.Controls.Add(this.splitColorSelector);
      this.Name = "FormMain";
      this.Text = "ngPiPa v0.002";
      this.splitColorSelector.Panel1.ResumeLayout(false);
      this.splitColorSelector.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitColorSelector)).EndInit();
      this.splitColorSelector.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitToolSelector)).EndInit();
      this.splitToolSelector.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedColor)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitColorSelector;
    private System.Windows.Forms.SplitContainer splitToolSelector;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button buttonColor_e0e0e0;
    private System.Windows.Forms.Button buttonColor_c0c0c0;
    private System.Windows.Forms.Button buttonColor_808080;
    private System.Windows.Forms.Button buttonColor_404040;
    private System.Windows.Forms.PictureBox pictureBoxSelectedColor;
    private System.Windows.Forms.Button buttonColor_000000;
  }
}

