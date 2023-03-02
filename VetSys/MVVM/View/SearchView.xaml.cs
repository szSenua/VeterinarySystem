using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Data.SQLite;
using System.IO;
using Path = System.IO.Path;

namespace VetSys.MVVM.View
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

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Services");

            Console.WriteLine("La ruta es: " + directoryPath);
            string dbName = "veterinaria.sqlite";

            string dbPath = Path.Combine(directoryPath, dbName);

            using (SQLiteConnection connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                connection.Open();


                // Consulta
                String query = "SELECT nombre, apellidos, direccion, telefono, email from clientes where DNI = '"+dnitext.Text+ "'";
                SQLiteCommand createCommand = new SQLiteCommand(query, connection);

               createCommand.Parameters.AddWithValue("$DNI", dnitext.Text);

                SQLiteDataReader reader = createCommand.ExecuteReader();

                while (reader.Read())
                {
                    string name = reader.GetString(1).ToString();
                    string apellido = reader.GetString(2).ToString();
                    string direccion = reader.GetString(3).ToString();
                    string telefono = reader.GetString(4).ToString();
                    string email = reader.GetString(5).ToString();

                    nombretext.Text = name;
                    apellidotext.Text = apellido;
                    direcciontext.Text = direccion;
                    telefonotext.Text = telefono;
                    emailtext.Text = email;
                }
   
                
            }

        }
    }
}
