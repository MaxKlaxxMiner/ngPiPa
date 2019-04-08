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
      ((System.ComponentModel.ISupportInitialize)(this.splitColorSelector)).BeginInit();
      this.splitColorSelector.Panel1.SuspendLayout();
      this.splitColorSelector.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitToolSelector)).BeginInit();
      this.splitToolSelector.SuspendLayout();
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
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.ClientSize = new System.Drawing.Size(1027, 519);
      this.Controls.Add(this.splitColorSelector);
      this.Name = "FormMain";
      this.Text = "ngPiPa v0.001";
      this.splitColorSelector.Panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitColorSelector)).EndInit();
      this.splitColorSelector.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitToolSelector)).EndInit();
      this.splitToolSelector.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitColorSelector;
    private System.Windows.Forms.SplitContainer splitToolSelector;
  }
}

