using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace demomvc.Models

{
    [Table("t_alumno")]
    public class Alumno
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Column("id")]
        public int Id{
            get;
            set;     
        }

        [Column("apellidos")]

        public string Apellidos{
            get;
            set;  
        }

        [Column("nombres")]

        public string Nombres{
            get;
            set;  
        }

        [Column("dni")]
        public string Dni{
            get;
            set;  
        }

        [Column("fechnac")]

        public DateTime FechNac{
            get;
            set;  
        }

        [Column("carrera")]

        public string Carrera{
            get;
            set;  
        }

        [Column("genero")]

        public string Genero{
            get;
            set;  
        }
    }
}