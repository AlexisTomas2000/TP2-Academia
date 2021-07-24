using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Persona : BusinessEntity
    {
        private String _Apellido;
        private String _Direccion;
        private String _Email;
        private DateTime _FechaNacimiento;
        private int _IDPlan;
        private int _Legajo;
        private String _Nombre;
        private String _Telefono;
        private int _TipoPersona;

        public String Apellido
        {
            get => _Apellido;
            set => _Apellido = value;


        }

        public String Direccion
        {
            get => _Direccion;

            set => _Direccion = value;

        }

        public String EMail
        {
            get => _Email;
            set => _Email = value;

        }

        public DateTime FechaNacimiento
        {
            get => _FechaNacimiento;
            set => _FechaNacimiento = value;


        }

        public int IDPlan
        {
            get => _IDPlan;
            set => _IDPlan = value;


        }

        public int Legajo
        {
            get => _Legajo;
            set => _Legajo = value;


        }

        public String Nombre
        {
            get => _Nombre;
            set => _Nombre = value;

        }

        public String Telefono
        {
            get => _Telefono;
            set => _Telefono = value;


        }

        public int TipoPersona
        {
            get => _TipoPersona;
            set => _TipoPersona = value;


        }
    }
}