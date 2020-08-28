using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Z13_DI
{
    public interface IControlGenerator
    {
        FrameworkElement Generate();
    }
}
