namespace NewProgressBar
{
    partial class ProgressBarWithTransparentLabel
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
            this.transparentLabel1 = new NewProgressBar.TransparentLabel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // transparentLabel1
            // 
            this.transparentLabel1.AutoSize = true;
            this.transparentLabel1.BackColor = System.Drawing.Color.Transparent;
            this.transparentLabel1.Location = new System.Drawing.Point(79, 12);
            this.transparentLabel1.Name = "transparentLabel1";
            this.transparentLabel1.Size = new System.Drawing.Size(13, 13);
            this.transparentLabel1.TabIndex = 1;
            this.transparentLabel1.Text = "0";
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(174, 40);
            this.progressBar1.TabIndex = 2;
            // 
            // ProgressBarWithTransparentLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.transparentLabel1);
            this.Controls.Add(this.progressBar1);
            this.Name = "ProgressBarWithTransparentLabel";
            this.Size = new System.Drawing.Size(174, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TransparentLabel transparentLabel1;
        private System.Windows.Forms.ProgressBar progressBar1;

    }
}
