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
        public Business.Entities.AlumnoInscripcion GetOne(int IDA, int IDC)
        {
            this.AIData = new Data.Database.AlumnoInscripcionAdapter();
            return this.AIData.GetOne(IDA, IDC);
        }
        public void Delete(int IDA, int IDC)
        {
            this.AIData = new Data.Database.AlumnoInscripcionAdapter();
            AIData.Delete(IDA,IDC);
        }

        public void Save(Business.Entities.AlumnoInscripcion AI)
        {
            this.AIData = new Data.Database.AlumnoInscripcionAdapter();
            AIData.Save(AI);
        }
    }
}
