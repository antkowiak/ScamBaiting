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
        Random rnd = new Random();

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

            MessageBox.Show(this, messageText, "About Notepad", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            int cursorPosition = tb.SelectionStart;
            string text = tb.Text;

            for (int i = 0; i < tb.Text.Length; ++i)
                if (rnd.Next(1, 500) == 499)
                    text = ReplaceAtIndex(text, i);

            tb.Text = text;
            tb.Select(cursorPosition, 0);
            tb.ScrollToCaret();
        }

        private string ReplaceAtIndex(string text, int index)
        {
            char c = text[index];

            if (c >= '0' && c <= '9')
                c = (char)rnd.Next((int)'0', ((int)'9') + 1);
            else if (c >= 'A' && c <= 'Z')
                c = (char)rnd.Next((int)'A', ((int)'Z') + 1);
            else if (c >= 'a' && c <= 'z')
                c = (char)rnd.Next((int)'a', ((int)'z') + 1);

            var stringBuilder = new StringBuilder(text);
            stringBuilder[index] = c;
            return stringBuilder.ToString();
        }
    }
}
