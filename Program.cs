using System;
using System.IO;

namespace EmailAddressIsValid
{
    class Program
    {
        public static void Main()
        {
            RegexUtilities util = new RegexUtilities();
            string[] emailAddresses = {
                        "samil_90_@hotmail.com",
                        "ddcommodity@ddcap.co.uk",
                        "recep.@gmail.com",
                        "Operations@richmondcommodities.com",
                        "ddcapdocumentation@ddcap.co.uk"
                  };

            StreamWriter w = new StreamWriter("result.txt");
            foreach (var emailAddress in emailAddresses)
            {
                if (util.IsValidEmail(emailAddress))
                {
                    Console.WriteLine("Valid: {0}", emailAddress);
                    w.WriteLine("Valid: {0}", emailAddress);
                }
                else
                {
                    Console.WriteLine("Invalid: {0}", emailAddress);
                    w.WriteLine("Invalid: {0}", emailAddress);
                }
            }
            w.Close();
            //Console.ReadLine();
        }
    }
}
