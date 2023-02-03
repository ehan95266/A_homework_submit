using IPersonService;
namespace Person;

class Program
{
    static void Main(string[] args)
    {
        var studentAmy = new Student("eat","walk","female");
        studentAmy.DoYouEat();
        //Console.WriteLine(studentAmy.StuRoutine("do eat", "dont walk"));
        var instructorjohn = new Instructor("no eat", "walk", "male");
        instructorjohn.DoYouEat();

        //encapsulation
        Student Amy= new Student("eat alot", "walk little", "female");
        Console.WriteLine(Amy.DetailInfo());

        Instructor Sam = new Instructor("eat little", "walk alot", "male");
        Console.WriteLine(Sam.DetailInfo());

        Amy.DoYouWalk(30, 20);
        Sam.DoYouWalk(20, 30);
    }
}

