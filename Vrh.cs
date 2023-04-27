using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppHome
{
    internal class Vrh:Fyzika
    {
        public override void calculateF()
        {

            Fx = 0;
            Fy = m * ag;
        }

    }
}
