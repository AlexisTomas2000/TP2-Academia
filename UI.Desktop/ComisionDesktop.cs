using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class ComisionDesktop : ApplicationForm
    {
        private Business.Entities.Comision _ComisionActual;
        public ComisionDesktop()
        {
            InitializeComponent();
        }
        public Business.Entities.Comision ComisionActual { get=>this._ComisionActual; set=>this._ComisionActual=value; }
        private void ComisionDesktop_Load(object sender, EventArgs e)
        {

        }
        public ComisionDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }
    }
}
