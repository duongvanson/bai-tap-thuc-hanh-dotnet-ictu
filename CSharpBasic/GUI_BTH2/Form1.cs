using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_BTH2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtInput_TextChanged(object sender, EventArgs e)
        {
            txtOutput.Text = standardizeString(txtInput.Text);
        }
        string isNumberInString(string str)
        {
            var lst = str.ToList();
            for (int i = 0; i < lst.Count; i++)
            {
                if (char.IsDigit(lst[i]))
                {
                    lst.RemoveAt(i);
                    i--;
                }
            }
            string outp = new string(lst.ToArray());
           // outp = outp.Replace("%", "");
            return outp;
        }
        string standardizeString(string inp)
        {
            inp = isNumberInString(inp);
            inp = inp.Trim();
            var lst = inp.Split(' ');
            inp = "";
            foreach (string item in lst)
            {
                if (!string.IsNullOrWhiteSpace(item.Trim()))
                {
                    var temp = item.Substring(0, 1);
                    temp = temp.ToUpper();
                    var get = temp + item.Substring(1, item.Length - 1);
                    inp += get + " ";
                }
            }
            inp = inp.TrimEnd();
            return inp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //("haha7");
        }
    }
}
