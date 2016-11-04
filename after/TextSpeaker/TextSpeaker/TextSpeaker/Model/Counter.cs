using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace TextSpeaker.Model
{
    public class Counter : BindableBase, ICounter
    {
        private int _value;

        public int Value
        {
            get { return _value; }
            set { SetProperty(ref _value, value); }
        }
        public void CountUp()
        {
            Value++;
        }
    }
}
