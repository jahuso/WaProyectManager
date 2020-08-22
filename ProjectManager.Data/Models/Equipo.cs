using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectManager.Data
{
    public class Equipo
    {
        public int Codigo
        {
            get => default;
            set
            {
            }
        }

        public int Proyecto
        {
            get => default;
            set
            {
            }
        }

        public List<Persona> Estudiantes
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

        public Equipo Consultar()
        {
            throw new System.NotImplementedException();
        }

        public List<Equipo> ConsultarTodos()
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