using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextSpeaker.Model
{
    public interface ICounter : INotifyPropertyChanged
    {
        int Value { get; }

        void CountUp();
    }
}
