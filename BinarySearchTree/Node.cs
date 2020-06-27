using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class Node
    {
        //Member variables
        public int Data;
        //Will we need to indicate connection to child nodes here?
        //Should have node to left and right (unless it's end of tree, in which case that node == null and our add method will add in our value)
        public Node leftChild;
        public Node rightChild;

        //Ctor
        public Node(int data)
        {
            Data = data;
        }

        //member methods
    }
}
