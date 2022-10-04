using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD_DOCNET.Models
{
    public class Nota
    {
        // este seria la encapsulacion con los campos privados
        private int _id;
        private string _nombre;
        private string _apellido;
        private string _matricula;
        private string _curso;
        private int _nota;

        // declaramos nuestos propiedas publicas a la cual se puede acceder

        public int Id { get { return _id; }set { _id = value; }}
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public string Apellido { get { return _apellido; } set { _apellido = value; } }
        public string Matricula { get { return _matricula; } set { _matricula = value; } }
        public string Curso { get { return _curso; } set { _curso = value; } }
        public int nota { get { return _nota; } set { _nota = value; } }


        //metodos constructores
        public Nota(int Id, string Nombre, string Apellido, string Matricula, string Curso, int Nota)

        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Apellido=Apellido;
            this.Matricula=Matricula;
            this.Curso=Curso;
            this.nota=nota;

        }
        public Nota(string Nombre, string Apellido, string Matricula, string Curso, int Nota)

        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Matricula = Matricula;
            this.Curso = Curso;
            this.nota = nota;

        }
        public Nota()

        {
           
        }
    }
}
