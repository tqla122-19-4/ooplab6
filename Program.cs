using System;
using System.Collections;

namespace ooplab6
{
    class Program
    {
        abstract class CGraphicsObject
        {
            public static int x, y, z, a;
        }
        class PolygonalСhain : CGraphicsObject
        {
            interface UIPolygonalСhain
            {
                void Per();
            }
            class Polytr
            {
                public int P(int x, int y, int z) { return x + y + z; }
                UIPolygonalСhain polychain;
                public Polytr(UIPolygonalСhain pol)
                {
                    polychain = pol;
                }
                public void Start()
                {
                    polychain.Per();
                }
            }
            class Perimeter : UIPolygonalСhain
            {
                public void Per()
                {

                    Console.WriteLine("Введите длину x: ");
                    CGraphicsObject.x = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите длину y: ");
                    CGraphicsObject.y = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите длину z: ");
                    CGraphicsObject.z = Convert.ToInt32(Console.ReadLine());
                }
            }
            class Square : CGraphicsObject
            {
                interface UISquare
                {
                    void Per();
                }
                class Squaretr
                {
                    public int P1(int a) { return a * 4; }
                    UISquare square;
                    public Squaretr(UISquare tr)
                    {
                        square = tr;
                    }
                    public void Start()
                    {
                        square.Per();
                    }
                }
                class Perimeter1 : UISquare
                {
                    public void Per()
                    {

                        Console.WriteLine("Введите a: ");
                        CGraphicsObject.a = Convert.ToInt32(Console.ReadLine());
                    }
                }

                delegate int Operation(int x, int y, int z);
                delegate int Operation1(int a);

                static void Main(string[] args)
                {



                    Polytr per = new Polytr(new Perimeter());
                    per.Start();
                    Operation operation = per.P;

                    int result = Convert.ToInt32(operation(CGraphicsObject.x, CGraphicsObject.y, CGraphicsObject.z));
                    Console.WriteLine("Длина ломаной линии:");
                    Console.WriteLine(result);

                    Squaretr per1 = new Squaretr(new Perimeter1());
                    per1.Start();
                    Operation1 operation1 = per1.P1;
                    int result1 = operation1(CGraphicsObject.a);

                    Console.WriteLine("Периметр квадрата:");
                    Console.WriteLine(result1);
                    Console.Read();

                    ArrayList numberlist = new ArrayList() { CGraphicsObject.x, CGraphicsObject.y, CGraphicsObject.z, CGraphicsObject.a };
                    object obj = 10;
                    numberlist.Add(obj);
                    numberlist.RemoveAt(4);

                    Console.WriteLine("Длины отрезков ломаной и сторона квадрата: ");
                    foreach (object o in numberlist)
                    {
                        Console.Write(o + " ");
                    }
                }
            }
        }
    }
}

