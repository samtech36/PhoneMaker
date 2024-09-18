namespace PhoneMaker;

class Program
{
    static void Main(string[] args)
    {
        //phone #1
        Phone myfirstPhone = new Phone();
        myfirstPhone.Brand = "Apple";
        myfirstPhone.Make = "IPhone";
        myfirstPhone.Model = "16";
        myfirstPhone.ISFast = true;



        myfirstPhone.Type();
        myfirstPhone.MakePhone();
        
        
        
        
        //phone #2
        Phone mysecondPhone = new Phone();
        mysecondPhone.Brand = "Samsung";
        mysecondPhone.Make = "Galaxy";
        mysecondPhone.Model = "S24";
        mysecondPhone.ISFast = true;
        
        mysecondPhone.Type();
        mysecondPhone.MakePhone();
        
        
        //phone #3
        Phone mythirdPhone = new Phone();
        mythirdPhone.Brand = "Google";
        mythirdPhone.Make = "Pixel";
        mythirdPhone.Model = "9";
        mysecondPhone.ISFast = true;
        
        mythirdPhone.Type();
        mythirdPhone.MakePhone();
        
        //phone #4
        Phone myfourthPhone = new Phone();
        myfourthPhone.Brand = "Nothing";
        myfourthPhone.Make = "Phone";
        myfourthPhone.Model = "2";
        myfourthPhone.ISFast = true;
        
        
        myfourthPhone.Type();
        myfourthPhone.MakePhone();
    }
}