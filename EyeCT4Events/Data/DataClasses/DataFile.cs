using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyeCT4Events.Data.DataClasses
{
    class DataFile
    {
        public DataFile()
        {
            
        }

        //Kom er niet uit! Zou best totaal anders moeten dan hoe ik het probeer.
        //public static Bitmap DownloadFile()
        //{
        //    Datacom.OpenConnection();
        //    SqlCommand cmd = new SqlCommand("SELECT Content " +
        //                                    "FROM Media " +
        //                                    "WHERE Titel = 'Pino';",
        //                                    Datacom.connect);
        //    byte[] img = (byte[]) cmd.ExecuteScalar();
        //    MemoryStream str = new MemoryStream();
        //    str.Write(img, 0, img.Length);
        //    Bitmap bit = new Bitmap(str);
        //    Datacom.CloseConnection();

        //    return bit;
        //}

        public static void UploadFile(Person poster, int mapID, string fileType, string filename, string text, string title)
        {
            try
            {
                FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                BinaryReader byteReader = new BinaryReader(fs);
                int bytes = Convert.ToInt32(new FileInfo(filename).Length);
                byte[] buff = byteReader.ReadBytes(bytes);

                Datacom.OpenConnection();
                //Get the ID from the poster
                SqlCommand cmdPoster = new SqlCommand("SELECT AccountID " +
                                                      "FROM Account " +
                                                      $"WHERE Email = {poster.Email}");
                SqlDataReader reader = cmdPoster.ExecuteReader();
                reader.Read();
                int posterId = reader.GetInt32(0); 
                
                using (
                    SqlCommand cmd = new SqlCommand($"INSERT INTO Media VALUES (" +
                                                    $"{posterId}, " +
                                                    $"{mapID}, " +
                                                    $"'{fileType}', " +
                                                    $"'{DateTime.Now.ToString("d-M-yyyy")}', " +
                                                    $"@binaryValue, " +
                                                    $"'{text}', " +
                                                    $"'{title}')", 
                                                    Datacom.connect)
                    )
                {
                    cmd.Parameters.Add("@binaryValue", SqlDbType.VarBinary, -1).Value = buff;
                    cmd.ExecuteNonQuery();
                }
                    
                Datacom.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }

        public static List<File> GetFileList()
        {
            return null;
        }
    }
}
