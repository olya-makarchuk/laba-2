using System;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Runtime.Serialization;

namespace laba_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] date1 = new int[3];
            int[] date2 = new int[3];

            Console.WriteLine("Перша дата");
            date1 = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            Console.WriteLine("Друга дата");
            date2 = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            DateInterval date = new DateInterval() {Start = new DateTime(date1[2], date1[1], date1[0]), End = new DateTime(date2[2], date2[1], date2[0]) };
            string path = "date.json";

            string json = JsonSerializer.Serialize(date);
            File.WriteAllText(path, json);
            
            string jsonread =File.ReadAllText(path);
            DateInterval date_j = JsonSerializer.Deserialize<DateInterval>(jsonread);

            date_j.Print();
        }
    }
}
