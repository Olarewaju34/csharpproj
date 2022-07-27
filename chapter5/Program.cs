// Console.WriteLine("Question1\n_________________");
// double Firstinput = 5;
// double Secondinput = 7;
// if (Firstinput>Secondinput)
// {
//     Firstinput = Secondinput;
//     Console.WriteLine(Secondinput);
// }
//  Console.WriteLine("Question2.\n_________________");
// Console.WriteLine("Question3\n---------------");

//  Console.Write("enter first number: ");
//  int FirstNumber = int.Parse(Console.ReadLine());

//  Console.Write("enter second number: ");
//  int SecondNumber = int.Parse(Console.ReadLine());

//  Console.Write("enter third number: ");
//  int ThirdNumber = int.Parse(Console.ReadLine());
//  if (FirstNumber> SecondNumber && FirstNumber>ThirdNumber)
//  {
//   Console.WriteLine(FirstNumber); 
//  }
//  else if (SecondNumber> ThirdNumber && SecondNumber> FirstNumber)
//  {
// Console.WriteLine(SecondNumber);
//  }
//  else
//  {
// Console.WriteLine(ThirdNumber);
//  }
//  Console.WriteLine("Question4\n--------------");
//  Console.Write("enter first number: ");
//  int Firstinteger = int.Parse(Console.ReadLine());

//  Console.Write("enter second number: ");
//  int Secondinteger = int.Parse(Console.ReadLine());

//  Console.Write("enter third integer:  ");
//  int Thirdinteger = int.Parse(Console.ReadLine());

//  if (Firstinteger>Secondinteger && Firstinteger>Thirdinteger)
//  {
//     if (Secondinteger>Thirdinteger)
//     {
//         Console.WriteLine($"{Firstinteger} {Secondinteger},{Thirdinteger} ");
//     }
//  else
//  {
//     Console.WriteLine($"{Firstinteger} {Thirdinteger} {Secondinteger}");
//  }
//  }

//  if (Secondinteger>Firstinteger && Secondinteger>Thirdinteger)
//  {
//     if (Firstinteger > Thirdinteger)
//     {
//         Console.WriteLine($"{Secondinteger} {Firstinteger} {Thirdinteger}");
//     }
//    else
//    {
//     Console.WriteLine($"{Secondinteger} {Thirdinteger} {Firstinteger}");
//    }
//  }
//  if(Thirdinteger>Firstinteger && Thirdinteger> Secondinteger) 
//  {
//     if(Secondinteger>Firstinteger)
//     {
//    Console.WriteLine($"{Thirdinteger} {Secondinteger} {Firstinteger}");
//     }
// }
//  else
//  {
//     Console.WriteLine($"{Thirdinteger} {Secondinteger} {Firstinteger}");
//  }
//  Console.WriteLine("---------------------Question 5------------");
// Console.Write("Enter a number from 0--9: ");
// int Digit = int.Parse(Console.ReadLine());
// switch (Digit)
// {
//     case 0:
//         Console.WriteLine("Zero");
//         break;

//     case 1:
//         Console.WriteLine(" One");
//         break;

//     case 2:
//         Console.WriteLine("Two");
//         break;

//     case 3:
//         Console.WriteLine("Three");
//         break;

//     case 4:
//         Console.WriteLine("Four");
//         break;

//     case 5:
//         Console.WriteLine("Five");
//         break;

//     case 6:
//         Console.WriteLine("Six");
//         break;

//     case 7:
//         Console.WriteLine("Seven");
//         break;

//     case 8:
//         Console.WriteLine("Eight");
//         break;
//     case 9:
//         Console.WriteLine("Nine");
//         break;
//     default:
//         Console.WriteLine("invalid!!");
//         break;
// }

// Console.WriteLine("---------question7--------------");
// Console.Write("enter coefficient of a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("enter coefficient of b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("enter coefficient of c: ");
// int c = Convert.ToInt32(Console.ReadLine());
// double x1;
// double x2;
// int D = b * b - 4 * a * c;
// Console.WriteLine(D);
// if (D < 0)
// {
//     Console.WriteLine("it has no real root");
// }
// else if (D == 0)
// {
//     x1 = -b / 2 * a;
//     Console.WriteLine(x1);
// }
// else
// {
//     x1 = -b - Math.Sqrt(D) / 2 * a;
//     x2 = -b + Math.Sqrt(D) / 2 * a;
//     Console.WriteLine($"roots of the equation are {x1} and {x2}");
// }
// Console.WriteLine("-------------Question8------------");
// Console.WriteLine("enter any varaiable: ");
// var variable = Console.ReadLine();
// Console.Write("Enter an input: ");
// var input = Console.ReadLine();

