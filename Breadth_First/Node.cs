using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breadth_First
{
    class Node
    {
        Node Right, Left;
        String Data;

        public void set_Nodes(Node left, Node right, String data) 
        {
            this.set_Left(left);
            this.set_Right(right);
            this.set_Data(data);
        }
        
        // Left
        private void set_Left(Node left)
        {
            this.Left = left;
        }
        public Node get_Left() 
        {
            return this.Left;
        }
        // Right
        private void set_Right(Node right) 
        {
            this.Right = right;
        }
        public Node get_Right()
        {
            return this.Right;
        }
        // Data
        private void set_Data(String data) 
        {
            this.Data = data;
        }
        public String get_Data() 
        {
            return this.Data;
        }
    }
}
