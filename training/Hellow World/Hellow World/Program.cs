
Console.WriteLine("Hello, World!");
Console.Beep();
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine("Iam Learning");
Console.ForegroundColor = ConsoleColor.Red;

//Calculation
int a = 10;
int b = 10;

int c = a + b;

Console.WriteLine(c);

//getting values
Console.WriteLine("Enter 1st value");
string stra;
stra = Console.ReadLine();
String res = "You entred -2" + stra;
Console.WriteLine("Enter 1st value"+ stra);
Console.WriteLine("Enter 1st value {0}" , stra);
System.IO.File.WriteAllText(@"c:\temp\test.txt", "you entred -1 " + stra);
System.IO.File.AppendAllText(@"c:\temp\test.txt",  res);

//convert string to int

double x = double.Parse(stra);

double y = x * x;
Console.WriteLine("the Square of {0} is {1}", x, y);

//Area and converting to double

Console.WriteLine("Enter the Area of circle : ");
String strarea = Console.ReadLine();
double area = double.Parse(strarea);

double r = Math.Sqrt(area * 7.0 / 22);

string result = "The area of " + strarea + "is"+r;
Console.WriteLine(result);

