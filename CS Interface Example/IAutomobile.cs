﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Interface_Example
{
    interface IAutomobile
    {
        string LicensePlate {get;}
        double Speed {get;}
        int Wheels {get;}
        void Honk();
    }
}
