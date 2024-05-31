using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class TablaHashGenerica
    {
        public static readonly int M = 457;

        ListaEnlazadHash[] TablaHash;
        public int Posicion;

        public TablaHashGenerica()
        {
            TablaHash = new ListaEnlazadHash[M];
        }

        public int DispersionMod(int Clave)
        {
            return Clave % M;
        }

        public void Insertar(Object Dato, int Clave)
        {
            Posicion = DispersionMod(Clave);
            if (Posicion < M)
            {
                if (TablaHash[Posicion] == null)
                {
                    TablaHash[Posicion] = new ListaEnlazadHash();
                }
                TablaHash[Posicion].insertarCabezaLista(Dato);
            }
            else
            {
                Posicion = Posicion % 2;
                if (TablaHash[Posicion] == null)
                {
                    TablaHash[Posicion] = new ListaEnlazadHash();
                }
                TablaHash[Posicion].insertarCabezaLista(Dato);
            }


        }
        public void Eliminar(int Clave)
        {
            Posicion = DispersionMod(Clave);

            //eliminar
            TablaHash[Posicion] = null;
        }

        public object Consultar(int Clave)
        {
            Posicion = DispersionMod(Clave);
            return TablaHash[Posicion];
        }
    }
}
