using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Authentication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "ADMIN" & textBox2.Text == "ADMIN")
            {
                Form Form2 = new Form2();
                Form2.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неправильно введен логин или пароль");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
