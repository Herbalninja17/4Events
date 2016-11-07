﻿using System;
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

        private static string[] acceptedExtensions = {"jpg", "jpeg", "png", "gif"};

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

        public string FileType { get; private set; }

        /// <summary>
        /// Created in the database.
        /// </summary>
        public int FileID { get { return fileID; } private set { } }

        public Person Poster { get; set; }

        /// <summary>
        /// Constructor
        /// When getting a file from the database.
        /// Transmitting of the actual file happens on the FORM and DAL
        /// </summary>
        /// <param name="title">Title of the file</param>
        /// <param name="fileName">Full path of the file</param>
        /// <param name="fileType">The document type of the file</param>
        /// <param name="fileID">The ID of the file</param>
        /// <param name="poster">The person who posted the file</param>
        public File(string title, string fileName, string fileType, int fileID, Person poster)
        {
            Title = title;
            FileName = fileName;
            this.fileID = fileID;
            Poster = poster;
            FileType = fileType;
        }

        /// <summary>
        /// Constructor
        /// When giving a file to the database.
        /// Transmitting of the actual file happens on the FORM and DAL
        /// </summary>
        /// <param name="title">Title of the file</param>
        /// <param name="fileName">Full path of the file</param>
        /// <param name="poster">The person posting the file</param>
        public File(string title, string fileName, Person poster)
        {
            Title = title;
            FileName = fileName;
            Poster = poster;
            FileType = CheckFileType(fileName);
        }

        /// <summary>
        /// checks for acceptable filetypes
        /// </summary>
        /// <param name="fileName">full filename</param>
        /// <returns>Extension if accepted, Empty string if not.</returns>
        public string CheckFileType(string fileName)
        {
            string extension = FileName.ToLower();
            int checkType = extension.LastIndexOf(".");
            extension = extension.Substring(checkType + 1);

            foreach(string found in acceptedExtensions)
            {
                if(found == extension)
                {
                    return found;
                }
            }
            return "";
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
