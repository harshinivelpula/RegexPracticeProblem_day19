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
        public static void Main(string[] args)
        {
            validlastname validLastName = new validlastname();
            Console.WriteLine("please enter the name");

            string validlastname = Console.ReadLine();

            bool value = validLastName.validatelastname(validlastname);
            if (value)
            {
                Console.WriteLine("Name is matched");
            }
            else
            {
                Console.WriteLine("Name is not matched");
            }
        }
    }
}