using System.Runtime.InteropServices;
using GotaSoundIO.IO.Backend.WASAPI.CoreAudioApi.Interfaces;

namespace GotaSoundIO.IO.Backend.WASAPI.CoreAudioApi
{
    internal class AudioSessionNotification : IAudioSessionNotification
    {
        private AudioSessionManager parent;

        internal AudioSessionNotification(AudioSessionManager parent)
        {
            this.parent = parent;
        }

        [PreserveSig]
        public int OnSessionCreated(IAudioSessionControl newSession)
        {
            parent.FireSessionCreated(newSession);
            return 0;
        }
    }
}
