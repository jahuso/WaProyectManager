using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectManager.Data
{
    
    public class Documento
    {
        [Key]
        public int Codigo
        {
            get => default;
            set
            {
            }
        }

        public string Ruta
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

        public void Actualizar()
        {
            throw new System.NotImplementedException();
        }

        public Documento Consultar()
        {
            throw new System.NotImplementedException();
        }

        public List<Documento> ConsultarTodos()
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