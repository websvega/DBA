using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Menu : Form
    {
        Image logoMarillac;

        public Menu()
        {
            cargarImagenes();
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void cargarImagenes()
        {
            string path = Directory.GetCurrentDirectory();
            path += @"\Imagenes\logoMarillac.png";
            logoMarillac = Image.FromFile(path);
        }

        private void Menu_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(logoMarillac, new Point((this.Width / 2) - 190, 10));
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hola");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Beneficiarios newMDIChild = new Beneficiarios();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        
        }
    }
}
