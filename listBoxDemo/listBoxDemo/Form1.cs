using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] g12Advisers = { "tesla", "Ford", "Coleman", "Frasco", "Channel", "Goldman", "Bourdian", "Ramsy" };
        int[] numberOfStudents = { 23, 45, 67, 78, 34, 45, 56, 67 };

        
        
        private void lstSections_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstG12Adviser.Items.AddRange(g12Advisers);
            if (lstSections.SelectedIndex == 0)
            {
                lblClassAdviser.Text = "Mr. Cativo";
            }

            lstG12Adviser.Items.AddRange(g12Advisers);
            if (lstSections.SelectedIndex == 1)
            {
                lblClassAdviser.Text = "Mrs. Mallari";
            }

            lstG12Adviser.Items.AddRange(g12Advisers);
            if (lstSections.SelectedIndex == 2)
            {
                lblClassAdviser.Text = "Mr. Samaniego";
            }

            lstG12Adviser.Items.AddRange(g12Advisers);
            if (lstSections.SelectedIndex == 3)
            {
                lblClassAdviser.Text = "Mr. Valencia";
            }

            lstG12Adviser.Items.AddRange(g12Advisers);
            if (lstSections.SelectedIndex == 4)
            {
                lblClassAdviser.Text = "Mr. Jabulin";
            }
        }

        private void lstG12Adviser_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lstG12Adviser.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < g12Advisers.Length)
            {
                lblG12Adviser.Text = g12Advisers[selectedIndex];
                lblNumStudent.Text = numberOfStudents[selectedIndex].ToString();

            }
        }

        public void loadG12ClasAdviser()
        {
            lstG12Adviser.Items.AddRange(g12Advisers);
        }

        private void frmDemo_Load(object sender, EventArgs e)
        {
            loadG12ClasAdviser();


        }
    }

}
