using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorProgram
{
    public class Door
    {
        public Guid Key;
        public bool Open = false;
        public bool Closed = false;
        public bool Locked = false;
        public bool Unlocked = false;
        public Door(Guid Key)
        {
            Key = new Guid();
            Open = false;
            Closed = true;
            Locked = false;
            Unlocked = true;
        }

        public void OpenAndLocked(Guid key)
        {
            key = Key;
            if(Open == true && Locked == true)
            {
                throw new Exception();
            }
            else
            {
                Open = true;
            }
        }
        public void OpenAndUnlocked(Guid key)
        {
            key = Key;
            Unlocked = true;
            Open = true;
        }
        public void ClosedAndLocked(Guid key)
        {
            key = Key;
            Closed = true;
            Locked = true;
        }
        public void ClosedAndUnlocked(Guid key)
        {
            key = Key;
            Closed = true;
            Unlocked = true;
        }

    }
}
