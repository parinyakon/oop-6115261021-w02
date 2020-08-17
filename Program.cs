using System;

namespace oop_6115261021_w02
{
    class Program
    {
        static void Main(string[] args)
        {
            Room r433 = new Room();
            Room r434 = new Room("434", "434", 4, 4, "Computer");
            Building b1 = new Building("1", "Building 1", "2222", "3333");
            Subject sj1 = new Subject("611526", "Subject 1", "3", "5", "10");
            Lecturer l1 = new Lecturer("Parinyakon", "Butbankheoa", "Lecturer");
            Section s1 = new Section("434", "1", "611526", "Parinyakon", "Monday", "8.00", "11.30");
            StudyGroup sg1 = new StudyGroup("1", "bachelor");

            Console.WriteLine(r433);
            Console.WriteLine(r434);
            Console.WriteLine(b1);
            Console.WriteLine(sj1);
            Console.WriteLine(l1);
            Console.WriteLine(s1);
            Console.WriteLine(sg1);

            Console.WriteLine("Hello World!");

        }

    }
}