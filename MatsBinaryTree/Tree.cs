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

        public void Add( int v)
        {

            Node nextNode = new Node();
            nextNode.value = v;

            if(root == null)
            {
                root = nextNode;
            }
            




        }



    }
}
