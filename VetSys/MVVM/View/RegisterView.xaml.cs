using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using SQLite;
using VetSys.MVVM.Model;

namespace VetSys.MVVM.View
{
    /// <summary>
    /// Lógica de interacción para RegisterView.xaml
    /// </summary>
    public partial class RegisterView : UserControl
    {
        public RegisterView()
        {
            InitializeComponent();
        }

        public void btn_register_Click(object sender, RoutedEventArgs e)
        {
            if (System.IO.File.Exists("vetsys.db")) { }
            else
            {
                System.IO.File.Create("vetsys.db");
                var db_create = new SQLiteConnection("vetsys.db");
                db_create.CreateTable<Clientes>();
                db_create.CreateTable<Mascota>();
                db_create.Close();

            }
            int edadconvertida;
            int pesoconvertido;

            var cliente = new Clientes()
            {
                DNI = dnitext.Text,
                nombre = nombretext.Text,
                apellidos = apellidotext.Text,
                direccion = direcciontext.Text,
                telefono = telefonotext.Text,
                email = emailtext.Text

            };

            bool success1 = int.TryParse(edadmascotatext.Text.ToString(), out edadconvertida);
            bool success2 = int.TryParse(pesomascotatext.Text.ToString(), out pesoconvertido);


            var mascota = new Mascota()
            {
                nombre = nombremascotatext.Text,
                raza = razamascotatext.Text,

                edad = edadconvertida,
                DNI_Cliente = dnitext.Text,

                peso = pesoconvertido
            };

            try
            {
                var db = new SQLiteConnection("vetsys.db");
                db.Tracer = new Action<string>(q => Debug.WriteLine(q));
                db.Trace = true;
                int rowcliente = db.Insert(cliente);
                int rowMascota = db.Insert(mascota);
                db.Close();
            }catch(SQLiteException sqle)
            {
                Console.WriteLine(sqle);
            }

            //if (rowcliente > 0 && rowMascota > 0)
            //{
              //  MessageBox.Show("Registro realizado con éxito" + cliente.ToString() + " " + mascota.ToString() + cliente.DNI.ToString());
            //}



        }
     }
}
