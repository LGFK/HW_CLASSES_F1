namespace Prop_CW_CS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Team _mercedes = new Team("Mercedes");
                Team team2 = new Team("HaasF1 Team");
                Team team3 = new Team("Williams");
                Team team4 = new Team("Red Bull Racing");
                Team team5 = new Team("McLaren");
                Team team6 = new Team("Astron Martin");
                Team team7 = new Team("Alpine");
                Team team8 = new Team("Alfa Romeo");
                Team team9 = new Team("Ferrari");
                Team team10 = new Team("Alpha Tauri");
                Pilot pilot1 = new Pilot("Loius Hamilton", 27, _mercedes);
                Pilot pilot2 = new Pilot("George Russel", 27, _mercedes);
                Pilot pilot3 = new Pilot("Kevin Magnussen", 27, team2);
                Pilot pilot4 = new Pilot("Michel Schumacher", 27, team2);
                Pilot pilot5 = new Pilot("Alexander Elbon", 27, team3);
                Pilot pilot6 = new Pilot("Nicola Latifi", 27, team3);
                Pilot pilot7 = new Pilot("Sarhio Perres", 27, team4);
                Pilot pilot8 = new Pilot("Max Ferstappen", 27, team4);
                Pilot pilot9 = new Pilot("Daniel Ricardo", 27, team5);
                Pilot pilot10 = new Pilot("Lando Norrids", 27, team5);
                Pilot pilot11 = new Pilot("Sebastian Fettel", 27, team6);
                Pilot pilot12 = new Pilot("Lence Stroll", 27, team6);
                Pilot pilot13 = new Pilot("Fernando Alionco", 27, team7);
                Pilot pilot14 = new Pilot("Esteban Occon", 27, team7);
                Pilot pilot15 = new Pilot("Guaniun Chzhou", 27, team8);
                Pilot pilot16 = new Pilot("Valterri Bottas", 27, team8);
                Pilot pilot17 = new Pilot("Carlos Sains", 27, team9);
                Pilot pilot18 = new Pilot("Sharl Lecler", 27, team9);
                Pilot pilot19 = new Pilot("Yuki Tsunoda", 27, team10);
                Pilot pilot20 = new Pilot("Pier Gasli", 27, team10);
                _mercedes.Pilot1 = pilot1;
                _mercedes.Pilot2 = pilot2;
                team2.Pilot1 = pilot3;
                team2.Pilot2 = pilot4;
                team3.Pilot1 = pilot5;
                team3.Pilot2 = pilot6;
                team4.Pilot1 = pilot7;
                team4.Pilot2 = pilot8;
                team5.Pilot1 = pilot9;
                team5.Pilot2 = pilot10;
                team6.Pilot1 = pilot11;
                team6.Pilot2 = pilot12;
                team7.Pilot1 = pilot13;
                team7.Pilot2 = pilot14;
                team8.Pilot1 = pilot15;
                team8.Pilot2 = pilot16;
                team9.Pilot1 = pilot17;
                team9.Pilot2 = pilot18;
                team10.Pilot1 = pilot19;
                team10.Pilot2 = pilot20;
                Race race = new Race();
                race.AddTeam(_mercedes);
                race.AddTeam(team2);
                race.AddTeam(team3);
                race.AddTeam(team4);
                race.AddTeam(team5);
                race.AddTeam(team6);
                race.AddTeam(team7);
                race.AddTeam(team8);
                race.AddTeam(team9);
                race.AddTeam(team10);
                for(int i = 0; i < 20; i++)
                    race.Manage_Race();
                Pilot leader = race.GetLeader();
                Console.WriteLine($"Leaders Name :{leader.Name},Points:{leader.GetTotalPoints()}");
                Pilot bypos = race.GetByPos(2);
                Console.WriteLine($"2nd place{bypos.Name},{bypos.GetTotalPoints()}");
                


            }
            catch(IndexOutOfRangeException inofr)
            {
                Console.WriteLine("Index Out of range");
            }
            catch(Exception any) 
            {
                Console.WriteLine("Unidentified exception thrown");
            }
            
        }
    }
}