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
            rootNode = null;
            //Do we have to assign this here in order to have a "null" value to set?
        }

        //member methods
        public void AddNode(int value)
        {
            Node nodeToAdd = new Node(value);
            if (rootNode == null)
            {
                //current node will equal rootnode
                rootNode = nodeToAdd;
            }
            //Will then compare our current value to our value to add
            else
            {
                //Will have a current node, starting at our root
                Node currentNode = rootNode;
                //Want to have a "parent node" to ensure our nodes all nest within each other
                //This will also have a LEFT and a RIGHT node (currently unassigned)

                //How to keep looping through this UNTIL the value is assigned to a null spot?
                while (true)
                {
                    if (value > currentNode.Data)
                    {
                        //Some logic to move us to the RIGHT child node of rootNode
                        if (currentNode.rightChild == null)
                        {
                            currentNode.rightChild = nodeToAdd;
                            return;
                        }
                        else
                        {
                            currentNode = currentNode.rightChild;
                        }
                    }
                    else
                    {
                        if (currentNode.leftChild == null)
                        {
                            currentNode.leftChild = nodeToAdd;
                            return;
                        }
                        else
                        {
                            currentNode = currentNode.leftChild;
                        }

                    }
                }
               
            }
            
        }

        public bool Search(int itemToSearch)
        {
                Node currentNode = rootNode;
                while (true)
                {
                    if (itemToSearch > currentNode.Data)
                    {
                        if (currentNode.rightChild == null)
                        {
                            return false;
                        }
                        else if (currentNode.rightChild.Data == itemToSearch)
                        {
                            return true;
                        }
                        else
                        {
                            currentNode = currentNode.rightChild;
                        }
                    }
                    else
                    {
                        if (currentNode.leftChild == null)
                        {
                        return false;
                        }
                        else if (currentNode.leftChild.Data == itemToSearch)
                        {
                        return true;
                        }
                        else
                        {
                            currentNode = currentNode.leftChild;
                        }

                    }
                }
        }
    }
}
