using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;
using System.Data.SqlClient;
namespace UI.Desktop
{
    public partial class GestionarAlumno : Form
    {
        public GestionarAlumno()
        {
            InitializeComponent();
            dgvGA.DataSource = fill_grid();
        }

        private void GestionarAlumno_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//Agregar
        {
            try
            {
                AlumnoInscripcion al = new AlumnoInscripcion(txtIdCurso.Text, txtNota.Text, txtCondicion.Text, false);
                DataTable dt = new DataTable();
                string agregar = "INSERT INTO AlumnoInscripciones(condicion, IDCurso, nota, disabled)" + "VALUES(@condicion, @IDCurso, @nota, @disable)";
                SqlCommand com1 = new SqlCommand(agregar, Conexion.Conectar());
                com1.Parameters.AddWithValue("@condicion", al.Condicion);
                com1.Parameters.AddWithValue("@IDCurso", al.IDCurso);
                com1.Parameters.AddWithValue("@nota", al.Nota);
                com1.Parameters.AddWithValue("@disabled", al.Disable);
                com1.ExecuteNonQuery();
                dgvGA.DataSource = fill_grid();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("No se pudo realizar la consulta, asegurese de haber completado todos los campos");
            }
        }
private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                try
                {
                    txtCondicion.Text = dgvGA.CurrentRow.Cells[0].Value.ToString();
                    txtIdAlumno.Text = dgvGA.CurrentRow.Cells[1].Value.ToString();
                    txtIdCurso.Text = dgvGA.CurrentRow.Cells[2].Value.ToString();
                    txtNota.Text = dgvGA.CurrentRow.Cells[3].Value.ToString();
                }

                catch { }
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)//consulta

        {
            try
            {
                Conexion.Conectar();
                AlumnoInscripcion al = new AlumnoInscripcion(txtIdAlumno.Text);
                DataTable dt = new DataTable();
                string consulta = "SELECT * FROM AlumnoInscripciones WHERE IDAlumno=@IDAlumno ";
                SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());
                cmd.Parameters.AddWithValue("@IDAlumno", al.IDAlumno);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvGA.DataSource = dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("No se pudo realizar la consulta, asegurese de haber completado todos los campos");
            }
        }
    private void btnBaja_Click(object sender, EventArgs e)//BAJA
        {
            try
            {
                Conexion.Conectar();
                AlumnoInscripcion al = new AlumnoInscripcion(txtIdAlumno.Text);
                DataTable dt = new DataTable();
                string baja = "UPDATE AlumnoInscripciones SET disabled=@disabled WHERE IDAlumno=@IDAlumno ";
                SqlCommand cmd = new SqlCommand(baja, Conexion.Conectar());
                cmd.Parameters.AddWithValue("@IDAlumno", al.IDAlumno);
                cmd.Parameters.AddWithValue("@disabled", true);
                cmd.ExecuteNonQuery();
                dgvGA.DataSource = fill_grid();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("No se pudo realizar la consulta, asegurese de haber completado todos los campos");
            }

        }
        public DataTable fill_grid()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string todo = "SELECT * FROM AlumnoInscripciones where disabled=@disabled";
            SqlCommand cmd = new SqlCommand(todo, Conexion.Conectar());
            cmd.Parameters.AddWithValue("@disabled", false);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        /*public DataTable fill_grida()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string todo = "SELECT * FROM AlumnoInscripciones";
            SqlCommand cmd = new SqlCommand(todo, Conexion.Conectar());
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }*/
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion.Conectar();
                AlumnoInscripcion al = new AlumnoInscripcion(txtIdCurso.Text, txtNota.Text, txtCondicion.Text, txtIdAlumno.Text);
                DataTable dt = new DataTable();
                string actualizar = "UPDATE AlumnoInscripciones SET  nota = @nota, condicion = @condicion, IDCurso = @IDCurso, disabled=@disabled WHERE IDAlumno = @IDAlumno";
                SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.Conectar());

                cmd2.Parameters.AddWithValue("@IDAlumno", al.IDAlumno);
                cmd2.Parameters.AddWithValue("@nota", al.Nota);
                cmd2.Parameters.AddWithValue("@condicion", al.Condicion);
                cmd2.Parameters.AddWithValue("@IDCurso", al.IDCurso);

                MessageBox.Show("Datos Actualizados");
                String title = "Academia";
                String message = "¿Desea a volver dar de alta al alumno?";
                MessageBoxButtons b1 = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, b1);
                if (result == DialogResult.Yes)
                {
                    cmd2.Parameters.AddWithValue("@disabled", false);
                }
                else { cmd2.Parameters.AddWithValue("@disabled", true); }
                cmd2.ExecuteNonQuery();
                dgvGA.DataSource = fill_grid();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                MessageBox.Show("No se pudo realizar la consulta, asegurese de haber completado todos los campos");
            }

        }
    }
}
