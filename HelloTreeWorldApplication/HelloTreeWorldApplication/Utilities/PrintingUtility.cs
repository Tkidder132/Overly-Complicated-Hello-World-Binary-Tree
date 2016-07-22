using System;
using System.Collections.Generic;

namespace HelloTreeWorldApplication.Utilities
{
    public static class PrintingUtility
    {
        public static void PrintProgress(int counter, List<int> messageAsciiValueList)
        {
            ClearCurrentConsoleLine();
            PrintProgressBar((counter), messageAsciiValueList.Count);
            Console.Write($"{GetPercentageOutput(counter, messageAsciiValueList.Count)}");
            System.Threading.Thread.Sleep(250);
        }

        private static void PrintProgressBar(int counter, double asciiListCount)
        {
            var counterPercent = 100 * (counter / asciiListCount);
            Console.Write("(");
            for (var i = 10; i <= 100; i += 10)
            {
                Console.Write(counterPercent - i >= 0 ? "#" : " ");
            }
            Console.Write(") ");
        }

        public static void PrintFinalMessageAndWait(string decodedMessage, long elapsedMs)
        {
            Console.WriteLine();
            Console.WriteLine($"Message decoded in {GetTimeOutput(elapsedMs)}");
            Console.WriteLine();
            Console.WriteLine(decodedMessage);
            Console.ReadLine();
        }

        private static string GetPercentageOutput(int counter, int messageAsciiValueListCount)
        {
            var percentage = 100 * (counter / (double)messageAsciiValueListCount);
            return percentage < 100 ? percentage.ToString("N2") + "%" : "DONE";
        }

        private static string GetTimeOutput(long elapsedMs)
        {
            var t = TimeSpan.FromMilliseconds(elapsedMs);
            return $"{t.Hours:D2}h:{t.Minutes:D2}m:{t.Seconds:D2}s:{t.Milliseconds:D3}ms";
        }

        private static void ClearCurrentConsoleLine()
        {
            var currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
    }
}
