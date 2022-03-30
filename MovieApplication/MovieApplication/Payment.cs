using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieApplication
{
    public partial class Payment : Form
    {
        public Payment(int price)
        {
            InitializeComponent();
            this.textBox1.Text = price.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            try
            {
                string input = textBox2.Text;
                int intInput = int.Parse(input);
                int price = int.Parse(this.textBox1.Text);
                this.textBox3.Text = (intInput - price).ToString();

            }
            catch (Exception ex) {
                this.textBox3.Text = "รับเฉพาะตัวเลขโว้ย!!!";
            }
        }
    }
}
