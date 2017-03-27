using System;
using System.Collections.Generic;


namespace HomeworkCreator
{
    public interface IAssignmentData
    {
        string AssignmentTitle { get; }
        DateTime Due { get; }
        IEnumerable<IQuestionData> Questions { get; }
    }

    public interface IQuestionData
    {
        string Title { get; }
        string Text { get; }
        string Hint { get; }
        string Type { get; }
        string Answer { get; }
        int Order { get; }
        IEnumerable<string> Prompts { get; }
        IEnumerable<string> ImageNames { get; }
    }

}
