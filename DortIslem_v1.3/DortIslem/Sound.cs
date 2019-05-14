using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace DortIslem
{
    public static class Sound
    {
        public static void WrongSound()
        {
            SoundPlayer player = new SoundPlayer();
            string path = Application.StartupPath.ToString() + "\\wrongAnswer.wav";
            player.SoundLocation = path;
            player.Play();
        }
        public static void TrueSound()
        {
            SoundPlayer player = new SoundPlayer();
            string path = Application.StartupPath.ToString() + "\\trueAnswer.wav";
            player.SoundLocation = path;
            player.Play();
        }

        public static void IntroSound()
        {
            SoundPlayer player = new SoundPlayer();
            string path = Application.StartupPath.ToString() + "\\introMusic.wav";
            player.SoundLocation = path;
            player.Play();
        }

        public static void ExitSound()
        {
            SoundPlayer player = new SoundPlayer();
            string path = Application.StartupPath.ToString() + "\\exitMusic.wav";
            player.SoundLocation = path;
            player.Play();
        }
    }
}
