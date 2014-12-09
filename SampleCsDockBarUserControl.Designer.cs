namespace SampleCsDockBar
{
  partial class SampleCsDockBarUserControl
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnPanel0 = new System.Windows.Forms.Button();
      this.btnPanel1 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnPanel0
      // 
      this.btnPanel0.Location = new System.Drawing.Point(4, 4);
      this.btnPanel0.Name = "btnPanel0";
      this.btnPanel0.Size = new System.Drawing.Size(75, 23);
      this.btnPanel0.TabIndex = 0;
      this.btnPanel0.Text = "Panel 0";
      this.btnPanel0.UseVisualStyleBackColor = true;
      this.btnPanel0.Click += new System.EventHandler(this.btnPanel0_Click);
      // 
      // btnPanel1
      // 
      this.btnPanel1.Location = new System.Drawing.Point(85, 4);
      this.btnPanel1.Name = "btnPanel1";
      this.btnPanel1.Size = new System.Drawing.Size(75, 23);
      this.btnPanel1.TabIndex = 1;
      this.btnPanel1.Text = "Panel 1";
      this.btnPanel1.UseVisualStyleBackColor = true;
      this.btnPanel1.Click += new System.EventHandler(this.btnPanel1_Click);
      // 
      // SampleCsDockBarUserControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.btnPanel1);
      this.Controls.Add(this.btnPanel0);
      this.Name = "SampleCsDockBarUserControl";
      this.Size = new System.Drawing.Size(328, 33);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnPanel0;
    private System.Windows.Forms.Button btnPanel1;
  }
}
