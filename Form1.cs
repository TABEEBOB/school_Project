using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Michael Arrey
 * C#
 * Lab2. 25 August 2020.
 * I wrote this code myself.
 */
namespace schoolProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            Course course1;
            course1 = new Course("C#", 2342);
            course1.displayCourse();
        }
    }
}
