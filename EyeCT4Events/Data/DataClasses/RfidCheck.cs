using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EyeCT4Events.Data;

namespace EyeCT4Events.Business.Classes
{
    class RfidCheck
    {
        public void CheckInFisrtTime(string rfidcode, string account)
        {
            int AcID = 0; ;
            try
            {
                try
                {
                    Datacom.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Datacom.connect;
                    cmd.CommandText = "Select AccountID From Account Where Email = @Data";
                    cmd.Parameters.Add(new SqlParameter("Data", account)); //(@string waarde, parameter waarde)
                    cmd.ExecuteNonQuery();                  //execute het query
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        AcID = Convert.ToInt32(reader["AccountID"]);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                finally
                {
                    Datacom.CloseConnection();
                }
                Datacom.OpenConnection();
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = Datacom.connect;
                cmd1.CommandText = "INSERT INTO Polsband(BandID,AccountAccountID, Aanwezig) VALUES ('" + rfidcode + "', '" + AcID + "', '1');";
                cmd1.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Datacom.CloseConnection();
            }
        }

        public void CheckIn(string rfidcode, int account)
        {
            InOutSql(rfidcode, account, 1);
        }

        public void CheckOut(string rfidcode, int account)
        {
            
            InOutSql(rfidcode, account, 0);
        }

        public bool CheckRsvp(string res, string acid, string rfid)
        {
            bool check = false;
            string eventid = "";
            string RfidEvent = "";
            Datacom.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Datacom.connect;
            cmd.CommandText = "Select BandBandID, EventEventID From EventPolsband Where BandBandID = @Data AND EventEventID = @Data2";
            cmd.Parameters.Add(new SqlParameter("Data", rfid)); //(@string waarde, parameter waarde)
            cmd.Parameters.Add(new SqlParameter("Data2", res)); //(@string waarde, parameter waarde)
            cmd.ExecuteNonQuery();                  //execute het query
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                RfidEvent = Convert.ToString(reader["BandBandID"]);
                eventid = Convert.ToString(reader["EventEventID"]);
            }
            if (RfidEvent == rfid && eventid == res)
            {
                check = true;
            }
            else
            {
                check = false;
            }
            return check;
        }

        public bool CheckBlock(string rfid)
        {
            bool check = false;
            string result = "Null";
            Datacom.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Datacom.connect;
            cmd.CommandText = "select a.Bruikbaar as Bruikbaar from Polsband p, Account a where p.AccountAccountID = a.AccountID and p.BandID = @Data";
            cmd.Parameters.Add(new SqlParameter("Data", rfid)); //(@string waarde, parameter waarde)
            cmd.ExecuteNonQuery();                  //execute het query
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                result = Convert.ToString(reader["Bruikbaar"]);
            }
            if (result == "uitgeschakeld")
            {
                check = false;
            }
            else
            {
                check = true;
            }
            return check;
        }



        public bool CheckUp(string rfid)
        {
            bool check = false;
            string ID = "";
            try
            {
                Datacom.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Datacom.connect;
                cmd.CommandText = "Select BandID From Polsband Where BandID = @Data";
                cmd.Parameters.Add(new SqlParameter("Data", rfid)); //(@string waarde, parameter waarde)
                cmd.ExecuteNonQuery();                  //execute het query
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ID = Convert.ToString(reader["BandID"]);
                }
                if (ID == "")
                {
                    check = false;
                }
                else
                {
                    check = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Datacom.CloseConnection();
            }
            return check;
        }

        public void rfidbetaal()
        {
            string betID = "";

            try
            {
                Datacom.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Datacom.connect;
                cmd.CommandText = "select r.ReserveringID as reservering from reservering r, AccountReservering a  where r.ReserveringID = a.ReserveringReserveringID and a.AccountAccountID = '" + Person.AcID +"'";

                cmd.ExecuteNonQuery();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    betID = Convert.ToString(reader["reservering"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Datacom.CloseConnection();
            }

            try
            {
                Datacom.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Datacom.connect;
                cmd.CommandText = "UPDATE Reservering SET BetaaldStatus = 'Betaald' WHERE ReserveringID = '"+ betID +"'";

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Datacom.CloseConnection();
            }
        }

        public void InOutSql(string rfidcode, int account, int aanwezig)
        {
            try
            {
                Datacom.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Datacom.connect;
                cmd.CommandText = "UPDATE Polsband SET Aanwezig = '"+aanwezig+"' WHERE BandID = '" + rfidcode + "'; ";

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Datacom.CloseConnection();
            }
        }
    }
}
