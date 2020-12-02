using System;

namespace OOP_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3];
            int[] array1 = new int[3];
            Console.WriteLine("Введiть 3 точки через пробiл для 1 рiвняння");
            array = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
            Console.WriteLine("Введiть 3 точки через пробiл для 2 рiвняння");
            array1 = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
            EquationOfTheLine equ1 = new EquationOfTheLine(array);
            EquationOfTheLine equ2 = new EquationOfTheLine(array1);
            Console.WriteLine($"Equation1 = {equ1}");
            Console.WriteLine($"Equation2 = {equ2}");
            Console.WriteLine($"Точка перетину {equ1.CrossingPoint(equ2)}");

            Console.WriteLine("Введiть 2 числа через пробiл для перевiрки, чи належить точка з такими координатами прямiй");
            double[] point_array = new double[2];
            point_array = Array.ConvertAll(Console.ReadLine().Trim().Split(), double.Parse);
            Point point = new Point(point_array[0], point_array[1]); 
            //Random rand = new Random();
            //Point point = new Point(rand.Next(-10, 10), rand.Next(-10, 10));
            Console.WriteLine($"Point {point}");
            Console.WriteLine(equ1.IsPointBelongLine(point) ? $"Точка належить прямiй {equ1}" : $"Точка не належить прямiй {equ1}");
            Console.ReadKey();
        }
    }
}
