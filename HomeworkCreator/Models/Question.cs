using System.Collections.Generic;
using System.Data.Entity;

namespace HomeworkCreator.Models
{
    public enum QuestionType
    {
        Exact,
        ExactNoCase,
        NumericWithTolerance,
        MultipleChoice,
        ContainsAny,
        ContainsAll
    }

    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Answer { get; set; }
        public string Hint { get; set; }
        public QuestionType Type { get; set; }
        public int Order { get; set; }
        public bool IsPublic { get; set; }

        public virtual Assignment Assignment { get; set; }
        public virtual ICollection<Attempt> Attempts {get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }

}