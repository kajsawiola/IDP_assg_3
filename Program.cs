namespace Dag_15_inlamning
{
    internal class Program
    {

    }
    
    class Element
    {
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
        }
    }
}