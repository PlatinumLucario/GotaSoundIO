using System;
using System.Linq;
using System.Runtime.InteropServices;
using GotaSoundIO.IO.Backend.WASAPI.CoreAudioApi.Interfaces;

namespace GotaSoundIO.IO.Backend.WASAPI.CoreAudioApi
{
    /// <summary>
    /// Collection of sessions.
    /// </summary>
    public class SessionCollection
    {
        readonly IAudioSessionEnumerator audioSessionEnumerator;

        internal SessionCollection(IAudioSessionEnumerator realEnumerator)
        {
            audioSessionEnumerator = realEnumerator;
        }

        /// <summary>
        /// Returns session at index.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public AudioSessionControl this[int index]
        {
            get
            {
                Marshal.ThrowExceptionForHR(audioSessionEnumerator.GetSession(index, out var result));
                return new AudioSessionControl(result);
            }
        }

        /// <summary>
        /// Number of current sessions.
        /// </summary>
        public int Count
        {
            get
            {
                Marshal.ThrowExceptionForHR(audioSessionEnumerator.GetCount(out var result));
                return result;
            }
        }
    }
}
