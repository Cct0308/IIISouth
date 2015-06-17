using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    public interface IUiListener
    {
        void moveFirst();
        void moveLeft();
        void moveRight();
        void moveLast();
    }
}
