using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, ketQua;
            a = int.Parse(txtso1.Text);
            b = int.Parse(txtso2.Text); 
            Caculation c = new Caculation(a,b);
            ketQua = c.Execute("+");
            txtKetqua.Text = ketQua.ToString();
        }
    }
}