// switch(variable)
// {
// case "int" :
// case "double" : 
// Console.WriteLine($"{input+1} ");
// break;
 
//  case "string" :
//  Console.WriteLine($"{input}*");
//  break;

// default :
// Console.WriteLine("invalid variable!!!");
// break;
 
// // }
// Console.WriteLine("-----------Question9---------------");
// Console.WriteLine("Enter five number: ");
// int Number1 =Convert.ToInt32(Console.ReadLine());
// int Number2 =Convert.ToInt32(Console.ReadLine());
// int Number3 =Convert.ToInt32(Console.ReadLine());
// int Number4 =Convert.ToInt32(Console.ReadLine());
// int Number5 = Convert.ToInt32(Console.ReadLine());
 
//  if (Number1 + Number2 + Number3 ==0)
//  {
    
// Console.WriteLine($"the subset of {Number1},{Number2},{Number3}={Number1 + Number2 + Number3}");
    
//  }else
//  {
//     if (Number3+Number4+Number5==0)
//     {
//         Console.WriteLine($"the subset of {Number4},{Number3},{Number5} is {Number3+Number4+Number5}" );
//     }
//     else
//     {
//         Console.WriteLine("No subset is equal to zero");
//     }
//  }
// Console.WriteLine("-----------------Question10-----------------");
//     Random numberGen = new Random();
//     int bonus = numberGen.Next(0,11);
//     Console.WriteLine($"your bonus score is {bonus}");
//      if (bonus == 2 )
//      {
//        Console.WriteLine(bonus*10);
//      }
//      else if (bonus == 5)
//      {
//         Console.WriteLine(bonus *100);
//      }else if (bonus ==8 )
//      {
//         Console.WriteLine(bonus *1000);
//      }
//      else if (bonus == 0 || bonus>9)
//      {
//    Console.WriteLine("error!!!");
//      }
     Console.WriteLine("-------------Question11-----------");
