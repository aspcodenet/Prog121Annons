using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace Prog121Annons
{
    public class AnnonsSystem
    {
        public List<Annons> GetAnnonserFromFile()
        {
             
            if (File.Exists(@"C:\Users\stefa\Temp\annonser.txt") == false)
            {
                return new List<Annons>();
            }

            var annonser = File.ReadAllText(@"C:\Users\stefa\Temp\annonser.txt");
            return JsonConvert.DeserializeObject<List<Annons>>(annonser);
        }

        public void SaveAnnonserToFile(List<Annons> listaMedAnnonser)
        {
            var json = JsonConvert.SerializeObject(listaMedAnnonser);
            File.WriteAllText(@"C:\Users\stefa\Temp\annonser.txt", json);
        }

        public void Run()
        {
            var listaMedAnnonser = GetAnnonserFromFile();
            // .\annonser.txt
            //Läs alla annonser från C:\Users\stefa\Temp\annonser.txt

            while (true)
            {
                //1. 
            }


            SaveAnnonserToFile(listaMedAnnonser);
        }
    }
}
