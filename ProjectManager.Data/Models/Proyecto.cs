using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjectManager.Data
{
    public class Proyecto
    {
        [Key]
        public int Codigo { get; set; }


        [Column(TypeName = "nvarchar(50)")]
        public string Nombre { get; set; }


        [Column(TypeName = "nvarchar(500)")]
        public string Descripcion { get; set; }



        [Column(TypeName = "nvarchar(50)")]
        public string Tipo { get; set; }


        [Column(TypeName = "nvarchar(10)")]
        public string Estado { get; set; }


        public List<Documento> Documentos { get; set; }


        public int Tutor
        {
            get => default;
            set
            {
            }
        }



        public int Equipo
        {
            get => default;
            set
            {
            }
        }

        public List<Actividad> Actividades
        {
            get => default;
            set
            {
            }
        }

        public void Crear()
        {
            throw new System.NotImplementedException();
        }

        public void Actualizar()
        {
            throw new System.NotImplementedException();
        }

        public List<Proyecto> ConsultarTodos()
        {
            throw new System.NotImplementedException();
        }

        public Proyecto Consultar()
        {
            throw new System.NotImplementedException();
        }

        private void Borrar()
        {
            throw new System.NotImplementedException();
        }
    }
}