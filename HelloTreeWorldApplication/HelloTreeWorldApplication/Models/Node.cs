namespace HelloTreeWorldApplication.Models
{
    public class Node
    {
        public int AsciiValue;
        public char AlphabetValue;
        public Node LeftChild;
        public Node RightChild;

        public Node(Node leftChild, Node rightChild, int asciiValue, char alphabetValue)
        {
            LeftChild = leftChild;
            RightChild = rightChild;
            AsciiValue = asciiValue;
            AlphabetValue = alphabetValue;
        }

        public Node(int asciiValue, char alphabetValue)
        {
            AsciiValue = asciiValue;
            AlphabetValue = alphabetValue;
        }
    }
}
