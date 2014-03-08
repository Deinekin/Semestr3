﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerNetwork
{
    /// <summary>
    /// Windows OS
    /// </summary>
    public class Windows : OperationSystem
    {
        /// <summary>
        /// Windows' probability to get infected
        /// </summary>
        /// <returns></returns>
        protected override int GetProbability()
        {
           return 60;
        }
    }
}
