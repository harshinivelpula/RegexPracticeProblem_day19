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

        
            validlastname validLastName = new validlastname();
            Console.WriteLine("enter the name");
            string validlastname = Console.ReadLine();
            bool value2 = validLastName.validatelastname(validlastname);
            if (value2)
            {
                Console.WriteLine("Name is matched");
            }
            else
            {
                Console.WriteLine("Name is not matched");
            }

         
          validemail validEmail3 = new validemail();
           Console.WriteLine("enter the EmailId");
          string validemail = Console.ReadLine();
          bool value3 = validEmail3.validateemail(validemail);
          if (value3)
          {
             Console.WriteLine("Name is matched");
          }
          else
          {
            Console.WriteLine("Name is not matched");
          }

        
            mobileformat mobileFormat = new mobileformat();
            Console.WriteLine("enter the phonenumber");
            string phonenumber = Console.ReadLine();
            bool value4 = mobileFormat.validatemobilenumber(phonenumber);
            if (value4)
            {
                Console.WriteLine("matched");
            }
            else
            {
                Console.WriteLine("not matched");
            }

      
            passwordrule1 passWord = new passwordrule1();
            Console.WriteLine("enter the password");
            string password1 = Console.ReadLine();
            bool value5 = passWord.validatePassWord(password1);
            if (value5)
            {
                Console.WriteLine("matched");
            }
            else
            {
                Console.WriteLine("not matched");
            }

       
          uppercaserule2 password6Rule2 = new uppercaserule2();
          Console.WriteLine("enter the password");
           string password2 = Console.ReadLine();
           bool value6 = password6Rule2.validatePassWord(password2);
           if (value6)
           {
             Console.WriteLine("matched");
           }
           else
           {
             Console.WriteLine("not matched");
           }


           passwordrule3 passwordRule3 = new passwordrule3();
           Console.WriteLine("enter the password");
           string password3 = Console.ReadLine();
            bool value7 = passwordRule3.validatePassWord(password3);
            if (value7)
            {
                Console.WriteLine("matched");
            }
            else
            {
                Console.WriteLine("not matched");
            }

 
           passwordrule4 passwordRule4 = new passwordrule4();
           Console.WriteLine("enter the password");
           string password4 = Console.ReadLine();    
           bool value8 = passwordRule4.validatePassWord(password4);
           if (value8)
           {
               Console.WriteLine("matched");
           }
           else
           {
               Console.WriteLine("not matched");
           }


            emailsamples emailSamples = new emailsamples();
            Console.WriteLine("enter the email");
            string email = Console.ReadLine();
            bool value = emailSamples.validateValidAllEmail(email);
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