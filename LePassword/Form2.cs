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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void registro()
        {
            string connect = "datasource=localhost;port=3306;username=root;password=;database=leincriptation";
            string query = "INSERT INTO user(`id`,`username`,`password`) VALUES (NULL, '" + textBox1.Text + "',SHA1('" + textBox2.Text + "' ))";
            MySqlConnection databaseConnection = new MySqlConnection(connect);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;


            try
            {
                databaseConnection.Open();
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                MessageBox.Show("Usuario Registrado");
                databaseConnection.Close();
                textBox1.Text = "";
                textBox2.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            registro();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

