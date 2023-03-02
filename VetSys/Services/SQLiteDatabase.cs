using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Windows.Controls;

namespace VetSys.Services
{
    class SQLiteDatabase
    {
        //Functions
       

        public void createDB()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Services");
            string dbName = "veterinaria.sqlite";

            string dbPath = Path.Combine(directoryPath, dbName);

            Console.WriteLine("La ruta es: " + directoryPath);


            if (!File.Exists(dbPath))
            {
               
                    SQLiteConnection.CreateFile("veterinaria.sqlite");
                    

                    string connectionString = $"Data Source={dbPath};Version=3;";
                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();

                        // Ejecutar el script
                        SQLiteCommand command = new SQLiteCommand();
                        command = connection.CreateCommand();
                        command.CommandText= @"CREATE TABLE IF NOT EXISTS 'clientes' (
                                            'DNI'   TEXT,
	                                        'nombre'    TEXT,
	                                        'apellidos' TEXT,
	                                        'direccion' TEXT,
	                                        'telefono'  TEXT,
	                                        'email' TEXT,
	                                        PRIMARY KEY('DNI')
                        ); 


                                            CREATE TABLE IF NOT EXISTS 'mascotas' (
                                            'DNI_Cliente'   TEXT,
	                                        'nombre'    TEXT,
	                                        'raza'  TEXT,
	                                        'edad'  TEXT,
	                                        'peso'  INTEGER,
	                                        PRIMARY KEY('DNI_Cliente'),
	                                        FOREIGN KEY('DNI_Cliente') REFERENCES 'clientes'('DNI') ON DELETE SET NULL
                        ); 
                                            INSERT INTO 'clientes' ('DNI','nombre','apellidos','direccion','telefono','email') VALUES
                                            ('54555666G', 'Sara', 'Orrego Martín', 'C/Falsa, 5', '657889900', 'sara@lol.com');
                                        INSERT INTO 'mascotas'('DNI_Cliente', 'nombre', 'raza', 'edad', 'peso') VALUES ('54555666G', 'Lulu', 'perro', 4, 5);

                        ";

                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                
                
            }
            else
            {
                Console.WriteLine("La base de datos ya existe.");
            }


        }

        public string DataConnection()
        {
            string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "Services");
            string dbName = "veterinaria.sqlite";

            string dbPath = Path.Combine(directoryPath, dbName);

            String connectionString = $"Data Source={dbPath};Version=3;";

            return connectionString;
        }      
    }
}


    

