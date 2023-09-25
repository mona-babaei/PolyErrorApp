using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace PolyErrorApp
{

    class Program
    {
        static void Main(string[] args)
        {

            List<UserError> errors = new List<UserError>
        {
            new NumericInputError() ,
            new TextInputError()
                //error massage 

            };
            foreach (var error in errors)
            {
                Console.WriteLine(error.UEMessage());
                Console.ReadLine();
            }
        }



    }

}