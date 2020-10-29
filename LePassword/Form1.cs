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

namespace LePassword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Registrar()
        {
            string connect = "datasource=localhost;port=3306;username=root;password=;database=leincriptation";
            string query = "SELECT * from user where username = '" + textBox1.Text + "' AND password = SHA1 ('"+ textBox2.Text + "'))";
            MySqlConnection databaseConnection = new MySqlConnection(connect);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                textBox1.Text = "";
                textBox2.Text = "";

                if (reader.Read())
                {
                    MessageBox.Show("Sea usted bienvenido.");
                    databaseConnection.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registrar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 registrar = new Form2();
            registrar.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
