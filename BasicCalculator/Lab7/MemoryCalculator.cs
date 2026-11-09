using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Text;

namespace Lab7
{
    internal class MemoryCalculator : Calculator
    {
        public decimal MemoryValue { get; private set; }

        public bool HasMemory { get; private set; }

        public void MemoryClear()
        {
            MemoryValue = 0;
            HasMemory = false;
        }

        public void MemoryStore()
        {
            MemoryValue = Value;
            HasMemory = true;
        }

        public void MemoryRecall()
        {
            if (HasMemory)
            {
                SetValue(MemoryValue);
            }
        }

        public void MemoryAdd()
        {
            MemoryValue += Value;
            HasMemory = true;
        }
    }
    }
