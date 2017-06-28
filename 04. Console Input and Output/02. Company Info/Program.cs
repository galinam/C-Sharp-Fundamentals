using System;
class Program
{
    static void Main()
    {
        string companyName = Console.ReadLine();
        string companyAddress = Console.ReadLine();
        string inputCompPhone = Console.ReadLine();
        string inputCompFax = Console.ReadLine();
        inputCompFax.Trim();
        //long companyFaxTemp;
        //long? companyFax = long.TryParse(inputCompFax, out companyFaxTemp) ? (long?)companyFaxTemp : null;
                
        string companyWebSite = Console.ReadLine();
        string managerFirstName = Console.ReadLine();
        string managerLastName = Console.ReadLine();
        string managerFullName = managerFirstName + " " + managerLastName;
        int managerAge = int.Parse(Console.ReadLine());
        string inputManPhone = Console.ReadLine();
              
        string strCompAddress = "Address: ";
        string strCompPhone = "Tel. ";
        string strCompFax = "Fax: ";
        string strCompWeb = "Web site: ";
        string strMan = "Manager: ";
        string noFax = "(no fax)";

        //Console.WriteLine();
       
        Console.WriteLine("{0}", companyName);
        Console.WriteLine("{0}{1}", strCompAddress, companyAddress);
        Console.WriteLine("{0}{1:000 00 00 000}", strCompPhone, inputCompPhone);
        
        if (inputCompFax.Length > 1)
        {
            Console.WriteLine("{0}{1:000 00 00 000}", strCompFax, inputCompFax);

        }
        else
        {
            Console.WriteLine("{0}{1}", strCompFax, noFax);

        }

        Console.WriteLine("{0}{1}", strCompWeb, companyWebSite);
        Console.WriteLine("{0}{1} (age: {2}, tel. {3:0 000 000})", strMan, managerFullName, managerAge, inputManPhone);
       
    }
}