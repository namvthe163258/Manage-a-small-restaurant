namespace QuanLy_QuanAn
{
    partial class frmFAdd
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
            this.lb_FName = new System.Windows.Forms.Label();
            this.lb_Price = new System.Windows.Forms.Label();
            this.lb_Descrip = new System.Windows.Forms.Label();
            this.txt_Cate = new System.Windows.Forms.TextBox();
            this.txt_Des = new System.Windows.Forms.TextBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_FName = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lb_Cate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Tieude
            // 
            this.lb_Tieude.AutoSize = true;
            this.lb_Tieude.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Tieude.Location = new System.Drawing.Point(363, 64);
            this.lb_Tieude.Name = "lb_Tieude";
            this.lb_Tieude.Size = new System.Drawing.Size(156, 41);
            this.lb_Tieude.TabIndex = 0;
            this.lb_Tieude.Text = "Add Food";
            // 
            // lb_FName
            // 
            this.lb_FName.AutoSize = true;
            this.lb_FName.Location = new System.Drawing.Point(192, 168);
            this.lb_FName.Name = "lb_FName";
            this.lb_FName.Size = new System.Drawing.Size(72, 15);
            this.lb_FName.TabIndex = 1;
            this.lb_FName.Text = "Food Name:";
            this.lb_FName.Click += new System.EventHandler(this.label2_Click);
            // 
            // lb_Price
            // 
            this.lb_Price.AutoSize = true;
            this.lb_Price.Location = new System.Drawing.Point(192, 248);
            this.lb_Price.Name = "lb_Price";
            this.lb_Price.Size = new System.Drawing.Size(36, 15);
            this.lb_Price.TabIndex = 2;
            this.lb_Price.Text = "Price:";
            // 
            // lb_Descrip
            // 
            this.lb_Descrip.AutoSize = true;
            this.lb_Descrip.Location = new System.Drawing.Point(192, 339);
            this.lb_Descrip.Name = "lb_Descrip";
            this.lb_Descrip.Size = new System.Drawing.Size(70, 15);
            this.lb_Descrip.TabIndex = 3;
            this.lb_Descrip.Text = "Description:";
            // 
            // txt_Cate
            // 
            this.txt_Cate.Location = new System.Drawing.Point(281, 431);
            this.txt_Cate.Name = "txt_Cate";
            this.txt_Cate.Size = new System.Drawing.Size(320, 23);
            this.txt_Cate.TabIndex = 4;
            // 
            // txt_Des
            // 
            this.txt_Des.Location = new System.Drawing.Point(281, 331);
            this.txt_Des.Name = "txt_Des";
            this.txt_Des.Size = new System.Drawing.Size(320, 23);
            this.txt_Des.TabIndex = 5;
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(281, 240);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(320, 23);
            this.txt_Price.TabIndex = 6;
            // 
            // txt_FName
            // 
            this.txt_FName.Location = new System.Drawing.Point(281, 160);
            this.txt_FName.Name = "txt_FName";
            this.txt_FName.Size = new System.Drawing.Size(320, 23);
            this.txt_FName.TabIndex = 7;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Add.Location = new System.Drawing.Point(245, 537);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 31);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Exit.Location = new System.Drawing.Point(513, 537);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 31);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.Text = "Cancel";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lb_Cate
            // 
            this.lb_Cate.AutoSize = true;
            this.lb_Cate.Location = new System.Drawing.Point(192, 439);
            this.lb_Cate.Name = "lb_Cate";
            this.lb_Cate.Size = new System.Drawing.Size(58, 15);
            this.lb_Cate.TabIndex = 10;
            this.lb_Cate.Text = "Category:";
            // 
            // frmFAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(858, 695);
            this.Controls.Add(this.lb_Cate);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_FName);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.txt_Des);
            this.Controls.Add(this.txt_Cate);
            this.Controls.Add(this.lb_Descrip);
            this.Controls.Add(this.lb_Price);
            this.Controls.Add(this.lb_FName);
            this.Controls.Add(this.lb_Tieude);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "frmFAdd";
            this.Text = "frmFAdd";
            this.Load += new System.EventHandler(this.frmFAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_Tieude;
        private Label lb_FName;
        private Label lb_Price;
        private Label lb_Descrip;
        private TextBox txt_Cate;
        private TextBox txt_Des;
        private TextBox txt_Price;
        private TextBox txt_FName;
        private Button btn_Add;
        private Button btn_Exit;
        private Label lb_Cate;
    }
}