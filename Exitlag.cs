using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management.Automation;
using Microsoft.Win32;
using System.Security.Cryptography;
using System.Windows.Input;
using System.Security.Principal;
using System.Runtime.InteropServices;
using System.IO;

namespace WindowsFormsApp1.Forms
{
    public partial class Formamd : Form
    {
        public Formamd()
        {
            InitializeComponent();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            {
                string currentDirectory = Directory.GetCurrentDirectory();


                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "LosslessScaling.exe",

                };

                try
                {
                    using (Process process = Process.Start(startInfo))
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao executar o Power Settings Explorer: " + ex.Message);
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.exitlag.com/refer/10133657");
        }
    }
}
