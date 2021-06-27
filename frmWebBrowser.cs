using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class frmBrowser : Form
    {
        int TogMove;
        int MValX;
        int MValY;
        public frmBrowser()
        {
            InitializeComponent();
        }

        private void frmBrowser_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void txtBrowserUrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            brpWebBrowser.GoBack();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            brpWebBrowser.GoForward();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            brpWebBrowser.Stop();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            brpWebBrowser.Navigate(txtBrowserUrl.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            brpWebBrowser.Refresh();
        }

        private void brpWebBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            txtBrowserUrl.Text = brpWebBrowser.Url.ToString();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            brpWebBrowser.Navigate("http://www.brprotective.com/");
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblBRPClient_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void lblBRPClient_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void lblBRPClient_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void lblBRPClient_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void cmdMinimizeProgram_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
