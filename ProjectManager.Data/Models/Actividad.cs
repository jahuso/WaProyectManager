using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectManager.Data
{
    public class Actividad
    {
        [Key]
        public int Codigo
        {
            get => default;
            set
            {
            }
        }

        public string Descripcion
        {
            get => default;
            set
            {
            }
        }

        public int Tipo
        {
            get => default;
            set
            {
            }
        }

        public double Nota
        {
            get => default;
            set
            {
            }
        }

        public void Actualizar()
        {
            throw new System.NotImplementedException();
        }

        private void Borrar()
        {
            throw new System.NotImplementedException();
        }

        public Programa Consultar()
        {
            throw new System.NotImplementedException();
        }

        public List<Actividad> ConsultarTodos()
        {
            throw new System.NotImplementedException();
        }

        public void Crear()
        {
            throw new System.NotImplementedException();
        }
    }
}