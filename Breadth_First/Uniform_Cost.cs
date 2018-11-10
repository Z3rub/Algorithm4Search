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
        Nod B = new Nod("B", 4);
        Nod C = new Nod("C", 2);
        Nod D = new Nod("D", 9);
        Nod E = new Nod("E", 4);
        Nod F = new Nod("F", 2);
        Nod Gb = new Nod("G", 6);
        Nod Ge = new Nod("G", 5);
        Nod Gf = new Nod("G", 1);
        Nod H = new Nod("H", 7);
        Nod Step = new Nod("", 0);

        List<Nod> openL = new List<Nod>();
        Queue<Nod> closeQ = new Queue<Nod>();
        public Uniform_Cost()
        {
            // Set Childern
            S.New_Child(new[] { A, B, C });
            A.New_Child(new[] { D, E});
            B.New_Child(new[] { Gb });
            C.New_Child(new[] { F });
            F.New_Child(new[] { Gf });
            D.New_Child(new[] { H });
            E.New_Child(new[] { Ge });
            
            // Set Parents !
            S.Set_Parent(null);
            A.Set_Parent(S);
            B.Set_Parent(S);
            C.Set_Parent(S);
            D.Set_Parent(A);
            E.Set_Parent(A);
            F.Set_Parent(C);
            Gb.Set_Parent(B);
            Ge.Set_Parent(E);
            Gf.Set_Parent(F);
            H.Set_Parent(D);

            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            UniformCostSearch("G");
        }
        private void UniformCostSearch(String data)
        {
            openL.Add(S);
            while (true)
            {
                if (openL[0].Get_Data() == data)
                {
                    closeQ.Enqueue(openL[0]);
                    MessageBox.Show("We found " + data);
                    foreach (Nod n in Get_Track(openL[0]))
                    {
                        MessageBox.Show(n.Get_Data());
                    }
                    openL.Clear();
                    break;
                }
                else
                {
                    closeQ.Enqueue(openL[0]);
                    openL.Remove(openL[0]);
                    foreach (Nod x in closeQ.Last().Get_Childern()) 
                    {
                        Step = x;
                        Step.Set_Distance(Step.Get_Distance() + closeQ.Last().Get_Distance());
                        openL.Add(Step);
                        ReSort();
                    }
                    //foreach (Nod n in openL)
                    //{
                    //    MessageBox.Show("List: " + n.Get_Data() + " - " + n.Get_Distance());
                    //}
                    //MessageBox.Show(openL[0].Get_Distance().ToString() + " - " + openL[0].Get_Data());
                    
                    //  setControl(data);
                }
            }
            //foreach (Nod n in closeQ)
            //{
            //    MessageBox.Show(n.Get_Data());
            //}
            
            closeQ.Clear();
        }

        private void ReSort()
        {
            if (openL.Count >= 2)
            {
                Nod Temp;
                int last = this.openL.Count - 2;
                for (int i = 0; i <= last; i++)
                {
                    if (openL[i].Get_Distance() > openL[i + 1].Get_Distance())
                    {
                        Temp = openL[i];
                        openL[i] = openL[i + 1];
                        openL[i + 1] = Temp;
                        if (i != 0)
                        {
                            i--;
                        }
                    }
                }
            }
        }
        private List<Nod> Get_Track(Nod child) 
        {
            List<Nod> Track = new List<Nod>();
            Nod root = child;
            while (root.Get_Parent() != null) {
                Track.Add(root);
                root = root.Get_Parent();
            }
            return Track;
        }
    }
}
