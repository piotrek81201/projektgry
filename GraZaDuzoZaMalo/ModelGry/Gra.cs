using System;

namespace ModelGry
{
    public class Gra
    { 
        public enum Odpowiedz { ZaMalo = -1, ZaDuzo = 0, Trafiono = 1 }
        public enum StanGry { Trwa, Odgadnieta, Poddana }
 
        public StanGry Stan { get; private set; }
        public readonly int ZakresOd, ZakresDo;

        
        private readonly int wylosowana;
        public int? Wylosowana
        {
            get
            {
                if (Stan == StanGry.Poddana || Stan == StanGry.Odgadnieta)
                    return wylosowana;
                else
                    return null;
            }
            
        } 

        public int LicznikRuchow { get; private set; }  = 0;

        public Gra(int a, int b)
        {
            ZakresOd = Math.Min(a,b);
            ZakresDo = Math.Max(a,b);
            wylosowana = Losuj(ZakresOd, ZakresDo);
            Stan = StanGry.Trwa;
        }

        public Odpowiedz Ocena( int propozycja )
        {
            LicznikRuchow++;
            if (propozycja < wylosowana)
                return Odpowiedz.ZaMalo;
            else if (propozycja > wylosowana)
                return Odpowiedz.ZaDuzo;
            else
            {
                Stan = StanGry.Odgadnieta;
                return Odpowiedz.Trafiono;
            }
        }

        public void Poddaj()
        {
            Stan = StanGry.Poddana;
        }

        public static int Losuj(int a = 1, int b = 100)
        {
            if (a > b)
            { 
                int tmp = a;
                a = b;
                b = tmp;
            }
            Random generator = new Random();
            return generator.Next(a, b + 1);
        }


    }
}
