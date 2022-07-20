using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace SplashScreenHelperLib
{
    public class SplashScreenHelper
    {
        public static void ShowSplashScreen(string imagePath, TimeSpan fadeoutDuration, int delayMs = 1000)
        {
            var s = new SplashScreen(imagePath);
            s.Show(false);
            Thread.Sleep(delayMs);
            s.Close(fadeoutDuration);
        }

        public static async Task ShowSplashScreenAsync(string imagePath, TimeSpan fadeoutDuration, int delayMs = 1000)
        {
            var s = new SplashScreen(imagePath);
            s.Show(false);
            await TaskEx.Delay(delayMs);
            s.Close(fadeoutDuration);
        }
    }
}
