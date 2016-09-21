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
        C_Connection sql;

        public Form_Psicologo(Menu m_Form, string connection_str)
        {
            InitializeComponent();
            this.main_Form = m_Form;
            this.sql = new C_Connection(connection_str);
        }

        private void Form_Psicologo_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.main_Form.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

                
        }

        private void btt_Alta_Psic_Click(object sender, EventArgs e)
        {
                string query = this.sql.DML[0, 0]
                +
                this.sql.Tables[0, 0]
                +
                this.sql.Tables[0, 1]
                +
                this.sql.DML[0, 1]
                + "('" +
                this.txt_Box_Nom
                + "', '" +
                this.txt_Apellido_Pat
                + "', '" +
                this.txt_Box_Apelli_Mat
                + "', '" +
                this.txt_Box_Dir
                + "', '" +
                this.txt_Box_Col
                + "', '" +
                this.txt_Box_Tel
                + "', '" +
                this.numericUpDown_Wor_Days.Value
                + "', '" +
                this.get_Sexo()
                + "', '" +
                this.numericUpDown_Pac_Limit.Value
                + "', '" +
                this.dateTime_Birth_Date.Value.Day
                + "-" +
                this.dateTime_Birth_Date.Value.Month
                + "-" +
                this.dateTime_Birth_Date.Value.Year
                + "')"
                ;
            if (this.sql.execute_Query(query) == true)
            {
                this.psicologoTableAdapter.Fill(this.marillac_DataSet.Psicologo);
                this.Reset_Controls();
            }
        }
        
        private char get_Sexo() {
            return (this.radioButt_Male.Checked) ? 'M' : 'F';
        }

        private void Reset_Controls()
        {
            foreach(Control c in this.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else if (c is RadioButton)
                {
                    if (((RadioButton)c).Checked)
                        ((RadioButton)c).Checked = false;
                }
                else if (c is NumericUpDown)
                    ((NumericUpDown)c).Value = 0;
                else if (c is DateTimePicker)
                    ((DateTimePicker)c).ResetText();
            }
        }

        private void psicologoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.psicologoBindingSource.EndEdit();
        }

        private void psicologoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.psicologoBindingSource.EndEdit();
        }

        private void psicologoBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.psicologoBindingSource.EndEdit();
        }

        private void Form_Psicologo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marillac_DataSet.Psicologo' table. You can move, or remove it, as needed.
            this.psicologoTableAdapter.Fill(this.marillac_DataSet.Psicologo);
        }
    }
}
