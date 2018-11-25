using System;
using System.Collections.Generic;
using System.Text;

namespace IceDog.Xamarin.Phoneword
{
    public interface IDialer
    {
        bool Dial(string number);
    }
}
