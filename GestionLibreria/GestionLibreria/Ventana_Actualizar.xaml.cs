using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
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
using System.Windows.Shapes;

namespace GestionLibreria
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Ventana_Actualizar : Window
    {
        SqlConnection miConexionSql;
        private int identificadorCliente;
        public Ventana_Actualizar(int id)
        {
            InitializeComponent();
            identificadorCliente = id;
            string miconexion = ConfigurationManager.ConnectionStrings["GestionLibreria.Properties.Settings.GestionLibreriaConnectionString"].ConnectionString;
            miConexionSql = new SqlConnection(miconexion);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string consulta = "UPDATE CLIENTES SET nombreCliente = @nombre WHERE idCliente = " + identificadorCliente;
            SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);
            miConexionSql.Open();
            miSqlCommand.Parameters.AddWithValue("@nombre", TextBox_Actualizar.Text);
            miSqlCommand.ExecuteNonQuery();
            miConexionSql.Close();
            this.Close();
        }
    }
}
