using System;
using System.Collections.Generic;

namespace UrlsFromHandles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes a list of GitHub handles as input and returns a list of strings that represents
            // GitHub url's under Green Fox Academy organization in the following format: "https://github.com/greenfox-academy/teststudent"

            // example:
            // input: ["ghhandle1", "ghhandle2"]
            // output: ["https://github.com/greenfox-academy/ghhandle1", "https://github.com/greenfox-academy/ghhandle2"]
           
            gitHubUrls();
            Console.ReadLine();

        }
        private static void gitHubUrls()
        {
            Console.WriteLine("Please tell me how many github handles you are going to give me");
            int handleNumber = int.Parse(Console.ReadLine());
            List<string> handleList = new List<string> { };

            for (int i = 0; i < handleNumber; i++)
            {
                Console.WriteLine("Tell me the github handle");
                string handle = Console.ReadLine();
                handleList.Add("https://github.com/greenfox-academy/"+handle);
            }
           
            Console.Write("Here is the github url for them: ");
            foreach (var gitHubUrl in handleList)
            {
                Console.Write(gitHubUrl+", ");
            }
        }
    }
}
