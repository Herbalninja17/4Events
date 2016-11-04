using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events.Data.DataClasses
{
    class DataFile
    {
        public DataFile()
        {
            
        }

        public static File GetFile()
        {
            return null;
        }

        public static void SetFile()
        {
             public static void PerisitImage(string path, IDbConnection connection)
        {
            //http://stackoverflow.com/questions/3548401/how-to-save-image-in-database-using-c-sharp

            //using (var command = connection.CreateCommand())
            //{
            //    Image img = Image.FromFile(path);
            //    MemoryStream tmpStream = new MemoryStream();
            //    img.Save(tmpStream, ImageFormat.Png); // change to other format
            //    tmpStream.Seek(0, SeekOrigin.Begin);
            //    byte[] imgBytes = new byte[MAX_IMG_SIZE];
            //    tmpStream.Read(imgBytes, 0, MAX_IMG_SIZE);

            //    command.CommandText = "INSERT INTO images(payload) VALUES (:payload)";
            //    IDataParameter par = command.CreateParameter();
            //    par.ParameterName = "payload";
            //    par.DbType = DbType.Binary;
            //    par.Value = imgBytes;
            //    command.Parameters.Add(par);
            //    command.ExecuteNonQuery();
            //}
        }
    }

        public static void UpdateFile()
        {
            
        }

        public static List<File> GetFileList()
        {
            return null;
        }
    }
}
