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
    public partial class A_Star : Form
    {
        Nude A = new Nude("A", 10);
        Nude B = new Nude("B", 8);
        Nude C = new Nude("C", 5);
        Nude D = new Nude("D", 7);
        Nude E = new Nude("E", 3);
        Nude F = new Nude("F", 6);
        Nude G = new Nude("G", 5);
        Nude H = new Nude("H", 3);
        Nude I = new Nude("I", 1);
        Nude J = new Nude("J", 0);
        Nude root ;
        Bitmap circle_0 = Bitmap.FromFile(@"F:\images\circle_0.png") as Bitmap; // Dedualt
        Bitmap circle_1 = Bitmap.FromFile(@"F:\images\circle_1.png") as Bitmap; // Target == Green
        Bitmap circle_2 = Bitmap.FromFile(@"F:\images\circle_2.png") as Bitmap; // Select = Orange
        Bitmap circle_3 = Bitmap.FromFile(@"F:\images\circle_3.png") as Bitmap; // Steps = Blue

        bool startFlag = false;
        string Target = "";

        public A_Star()
        {
            root = A;
            InitializeNudes();
            InitializeComponent();
        }
        private void InitializeNudes()
        {
            A.Add_Nude(B, 6);
            A.Add_Nude(F, 3);
            B.Add_Nude(A, 6);
            B.Add_Nude(C, 3);
            B.Add_Nude(D, 2);
            C.Add_Nude(B, 3);
            C.Add_Nude(D, 1);
            C.Add_Nude(E, 5);
            D.Add_Nude(B, 2);
            D.Add_Nude(C, 1);
            D.Add_Nude(E, 8);
            E.Add_Nude(C, 5);
            E.Add_Nude(D, 8);
            E.Add_Nude(I, 5);
            E.Add_Nude(J, 5);
            F.Add_Nude(A, 3);
            F.Add_Nude(G, 1);
            F.Add_Nude(H, 7);
            G.Add_Nude(F, 1);
            G.Add_Nude(I, 3);
            H.Add_Nude(F, 7);
            H.Add_Nude(I, 2);
            I.Add_Nude(E, 5);
            I.Add_Nude(G, 3);
            I.Add_Nude(H, 2);
            I.Add_Nude(J, 3);
            J.Add_Nude(E, 5);
            J.Add_Nude(I, 3);
        }

        

        private void btn_F_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).BackgroundImage = circle_0;
        }

        private void btn_F_MouseEnter(object sender, EventArgs e)
        {
            //(sender as Button).BackgroundImage = System.Drawing.Bitmap.FromResource(IntPtr.Zero, "circle_1");
            if (startFlag)
            {
                (sender as Button).BackgroundImage = circle_2;
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            startFlag = true;
            (sender as Button).Visible = !startFlag;
            foreach (Button b in Controls)
            {
                if (b.Text.Count() == 1)
                {
                    b.Enabled = true;
                }
            }
        }

        private void btn_A_Click(object sender, EventArgs e)
        {
            if (startFlag)
            {
                Target = (sender as Button).Text;
                btn_Go.Visible = true;
                startFlag = false;
            }
        }
        private void Go_On(object sender, EventArgs e) 
        {
            if (root.Get_Text() == Target)
            {
                foreach (Button b in Controls)
                {
                    if (b.Text == Target)
                    {
                        b.BackgroundImage = circle_1;
                        btn_Go.Visible = false;
                    }
                }
            }
            else
            {
                foreach (Button b in Controls)
                {

                    if (b.Text == root.Get_Text())
                    {
                        b.BackgroundImage = circle_3;
                    }
                }
                root = root.Get_Shortest(); 
            }
        }
    }
}
