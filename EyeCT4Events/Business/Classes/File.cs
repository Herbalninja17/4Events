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
        private string fileName;
        private string fileType;

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

        public string FileName
        {
            get { return fileName; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    if (value == null) { throw new ArgumentNullException("fileName"); }
                    throw new ArgumentException("fileName");
                }
                fileName = value;
            }
        }

        public string FileType
        {
            get { return fileType; }
            set
            {
                if(!CheckFileType(FileName))
                {
                    throw new ArgumentException("fileType");
                }
                fileType = value;
            }
        }

        /// <summary>
        /// Created in the database.
        /// </summary>
        public int FileID { get { return fileID; } private set { } }

        public Person Poster { get; set; }

        /// <summary>
        /// Constructor
        /// When getting a file from the database.
        /// </summary>
        /// <param name="title">Title of the file</param>
        /// <param name="fileType">The document type of the file</param>
        /// <param name="fileID">The ID of the file</param>
        /// <param name="poster">The person who posted the file</param>
        public File(string title, string fileName, int fileID, Person poster)
        {
            Title = title;
            FileName = fileName;
            FileID = fileID; //LAATSTE OPHALEN UIT DATABASE?
            Poster = poster;
        }

        private bool CheckFileType(string fileName)
        {
            string checkFile = FileName;
            int checkType = checkFile.LastIndexOf(".");
            string extension = checkFile.Substring(checkType);

            if (extension != ".jpg" || extension != ".jpeg" || extension != ".gif" || extension != ".jpg")
            {
                return false;
            }

            return true;
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
