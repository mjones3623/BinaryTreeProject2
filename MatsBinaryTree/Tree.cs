using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatsBinaryTree
{
    class Tree
    {
        public Node root;
        


        public Tree()
        {
            root = null;
            
        }

        public void Add(int v)
        {

            if (root == null)
            {
                root = new Node();

                root.value = v;
                return;
            }
            Node current;
            current = root;

            while (true)
            {

                if (v < current.value)
                {
                    if (current.left == null)
                    {
                        current.left = new Node();
                        current.left.value = v;
                        return;
                    }
                    else
                    {
                        current = current.left;
                    }

                }
                else
                {
                   if (current.right == null)
                    {
                        current.right = new Node();
                        current.right.value = v;
                        return;
                    }
                    else
                    {
                        current = current.right;
                    }

                }





            }

        }
        public void Search(int v)
        {
           
            if (root.value == v)
            {
                                               
                return;
            }
            Node current;
            current = root;

            while (true)
            {

                if (v < current.value)
                {
                    if (current.left.value == v)
                    {
                        
                        return;
                    }
                    else
                    {
                        current = current.left;
                    }

                }
                else
                {
                    if (current.right.value == v)
                    {
                        
                        return;
                    }
                    else
                    {
                        current = current.right;
                    }

                }





            }
        }

    }
}
