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
    public partial class Uniform_Cost : Form
    {
        Nod S = new Nod("S", 0);
        Nod A = new Nod("A", 5);
        Nod B = new Nod("B", 2);
        Nod C = new Nod("C", 4);
        Nod D = new Nod("D", 9);
        Nod E = new Nod("E", 4);
        Nod F = new Nod("F", 2);
        Nod Gb = new Nod("G", 6);
        Nod Ge = new Nod("G", 6);
        Nod Gf = new Nod("G", 1);
        Nod H = new Nod("H", 7);

        Queue<Nod> openQ = new Queue<Nod>();
        Queue<Nod> closeQ = new Queue<Nod>();
        public Uniform_Cost()
        {
            S.New_Child(new[] { A, B, C });
            A.New_Child(new[] { D, F});
            B.New_Child(new[] { Gb });
            C.New_Child(new[] { F });
            D.New_Child(new[] { H });
            E.New_Child(new[] { Ge });
            F.New_Child(new[] { Gf });
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            UniformCostSearch("G");
        }
        private void UniformCostSearch(String data)
        {
            openQ.Enqueue(S);
            while (true)
            {
                if (openQ.Peek().Get_Data() == data)
                {
                    closeQ.Enqueue(openQ.Dequeue());
                    MessageBox.Show("We found " + data);
                    openQ.Clear();
                    break;
                }
                else
                {
                    closeQ.Enqueue(openQ.Dequeue());
                    foreach (Nod x in closeQ.Last().Get_Childern()) 
                    {
                        openQ.Enqueue(x);
                    }
                  //  setControl(data);
                }
            }
            foreach (Nod n in closeQ)
            {
                MessageBox.Show(n.Get_Data());
            }
            closeQ.Clear();
        }
    }
}
