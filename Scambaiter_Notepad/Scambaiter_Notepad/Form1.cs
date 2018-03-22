using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scambaiter_Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://answers.microsoft.com/en-us/windows/forum/apps_windows_10");
        }

        private void aboutNotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string messageText =    "Microsoft Windows\n\n" +
                                    "Copyright Microsoft Corporation. All rights reserved.\n\n" +
                                    "The Windows 10 Home operating system and its user\n" +
                                    "interface are protected by trademark and other pending\n" +
                                    "or existing intellectual property rights in the United\n" +
                                    "States of America and other countries/regions.\n\n" +
                                    "This product is licensed under the\n" +
                                    "Microsoft Sofware License Terms\n\n";

            //MessageBox.Show(this, "Microsoft Notepad 1.0", "About Notepad", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            MessageBox.Show(this, messageText, "About Notepad", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
        }
    }
}
