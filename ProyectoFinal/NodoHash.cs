using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
        public class NodoHash
        {
            public Object Dato;
            public NodoHash Enlace;
            public NodoHash(Object vDato)
            {
                Dato = vDato;
                Enlace = null;
            }
        }
    }
