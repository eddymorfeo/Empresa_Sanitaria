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
    public partial class Registro_Requerimiento : Form
    {
        public Registro_Requerimiento()
        {
            InitializeComponent();
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            this.Dispose(false);
            Listar_Requerimiento pantalla = new Listar_Requerimiento();
            pantalla.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Registro_Requerimiento_Load(object sender, EventArgs e)
        {
            //Llenado de ComboBox Tipos de Requerimientos
            SqlCommand query1 = new SqlCommand("select id,nombre from requerimiento_tipos", Conexion.Conectar());
            SqlDataReader req_tipo = query1.ExecuteReader();

            while (req_tipo.Read())
            {
                cmb_tipo_requerimiento.Items.Add(req_tipo["nombre"].ToString());
                cmb_tipo_requerimiento.DisplayMember=(req_tipo["nombre"].ToString());
                cmb_tipo_requerimiento.ValueMember=(req_tipo["id"].ToString());
            }

            //Llenado de ComboBox Usuarios
            SqlCommand query2 = new SqlCommand("select id, nombre_usu from usuario", Conexion.Conectar());
            SqlDataReader usu = query2.ExecuteReader();

            while (usu.Read())
            {
                cmb_asignar.Items.Add(usu["nombre_usu"].ToString());
            }

            //Llenado de ComboBox Prioridades
            SqlCommand query3 = new SqlCommand("select nombre from prioridad", Conexion.Conectar());
            SqlDataReader pri = query3.ExecuteReader();

            while (pri.Read())
            {
                cmb_prioridad.Items.Add(pri["nombre"].ToString());
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string query = "insert into requerimiento (descripcion,requerimiento_tipo_id, usuario_id, prioridad_id, estado_id) values (@desc,@req,@usu, @prio,1)";
            //string query2 = "select dias from prioridad where nombre=@prio";

            // SqlCommand comando2 = new SqlCommand(query2, Conexion.Conectar());
            
            SqlCommand comando = new SqlCommand(query, Conexion.Conectar());
            
                
                



            comando.Parameters.AddWithValue("@desc", txt_descripcion.Text);            
            comando.Parameters.AddWithValue("@req", cmb_tipo_requerimiento.Text);            
            comando.Parameters.AddWithValue("@usu", cmb_asignar.Text);            
            comando.Parameters.AddWithValue("@prio", cmb_prioridad.Text);
            
            comando.ExecuteNonQuery();
            //comando2.ExecuteNonQuery();
            //MessageBox.Show("El requerimiento fue ingresado, el plazo para resolverlo es " +query2+ " días");
        }
    }
}
