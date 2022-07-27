using System;
namespace Chapter7
{
    class Program
    {

        static void Main(string[] args, int v)
        {
Console.WriteLine("------------Question1-------------");
int[] Myarray = new int [20];
int result;
for (int i = 0; i < Myarray.Length; i++)
{
    Console.Write($"Element of index {i}: ");
    Myarray[i]= Convert.ToInt32(Console.ReadLine());
    result= Myarray[i]*5;
    Console.WriteLine("the multiplied result is "+result);
}
Console.WriteLine("--------------Question2------------------");
int [] FirstArray = new int [3];
int[] SecondArray = new int [3];
for (int i = 0; i < FirstArray.Length; i++)
{
    Console.Write($"Element of index {i} is: ");
    FirstArray[i]= Convert.ToInt32(Console.ReadLine());
}
for (int j = 0; j < SecondArray.Length; j++)
{
    Console.Write($"Element of index {j} is: ");
    SecondArray[j]= Convert.ToInt32(Console.ReadLine());
}
bool isArrayEqual = FirstArray.SequenceEqual(SecondArray);
Console.Write($"is the araray equal ??{isArrayEqual}");
Console.WriteLine("--------------------Question3--------------");
char[]character1 =new char[3]; 
char[] character = new char[3];
bool character2 = false;
for (int a = 0; a < character.Length; a++)
{
    Console.Write("Element of index {0} is: ",a);
    character[a] = Convert.ToChar(Console.ReadLine());  
            
}
for (int b = 0; b < character1.Length; b++)
{
    Console.Write("Element of index {0} is: ",b);
character1[b] =  Convert.ToChar(Console.ReadLine());  
}

            if (character.Length > character1.Length) Console.WriteLine("Second array is lexicographicaly first.");
            else if (character.Length < character1.Length) Console.WriteLine("First array is lexicographicaly first.");
            else
            {
                for (int i = 0; i < character.Length; i++)
                {
                    if (character[i] < character1[i])
                    {
                        Console.WriteLine("First array is lexicographicaly first.");
                        character2 = false;
                        break;
                    }
                    if (character[i] > character1[i])
                    {
                        Console.WriteLine("Second array is lexicographicaly first.");
                        character2 = false;
                        break;
                    }
                }

                if (character2) Console.WriteLine("Arrays are lexicographicaly equal.");
            }
 Console.WriteLine("---------------Question4----------------");
int [] NewArray = new int [5];

for (int i = 0; i < NewArray.Length; i++)
{
  Console.Write("Enter elements of an arrary: ");
  NewArray[i]= Convert.ToInt32(Console.ReadLine()); 
 }

    if (NewArray[0]==NewArray[1]&&NewArray[0]==NewArray[2])
    {
        Console.WriteLine($"The Maximal Sequence is {NewArray[0]},{NewArray[1]},{NewArray[2]}");
    }
    else if (NewArray[1]==NewArray[2]&&NewArray[1]==NewArray[3])
    {
       Console.WriteLine($"The Maximal Sequence is {NewArray[1]},{NewArray[2]},{NewArray[3]}"); 
    }
    else
    {
        Console.WriteLine($"the Maximal Sequence is {NewArray[2]},{NewArray[3]},{NewArray[4]}");
    }
    Console.WriteLine("---------------Question5----------------");
int [] Array = new int [5];

for (int i = 0; i < Array.Length; i++)
{
  Console.Write("Enter elements of an arrary: ");
  Array[i]= Convert.ToInt32(Console.ReadLine()); 
 }
 if (Array[0]<Array[1]&&Array[0]<Array[2])
 {
  Console.WriteLine($"{Array[0]},{Array[1]},{Array[2]}");  
 }
else if (Array[1]<Array[2]&&Array[1]<Array[3])
{
   Console.WriteLine($"{Array[1]},{Array[2]},{Array[3]}") ;
}
else 
{
    Console.WriteLine($"{Array[2]},{Array[3]},{Array[4]}");
}
Console.WriteLine("------------Question6-------------");




Console.WriteLine("------------Question7--------------");
int [] firstArray= new int [6];
int sum=0;
for (int i = 0; i <firstArray.Length; i++)
{
Console.Write("Elements {0}: ",i);
firstArray[i]= Convert.ToInt32(Console.ReadLine());
sum+=firstArray[i];
}
Console.WriteLine(sum);
int [] array = new int[3];
Console.WriteLine("------------Question8------------");

int[] sortArray = new int [7];
int temp;
for (int i = 0; i < sortArray.Length; i++)
{
Console.Write("Elemenys at index {0}: ",i);
sortArray[i]= Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < FirstArray.Length-1; i++)
{
int minindex = i;
for (int j = i+1; j <sortArray.Length; j++)
{
  if (sortArray[j]<sortArray[minindex])
  {
    minindex=j;
 
 temp = sortArray[minindex];
 sortArray[minindex]= sortArray[i];
 sortArray[i]=temp;

  }
}  
}
for (int i = 0; i <FirstArray.Length ; i++)
{
  Console.Write("{0} ",FirstArray[i]);
}
Console.WriteLine("-------------------Question12--------------------");
int [,] numbers = new int[4,4];
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        Console.Write($"enter integers for roll {i} and column {j}: ");
        numbers[i,j]= Convert.ToInt32(Console.ReadLine());

    }
    }
    
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        Console.Write(  numbers[i,j] + " ");
      
     }
     Console.WriteLine();
    }
    Console.WriteLine("---------------Question16-------------------");
    int [] sortedarrays = new int [5];
    for (int i = 0; i <sortedarrays.Length; i++)
    {
      Console.Write("Element at index {0}: ",i);
      sortedarrays[i]= Convert.ToInt32(Console.ReadLine());
    }
   }
  }
}