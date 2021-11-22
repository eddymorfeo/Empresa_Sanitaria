using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Empresa_Sanitaria
{
    class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection con = new SqlConnection("Server=DESKTOP-H5HPE9G; database=Empresa_Sanitaria; integrated security= true");
            con.Open();
            return con;
        }
    }
}
