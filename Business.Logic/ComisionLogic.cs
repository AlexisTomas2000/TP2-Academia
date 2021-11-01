using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class ComisionLogic:BusinessLogic
    {
            private Data.Database.ComisionAdapter _ComisionData;
            public Data.Database.ComisionAdapter ComisionData
        {
                get { return this._ComisionData; }
                set { this._ComisionData = value; }
            }

            public ComisionLogic(Data.Database.ComisionAdapter x)
            {
            ComisionData = x;
            }

            public ComisionLogic()
            {
            }

            public List<Comision> GetAll()
            {
                this.ComisionData = new Data.Database.ComisionAdapter();
                return this.ComisionData.GetAll();
            }

            public Business.Entities.Comision GetOne(int ID)
            {
                this.ComisionData = new Data.Database.ComisionAdapter();
                return ComisionData.GetOne(ID);
            }

            public void Delete(int ID)
            {
                this.ComisionData = new Data.Database.ComisionAdapter();
            ComisionData.Delete(ID);
            }

            public void Save(Business.Entities.Comision com)
            {
                this.ComisionData = new Data.Database.ComisionAdapter();
            ComisionData.Save(com);
            }
    }
}
