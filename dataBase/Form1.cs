using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;




                                                     //THIS PROJECT HAS BEEN DONE BY ABDULAZIZ FAHAM(200209984) & ABDULAZIZ KATTAN(200209911) 

namespace OOPII_PROJECT
{
    public partial class Form1 : Form
    {
        SqlConnection connection = null;                    
        string [] Credits = null;
        string [] letterGradeArray = null;
        string [] CreditsCgpa = null;
        string [] letterGradeArrayCgpa = null;
        string selectedSemester = "8";
        double resultGpa = 0;
        double resultCgpa = 0;
        public String stringConnection = "data source=localhost\\SQLEXPRESS;initial catalog=Transcrpit;Integrated Security=true";
        
        public Form1()
        {

            InitializeComponent();


        }

        public void connect()
        {
            connection = new SqlConnection(stringConnection);
            connection.Open();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connect();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "select courseName, courseCode, etcsCriedts, letterGrade, semester from grades order by semester";
            sqlCommand.Connection = connection;

            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            Gpa();
            Cgpa();

            connection.Close();
        }

        private void load_Click(object sender, EventArgs e)
        {
            connect();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "select courseName, courseCode, etcsCriedts, letterGrade, semester from grades order by semester";
            sqlCommand.Connection = connection;

            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            Gpa();
            Cgpa();

            GpaLabel.Text = Convert.ToString(Math.Round(resultGpa, 2, MidpointRounding.ToEven));
            cgpaLabel.Text = Convert.ToString(Math.Round(resultCgpa, 2, MidpointRounding.ToEven));

            connection.Close();
        }
        private void clearAll_Click(object sender, EventArgs e)
        {
            GpaLabel.Text = "-";
            cgpaLabel.Text = "-";
            displayDropDown.SelectedIndex = -1;
            courseSearch.Clear();
            dataGridView1.DataSource = null;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Cgpa()  // This function is a modified version of the GPA function that keeps calculating till the selected semester.

        {
            if (displayDropDown.SelectedIndex > -1)
            {
                selectedSemester = displayDropDown.Text;
            }
            
            connect();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $"select etcsCriedts FROM Transcrpit.dbo.grades WHERE semester <= '{selectedSemester}'";
            cmd.Connection = connection;
            using (var reader = cmd.ExecuteReader())
            {
                var list = new LinkedList<string>();
                int i = 0;
                while (reader.Read())
                {
                    list.AddLast(reader.GetString(0));
                    i++;
                }
                    
                CreditsCgpa = list.ToArray();


            }
            connection.Close();
              connect();
              SqlCommand sqlCommand = new SqlCommand();
              sqlCommand.CommandText = $"select letterGrade FROM Transcrpit.dbo.grades WHERE semester <= '{selectedSemester}'";
              sqlCommand.Connection = connection;
              using (var reader = sqlCommand.ExecuteReader())
              {
                  var list = new List<string>();
                  int i = 0;
                  while (reader.Read())
                  {
                      list.Add(reader.GetString(0));
                      i++;
                  }
                  letterGradeArrayCgpa = list.ToArray();


              }
            double resultCgpa = 0.0;
            double numGradeCgpa = 0.0;
            double creditsSumCgpa = 0.0;
              for(int i = 0; i < CreditsCgpa.Length; i++)
            {
                creditsSumCgpa += Convert.ToDouble(CreditsCgpa[i]);
                String letterGradeUpper = letterGradeArrayCgpa[i].ToUpper();
                switch (letterGradeUpper)
                {
                    case "AA":
                        numGradeCgpa = 4.0;
                        break;
                    case "BA":
                        numGradeCgpa = 3.5;
                        break;
                    case "BB":
                        numGradeCgpa = 3.0;
                        break;
                    case "CB":
                        numGradeCgpa = 2.5;
                        break;
                    case "CC":
                        numGradeCgpa = 2.0;
                        break;
                    case "DC":
                        numGradeCgpa = 1.5;
                        break;
                    case "DD":
                        numGradeCgpa = 1.0;
                        break;
                    case "FD":
                        numGradeCgpa = 0.5;
                        break;
                    case "FF":
                        numGradeCgpa = 0.0;
                        break;
                    default:
                        break;
                }

                resultCgpa = resultCgpa + (Convert.ToDouble(CreditsCgpa[i]) * numGradeCgpa);
                

            }
            resultCgpa = resultCgpa / creditsSumCgpa;
            this.resultCgpa = resultCgpa;
        } // End of the CGPA Function

        private void Gpa() // THis function calculates the GPA
        {
            if (displayDropDown.SelectedIndex != -1)
            {
                 selectedSemester = displayDropDown.Text;
            }
            else
            {
                selectedSemester = "8";
            }

            connect();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $"select etcsCriedts FROM Transcrpit.dbo.grades WHERE semester='{selectedSemester}'";
            cmd.Connection = connection;
            using (var reader = cmd.ExecuteReader())
            {
                var list = new LinkedList<string>();
                int i = 0;
                while (reader.Read())
                {
                    list.AddLast(reader.GetString(0));
                    i++;
                }
                    
                Credits = list.ToArray();


            }
              connection.Close();
              connect();
              SqlCommand sqlCommand = new SqlCommand();
              sqlCommand.CommandText = $"select letterGrade FROM Transcrpit.dbo.grades WHERE semester='{selectedSemester}'";
              sqlCommand.Connection = connection;
              using (var reader = sqlCommand.ExecuteReader())
              {
                  var list = new List<string>();
                  int i = 0;
                  while (reader.Read())
                  {
                      list.Add(reader.GetString(0));
                      i++;
                  }
                  letterGradeArray = list.ToArray();


              }
            double resultGpa = 0.0;
            double numGrade = 0.0;
            double creditsSum = 0.0;
              for(int i = 0; i < Credits.Length; i++)
            {
                creditsSum += Convert.ToDouble(Credits[i]);
                String letterGradeUpper = letterGradeArray[i].ToUpper();
                switch (letterGradeUpper)
                {
                    case "AA":
                        numGrade = 4.0;
                        break;
                    case "BA":
                        numGrade = 3.5;
                        break;
                    case "BB":
                        numGrade = 3.0;
                        break;
                    case "CB":
                        numGrade = 2.5;
                        break;
                    case "CC":
                        numGrade = 2.0;
                        break;
                    case "DC":
                        numGrade = 1.5;
                        break;
                    case "DD":
                        numGrade = 1.0;
                        break;
                    case "FD":
                        numGrade = 0.5;
                        break;
                    case "FF":
                        numGrade = 0.0;
                        break;
                    default:
                        break;
                }

                resultGpa = resultGpa + (Convert.ToDouble(Credits[i]) * numGrade);
                

            }
            resultGpa = resultGpa / creditsSum;
            this.resultGpa = resultGpa;
          
        } // End of GPA Function

        private void delete_Click(object sender, EventArgs e)
        {
            connect();
            string IDdelete = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.CommandText = "Delete from grades where courseName='" + IDdelete + "'";
            sqlcommand.Connection = connection;
            sqlcommand.ExecuteNonQuery();

            load_Click(sender, e);
            connection.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            
                string selectedCourse = courseSearch.Text;
                connect();

                SqlCommand sql = new SqlCommand();
                sql.CommandText = $"select courseName, letterGrade from Transcrpit.dbo.grades where courseName ='{selectedCourse}'";
                sql.Connection = connection;

                SqlDataAdapter adapter = new SqlDataAdapter(sql);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

               GpaLabel.Text = Convert.ToString(Math.Round(resultGpa, 2, MidpointRounding.ToEven));
               cgpaLabel.Text = Convert.ToString(Math.Round(resultCgpa, 2, MidpointRounding.ToEven));
            connection.Close();
       

        }
        private void btn_addCourses_Click(object sender, EventArgs e) // A button To go to the next page
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string selectedSemster = displayDropDown.Text;

            connect();

            SqlCommand sql = new SqlCommand();
            sql.CommandText = $"select courseName,courseCode, etcsCriedts, letterGrade, semester from Transcrpit.dbo.grades where semester ='{selectedSemster}'";
            sql.Connection = connection;
            Gpa();
            Cgpa();
            GpaLabel.Text = Convert.ToString(Math.Round(resultGpa, 2, MidpointRounding.ToEven));
            cgpaLabel.Text = Convert.ToString(Math.Round(resultCgpa, 2, MidpointRounding.ToEven));
            SqlDataAdapter adapter = new SqlDataAdapter(sql);
            DataTable dt = new DataTable();

            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }
    }
}
