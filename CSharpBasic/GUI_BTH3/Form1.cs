using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_BTH3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Fraction fra1, fra2;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TxtFrac1_TextChanged(object sender, EventArgs e)
        {
            resultMessage(txtFrac1.Text, txtFrac2.Text);
        }

        private void TxtFrac2_TextChanged(object sender, EventArgs e)
        {
            resultMessage(txtFrac1.Text, txtFrac2.Text);
        }
        private bool checkInput(string inp)
        {
            int x;
            inp.Trim();
            var temp = inp.Split('/');
            if (temp.Length != 2 ||
                !int.TryParse(temp[0], out x) ||
                !int.TryParse(temp[1], out x)) return false;
            if (int.Parse(temp[1]) == 0) { return false; }
            return true;
        }
        private void resultMessage(string str1, string str2)
        {
            StringBuilder outp = new StringBuilder("Hi, i'm SRG.");
            var inp1 = str1.Split('/');
            var inp2 = str2.Split('/');
            if (checkInput(str1) && checkInput(str2))
            {
                outp.Clear();
                fra1 = new Fraction(int.Parse(inp1[0]), int.Parse(inp1[1]));
                fra2 = new Fraction(int.Parse(inp2[0]), int.Parse(inp2[1]));
                Fraction plus = fra1.plus(fra2);
                Fraction multiply = fra1.multiply(fra2);
                fra1.simplify();
                fra2.simplify();
                outp.Append(" RESULT: \n");
                outp.Append("\n- Frac 1 simplify: " + fra1.ToString());
                outp.Append("\n- Frac 2 simplify: " + fra2.ToString());
                outp.Append("\n- Plus: " + plus.ToString());
                outp.Append("\n- Multiply: " + multiply.ToString());
            }
            txtResult.Text = outp.ToString();
        }
    }
}
