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
using System.Data.SQLite;

namespace VetSys.MVVM.View
{
    /// <summary>
    /// Lógica de interacción para MascotaView.xaml
    /// </summary>
    public partial class MascotaView : UserControl
    {
        public MascotaView()
        {
            InitializeComponent();
        }

        public static void consulta_Click(object sender, RoutedEventArgs e)
        {
            // Define a connection string to the SQLite database
            string connectionString = "Data Source=mydatabase.sqlite;Version=3;";

            // Write a query to retrieve the data from the database
            string query = "SELECT * FROM MyTable";

            // Create a SQLiteConnection object to connect to the database
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                // Open the database connection
                connection.Open();

                // Create a SQLiteCommand object to execute the query
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    // Create a SQLiteDataReader object to read the data from the query results
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        // Read the data from the SQLiteDataReader object and assign it to the TextBox
                        while (reader.Read())
                        {
                            string data = reader.GetString(0); // Assume the data is in the first column
                            
                        }
                    }
                }
            }
        }

    }
}
