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

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.Image = global::WindowsFormsApplication1.Properties.Resources.beneficiarios1;
        }

        private void button1_MouseDown_1(object sender, MouseEventArgs e)
        {
            button1.Image = global::WindowsFormsApplication1.Properties.Resources.beneficiarios2;
        }

        private void button1_MouseUp_1(object sender, MouseEventArgs e)
        {
            button1.Image = global::WindowsFormsApplication1.Properties.Resources.beneficiarios1;
        }
    }
}
