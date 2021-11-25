using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace gerenciamento_db
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();




        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            SqlConnection conexao = new SqlConnection("Server=DESKTOP-IJEN2GO;Database=filmes_series;Trusted_Connection=True;");
            SqlCommand comando;
            comando = new SqlCommand("SELECT * FROM lista", conexao);

            conexao.Open();
            SqlDataReader leitorDados = comando.ExecuteReader();

            while (leitorDados.Read())
            {
                listBox1.Items.Add(leitorDados[0] + " - " + leitorDados[1] + " - " + leitorDados[2] + " - " + leitorDados[3] + " - " + leitorDados[4]);
            }
            conexao.Close();

            pictureBox1.ImageLocation = @"C:\Users\Guilherme Rodrigues\source\repos\gerenciamento_db\gerenciamento_db\Resources\download (1).jpg";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection("Server=DESKTOP-IJEN2GO;Database=filmes_series;Trusted_Connection=True;");
            SqlCommand comando;
            string strSQL = "INSERT INTO lista (nome, lancamento, servico_que_assistiu, nota) VALUES (@nome, @lancamento, @servico_que_assistiu, @nota)";

            comando = new SqlCommand(strSQL, conexao);

            comando.Parameters.AddWithValue("@nome", textBox3.Text);
            comando.Parameters.AddWithValue("@lancamento", textBox4.Text);
            comando.Parameters.AddWithValue("@servico_que_assistiu", textBox5.Text);
            comando.Parameters.AddWithValue("@nota", textBox6.Text);

            conexao.Open();
            comando.ExecuteNonQuery();

            MessageBox.Show("Listado com Sucesso!");
            conexao.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"C:\Users\Guilherme Rodrigues\source\repos\gerenciamento_db\gerenciamento_db\Resources\818a255c7d3bda1bcb554ee08e2c0980 (1).jpg";
            listBox1.Items.Clear();
        }
    }
}
