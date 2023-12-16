using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp161
{
    public class Mission : IMissions
    {
        private string missionName;
        private string missionState;

        public Mission(string missionName, string missionState)
        {
            this.missionName = missionName;
            this.missionState = missionState;
        }

        public Mission(string missionName, State state)
        {
            this.missionName = missionName;
            State = state;
        }

        public string CodeName { get; private set; }

        
        public State State { get; private set; }

        public void CompleteMission()
        {
          
           State  = State.Finished;
        }

        public override string ToString()
        {
            return $"Code Name: {CodeName} State: {State}";
        }
    }
}
