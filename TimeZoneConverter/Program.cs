using System;
using System.Data;
using System.Data.SqlClient;

namespace DateTimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=CHERNO-WM;Initial Catalog=WheelCopy;Integrated Security=True;Connect Timeout=30;Encrypt=False";
            string query = "SELECT CreatedOn FROM AssessmentComments WHERE DATA_TYPE='datetime'";

            //convert australian time to to utc
            TimeZoneInfo timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("E. Australia Standard Time");

            // Get the local time in the local time zone
            DateTime localTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, timeZoneInfo);

            DateTime nowUtc = DateTime.UtcNow;
            // Convert the local time to UTC
            DateTime utcTime = TimeZoneInfo.ConvertTimeToUtc(localTime, timeZoneInfo);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                using (SqlCommand updateCommand = new SqlCommand("UPDATE AssessmentComments SET CreatedOn=@localTime WHERE CreatedOn=@utcTime", connection))
                {

                    updateCommand.Parameters.AddWithValue("utcTime", utcTime);
                    updateCommand.Parameters.AddWithValue("localTime", localTime);
                    updateCommand.ExecuteNonQuery();
                    Console.WriteLine("\n" + utcTime.ToString() + "  UTC Time " + "\nLocal Time" + localTime);
                }

                connection.Close();
                Console.WriteLine("Done!");
            }
        }
    }
}

