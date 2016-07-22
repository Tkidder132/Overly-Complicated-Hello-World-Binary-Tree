using System.Collections.Generic;
using System.Linq;

namespace HelloTreeWorldApplication.Models
{
    public class Tree
    {
        public Node RootNode { get; set; }

        public Node GenerateTreeStructureFromList(List<char> alphabetList)
        {
            CreateRootNode(alphabetList);
            foreach (var letter in alphabetList.Skip(1))
            {
                InsertNode(RootNode, CreateGenericNode(letter, letter));
            }
            return RootNode;
        }

        public Node SearchForNodeWithAsciiValue(Node searchNode, int asciiValue)
        {
            if (searchNode == null || searchNode.AsciiValue.Equals(asciiValue))
            {
                return searchNode;
            }
            else if (asciiValue < searchNode.AsciiValue)
            {
                return SearchForNodeWithAsciiValue(searchNode.LeftChild, asciiValue);
            }
            else
            {
                return SearchForNodeWithAsciiValue(searchNode.RightChild, asciiValue);
            }
        }

        private void CreateRootNode(IReadOnlyList<char> alphabetList)
        {
            RootNode = CreateGenericNode(alphabetList[0], alphabetList[0]);
        }

        private Node CreateGenericNode(int asciiValue, char alphabetValue)
        {
            return new Node(asciiValue, alphabetValue);
        }

        private void InsertNode(Node rootNode, Node newNode)
        {
            var temp = rootNode;
            if (newNode.AsciiValue < temp.AsciiValue)
            {
                if (temp.LeftChild == null)
                {
                    temp.LeftChild = newNode;
                }
                else
                {
                    temp = temp.LeftChild;
                    InsertNode(temp, newNode);
                }
            }
            else if (newNode.AsciiValue > temp.AsciiValue)
            {
                if (temp.RightChild == null)
                {
                    temp.RightChild = newNode;
                }
                else
                {
                    temp = temp.RightChild;
                    InsertNode(temp, newNode);
                }
            }
        }
    }
}
