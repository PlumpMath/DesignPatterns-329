using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public interface Observer
    {
        void Update(float Temperature , float Humidity , float Pressure);
    }
}
