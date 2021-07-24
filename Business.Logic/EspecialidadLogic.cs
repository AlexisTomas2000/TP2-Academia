using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Business.Entities;

namespace Business.Logic
{
    public class EspecialidadLogic : BusinessLogic
    {
        private Data.Database.EspecialidadAdapter _EspecialidadData;
        public Data.Database.EspecialidadAdapter EspecialidadData
        {
            get { return _EspecialidadData; }
            set { _EspecialidadData = value; }
        }

        public EspecialidadLogic(Data.Database.EspecialidadAdapter x)
        {
            EspecialidadData = x;
        }

        public EspecialidadLogic()
        {
        }

        public List<Especialidad> GetAll()
        {
            this.EspecialidadData = new Data.Database.EspecialidadAdapter();
            return this.EspecialidadData.GetAll();
        }

        public Business.Entities.Especialidad GetOne(int ID)
        {
            this.EspecialidadData = new Data.Database.EspecialidadAdapter();
            return EspecialidadData.GetOne(ID);
        }

        public void Delete(int ID)
        {
            this.EspecialidadData = new Data.Database.EspecialidadAdapter();
            EspecialidadData.Delete(ID);
        }

        public void Save(Business.Entities.Especialidad espe)
        {
            this.EspecialidadData = new Data.Database.EspecialidadAdapter();
            EspecialidadData.Save(espe);
        }
    }
}
