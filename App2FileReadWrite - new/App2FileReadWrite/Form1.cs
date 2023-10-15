using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App2FileReadWrite
{
    public partial class Form1 : Form
    {
        File file1 = new File(); // the file class is instantiated 
        public Form1()
        {
            InitializeComponent();
        }

        private void bntRead_Click(object sender, EventArgs e)
        {
           
           
            file1.FilePath = txtFilePath.Text;
            
            txtOutput.Text = file1.ReadFile(); // the read method is called
        }

        private void bntWrite_Click(object sender, EventArgs e)
        {
           
           
            file1.FilePath = txtFilePath.Text;
            txtOutput.Text = file1.WriteFile(txtOutput.Text); // the write method is called 
            MessageBox.Show(file1.FilePath); //displays file path
        }
    }
}
