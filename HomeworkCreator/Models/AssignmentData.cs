using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkCreator
{
    public class AssignmentData : IAssignmentData
    {
        public AssignmentData(string title, DateTime due, IEnumerable<IQuestionData> questions)
        {
            _title = title;
            _due = due;
            _questions = questions;
        }
        public string AssignmentTitle { get { return _title; } }

        public DateTime Due { get { return _due; } }

        public IEnumerable<IQuestionData> Questions { get { return _questions; } }

        private string _title;
        private DateTime _due;
        private IEnumerable<IQuestionData> _questions;
    }

    public class QuestionData : IQuestionData
    {
        public QuestionData(string title, string text, string hint, string answer, string type, int order, IEnumerable<string> prompts = null)
        {
            _title = title;
            _text = text;
            _hint = hint;
            _answer = answer;
            _order = order;
            _type = type;
            if (prompts == null)
            {
                _prompts = new List<string>();
            }
            else
            {
                _prompts = prompts;
            }
        }

        public string Title { get { return _title; } }

        public string Text { get { return _text; } }

        public string Hint { get { return _hint; } }

        public string Type { get { return _type; } }

        public string Answer { get { return _answer; } }

        public int Order { get { return _order; } }

        public IEnumerable<string> Prompts { get { return _prompts; } }

        public IEnumerable<string> ImageNames => throw new NotImplementedException();

        private string _title;
        private string _text;
        private string _hint;
        private string _type;
        private string _answer;
        private int _order;
        private IEnumerable<string> _prompts;
    }
}
