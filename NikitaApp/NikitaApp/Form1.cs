using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NikitaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddObject_Click(object sender, EventArgs e)
        {
            addObject1.BringToFront();
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            parskats1.BringToFront();
        }
    }
}
