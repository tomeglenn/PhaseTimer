using System.Collections.Generic;

namespace PhaseTimer
{
    public class ApplicationConfiguration
    {
        public bool RepeatOnFinish { get; set; }
        public List<Phase> Phases { get; set; }

        public ApplicationConfiguration()
        {
            Phases = new List<Phase>();
        }
    }
}
