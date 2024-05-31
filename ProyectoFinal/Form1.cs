using System.Windows.Forms;
using static ProyectoFinal.NodoLE;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        public ArbolAVL arbolAVL;
        public ListaSimple listaS;
        public TablaHashGenerica miTabla;
        public ListaEnlazadHash LEHash;
        public Form1()
        {
            InitializeComponent();
            LEHash = new ListaEnlazadHash();
            miTabla = new TablaHashGenerica();
            arbolAVL = new ArbolAVL();
            listaS = new ListaSimple();
        }

        /// <summary>
        /// Maneja el evento de clic para el botón "Datos Jugadores".
        /// Lee datos de jugadores desde un archivo CSV y llena una lista enlazada con esta información.
        /// Actualiza la interfaz de usuario para reflejar la carga exitosa de los datos de los jugadores.
        /// </summary>
        /// <param name="sender">El origen del evento.</param>
        /// <param name="e">Un EventArgs que contiene los datos del evento.</param>
        private void btn_DatosJugadores_Click(object sender, EventArgs e)
        {
            try
            {
                string line;
                string archivo = "jugadores.csv";
                string rutaCompleta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, archivo);

                System.IO.StreamReader file =
                new System.IO.StreamReader(rutaCompleta);

                Char delimiter = ',';
                while ((line = file.ReadLine()) != null)
                {
                    String[] substrings = line.Split(delimiter);
                    Player jugador = new Player(substrings[0], int.Parse(substrings[1]), substrings[6],
                        substrings[7], substrings[11], int.Parse(substrings[15]), int.Parse(substrings[18]),
                        int.Parse(substrings[29]), int.Parse(substrings[30]));
                    listaS.AgregarAlInicio(jugador);
                }
                MessageBox.Show("¡Jugadores agregados con éxito!");
                btn_VerJugadores.Enabled = true;
                btn_DatosJugadores.Enabled = false;
                btn_DatosJugadores.Hide();
                btn_DatosEquipos.Hide();
                btn_DatosPartidos.Hide();
                label3.Show();
                btn_editarJugador.Show();
                btn_TablaJugadores.Show();
                txt_vista.Hide();
                dataGridViewTeams.Show();



                RefreshDataGridViewPlayers();
                btn_VerEquipos.Hide();
                btn_VerJugadores.Hide();
                btn_VerPartidos.Hide();
                btn_BuscarJugador.Show();
                txt_BuscarJugador.Show();
                btn_AgregarJugador.Show();
                btn_EliminarJugador.Show();
                btn_regresarJugador.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al leer el archivo");
            }
        }

        /// <summary>
        /// Maneja el evento de clic para el botón "Datos Jugadores".
        /// Lee datos de jugadores desde un archivo CSV y llena una lista enlazada con esta información.
        /// Actualiza la interfaz de usuario para reflejar la carga exitosa de los datos de los jugadores.
        /// </summary>
        /// <param name="sender">El origen del evento.</param>
        /// <param name="e">Un EventArgs que contiene los datos del evento.</param>

        private void btn_DatosEquipos_Click(object sender, EventArgs e)
        {
            try
            {
                string line;
                string archivo = "equipos.csv";
                string rutaCompleta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, archivo);

                System.IO.StreamReader file =
                new System.IO.StreamReader(rutaCompleta);

                Char delimiter = ',';
                while ((line = file.ReadLine()) != null)
                {
                    String[] substrings = line.Split(delimiter);
                    Team equipos = new Team(substrings[0], substrings[3], int.Parse(substrings[4]),
                        int.Parse(substrings[8]), int.Parse(substrings[11]), int.Parse(substrings[14]),
                        int.Parse(substrings[20]), int.Parse(substrings[24]), int.Parse(substrings[25]),
                        int.Parse(substrings[26]));

                    arbolAVL.insertar(equipos);
                }
                MessageBox.Show("Estadísticas de equipos agregados con éxito");
                btn_VerEquipos.Enabled = true;
                btn_DatosEquipos.Enabled = false;
                btn_DatosJugadores.Hide();
                btn_DatosEquipos.Hide();
                btn_DatosPartidos.Hide();
                btn_editarEquipo.Show();
                lbl_nameEquipo.Show();
                txt_vista.Hide();
                dataGridViewTeams.Show();

                btn_TablaJugadores.Hide();
                btn_InsertarEquipo.Show();
                btn_EliminarEquipo.Show();
                btn_buscar.Show();
                txt_buscar.Show();
                button2.Show();
                button1.Show();

                btn_VerJugadores.Hide();
                btn_VerPartidos.Hide();
                btn_VerEquipos.Hide();

                RefreshDataGridViewTeams();
            }
            catch (Exception)
            {
                MessageBox.Show("error al leer el archivo");
                throw;
            }
        }

        /// <summary>
        /// Maneja el evento de clic para el botón "Datos Partidos".
        /// Lee datos de partidos desde un archivo CSV y los inserta en una tabla hash.
        /// Actualiza la interfaz de usuario para reflejar la carga exitosa de los datos de los partidos.
        /// </summary>
        /// <param name="sender">El origen del evento.</param>
        /// <param name="e">Un EventArgs que contiene los datos del evento.</param>
        private void btn_DatosPartidos_Click(object sender, EventArgs e)
        {
            ConfigurarColumnasPartidos();
            try
            {
                string line;
                string archivo = "partidoss.csv";
                string rutaCompleta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, archivo);
                System.IO.StreamReader file =
                new System.IO.StreamReader(rutaCompleta);
                Char delimiter = ',';
                while ((line = file.ReadLine()) != null)
                {
                    String[] substrings = line.Split(delimiter);
                    Match partido = new Match(substrings[1], substrings[2], substrings[5], substrings[4],
                   int.Parse(substrings[13]), int.Parse(substrings[12]), substrings[6], int.Parse(substrings[3]));
                    int clave = int.Parse(substrings[3]);
                    miTabla.Insertar(partido, clave);


                }
                MessageBox.Show("Estadísticas de partidos agregadas con éxito");
                btn_AgregarPartido.Show();
                btn_EliminarPartido.Show();
                CargarDatosPartidosEnDataGrid();
                RefreshDataGridViewMatch();
                txt_buscarPartidos.Show();
                btn_buscarPartido.Show();
                btn_verTablaLiga.Show();
                lbl_asistencia.Show();
                btn_editarPartido.Show();
                btn_VerEquipos.Hide();
                btn_VerJugadores.Hide();
                btn_VerPartidos.Hide();
                btn_regresarPartido.Show();
                btn_DatosPartidos.Enabled = false;
                btn_VerPartidos.Enabled = true;


            }
            catch (Exception)
            {
                MessageBox.Show("error al leer el archivo");
                throw;
            }
        }

        /// <summary>
        /// Maneja el evento de clic para el botón "Insertar Equipo".
        /// Abre la ventana para agregar un nuevo equipo, pasando la referencia del formulario actual y el árbol AVL.
        /// </summary>
        /// <param name="sender">El origen del evento.</param>
        /// <param name="e">Un EventArgs que contiene los datos del evento.</param>
        private void btn_InsertarEquipo_Click(object sender, EventArgs e)
        {
            AgregarEquipo agregarEquipo = new AgregarEquipo(this, arbolAVL);
            agregarEquipo.Show();
        }

        /// <summary>
        /// Refresca y actualiza el contenido del DataGridView de equipos.
        /// Muestra el DataGridView, limpia las columnas y la fuente de datos,
        /// configura las columnas y carga los datos en el DataGridView.
        /// </summary>
        public void RefreshDataGridViewTeams()
        {
            dataGridViewTeams.Show();
            dataGridViewTeams.Columns.Clear();
            dataGridViewTeams.DataSource = null;
            ConfigurarColumnasEquipos();
            CargarDatosEnDataGridView();
        }

        /// <summary>
        /// Refresca y actualiza el contenido del DataGridView de jugadores.
        /// Muestra el DataGridView, limpia las columnas y la fuente de datos,
        /// obtiene la lista de jugadores, los agrega a una fuente de datos enlazable,
        /// y configura las columnas del DataGridView para mostrar los datos de los jugadores.
        /// </summary>
        public void RefreshDataGridViewPlayers()
        {

            dataGridViewTeams.Show();
            dataGridViewTeams.Columns.Clear(); //
            dataGridViewTeams.DataSource = null;
            var jugadores = listaS.ObtenerJugadores();
            var Jugadores = new BindingSource();
            foreach (var jugador in jugadores)
            {
                Jugadores.Add(jugador);
            }
            dataGridViewTeams.DataSource = Jugadores;
            ConfigurarColumnasJugadores();
        }

        /// <summary>
        /// Refresca y actualiza el contenido del DataGridView de partidos.
        /// Muestra el DataGridView, limpia las columnas,
        /// configura las columnas del DataGridView para los partidos,
        /// y carga los datos de los partidos en el DataGridView.
        /// </summary>

        public void RefreshDataGridViewMatch()
        {
            dataGridViewTeams.Show();
            dataGridViewTeams.Columns.Clear(); //
            ConfigurarColumnasPartidos();
            CargarDatosPartidosEnDataGrid();
        }

        /// <summary>
        /// Carga los datos de los partidos en el DataGridView.
        /// Recorre la tabla hash y sus listas enlazadas para agregar cada partido al DataGridView.
        /// </summary>
        public void CargarDatosPartidosEnDataGrid()
        {
            for (int i = 0; i < TablaHashGenerica.M; i++)
            {
                ListaEnlazadHash lista = miTabla.Consultar(i) as ListaEnlazadHash;

                if (lista != null)
                {
                    NodoHash actual = lista.primero;
                    while (actual != null)
                    {
                        Match Partido = (Match)actual.Dato;
                        dataGridViewTeams.Rows.Add(
                            Partido.fecha,
                            Partido.estado,
                            Partido.visitante,
                            Partido.local,
                            Partido.golVisitante,
                            Partido.golLocal,
                            Partido.referee,
                            Partido.asistencia
                            );
                        actual = actual.Enlace;
                    }
                }
            }
        }

        /// <summary>
        /// Configura las columnas del DataGridView para mostrar información de equipos.
        /// Limpia las columnas existentes y agrega nuevas columnas con los encabezados correspondientes.
        /// </summary>
        private void ConfigurarColumnasEquipos()
        {
            dataGridViewTeams.Columns.Clear();
            dataGridViewTeams.Columns.Add("nombre", "Equipo");
            dataGridViewTeams.Columns.Add("pais", "Pais");
            dataGridViewTeams.Columns.Add("jugados", "Partidos Jugados");
            dataGridViewTeams.Columns.Add("ganados", "Partidos Ganados");
            dataGridViewTeams.Columns.Add("empates", "Partidos Empatados");
            dataGridViewTeams.Columns.Add("perdidos", "Partidos Perdidos");
            dataGridViewTeams.Columns.Add("posicion", "Posición en Tabla");
            dataGridViewTeams.Columns.Add("golesAFavor", "Goles a Favor");
            dataGridViewTeams.Columns.Add("golesEnContra", "Goles en Contra");
            dataGridViewTeams.Columns.Add("diferenciaGoles", "Diferencia de Goles");
        }

        /// <summary>
        /// Carga los datos de los equipos en el DataGridView.
        /// Utiliza un recorrido inorden del árbol AVL para obtener los datos de los equipos.
        /// </summary>
        private void CargarDatosEnDataGridView()
        {
            CargarDatosInOrden(arbolAVL.raizArbol());
        }

        /// <summary>
        /// Carga los datos de los equipos en el DataGridView utilizando un recorrido inorden del árbol AVL.
        /// Agrega cada equipo como una nueva fila en el DataGridView.
        /// </summary>
        /// <param name="nodo">Nodo de la raíz del subárbol a recorrer.</param>
        private void CargarDatosInOrden(NodoAvl nodo)
        {
            if (nodo != null)
            {
                CargarDatosInOrden((NodoAvl)nodo.subarbolIzdo());

                Team equipo = (Team)nodo.valorNodo();
                dataGridViewTeams.Rows.Add(
                    equipo.nombre,
                    equipo.pais,
                    equipo.jugados,
                    equipo.ganados,
                    equipo.empates,
                    equipo.perdidos,
                    equipo.posicion,
                    equipo.golesAFavor,
                    equipo.golesEnContra,
                    equipo.diferenciaGoles
                );

                CargarDatosInOrden((NodoAvl)nodo.subarbolDcho());
            }
        }

        /// <summary>
        /// Configura los encabezados de las columnas en el DataGridView para mostrar información 
        /// de los jugadores.
        /// </summary>
        private void ConfigurarColumnasJugadores()
        {
            dataGridViewTeams.Columns["fullName"].HeaderText = "Nombre Jugador";
            dataGridViewTeams.Columns["edad"].HeaderText = "Edad";
            dataGridViewTeams.Columns["posicion"].HeaderText = "Posición en que Juega";
            dataGridViewTeams.Columns["club"].HeaderText = "Club Actual";
            dataGridViewTeams.Columns["nacionalidad"].HeaderText = "Nacionalidad";
            dataGridViewTeams.Columns["goles"].HeaderText = "Goles Marcados";
            dataGridViewTeams.Columns["asistencias"].HeaderText = "Asistencias";
            dataGridViewTeams.Columns["TarjetaRoja"].HeaderText = "Tarjetas Rojas";
            dataGridViewTeams.Columns["TarjetaAmarilla"].HeaderText = "Tarjetas Amarillas";
        }

        /// <summary>
        /// Configura los encabezados y el ancho de las columnas en el DataGridView para mostrar
        /// información de los partidos.
        /// </summary>
        private void ConfigurarColumnasPartidos()
        {
            dataGridViewTeams.Columns.Clear();
            dataGridViewTeams.Columns.Add("fecha", "Fecha partido");
            dataGridViewTeams.Columns["fecha"].Width = 200;
            dataGridViewTeams.Columns.Add("estado", "Estado");
            dataGridViewTeams.Columns["estado"].Width = 75;
            dataGridViewTeams.Columns.Add("visitante", "Equipo Visitante");
            dataGridViewTeams.Columns["visitante"].Width = 175;
            dataGridViewTeams.Columns.Add("local", "Equipo Local");
            dataGridViewTeams.Columns["local"].Width = 175;
            dataGridViewTeams.Columns.Add("golVisitante", "Goles Visitante");
            dataGridViewTeams.Columns["golVisitante"].Width = 75;
            dataGridViewTeams.Columns.Add("golLocal", "Goles Local");
            dataGridViewTeams.Columns["golLocal"].Width = 75;
            dataGridViewTeams.Columns.Add("referee", "Árbitro");
            dataGridViewTeams.Columns.Add("asistencia", "Asistencia");

        }

        /// <summary>
        /// Maneja el evento de clic en el botón de búsqueda de equipos. Busca un equipo en el árbol AVL 
        /// y muestra su información si se encuentra.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (txt_buscar.Text != "")
            {
                try
                {
                    Team EquipoBuscado = new Team(txt_buscar.Text, "", 0, 0, 0, 0, 0, 0, 0, 0);
                    Nodo resultado = arbolAVL.buscarIterativo(EquipoBuscado);

                    if (resultado != null)
                    {
                        Team res = (Team)resultado.valorNodo();
                        if (res != null)
                        {
                            txt_vista.Show();
                            dataGridViewTeams.Visible = false;
                            MessageBox.Show("Equipo encontrado");
                            string infoEquipo = $"Nombre: {res.nombre}\n {Environment.NewLine}" +
                                $"Pais: {res.pais}\n {Environment.NewLine}" +
                                $"Partidos jugados: {res.jugados}\n {Environment.NewLine}" +
                                $"Partidos ganados: {res.ganados}\n {Environment.NewLine}" +
                                $"Partidos perdidos: {res.perdidos}\n {Environment.NewLine}" +
                                $"Partidos empatados: {res.empates}\n {Environment.NewLine}" +
                                $"Posición en tabla: {res.posicion}\n {Environment.NewLine}" +
                                $"Goles a favor: {res.golesAFavor}\n {Environment.NewLine}" +
                                $"Goles en contra: {res.golesEnContra}\n {Environment.NewLine}" +
                                $"Diferencia de goles: {res.diferenciaGoles}\n {Environment.NewLine}";
                            txt_vista.Text = infoEquipo;
                            txt_buscar.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("El equipo no se encuentra.");
                            txt_buscar.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("El equipo no se encuentra.");
                        txt_buscar.Text = "";
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                MessageBox.Show("Ingresar equipo a buscar");
            }
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Ver Tabla". Oculta el cuadro de texto de vista y
        /// muestra el DataGridView con la tabla de equipos actualizada.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void btn_verTabla_Click(object sender, EventArgs e)
        {
            txt_vista.Text = "";
            dataGridViewTeams.Visible = true;
            txt_vista.Hide();
            RefreshDataGridViewTeams();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Eliminar Equipo". Abre la ventana para eliminar un equipo.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void btn_EliminarEquipo_Click(object sender, EventArgs e)
        {
            EliminarEquipo eliminarEquipo = new EliminarEquipo(this, arbolAVL);
            eliminarEquipo.Show();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón. Oculta varios elementos de la interfaz de 
        /// usuario y muestra opciones para ver datos de jugadores, partidos y equipos.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewTeams.DataSource = null;
            btn_buscar.Hide();
            btn_EliminarEquipo.Hide();
            btn_InsertarEquipo.Hide();
            button1.Hide();
            button2.Hide();
            txt_buscar.Hide();
            dataGridViewTeams.Hide();
            txt_vista.Text = "";
            txt_vista.Show();
            btn_editarEquipo.Hide();
            lbl_nameEquipo.Hide();
            btn_VerJugadores.Show();
            btn_VerPartidos.Show();
            btn_VerEquipos.Show();

            btn_DatosEquipos.Show();
            btn_DatosPartidos.Show();
            btn_DatosJugadores.Show();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "btn_VerJugadores". Muestra la tabla de datos de jugadores 
        /// y oculta otros elementos relacionados con la visualización de datos de jugadores.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void btn_VerJugadores_Click(object sender, EventArgs e)
        {
            btn_DatosJugadores.Hide();
            //btn_DatosPartidos.Hide();
            dataGridViewTeams.Visible = true;
            txt_vista.Hide();
            btn_BuscarJugador.Show();
            txt_BuscarJugador.Show();
            btn_TablaJugadores.Show();
            btn_regresarJugador.Show();
            btn_AgregarJugador.Show();
            btn_EliminarJugador.Show();
            btn_editarJugador.Show();
            label3.Show();

            btn_VerEquipos.Hide();
            btn_VerPartidos.Hide();
            btn_VerJugadores.Hide();
            RefreshDataGridViewPlayers();
            RefreshDataGridViewPlayers();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "btn_VerEquipos". Muestra la tabla de datos de equipos y
        /// los controles asociados para la gestión de equipos, mientras oculta otros elementos relacionados con 
        /// la visualización de equipos.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void btn_VerEquipos_Click(object sender, EventArgs e)
        {
            btn_InsertarEquipo.Show();
            btn_EliminarEquipo.Show();
            btn_buscar.Show();
            txt_buscar.Show();
            btn_editarEquipo.Show();
            lbl_nameEquipo.Show();

            button1.Show();
            btn_VerJugadores.Hide();
            btn_VerPartidos.Hide();
            btn_VerEquipos.Hide();
            button2.Show();
            btn_DatosJugadores.Hide();
            dataGridViewTeams.Visible = true;
            txt_vista.Hide();
            RefreshDataGridViewTeams();
            RefreshDataGridViewTeams();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "btn_VerPartidos". Actualiza la tabla de datos de partidos 
        /// y muestra los controles asociados para la gestión de partidos, mientras oculta otros elementos 
        /// relacionados con la visualización de partidos.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void btn_VerPartidos_Click(object sender, EventArgs e)
        {
            RefreshDataGridViewMatch();
            btn_buscarPartido.Show();
            btn_editarPartido.Show();
            btn_AgregarPartido.Show();
            btn_EliminarPartido.Show();
            btn_regresarPartido.Show();
            btn_editarPartido.Show();
            btn_verTablaLiga.Show();
            txt_buscarPartidos.Show();
            btn_VerEquipos.Hide();
            btn_VerJugadores.Hide();
            btn_VerPartidos.Hide();
            lbl_asistencia.Show();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "btn_regresarJugador". Restaura la interfaz de usuario a 
        /// la vista principal de jugadores, ocultando los elementos relacionados con la gestión de jugadores
        /// y mostrando los controles para navegar entre las distintas vistas.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void btn_regresarJugador_Click(object sender, EventArgs e)
        {
            dataGridViewTeams.DataSource = null;
            txt_vista.Text = "";
            txt_vista.Show();
            btn_TablaJugadores.Hide();
            dataGridViewTeams.Hide();
            btn_regresarJugador.Hide();
            txt_BuscarJugador.Hide();
            btn_BuscarJugador.Hide();
            btn_EliminarJugador.Hide();
            btn_AgregarJugador.Hide();
            btn_editarJugador.Hide();
            label3.Hide();
            btn_DatosPartidos.Show();
            btn_DatosEquipos.Show();
            btn_DatosJugadores.Show();
            btn_VerEquipos.Show();
            btn_VerJugadores.Show();
            btn_VerPartidos.Show();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "btn_BuscarJugador". Actualiza el DataGridView con la
        /// lista de jugadores y muestra la información del jugador buscado en el cuadro de texto "txt_vista" 
        /// si se encuentra, de lo contrario muestra un mensaje indicando que el jugador no fue encontrado.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los datos del evento.</param>

        private void btn_BuscarJugador_Click(object sender, EventArgs e)
        {
            RefreshDataGridViewPlayers();
            txt_vista.Text = "";
            txt_vista.Show();

            if (string.IsNullOrWhiteSpace(txt_BuscarJugador.Text))
            {
                MessageBox.Show("¡Ingrese el nombre del jugador!");
                return;
            }

            Player jugadorBuscado = (Player)listaS.BuscarPorNombre(txt_BuscarJugador.Text);
            if (jugadorBuscado != null)
            {
                dataGridViewTeams.Hide();
                MessageBox.Show("¡Jugador encontrado!");
                txt_vista.Text = $"JUGADOR ENCONTRADO{Environment.NewLine}" +
                    $"Nombre Jugador: {jugadorBuscado.fullName}{Environment.NewLine}" +
                    $"Edad: {jugadorBuscado.edad} años{Environment.NewLine}" +
                    $"Posición en que juega: {jugadorBuscado.posicion}{Environment.NewLine}" +
                    $"Equipo Actual: {jugadorBuscado.club}{Environment.NewLine}" +
                    $"Nacionalidad: {jugadorBuscado.nacionalidad}{Environment.NewLine}" +
                    $"Goles anotados: {jugadorBuscado.goles}{Environment.NewLine}" +
                    $"Asistencias: {jugadorBuscado.asistencias}{Environment.NewLine}" +
                    $"Tarjetas amarillas: {jugadorBuscado.TarjetaAmarilla}{Environment.NewLine}" +
                    $"Tarjetas rojas: {jugadorBuscado.TarjetaRoja}{Environment.NewLine}";
                txt_BuscarJugador.Text = "";
            }
            else
            {
                MessageBox.Show("¡Jugador no encontrado!");
                txt_vista.Text = "No se encontró el jugador buscado.";
                txt_BuscarJugador.Text = "";
            }
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "btn_TablaJugadores". Actualiza el DataGridView con la lista 
        /// de jugadores y oculta el cuadro de texto "txt_vista".
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void btn_TablaJugadores_Click(object sender, EventArgs e)
        {
            txt_vista.Hide();

            RefreshDataGridViewPlayers();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón. Actualiza el DataGridView con la lista de equipos
        /// y oculta el cuadro de texto "txt_vista".
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void button2_Click(object sender, EventArgs e)
        {
            txt_vista.Hide();
            RefreshDataGridViewTeams();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón. Muestra el formulario para agregar un nuevo jugador.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void button3_Click(object sender, EventArgs e)
        {
            AgregarJugador agregarJ = new AgregarJugador(this);
            agregarJ.Show();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "btn_EliminarJugador". Muestra el formulario para eliminar 
        /// un jugador.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void btn_EliminarJugador_Click(object sender, EventArgs e)
        {
            EliminarJugador eliminarJugador = new EliminarJugador(this);
            eliminarJugador.Show();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "btn_buscarPartido". Busca un partido utilizando su clave en 
        /// la tabla hash y muestra la información del partido si se encuentra.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void btn_buscarPartido_Click(object sender, EventArgs e)
        {
            if (txt_buscarPartidos.Text != "" )
            {
                int claveA = int.Parse(txt_buscarPartidos.Text);
                int claveB = miTabla.DispersionMod(claveA);
                LEHash = (ListaEnlazadHash)miTabla.Consultar(claveB);

                if (LEHash != null)
                {
                    Match PartidoBuscado = new Match("", "", "", "", 0, 0, "", int.Parse(txt_buscarPartidos.Text));
                    Object encontrado = LEHash.BuscarNodo(PartidoBuscado);
                    if (encontrado != null)
                    {
                        MessageBox.Show("Partido encontrado");
                        txt_buscarPartidos.Text = "";
                        dataGridViewTeams.Hide();
                        txt_vista.Show();
                        Match p = encontrado as Match;
                        txt_vista.Text = $"PARTIDO ENCONTRADO{Environment.NewLine}" +
                            $"Fecha: {p.fecha}{Environment.NewLine}" +
                            $"Estado: {p.estado}{Environment.NewLine}" +
                            $"Local: {p.local}[{p.golLocal}] vs Visitante: {p.visitante}[{p.golVisitante}]{Environment.NewLine}" +
                            $"Asistencia: {p.asistencia} {Environment.NewLine}";
                    }
                    else
                    {
                        txt_buscarPartidos.Text = "";
                        MessageBox.Show("Partido no encontrado");
                    }
                }
                else
                {
                    txt_buscarPartidos.Text = "";
                    MessageBox.Show("Partido no encontrado");
                }
            }
            else
            {
                txt_buscarPartidos.Text = "";
                MessageBox.Show("Ingrese el partido a buscar");
            }
        }

        /// <summary>
        /// Actualiza y muestra el DataGridView con la tabla de la liga de fútbol.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void btn_verTablaLiga_Click(object sender, EventArgs e)
        {
            RefreshDataGridViewMatch();
        }

        /// <summary>
        /// Abre la ventana para editar la información de un jugador si se ha proporcionado un nombre de
        /// jugador válido recuperando su información.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void btn_editarJugador_Click(object sender, EventArgs e)
            {
                if (txt_BuscarJugador.Text != "")
                {
                    Player jugadorBuscado = (Player)listaS.BuscarPorNombre(txt_BuscarJugador.Text);
                    if (jugadorBuscado != null)
                    {
                        EditarJugador editarJugador = new EditarJugador(this, jugadorBuscado);
                        editarJugador.Show();
                        txt_BuscarJugador.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("¡Jugador no encontrado!");                   
                        txt_BuscarJugador.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el nombre del jugador a editar");
                }
           
            }

        /// <summary>
        /// Abre la ventana para editar la información de un equipo si se ha proporcionado un nombre de
        /// equipo válido recuperando su información..
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void btn_editarEquipo_Click(object sender, EventArgs e)
        {
            if (txt_buscar.Text != "")
            {
                try
                {
                    Team EquipoBuscado = new Team(txt_buscar.Text, "", 0, 0, 0, 0, 0, 0, 0, 0);
                    Nodo resultado = arbolAVL.buscarIterativo(EquipoBuscado);

                    if (resultado != null)
                    {
                        Team res = (Team)resultado.valorNodo();
                        if (res != null)
                        {
                            EditarEquipo editarEquipo = new EditarEquipo(this, res);
                            editarEquipo.Show();
                            txt_buscar.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("El equipo no se encuentra.");
                            txt_buscar.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("El equipo no se encuentra.");
                        txt_buscar.Text = "";
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                MessageBox.Show("Ingresar equipo a buscar");
            }
        }

        /// <summary>
        /// Oculta los elementos relacionados con la visualización y edición de partidos y muestra los 
        /// botones para ver equipos, jugadores y partidos.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void btn_regresarPartido_Click(object sender, EventArgs e)
        {
            lbl_asistencia.Hide();
            txt_buscarPartidos.Hide();
            btn_buscarPartido.Hide();
            btn_editarPartido.Hide();
            btn_verTablaLiga.Hide();
            btn_EliminarPartido.Hide();
            btn_AgregarPartido.Hide();
            btn_regresarPartido.Hide();

            btn_VerEquipos.Show();
            btn_VerJugadores.Show();
            btn_VerPartidos.Show();

            dataGridViewTeams.Hide();
            txt_vista.Text = "";

        }

        /// <summary>
        /// Abre la ventana para eliminar un partido, pasando como parámetro la instancia de la tabla hash
        /// de partidos.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void btn_EliminarPartido_Click(object sender, EventArgs e)
        {
            EliminarPartido eliminarPartido = new EliminarPartido(this,miTabla);
            eliminarPartido.Show();
        }

        /// <summary>
        /// Abre la ventana para agregar un nuevo partido, pasando como parámetro la instancia de la tabla
        /// hash de partidos.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void btn_AgregarPartido_Click(object sender, EventArgs e)
        {
            AgregarPartido agregarPartido = new AgregarPartido(this,miTabla);
            agregarPartido.Show();
        }

        /// <summary>
        /// Abre la ventana de edición de un partido, pasando como parámetros esta instancia del formulario, 
        /// la tabla hash de partidos y la asistencia del partido a editar.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void btn_editarPartido_Click(object sender, EventArgs e)
        {
            if (txt_buscarPartidos.Text != "")
            {
                EditarPartido editarPartido = new EditarPartido(this, miTabla, int.Parse(txt_buscarPartidos.Text));
                editarPartido.Show();
                txt_buscarPartidos.Text = "";
            }
            else
            {
                MessageBox.Show("Ingrese la asistencia del partido");
            }
           
        }
    }
}
