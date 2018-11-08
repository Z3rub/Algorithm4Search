using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Breadth_First
{
    public partial class frm_Main : Form
    {
        String[] n = new String[] { "A", "B", "C", "D", "E", "F", "G" };
        Node A= new Node();
        Node B = new Node();
        Node C = new Node();
        Node D = new Node();
        Node E = new Node();
        Node F = new Node();
        Node G = new Node();
       
        Queue<Node> openQ = new Queue<Node>();
        Queue<Node> closeQ = new Queue<Node>();
        Stack<Node> openS = new Stack<Node>();
        Stack<Node> closeS = new Stack<Node>();
        public frm_Main()
        {
            A.set_Nodes(B, C, "A");
            B.set_Nodes(D, E, "B");
            C.set_Nodes(F, G, "C");
            D.set_Nodes(null, null, "D");
            E.set_Nodes(null, null, "E");
            F.set_Nodes(null, null, "F");
            G.set_Nodes(null, null, "G");
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            if (rbn_Breadth.Checked)
            {
                BreadthFirstSearch(n[rand.Next(0, 6)]);
            }
            else if (rbn_Depth.Checked)
            {
                DepthFirstSearch(n[rand.Next(0, 6)]);
            }
            else
            {
                MessageBox.Show("Please Select Any Algorithim!");
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //Test();
            if (n.ToList<String>().Contains(txt_Data.Text))
            {
                if (rbn_Breadth.Checked)
                {
                    BreadthFirstSearch(txt_Data.Text);
                }
                else if (rbn_Depth.Checked)
                {
                    DepthFirstSearch(txt_Data.Text);
                }
                else
                {
                    MessageBox.Show("Please Select Any Algorithim!");
                }
            }
            else
            {
                MessageBox.Show("The Char in not found in The Graph!");
            }
            
        }
        // Breadth First Serach
        private void BreadthFirstSearch(String data)
        {
            openQ.Enqueue(A);
            while (true)
            {
                if (openQ.Peek().get_Data() == data)
                {
                    closeQ.Enqueue(openQ.Dequeue());
                    MessageBox.Show("We found " + data);
                    openQ.Clear();
                    break;
                }
                else
                {
                    //MessageBox.Show(openQ.Peek().get_Data() + " 'll be deleted!");
                    closeQ.Enqueue(openQ.Dequeue());
                    //MessageBox.Show(closeQ.Last().get_Data() + " is cPeek!");
                    openQ.Enqueue(closeQ.Last().get_Left());
                    //MessageBox.Show(openQ.Peek().get_Data() + " is oPeek!");
                    openQ.Enqueue(closeQ.Last().get_Right());
                    setControl(data);
                }
            }
            foreach (Node n in closeQ)
            {
                MessageBox.Show(n.get_Data());
            }
            closeQ.Clear();
        }
        // Depth First Search
        private void DepthFirstSearch(String data)
        {
            openS.Push(A);
            while (true)
            {
                if (openS.Peek().get_Data() == data)
                {
                    closeS.Push(openS.Pop());
                    MessageBox.Show("We found " + data);
                    openS.Clear();
                    break;
                }
                else
                {
                    closeS.Push(openS.Pop());
                    if (closeS.Peek().get_Right() != null) { 
                        openS.Push(closeS.Peek().get_Right());
                    }
                    if (closeS.Peek().get_Left() != null) { 
                        openS.Push(closeS.Peek().get_Left());
                    }
                   
                    setControl(data);
                }
            }
            foreach (Node n in closeS.Reverse())
            {
                MessageBox.Show(n.get_Data());
            }
            closeS.Clear();
        }
        // Set All TextBox Controls
        private void setControl(String data)
        {
            foreach (Control x in Controls) 
            {
                if (x is TextBox) 
                {
                    if (x.Tag != "data" && x.Text == data)
                    {
                        x.BackColor = Color.Yellow;
                    }
                    else
                    {
                        x.BackColor = Color.WhiteSmoke;
                    }
                }
            }
        }

        private void Test() 
        {
            Stack<int> Nums = new Stack<int>();
            Nums.Push(1);
            MessageBox.Show(Nums.Peek().ToString());
            Nums.Push(2);
            MessageBox.Show(Nums.Peek().ToString());
            Nums.Push(3);
            MessageBox.Show(Nums.Peek().ToString());
            Nums.Push(4);
            Nums.Pop();
            MessageBox.Show(Nums.Peek().ToString());
            MessageBox.Show(Nums.Count.ToString());
        }
    }
}
