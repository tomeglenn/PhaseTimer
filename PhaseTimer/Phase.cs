using System;

namespace PhaseTimer
{
    public class Phase
    {
        public string Name { get; set; }
        public TimeSpan Time { get; set; }
        public TimeSpan TimeRemaining { get; set; }

        public Phase(string name, TimeSpan time)
        {
            Name = name;
            Time = time;
            TimeRemaining = time;
        }

        public void Reset()
        {
            TimeRemaining = Time;
        }
    }
}
