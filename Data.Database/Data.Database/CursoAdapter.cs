using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class CursoAdapter : Adapter
    {
       /* public List<Curso> GetAll()
        {
            List<Curso> cursos = new List<Curso>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdCurso = new SqlCommand("select * from cursos", sqlConn);
                SqlDataReader drCurso = cmdCurso.ExecuteReader();
                while (drCurso.Read())
                {
                    Curso c = new Curso();
                    c.ID = (int)drCurso["id_curso"];
                    c.IDComision = (int)drCurso["id_comision"];
                    c.IDMateria = (int)drCurso["id_materia"];
                    c.AnioCalendario = (int)drCurso["anio_calendario"];
                    c.Cupo = (int)drCurso["cupo"];
                    cursos.Add(c);
                }
                drCurso.Close();
                return cursos;
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Cursos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }*/

        public Business.Entities.Curso GetOne(int ID)
        {
            Curso c = new Curso();
            try
            {
                this.OpenConnection();
                SqlCommand cmdCurso = new SqlCommand("select * from cursos where id_curso=@id", sqlConn);
                cmdCurso.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drCurso = cmdCurso.ExecuteReader();
                if (drCurso.Read())
                {
                    c.ID = (int)drCurso["id_curso"];
                    c.IDComision = (int)drCurso["id_comision"];
                    c.IDMateria = (int)drCurso["id_materia"];
                    c.AnioCalendario = (int)drCurso["anio_calendario"];
                    c.Cupo = (int)drCurso["cupo"];
                }
                drCurso.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar el curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return c;
        }

        public void Delete(int ID)
        {
            try
            {
                //abrimos la conexion
                this.OpenConnection();
                //creame la sentencia sql y asignamos un valor al parametro
                SqlCommand cmdDelete = new SqlCommand("delete cursos where id_curso=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                //ejecutamos la sentencia sql
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Curso cur)
        {
            if (cur.State == BusinessEntity.States.Deleted)
            {
                this.Delete(cur.ID);
            }
            else if (cur.State == BusinessEntity.States.New)
            {
                this.Insert(cur);
            }
            else if (cur.State == BusinessEntity.States.Modified)
            {
                this.Update(cur);
            }
            cur.State = BusinessEntity.States.Unmodified;
        }

        protected void Update(Curso cur)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE cursos SET id_materia = @id_materia, id_comision=@id_comision, " +
                    "anio_calendario = @anio_calendario, cupo = @cupo " + "WHERE id_curso=@id", sqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = cur.ID;
                cmdSave.Parameters.Add("@id_materia", SqlDbType.Int).Value = cur.IDMateria;
                cmdSave.Parameters.Add("@id_comision", SqlDbType.Int).Value = cur.IDComision;
                cmdSave.Parameters.Add("@anio_calendario", SqlDbType.Int).Value = cur.AnioCalendario;
                cmdSave.Parameters.Add("@cupo", SqlDbType.Int).Value = cur.Cupo;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos del curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(Curso cur)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO cursos(id_materia,id_comision,anio_calendario,cupo) " +
                    "VALUES(@id_materia,@id_comision,@anio_calendario,@cupo) " +
                    "SELECT @@identity"
                    , sqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = cur.ID;
                cmdSave.Parameters.Add("@id_materia", SqlDbType.Int).Value = cur.IDMateria;
                cmdSave.Parameters.Add("@id_comision", SqlDbType.Int).Value = cur.IDComision;
                cmdSave.Parameters.Add("@anio_calendario", SqlDbType.Int).Value = cur.AnioCalendario;
                cmdSave.Parameters.Add("@cupo", SqlDbType.Int).Value = cur.Cupo;
                cur.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear un curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

        }
        public List<Curso> GetAll()
        {
            List<Curso> cursos = new List<Curso>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdCurso = new SqlCommand("sp_ListaCursos", sqlConn);
                cmdCurso.CommandType = CommandType.StoredProcedure;
                SqlDataReader drCurso = cmdCurso.ExecuteReader();
                while (drCurso.Read())
                {
                    Curso c = new Curso();
                    c.ID = (int)drCurso["id_curso"];
                    c.IDComision = (int)drCurso["id_comision"];
                    c.IDMateria = (int)drCurso["id_materia"];
                    c.AnioCalendario = (int)drCurso["anio_calendario"];
                    c.Cupo = (int)drCurso["cupo"];
                    c.DescComision = (string)drCurso["desc_comision"];
                    c.Desc_Materia = (string)drCurso["desc_materia"];
                    cursos.Add(c);
                }
                drCurso.Close();
                return cursos;
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Cursos con descripciones", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        }
}
