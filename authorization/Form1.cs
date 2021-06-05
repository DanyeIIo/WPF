using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace authorization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int tries = 5;
        DateTime lastTime;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tries <= 0 && DateTime.Now > lastTime.AddSeconds(5))
            {
                tries = 5;
            }

            if (tries <= 0)
            {
                label3.Text = $"No tries :(";
                return;
            }

            string login = textBox1.Text;
            string password = textBox2.Text;

            var user = Authorization.GetAutorizatedUser(login, password);

            if (user is null)
            {
                label3.Text = $"Uncorrect login or password. Tries: {tries}";
                tries--;
            }
            else
            {
                lastTime = DateTime.Now;
                label3.Text = $"Successfully authorizated. {login}, {password}";
                tries = 5;
            }
        }
    }
}
