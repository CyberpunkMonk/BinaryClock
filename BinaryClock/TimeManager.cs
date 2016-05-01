using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryClock {
    public class TimeManager {
        public string Hours {get; set;}
        public string Minutes {get; set;}
        public string Seconds {get;set;}
        public TimeManager() {
            this.Update();
        }
        public void Update() {
            this.Hours=DateTime.Now.TimeOfDay.Hours.ToString();
            this.Minutes=DateTime.Now.TimeOfDay.Minutes.ToString();
            this.Seconds=DateTime.Now.TimeOfDay.Seconds.ToString();
        }
    }
}