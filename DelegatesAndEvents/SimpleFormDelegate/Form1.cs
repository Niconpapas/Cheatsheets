using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFormDelegate
{
    public partial class Form1 : Form
    {
        public delegate string btnHandler(object source,EventArgs args);
        public event btnHandler BtnClicked;

        public Form1()
        {
            InitializeComponent();
        }
        //protected virtual void OnbtnClick()
        //{
        //    if (BtnClicked != null)
        //        BtnClicked(this, EventArgs.Empty);
        //}

        private void btn_Super_Click(object sender, EventArgs e)
        {
            if(BtnClicked!=null)
            {
                lbl_Video.Text = BtnClicked(this, EventArgs.Empty);
            }
            

        }
        
    }
}
