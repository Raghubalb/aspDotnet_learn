using creating_classes;

//Intrestcalculation ic = new();
//ic.SimpleInterest();

//Circle c = new();
//c.Radius2PerimeterArea();

//NumberComparision b = new();
//b.Findgreater();

//
// Finding simple interest who is getting more interest amount|

SimpleInterest raghu = new();
raghu.PrincipalAmount = 500000;
raghu.InterestPercentage = 30M;
raghu.YearOfInvestment = 5;
raghu.CalculateSimpleInterest();


SimpleInterest shiva = new();
shiva.PrincipalAmount = 400000;
shiva.InterestPercentage = 38.2M;
shiva.YearOfInvestment = 4;
shiva.CalculateSimpleInterest();

string res = $"Raghu Simple interest is {raghu.SimpleInterestAmount:0.00}";
Console.WriteLine(res);
res = $"Shiva Simple interest is {shiva.SimpleInterestAmount:0.00}";
Console.WriteLine(res);

if (raghu.SimpleInterestAmount > shiva.SimpleInterestAmount)
{
    Console.WriteLine("Raghu is yearning more");
}
else
{
    Console.WriteLine("Shiiva is yearning more");

}