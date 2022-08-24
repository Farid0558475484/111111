using System;
namespace avgust
{
    public class Teacher : Person
    {
        public double _salary;

        public double Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value > 0)
                {
                    _salary=value;
                }
            }
        }
        public Teacher(int Id, string Name, string SurName, int Age) : base(Id, Name, SurName, Age)
        {

            Salary = _salary;
        }


        public override string  ShowInfo()
        {
            return ("Id:"+Id + "Name:"+Name + "Surname:"+SurName +"Age:" +Age + "Salary:"+Salary);
        }
        public static bool operator >(Teacher str1, Teacher str2)
        {
            return str1.Salary > str2.Salary;
        }


        public static bool operator <(Teacher str1, Teacher str2)
        {
            return str1.Salary < str2.Salary;
        }
    }
}



    


    
