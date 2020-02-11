using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Screen_Switch_2
{
    public partial class MainScreen : UserControl
    {


        SecondScreen ss = new SecondScreen();

        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        public void Button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == Form1.beanID && textBox2.Text == Form1.beanPass)
            {
                // f is the form that this control is on - ("this" is the current User Control)
                Form f = this.FindForm();
                f.Controls.Remove(this);

                //Now you can add your new User Control to the Form and display it.The code will be similar to the code in the previous section however we are now using “f” instead of “this” to represent the form since in this instance “this” refers the current User Control.

                // Create an instance of the SecondScreen


                // Add the User Control to the Form
                f.Controls.Add(ss);
            }
            else
            {
                Refresh();
                textBox1.Text = "NO";
                Thread.Sleep(1000);
                Refresh();
                textBox1.Text = "bEANS";
                Thread.Sleep(1000);
                Refresh();
                textBox1.Text = "";
                Refresh();

            }
           


        }
    }
}
