namespace QuanLy_QuanAn
{
    partial class frmManagement
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
            this.button4 = new System.Windows.Forms.Button();
            this.dgvFoodList = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txt_Cate = new System.Windows.Forms.TextBox();
            this.txt_Desc = new System.Windows.Forms.TextBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_FName = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lb_Cate = new System.Windows.Forms.Label();
            this.lb_Description = new System.Windows.Forms.Label();
            this.lb_Price = new System.Windows.Forms.Label();
            this.lb_FName = new System.Windows.Forms.Label();
            this.lb_ID = new System.Windows.Forms.Label();
            this.lb_Tieude = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.lb_Search = new System.Windows.Forms.Label();
            this.cbo_Search = new System.Windows.Forms.ComboBox();
            this.btn_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button4.Location = new System.Drawing.Point(879, 491);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 48;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgvFoodList
            // 
            this.dgvFoodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodList.Location = new System.Drawing.Point(32, 348);
            this.dgvFoodList.Name = "dgvFoodList";
            this.dgvFoodList.ReadOnly = true;
            this.dgvFoodList.RowHeadersWidth = 62;
            this.dgvFoodList.RowTemplate.Height = 25;
            this.dgvFoodList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoodList.Size = new System.Drawing.Size(731, 216);
            this.dgvFoodList.TabIndex = 47;
            this.dgvFoodList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFoodList_CellDoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDelete.Location = new System.Drawing.Point(729, 300);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 46;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNew.Location = new System.Drawing.Point(505, 300);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 45;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLoad.Location = new System.Drawing.Point(274, 300);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 44;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txt_Cate
            // 
            this.txt_Cate.Location = new System.Drawing.Point(682, 207);
            this.txt_Cate.Name = "txt_Cate";
            this.txt_Cate.Size = new System.Drawing.Size(272, 23);
            this.txt_Cate.TabIndex = 43;
            // 
            // txt_Desc
            // 
            this.txt_Desc.Location = new System.Drawing.Point(682, 134);
            this.txt_Desc.Name = "txt_Desc";
            this.txt_Desc.Size = new System.Drawing.Size(272, 23);
            this.txt_Desc.TabIndex = 42;
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(220, 238);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(255, 23);
            this.txt_Price.TabIndex = 41;
            // 
            // txt_FName
            // 
            this.txt_FName.Location = new System.Drawing.Point(220, 183);
            this.txt_FName.Name = "txt_FName";
            this.txt_FName.Size = new System.Drawing.Size(255, 23);
            this.txt_FName.TabIndex = 40;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(220, 129);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(255, 23);
            this.txt_ID.TabIndex = 39;
            // 
            // lb_Cate
            // 
            this.lb_Cate.AutoSize = true;
            this.lb_Cate.Location = new System.Drawing.Point(584, 215);
            this.lb_Cate.Name = "lb_Cate";
            this.lb_Cate.Size = new System.Drawing.Size(58, 15);
            this.lb_Cate.TabIndex = 38;
            this.lb_Cate.Text = "Category:";
            // 
            // lb_Description
            // 
            this.lb_Description.AutoSize = true;
            this.lb_Description.Location = new System.Drawing.Point(584, 142);
            this.lb_Description.Name = "lb_Description";
            this.lb_Description.Size = new System.Drawing.Size(70, 15);
            this.lb_Description.TabIndex = 37;
            this.lb_Description.Text = "Description:";
            // 
            // lb_Price
            // 
            this.lb_Price.AutoSize = true;
            this.lb_Price.Location = new System.Drawing.Point(138, 241);
            this.lb_Price.Name = "lb_Price";
            this.lb_Price.Size = new System.Drawing.Size(36, 15);
            this.lb_Price.TabIndex = 36;
            this.lb_Price.Text = "Price:";
            // 
            // lb_FName
            // 
            this.lb_FName.AutoSize = true;
            this.lb_FName.Location = new System.Drawing.Point(117, 186);
            this.lb_FName.Name = "lb_FName";
            this.lb_FName.Size = new System.Drawing.Size(72, 15);
            this.lb_FName.TabIndex = 35;
            this.lb_FName.Text = "Food Name:";
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.Location = new System.Drawing.Point(138, 132);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(51, 15);
            this.lb_ID.TabIndex = 34;
            this.lb_ID.Text = "Food ID:";
            // 
            // lb_Tieude
            // 
            this.lb_Tieude.AutoSize = true;
            this.lb_Tieude.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lb_Tieude.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Tieude.Location = new System.Drawing.Point(398, 9);
            this.lb_Tieude.Name = "lb_Tieude";
            this.lb_Tieude.Size = new System.Drawing.Size(295, 42);
            this.lb_Tieude.TabIndex = 49;
            this.lb_Tieude.Text = "Management Food";
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Update.Location = new System.Drawing.Point(879, 420);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 50;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.Location = new System.Drawing.Point(257, 86);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(75, 15);
            this.lb_Search.TabIndex = 51;
            this.lb_Search.Text = "Search Food:";
            // 
            // cbo_Search
            // 
            this.cbo_Search.FormattingEnabled = true;
            this.cbo_Search.Location = new System.Drawing.Point(366, 82);
            this.cbo_Search.Name = "cbo_Search";
            this.cbo_Search.Size = new System.Drawing.Size(352, 23);
            this.cbo_Search.TabIndex = 52;
            this.cbo_Search.SelectedIndexChanged += new System.EventHandler(this.cbo_Search_SelectedIndexChanged);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Search.Location = new System.Drawing.Point(761, 82);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 53;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // frmManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1047, 602);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.cbo_Search);
            this.Controls.Add(this.lb_Search);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.lb_Tieude);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dgvFoodList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txt_Cate);
            this.Controls.Add(this.txt_Desc);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.txt_FName);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.lb_Cate);
            this.Controls.Add(this.lb_Description);
            this.Controls.Add(this.lb_Price);
            this.Controls.Add(this.lb_FName);
            this.Controls.Add(this.lb_ID);
            this.Name = "frmManagement";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button4;
        private DataGridView dgvFoodList;
        private Button btnDelete;
        private Button btnNew;
        private Button btnLoad;
        private TextBox txt_Cate;
        private TextBox txt_Desc;
        private TextBox txt_Price;
        private TextBox txt_FName;
        private TextBox txt_ID;
        private Label lb_Cate;
        private Label lb_Description;
        private Label lb_Price;
        private Label lb_FName;
        private Label lb_ID;
        private Label lb_Tieude;
        private Button btn_Update;
        private Label lb_Search;
        private ComboBox cbo_Search;
        private Button btn_Search;
    }
}