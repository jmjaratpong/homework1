using System.Globalization;

public class Information{
    string name;
    double vat;
    string storeName;
    double value; 
    string moneyValue;

    int thousand, fiveHundred, oneHundred, fifthy, twenty, ten, two, one, pointfifty, pointtwentyfive;

    public Information(string moneyvalue){
        this.moneyValue = moneyvalue;
    }

    public Information(string name, double vat, string storename, double value){
        this.name = name;
        this.vat = vat;
        this.storeName = storename;
        this.value = value;
    }

    public void PrintInformation(){
        Console.WriteLine("**********************************");
        Console.WriteLine($"Name = {name}");
        Console.WriteLine($"vat = {vat}");
        Console.WriteLine($"Store Name = {storeName}");
        Console.WriteLine($"Store Value = {value}");
        Console.WriteLine("**********************************");
    }

    public void ExchangeMoney(){
        if(moneyValue == "."){
            string[] partstring = moneyValue.Split('.');
            int intergerpart = CheckTypeInterger(partstring[0]);
            int decemalpart = CheckTypeDecemal(partstring[1]);
            if(SpecialDecimal(decemalpart)) decemalpart *= 100;
            if(CheckInteger(intergerpart) && CheckDecimal(decemalpart) && SpecialDecimal(decemalpart)) throw new Exception("Wrong!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            else {
                Calculater(intergerpart, decemalpart);
                PrintCalculator();
            }
        }
        else{
            if(CheckInteger(CheckTypeInterger(moneyValue))) throw new Exception("Wrong!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            else {
                Calculater(CheckTypeInterger(moneyValue));
                PrintCalculator();
            }
        }
    }

    public int ChangeTypeInt(string intergerpart){
        if(int.TryParse(intergerpart, out int num)){
            return num;
        }
        else{
            throw new Exception("Not Interger");
        }
    }

    public int CheckTypeInterger(string intergerpart){
        if(int.TryParse(intergerpart, out int num)){
            return num;
        }
        else{
            throw new Exception("Not Interger");
        }
    }

    public int CheckTypeDecemal(string decemalpart){
        if(int.TryParse(decemalpart, out int num)){
            return num;
        }
        else{
            throw new Exception("Not Decemal");
        }
    }

    public bool CheckInteger(int intergerpart){
        if(intergerpart > 0){
            return false;
        }
        
        return true;
    }

    public bool CheckDecimal(int decimalpart){
        if(decimalpart >= 25 && decimalpart != 50 && decimalpart <= 75){
            return false;
        }
        
        return true;
    }

    public bool SpecialDecimal(int decimalpart){
        if(decimalpart >= 1 && decimalpart <= 9){
            return true;
        }
        return false;
    }

    public void Calculater(int intergerpart){
        thousand = intergerpart / 1000;
        intergerpart %= 1000;
        fiveHundred = intergerpart / 500;
        intergerpart %= 500;
        oneHundred = intergerpart / 100;
        intergerpart %= 100;
        fifthy = intergerpart / 50;
        intergerpart %= 50;
        twenty = intergerpart / 20;
        intergerpart %= 20;
        ten = intergerpart / 10;
        intergerpart %= 10;
        two = intergerpart / 2;
        intergerpart %= 2;
        one = intergerpart / 1;
        intergerpart %= 1;
        pointfifty = intergerpart / 50;
        intergerpart %= 50;
        pointtwentyfive = intergerpart / 25;
        intergerpart %= 25;
    }
    public void Calculater(int intergerpart, int decimalpart){
        thousand = intergerpart / 1000;
        intergerpart %= 1000;
        fiveHundred = intergerpart / 500;
        intergerpart %= 500;
        oneHundred = intergerpart / 100;
        intergerpart %= 100;
        fifthy = intergerpart / 50;
        intergerpart %= 50;
        twenty = intergerpart / 20;
        intergerpart %= 20;
        ten = intergerpart / 10;
        intergerpart %= 10;
        two = intergerpart / 2;
        intergerpart %= 2;
        one = intergerpart / 1;
        intergerpart %= 1;
        pointfifty = decimalpart / 50;
        decimalpart %= 50;
        pointtwentyfive = decimalpart / 25;
        decimalpart %= 25;
    }

    public void PrintCalculator(){
        Console.WriteLine("1000 : " + thousand + "\n" + 
        "500 : " + fiveHundred + "\n" + 
        "100 : " + oneHundred + "\n" + 
        "50 : " + fifthy + "\n" + 
        "20 : " + twenty + "\n" + 
        "10 : " + ten + "\n" +  
        "2 : " + two + "\n" + 
        "1 : " + one + "\n" +  
        ".50 : " + pointfifty + "\n" +  
        ".25 : " + pointtwentyfive);
    }

    public string Name{
        get{ return name;}
        set {name = value;}
    }
    public double Vat{
        get{ return vat;}
        set {vat = value;}
    }
    public string StoreName{
        get{ return storeName;}
        set {storeName = value;}
    }
    public double Value{
        get{ return value;}
        set {this.value = value;}
    }
}