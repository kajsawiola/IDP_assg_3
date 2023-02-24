using System.Diagnostics.CodeAnalysis;

namespace Dag_15_inlamning
{
    internal class Program
    {

    }
     
    class Element
    {
        public void Print()
        {
            Console.WriteLine($"Grundämne: {namn}");
            Console.WriteLine($"Atomnummer: {Z}");
            Console.WriteLine($"Typ: {typ}");
            Console.WriteLine($"Smältpunkt: {smältpunkt}");
            Console.WriteLine($"Kokpunkt: {kokpunkt}");
        }
        
        public string namn, Z, typ, smältpunkt, kokpunkt;
        static void Main(string[] args)
        {
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
                smältpunkt = "1811",
                kokpunkt = "3134"
            };
            Element guld = new Element()
            {
                namn = "guld",
                Z = "79",
                typ = "metall",
                smältpunkt = "1337.33",
                kokpunkt = "3243"
            };
            syre.Print();

            järn.Print();

            guld.Print();

            Element[] alla= new Element[6] { syre, järn, guld, null, null, null };
            alla[3] = new Element() { namn = "väte", Z = "1", typ = "ickemetall", smältpunkt = "13.99", kokpunkt = "20.271" };
            alla[4] = new Element() { namn = "brom", Z = "35", typ = "ickemetall", smältpunkt = "265.8", kokpunkt = "332.0" };
            alla[5] = new Element() { namn = "kvicksilver", Z = "80", typ = "metall", smältpunkt = "234.3210", kokpunkt = "629.88" };

            foreach (Element i in alla) 
            {
                i.Print();
            }
            
            foreach (var i in alla)
            {
               if (i.typ == "metall")
                    Console.WriteLine(i.namn);
            }
        }
    }
}