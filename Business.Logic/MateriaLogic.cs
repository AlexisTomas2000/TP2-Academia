using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class MateriaLogic:BusinessLogic
    {
        private Data.Database.MateriaAdapter _MateriaData;
        public Data.Database.MateriaAdapter MateriaData
        {
            get { return this._MateriaData; }
            set { this._MateriaData = value; }
        }

        public MateriaLogic (Data.Database.MateriaAdapter x)
        {
            MateriaData = x;
        }

        public MateriaLogic()
        {
        }

        public List<Materia> GetAll()
        {
            this.MateriaData = new Data.Database.MateriaAdapter();
            return this.MateriaData.GetAll();
        }

        public Business.Entities.Materia GetOne(int ID)
        {
            this.MateriaData = new Data.Database.MateriaAdapter();
            return MateriaData.GetOne(ID);
        }

        public void Delete(int ID)
        {
            this.MateriaData = new Data.Database.MateriaAdapter();
            MateriaData.Delete(ID);
        }

        public void Save(Business.Entities.Materia mat)
        {
            this.MateriaData = new Data.Database.MateriaAdapter();
            MateriaData.Save(mat);
        }
    }
}
