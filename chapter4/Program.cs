Console.Write("enter any integer of ur choice: ");
double firstinteger = double.Parse(Console.ReadLine());

Console.Write("enter a second integer: ");
double secondinteger = double.Parse(Console.ReadLine());

Console.Write("enter third integer: ");
double thirdinteger = double.Parse(Console.ReadLine());

double summation = firstinteger + secondinteger +thirdinteger;
Console.WriteLine("the sum of {0},{1} and {2} is {3}",firstinteger,secondinteger,thirdinteger,summation);
Console.Write("------------------Question2------------\n");
Console.Write("Area and Perimeter of a circle\n");
Console.WriteLine("--------------------------");
Console.Write("enter any radius of ur choice: ");
double radius = int.Parse(Console.ReadLine());
double Area =  Math.PI * radius * radius;
double perimeter = 2* Math.PI*radius ;
Console.WriteLine("the area and perimater of the circle are {0} and {1}",Math.Round(Area,2),Math.Round(perimeter,2));
Console.WriteLine("the area and perimater of the circle are {0} and {1}",Math.Round(Area,2),Math.Round(perimeter,2));
Console.WriteLine("---------------------Question3------------");
Console.Write("----------Company information\n----------------\n");

Console.Write("enter your dream company name: ");
string companyname = Console.ReadLine();
Console.Write("enter your dream company address: ");
string companyaddress = Console.ReadLine();
Console.Write("enter company fax number: ");
long companyfaxnumber = long.Parse(Console.ReadLine());
Console.Write("enter ur dream company website: ");
string website = Console.ReadLine();
Console.Write("please input ur surname and name: ");
string managernames = Console.ReadLine();
Console.Write("enter your phonenumber: ");
long phonenumber = long.Parse(Console.ReadLine());
 Console.WriteLine("your company name is {0} and you located at {1}.\n your fax number is {2} and u can contact us on {3}",companyname,companyaddress,companyfaxnumber,website);
Console.WriteLine("your manager at {0} is {1}.\n you can contact him through his number which is {2}",companyname,managernames,phonenumber);
Console.WriteLine("--------------------------------------");
Console.WriteLine("Question4");
Console.WriteLine("enter three numbers: ");
int  number1;
int number2;
int nummber3;
number1 = int.Parse(Console.ReadLine());
number2= int.Parse(Console.ReadLine());
nummber3 = int.Parse(Console.ReadLine());

Console.WriteLine("{0,-10:X}{1,-10:0.00}{2,-10:-0.00}",number1,number2,nummber3);

Console.Write("enter a number: ");
int firstnum = int.Parse(Console.ReadLine());

Console.Write("enter another number: ");
int secondnum = int.Parse(Console.ReadLine());
while(firstnum<secondnum)
{
firstnum++;
if(firstnum%5==0)
{
Console.WriteLine(firstnum);
}
}
Console.WriteLine("------------Question6---------------");
Console.Write("enter ur first input: ");
int firstinput = int.Parse(Console.ReadLine());
Console.Write("enter your second input: ");
int seconinput = int.Parse(Console.ReadLine());

 int maxnumber = Math.Max(firstinput,seconinput);
 Console.WriteLine(maxnumber);
 Console.WriteLine("------------------Question7--------------");

        int sum = 0;
        int i = 0;
         while ( i <= 4)
      {
          Console.Write("Please enter number :");
          string  input = Console.ReadLine();
          int x;
           bool isInteger = int.TryParse(input , out x);
      if (!isInteger)
           {
             i--;
             Console.Write("Invalid input! ");
             
           }
           
           
           sum += x;
           i++;
      }
      Console.WriteLine($"the sum of the number is {sum} ");
      Console.WriteLine("------------Question8-------------");
      Console.Write("finding the greatest of 5 numbers\n-----------\n");
int[] fiveintegers = new int[5];
for (int j = 0; j < fiveintegers.Length; j++)
{
Console.Write("enter an integer: ");
 fiveintegers[j] = int.Parse(Console.ReadLine());
}
int greatestarray =fiveintegers.Max();
Console.WriteLine($"the greatest number in the array is {greatestarray}");
Console.WriteLine("---------------------Question9-------------------");
Console.Write("enter a number: ");
int firstnumber = int.Parse(Console.ReadLine());
Console.Write("enter another number: ");
int secondnumber = int.Parse(Console.ReadLine());
int result=0;
while (firstnumber<secondnumber)
{
  result+=firstnumber;
  firstnumber++;
}
Console.WriteLine(result);

Console.WriteLine("---------------------Question10--------------");
int FirstNo = 1;
Console.WriteLine("enter a number: ");
int SecondNo = int.Parse(Console.ReadLine());
while(FirstNo<SecondNo)
{
Console.WriteLine(FirstNo);
FirstNo++;
}
Console.WriteLine("-----------Question11-------------");
    int FirstTerm = 0;
    int SecondTerm =1;
    int counter = 100;
     int nextterm;
     for (int j = 0; j <= counter; j++)
     {
      Console.WriteLine("{0}",FirstTerm);
      nextterm = FirstTerm+SecondTerm;
       FirstTerm=SecondTerm;
       SecondTerm= nextterm;
     }
