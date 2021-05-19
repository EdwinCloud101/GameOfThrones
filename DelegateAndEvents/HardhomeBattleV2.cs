using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfThrones.DelegateAndEvents
{
    public class HardhomeBattleV2
    {
        public event EventsDeclaration.MeetingDelegate HardhomeEldersMeetingEvent;

        public bool ActStarted { get; set; }

        public void StartAct()
        {
            this.ActStarted = true;
            HardhomeEldersMeetingEvent();
        }
    }
}
