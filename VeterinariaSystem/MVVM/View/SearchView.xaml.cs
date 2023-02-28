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

namespace VeterinariaSystem.MVVM.View
{
    /// <summary>
    /// Lógica de interacción para SearchView.xaml
    /// </summary>
    public partial class SearchView : UserControl
    {
        public SearchView()
        {
            InitializeComponent();
        }

        private void consultar_Click(object sender, EventArgs e)
        {

            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Database=veterinaria;username=root;password=");
            connection.Open();
            MySqlCommand cmd1 = new MySqlCommand("Select clientes.nombre as nombre_cliente, clientes.apellidos as apellidos, clientes.direccion as direccion, clientes.telefono as telefono, clientes.email as email, mascota.nombre as nombre_mascota, mascota.raza as raza, mascota.edad as edad from clientes" +
                " inner join  mascota on DNI = mascota.DNI_Cliente", connection);
            cmd1.Parameters.AddWithValue("DNI", dnitext.Text);
            MySqlDataReader reader;
            reader = cmd1.ExecuteReader();
            if (reader.Read())
            {
              
                


                nombretext.Text = reader["nombre_cliente"].ToString();
                apellidotext.Text = reader["apellidos"].ToString();
                direcciontext.Text = reader["direccion"].ToString();
                telefonotext.Text = reader["telefono"].ToString();
                emailtext.Text = reader["email"].ToString();

                nombremascotatext.Text = reader["nombre_mascota"].ToString();
                razamascotatext.Text = reader["raza"].ToString();
                edadmascotatext.Text = reader["edad"].ToString();


                
            }
            else
            {
                MessageBox.Show("No data found");
            }

            connection.Close();
        }
    
}
}
