﻿using System;

namespace GotaSoundIO.IO.Backend.WASAPI.Dmo
{
    [Flags]
    enum DmoInputStatusFlags
    {
        None,
        DMO_INPUT_STATUSF_ACCEPT_DATA	= 0x1
    }
}
