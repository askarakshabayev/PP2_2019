using System;

namespace Ex7
{
    class Student
    {
        public string name;
        public string surname;
        public double gpa;

        public Student(double gpa, string name, string surname)
        {
            this.name = name;
            this.surname = surname;
            this.gpa = gpa;
        }

        public Student(string name, string surname, double gpa) {
            this.name = name;
            this.surname = surname;
            this.gpa = gpa;
        }

        public Student() { }

        public Student(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        //public void Init(string name, string surname, double gpa)
        //{
        //    this.name = name;
        //    this.surname = surname;
        //    this.gpa = gpa;
        //}
        public void Print()
        {
            Console.WriteLine(this.name + " " + surname + " " + gpa);
        }

        public void Print(int k)
        {

        }

        public override string ToString()
        {
            return name + " " + surname + " " + gpa;
        }

    }

    class Program
    {
        static void F1()
        {
            Student st1 = new Student();
            st1.name = "Askar";
            st1.surname = "Akshabayev";
            st1.gpa = 2.0;

            Student st2 = new Student();
            //st2.Init("aaa", "bbb", 3.0);

            st1.Print();
            st2.Print();

        }
        static void F2()
        {
            int n = int.Parse(Console.ReadLine());
            Student[] a = new Student[n];
            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split();
                string name = arr[0];
                string surname = arr[1];
                double gpa = double.Parse(arr[2]);
                a[i] = new Student(name, surname, gpa);
            }

            //for (int i = 0; i < n; i++)
            //a[i].Print();
            for (int i = 0; i < n; i++)
                Console.WriteLine(a[i]);
        }

        static void F3()
        {
            Student st1 = new Student();
            st1.name = "aaa";
            st1.surname = "bbb";
            st1.gpa = 2.2;

            Student st2 = new Student("ccc", "ddd");
            st2.gpa = 2.5;

            Student st3 = new Student("qqq", "www", 3.0);
        }
        static void Main(string[] args)
        {
            F2();
        }
    }
}
