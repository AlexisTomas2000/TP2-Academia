using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database
{
    public class AlumnoInscripcionAdapter:Adapter
    {
        public List<AlumnoInscripcion> GetAll()
        {
            List<AlumnoInscripcion> AlumnoInscrip = new List<AlumnoInscripcion>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdAlIns = new SqlCommand("select * from alumnos_inscripciones", sqlConn);
                SqlDataReader drAlIns = cmdAlIns.ExecuteReader();
                while (drAlIns.Read())
                {
                    AlumnoInscripcion AI = new AlumnoInscripcion();
                    AI.ID = (int)drAlIns["id_inscripcion"];
                    AI.IDAlumno = (int)drAlIns["id_alumno"];
                    AI.IDCurso = (int)drAlIns["id_curso"];
                    AI.Condicion = (string)drAlIns["condicion"];
                    AI.Nota = (int)drAlIns["nota"];
                    AlumnoInscrip.Add(AI);
                }
                drAlIns.Close();
                return AlumnoInscrip;
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Alumnos Inscriptos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public List<AlumnoInscripcion> GetAllA(int idA)
        {
            List<AlumnoInscripcion> AlumnoInscrip = new List<AlumnoInscripcion>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdAlIns = new SqlCommand("select * from alumnos_inscripciones where id_alumno = @idA", sqlConn);
                cmdAlIns.Parameters.Add("@idA", SqlDbType.Int).Value = idA;
                SqlDataReader drAlIns = cmdAlIns.ExecuteReader();
                while (drAlIns.Read())
                {
                    AlumnoInscripcion AI = new AlumnoInscripcion();
                    AI.ID = (int)drAlIns["id_inscripcion"];
                    AI.IDAlumno = (int)drAlIns["id_alumno"];
                    AI.IDCurso = (int)drAlIns["id_curso"];
                    AI.Condicion = (string)drAlIns["condicion"];
                    AI.Nota = (int)drAlIns["nota"];
                    AlumnoInscrip.Add(AI);
                }
                drAlIns.Close();
                return AlumnoInscrip;
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Alumnos Inscriptos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public List<AlumnoInscripcion> GetAllD(int idDoc)
        {
            List<AlumnoInscripcion> AlumnoInscrip = new List<AlumnoInscripcion>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdAlIns = new SqlCommand("SELECT alumnos_inscripciones.* FROM alumnos_inscripciones INNER JOIN "+
                         "cursos ON alumnos_inscripciones.id_curso = cursos.id_curso INNER JOIN docentes_cursos ON cursos.id_curso = docentes_cursos.id_curso INNER JOIN "+
                         "personas ON docentes_cursos.id_docente = personas.id_persona where personas.id_persona = @idDoc", sqlConn);
                cmdAlIns.Parameters.Add("@idDoc", SqlDbType.Int).Value = idDoc;
                SqlDataReader drAlIns = cmdAlIns.ExecuteReader();
                while (drAlIns.Read())
                {
                    AlumnoInscripcion AI = new AlumnoInscripcion();
                    AI.ID = (int)drAlIns["id_inscripcion"];
                    AI.IDAlumno = (int)drAlIns["id_alumno"];
                    AI.IDCurso = (int)drAlIns["id_curso"];
                    AI.Condicion = (string)drAlIns["condicion"];
                    AI.Nota = (int)drAlIns["nota"];
                    AlumnoInscrip.Add(AI);
                }
                drAlIns.Close();
                return AlumnoInscrip;
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Alumnos Inscriptos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public Business.Entities.AlumnoInscripcion GetOne(int ID)
        {
            AlumnoInscripcion AI = new AlumnoInscripcion();
            try
            {
                this.OpenConnection();
                SqlCommand cmdAlIns = new SqlCommand("select * from alumnos_inscripciones where id_inscripcion=@id", sqlConn);
                cmdAlIns.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drAlIns = cmdAlIns.ExecuteReader();
                if (drAlIns.Read())
                {
                    AI.ID = (int)drAlIns["id_inscripcion"];
                    AI.IDAlumno = (int)drAlIns["id_alumno"];
                    AI.IDCurso = (int)drAlIns["id_curso"];
                    AI.Condicion = (string)drAlIns["condicion"];
                    AI.Nota = (int)drAlIns["nota"];
                }
                drAlIns.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar el Alumno Inscripto", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return AI;
        }
      
        public void Delete(int IDA,int IDC,int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete alumnos_inscripciones where id_alumno=@ida and id_curso=@idc and id_inscripcion=@id", sqlConn);
                cmdDelete.Parameters.Add("@ida", SqlDbType.Int).Value = IDA;
                cmdDelete.Parameters.Add("@idc", SqlDbType.Int).Value = IDC;
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar Inscripcion de Alumno", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public void Delete(int IDA)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete alumnos_inscripciones  where id_inscripcion=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = IDA;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar Inscripcion de Alumno", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public void Save(AlumnoInscripcion AI)
        {
            if (AI.State == BusinessEntity.States.Deleted)
            {
                this.Delete(AI.ID);
            }
            else if (AI.State == BusinessEntity.States.New)
            {
                this.Insert(AI);
            }
            else if (AI.State == BusinessEntity.States.Modified)
            {
                this.Update(AI);
            }
            AI.State = BusinessEntity.States.Unmodified;
        }
        protected void Update(AlumnoInscripcion AI)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE alumnos_inscripciones SET  id_alumno=@id_alumno, " +
                    "id_curso = @id_curso, condicion = @condicion, nota = @nota WHERE id_inscripcion = @id_inscripcion" /*id_inscripcion = @id_inscripcion,id_alumno=@id_alumno and id_curso=@id_curso*/, sqlConn);
                cmdSave.Parameters.Add("@id_inscripcion", SqlDbType.Int).Value = AI.ID;
                cmdSave.Parameters.Add("@id_alumno", SqlDbType.Int).Value = AI.IDAlumno;
                cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = AI.IDCurso;
                cmdSave.Parameters.Add("@nota", SqlDbType.Int).Value = AI.Nota;
                cmdSave.Parameters.Add("@condicion", SqlDbType.VarChar, 50).Value = AI.Condicion;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos de la inscripcion", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        protected void Insert(AlumnoInscripcion AI)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO alumnos_inscripciones(id_alumno,id_curso,nota,condicion) " +
                    "VALUES(@id_alumno,@id_curso,@nota,@condicion) " +
                    "SELECT @@identity"
                    , sqlConn);
                cmdSave.Parameters.Add("@id_inscripcion", SqlDbType.Int).Value = AI.ID;
                cmdSave.Parameters.Add("@id_alumno", SqlDbType.Int).Value = AI.IDAlumno;
                cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = AI.IDCurso;
                cmdSave.Parameters.Add("@nota", SqlDbType.Int).Value = AI.Nota;
                cmdSave.Parameters.Add("@condicion", SqlDbType.VarChar, 50).Value = AI.Condicion;
                AI.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear una Inscripcion de Alumno", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
    }
}
