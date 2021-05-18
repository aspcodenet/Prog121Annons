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

        public void ShowMenu()
        {
            Console.WriteLine("1. Skapa ny");
            Console.WriteLine("2. Lista");
            Console.WriteLine("0. Avsluta");
        }

        public void SkrivUtAnnonser(List<Annons> annonsList)
        {
            Console.Clear();
            Console.WriteLine("---- ALLA ANNONSER ----");
            foreach (var annons in annonsList)
            {
                string dag = annons.GetWeekday();
                Console.WriteLine($"{annons.Rubrik} - {annons.Pris}");
                if (annons.SlutarSnart())
                {
                    Console.WriteLine("***Slutar snart***");
                }
                Console.WriteLine($"{annons.Description}");
                Console.WriteLine($"{dag}, {annons.SlutDatumOchTid}");
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        public void Run()
        {
            var listaMedAnnonser = GetAnnonserFromFile();
            // .\annonser.txt
            //Läs alla annonser från C:\Users\stefa\Temp\annonser.txt

            while (true)
            {
                ShowMenu();
                Console.WriteLine("Ange vad du vill göra:");
                int sel = Convert.ToInt32(Console.ReadLine());
                if (sel == 1)
                {
                    //Create
                }

                if (sel == 2)
                {
                    SkrivUtAnnonser(listaMedAnnonser);
                }
                else if (sel == 0)
                {
                    break;
                }
            }


            SaveAnnonserToFile(listaMedAnnonser);
        }
    }
}
