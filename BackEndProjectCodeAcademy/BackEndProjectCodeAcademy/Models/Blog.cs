using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationBackendFinal.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string WriteTime { get; set; }
        public int CommentCount { get; set; }

    }
}
