using System;
using System.Diagnostics.CodeAnalysis;

namespace Dag_15_inlamning
{
    internal class Program
    {

    }
    //uppgift 1
    class Element
    {
        // uppgift 3
        public void Print()
        {
            Console.WriteLine($"Grundämne: {namn}");
            Console.WriteLine($"Atomnummer: {Z}");
            Console.WriteLine($"Typ: {typ}");
            Console.WriteLine($"Smältpunkt: {smältpunkt}");
            Console.WriteLine($"Kokpunkt: {kokpunkt}");
            Console.WriteLine("                   ");
        }

        public string namn, Z, typ, smältpunkt, kokpunkt;
        static void Main(string[] args)
        {
            // uppgift 2
            Element syre = new Element()
            {
                namn = "syre",
                Z = "8",
                typ = "ickemetall",
                smältpunkt = "54.36",
                kokpunkt = "90.188"
            };

            Element järn = new Element()
            {
                namn = "järn",
                Z = "26",
                typ = "metall",
                smältpunkt = "1811.0",
                kokpunkt = "3134.0"
            };
            Element guld = new Element()
            {
                namn = "guld",
                Z = "79",
                typ = "metall",
                smältpunkt = "1337.33",
                kokpunkt = "3243.0"
            };
            syre.Print();

            järn.Print();

            guld.Print();

            //uppgift 4
            Element[] alla = new Element[6] { syre, järn, guld, null, null, null };
            alla[3] = new Element() { namn = "väte", Z = "1", typ = "ickemetall", smältpunkt = "13.99", kokpunkt = "20.271" };
            alla[4] = new Element() { namn = "brom", Z = "35", typ = "ickemetall", smältpunkt = "265.8", kokpunkt = "332.0" };
            alla[5] = new Element() { namn = "kvicksilver", Z = "80", typ = "metall", smältpunkt = "234.321", kokpunkt = "629.88" };

            //uppgift 5
            foreach (Element i in alla)
            {
                i.Print();
            }
            //uppgift 7
            foreach (var i in alla)
            {
                if (i.typ == "metall")
                    Console.WriteLine(i.namn + " är metall");
            }

            // upgift 8, fungerar ej

            double nollCelsius = 273.16;
            foreach (var a in alla)   
            {
                
                if (Convert.ToDouble(a.smältpunkt) < nollCelsius && Convert.ToDouble(a.kokpunkt) > nollCelsius)
                    {
                        Console.WriteLine($"Dessa ämnen har en smälpunkt som är under 273.16 F och en kokpunkt " +
                            $"som är högre än 273.16 F: {a.namn}");
                    }

                }

            }
        }
    }

