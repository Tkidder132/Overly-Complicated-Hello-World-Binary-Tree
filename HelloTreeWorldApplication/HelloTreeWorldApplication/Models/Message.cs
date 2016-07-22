using System;
using System.Collections.Generic;
using HelloTreeWorldApplication.Utilities;

namespace HelloTreeWorldApplication.Models
{
    public class Message
    {
        private readonly string _plainText;
        public List<char> AlphabetList;
        public List<int> MessageAsciiValueList;

        public Message(string message)
        {
            _plainText = message;
            GenerateAlphabetList();
            AlphabetList.Shuffle();
            MessageAsciiValueList = ConvertMessageToIntList();
        }
        
        private void GenerateAlphabetList()
        {
            AlphabetList = new List<char>();
            for (var i = 0; i < 256; i++)
            {
                AlphabetList.Add(Convert.ToChar(i));
            }
        }

        private List<int> ConvertMessageToIntList()
        {
            MessageAsciiValueList = new List<int>();
            var messageCharArray = _plainText.ToCharArray();
            foreach (var t in messageCharArray)
            {
                MessageAsciiValueList.Add(t);
            }
            return MessageAsciiValueList;
        }
    }
}
