using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Data;
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

                foreach (var property in dateTimeProperties)
                {

                    var propertyName = property.Name;

                    var tableName = property.DeclaringEntityType.GetTableName();

                    var query = $"SELECT [{propertyName}] FROM [{tableName}]";

                    // Execute the query and iterate over the results
                    using (var command = context.Database.GetDbConnection().CreateCommand())
                    {
                        command.CommandText = query;
                        command.CommandType = CommandType.Text;

                        context.Database.OpenConnection();

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Get the datetime value from the reader
                                var datetimeValue = reader.GetDateTime(reader.GetOrdinal(propertyName));

                                string time = datetimeValue.ToString();
                                DateTime dateTime = DateTime.Parse(time);
                                string formattedString = dateTime.ToString("yyyy MM dd HH mm ss");

                                string[] splitTimeString = formattedString.Split(' ');
                                int[] splitTimeStringToInt = Array.ConvertAll(splitTimeString, int.Parse);

                                int year = splitTimeStringToInt[0];
                                int month = splitTimeStringToInt[1];
                                int day = splitTimeStringToInt[2];
                                int hour = splitTimeStringToInt[3];
                                int minute = splitTimeStringToInt[4];
                                int second = splitTimeStringToInt[5];

                                DateTime dateAndTime = new DateTime(year, month, day, hour, minute, second);
                                var yearValue = dateAndTime.Year;
                                var BstStart = new DateTime(yearValue, 3, 26);
                                var BstEnd = new DateTime(yearValue, 10, 29);
                                var timezone_value = "GMT Standard Time";
                                
                                while (!(month >= BstStart.Month && day >= 26) && (month <= BstEnd.Month && day <= 29))
                                {
                                    TimeZoneInfo ukTime = TimeZoneInfo.FindSystemTimeZoneById(timezone_value);
                                    dateAndTime = DateTime.SpecifyKind(dateAndTime, DateTimeKind.Unspecified);
                                    var result = TimeZoneInfo.ConvertTimeToUtc(dateAndTime, ukTime);
                                }
                            }
                        }
                    }

                    tableName = property.DeclaringEntityType.GetTableName();
                    var columnName = property.GetColumnName();
                    var sql = $@"UPDATE[{tableName}] SET[{columnName}] = DATEADD(hour, -1, [{columnName}])";
                    context.Database.ExecuteSqlRaw(sql);
                }
                context.SaveChanges();
            }
            Console.WriteLine("Done!");
        }
    }
}


