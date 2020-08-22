using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjectManager.Data
{
    public class Tarea
    {
        [Key]
        public int Codigo { get; set; }


        [Column(TypeName = "nvarchar(50)")]
        public string Nombre { get; set; }


        [Column(TypeName = "nvarchar(500)")]
        public string Descripcion { get; set; }


        [Column(TypeName = "datetime")]
        public DateTime Fecha { get; set; }


        [Column(TypeName = "nvarchar(10)")]
        public string Estado { get; set; }


        public int Proyecto { get; set; }

    }
}