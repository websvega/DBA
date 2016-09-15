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
    }
}
