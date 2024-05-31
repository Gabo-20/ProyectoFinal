using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class Match
    {
        public string fecha {  get; set; }
        public string estado { get; set; }
        public string visitante { get; set; }
        public string local { get; set; }
        public int golVisitante { get; set; }
        public int golLocal { get; set; }
        public string referee {  get; set; }
        public int asistencia {  get; set; }

        public Match(string fecha, string estado, string visitante, string local, int golVisitante, int golLocal, 
            string referee, int asistencia)
        {
            // Pos. 1
            this.fecha = fecha;

            // Pos. 2
            this.estado = estado;

            // Pos. 5
            this.visitante = visitante;

            // Pos.4
            this.local = local;

            // Pos.13
            this.golVisitante = golVisitante;

            // Pos.12
            this.golLocal = golLocal;

            // Pos.6
            this.referee = referee; 

            // Pos.3
            this.asistencia = asistencia;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Match))
                return false;
            Match other = (Match)obj;
            return asistencia.Equals(other.asistencia);
        }
    }
}
