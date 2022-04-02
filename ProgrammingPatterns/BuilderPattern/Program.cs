using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Builder!");

            var builder = new InvoiceBuilder();
            Invoice invoice = builder.SetDate(new DateTime(2020,1,1))
                .SetInvoiceNumber("A1")
                .SetVendor("Google..")
                .SetVendee("Vendee")
                .SetLineItems(new List<string>() {"Line Item1", "Line Item2"})
                .Build();
            Console.WriteLine(invoice.Vendee);
            Console.WriteLine(invoice.Vendor);
        }
    }
}