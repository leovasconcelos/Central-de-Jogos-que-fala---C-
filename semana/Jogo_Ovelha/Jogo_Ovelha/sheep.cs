﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace game
{
    class sheep
    {
        public int x, y,index;
        public Image I;
        public sheep(string path)
        {
            x = 0;
            y = 0;
            I= Image.FromFile(path);
        }
    }
}
