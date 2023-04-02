using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Spotifdp
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Process.Start("curl", "parrot.live");
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            Process.Start("powershell.exe", "iwr -useb https://raw.githubusercontent.com/spicetify/spicetify-cli/master/install.ps1 | iex\r\niwr -useb https://raw.githubusercontent.com/spicetify/spicetify-marketplace/main/resources/install.ps1 | iex");            
            MessageBox.Show("Veuillez Patienter et ne pas fermer Windows Powershell");
            Environment.Exit(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
