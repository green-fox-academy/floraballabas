
using System;

namespace NameFromEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes an email address as input in the following format: firstName.lastName@exam.com
            //and returns a string that represents the user name in the following format: lastName firstName
            //example: "elek.viz@exam.com" for this input the output should be: "Viz Elek"
            //accents does not matter 
            NameFromEmail();
            Console.ReadLine();
        }
        private static void NameFromEmail()
        {
            Console.WriteLine("Please enter your email address in the following format: firstName.lastName@exam.com");
            string email = Console.ReadLine();
            string user = email.Substring(0, email.IndexOf("@"));

            string firstName = user.Substring(0, user.IndexOf("."));
            firstName = char.ToUpper(firstName[0]) + firstName.Substring(1);

            string lastName = user.Substring(user.IndexOf(".")+1);
            lastName = char.ToUpper(lastName[0]) + lastName.Substring(1);

            Console.WriteLine(lastName +" "+ firstName);

        }
    }
}
