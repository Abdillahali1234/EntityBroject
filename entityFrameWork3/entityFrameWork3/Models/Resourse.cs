using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityFrameWork3.Models
{
    /**
     *   Resource:
        o ResourceId
        o Name (up to 50 characters, unicode)
        o Url (not unicode)
        o ResourceType (enum – can be Video, Presentation, Document or Other)
        o CourseId
     **/
    public enum ResourceType
    {
        vide,
        presentation,
        document,
        other
    }

    internal class Resourse
    {   
        public int ResourceId { get; set; }
        public string Name { get; set; }
        public string URl { get; set; }
        public ResourceType ResourceType { get; set; }
        public int CourseId { get; set; }

        public Course Course { get; set; }
    }
}
