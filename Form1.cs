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

namespace WinFormCRUD
{
    public partial class Form1 : Form
    {
        MySqlConnection connection;
        MySqlCommand command;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "Gyumolcsok";
            connection = new MySqlConnection(builder.ConnectionString);
            try
            {
                connection.Open();
                command = connection.CreateCommand();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + "Program leáll!");
                Environment.Exit(0);
            }
            finally
            {
                connection.Close();
            }
            Gyumik_Update();
        }

       
        
        
        
        
        
        private void Gyumik_Update()
        {
            listBox_fruits.Items.Clear();
            try
            {
                command.CommandText = "SELECT * FROM `gyumolcs` WHERE 1;";
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (MySqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        fruit beolvasott = new fruit(dr.GetString("nev"), dr.GetInt32("ar"), dr.GetInt32("db"), dr.GetDateTime("beszerzese"));
                        listBox_fruits.Items.Add(beolvasott);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                connection.Close();
            }
        }

       
        
        
        
        
        private void listBox_fruits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_fruits.SelectedIndex < 0)
            {
                return;
            }
            fruit kivalasztottTag = (fruit)listBox_fruits.SelectedItem;
            textBox_nev.Text = kivalasztottTag.Nev;
            textBox_ar.Text = kivalasztottTag.Ar.ToString();
            textBox_db.Text = kivalasztottTag.Db.ToString();
            textBox_date.Text = kivalasztottTag.Beszerzes.ToString("yyyy-MM-dd");
        }

        
        
        
        
        
        
        private bool vannak_adatok()
        {
            if (string.IsNullOrEmpty(textBox_nev.Text))
            {
                MessageBox.Show("Nem adott meg nevet!");
                textBox_nev.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBox_ar.Text))
            {
                MessageBox.Show("Nem adott meg országot!");
                textBox_ar.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBox_db.Text))
            {
                MessageBox.Show("Nem adott meg nevet!");
                textBox_db.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBox_date.Text))
            {
                MessageBox.Show("Nem adott meg országot!");
                textBox_date.Focus();
                return false;
            }
            return true;
        }

       
        
        
        
        
        
        
        private void button_update_Click(object sender, EventArgs e)
        {
            if (!vannak_adatok())
            {
                return;
            }
            command.CommandText = "UPDATE `gyumolcs` SET `ar`=@ar,`db`=@db,`beszerzese`=@date WHERE `nev`=@nev";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nev", textBox_nev.Text);
            command.Parameters.AddWithValue("@ar", textBox_ar.Text);
            command.Parameters.AddWithValue("@db", textBox_db.Text);
            command.Parameters.AddWithValue("@date", textBox_date.Text);
            connection.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Módosítás végrahajtva!");
                textBox_nev.Text = "";
                textBox_ar.Text = "";
                textBox_db.Text = "";
                textBox_date.Text = "";
                connection.Close();
                Gyumik_Update();
            }
            else
            {
                MessageBox.Show("Módosítás sikertelen!");
            }
            connection.Close();
        }
    }
}
