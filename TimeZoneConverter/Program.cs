using Microsoft.EntityFrameworkCore;
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
                    var timeZone = TimeZoneInfo.FindSystemTimeZoneById("E. Australia Standard Time");
                    var tableName = property.DeclaringEntityType.GetTableName();
                    var columnName = property.GetColumnName();
                    var sql = $"UPDATE {tableName} SET {columnName} = DATEADD(hour, {timeZone.BaseUtcOffset.TotalHours}, {columnName})";
                    context.Database.ExecuteSqlRaw(sql);
                }
                 context.SaveChanges();
            }
            Console.WriteLine("Done!");
        }
    }
}