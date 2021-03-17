using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWpf
{
    class Question
    {
        private string _category;
        private string _question;
        private string _right_answer;
        private string _wrongAnswer1;
        private string _wrongAnswer2;
        private string _wrongAnswer3;
        public Question(string category, string question, string right_answer, string wrongAnswer1, string wrongAnswer2, string wrongAnswer3)
        {
            _category = category;
            _question = question;
            _right_answer = right_answer;
            _wrongAnswer1 = wrongAnswer1;
            _wrongAnswer2 = wrongAnswer2;
            _wrongAnswer3 = wrongAnswer3;
        }
        public string category
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
    }
}
