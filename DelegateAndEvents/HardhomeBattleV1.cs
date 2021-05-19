using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfThrones.DelegateAndEvents
{
    public class HardhomeBattleV1
    {
        public EventsDeclaration.MeetingDelegate HardhomeEldersMeetingDelegate;

        public bool ActStarted { get; set; }

        public void StartAct()
        {
            this.ActStarted = true;
            HardhomeEldersMeetingDelegate();
        }
    }
}
