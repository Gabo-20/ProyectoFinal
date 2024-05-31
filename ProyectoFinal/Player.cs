using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class Player
    {
        public string fullName {  get; set; }
        public int edad {  get; set; }
        public string posicion { get; set; }
        public string club { get; set; }
        public string nacionalidad { get; set; }
        public int goles { get; set; }
        public int asistencias { get; set; }
        public int TarjetaRoja {  get; set; }
        public int TarjetaAmarilla {  get; set; }


        public Player(string fullName, int edad, string posicion, string club, string nacionalidad, int goles,
            int asistencias, int TarjetaRoja, int TarjetaAmarilla) 
        { 
            //Pos.0
            this.fullName = fullName;

            //Pos.1
            this.edad = edad;

            //Pos.6
            this.posicion = posicion;

            //Pos.7
            this.club = club;

            //Pos.11
            this.nacionalidad = nacionalidad;

            //Pos.15
            this.goles = goles;

            //Pos.18
            this.asistencias = asistencias;

            //Pos.29
            this.TarjetaRoja = TarjetaRoja;

            //Pos.30
            this.TarjetaAmarilla = TarjetaAmarilla;
        }
    }
}
