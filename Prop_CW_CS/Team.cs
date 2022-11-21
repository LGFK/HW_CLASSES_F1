using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Prop_CW_CS
{
    internal class Team
    {
        private string title;
        private Pilot pilot1;
        private Pilot pilot2;
        public Team(string title)
        {
            this.title = title;
        }
       public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public Pilot Pilot1
        {
            get { return pilot1; }
            set
            {
                pilot1 = value;
            }
        }
        public Pilot Pilot2
        {
            get { return pilot2; }
            set
            {
                pilot2 = value;
            }
        }
    }
}
