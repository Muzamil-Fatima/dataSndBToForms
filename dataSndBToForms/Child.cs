using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataSndBToForms
{
    public partial class Child : Form
    {
        public Child()
        {
            InitializeComponent();
        }
        public Child(string name)
        {
            InitializeComponent();
            this.Name = name;
            txtName.Text = name;    
        }
        private void Child_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string SendData()
        {
            return "Age of " + Name + " is " + txtAge.Text;
        }
    }
}
