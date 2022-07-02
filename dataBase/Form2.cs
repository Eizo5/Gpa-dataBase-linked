using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPII_PROJECT 
{

                                                            //THIS PROJECT HAS BEEN DONE BY ABDULAZIZ FAHAM(200209984) & ABDULAZIZ KATTAN(200209911) 
    public partial class Form2 : Form
    {
        public String stringConnection = "data source=localhost\\SQLEXPRESS;initial catalog=Transcrpit;Integrated Security=true";
        SqlConnection connection = null;
        public Form2()
        {
            InitializeComponent();
        }

        public void connect()
        {
            connection = new SqlConnection(stringConnection);
            connection.Open();

        }

        private void goBack_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            connect();
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.CommandText = "INSERT INTO grades (courseName, courseCode, etcsCriedts, letterGrade, semester) VALUES (@courseName, @courseCode, @etcsCriedts, @letterGrade, @semester)";
            sqlcommand.Connection = connection;

            sqlcommand.Parameters.AddWithValue("@courseName", nameTxt.Text);
            sqlcommand.Parameters.AddWithValue("@courseCode", codeTxt.Text);
            sqlcommand.Parameters.AddWithValue("@etcsCriedts", criedtsTxt.Text);
            sqlcommand.Parameters.AddWithValue("@letterGrade", gradesDropDown.Text);
            sqlcommand.Parameters.AddWithValue("@semester", semsterDropDown.Text);
            sqlcommand.ExecuteNonQuery();
            Notify.Text = $"{ nameTxt.Text } has been added";
            connection.Close();
            
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            nameTxt.Clear();
            codeTxt.Clear();
            criedtsTxt.Clear();
            gradesDropDown.SelectedIndex = -1;
            semsterDropDown.SelectedIndex = -1;
        }
    }
}
