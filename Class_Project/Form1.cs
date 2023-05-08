using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Project
{
    public partial class Form1 : Form
    {
        Double result = 0;
        string operatorion = string.Empty;
        string fstNum, secNum;
        bool enterValue = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            PnlHistory.Height = (PnlHistory.Height == 5) ? PnlHistory.Height = 345 : 5;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnNum_Click(object sender, EventArgs e)
        {
            if (TxtDisplay1.Text == "O" || enterValue) TxtDisplay1.Text = string.Empty;

            enterValue = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if(TxtDisplay1.Text.Contains("."))
                    TxtDisplay1.Text = TxtDisplay1 + button.Text;
            }
            else
                TxtDisplay1.Text = TxtDisplay1.Text + button.Text;
        }
    }
}
