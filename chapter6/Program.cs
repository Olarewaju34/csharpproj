Console.WriteLine("--------------Question1---------------");
int Integer1 = 1;
Console.Write("Enter Second Number: ");
int Integer2 = int.Parse(Console.ReadLine());
while (Integer1<Integer2)
{
Console.Write(Integer1 +" ");  
Integer1++;
}
//    Console.WriteLine("------------Question2------------");
//     Console.Write("input a number: ");
//     int n = Convert.ToInt32(Console.ReadLine());
//     for (int value = 1; value <= n; value++)
//     {
//         if(value % 3 == 0 && value% 7 ==0)
//         {
//     Console.WriteLine(value);
//         }
//     }
Console.WriteLine("--------------Question3-----------------");
int [] FirstArray = new int [6];
int max;
int min;
for (int i = 0; i <FirstArray.Length; i++)
{
  Console.Write("Elements {0}: ",i);
}
max = FirstArray[0];
min = FirstArray[0];
for (int i = 0; i < FirstArray.Length;i++)
{
  if (FirstArray[i]>max)
  {
   max = FirstArray[i];
  
  }
if (FirstArray[i]<min)
{
  min= FirstArray[i];
}
}
Console.WriteLine("The Maximum Number is ",max);
Console.WriteLine("The Minimum Number is ",min);
//     Console.WriteLine("---------------------Question4-------------");
//  Console.Write("printing deck of card: ");
//   for (int i = 1; i <= 4; i++)
//    {
//      for (int j =2; j  <= 14 ; j++)
//      {
//        switch (i)
//        {
//         case 1:
//         Console.WriteLine("club");
//         break;

//         case 2:
//         Console.WriteLine("diamond");
//         break;
//         case 3:
//         Console.WriteLine("hearts");
//      break;
//        case 4: 
//         Console.WriteLine("spades");
//        break;    
//        }
//        switch (j)
//        {
//    case 2:
//    Console.Write("2-");
//    break;
//    case 3:
//    Console.Write("3-");
//   break;
//    case 4:
//    Console.Write("4-");
//    break;
//    case 5:
//    Console.Write("5-");
//    break;
//    case 6:
// Console.Write("6-");
//  break;
//  case 7:
//  Console.Write("7-");
//  break;
//  case 8:
//  Console.Write("9-");
//  break;
//  case 10:
//  Console.Write("10-");
// break;
//  case 11:
//  Console.Write("A-");
// break;
//  case 12:
//  Console.Write("J-");
//  break;
//  case 13:
//  Console.Write("K-");
//  break;
//  case 14:
//  Console.Write("Q-");
// break;
//}
//    Console.WriteLine("--------------Question5------------------");
//     int firstterm = 0;
//     int secondterm =1;
//     Console.Write("enter number: ");
//     int input = Convert.ToInt32(Console.ReadLine());
//      int term;
//      for (int i = 0; i <= input; i++)
//      {    Console.WriteLine("{0}",firstterm);
//     term = firstterm+secondterm;
//        firstterm=secondterm;
//        secondterm=term;
//       }
// Console.WriteLine("------------Question6---------");
// Console.Write("input integer N: ");
// int integerN  = int.Parse(Console.ReadLine()); 
// Console.Write("input integer k: ");
// int integerK = int.Parse(Console.ReadLine());
// long factorialN =1;
// long factorialK =1;
// int subtractedinteger = integerN-integerK;
// long subtrataction =1;
// while(integerN  > 0)
// {
// factorialN*=integerN;
// integerN--;
// }
// Console.WriteLine($"the factorial of {integerN} is {factorialN}");
// do
// {
// factorialK*=integerK;
// integerK--;
// } while (integerK>0);
// Console.WriteLine($"the factorial of {integerK} is {factorialK}");
// long Result = factorialN / factorialK;
// Console.WriteLine($"the division of {factorialN} and {factorialK} is {Result}");
// Console.WriteLine("-----------Question7-----------");
// do
// {
//     subtrataction*=subtractedinteger;
//     subtractedinteger--;
// } while (subtractedinteger>0);
// Console.WriteLine($"the result of substracted factorial is {subtrataction}");
// long factorial = factorialN *factorialK;
// long totalfactorial = factorial/subtrataction;
// Console.WriteLine($"the result of the total  is {totalfactorial}");
// Console.WriteLine("-------------------Question8--------------------");
// Console.Write("enter intgerN: ");
// int N = int.Parse(Console.ReadLine());
// int MultipliedN = 2*N;
// long MultipliedfactorialN = 1;
// long Nfactorial = 1;
// int AddedN = N+1;
// long AddedFactorial =1;
// do
// {
//     MultipliedfactorialN*=MultipliedN;
//     MultipliedN--;
// } while (MultipliedN>0);
// do
// {
//     AddedFactorial*=AddedN;
//     AddedN--;
// } while (AddedN>0);
// do
// {
//     Nfactorial *= N;
//     N--;
// } while (N>0);
  
