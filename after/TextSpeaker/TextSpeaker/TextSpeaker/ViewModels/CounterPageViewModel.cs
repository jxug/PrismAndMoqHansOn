using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using TextSpeaker.Model;

namespace TextSpeaker.ViewModels
{
    public class CounterPageViewModel : BindableBase
    {
        private readonly ICounter _counter;
        private int _value;

        public int Value
        {
            get { return _value; }
            set { SetProperty(ref _value, value); }
        }
        public DelegateCommand CountUpCommand => new DelegateCommand(() => _counter.CountUp());

        public CounterPageViewModel(ICounter counter)
        {
            _counter = counter;
            _counter.PropertyChanged += (sender, args) =>
            {
                if (args.PropertyName == "Value")
                {
                    Value = _counter.Value;
                }
            };
        }
    }
}
