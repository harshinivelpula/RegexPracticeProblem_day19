namespace UserRegistrationProblem19
{
    public class Program
    {
        public static void Main(string[] args)
        {
            validfirstname validFirstName = new validfirstname();
            Console.WriteLine("enter the name");
            string validfirstname = Console.ReadLine();
            bool value1 = validFirstName.validatefirstname(validfirstname);
            if (value1)
            {
                Console.WriteLine("name is matched");
            }
            else
            {
                Console.WriteLine("name is not matched");
            }
        }
    }
}