using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjectManager.Data
{
    public class Persona
    {


        [Key]
        [Column(TypeName = "nvarchar(25)")]
        public int Identificacion{ get; set; }



        [Column(TypeName = "nvarchar(50)")]
        public string Nombre { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Apellido{ get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string Rol { get; set; }


        [Column(TypeName = "nvarchar(50)")]
        public string Programa { get; set; }


        public void Actualizar()
        {
            throw new System.NotImplementedException();
        }

        public Persona Consultar()
        {
            throw new System.NotImplementedException();
        }

        public List<Persona> ConsultarTodos()
        {
            throw new System.NotImplementedException();
        }

        public void Crear()
        {
            throw new System.NotImplementedException();
        }

        private void Borrar()
        {
            throw new System.NotImplementedException();
        }
    }
}