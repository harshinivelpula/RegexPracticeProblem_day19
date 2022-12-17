namespace UserRegistrationProblem19
{
    public class Program
    {
        //public static void Main(string[] args)
        //{
        //    validfirstname validFirstName = new validfirstname();
        //    Console.WriteLine("enter the name");
        //    string validfirstname = Console.ReadLine();
        //    bool value1 = validFirstName.validatefirstname(validfirstname);
        //    if (value1)
        //    {
        //        Console.WriteLine("name is matched");
        //    }
        //    else
        //    {
        //        Console.WriteLine("name is not matched");
        //    }
        //}
        //public static void Main(string[] args)
        //{
        //    validlastname validLastName = new validlastname();
        //    Console.WriteLine("please enter the name");

        //    string validlastname = Console.ReadLine();

        //    bool value = validLastName.validatelastname(validlastname);
        //    if (value)
        //    {
        //        Console.WriteLine("Name is matched");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Name is not matched");
        //    }
        //}
        //public static void Main(string[] args)
        //{
        //    validemail validEmail3 = new validemail();
        //    Console.WriteLine("enter the EmailId");

        //    string validemail = Console.ReadLine();

        //    bool value3 = validEmail3.validateemail(validemail);
        //    if (value3)
        //    {
        //        Console.WriteLine("Name is matched");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Name is not matched");
        //    }
        //}
        //public static void Main(string[] args)
        //{
        //    mobileformat mobileFormat = new mobileformat();
        //    Console.WriteLine("enter the phonenumber");

        //    string phonenumber = Console.ReadLine();

        //    bool value = mobileFormat.validatemobilenumber(phonenumber);
        //    if (value)
        //    {
        //        Console.WriteLine("matched");
        //    }
        //    else
        //    {
        //        Console.WriteLine("not matched");
        //    }
        //}
        //public static void Main(string[] args)
        //{
        //    passwordrule1 passWord = new passwordrule1();
        //    Console.WriteLine("enter the password");

        //    string password = Console.ReadLine();

        //    bool value = passWord.validatePassWord(password);
        //    if (value)
        //    {
        //        Console.WriteLine("matched");
        //    }
        //    else
        //    {
        //        Console.WriteLine("not matched");
        //    }
        //}
        //public static void Main(string[] args)
        //{
        //    uppercaserule2 password6Rule2 = new uppercaserule2();
        //    Console.WriteLine("enter the password");

        //    string password = Console.ReadLine();

        //    bool value = password6Rule2.validatePassWord(password);
        //    if (value)
        //    {
        //        Console.WriteLine("matched");
        //    }
        //    else
        //    {
        //        Console.WriteLine("not matched");
        //    }
        //}
        public static void Main(string[] args)
        {
            passwordrule3 passwordRule3 = new passwordrule3();
            Console.WriteLine("enter the password");

            string password = Console.ReadLine();

            bool value = passwordRule3.validatePassWord(password);
            if (value)
            {
                Console.WriteLine("matched");
            }
            else
            {
                Console.WriteLine("not matched");
            }
        }
    }
}