Console.Write("enter any number from 0-999: ");
int number =int.Parse (Console.ReadLine());
 switching(number);
 
 
    static void switching(int number)
    {
        if (number%2==0)
{          
switch(number)
{
case 0:
Console.WriteLine("Zero");
break;
} 
       
switch(number)
{
case 2:
Console.WriteLine("Two");
break;
} 
       
switch(number)
{
case 4:
Console.WriteLine("Four");
break;
} 
       
switch(number)
{
case 6:
Console.WriteLine("Six");
break;
} 
       
switch(number)
{
case 8:
Console.WriteLine("Eight");
break;
} 
       
switch(number)
{
case 12:
Console.WriteLine("Twelve");
break;
} 
       
switch(number)
{
case 14:
Console.WriteLine("Fourteen");
break;
} 
       
switch(number)
{
case 18:
Console.WriteLine("Eighteen");
break;
} 
       
switch(number)
{
case 22:
Console.WriteLine("Twenty Two");
break;
} 
       
switch(number)
{
case 24:
Console.WriteLine("Twenty Four");
break;
} 
       
switch(number)
{
case 26:
Console.WriteLine("Twenty six");
break;
} 
       
switch(number)
{
case 28:
Console.WriteLine("Twenty Eight");
break;
} 
       
switch(number)
{
case 32:
Console.WriteLine("Thirty Two");
break;
} 
       
switch(number)
{
case 34:
Console.WriteLine("Thirty Four");
break;
} 
       
switch(number)
{
case 36:
Console.WriteLine("Thirty six");
break;
} 
       
switch(number)
{
case 38:
Console.WriteLine("thirty eight");
break;
} 
       
switch(number)
{
case 42:
Console.WriteLine("fourty two");
break;
} 
       
switch(number)
{
case 44:
Console.WriteLine("fourty four");
break;
} 
       
switch(number)
{
case 46:
Console.WriteLine("Fourty six");
break;
} 
       
switch(number)
{
case 48:
Console.WriteLine("Fourty eight");
break;
} 
       
switch(number)
{
case 52:
Console.WriteLine("fifty two");
break;
} 
       
switch(number)
{
case 54:
Console.WriteLine("fifty four");
break;
} 
       
switch(number)
{
case 56:
Console.WriteLine("fifty six");
break;
} 
       
switch(number)
{
case 58:
Console.WriteLine("fifty eight");
break;
} 
       
switch(number)
{
case 62:
Console.WriteLine("sixty two");
break;
} 
       
switch(number)
{
case 64:
Console.WriteLine("sixty four");
break;
} 
       
switch(number)
{
case 66:
Console.WriteLine("sixty six");
break;
} 
       
switch(number)
{
case 68:
Console.WriteLine("sixty eighty");
break;
} 
       
switch(number)
{
case 72:
Console.WriteLine("seventy two");
break;
} 
       
switch(number)
{
case 74:
Console.WriteLine("seventy four");
break;
} 
       
switch(number)
{
case 76:
Console.WriteLine("seventy six");
break;
} 
       
switch(number)
{
case 78:
Console.WriteLine("seventy  eight");
break;
} 
       
switch(number)
{
case 82:
Console.WriteLine("eighty two");
break;
} 
       
switch(number)
{
case 84:
Console.WriteLine("eighty four");
break;
} 
       
switch(number)
{
case 86:
Console.WriteLine("eighty six");
break;
} 
       
switch(number)
{
case 88:
Console.WriteLine("eighty eight");
break;
} 
       
switch(number)
{
case 92:
Console.WriteLine("ninety two");
break;
} 
       
switch(number)
{
case 94:
Console.WriteLine("ninety four");
break;
} 
       
switch(number)
{
case 96:
Console.WriteLine("ninenty six");
break;
} 
       
switch(number)
{
case 98:
Console.WriteLine("ninety eight");
break;
}     
} 
if (number%2!=0)
{      
switch(number)
{
case 1:
Console.WriteLine("one");
break;
} 
       
switch(number)
{
case 3:
Console.WriteLine("three");
break;
} 
       
switch(number)
{
case 7:
Console.WriteLine("seven");
break;
} 
       
switch(number)
{
case 9:
Console.WriteLine("nine");
break;
} 
       
switch(number)
{
case 11:
Console.WriteLine("eleven");
break;
} 
       
switch(number)
{
case 13:
Console.WriteLine("thirteen");
break;
}       
switch(number)
{
case 15:
Console.WriteLine("fifteen");
break;
} 
       
switch(number)
{
case 17:
Console.WriteLine("seventeen");
break;
} 
       
switch(number)
{
case 19:
Console.WriteLine("nineteen");
break;
} 
       
switch(number)
{
case 21:
Console.WriteLine("Twenty one");
break;
} 
       
switch(number)
{
case 23:
Console.WriteLine("Twenty three");
break;
} 
       
switch(number)
{
case 27:
Console.WriteLine("Twenty seven");
break;
}

switch(number)
{
case 29:
Console.WriteLine("Twenty nine");
break;
} 

switch(number)
{
case 31:
Console.WriteLine("thirty one");
break;
} 

switch(number)
{
case 33:
Console.WriteLine("Thirty three");
break;
}

switch(number)
{
case 37:
Console.WriteLine("thirty seven");
break;
} 

switch(number)
{
case 39:
Console.WriteLine("thirty nine");
break;
} 

switch(number)
{
case 41:
Console.WriteLine("fourty one");
break;
} 

switch(number)
{
case 43:
Console.WriteLine("fourty three");
break;
}  

switch(number)
{
case 47:
Console.WriteLine("fourty seven");
break;
}  

switch(number)
{
case 49:
Console.WriteLine("fourty nine");
break;
}  

switch(number)
{
case 51:
Console.WriteLine("fifty one");
break;
}  

switch(number)
{
case 53:
Console.WriteLine("fifty three");
break;
}  

switch(number)
{
case 57:
Console.WriteLine("fifty seven");
break;
}  

switch(number)
{
case 59:
Console.WriteLine("fifty nine");
break;
}  

switch(number)
{
case 61:
Console.WriteLine("sixty one");
break;
}  

switch(number)
{
case 63:
Console.WriteLine("sixty three");
break;
}  

switch(number)
{
case 67:
Console.WriteLine("sixty seven");
break;
}  

switch(number)
{
case 69:
Console.WriteLine("sixty nine");
break;
}  

switch(number)
{
case 71:
Console.WriteLine("seventy one");
break;
}  

switch(number)
{
case 73:
Console.WriteLine("seventy three");
break;
}  

switch(number)
{
case 77:
Console.WriteLine("seventy seven");
break;
}  

switch(number)
{
case 79:
Console.WriteLine("seventy nine");
break;
}  

switch(number)
{
case 81:
Console.WriteLine("eighty one");
break;
}  

switch(number)
{
case 83:
Console.WriteLine("eighty three");
break;
}  

switch(number)
{
case 87:
Console.WriteLine("eighty seven");
break;
}  

switch(number)
{
case 89:
Console.WriteLine("eighty nine");
break;
}  

switch(number)
{
case 91:
Console.WriteLine("ninety one");
break;
}  

switch(number)
{
case 93:
Console.WriteLine("ninety three");
break;
}  

switch(number)
{
case 97:
Console.WriteLine("ninenty seven");
break;
}  

switch(number)
{
case 99:
Console.WriteLine("ninenty nine");
break;
}  
}
    }  
