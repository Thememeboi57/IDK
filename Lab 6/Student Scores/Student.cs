using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Scores
{
    public class Student
    {
        public string Name { get; set; }
        public List<int> Scores { get; set; }

        public Student()
        {
            Scores = new List<int>();
        }

        public Student(string name)
        {
            Name = name;
            Scores = new List<int>();
        }

        public int GetTotal()
        {
            int total = 0;
            foreach (int score in Scores)
            {
                total += score;
            }
            return total;
        }
        
            
        

        public int GetCount()
            {
                return Scores.Count;
            }
        

        public decimal GetAverage()
            {
                if (Scores.Count == 0)
        {
            return 0;
        }

            return (decimal)GetTotal() / Scores.Count;
        }
        

        public override string ToString()
        {
            return Name;
        }
    }
}
