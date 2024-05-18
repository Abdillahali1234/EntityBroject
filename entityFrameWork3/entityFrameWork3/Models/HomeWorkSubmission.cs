using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityFrameWork3.Models
{

    /**
     *        HomeworkId
             o Content (string, linking to a file, not unicode)
             o ContentType (enum – can be Application, Pdf or Zip)
             o SubmissionTime
             o StudentId
             o CourseId                                
     * **/

    public enum ContentType
    {
           Application,
           Pdf,
           Zip
    }
    internal class HomeWorkSubmission
    {
        public int HomeworkId { get; set; }
        public string Content { get; set; }
        public ContentType ContentType { get; set; }
        public DateTime SubmissionTime { get; set; }

        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public Student Student { get; set; } = null!;

        public Course Course { get; set; } = null!;

    }
}
