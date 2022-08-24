using System;
namespace avgust
{
    public class Student : Person
    {
        public float _point;

        public float Point
        {
            get
            {
                return _point;
            }
            set
            {
                if (value>0)
                {
                    value = _point;
                }
            }
        }

        public Student(int Id, string Name, string SurName, int Age) : base(Id, Name, SurName, Age)
        {

            Point = _point;
            Id = _Id;
            Name = _name;
            SurName = _surName;
            Age = _age;
        }


      
        public override void ShowInfo()
        {
            Console.WriteLine ("Name:" + Name + "Surname:" + SurName + "Age:" + Age);
        }
    

        public static bool operator > (Student str1,Student str2)
        {
            return str1.Point > str2.Point;
        }


        public static bool operator <(Student str1, Student str2)
        {
            return str1.Point <str2.Point;
        }
    }

    }

