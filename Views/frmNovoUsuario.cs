using AirSystem2.Models;
using AirSystem2.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem2.Views
{
    public partial class frmNovoUsuario : Form
    {
        private Usuario usuario = null;
        public frmNovoUsuario()
        {
            InitializeComponent();
        }
        public frmNovoUsuario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!Utils.temCamposVazio(this))
            {
                UsuarioRepository repository = new UsuarioRepository();
                if (this.usuario == null)
                {
                    Usuario usuario = new Usuario
                    {
                        nome = textBox1.Text,
                        sobrenome = textBox2.Text
                    };

                    repository.adicionar(usuario);

                    MessageBox.Show("Dados Salvos.",
                                    "Aviso", MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);

                }
                else
                {
                    this.usuario.nome = textBox1.Text;
                    this.usuario.sobrenome = textBox2.Text;

                    repository.editar(usuario);
                }
                this.Close();

            }
            else
            { 
                MessageBox.Show("Todos os campos são obrigatórios.",
                                "Aviso", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
        }

        bool isValidEmail;
        private void textBox5_TextChanged(object sender, EventArgs e)
        { 
            string pattern = "[a-z]{3,}[.][a-z]{3,}[@][a-z]{3,}[.][a-z]{2,3}";
            isValidEmail = Regex.IsMatch(textBox5.Text, pattern);
            lblEmail.Visible = false;
        }

        private void btn1Alterar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Arquivos de imagens(*.jpg;*.png)|*.jpg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }
        private void btnDeletarA_Click(object sender, EventArgs e)
        {
            btn1Alterar.Image = null;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string pattern = "[A-Z]{1}[a-z]{1,}[0-9]{1,}";

            textBox7.Visible = !Regex.IsMatch(textBox6.Text, pattern);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

            if (textBox6 == textBox7)
            {
                MessageBox.Show("As senhas são iguais");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
