using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class ListaEnlazadHash
    {
            public NodoHash primero;

            public ListaEnlazadHash()
            {
                primero = null;
            }

            public ListaEnlazadHash insertarCabezaLista(Object vDato)
            {
                NodoHash nuevo;
                nuevo = new NodoHash(vDato);
                nuevo.Enlace = primero;
                primero = nuevo;
                return this;
            }

            public Object BuscarNodo(Object pValor)
            {
                NodoHash temp = primero;
                int posicion = 1;

                while (temp != null && !temp.Dato.Equals(pValor))
                {
                    temp = temp.Enlace;
                    posicion++;
                }
                return (temp == null) ? null : temp.Dato;
            }

            public void Eliminar(object valor)
            {
                if (primero == null)
                {
                    return;
                }

                if (primero.Dato == valor)
                {
                    primero = primero.Enlace;
                    return;
                }

                NodoHash actual = primero;
                while (actual.Enlace != null)
                {
                    if (actual.Enlace.Dato == valor)
                    {
                        actual.Enlace = actual.Enlace.Enlace;
                        return;
                    }
                    actual = actual.Enlace;
                }
            }
        }
    }

