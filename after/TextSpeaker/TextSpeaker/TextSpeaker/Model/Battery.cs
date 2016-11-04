using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Battery;
using Plugin.Battery.Abstractions;

namespace TextSpeaker.Model
{
    public class Battery : IBattery
    {
        public event BatteryChangedEventHandler BatteryChanged;

        private readonly IBattery _battery;
        public int RemainingChargePercent => _battery.RemainingChargePercent;
        public BatteryStatus Status => _battery.Status;
        public PowerSource PowerSource => _battery.PowerSource;

        public Battery()
        {
            _battery = CrossBattery.Current;
            _battery.BatteryChanged += (sender, args) =>
            {
                BatteryChanged?.Invoke(this, args);
            };
        }
        public void Dispose()
        {
            _battery.Dispose();
        }
    }
}
