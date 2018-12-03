using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breadth_First
{
    class Nude
    {
        private string Text;
        private int G;
        private int H;
        private List<object[]> Nudes = new List<object[]>(); // [Nude n, Int h]

        public Nude(string text, int h)
        {
            this.Set_H(h);
            this.Set_Text(text);
        }

        // Set & Get Text
        public void Set_Text(string text) 
        {
            this.Text = text;
        }
        public string Get_Text()
        {
            return this.Text;
        }
        // Set & Get G
        public void Set_G(int g) 
        {
            this.G = g;
        }
        public int Get_G() 
        {
            return this.G;
        }

        // Set & Get H
        public void Set_H(int h)
        {
            this.H = h;
        }
        public int Get_H()
        {
            return this.H;
        }

        // Set & Get Nudes
        public void Add_Nude(Nude n, int g) 
        {
            Object[] o = {n,g};
            this.Nudes.Add(o);
        }
        public void Add_Nudes(List<object[]> objs)
        {
            foreach(object o in objs)
            {
                this.Nudes.Add((object[])o);
            }
        }
        public List<object[]> Get_Nudes() 
        {
            return this.Nudes;
        }
        public Nude Get_Shortest()
        {
            List<object[]> temps = this.Get_Nudes();
            object[] step;
            for (int i = 0; i < temps.Count() -1; i++)
            {
                if (Convert.ToInt32(temps[i][1]) < Convert.ToInt32(temps[i + 1][1]))
                {
                    step = temps[i];
                    temps[i] = temps[i + 1];
                    temps[i + 1] = step;
                    i--;
                }
            }
            return temps[temps.Count()-1][0] as Nude;
        }
    }
}
