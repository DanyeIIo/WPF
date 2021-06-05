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
    public partial class Space : Form
    {
        public Space()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!PlaneAuthorization.CheckAuthorization())
            {
                var impostors = PlaneAuthorization.ImpostorPlanes();
                label1.Text = string.Empty;

                foreach (var impostor in impostors)
                {
                    label1.Text += impostor.PassportID.ToString() + '\n';
                }
            }
        }
    }
}
