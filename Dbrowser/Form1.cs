using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dbrowser
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Web Browser by Dylan");
        }
        //On click the web control will display the page requested by url
        private void button1_Click(object sender, EventArgs e)
        {
            NavigateToPage();
        }

        private void NavigateToPage()
        {
            toolStripStatusLabel1.Text = "Navigation has started";
            button1.Enabled = false;
            textBox1.Enabled = false;
            webBrowser1.Navigate(textBox1.Text);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)ConsoleKey.Enter)
            {
                NavigateToPage();
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            button1.Enabled = true;
            textBox1.Enabled = true;
            toolStripStatusLabel1.Text = "Navigation has started";


            foreach(HtmlElement image in webBrowser1.Document.Images)
            {
                image.SetAttribute("src", "data:image/jpeg;base64,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");
            }
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            if( e.CurrentProgress > 0 && e.MaximumProgress > 0)
            {
                toolStripProgressBar1.ProgressBar.Value = (int)(e.CurrentProgress * 100 / e.MaximumProgress);
            }
           

        }
    }
}
