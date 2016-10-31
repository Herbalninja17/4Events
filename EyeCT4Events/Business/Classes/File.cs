using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events
{
    public class File
    {
        private string title;
        private int fileID;

        public string Title
        {
            get { return title; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    if (value == null) { throw new ArgumentNullException("title"); }
                    throw new ArgumentException("title");
                }
                title = value;
            }
        }

        public FileType FileType { get; set; }

        public int FileID
        {
            get { return fileID; }
            set
            {
                if (value < 1) { throw new ArgumentOutOfRangeException("fileID");}
                fileID = value;
            }
        }

        public Person Poster { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="title">Title of the file</param>
        /// <param name="fileType">The document type of the file</param>
        /// <param name="fileID">The ID of the file</param>
        /// <param name="poster">The person who posted the file</param>
        public File(string title, FileType fileType, int fileID, Person poster)
        {
            Title = title;
            FileType = fileType;
            FileID = fileID;
            Poster = poster;
        }

        public override string ToString()
        {
            return Title
                + " | " + FileType
                + " | " + fileID
                + " | " + Poster.Email
                ;
        }
    }
}
