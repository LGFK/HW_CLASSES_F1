using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prop_CW_CS
{
    internal class Pilot
    {
        private string name;
        private int age;
        private Team team;
        private double[] points = new double[20];
        public Pilot(string _name, int _age, Team _team)
        {
            name = _name;
            age = _age;
            team = _team;
        }
        public double GetTotalPoints()
        {
            double res = 0;
            for(int i=0;i<points.Length;i++)
            {
                res+= points[i];
            }
            return res;
        }
        public string Name
        {
            get
            {
                return name;
            }
           
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get => age;
            set => age = value;
        }
        public Team Team
        {
            get => team;
            set => team = value;
        }
        public double[] Points
        {
            get => points;
        }
        public void SetPoints(double p,int pos)
        {
            points[pos] = p;
        }
    }
}
