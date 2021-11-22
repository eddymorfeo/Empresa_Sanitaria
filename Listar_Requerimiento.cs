using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa_Sanitaria
{
    public partial class Listar_Requerimiento : Form
    {
        public Listar_Requerimiento()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose(false);
            Registro_Requerimiento pantalla = new Registro_Requerimiento();
            pantalla.Show();
        }
    }
}
