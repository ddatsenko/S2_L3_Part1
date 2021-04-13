﻿using System;
using System.Windows.Forms;

namespace TestList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (peopleLіst.Text.Length != 0){

                memberLіst.Items.Add(peopleLіst.Text);
            }
            else MessageBox.Show("Bиберіть елемент зі списку або введіть новий");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            while (memberLіst.CheckedIndices.Count > 0)
            memberLіst.Items.RemoveAt(memberLіst.CheckedIndices[0]);
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            memberLіst.Sorted = true;
        }
    }
}
