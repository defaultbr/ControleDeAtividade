using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ControleDeAtividade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txt_usuario.Text.Length == 0 || txt_senha.Text.Length == 0)
            {
                MessageBox.Show("Usuário e Senha devem ser preenchidos", "Erro");
            } else
            {
                bool logado = false;
                String sql = "SELECT * FROM usuario WHERE username = '"+txt_usuario.Text.ToString()+ "' AND password = '" + txt_senha.Text.ToString() + "'";
                try {
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, Connection.getConexao());
                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        logado = true;
                    }
                } catch(Exception ex)
                {
                    throw new Exception(ex.Message);
                }

                if(!logado)
                {
                    MessageBox.Show("Usuário ou Senha incorretos", "Erro");
                } else

                {
                    MessageBox.Show("Usuário identificado", "Ok");
                }
            }
        }
    }
}
