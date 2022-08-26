using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Methods1
{
    class Movie
    {
        string movieName;
        int releaseYr;

        actor actorName;

        static void Main(string[] args)
        {
            Movie m = new Movie();
            m.movieName = "MI-FallOut";
            m.releaseYr = 2018;

            actor ac = new actor("Tom Cruise",56);
            m.actorName = ac;

            Console.WriteLine("Movie Name is "+m.movieName);
            Console.WriteLine("Mpvie Year is "+m.releaseYr);

            Console.WriteLine("Actor Name is "+m.actorName.Actor);
            Console.WriteLine("Actor Age is "+m.actorName.ActorAge);
        }


    }

    class actor
    {
        string actorName;
        int actorAge;

        public string Actor
            {
            set { actorName = value; }
            get { return actorName; }
            }

        public int ActorAge
          {
            set { actorAge = value; }
            get { return actorAge; }
        }


        public actor(string actorName,int actorAge)
        {
            this.actorName = actorName;
            this.actorAge = actorAge;
        }

    
    }

}
