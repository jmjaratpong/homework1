class Program{
    static void Main(string[] args){
        Console.WriteLine("Input Name : ");
        var name = Console.ReadLine();
        Console.WriteLine("Input Vat : ");
        var vat = double.Parse(Console.ReadLine());
        Console.WriteLine("Input Store Name : ");
        var storename = Console.ReadLine();
        Console.WriteLine("Input Value : ");
        var value = double.Parse(Console.ReadLine());

        Information information = new Information(name, vat, storename, value);

        information.PrintInformation();

        Console.WriteLine("Input Money Value : ");
        var moneyvalue = Console.ReadLine();

        Information information2 = new Information(moneyvalue);
        information2.ExchangeMoney();
    }
}