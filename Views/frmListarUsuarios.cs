using AirSystem2.Models;
using AirSystem2.Repositories;
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
    public partial class frmListarUsuarios : Form
    {
        UsuarioRepository repository = new UsuarioRepository();
        public frmListarUsuarios()
        {
            InitializeComponent();
        }

        private void frmListarUsuarios_Load(object sender, EventArgs e)
        {
            carregaLista();
        }

        private void btnNovoLista_Click(object sender, EventArgs e)
        {
            new frmNovoUsuario().ShowDialog();
            carregaLista();
        }
        private void dgvListaAluno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linha = dataGridView1.Rows[e.RowIndex];

            string nome = linha.Cells[1].Value.ToString();
            string sobrenome = linha.Cells[2].Value.ToString();

            int codigo = Convert.ToInt32(linha.Cells[0].Value.ToString());

            Usuario usuario = new Usuario
            {
                codigo = codigo,
                nome = nome,
                sobrenome = sobrenome,
            };

            new frmNovoUsuario(usuario).ShowDialog();

            carregaLista();
        }

        private void dgvListaAluno_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DialogResult dr = MessageBox.Show("Deseja excluir este usuário?", "Atenção"
                    , MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    DataGridViewRow linha = dataGridView1.Rows[e.RowIndex];

                    int codigo = Convert.ToInt32(linha.Cells[0].Value.ToString());

                    repository.deletar(codigo);

                    carregaLista();
                }
            }
        }
        private void carregaLista()
        {
            UsuarioRepository repository = new UsuarioRepository();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = repository.buscarTodos();
            alterarContador();
        }
        private void filtroTextbox_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = repository.buscarTodos().FindAll(x =>
                x.nome.ToUpper().Contains(textBox1Lista.Text.ToUpper()) ||
                x.sobrenome.ToUpper().Contains(textBox1Lista.Text.ToUpper())
            );

            alterarContador();

        }
        private void alterarContador()
        {
            lblContador.Text = $"{dataGridView1.RowCount} itens de {repository.buscarTodos().Count}";
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Arquivos de imagens(*.jpg;*.png)|*.jpg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnDeletarFtLista_Click(object sender, EventArgs e)
        {
            btnAlterar.Image = null;
        }

        private void textBox1Lista_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
