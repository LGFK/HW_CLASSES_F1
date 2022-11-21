using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prop_CW_CS
{
    internal class Race
    {
        Team[]teams=new Team[10];
        int _raceNum = 0;
        private Pilot[] GetLeadeboard()
        {
            Pilot[] LeaderBoard = new Pilot[20];
            int counter = 0;
            for (int i = 0; i < teams.Length; i++)
            {
                LeaderBoard[counter++] = teams[i].Pilot1;
                LeaderBoard[counter++] = teams[i].Pilot2;
            }
            for (int i = 0; i < LeaderBoard.Length; i++)
            {
                for (int j = 0; j < LeaderBoard.Length - 1; j++)
                {
                    if (LeaderBoard[j].GetTotalPoints() > LeaderBoard[j + 1].GetTotalPoints())
                    {
                        Pilot tmp = LeaderBoard[j];
                        LeaderBoard[j] = LeaderBoard[j + 1];
                        LeaderBoard[j + 1] = tmp;
                    }
                }
            }
            foreach (var t in LeaderBoard)
                Console.WriteLine(t.GetTotalPoints());
            return LeaderBoard;
        }
        
        public void AddTeam(Team obj)
        {
            for(int i=0;i<teams.Length;i++)
            {
                if (teams[i] == null)
                {
                    
                    teams[i] = obj;
                    break;
                }
            }
        }
        public int Race_num
        {
            get { return _raceNum; }
            set { _raceNum = value; }
        }
        public Pilot GetLeader()
        {
            return GetLeadeboard()[GetLeadeboard().Length-1];
        }
        public Pilot GetByPos(int pos)
        {
            if(pos > teams.Length)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                return GetLeadeboard()[GetLeadeboard().Length-pos];
            }
                
        }
        public double GetAvg(Pilot pil)
        {
            return pil.GetTotalPoints() / _raceNum;
        }
        public double GetPoints(Pilot pil)
        {
            return pil.GetTotalPoints();
        }
        public void Manage_Race()
        {
            if(Race_num > 19)
            {
                throw new IndexOutOfRangeException();
            }
            Random random = new Random();
            int[] arr = new int[8];
            for(int i=7;i>=0;i--)
            {
                arr[i] = i+1;
            }
            int counter = 0;
            int team;
            do
            {
                int pil=random.Next();
                team = random.Next(0, 10);
                if (pil % 2==0)
                {
                    if (teams[team].Pilot1.Points[_raceNum] == 0)
                    {
                        
                        teams[team].Pilot1.Points[_raceNum] = arr[counter++];
                    }
                    else
                    {
                       
                    }
                }
               else
               {
                    if (teams[team].Pilot2.Points[_raceNum] == 0)
                    {
                        teams[team].Pilot2.Points[_raceNum] = arr[counter++];
                    }
                    else
                    {
                        
                    }
                }


            } while (counter < 8);
            Race_num++;
        }
    }
}
