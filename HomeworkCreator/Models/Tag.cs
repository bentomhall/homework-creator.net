using System.Collections.Generic;

namespace HomeworkCreator.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }
    }
}