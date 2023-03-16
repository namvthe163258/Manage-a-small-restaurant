namespace QuanLy_QuanAn
{
    partial class frmFUpdate
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
            this.lb_Tieude = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_Ucate = new System.Windows.Forms.Label();
            this.lb_Udescription = new System.Windows.Forms.Label();
            this.lb_Uprice = new System.Windows.Forms.Label();
            this.lb_Uname = new System.Windows.Forms.Label();
            this.lb_Uid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Tieude
            // 
            this.lb_Tieude.AutoSize = true;
            this.lb_Tieude.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Tieude.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lb_Tieude.Location = new System.Drawing.Point(399, 18);
            this.lb_Tieude.Name = "lb_Tieude";
            this.lb_Tieude.Size = new System.Drawing.Size(194, 40);
            this.lb_Tieude.TabIndex = 25;
            this.lb_Tieude.Text = "Update Food";
            this.lb_Tieude.Click += new System.EventHandler(this.lb_Tieude_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(573, 450);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(120, 40);
            this.btn_Exit.TabIndex = 24;
            this.btn_Exit.Text = "Exit ";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(265, 450);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(132, 40);
            this.btn_Save.TabIndex = 23;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(354, 359);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(284, 23);
            this.textBox5.TabIndex = 22;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(354, 282);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(284, 23);
            this.textBox4.TabIndex = 21;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(354, 143);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(284, 23);
            this.textBox3.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(354, 211);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(284, 23);
            this.textBox2.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(354, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 23);
            this.textBox1.TabIndex = 18;
            // 
            // lb_Ucate
            // 
            this.lb_Ucate.AutoSize = true;
            this.lb_Ucate.Location = new System.Drawing.Point(228, 367);
            this.lb_Ucate.Name = "lb_Ucate";
            this.lb_Ucate.Size = new System.Drawing.Size(58, 15);
            this.lb_Ucate.TabIndex = 17;
            this.lb_Ucate.Text = "Category:";
            // 
            // lb_Udescription
            // 
            this.lb_Udescription.AutoSize = true;
            this.lb_Udescription.Location = new System.Drawing.Point(216, 290);
            this.lb_Udescription.Name = "lb_Udescription";
            this.lb_Udescription.Size = new System.Drawing.Size(70, 15);
            this.lb_Udescription.TabIndex = 16;
            this.lb_Udescription.Text = "Description:";
            // 
            // lb_Uprice
            // 
            this.lb_Uprice.AutoSize = true;
            this.lb_Uprice.Location = new System.Drawing.Point(239, 219);
            this.lb_Uprice.Name = "lb_Uprice";
            this.lb_Uprice.Size = new System.Drawing.Size(36, 15);
            this.lb_Uprice.TabIndex = 15;
            this.lb_Uprice.Text = "Price:";
            // 
            // lb_Uname
            // 
            this.lb_Uname.AutoSize = true;
            this.lb_Uname.Location = new System.Drawing.Point(216, 151);
            this.lb_Uname.Name = "lb_Uname";
            this.lb_Uname.Size = new System.Drawing.Size(79, 15);
            this.lb_Uname.TabIndex = 14;
            this.lb_Uname.Text = "Foood Name:";
            // 
            // lb_Uid
            // 
            this.lb_Uid.AutoSize = true;
            this.lb_Uid.Location = new System.Drawing.Point(254, 90);
            this.lb_Uid.Name = "lb_Uid";
            this.lb_Uid.Size = new System.Drawing.Size(21, 15);
            this.lb_Uid.TabIndex = 13;
            this.lb_Uid.Text = "ID:";
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(942, 525);
            this.Controls.Add(this.lb_Tieude);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_Ucate);
            this.Controls.Add(this.lb_Udescription);
            this.Controls.Add(this.lb_Uprice);
            this.Controls.Add(this.lb_Uname);
            this.Controls.Add(this.lb_Uid);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "Details";
            this.Text = "Details";
            this.Load += new System.EventHandler(this.Details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_Tieude;
        private Button btn_Exit;
        private Button btn_Save;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label lb_Ucate;
        private Label lb_Udescription;
        private Label lb_Uprice;
        private Label lb_Uname;
        private Label lb_Uid;
    }
}