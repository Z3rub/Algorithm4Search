namespace Breadth_First
{
    partial class frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Random = new System.Windows.Forms.Button();
            this.txt_A = new System.Windows.Forms.TextBox();
            this.txt_B = new System.Windows.Forms.TextBox();
            this.txt_C = new System.Windows.Forms.TextBox();
            this.txt_D = new System.Windows.Forms.TextBox();
            this.txt_E = new System.Windows.Forms.TextBox();
            this.txt_F = new System.Windows.Forms.TextBox();
            this.txt_G = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_Data = new System.Windows.Forms.TextBox();
            this.rbn_Breadth = new System.Windows.Forms.RadioButton();
            this.rbn_Depth = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Random
            // 
            this.btn_Random.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_Random.Location = new System.Drawing.Point(16, 123);
            this.btn_Random.Name = "btn_Random";
            this.btn_Random.Size = new System.Drawing.Size(254, 32);
            this.btn_Random.TabIndex = 0;
            this.btn_Random.Text = "Search for random Value";
            this.btn_Random.UseVisualStyleBackColor = true;
            this.btn_Random.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_A
            // 
            this.txt_A.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_A.Font = new System.Drawing.Font("Tahoma", 26F);
            this.txt_A.Location = new System.Drawing.Point(120, 180);
            this.txt_A.Name = "txt_A";
            this.txt_A.ReadOnly = true;
            this.txt_A.Size = new System.Drawing.Size(50, 49);
            this.txt_A.TabIndex = 1;
            this.txt_A.Text = "A";
            this.txt_A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_B
            // 
            this.txt_B.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_B.Font = new System.Drawing.Font("Tahoma", 26F);
            this.txt_B.Location = new System.Drawing.Point(45, 231);
            this.txt_B.Name = "txt_B";
            this.txt_B.ReadOnly = true;
            this.txt_B.Size = new System.Drawing.Size(50, 49);
            this.txt_B.TabIndex = 2;
            this.txt_B.Text = "B";
            this.txt_B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_C
            // 
            this.txt_C.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_C.Font = new System.Drawing.Font("Tahoma", 26F);
            this.txt_C.Location = new System.Drawing.Point(195, 231);
            this.txt_C.Name = "txt_C";
            this.txt_C.ReadOnly = true;
            this.txt_C.Size = new System.Drawing.Size(50, 49);
            this.txt_C.TabIndex = 3;
            this.txt_C.Text = "C";
            this.txt_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_D
            // 
            this.txt_D.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_D.Font = new System.Drawing.Font("Tahoma", 26F);
            this.txt_D.Location = new System.Drawing.Point(16, 292);
            this.txt_D.Name = "txt_D";
            this.txt_D.ReadOnly = true;
            this.txt_D.Size = new System.Drawing.Size(50, 49);
            this.txt_D.TabIndex = 4;
            this.txt_D.Text = "D";
            this.txt_D.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_E
            // 
            this.txt_E.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_E.Font = new System.Drawing.Font("Tahoma", 26F);
            this.txt_E.Location = new System.Drawing.Point(75, 292);
            this.txt_E.Name = "txt_E";
            this.txt_E.ReadOnly = true;
            this.txt_E.Size = new System.Drawing.Size(50, 49);
            this.txt_E.TabIndex = 5;
            this.txt_E.Text = "E";
            this.txt_E.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_F
            // 
            this.txt_F.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_F.Font = new System.Drawing.Font("Tahoma", 26F);
            this.txt_F.Location = new System.Drawing.Point(161, 292);
            this.txt_F.Name = "txt_F";
            this.txt_F.ReadOnly = true;
            this.txt_F.Size = new System.Drawing.Size(50, 49);
            this.txt_F.TabIndex = 6;
            this.txt_F.Text = "F";
            this.txt_F.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_G
            // 
            this.txt_G.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_G.Font = new System.Drawing.Font("Tahoma", 26F);
            this.txt_G.Location = new System.Drawing.Point(220, 292);
            this.txt_G.Name = "txt_G";
            this.txt_G.ReadOnly = true;
            this.txt_G.Size = new System.Drawing.Size(50, 49);
            this.txt_G.TabIndex = 7;
            this.txt_G.Text = "G";
            this.txt_G.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_search.Location = new System.Drawing.Point(16, 87);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(158, 30);
            this.btn_search.TabIndex = 8;
            this.btn_search.Text = "Search for a Value";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_Data
            // 
            this.txt_Data.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txt_Data.ForeColor = System.Drawing.Color.Red;
            this.txt_Data.Location = new System.Drawing.Point(180, 87);
            this.txt_Data.Name = "txt_Data";
            this.txt_Data.Size = new System.Drawing.Size(90, 30);
            this.txt_Data.TabIndex = 0;
            this.txt_Data.Tag = "data";
            this.txt_Data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbn_Breadth
            // 
            this.rbn_Breadth.AutoSize = true;
            this.rbn_Breadth.Location = new System.Drawing.Point(12, 25);
            this.rbn_Breadth.Name = "rbn_Breadth";
            this.rbn_Breadth.Size = new System.Drawing.Size(87, 17);
            this.rbn_Breadth.TabIndex = 9;
            this.rbn_Breadth.TabStop = true;
            this.rbn_Breadth.Text = "Breadth First";
            this.rbn_Breadth.UseVisualStyleBackColor = true;
            // 
            // rbn_Depth
            // 
            this.rbn_Depth.AutoSize = true;
            this.rbn_Depth.Location = new System.Drawing.Point(12, 48);
            this.rbn_Depth.Name = "rbn_Depth";
            this.rbn_Depth.Size = new System.Drawing.Size(78, 17);
            this.rbn_Depth.TabIndex = 10;
            this.rbn_Depth.TabStop = true;
            this.rbn_Depth.Text = "Depth First";
            this.rbn_Depth.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Please Select the algrothim which want search by:";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 382);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbn_Depth);
            this.Controls.Add(this.rbn_Breadth);
            this.Controls.Add(this.txt_Data);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_G);
            this.Controls.Add(this.txt_F);
            this.Controls.Add(this.txt_E);
            this.Controls.Add(this.txt_D);
            this.Controls.Add(this.txt_C);
            this.Controls.Add(this.txt_B);
            this.Controls.Add(this.txt_A);
            this.Controls.Add(this.btn_Random);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Breadth First";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Random;
        private System.Windows.Forms.TextBox txt_A;
        private System.Windows.Forms.TextBox txt_B;
        private System.Windows.Forms.TextBox txt_C;
        private System.Windows.Forms.TextBox txt_D;
        private System.Windows.Forms.TextBox txt_E;
        private System.Windows.Forms.TextBox txt_F;
        private System.Windows.Forms.TextBox txt_G;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_Data;
        private System.Windows.Forms.RadioButton rbn_Breadth;
        private System.Windows.Forms.RadioButton rbn_Depth;
        private System.Windows.Forms.Label label1;
    }
}

