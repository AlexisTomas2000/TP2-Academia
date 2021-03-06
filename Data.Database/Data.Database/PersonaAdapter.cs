using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;
namespace Data.Database
{
    public class PersonaAdapter : Adapter
    {
        Exception e;
        public List<Persona> GetAllP()
        {
            List<Persona> Personas = new List<Persona>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdPersonas = new SqlCommand("select * from personas where tipo_persona=2", sqlConn);
                SqlDataReader drPersonas = cmdPersonas.ExecuteReader();
                while (drPersonas.Read())
                {
                    Persona per = new Persona();
                    per.ID = (int)drPersonas["id_persona"];
                    per.Nombre = (string)drPersonas["nombre"];
                    per.Apellido = (string)drPersonas["apellido"];
                    per.Direccion = (string)drPersonas["direccion"];
                    per.EMail = (string)drPersonas["email"];
                    per.Telefono = (string)drPersonas["telefono"];
                    per.FechaNacimiento = (DateTime)drPersonas["fecha_nac"];
                    per.Legajo = (int)drPersonas["legajo"];
                    per.TipoPersona = (int)drPersonas["tipo_persona"];
                    per.IDPlan = (int)drPersonas["id_plan"];
                    Personas.Add(per);
                }
                drPersonas.Close();
                return Personas;
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de profesores", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public List<Persona> GetAllA()
        {
            List<Persona> Personas = new List<Persona>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdPersonas = new SqlCommand("select * from personas where tipo_persona=1", sqlConn);
                SqlDataReader drPersonas = cmdPersonas.ExecuteReader();
                while (drPersonas.Read())
                {
                    Persona per = new Persona();
                    per.ID = (int)drPersonas["id_persona"];
                    per.Nombre = (string)drPersonas["nombre"];
                    per.Apellido = (string)drPersonas["apellido"];
                    per.Direccion = (string)drPersonas["direccion"];
                    per.EMail = (string)drPersonas["email"];
                    per.Telefono = (string)drPersonas["telefono"];
                    per.FechaNacimiento = (DateTime)drPersonas["fecha_nac"];
                    per.Legajo = (int)drPersonas["legajo"];
                    per.TipoPersona = (int)drPersonas["tipo_persona"];
                    per.IDPlan = (int)drPersonas["id_plan"];
                    Personas.Add(per);
                }
                drPersonas.Close();
                return Personas;
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de profesores", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public Business.Entities.Persona GetOne(int ID)
        {
            Persona per = new Persona();
            try
            {
                this.OpenConnection();
                SqlCommand cmdPersonas = new SqlCommand("select * from personas where id_persona=@id", sqlConn);
                cmdPersonas.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drPersonas = cmdPersonas.ExecuteReader();
                if (drPersonas.Read())
                {
                    per.ID = (int)drPersonas["id_persona"];
                    per.Nombre = (string)drPersonas["nombre"];
                    per.Apellido = (string)drPersonas["apellido"];
                    per.Direccion = (string)drPersonas["direccion"];
                    per.EMail = (string)drPersonas["email"];
                    per.Telefono = (string)drPersonas["telefono"];
                    per.FechaNacimiento = (DateTime)drPersonas["fecha_nac"];
                    per.Legajo = (int)drPersonas["legajo"];
                    per.TipoPersona = (int)drPersonas["tipo_persona"];
                    per.IDPlan = (int)drPersonas["id_plan"];
                }
                drPersonas.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la persona", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return per;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete personas where id_persona=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar la persona", Ex);
                e = Ex;
                throw ExcepcionManejada;
            }
            finally
            {
                this.MsgCatch();
                this.CloseConnection();
            }
        }

        public Exception MsgCatch()
        {
            return e;
        }
        public void Save(Persona persona)
        {
            if (persona.State == BusinessEntity.States.Deleted)
            {
                this.Delete(persona.ID);
            }
            else if (persona.State == BusinessEntity.States.New)
            {
                this.Insert(persona);
            }
            else if (persona.State == BusinessEntity.States.Modified)
            {
                this.Update(persona);
            }
            persona.State = BusinessEntity.States.Unmodified;
        }

        protected void Update(Persona persona)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE personas SET apellido = @apellido, nombre=@nombre, " +
                    "direccion = @direccion, email = @email, telefono = @telefono, fecha_nac = @fecha_nac , legajo=@legajo, tipo_persona=@tipo_persona,id_plan=@id_plan " +
                    "WHERE id_persona=@id", sqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = persona.ID;
                cmdSave.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = persona.Apellido;
                cmdSave.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = persona.Nombre;
                cmdSave.Parameters.Add("@direccion", SqlDbType.VarChar,50).Value = persona.Direccion;
                cmdSave.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = persona.EMail;
                cmdSave.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = persona.Telefono;
                cmdSave.Parameters.Add("@fecha_nac", SqlDbType.DateTime, 50).Value = persona.FechaNacimiento;
                cmdSave.Parameters.Add("@legajo", SqlDbType.Int).Value = persona.Legajo;
                cmdSave.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = persona.TipoPersona;
                cmdSave.Parameters.Add("@id_plan", SqlDbType.Int).Value = persona.IDPlan;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos de la persona", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(Persona persona)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO personas(nombre,apellido,direccion,email,telefono,fecha_nac,legajo,tipo_persona,id_plan) " +
                    "VALUES(@nombre,@apellido,@direccion,@email,@telefono,@fecha_nac,@legajo,@tipo_persona,@id_plan) " +
                    "SELECT @@identity"
                    , sqlConn);
                cmdSave.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = persona.Apellido;
                cmdSave.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = persona.Nombre;
                cmdSave.Parameters.Add("@direccion", SqlDbType.VarChar,50).Value = persona.Direccion;
                cmdSave.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = persona.EMail;
                cmdSave.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = persona.Telefono;
                cmdSave.Parameters.Add("@fecha_nac", SqlDbType.DateTime, 50).Value = persona.FechaNacimiento;
                cmdSave.Parameters.Add("@legajo", SqlDbType.Int).Value = persona.Legajo;
                cmdSave.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = persona.TipoPersona;
                cmdSave.Parameters.Add("@id_plan", SqlDbType.Int).Value = persona.IDPlan;
                persona.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear una persona", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public Business.Entities.Persona Ult()
        {
            Persona per = new Persona();
            try
            {
                this.OpenConnection();
                SqlCommand cmdPersonas = new SqlCommand("select * from personas where id_persona=(select max(id_persona) From personas)", sqlConn);
                SqlDataReader drPersonas = cmdPersonas.ExecuteReader();
                if (drPersonas.Read())
                {
                    per.ID = (int)drPersonas["id_persona"];
                    per.Nombre = (string)drPersonas["nombre"];
                    per.Apellido = (string)drPersonas["apellido"];
                    per.Direccion = (string)drPersonas["direccion"];
                    per.EMail = (string)drPersonas["email"];
                    per.Telefono = (string)drPersonas["telefono"];
                    per.FechaNacimiento = (DateTime)drPersonas["fecha_nac"];
                    per.Legajo = (int)drPersonas["legajo"];
                    per.TipoPersona = (int)drPersonas["tipo_persona"];
                    per.IDPlan = (int)drPersonas["id_plan"];
                }
                drPersonas.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la persona", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return per;
        }
    }
}
