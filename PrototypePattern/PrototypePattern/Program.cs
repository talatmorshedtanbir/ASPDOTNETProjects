using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Email email1 = new Email();
            email1.Username = "Tanbir";

            Email email2 = (Email)email1.Clone();
            Email email3 = (Email)email1.Clone();

            email2.Username = "Talat";

            Console.WriteLine($"{email1.Username} {email2.Username} {email3.Username}");
        }
    }
}
