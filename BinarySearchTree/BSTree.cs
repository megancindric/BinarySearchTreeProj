using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class BSTree
    {
        //member variables
        public Node rootNode;
        //ctor
        public BSTree()
        {

        }

        //member methods
        public void Add(Node nodeToAdd)
        {
            //Will be passing in an array of values to sort into a tree
            if (rootNode == null)
            {
                //current node will equal rootnode
                rootNode = nodeToAdd;
            }
            //Will then compare our current value (should we pass in as param?)
            else
            {
                if (nodeToAdd.Data > rootNode.Data)
                {
                    //Some logic to move us to the RIGHT child node of rootNode
                        //If this is a null value (unassigned) then we will assign this node to this position

                }
                else if (nodeToAdd.Data < rootNode.Data)
                {
                    //Some logic to move us to LEFT child node of rootNode
                        //If this is a null value (unassigned) then we will assign this node to this position
                }
            }
            
        }

        public void Search(int itemToSearch)
        {
            //Should return a bool of contains or does not contain said value
            //Can run same comparison that Add runs - compares value to each node then chooses whether to go left or right down tree
                //if current value == itemToSearch return true, otherwise...
                    //If greater than current value, shift to right child node
                    //If less than current value, shift to left child node
                        //If we get to the end and have not found this value, return false
        }
    }
}
