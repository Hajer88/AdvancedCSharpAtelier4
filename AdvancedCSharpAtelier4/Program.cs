using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedCSharpAtelier4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arraylist = new ArrayList();
            arraylist.AddRange(new string[] {"A","B","D","E" });
            
            Console.WriteLine("Le nombre d'éléments est {0}", arraylist.Count);
            //Ajouter un nouvel élément
            arraylist.Add("x");
            Console.WriteLine("Le nombre d'éléments est {0}", arraylist.Count);

            Console.WriteLine("Hello World!");
            List<Personne> personnes = new List<Personne>()
            {
                new Personne { Id= 1, age=18,Name="aaa"},
                new Personne {Id=2, age=20, Name="bbb"},
            };
            //Requête LINQ ui permet de récupérer les personnes dont l'age est 
            //compirs entre 15 et 20
            var pers = personnes.Where(a => a.age > 15 && a.age < 20).ToList().ToString();
            foreach(var item in pers)
            {
                Console.WriteLine(item);
            }
            var perso = from a in personnes
                        where (a.age > 15)
                        select a;
            //Requête avec nom = aaa
            var person = personnes.Where(a => a.Name == "aaa").FirstOrDefault();
            var persone = (from p in personnes
                           where (p.Name == "aaa")
                           select p)
                          .FirstOrDefault();
            //Récupérer une personne ayant comme Id 2
            var pe = personnes.FirstOrDefault(c => c.Id == 2);
        }
    }
    public class Voiture : IEnumerable
    {
        string[] car = new string[3];
        public IEnumerator GetEnumerator()
        {
            foreach(var s in car)
            {
                yield return s;
            }
        }
    }
}
