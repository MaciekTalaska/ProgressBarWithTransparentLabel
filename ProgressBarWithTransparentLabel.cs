using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NewProgressBar
{
    public partial class ProgressBarWithTransparentLabel : UserControl
    {
        public ProgressBarWithTransparentLabel()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.progressBar1.SendToBack();
            this.transparentLabel1.BringToFront();
            this.transparentLabel1.Text = this.progressBar1.Value.ToString();
            this.transparentLabel1.Invalidate();
       }

        public int Value
        {
            get { return this.progressBar1.Value; }
            set
            {
                this.progressBar1.Value = value; 
            }
        }
    }
}
