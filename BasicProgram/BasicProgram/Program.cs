

using BasicProgram;

Console.WriteLine("Basic Programs");
while (true)
{   
    Console.WriteLine("Enter the option to perform the operation \n1) FlipCoin ");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            FlipCoin.FlipCoinMethod();
            break;
        case 2:
            LeapYear.CheckingLeapYear();
            break;
       
    }
}
