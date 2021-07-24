using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class BusinessEntity
    {
        public States _State;
        public int _ID;
        public BusinessEntity() {
            this.State = new States();
        }

        public int ID { 
            get=> this._ID; 
            set=> this._ID=value; }
        
        public States State { 
            get=> this._State; 
            set=> this._State=value; }

        public enum States { 
            Deleted,
            New,
            Modified,
            Unmodified
        }
    }
}
