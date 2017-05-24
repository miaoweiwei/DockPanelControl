using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DockPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            Form2 form21 = new Form2();
            Form2 form22 = new Form2();
            Form2 form23 = new Form2();
            form2.Show(this.dockPanel1);
            form21.Show(this.dockPanel1);
            form22.Show(this.dockPanel1);
            form23.Show(this.dockPanel1);
        }
    }
}
