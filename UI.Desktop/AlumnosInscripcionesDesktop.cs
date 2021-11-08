using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class AlumnosInscripcionesDesktop : ApplicationForm
    {
        private Business.Entities.AlumnoInscripcion _AIActual;
        public Business.Entities.AlumnoInscripcion AIActual { get=>_AIActual; set=>this._AIActual=value; }


        private Business.Entities.Persona _entity;
        public Persona Entity { get => _entity; set => _entity = value; }

        private void AlumnosInscripcionesDesktop_Load(object sender, EventArgs e)
        {
            CCMLogic c = new CCMLogic();
            if (Entity.TipoPersona == 1) { 
            cbCursos.DataSource = c.GetAll(Entity.IDPlan);
            cbCursos.DisplayMember = "Desc";
            cbCursos.ValueMember = "Id_Curso";
            cbCondicion.SelectedIndex = 0;
            }
            else
            {   
                cbCursos.DataSource = c.GetAll();
                cbCursos.DisplayMember = "Desc";
                cbCursos.ValueMember = "Id_Curso";
                cbCondicion.SelectedIndex = 0;
            }
            
            if (Modo == ModoForm.Alta)
            {
                this.txtIdAlum.Text = Entity.ID.ToString();
                if (this.Entity.TipoPersona == 2)
                {
                    txtIdAlum.Enabled = true;
                }else
                {
                    txtIdAlum.Enabled = false;
                }
                cbCondicion.Visible = false;
                cbNota.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
            }
            else if (Modo == ModoForm.Modificacion)
            {
                txtIdAlum.Enabled = false;
                cbCursos.Enabled = false;
            }
            else { txtIdAlum.Enabled = false;
                cbCondicion.Enabled = false;
                cbCursos.Enabled = false;
                cbNota.Enabled = false;
            }
        }
        public AlumnosInscripcionesDesktop()
        {
            InitializeComponent();
        }
        public AlumnosInscripcionesDesktop(ModoForm modo) : this()
        {
            
            this.Modo = modo;
        }
        public AlumnosInscripcionesDesktop(Persona per,int ida,int idc,ModoForm modo):this()
        {
            this.Modo = modo;
            AlumnoInscripcionLogic ail = new AlumnoInscripcionLogic();
            AIActual = ail.GetOne(ida,idc);
            this.MapearDeDatos();
            Entity = per;
        }

        public AlumnosInscripcionesDesktop(Persona per, ModoForm modo) : this() {
            Entity = per;
            this.Modo = modo;
        }
        public override void MapearDeDatos()
        {
            //this.txtID.Text = this.AIActual.ID.ToString();
            this.txtIdAlum.Text = this.AIActual.IDAlumno.ToString();
            /*int a=0;
                for (int i = 0; i < 4; i++)
                {
                string ab = cbCondicion.Items[i].ToString();
                    if ((ab.Equals(AIActual.Condicion)))
                    {
                        a = i;
                    }
                }
            cbCondicion.DisplayMember = cbCondicion.Items[a].ToString();*/
            this.cbCondicion.SelectedValue = this.AIActual.Condicion.ToString();
            this.cbNota.SelectedIndex = this.AIActual.Nota-1;
            switch (this.Modo)
            {
                case ModoForm.Alta:
                    {
                        this.btnAceptar.Text = "Guardar";
                        break;
                    }
                case ModoForm.Modificacion:
                    {
                        this.btnAceptar.Text = "Guardar";
                        break;
                    }
                case ModoForm.Baja:
                    {
                        this.btnAceptar.Text = "Eliminar";
                        break;
                    }
                case ModoForm.Consulta:
                    {
                        this.btnAceptar.Text = "Aceptar";
                        break;
                    }
                default:
                    {
                        this.btnAceptar.Text = "Guardar";
                        break;
                    }
            }
        }

        public override void MapearADatos()
        {
            switch(Modo)
            {
                case ModoForm.Alta:
                    {
                        this.txtIdAlum.Text = Entity.ID.ToString();
                        AlumnoInscripcion ai = new AlumnoInscripcion();
                        AIActual = ai;
                        this.AIActual.IDAlumno = Entity.ID;
                        this.AIActual.IDCurso = int.Parse(cbCursos.SelectedValue.ToString());
                        this.AIActual.Condicion = cbCondicion.SelectedItem.ToString();
                        AIActual.State = BusinessEntity.States.New;
                        break;
                    }
                case ModoForm.Modificacion:
                    {
                       // this.AIActual.ID = AIActual.ID;//int.Parse(txtID.Text);
                        this.AIActual.IDAlumno = int.Parse(txtIdAlum.Text);
                        this.AIActual.IDCurso = int.Parse(cbCursos.SelectedValue.ToString());
                        this.AIActual.Condicion = cbCondicion.SelectedItem.ToString();
                        this.AIActual.Nota = cbNota.SelectedIndex+1;
                        AIActual.State = BusinessEntity.States.Modified;
                        break;
                    }
                case ModoForm.Baja:
                    {
                        //this.AIActual.ID = int.Parse(txtID.Text);
                        this.AIActual.IDAlumno = int.Parse(txtIdAlum.Text);
                        this.AIActual.IDCurso = int.Parse(cbCursos.SelectedValue.ToString());
                        this.AIActual.Condicion = cbCondicion.SelectedItem.ToString();
                        this.AIActual.Nota = cbNota.SelectedIndex + 1;
                        AIActual.State = BusinessEntity.States.Deleted;
                        break;
                    }
            }
        }
        public override void GuardarCambios()
        {
            MapearADatos();
            AlumnoInscripcionLogic ail = new AlumnoInscripcionLogic();
            ail.Save(this.AIActual);
        }

        private void tp2netDataSet1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&& !char.IsDigit(e.KeyChar)&&(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            PersonaLogic per = new PersonaLogic();
            Persona a = per.GetOne(int.Parse(txtIdAlum.Text));
            if(Entity.TipoPersona == 2){ 
            if(a.TipoPersona==1) 
            {
                if (MessageBox.Show("Presiones si para confirmar la inscripcion", "Confirmar Inscripcion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.GuardarCambios();
                    this.Close();
                }
            }
            else { MessageBox.Show("El Alumno no existe", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            if (MessageBox.Show("Presiones si para confirmar la inscripcion", "Confirmar Inscripcion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.GuardarCambios();
                this.Close();
            }


        }

        private void cbCursos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtIdAlum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
