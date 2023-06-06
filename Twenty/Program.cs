//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
using System;
class Coordinates {
  static void Main() {
    int [] A = new int[3];
    int [] B = new int[3];
    int count = 0;
while(count < 2){
    if(count > 0){
        Console.WriteLine("Enter point B coordinates: ");
        B[0]= Convert.ToInt32(Console.ReadLine());
        B[1]= Convert.ToInt32(Console.ReadLine());
        B[2]= Convert.ToInt32(Console.ReadLine());
        }else{
            Console.WriteLine("Enter points A coordinates: ");
            A[0]= Convert.ToInt32(Console.ReadLine());
            A[1]= Convert.ToInt32(Console.ReadLine());
            A[2]= Convert.ToInt32(Console.ReadLine());
        }
        count++;
    }
for(int i = 0; i < A.Length; i++){
    Console.Write(A[i] + " ");
}
for(int i = 0; i < B.Length; i++){
    Console.Write(B[i] + " ");
}
  }
}