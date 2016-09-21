using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class F_Beneficiario : Form
    {
        Form main_Form;

        private SqlConnection con;
        private SqlDataAdapter adapter;
        private string connectionString;

        public F_Beneficiario(Form m_Form)
        {
            InitializeComponent();
            this.main_Form = m_Form;

            con = new SqlConnection();
            connectionString = @"Data Source=DEVCRACK-PC\SQLEXPRESS;Initial Catalog=Marillac;Integrated Security=True";
            con.ConnectionString = connectionString;
            adapter = new SqlDataAdapter();

            dateTimePicker1.CustomFormat = "dd-MMMM-yyyy"; 
        }

        private void form_is_Closing(object sender, FormClosingEventArgs e)
        {
            this.main_Form.Show();
        }

        private void F_Beneficiario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'marillacDataSet.CuotaHijo' Puede moverla o quitarla según sea necesario.
            this.cuotaHijoTableAdapter.Fill(this.marillacDataSet.CuotaHijo);
            // TODO: esta línea de código carga datos en la tabla 'marillacDataSet.Beneficiario' Puede moverla o quitarla según sea necesario.
            this.beneficiarioTableAdapter.Fill(this.marillacDataSet.Beneficiario);
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            this.main_Form.Show();
            this.Close();
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO Persona.Beneficiario(nombre, paterno, materno, direccion, colonia, telefono, sexo, fechaNacimiento) VALUES('"+nombre.Text+"', '"+paterno.Text+"', '"+materno.Text+"', '"+direccion.Text+"', '"+colonia.Text+"',"+telefono.Text+", '"+sexo.Text+"', '"+dateTimePicker1.Value.Year+"-"+dateTimePicker1.Value.Month+"-"+dateTimePicker1.Value.Day+"')";
                adapter.InsertCommand = new SqlCommand(query, con);
                adapter.InsertCommand.ExecuteNonQuery();
                limpiarTextBox();
                con.Close();

                this.beneficiarioTableAdapter.Fill(this.marillacDataSet.Beneficiario);

            }
            catch(Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void limpiarTextBox()
        {
            nombre.Clear();
            paterno.Clear();
            materno.Clear();
            direccion.Clear();
            colonia.Clear();
            telefono.Clear();
            sexo.Clear();
            dateTimePicker1.Value = new DateTime(1990, 01, 01);
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            Int64 idEliminar;

            if(dataGridView1.SelectedRows.Count!=0)
            {
                idEliminar = Convert.ToInt64(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                try
                {
                    con.Open();
                    string query = "DELETE FROM Persona.Beneficiario WHERE idBeneficiario="+idEliminar;
                    adapter.InsertCommand = new SqlCommand(query, con);
                    adapter.InsertCommand.ExecuteNonQuery();
                    con.Close();

                    this.beneficiarioTableAdapter.Fill(this.marillacDataSet.Beneficiario);
                    limpiarTextBox();
                }
                catch(Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                nombre.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value);
                paterno.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value);
                materno.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value);
                direccion.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value);
                colonia.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[6].Value);
                telefono.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[7].Value);
                sexo.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[8].Value);
                dateTimePicker1.Value = DateTime.Parse(Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[9].Value));
            }
            catch { }
        }

        private void botonModificar_Click(object sender, EventArgs e)
        {
            Int64 idModificar;

            if(dataGridView1.SelectedRows.Count!=0)
            {
                idModificar = Convert.ToInt64(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());

                try
                {
                    con.Open();
                    string query = "UPDATE Persona.Beneficiario SET nombre='"+nombre.Text+"', paterno='"+paterno.Text+"', materno='"+materno.Text+"', direccion='"+direccion.Text+"', colonia='"+colonia.Text+"', telefono="+telefono.Text+", sexo='"+sexo.Text+ "', fechaNacimiento='" + dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day + "' WHERE idBeneficiario=" + idModificar;
                    adapter.InsertCommand=new SqlCommand(query,con);
                    adapter.InsertCommand.ExecuteNonQuery();
                    con.Close();

                    this.beneficiarioTableAdapter.Fill(this.marillacDataSet.Beneficiario);
                    limpiarTextBox();

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    con.Close();
                }
            }
        }
    }
}
