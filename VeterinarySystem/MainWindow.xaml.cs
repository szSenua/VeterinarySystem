using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace VeterinarySystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void consultar_Click(object sender, EventArgs e)
        {

            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Database=veterinaria;username=root;password=");
            connection.Open();
            MySqlCommand cmd1 = new MySqlCommand("Select clientes.nombre as nombre_cliente, clientes.apellidos as apellidos, clientes.direccion as direccion, clientes.telefono as telefono, mascota.nombre as nombre_mascota, mascota.raza as raza, mascota.edad as edad from clientes" +
                " inner join  mascota on DNI = mascota.DNI_Cliente", connection);
            cmd1.Parameters.AddWithValue("DNI", dnitext.Text);
            MySqlDataReader reader;
            reader = cmd1.ExecuteReader();
            if (reader.Read())
            {
                //llamo a la ventana donde voy a mostrar los datos
                MuestraDatos datos = new MuestraDatos();


                datos.nombreShow.Text = reader["nombre_cliente"].ToString();
                datos.apellidosShow.Text = reader["apellidos"].ToString();
                datos.direccionShow.Text = reader["direccion"].ToString();
                datos.telefonoShow.Text = reader["telefono"].ToString();

                datos.nombreMascotaShow.Text = reader["nombre_mascota"].ToString();
                datos.razaShow.Text = reader["raza"].ToString();
                datos.edadShow.Text = reader["edad"].ToString();


                datos.Show();
            }
            else
            {
                MessageBox.Show("No data found");
            }

            connection.Close();
        }
    }
}
