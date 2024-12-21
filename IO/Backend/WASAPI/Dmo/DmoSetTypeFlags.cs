using System;

namespace GotaSoundIO.IO.Backend.WASAPI.Dmo
{
    [Flags]
    enum DmoSetTypeFlags
    {
        None,
        DMO_SET_TYPEF_TEST_ONLY = 0x00000001,
        DMO_SET_TYPEF_CLEAR = 0x00000002
    }
}
