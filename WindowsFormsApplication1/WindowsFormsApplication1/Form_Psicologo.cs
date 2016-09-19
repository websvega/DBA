using System;
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
    public partial class Form_Psicologo : Form
    {
        /// <summary>
        /// Forma Padre
        /// </summary>
        Menu main_Form;

        public Form_Psicologo(Menu m_Form)
        {
            InitializeComponent();
            this.main_Form = m_Form;
        }

        private void Form_Psicologo_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.main_Form.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
