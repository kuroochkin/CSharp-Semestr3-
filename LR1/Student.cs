using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters;

namespace LR1
{
    public class Student
    {
        private Person student;
        private Education formeducation;
        private int NumberGroup;
        private Exam[] exams;

        public Student(Person student, Education formeducation, int numberGroup)
        {
            this.student = student;
            this.formeducation = formeducation;
            this.NumberGroup = numberGroup;
        }
        public Student()
        {
            this.student = new Person();
            this.formeducation = Education.Bachelor;
            this.NumberGroup = 21;
            this.exams = new Exam[0];
        }

        public Person Datastudent
        {
            get { return student; }
            set { student = value; }
        }

        public Education Dataeducation
        {
            get { return formeducation; }
            set { formeducation = value; }
        }

        public int DataGroup
        {
            get { return NumberGroup; }
            set { NumberGroup = value; }
        }

        public Exam[] Dataexams
        {
            get { return exams; }
            set { exams = value; }
        }

        public double Average
        {
            get
            {
                double sum = 0;

                for (int i = 0; i < exams.Length; i++)
                {
                    sum += exams[i].Grade;
                }
                return sum / (exams.Length);
            }
        }

        public bool this[Education index]
        {
            get
            {
                if (this.formeducation == index)
                    return true;
                return false;
            }
        }

        public void AddExams(params Exam[] exam)
        {

            Exam[] exams1 = new Exam[exams.Length + exam.Length];

            for (int i = 0; i < exams.Length; i++)
            {
                exams1[i] = exams[i];
            }
            for (int i = exams.Length; i < exams1.Length - exams.Length; i++)
            {
                exams1[i] = exam[i - exams.Length];
            }
            exams = exams1;
        }

        public override string ToString()
        {
            return string.Format("\nСтудент: {0}\nФорма обучения: {1}\nНомер группы: {2}", student, formeducation, NumberGroup);
        }

        public virtual string ToShortString()
        {
            return string.Format("\nСтудент: {0}\nФорма обучения: {1}\nНомер группы: {2}\nСредний балл: {3}", student, formeducation, NumberGroup, Average);
        }
    }
}