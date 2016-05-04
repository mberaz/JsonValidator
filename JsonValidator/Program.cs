using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonValidator
{
    class Program
    {
        static void Main (string[] args)
        {
            var basePath = @"C:\Users\bigmack\Documents\Visual Studio 2015\Projects\JsonValidator\JsonValidator\Files\";
            var correctPath = basePath + "correct.json";
            var falsePath = basePath + "false.json";


            var isCorrectValid = JsonSchemaValidator.Validate(new UserModel(),ReadFile(correctPath));
            var isFalseValid = JsonSchemaValidator.Validate(new UserModel(),ReadFile(falsePath));
            Console.WriteLine($"correct {isCorrectValid}");
           
            Console.WriteLine($"fasle {isFalseValid}");

            Console.ReadKey();
        }


        public static string ReadFile (string path)
        {
            using(StreamReader sr = new StreamReader(path))
            {
                return sr.ReadToEnd();
            }
        }
    }
}
