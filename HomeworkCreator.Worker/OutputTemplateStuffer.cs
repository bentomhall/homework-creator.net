using System;
using HomeworkCreator.API;
using RazorEngine;
using RazorEngine.Templating;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace HomeworkCreator.Worker
{
    public class OutputTemplateStuffer
    {
        public OutputTemplateStuffer()
        {

            Engine.Razor.AddTemplate("question", Properties.FileResources.QuestionTemplateLocation);
            Engine.Razor.AddTemplate("multiple-choice", Properties.FileResources.MultipleChoiceTemplateLocation);
            Engine.Razor.AddTemplate("assignment", Properties.FileResources.AssignmentTemplateLocation);

            Engine.Razor.Compile("question", typeof(IQuestionData));
            Engine.Razor.Compile("multiple-choice", typeof(IQuestionData));
            Engine.Razor.Compile("assignment", typeof(IAssignmentData));
        }

        public string FillQuestionTemplate(IQuestionData data)
        {
            return Engine.Razor.Run("question", typeof(IQuestionData), data);
        }

        public string FillMultipleChoiceTemplate(IQuestionData data)
        {
            return Engine.Razor.Run("multiple-choice", typeof(IQuestionData), data);
        }

        public string FillAssignmentTemplate(IAssignmentData data)
        {
            return Engine.Razor.Run("assignment", typeof(IAssignmentData));
        }




    }
}
