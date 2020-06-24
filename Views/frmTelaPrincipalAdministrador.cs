using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem2.Views
{
    public partial class frmTelaPrincipalAdministrador : Form
    {
        public frmTelaPrincipalAdministrador()
        {
            InitializeComponent();
        }

        private void btnListarUsu_Click(object sender, EventArgs e)
        {
            new frmListarUsuarios().ShowDialog();
        }
    }
}
