using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using CultureResources;

namespace CultureExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AplicarIdioma();
        }

        private void AplicarIdioma()
        {
            button1.Text = StringResources.ButtonLabel1;
            button2.Text = StringResources.ButtonLabel2;
            button3.Text = StringResources.ButtonLabel3;
            button4.Text = StringResources.ButtonLabel4;
            button5.Text = StringResources.ButtonLabel5;
            this.Text = StringResources.WindowTitle;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo((string)listBox1.SelectedItem);
            AplicarIdioma();
        }
    }
}
