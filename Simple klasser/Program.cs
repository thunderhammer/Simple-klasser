using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_klasser
{
    class Program
    {
        public class Person
        {
            public string Fornavn;
            public string Efternavn;
            public int Fødselsår;


            public Person()
            {
                Fornavn = "";
                Efternavn = "";
            }

            public Person(string Fornavn, string Efternavn, int Fødselsår)
            {
                this.Fornavn = Fornavn.ToUpper();
                this.Efternavn = Efternavn.ToUpper(); 
                this.Fødselsår = Fødselsår;
            }
            
            public string FuldtNavn()
            {
                return (Fornavn + " " + Efternavn);
            }

            public int Alder()
            {
                DateTime Current_time = DateTime.Now;
                int estAlder = Current_time.Year - Fødselsår; 
                return estAlder;
            } 

         /*   public void udskriv(string ptype)
            {
                Console.WriteLine(ptype.Fornavn);
                )
            } */

        }
            static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person("Jens", "Hansen", 1966);
            Console.WriteLine(p1.Fornavn);
            Console.WriteLine(p1.Efternavn);
            Console.WriteLine(p2.Fornavn);
            Console.WriteLine(p2.Efternavn);
            Console.WriteLine(p2.Fødselsår);
            Console.WriteLine(p2.Alder());
        }
    }
}
