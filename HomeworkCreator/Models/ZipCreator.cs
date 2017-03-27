using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ionic.Zip;
using System.IO;

namespace HomeworkCreator.Worker
{
    internal class ZipCreator
    {
        internal ZipCreator(string filename)
        {
            _filename = filename;
        }

        internal void Build(string assignmentPage, IEnumerable<string> questionPages, Stream output)
        {
            string mungedJavascript = AdjustNumberOfQuestions(questionPages.Count());
            using (ZipFile zip = new ZipFile())
            {
                zip.AddEntry("validation.js", mungedJavascript);
                zip.AddFile(Properties.FileResources.OutputCSS, "");
                zip.AddFile(Properties.FileResources.CorrectImage, "");
                zip.AddFile(Properties.FileResources.IncorrectImage, "");

                zip.AddEntry("index.html", assignmentPage);
                int questionIndex = 1;
                foreach (var page in questionPages)
                {
                    zip.AddEntry($"Question{questionIndex}.html", page);
                    questionIndex += 1;
                }
                zip.Save(output);
            }
        }

        private string AdjustNumberOfQuestions(int v)
        {
            throw new NotImplementedException();
        }

        private string _filename;
    }
}
