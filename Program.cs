using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace MinecraftAutomationBot
{
    
    static class Program
    {
        static float[] apple = { 2, 5, 66, 90, 34, 64, Math.Pi(), 655, 285, 90, 4, Math.Tau(), 67583, 3978, 24, 664, 244, 7, 323, 6, 223, 6345, 84 };
        static void Main()
        {
            
            float mark = Math.Pi();
            Console.WriteLine("Argon: " + Math.Power(5, 10));

            #region Array Writer
            Console.WriteLine("Sorted Array:");

            apple = Math.Sort(apple, 3f);
            foreach (float a in apple)
            {
                Console.Write(" " + a + ",");
            }
            #endregion
            #region Max Writer
            Console.WriteLine("");
            Console.WriteLine("Biggest number: " + Math.Max(apple, 3f));
            #endregion
        }

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        static extern bool PostMessage(IntPtr hWnd, UInt32 Msg, int wParam, int lParam);

        static void Bot()
        {
            int arva = 0;
            bool start = true;
            while (start)
            {

                button1_Click(arva);
                Console.WriteLine("Done, dummy. Current window: 'Discord'");
                //Console.WriteLine("Current Key: " + arva);
                Thread.Sleep(300000);
                arva++;
            }
        }
        static void button1_Click(int arva)
        {
            const int WM_SYSKEYDOWN = 0x0104;
            

            IntPtr WindowToFind = FindWindow(null, "#idle-miner - Discord");

            //190 IT IS!!!!!

            PostMessage(WindowToFind, WM_SYSKEYDOWN, 190, 0) ;
            PostMessage(WindowToFind, WM_SYSKEYDOWN, 0x48, 0);
            Thread.Sleep(6000);
            PostMessage(WindowToFind, WM_SYSKEYDOWN, 0x0D, 0);
            Thread.Sleep(5000);
            PostMessage(WindowToFind, WM_SYSKEYDOWN, 190, 0);
            PostMessage(WindowToFind, WM_SYSKEYDOWN, 0x46, 0);
            PostMessage(WindowToFind, WM_SYSKEYDOWN, 0x0D, 0);
            Thread.Sleep(5000);
            PostMessage(WindowToFind, WM_SYSKEYDOWN, 190, 0);
            PostMessage(WindowToFind, WM_SYSKEYDOWN, 0x53, 0);
            PostMessage(WindowToFind, WM_SYSKEYDOWN, 0x0D, 0);


        }

        
    }

}
