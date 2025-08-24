using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Tutorial_Giordano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Text;
                string senha = txtSenha.Text;

                if (txtUsuario.Text != "" && txtSenha.Text != "")
                {
                    string conexaoBanco = "Server=localhost; Database=SistemaLogin; Uid=root;Pwd='';";
                    MySqlConnection conexao = new MySqlConnection(conexaoBanco);
                    conexao.Open();

                    string consultaUsuario = "select * from usuarios where usuario = @usuario and senha = @senha";
                    MySqlCommand comandoSQL = new MySqlCommand(consultaUsuario, conexao);
                    comandoSQL.Parameters.AddWithValue("@usuario", usuario);
                    comandoSQL.Parameters.AddWithValue("@senha", senha);

                    int registro = Convert.ToInt32(comandoSQL.ExecuteScalar());

                    if (registro > 0)
                    {
                        lblResultado.Text = "Login realizado com sucesso";
                        lblResultado.ForeColor = Color.Green;
                    }

                    else 
                    {
                        lblResultado.ForeColor = Color.Red;
                        lblResultado.Text = "Usuário ou senha incorretos";
                    }

                    conexao.Clone();


                }

                else
                {
                    MessageBox.Show("Atenção: Preencha os campos corretamente!", "Aviso - Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsuario.Focus();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel realizar o loguin: "+ ex.Message, "Erro - loguin não realizado ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
