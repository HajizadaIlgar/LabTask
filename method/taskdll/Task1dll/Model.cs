namespace Model
{
    public class Manager
    {
        public Employee GetPromotion(Employee employee)
        {
            employee.Salary += 100;
            return employee;
        }
    }
    public class Employee
    {
        private string _name;
        private bool _isSuccesfull;
        private double _salary;

        public Employee(string name, bool issuccesfull, double salary)
        {
            _name = name;
            _isSuccesfull = issuccesfull;
            _salary = salary;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public bool IsSuccesfull
        {
            get { return _isSuccesfull; }
            set { _isSuccesfull = value; }
        }
        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
    }
    public class Assistant : Manager
    {
        public void GetFeedBack(Employee employe)
        {
            if (true)
            {
                GetPromotion(employe);
            }
        }

    }
}