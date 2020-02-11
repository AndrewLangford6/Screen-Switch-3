using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Screen_Switch_2
{
    public partial class Form1 : Form
    {

        public static string beanID = "Bean";
        public static string beanPass = "Bean";

        public Form1()
        {
            InitializeComponent();
            // Create an instance of the MainScreen
            MainScreen ms = new MainScreen();
            SecondScreen ss = new SecondScreen();

            // Add the User Control to the Form
            this.Controls.Add(ms);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
    }
}
