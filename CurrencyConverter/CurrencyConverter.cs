Console.Write("Enter amount in SAR: ");
double sar = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter exchange rate from SAR to PHP: ");
double exchangeRate = Convert.ToDouble(Console.ReadLine());
CurrencyConverter(sar, exchangeRate);

void CurrencyConverter(double sar, double er){
    double php = sar * er;
    Console.WriteLine("Amount in PHP: {0:F2}", php);
}