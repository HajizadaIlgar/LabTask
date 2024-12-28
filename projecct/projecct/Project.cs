namespace projecct
{
    public class Project
    {
        public int Id;
        public Employees[] Employees;
        public DateTime StartTime;
        public DateTime DeedLine;
        public bool IsSuccesfull;
        public void AssignEmployee(Employees[] employees)
        {
            Employees = employees;

        }
        public void RemoveEmployee(Employees employees, int Id)
        {
            for (int i = 0; i < Employees.Length; i++)
            {
                if (Employees[i].Id == Id)
                {
                    Employees[i] = null;
                }
            }
        }
        public void Finish(DateTime starttime, DateTime deedtime)
        {
            DateTime thisDay=DateTime.Today;
            StartTime = starttime;
            DeedLine = deedtime;
            IsSuccesfull = true;
            if (thisDay>starttime && thisDay<deedtime)
            {
                Console.WriteLine(IsSuccesfull);
            }
            else
            {
                Console.WriteLine(IsSuccesfull);
            }
        }
        public void Print(int id, Employees[] employees, DateTime starttime, DateTime deedtime, bool issuccesful)
        {
            Id = id;
            Employees = employees;
            StartTime = starttime;
            DeedLine = deedtime;
            IsSuccesfull = issuccesful;
        }

    }
    public class Employees
    {

        public int Id;
        public float FullTime;
        public Project[] project;

        public void Leave(int id, float fulltime, Project[] project)
        {
            Id = id;
            FullTime = fulltime;
            this.project = project;
        }
    }



}

