using HelloTreeWorldApplication.Models;
using HelloTreeWorldApplication.Utilities;

namespace HelloTreeWorldApplication
{
    class Program
    {
        static void Main()
        {
            Message message = new Message("Hello World!");
            Tree treeStructure = new Tree();
            treeStructure.GenerateTreeStructureFromList(message.AlphabetList);
            MessageDecoder.DecodeMessage(treeStructure, message);
        }
    }
}
