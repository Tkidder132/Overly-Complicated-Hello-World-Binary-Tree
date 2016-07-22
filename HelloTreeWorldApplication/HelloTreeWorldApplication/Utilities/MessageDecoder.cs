using System;
using HelloTreeWorldApplication.Models;

namespace HelloTreeWorldApplication.Utilities
{
    public static class MessageDecoder
    {
        public static void DecodeMessage(Tree treeStructure, Message message)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            Console.WriteLine("Decoding message!");
            var decodedMessage = "";
            var counter = 0;

            foreach (var asciiValue in message.MessageAsciiValueList)
            {
                decodedMessage += treeStructure.SearchForNodeWithAsciiValue(treeStructure.RootNode, asciiValue).AlphabetValue;
                counter++;
                PrintingUtility.PrintProgress(counter, message.MessageAsciiValueList);
            }

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            PrintingUtility.PrintFinalMessageAndWait(decodedMessage, elapsedMs);
        }
    }
}
