using System;

namespace people
{
    class Program
    {
        static void Main(string[] args)
        {
            //custom casting
            Student student = new Student("Somaia Mostafa", 20_000);
            Console.WriteLine($"student object: {student}");
            Person person = (Person)student;
            Console.WriteLine($"after casting to Person: {person}");
            Student student1 = (Student)person;
            Console.WriteLine($"recasting to student again: {student1}");
        }
    }
}
