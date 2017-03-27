using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace HomeworkCreator.Models
{
    public class Assignment
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsPublic { get; set; }

        public virtual ApplicationUser Owner { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<Completion> Attempts { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
}