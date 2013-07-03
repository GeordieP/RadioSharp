using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Un4seen.Bass;

namespace RadioSharp {
    class Radio {
        private string techhouse;
        private Boolean playing;
        private int stream = 0;

        public Radio() {
            techhouse = "http://pub1.di.fm:80/di_techhouse";
            playing = false;
            Bass.BASS_Free();       // Initially free all channels
        }

        public Boolean StartStop() {
            playing = !playing;     // toggle playing status

            if (playing) {
                if (Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero)) {
                    IntPtr ptr = new IntPtr(0);
                    stream = Bass.BASS_StreamCreateURL(techhouse, 0, BASSFlag.BASS_DEFAULT, null, ptr);
                    Bass.BASS_ChannelPlay(stream, false);
                    Console.WriteLine("id3: " + Bass.BASS_ChannelGetTags(stream, BASSTag.BASS_TAG_ICY));
                }
                return true;
            } else {
                Bass.BASS_StreamFree(stream);
                Bass.BASS_Free();
                stream = 0;
                return false;
            }
        }

        public void ChangeVolume(float volume) {
            Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, volume);
        }
    }
}
