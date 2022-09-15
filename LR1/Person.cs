using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1
{
    public class Person
    {
        private string name;
        private string surname;
        private DateTime datetime;

        public Person(string name, string surname, DateTime datetime)
        {
            this.name = name;
            this.surname = surname;
            this.datetime = datetime;
        }

        public Person()
        {
            name = "Владислав";
            surname = "Курочкин";
            datetime = new DateTime(2003, 6, 19);
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public DateTime Datetime
        {
            get { return datetime; }
            set { datetime = value; }
        }

        public int GetData
        {
            get
            {
                return Convert.ToInt32(datetime);
            }
            set
            {
                datetime = Convert.ToDateTime(value);
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}\nДата рождения: {2}", name, surname, datetime);
        }

        public virtual string ToShortString()
        {
            return "\n" + "Имя: " + name + "\n" + "Фамилия: " + surname;
        }
    }
}
