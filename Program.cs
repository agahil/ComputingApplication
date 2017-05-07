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
            Coordinates p0 = new Coordinates(0.0015, 0.0000, 1.0210);
            Coordinates p1 = new Coordinates(3.000, 1.0000, 0.0000);

            Coordinates[] coordinates = new Coordinates[24];
            for(int i = 0; i<12;i++)
            {
                coordinates[i] = p0;
            }
            for(int i = 12; i<24;i++)
            {
                coordinates[i] = p1;
            }
             string[] filenames = {"@x_5.net","@y_5.net","@z_5.net"};
            //Właściwy program
            ExtrapolatingCalculator c = new ExtrapolatingCalculator();
            Coordinates resultPosition = c.ExtrapolatePosition(p0, p1, x0, x1, xk);
            System.Console.WriteLine("Result coordinates: (" + resultPosition.X + "," + resultPosition.Y + "," + resultPosition.Z + ")");

            MachineLearningPredictor p = new MachineLearningPredictor();
            Coordinates result = p.ExtrapolatePosition(coordinates, filenames, coordinates.Length);
        }
    }
}
