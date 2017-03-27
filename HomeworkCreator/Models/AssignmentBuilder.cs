using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HomeworkCreator.API;

namespace HomeworkCreator.Worker
{
    public class AssignmentBuilder
    {
        public AssignmentBuilder(IAssignmentData assignment)
        {
            _assignment = assignment;
            _zipCreator = new ZipCreator(assignment.AssignmentTitle.Where(c => !Char.IsWhiteSpace(c)).ToString());
            _stuffer = new OutputTemplateStuffer();
        }

        public Stream Build(Stream destination)
        {
            List<string> questions = new List<string>();
            foreach (var q in _assignment.Questions)
            {
                questions.Add(CreateQuestion(q));
            }
            var assignmentPage = CreateAssignment(_assignment);
            _zipCreator.Build(assignmentPage, questions, destination);
            return destination;
        }


        private IAssignmentData _assignment;
        private ZipCreator _zipCreator;
        private OutputTemplateStuffer _stuffer;

        private string CreateQuestion(IQuestionData data)
        {
            if (data.ImageNames.Any())
            {
                throw new NotImplementedException($"Images are not supported at this time");
            }
            if(data.Type == "multiple-choice")
            {
                return _stuffer.FillMultipleChoiceTemplate(data);
            }
            else
            {
                return _stuffer.FillQuestionTemplate(data);
            }
        }

        private string CreateAssignment(IAssignmentData data)
        {
            return _stuffer.FillAssignmentTemplate(data);
        }
    }

}
