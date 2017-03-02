using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoading
{
    interface IFWCharacter
    {
        Char getCharacter(); // intrinsic state

        void print(bool uppercase = false); // extrinsic state to be input
    }
}
