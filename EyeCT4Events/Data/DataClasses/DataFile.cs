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
    public static class DataFile
    {
        public static Image GetImageToDisplay(int id)
        {
            Datacom.OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT Content " +
                                            "FROM Media " +
                                            "WHERE Titel = 'Pino';",
                                            Datacom.connect);
            byte[] img = (byte[])cmd.ExecuteScalar();
            MemoryStream str = new MemoryStream(img);
            Image returnImage = Image.FromStream(str);

            return returnImage;
        }

        public static void UploadImage(Person poster, int mapID, string fileType, string filename, string text, string title)
        {
            try
            {
                FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                BinaryReader byteReader = new BinaryReader(fs);
                int bytes = Convert.ToInt32(new FileInfo(filename).Length);
                byte[] buff = byteReader.ReadBytes(bytes);
                byteReader.Close();

                Datacom.OpenConnection();
                //Get the ID from the poster
                SqlCommand cmdPoster = new SqlCommand("SELECT AccountID " +
                                                      "FROM Account " +
                                                      $"WHERE Email = '{poster.Email}'",
                                                      Datacom.connect);
                SqlDataReader reader = cmdPoster.ExecuteReader();
                reader.Read();
                int posterId = reader.GetInt32(0); 
                reader.Close();
                
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
            List<File> filelist = new List<File>();
            try
            {
                Datacom.OpenConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM media WHERE accountaccountid is not null and tekst is not null", Datacom.connect);
                SqlDataReader reader = cmd.ExecuteReader();
                File f;
                while (reader.Read())
                {
                    Person p = Data.DataClasses.DataPerson.GetPersonByID(Convert.ToInt32(reader["accountaccountid"]));
                    
                    f = new File(Convert.ToString(reader["titel"]), Convert.ToString(reader["tekst"]), Convert.ToString(reader["mediatype"]), Convert.ToInt32(reader["mediaid"]), p);
                    filelist.Add(f);
                }
                return filelist;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return filelist;
            }
            finally
            {
                Datacom.CloseConnection();
            }
        }
    }
}
