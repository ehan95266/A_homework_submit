using System;

namespace elva_custom_class
{
    class Dog : Pet
    {
        public Dog(string name, string breed, int age, string color, string type) : base(name, breed, age, color, type)
        {
        }

        //override from subclass
        public override void showBreed()
        {
            Console.WriteLine("this is override");
        }

        //overload from subclass
        public double howOldInHuman(double age)
        {
            return age * 7;
        }

    }

}