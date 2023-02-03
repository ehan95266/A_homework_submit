using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using elva_custom_class;

namespace hwk6OOP
{
    class Program
    {     //method or function
        static void Main(string[] args)
        {

            var seven = new Dog("seven", "golden", 3, "gold", "dog");
            Console.WriteLine(seven.showPetType());
            seven.showBreed();
            Console.WriteLine(seven.howOldInHuman(3));
            Console.WriteLine(seven.howOldInHuman(3.5));


        }

    }
}