// //   long CatalanNumber = (MultipliedfactorialN)/(AddedFactorial*Nfactorial);
//   Console.WriteLine("-------------------Question9----------------");
//   double S = 1;
//   double sequence;
//   Console.Write("enter an integer X: ");
//   int X = int.Parse(Console.ReadLine());
//   long Factorialn = 1;
//   for (int k = 0; k < 5; )
// {
//     k++;
//   do
//   {
//     Factorialn*=k;
//     k--;
//   } while (k<0);
//   k++;
// sequence=Factorialn/Math.Pow(X,k);
//     S+=sequence;
//   }
//    Console.WriteLine(S);
// Console.WriteLine("--------------Question10----------------");
// Console.Write("Enter rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int [,] myArray = new int [rows,columns];

// for (int i = 0; i <myArray.GetLength(0); i++)
// {
//     for (int j = 0; j <myArray.GetLength(1); j++)
//     {
//         Console.Write($"the integer of roll {i} and column {j} is: ");
//         myArray[i,j]=Convert.ToInt32(Console.ReadLine());
//     }
// }

// for (int i = 0; i <myArray.GetLength(0); i++)
// {
//     for (int j = 0; j <myArray.GetLength(1);j++)
// {
//      Console.Write( myArray[i,j] + " ");
        
//     }
//     Console.WriteLine();
//  }
//       Console.WriteLine("---------------Question11-----------");
//       Console.Write("Enter an integer: ");
//       int n = int.Parse(Console.ReadLine());
//       int count = 0;

//       for (int i = 5; n/i >1 ;  )
//       {
//         count += n/i;
//          i*=5;
//       }
//       Console.WriteLine($"the number of zeros in {n}! is {count}");
//       Console.WriteLine("--------------------Question12---------------");
//       Console.WriteLine("Enter a decimal Number: ");
//       int Decimal = Convert.ToInt32(Console.ReadLine());
//       string ConvertedNo = Convert.ToString(Decimal,2);
//       Console.WriteLine($"The binary number of {Decimal} is {ConvertedNo}");
//       Console.WriteLine("--------------------Question13----------------");
//       Console.Write("Enter a binary Number: ");
//       string Binary = Console.ReadLine();
//       int BinaryConvert = Convert.ToInt32(Binary,2);
//        Console.WriteLine("the decimal Number of  "+Binary+ " is "+ BinaryConvert );
//       Console.WriteLine("--------------Question14--------------");
//       Console.WriteLine("Enter a decimal number: ");
//       int Integer = Convert.ToInt32(Console.ReadLine());
//       Console.WriteLine("the hexadecimal number of {0} is {0:X}",Integer);
//       Console.WriteLine("---------------Question15-------------");
// Console.Write("Enter an hexadecimal number: ");
//       string hexadecimal = Console.ReadLine();
//       int DecimalInt = Convert.ToInt32(hexadecimal,16);
// //       Console.WriteLine("The hexadeciaml number of {0} is {1}",hexadecimal,DecimalInt);
//        Console.WriteLine("------------Question16--------------");
//        Random Numbers = new Random();
//        Console.Write("Enter any Number: ");
//        int Anyinteger = Convert.ToInt32(Console.ReadLine());
//       for (int i = 0; i < Anyinteger;)
//       {
//         i++;
//         Console.WriteLine(Numbers.Next(i,Anyinteger));
//       }
