using System;
namespace elva_custom_class
{
    abstract class Pet
    {
        public string name { get; set; }
        public string breed { get; set; }
        public int age { get; set; }
        public string color { get; set; }
        public string type { get; set; }

        public Pet(string name, string breed, int age, string color, string type)
        {
            this.name = name;
            this.breed = breed;
            this.age = age;
            this.color = color;
            this.type = type;
        }

        //abstract method
        public abstract void showBreed();
        
        //regular method
        public string showPetType()
        {
            return this.type;
        }

        //regular method
        public int howOldInHuman(int age)
        {
            return age * 7;
        }
    }
}

