using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class AlumnoInscripcion : BusinessEntity
    {
        private String _Condicion;
        private int _IDAlumno;
        private int _IDCurso;
        private int _Nota;
        private Boolean _Disable;

        public AlumnoInscripcion()
        {
                
        }
        public AlumnoInscripcion(string idalumno)
        {
            IDAlumno = int.Parse(idalumno);
        }
        public AlumnoInscripcion(string curso,string nota,string condicion,Boolean disable)
        {
            IDCurso = int.Parse(curso);
            Nota= int.Parse(nota);
            Condicion = condicion;
            Disable = disable;
        }
        public AlumnoInscripcion(string curso, string nota, string condicion, string idAlum)
        {
            IDCurso = int.Parse(curso);
            Nota = int.Parse(nota);
            Condicion = condicion;
            IDAlumno = int.Parse(idAlum);
        }
        public String Condicion
        {
            get => this._Condicion;
            set => this._Condicion = value;
        }

        public int IDAlumno
        {
            get => this._IDAlumno;
            set => this._IDAlumno = value;
        }

        public int IDCurso
        {
            get => this._IDCurso;
            set => this._IDCurso = value;
        }

        public int Nota
        {
            get => this._Nota;
            set => this._Nota = value;
           
        }

        public Boolean Disable
        {
            get =>this._Disable;
            set => this._Disable = value;
        }
    }
}