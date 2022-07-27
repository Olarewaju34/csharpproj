using System;
namespace Chapter7
{
    class Program
    {

        static void Main(string[] args )
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
for (int c = 0; c < character.Length; c++)
{
    Console.Write("Element of index {0} is: ",c);
    character[c] = Convert.ToChar(Console.ReadLine());  
            
}
for (int d = 0; d < character1.Length; d++)
{
    Console.Write("Element of index {0} is: ",d);
character1[d] =  Convert.ToChar(Console.ReadLine());  
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
int [] Arrays = new int [5];

for (int i = 0; i < Arrays.Length; i++)
{
  Console.Write("Enter elements of an arrary: ");
  Arrays[i]= Convert.ToInt32(Console.ReadLine()); 
 }
 if (Arrays[0]<Arrays[1]&&Arrays[0]<Arrays[2])
 {
  Console.WriteLine($"{Arrays[0]},{Arrays[1]},{Arrays[2]}");  
 }
else if (Arrays[1]<Arrays[2]&&Arrays[1]<Arrays[3])
{
   Console.WriteLine($"{Arrays[1]},{Arrays[2]},{Arrays[3]}") ;
}
else 
{
    Console.WriteLine($"{Arrays[2]},{Arrays[3]},{Arrays[4]}");
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
     Console.WriteLine();
    
   }
   Console.WriteLine("--------------Question17------------");
   
 int [] array1 = new int[3];
int []secondarray = new int[3];
int [] thirdarray = new int[6];
int a,b;
for ( a = 0; a <array1.Length; a++)
{
  Console.Write("Element {0} -",a);
  array1[a]= Convert.ToInt32(Console.ReadLine());
}
for ( a = 0;a <secondarray.Length; a++)
{
  Console.Write("Element {0} -",a);
secondarray[a]= Convert.ToInt32(Console.ReadLine());
}

for ( a = 0; a <array1.Length; a++)
{
  thirdarray[a]= array1[a];
}

for ( b =0; b <secondarray.Length; b++)
{
  thirdarray[a]= secondarray[b];
  a++;
}
Array.Sort(thirdarray);
for ( a = 0; a <thirdarray.Length; a++)
{
  Console.Write("{0} ",thirdarray[a]);
 }
        }
  }
}