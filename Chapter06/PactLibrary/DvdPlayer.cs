using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packt.Shared
{
    public class DvdPlayer : IPlayable
    {
        public void Play()
        {
            WriteLine("DVD is playing");
        }
       public void Pause()
        {
            WriteLine("DVD is stoping");
        }
    }
}
