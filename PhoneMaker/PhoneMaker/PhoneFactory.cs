using System;
using System.Collections.Generic;
using System.IO.Compression;


namespace PhoneMaker;

public class PhoneFactory
{

    public static int numberofphones;
    
    public List <Phone> PhoneList { get; set; } = new List<Phone>();


    public void PrintPhoneList()
    {
        Console.WriteLine("The phones I created in my factory: ");

        foreach (var phone in PhoneList)
        {
            Console.WriteLine($" {phone.Brand} {phone.Make} {phone.Model}");
        }
        
        
    }
    

}