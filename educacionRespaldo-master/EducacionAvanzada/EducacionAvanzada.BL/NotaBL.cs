using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducacionAvanzada.BL
{
    public class NotaBL
    {
        Contexto _contexto;
        public List<Nota> ListadeNota { get; set; }

        public NotaBL()
        {
            _contexto = new Contexto();
            ListadeNota = new List<Nota>();
        }
        public List<Nota> ObtenerNota()
        {
            ListadeNota = _contexto.Notas
            .Include("Alumno")
            .ToList();

            return ListadeNota;
        }
}
