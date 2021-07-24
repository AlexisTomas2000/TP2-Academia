using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;
using System.Data.SqlClient;

namespace UI.Desktop
{
    public partial class GestionarUsuarios : Form
    {
        public GestionarUsuarios()
        {
            InitializeComponent();
            
            dgvUsu.DataSource = fill_grid1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion.Conectar();
                Usuario usu = new Usuario();
                usu.NombreUsuario = txtNusu.Text;
                usu.Clave = txtClave.Text;
                usu.Nombre = txtNombre.Text;
                usu.Apellido = txtApellido.Text;
                usu.Email = txtEmail.Text;
                usu.Habilitado = chkHabilitado.Checked;
                DataTable dt = new DataTable();
                string agregar = "insert into Usuarios(nombreUsuario, clave, nombre, apellido, email, habilitado) values(@nombreUsuario, @clave, @nombre, @apellido, @email, @habilitado)";
                SqlCommand com1 = new SqlCommand(agregar, Conexion.Conectar());
                

                com1.Parameters.AddWithValue("@nombreUsuario", usu.NombreUsuario);
                com1.Parameters.AddWithValue("@clave", usu.Clave);
                com1.Parameters.AddWithValue("@nombre", usu.Nombre);
                com1.Parameters.AddWithValue("@apellido", usu.Apellido);
                com1.Parameters.AddWithValue("@email", usu.Email);
                com1.Parameters.AddWithValue("@habilitado", usu.Habilitado);

                MessageBox.Show("Usuario dado de alta con exito");
                com1.ExecuteNonQuery();
                dgvUsu.DataSource = fill_grid1();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("No se pudo realizar la consulta, asegurese de haber completado todos los campos");
            }
        }
        public DataTable fill_grid1()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string todo = "SELECT * FROM Usuarios ";
            SqlCommand cmd = new SqlCommand(todo, Conexion.Conectar());
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        private void chkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            
                string text = txtClave.Text;
                string text1 = txtConfClave.Text;
                if (chkMostrar.Checked)
                {
                    txtClave.UseSystemPasswordChar = false;
                    txtClave.Text = text;
                    txtConfClave.UseSystemPasswordChar = false;
                    txtConfClave.Text = text1;
                }
                else
                {
                    txtClave.UseSystemPasswordChar = true;
                    txtClave.Text = text;
                    txtConfClave.UseSystemPasswordChar = true;
                    txtConfClave.Text = text1;
                }
            
        }

        private void chkHabilitado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion.Conectar();
                Usuario usu = new Usuario();
                usu.NombreUsuario = txtNusu.Text;
                usu.Clave = txtClave.Text;
                usu.Nombre = txtNombre.Text;
                usu.Apellido = txtApellido.Text;
                usu.Email = txtEmail.Text;
                usu.Habilitado = chkHabilitado.Checked;
                DataTable dt = new DataTable();
                string actualizar = "UPDATE Usuarios SET  clave = @clave, nombre = @nombre, apellido = @apellido, email=@email,habilitado=@habilitado WHERE nombreUsuario = @nombreUsuario";
                SqlCommand com1 = new SqlCommand(actualizar, Conexion.Conectar());

                com1.Parameters.AddWithValue("@nombreUsuario", usu.NombreUsuario);
                com1.Parameters.AddWithValue("@clave", usu.Clave);
                com1.Parameters.AddWithValue("@nombre", usu.Nombre);
                com1.Parameters.AddWithValue("@apellido", usu.Apellido);
                com1.Parameters.AddWithValue("@email", usu.Email);
                com1.Parameters.AddWithValue("@habilitado", usu.Habilitado);
                com1.ExecuteNonQuery();
                MessageBox.Show("Datos Actualizados");


                dgvUsu.DataSource = fill_grid1();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("No se pudo modificar, verifique si lleno todos los campos");
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            Usuario usu = new Usuario();
            usu.NombreUsuario = txtNusu.Text;
            DataTable dt = new DataTable();
            String baja = "UPDATE Usuarios SET habilitado=@habilitado WHERE nombreUsuario=@nombreUsuario";
            SqlCommand com = new SqlCommand(baja, Conexion.Conectar());
            com.Parameters.AddWithValue("@nombreUsuario", usu.NombreUsuario );
            com.Parameters.AddWithValue("@habilitado", false);
            com.ExecuteNonQuery();
            MessageBox.Show("Usuario dado de baja con exito");
            dgvUsu.DataSource = fill_grid1();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            Usuario usu = new Usuario();
            usu.NombreUsuario = txtNusu.Text;
            
            DataTable dt = new DataTable();
            String consulta = "Select * From Usuarios WHERE nombreUsuario=@nombreUsuario";
            SqlCommand command = new SqlCommand(consulta, Conexion.Conectar());
            command.Parameters.AddWithValue("@nombreUsuario", usu.NombreUsuario);
            command.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            dgvUsu.DataSource = dt;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNusu.Clear();
            txtClave.Clear();
            txtConfClave.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtEmail.Clear();
        }
    }
}
