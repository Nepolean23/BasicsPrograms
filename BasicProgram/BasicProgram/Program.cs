

using BasicProgram;

Console.WriteLine("Basic Programs");
while (true)
{   
    Console.WriteLine("Enter the option to perform the operation \n1) FlipCoin \n2) LeapYear \n3) HarmonicSeries "+
        "\n4)PowerOfTwo\n5)PrimeFactor\n6)QuotientAndReminder\n7)SwapingTwoNumbers");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            FlipCoin.FlipCoinMethod();
            break;
        case 2:
            LeapYear.CheckingLeapYear();
            break;
        case 3:
            HarmonicSeries.Harmonic();
            break;
        case 4:
            PowerOfTwo.PowerOfBase(); 
            break;
        case 5:
            PrimeFactor.PrimeFactorNumber();
            break;
        case 6:
            QuotientAndReminder.CheckingQuotientAndReminder();
            break;
        case 7:
            SwapTwoNumbers.SwapingNumbers();
            break;
        
             
            
        



       
    }
}
