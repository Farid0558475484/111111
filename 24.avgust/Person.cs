using System;
namespace avgust
{
    public abstract class Person
    {
        private static int _id;
        public int _Id;
        public string _name;
        public string _surName;
        public int _age;


        public Person(int Id,string Name,string Surname,int Age)
        {
                
        }



        public int Id

        {
            get
            {
                return _id;
            }
        }


        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if(value.Length>0)
                {
                    value = _name;
                }
            }
        }



        public string SurName
        {
            get
            {
                return _surName;
            }
            set
            {
                if( value.Length>0)
                {
                    value = _surName;
                }
            }


        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value>0)
                {
                    value = _age;
                }
            }
        }

        public abstract void ShowInfo();
        

    }
}
