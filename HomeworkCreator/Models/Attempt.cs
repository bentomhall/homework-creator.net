using System;
using System.Data.Entity;

namespace HomeworkCreator.Models
{
    public class Attempt
    {
        public int Id { get; set; }
        public DateTime AttemptedOn { get; set; }
        public bool WasCorrect { get; set; }

        public virtual Question QuestionAttempted { get; set; }
    }

}