using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjectWpf
{
    class Question
    {
        private int _category;
        private string _question;
        private string _right_answer;
        private string _wrongAnswer1;
        private string _wrongAnswer2;
        private string _wrongAnswer3;
        private List<Question> _questionList;

        public Question()
        {
            select();
        }
        public Question(int category, string question)
        {
            _category = category;
            _question = question;
        }
        public Question(int category, string question, string right_answer, string wrongAnswer1, string wrongAnswer2, string wrongAnswer3)
        {
            _category = category;
            _question = question;
            _right_answer = right_answer;
            _wrongAnswer1 = wrongAnswer1;
            _wrongAnswer2 = wrongAnswer2;
            _wrongAnswer3 = wrongAnswer3;
            insert(question, category);
        }
        public int category
        {
            get { return _category; }
            set { _category = value; }
        }
        public string question
        {
            get { return _question; }
            set { _question = value; }
        }
        public string right_answer
        {
            get { return _right_answer; }
            set { _right_answer = value; }
        }
        public string wrongAnswer1
        {
            get { return _wrongAnswer1; }
            set { _wrongAnswer1 = value; }
        }
        public string wrongAnswer2
        {
            get { return _wrongAnswer2; }
            set { _wrongAnswer2 = value; }
        }
        public string wrongAnswer3
        {
            get { return _wrongAnswer3; }
            set { _wrongAnswer3 = value; }
        }

        public List<Question> questionList
        {
            get { return _questionList; }
            set { _questionList = value; }
        }

        public void insert(string question, int category)
        {
            SqlConnection SqlConnection = new SqlConnection("Data Source=r0793266.database.windows.net; Initial Catalog = SQLDBWPF; Persist Security Info = True; User ID = admin2ITF; Password = Password2ITF");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SqlConnection;
            cmd.CommandText = "insert into Question (question, categoryId) " +
                "values('" + question + "','" + category + "')";
            SqlConnection.Open();
            cmd.ExecuteNonQuery();
            SqlConnection.Close();
        }
        public void select()
        {
            SqlConnection SqlConnection = new SqlConnection("Data Source=r0793266.database.windows.net; Initial Catalog = SQLDBWPF; Persist Security Info = True; User ID = admin2ITF; Password = Password2ITF");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SqlConnection;
            cmd.CommandText = "select distinct(question), categoryId from Question";
            SqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                questionList = new List<Question>();
                while (reader.Read())
                {
                    string questionstr = reader["question"].ToString();
                    int category = Convert.ToInt32(reader["categoryId"]);
                    Question question = new Question(category, questionstr);
                    questionList.Add(question);
                }
            }
            SqlConnection.Close();
        }
    }
}
