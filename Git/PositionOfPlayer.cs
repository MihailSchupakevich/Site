﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git
{
    internal class PositionOfPlayer
    {
        int PositionId;
        int PlayerId;
        public void setAll(int PositionId, int PlayerId)
        { 
        this.PositionId = PositionId;
            this.PlayerId = PlayerId;
                }
    }
}
