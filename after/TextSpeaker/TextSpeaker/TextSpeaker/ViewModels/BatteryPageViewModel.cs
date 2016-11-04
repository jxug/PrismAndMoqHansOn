using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Plugin.Battery.Abstractions;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using TextSpeaker.Model;

namespace TextSpeaker.ViewModels
{
    public class BatteryPageViewModel : BindableBase
    {
        /// <summary>
        /// 本来はちゃんと終了処理をすること。
        /// </summary>
        private readonly IBattery _battery;

        private BatteryStatus _status;

        public BatteryStatus Status
        {
            get { return _status; }
            set { SetProperty(ref _status, value); }
        }

        private int _remainingChargePercent;

        public int RemainingChargePercent
        {
            get { return _remainingChargePercent; }
            set { SetProperty(ref _remainingChargePercent, value); }
        }
        public BatteryPageViewModel(IBattery battery)
        {
            _battery = battery;
            Status = _battery.Status;
            RemainingChargePercent = _battery.RemainingChargePercent;
            _battery.BatteryChanged += (sender, args) =>
            {
                Status = args.Status;
                RemainingChargePercent = args.RemainingChargePercent;
            };
        }
    }
}
