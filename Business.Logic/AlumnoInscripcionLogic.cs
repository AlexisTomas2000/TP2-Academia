using Business.Entities;
using Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class AlumnoInscripcionLogic : BusinessLogic
    {
        private Data.Database.AlumnoInscripcionAdapter _AIData;

        public AlumnoInscripcionAdapter AIData { get => _AIData; set => _AIData = value; }
        public AlumnoInscripcionLogic()
        {

        }
        public AlumnoInscripcionLogic(Data.Database.AlumnoInscripcionAdapter x)
        {
            this.AIData = x;
        }
        public List<AlumnoInscripcion> GetAll()
        {
            this.AIData = new Data.Database.AlumnoInscripcionAdapter();
            return this.AIData.GetAll();
        }
        public List<AlumnoInscripcion> GetAllD(int id)
        {
            this.AIData = new Data.Database.AlumnoInscripcionAdapter();
            return this.AIData.GetAllD(id);
        }
        public List<AlumnoInscripcion> GetAllA(int id)
        {
            this.AIData = new Data.Database.AlumnoInscripcionAdapter();
            return this.AIData.GetAllA(id);
        }
        public Business.Entities.AlumnoInscripcion GetOne(int ID)
        {
            this.AIData = new Data.Database.AlumnoInscripcionAdapter();
            return this.AIData.GetOne(ID);
        }
        public void Delete(int IDA, int IDC,int ID)
        {
            this.AIData = new Data.Database.AlumnoInscripcionAdapter();
            AIData.Delete(IDA,IDC,ID);
        }
        public void Delete(int IDA)
        {
            this.AIData = new Data.Database.AlumnoInscripcionAdapter();
            AIData.Delete(IDA);
        }

        public void Save(Business.Entities.AlumnoInscripcion AI)
        {
            this.AIData = new Data.Database.AlumnoInscripcionAdapter();
            AIData.Save(AI);
        }
    }
}
