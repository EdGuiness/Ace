using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SleepingBarber
{
    static class RandomMaleName
    {
        static Random random = new Random();
        static List<string> names = new List<string>() { "JACK", "OLIVER", "THOMAS", "HARRY", "JOSHUA", "ALFIE", "CHARLIE", "DANIEL", "JAMES", "WILLIAM", "SAMUEL", "GEORGE", "JOSEPH", "LEWIS", "ETHAN", "MOHAMMED", "DYLAN", "BENJAMIN", "ALEXANDER", "JACOB", "RYAN", "LIAM", "JAKE", "MAX", "LUKE", "TYLER", "CALLUM", "MATTHEW", "JAYDEN", "OSCAR", "ARCHIE", "ADAM", "RILEY", "HARVEY", "HARRISON", "LUCAS", "MUHAMMAD", "HENRY", "ISAAC", "LEO", "CONNOR", "EDWARD", "FINLEY", "LOGAN", "NOAH", "CAMERON", "ALEX", "OWEN", "RHYS", "NATHAN", "JAMIE", "MICHAEL", "MASON", "TOBY", "AARON", "CHARLES", "BEN", "THEO", "LOUIS", "FREDDIE", "FINLAY", "LEON", "HARLEY", "DAVID", "MOHAMMAD", "REECE", "KIAN", "KAI", "KYLE", "BRANDON", "HAYDEN", "ZACHARY", "KIERAN", "LUCA", "ASHTON", "BAILEY", "SEBASTIAN", "GABRIEL", "SAM", "EVAN", "BRADLEY", "ELLIOT", "JOHN", "TAYLOR", "JOE", "COREY", "REUBEN", "JOEL", "ROBERT", "ELLIS", "BLAKE", "AIDAN", "LOUIE", "CHRISTOPHER", "EWAN", "JAY", "MORGAN", "BILLY", "SEAN", "ZAK"};
        public static string Next() {
            return names[random.Next(names.Count)]; // + Guid.NewGuid().ToString().Substring(0,6);
        }
    }
}
