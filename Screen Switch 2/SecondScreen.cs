using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Screen_Switch_2
{
    public partial class SecondScreen : UserControl
    {
        public SecondScreen()
        {
            InitializeComponent();
        }

        private void SecondScreen_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            MainScreen ms = new MainScreen();

            f.Controls.Add(ms);
            f.Controls.Remove(this);
        }
    }
}
