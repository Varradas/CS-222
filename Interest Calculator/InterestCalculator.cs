Console.Write("Enter Principal amount: ");
double principal = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter rate of interest: ");
double interest = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter time in years: ");
double years = Convert.ToDouble(Console.ReadLine());
InterestCalculator(principal, interest, years);

void InterestCalculator(double p, double i, double y){
    double simpleInterest = (p * i * y) / 100;
    Console.WriteLine("Simple Interest: {0:F2}", simpleInterest);
}