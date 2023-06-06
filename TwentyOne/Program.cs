//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
using System;
class HelloWorld {
  static void Main() {
    double [] A = new double[3];
    double [] B = new double[3];
    int count = 0;
while(count < 2){
    if(count > 0){
        Console.WriteLine("Enter point B coordinates: ");
        B[0]= Convert.ToDouble(Console.ReadLine());
        B[1]= Convert.ToDouble(Console.ReadLine());
        B[2]= Convert.ToDouble(Console.ReadLine());
        }else{
            Console.WriteLine("Enter points A coordinates: ");
            A[0]= Convert.ToDouble(Console.ReadLine());
            A[1]= Convert.ToDouble(Console.ReadLine());
            A[2]= Convert.ToDouble(Console.ReadLine());
        }
        count++;
    }

      Console.Write($"The distance between the points is: {Distance(A,B)}.");
  }
  

static double Distance(double[] point, double[] pointOne){
    double distance = Math.Pow((point[0] - pointOne[0]), 2) + Math.Pow((point[1] - pointOne[1]), 2) + Math.Pow((point[2] - pointOne[2]), 2);
    distance = Math.Sqrt(distance);
    distance = Math.Round(distance,2);
    return distance;
  }
}  
