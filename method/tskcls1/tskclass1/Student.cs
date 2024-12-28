namespace tskclass1
{
     class Student
    {
        public string Name;
        public string Surname;
        public Grade[] Grades;
        public Student(string name,string surname, Grade[] grades)
        {
            Name = name;
            Surname = surname;
            Grades = grades;
        }
        public  void GetAvgrageGrate()
        {
            int total = 0;
            for (int i = 0; i < Grades.Length; i++)
            {
                total += Grades[i].Point;
                Console.WriteLine(Grades[i].Point);
                Console.WriteLine("--------------------------------------");
                Console.WriteLine(total);
            }
        }
        public  void GetCreditCount()
        {
            for (int i = 0; i < Grades.Length; i++)
            {
                int total= 0;
                total += Grades[i].CreditCount;
                Console.WriteLine(total);
            }
        }

    }
}
