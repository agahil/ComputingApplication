using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputingApplication
{
    /// <summary>
    /// Program ma za zadanie wyliczyć współrzędne wyjściowe mając dane współrzędne położenia głowy w obecnej chwilit, 
    /// w chwili t-1, numey klatek w chwilach t oraz t-1, a także numer klatki dla której ma być obliczone położenie głowy.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Przeliczanie czasu na numer klatki - tylko do testowania, 
            //docelowo będzie dostarczane z programu odbierającego dane z urządzenia
            int fps = 15;
            int t0 = 0;
            int t1 = 1;
            int tk = 2;
            int x0 = t0 * fps;
            int x1 = t1 * fps;
            int xk = tk * fps;

            //Dane docelowo dostarczone, jako parametry programu
            Coordinates p0 = new Coordinates(2.0, 0.0, 1.0);
            Coordinates p1 = new Coordinates(3.0, 3.0, 0.0);

            //Właściwy program
            Calculator c = new Calculator();
            Coordinates resultPosition = c.ExtrapolatePosition(p0, p1, x0, x1, xk);
            System.Console.WriteLine("Result coordinates: (" + resultPosition.X + "," + resultPosition.Y + "," + resultPosition.Z + ")");
        }
    }
}
