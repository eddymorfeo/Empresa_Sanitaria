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

namespace Empresa_Sanitaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //SqlConnection coneccion = new SqlConnection("Server=DESKTOP-H5HPE9G; database=Empresa_Sanitaria; integrated security= true");

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            //coneccion.Open();
            SqlCommand comando = new SqlCommand("select nombre_usu, clave from usuario where nombre_usu=@usu and clave=@pass", Conexion.Conectar());
            comando.Parameters.AddWithValue("@usu", txt_usuario.Text);
            comando.Parameters.AddWithValue("@pass", txt_contrasena.Text);

            SqlDataReader lector = comando.ExecuteReader();

            if (lector.Read())
            {    
                this.Dispose(false);
                Registro_Requerimiento pantalla = new Registro_Requerimiento();
                pantalla.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
