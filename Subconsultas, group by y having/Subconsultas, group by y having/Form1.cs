using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Subconsultas__group_by_y_having
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Server=(localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BDclientes.mdf;Integrated Security=True;"; public Form1()
        {
            InitializeComponent();
            dgvHaving.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                this.ventasTableAdapter.Fill(this.bDclientesDataSet.Ventas);
            }
            catch
            {
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultarFechas_Click(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dtpFechaFiltro.Value.Date;

            string query = "SELECT Id, Cliente, Monto, FechaVenta FROM Ventas WHERE FechaVenta >= @FechaFiltro ORDER BY FechaVenta DESC";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@FechaFiltro", fechaSeleccionada);

                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable dt = new DataTable();

                    adaptador.Fill(dt);

                    dgvFechas.DataSource = dt;
                }
            }
        }

        private void btnFiltrarHaving_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtUmbral.Text, out decimal umbral))
            {
                MessageBox.Show("Por favor, ingrese un monto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"SELECT Cliente, 
                    SUM(Monto) AS [Total Comprado Acumulado ($)]
                    FROM Ventas
                    GROUP BY Cliente
                    HAVING SUM(Monto) > @Umbral
                    ORDER BY [Total Comprado Acumulado ($)] DESC";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Umbral", umbral);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvHaving.DataSource = dt;
                    }
                }
            }
        }
    
    }
    
}