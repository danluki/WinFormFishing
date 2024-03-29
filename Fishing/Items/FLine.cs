﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fishing
{
    class FLine : Item
    {
        public static FLine twokgMono = new FLine("Монка 2кг", 2000, 500, Resource1.INDIANA);
        public int LeskaPower;
        public FLine(string name, int power, int price, Bitmap pic) : base(name, price, pic)
        {
            LeskaPower = power;
        }
        public static FLine Indiana1500 = new FLine("Indiana 1500", 1500, 500, Resource1.INDIANA);
        public static FLine Quest_Fishers = new FLine("Quest_fishers 90000", 90000, 200000, Resource1.QUEST_FISHERS);
        public static FLine Colorado = new FLine("Colorado 30000", 30000, 100000, Resource1.COLORADO);
        public override string ToString()
        {
            return this.Name;
        }
    }
}
