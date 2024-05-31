namespace ProyectoFinal
{
    public class Team : Comparador
    {

        public string nombre { get; set; }
        public string pais { get; set; }
        public int jugados { get; set; }
        public int ganados { get; set; }
        public int empates { get; set; }
        public int perdidos { get; set; }
        public int posicion { get; set; }
        public int golesAFavor { get; set; }
        public int golesEnContra { get; set; }
        public int diferenciaGoles { get; set; }


        public Team(string nombre, string pais, int jugados, int ganados, int empates, int perdidos, int posicion,
            int golesAFavor, int golesEnContra, int diferenciaGoles)
        {
            // Pos.0
            this.nombre = nombre;

            // Pos.3
            this.pais = pais;

            // Pos.4
            this.jugados = jugados;

            // Pos.8
            this.ganados = ganados;

            // Pos.11
            this.empates = empates;

            // Pos.14
            this.perdidos = perdidos;

            // Pos.20
            this.posicion = posicion;

            // Pos.24
            this.golesAFavor = golesAFavor;

            // Pos.25
            this.golesEnContra = golesEnContra;

            // Pos.26
            this.diferenciaGoles = diferenciaGoles;
        }

        public bool igualQue(object op2)
        {
            Team p2 = (Team)op2;
            return nombre.CompareTo(p2.nombre) == 0;
        }

        public bool menorQue(object op2)
        {
            Team p2 = (Team)op2;
            return nombre.CompareTo(p2.nombre) < 0;
        }

        public bool menorIgualQue(object op2)
        {
            Team p2 = (Team)op2;
            return nombre.CompareTo(p2.nombre) <= 0;
        }

        public bool mayorQue(object op2)
        {
            Team p2 = (Team)op2;
            return nombre.CompareTo(p2.nombre) > 0;
        }

        public bool mayorIgualQue(object op2)
        {
            Team p2 = (Team)op2;
            return nombre.CompareTo(p2.nombre) >= 0;
        }

        public override string ToString()
        {
            return "NOMBRE: " + nombre + " - PUESTO EN LIGA: " + posicion + Environment.NewLine;
        }
    }
}
