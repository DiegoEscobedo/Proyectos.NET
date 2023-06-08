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
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Controls.Primitives;
using System.Data;

namespace GestionLibreria
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string miconexion = ConfigurationManager.ConnectionStrings["GestionLibreria.Properties.Settings.GestionLibreriaConnectionString"].ConnectionString;
            miConexionSql = new SqlConnection(miconexion);
            Muestraclientes();
        }
        SqlConnection miConexionSql;
        private void Muestraclientes()
        {
            string consulta = "SELECT * FROM CLIENTES";
            SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consulta, miConexionSql);
            using (miAdaptadorSql)
            {
                DataTable clientesTabla = new DataTable();
                miAdaptadorSql.Fill(clientesTabla);
                listaClientes.DisplayMemberPath = "nombreCliente";
                listaClientes.SelectedValuePath = "IdCliente";
                listaClientes.ItemsSource = clientesTabla.DefaultView;
            }
        }

        private void MuestraPedidos()
        {
            if (listaClientes.SelectedItem != null)
            {

                int clienteId = (int)((DataRowView)listaClientes.SelectedItem)["IdCliente"];
                string consulta = "SELECT  PEDIDOS.formaPago " +
                          "FROM PEDIDOS INNER JOIN CLIENTES " +
                          "ON PEDIDOS.IdCliente = CLIENTES.IdCliente " +
                          "WHERE CLIENTES.IdCliente = @clienteId";
                SqlCommand sqlComando = new SqlCommand(consulta, miConexionSql);
                sqlComando.Parameters.AddWithValue("@clienteId", clienteId);
                SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(sqlComando);
                using (miAdaptadorSql)
                {
                    DataTable pedidosTabla = new DataTable();
                    miAdaptadorSql.Fill(pedidosTabla);
                    listaPedidos.DisplayMemberPath = "formaPago";
                    listaPedidos.SelectedValuePath = "IdPedido";
                    listaPedidos.ItemsSource = pedidosTabla.DefaultView;
                }
            }
        }

        private void listaClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MuestraPedidos();
            MuestraTodosPedidos();
        }
        private void MuestraTodosPedidos()
        {
            string consulta = "SELECT *, CONCAT(idCliente, ' ',fechaPedido, ' ', formaPago) AS INFO FROM PEDIDOS";
            SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consulta, miConexionSql);
            using (miAdaptadorSql)
            {
                DataTable pedidosTabla = new DataTable();
                miAdaptadorSql.Fill(pedidosTabla);
                todosPedidos.DisplayMemberPath = "INFO";
                todosPedidos.SelectedValuePath = "IdPedido";
                todosPedidos.ItemsSource = pedidosTabla.DefaultView;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string consulta = "DELETE FROM PEDIDOS WHERE IdPedido=@PEDIDOID";
            SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);
            miConexionSql.Open();
            miSqlCommand.Parameters.AddWithValue("@PEDIDOID", todosPedidos.SelectedValue);
            miSqlCommand.ExecuteNonQuery();
            miConexionSql.Close();
            MuestraTodosPedidos();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string consulta = "INSERT INTO CLIENTES (nombreCliente) VALUES (@nombre)";
            SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);
            miConexionSql.Open();
            miSqlCommand.Parameters.AddWithValue("@nombre", insertaCliente.Text);
            miSqlCommand.ExecuteNonQuery();
            miConexionSql.Close();
            Muestraclientes();
        }
        private void Button_Click_Borrar(object sender, RoutedEventArgs e)
        {
            string consulta = "DELETE FROM clientes WHERE IdCliente=@CLIENTEID";
            SqlCommand miSqlCommand1 = new SqlCommand(consulta, miConexionSql);
            miConexionSql.Open();
            miSqlCommand1.Parameters.AddWithValue("@CLIENTEID", listaClientes.SelectedValue);
            miSqlCommand1.ExecuteNonQuery();
            miConexionSql.Close();
            Muestraclientes();
        }

        private void btn_actualizar_Click(object sender, RoutedEventArgs e)
        {
            Ventana_Actualizar ventanaActualizar = new Ventana_Actualizar((int)listaClientes.SelectedValue);
            ventanaActualizar.Show();
            try
            {
                string consulta = "SELECT nombreCliente FROM CLIENTES WHERE idCliente = @CLid";

                SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);
                SqlDataAdapter miAdaptadorSQL = new SqlDataAdapter(miSqlCommand);
                using (miAdaptadorSQL)
                {
                    miSqlCommand.Parameters.AddWithValue("@CLid", listaClientes.SelectedValue);
                    DataTable clientesTabla = new DataTable();
                    miAdaptadorSQL.Fill(clientesTabla);
                    ventanaActualizar.TextBox_Actualizar.Text = clientesTabla.Rows[0]["nombreCliente"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            Muestraclientes();
        }
    }
        
}
