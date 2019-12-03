using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmaiilRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] emailAddresses = { "david.jones@proseware.com", "d.j@server1.proseware.com",
                                    "jones@ms1.proseware.com", "j.@server1.proseware.com",
                                    "j@proseware.com9", "js#internal@proseware.com",
                                    "j_9@[129.126.118.1]", "j..s@proseware.com",
                                    "js*@proseware.com", "js@proseware..com",
                                    "js@proseware.com9", "j.s@server1.proseware.com",
                                    "\"j\\\"s\\\"\"@proseware.com", "js@contoso.中国" };

            foreach (var email in emailAddresses)
            {
                string key=@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
                string key2 = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
                Regex regex = new Regex(key2);
                Match match = regex.Match(email);
                if (match.Success)
                    Console.WriteLine(email + " is correct");
                else
                    Console.WriteLine(email + " is incorrect");
            }
           

            Console.ReadLine();
        }
    }
}
