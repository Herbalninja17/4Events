using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events
{
    public class File
    {
        public string Title { get; set; }
        public FileType FileType { get; set; }
        public int FileID { get; set; }
        public Person Poster { get; set; }

        public File(string title, FileType fileType, int fileID, Person poster)
        {
            Title = title;
            FileType = fileType;
            FileID = fileID;
            Poster = poster;
        }
    }
}
