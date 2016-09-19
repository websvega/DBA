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
    public partial class F_Beneficiario : Form
    {
        Form main_Form;
        public F_Beneficiario(Form m_Form)
        {
            InitializeComponent();
            this.main_Form = m_Form;
        }

        private void form_is_Closing(object sender, FormClosingEventArgs e)
        {
            this.main_Form.Show();
        }

        private void F_Beneficiario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'marillacDataSet.Beneficiario' Puede moverla o quitarla según sea necesario.
            this.beneficiarioTableAdapter.Fill(this.marillacDataSet.Beneficiario);

        }
    }
}
