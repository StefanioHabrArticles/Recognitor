using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoapp
{
    public interface IView
    {
        double[] InputPixels{ get; set; }
        double[] NetOutput { set; }
        event EventHandler<EventArgs> GotResult;
    }
}
