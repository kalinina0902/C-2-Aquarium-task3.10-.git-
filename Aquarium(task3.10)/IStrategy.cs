﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium_task3._10_
{
    interface IStrategy
    {
        void Death();
        void Eating();
        void Move();
        void Reproduction();
    }
}
