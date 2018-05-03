using System; 
using System.Collections.Generic; 
using System.IO; 
using System.Linq; 

namespace project_ezekiel
{
    class Program
    {
        static void Main(string[] args)
        {
            var ignoreFiles = new List < string > ()
            {
                "cats", 
                "categories", 
                "contents", 
                "readme"
            }; 

            
            var path = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\..\\brown\\brown\\"; 
            var firstFile = Directory.GetFiles(path).First(); 
            var allText = System.IO.File.ReadAllText(firstFile).TrimStart(); 
            var tokenized = allText.Split(' ', StringSplitOptions.RemoveEmptyEntries); 
            foreach (var token in tokenized)
            {
                System.Console.WriteLine(token); 
            }

            // foreach(var file in Directory.GetFiles(path))
            // {
            //     var p = Path.GetFileNameWithoutExtension(file);
            //     if(!ignoreFiles.Contains(p.ToLower()))
            //     {
            //         var text = 
            //     }
            // }

            Console.Read(); 
        }
    }
}
