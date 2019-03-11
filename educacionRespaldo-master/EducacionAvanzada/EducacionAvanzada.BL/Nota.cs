using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducacionAvanzada.BL
{
    public class Nota
    {
        public int Id { get; set; }

        public int IdGrado { get; set; }
        public Grado Grado { get; set; }

        public int IdJornada { get; set; }
        public Jornada Jornada { get; set; }

        public int IdSeccion { get; set; }
        public seccion Seccion { get; set; }

        public List<NotasDetalle> ListadeNotasDetalle { get; set; }

        public Nota()
        {
            ListadeNotasDetalle = new List<NotasDetalle>();
        }
    }

    public class NotasDetalle
    {
        public int Id { get; set; }

        public int NotaId { get; set; }
        public Nota Nota { get; set; }

        public int AlumnoId { get; set; }
        public Alumno Alumno { get; set; }

        public int MateriaId { get; set; }
        public materia Materia { get; set; }

        public int PrimerParcial { get; set; }
        public int SegundoParcial { get; set; }
        public int TercerParcial { get; set; }
        public int CuartoParcial { get; set; }

        public int NotaFInal { get; set; }
    }
}
