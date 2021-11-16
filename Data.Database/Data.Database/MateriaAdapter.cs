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
    public class MateriaAdapter:Adapter
    {
        public List<Materia> GetAll()
        {
            List<Materia> materias = new List<Materia>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdMateria = new SqlCommand("select * from materias", sqlConn);
                SqlDataReader drMateria = cmdMateria.ExecuteReader();
                while (drMateria.Read())
                {
                    Materia mat = new Materia();
                    mat.ID = (int)drMateria["id_materia"];
                    mat.Descripcion = (string)drMateria["desc_materia"];
                    mat.HsSemanales=(int)drMateria["hs_semanales"];
                    mat.HsTotales=(int)drMateria["hs_totales"];
                    mat.IDPlan=(int)drMateria["id_plan"];
                    materias.Add(mat);
                }
                drMateria.Close();
                return materias;
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de materias", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public List<MatPlan> GetAllD()
        {
            List<MatPlan> materias = new List<MatPlan>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdMateria = new SqlCommand("sp_ListaMaterias", sqlConn);
                cmdMateria.CommandType = CommandType.StoredProcedure;
                SqlDataReader drMateria = cmdMateria.ExecuteReader();
                while (drMateria.Read())
                {
                    MatPlan mat = new MatPlan();
                    mat.ID = (int)drMateria["id_materia"];
                    mat.Descripcion = (string)drMateria["desc_materia"];
                    mat.HsSemanales = (int)drMateria["hs_semanales"];
                    mat.HsTotales = (int)drMateria["hs_totales"];
                    mat.IDPlan = (int)drMateria["id_plan"];
                    mat.DescripcionP = (string)drMateria["desc_plan"];
                    materias.Add(mat);
                }
                drMateria.Close();
                return materias;
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de materias", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public Business.Entities.Materia GetOne(int ID)
        {
            Materia mat = new Materia();
            try
            {
                this.OpenConnection();
                SqlCommand cmdMateria = new SqlCommand("select * from materias where id_materia=@id", sqlConn);
                cmdMateria.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drMateria = cmdMateria.ExecuteReader();
                if (drMateria.Read())
                {
                    mat.ID = (int)drMateria["id_materia"];
                    mat.Descripcion = (string)drMateria["desc_materia"];
                    mat.HsSemanales = (int)drMateria["hs_semanales"];
                    mat.HsTotales = (int)drMateria["hs_totales"];
                    mat.IDPlan = (int)drMateria["id_plan"];

                }
                drMateria.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la materia", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return mat;
        }
        public void Delete(int ID)
        {
            try
            {
                //abrimos la conexion
                this.OpenConnection();
                //creame la sentencia sql y asignamos un valor al parametro
                SqlCommand cmdDelete = new SqlCommand("delete materias where id_materia=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                //ejecutamos la sentencia sql
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar materia", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Materia mat)
        {
            if (mat.State == BusinessEntity.States.Deleted)
            {
                this.Delete(mat.ID);
            }
            else if (mat.State == BusinessEntity.States.New)
            {
                this.Insert(mat);
            }
            else if (mat.State == BusinessEntity.States.Modified)
            {
                this.Update(mat);
            }
            mat.State = BusinessEntity.States.Unmodified;
        }

        protected void Update(Materia mat)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE materias SET desc_materia = @desc_materia,hs_semanales=@hs_semanales,hs_totales=@hs_totales,id_plan=@id_plan" +
                    " WHERE id_materia=@id", sqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = mat.ID;
                cmdSave.Parameters.Add("@desc_materia", SqlDbType.VarChar, 50).Value = mat.Descripcion;
                cmdSave.Parameters.Add("@hs_semanales", SqlDbType.Int).Value = mat.HsSemanales;
                cmdSave.Parameters.Add("@hs_totales", SqlDbType.Int).Value = mat.HsTotales;
                cmdSave.Parameters.Add("@id_plan", SqlDbType.Int).Value = mat.IDPlan;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos de la materia", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(Materia mat)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO materias(desc_materia,hs_semanales,hs_totales,id_plan) " +
                    "VALUES(@desc_materia,@hs_semanales,@hs_totales,@id_plan) " +
                    "SELECT @@identity"//esta linea es para recuperar el ID que asignó el sql automaticamente
                    , sqlConn);
                //cmdSave.Parameters.Add("@id_especialidad", SqlDbType.Int).Value = especialidad.ID;
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = mat.ID;
                cmdSave.Parameters.Add("@desc_materia", SqlDbType.VarChar, 50).Value = mat.Descripcion;
                cmdSave.Parameters.Add("@hs_semanales", SqlDbType.Int).Value = mat.HsSemanales;
                cmdSave.Parameters.Add("@hs_totales", SqlDbType.Int).Value = mat.HsTotales;
                cmdSave.Parameters.Add("@id_plan", SqlDbType.Int).Value = mat.IDPlan;
                mat.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());//asi se obtiene el ID que asigno al BD automaticamente
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear una materia", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
    }
}
