﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._8_Lock关键字
{
    public class CounterWithLock:CounterBase
    {
        public int Count { get; private set; }

        private readonly object _syncObj = new object();

        public override void Decrease()
        {
            lock (_syncObj)
            {
                Count--;
            }
        }

        public override void Increase()
        {
            lock (_syncObj)
            {
                Count++;
            }
        }
    }
}
