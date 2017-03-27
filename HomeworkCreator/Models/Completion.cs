using System;
using System.Data.Entity;

namespace HomeworkCreator.Models
{
    public class Completion
    {
        public int Id { get; set; }
        public string CompletedBy { get; set; }
        public DateTime CompletedOn { get; set; }

        public virtual Assignment Assignment { get; set; }

    }

}