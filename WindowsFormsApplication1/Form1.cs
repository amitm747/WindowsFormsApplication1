﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbNameDataSet.tbl_name' table. You can move, or remove it, as needed.
            this.tbl_nameTableAdapter.Fill(this.dbNameDataSet.tbl_name);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbNameDataSet.tbl_name.Addtbl_nameRow(textBox1.Text);
            tbl_nameTableAdapter.Update(dbNameDataSet.tbl_name);
            textBox1.Text = "";
        }
    }
}
