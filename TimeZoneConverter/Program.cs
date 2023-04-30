using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Data.SqlClient;
using TimeZoneConverter.Models;

namespace DateTimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new WheelCopyContext())
            {
                var dateTimeProperties = context.Model.GetEntityTypes()
                    .SelectMany(t => t.GetProperties())
                    .Where(p => p.ClrType == typeof(DateTime));

                //string connectionString = "Data Source=CHERNO-WM;Initial Catalog=WheelCopy;Integrated Security=True;Connect Timeout=30;Encrypt=False";
                //string query = "SELECT CreatedOn FROM AssessmentComments WHERE DATA_TYPE='datetime'";

                ////convert australian time to to utc
                //TimeZoneInfo timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("E. Australia Standard Time");

                //// Get the local time in the local time zone
                //DateTime localTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, timeZoneInfo);

                //DateTime nowUtc = DateTime.UtcNow;
                //// Convert the local time to UTC
                //DateTime utcTime = TimeZoneInfo.ConvertTimeToUtc(localTime, timeZoneInfo);

                foreach (var property in dateTimeProperties)
                {
                    //using (SqlConnection connection = new SqlConnection(connectionString))
                    //{
                    //connection.Open();

                    //SqlCommand command = new SqlCommand(query, connection);

                    //using (SqlCommand updateCommand = new SqlCommand("UPDATE AssessmentComments SET CreatedOn=@localTime WHERE CreatedOn=@utcTime", connection))
                    //{

                    //    updateCommand.Parameters.AddWithValue("utcTime", utcTime);
                    //    updateCommand.Parameters.AddWithValue("localTime", localTime);
                    //    updateCommand.ExecuteNonQuery();
                    //    // Console.WriteLine("\n" + utcTime.ToString() + "  UTC Time " + "\nLocal Time" + localTime);
                    //}

                    //connection.Close();
                    ////Console.WriteLine($"Column name: {property.Name}");
                    ///

                    var timeZone = TimeZoneInfo.FindSystemTimeZoneById("E. Australia Standard Time");

                    //var dateTimeProperties = context.Model.GetEntityTypes()
                    //    .SelectMany(t => t.GetProperties())
                    //    .Where(p => p.ClrType == typeof(DateTime));

                    //foreach (var property in dateTimeProperties)
                    //{
                    var tableName = property.DeclaringEntityType.GetTableName();
                    var columnName = property.GetColumnName();
                    var sql = $"UPDATE {tableName} SET {columnName} = DATEADD(hour, {timeZone.BaseUtcOffset.TotalHours}, {columnName})";
                    context.Database.ExecuteSqlRaw(sql);
                   // Console.WriteLine(sql);
                }

                 context.SaveChanges();

            }
        }


    }
}





