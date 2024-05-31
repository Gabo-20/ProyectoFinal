namespace ProyectoFinal
{
    public class NodoLE
    {
        public Player Valor { get; set; }
        public NodoLE Siguiente { get; set; }

        public NodoLE(Player valor)
        {
            Valor = valor;
            Siguiente = null;
        }

        public class ListaSimple
        {
            public NodoLE cabeza;

            public ListaSimple()
            {
                cabeza = null;
            }

            // Método para agregar un elemento al inicio de la lista
            public object AgregarAlInicio(Player valor)
            {
                NodoLE nuevoNodo = new NodoLE(valor);
                nuevoNodo.Siguiente = cabeza;
                cabeza = nuevoNodo;

                return cabeza;
            }
            public IEnumerable<Player> ObtenerJugadores()
            {
                NodoLE actual = cabeza;
                while (actual != null)
                {
                    yield return actual.Valor;
                    actual = actual.Siguiente;
                }
            }
            // Método para agregar un elemento al final de la lista
            public void AgregarAlFinal(Player valor)
            {
                NodoLE nuevoNodo = new NodoLE(valor);

                if (cabeza == null)
                {
                    cabeza = nuevoNodo;
                    return;
                }

                NodoLE actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevoNodo;
            }

            // Método para eliminar un elemento de la lista
            public void Eliminar(object valor)
            {
                if (cabeza == null)
                {
                    return;
                }

                if (cabeza.Valor == valor)
                {
                    cabeza = cabeza.Siguiente;
                    return;
                }

                NodoLE actual = cabeza;
                while (actual.Siguiente != null)
                {
                    if (actual.Siguiente.Valor == valor)
                    {
                        actual.Siguiente = actual.Siguiente.Siguiente;
                        return;
                    }
                    actual = actual.Siguiente;
                }
            }
            public void EliminarPrimero()
            {
                if (cabeza != null)
                {
                    cabeza = cabeza.Siguiente;
                }
            }
            // Método para eliminar el último elemento de la lista
            public void EliminarUltimo()
            {
                if (cabeza == null)
                {
                    return;
                }

                if (cabeza.Siguiente == null)
                {
                    cabeza = null;
                    return;
                }

                NodoLE actual = cabeza;
                while (actual.Siguiente.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = null;
            }

            // Método para mostrar elementos de la lista
            public string Mostrar()
            {
                string datos = "";
                NodoLE actual = cabeza;
                Console.WriteLine("Lista: ");

                while (actual != null)
                {
                    datos += actual.Valor + " ";
                    Console.WriteLine(actual.Valor + " ");
                    actual = actual.Siguiente;
                }
                Console.WriteLine();
                return datos;
            }

            public object BuscarPorNombre(string nombre)
            {
                NodoLE actual = cabeza;

                while (actual != null)
                {

                    var jugador = actual.Valor as Player;
                    if (jugador != null && jugador.fullName == nombre)
                    {
                        return jugador;
                    }

                    actual = actual.Siguiente;
                }

                return null;
            }

           
        }

    }
}
