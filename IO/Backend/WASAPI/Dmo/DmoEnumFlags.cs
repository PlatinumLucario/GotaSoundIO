using System;

namespace GotaSoundIO.IO.Backend.WASAPI.Dmo
{
    [Flags]
    enum DmoEnumFlags
    {
        None,
        DMO_ENUMF_INCLUDE_KEYED = 0x00000001
    }
}
