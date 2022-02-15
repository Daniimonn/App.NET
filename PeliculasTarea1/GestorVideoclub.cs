using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeliculasTarea1
{
    public partial class GestorVideoclub : Form
    {
        public GestorVideoclub()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'videoclubDataSet.Peliculas' Puede moverla o quitarla según sea necesario.
            this.peliculasTableAdapter.Fill(this.videoclubDataSet.Peliculas);

        }

        private void peliculasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.peliculasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.videoclubDataSet);

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.VideoclubConnectionString))
            {
                using (SqlCommand command = new SqlCommand("dbo.proInsert", connection))
                {


                    command.CommandType = CommandType.StoredProcedure;


                    command.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));
                    command.Parameters["@nombre"].Value = Convert.ToString(this.NombreTextBox.Text);

                    command.Parameters.Add(new SqlParameter("@director", SqlDbType.VarChar));
                    command.Parameters["@director"].Value = Convert.ToString(this.DirectorTextBox.Text);

                    command.Parameters.Add(new SqlParameter("@sinopsis", SqlDbType.Text));
                    command.Parameters["@sinopsis"].Value = Convert.ToString(this.SinopsisTextBox.Text);

                    command.Parameters.Add(new SqlParameter("@genero", SqlDbType.VarChar));
                    command.Parameters["@genero"].Value = Convert.ToString(this.GeneroTextBox.Text);


                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        this.peliculasTableAdapter.Fill(videoclubDataSet.Peliculas);
                        connection.Close();
                        MessageBox.Show("Insertado Correctamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnCerrarGestor_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
