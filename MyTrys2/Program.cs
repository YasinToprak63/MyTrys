using System;

namespace MyTrys2
{
    class Program
    {
        static void Main(string[] args)
        {

            //öğrenci kayıt bölümü
            Student student1 = new Student();
            student1.FirstName = "Yasin";
            student1.LastName = "Toprak";
            student1.Age = 19;
            student1.SchoolNumber = 1524;

            Student student2 = new Student();
            student2.FirstName = "Ahmet";
            student2.LastName = "Tatmaz";
            student2.Age = 29;
            student2.SchoolNumber = 2548;

            Student student3 = new Student();
            student3.FirstName = "Mehmet";
            student3.LastName = "Kara";
            student3.Age = 15;
            student3.SchoolNumber = 1478;

            Student[] students = new Student[] {student1, student2, student3 };

            foreach (var student in students)
            {
                Console.WriteLine(student.SchoolNumber + " okul numaralı kişisi "  + student.FirstName +" "+ student.LastName + " öğrenci bölümüne kayıt edilidi");
                Console.WriteLine("**********************************************************************");
            }
            Console.WriteLine("//////////////////////////////////////////////////////\n" + "/////////////////////////////////////////////////////");
            
            //öğretmen kayıt bölümü

            Teacher teacher1 = new Teacher();
            teacher1.FirstName = "Okan";
            teacher1.LastName = "Demirci";
            teacher1.Branch = "Türkçe";
            teacher1.Age = 37;
            teacher1.Password = 125487;

            Teacher teacher2 = new Teacher();
            teacher2.FirstName = "Salih";
            teacher2.LastName = "Koç";
            teacher2.Branch = "Matematik";
            teacher2.Age = 45;
            teacher2.Password = 789456;

            Teacher teacher3 = new Teacher();
            teacher3.FirstName = "Ayşe";
            teacher3.LastName = "Dal";
            teacher3.Branch = "Kimya";
            teacher3.Age = 29;
            teacher3.Password = 698523;

            Teacher[] teachers = new Teacher[] {teacher1,teacher2,teacher3 };


            foreach (var teacher in teachers)
            {
                Console.WriteLine(teacher.Branch + " Branşlı sayın " + teacher.FirstName + " "+ teacher.LastName +" kişisi öğretmenler bölümüne kayıt edildi ");
                Console.WriteLine("***************************************************************************");
            }
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int SchoolNumber { get; set; }
    }
    class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Branch { get; set; }
        public int Age { get; set; }
        public int Password { get; set; }
    }

}
