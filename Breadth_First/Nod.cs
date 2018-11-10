using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breadth_First
{
    class Nod
    {
        List<Nod> Childern = new List<Nod>();
        Nod Parent;
        String Data;
        int Distance;
        public Nod(String data, int distance) 
        {
            this.Set_Data(data);
            this.Set_Distance(distance);
        }
        // Set Parent
        public void Set_Parent(Nod parent) 
        {
            this.Parent = parent;
        }
        public Nod Get_Parent()
        {
            return this.Parent;
        }
        // Set Childern
        public void New_Child(Nod child) 
        {
            this.Childern.Add(child);
            if (Childern.Count > 1) {
                this.ReSort();
            }
        }

        public void New_Child(Nod[] child)
        {
            foreach (Nod n in child)
            {
                this.Childern.Add(n);
                if (Childern.Count > 1)
                {
                    this.ReSort();
                }
            }
        }
        // Get Childern
        public List<Nod> Get_Childern() {
            return this.Childern;
        }
        // Sort Childern
        private void ReSort() 
        {
            Nod Temp;
            int last = this.Childern.Count -1;
            if(Childern[last].Distance < Childern[last-1].Distance)
            {
                Temp = Childern[last];
                Childern[last] = Childern[last - 1];
                Childern[last - 1] = Temp;
            }   
        }
        // Set Data
        private void Set_Data(String data) 
        {
            this.Data = data;
        }
        // Get Data
        public String Get_Data()
        {
            return this.Data;
        }
        // Set Distance
        public void Set_Distance(int distance)
        {
            this.Distance = distance;
        }
        // Get Distance
        public int Get_Distance()
        {
            return this.Distance;
        }
    }
}
