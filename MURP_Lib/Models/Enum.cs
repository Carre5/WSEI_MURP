using System;
using System.Collections.Generic;
using System.Text;

namespace MURP_Lib.Models
{
    public enum Order_Status { NEW, READY, IN_PROGRESS, RESOLVED };
    public enum Order_Rating { Very_Bad, Bad, Average, Good, Very_Good};

    public enum Car_Status { FREE, BUSY};
}
