namespace security_admin
{
    partial class carTable
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_del = new System.Windows.Forms.Button();
            this.CarTable1 = new System.Windows.Forms.DataGridView();
            this.idx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.license_plate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entry_space = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_insert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.FaceID = new System.Windows.Forms.PictureBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.CarTable2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Enrty_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exit_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CarTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FaceID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarTable2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("돋움체", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "등록차량 조회";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("돋움체", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(453, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "입출차기록";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_del
            // 
            this.btn_del.Font = new System.Drawing.Font("돋움체", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_del.Location = new System.Drawing.Point(350, 19);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(86, 23);
            this.btn_del.TabIndex = 11;
            this.btn_del.Text = "차량삭제";
            this.btn_del.UseMnemonic = false;
            this.btn_del.UseVisualStyleBackColor = true;
            // 
            // CarTable1
            // 
            this.CarTable1.AllowUserToAddRows = false;
            this.CarTable1.AllowUserToDeleteRows = false;
            this.CarTable1.AllowUserToOrderColumns = true;
            this.CarTable1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarTable1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idx,
            this.license_plate,
            this.Entry_space});
            this.CarTable1.Location = new System.Drawing.Point(12, 50);
            this.CarTable1.Name = "CarTable1";
            this.CarTable1.ReadOnly = true;
            this.CarTable1.RowTemplate.Height = 32;
            this.CarTable1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CarTable1.Size = new System.Drawing.Size(348, 241);
            this.CarTable1.TabIndex = 10;
            this.CarTable1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CarTable_CellClick);
            // 
            // idx
            // 
            this.idx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idx.HeaderText = "No.";
            this.idx.Name = "idx";
            this.idx.ReadOnly = true;
            this.idx.Width = 50;
            // 
            // license_plate
            // 
            this.license_plate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.license_plate.HeaderText = "등록차 번호판";
            this.license_plate.Name = "license_plate";
            this.license_plate.ReadOnly = true;
            // 
            // Entry_space
            // 
            this.Entry_space.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Entry_space.HeaderText = "주차구역";
            this.Entry_space.Name = "Entry_space";
            this.Entry_space.ReadOnly = true;
            this.Entry_space.Width = 78;
            // 
            // btn_insert
            // 
            this.btn_insert.Font = new System.Drawing.Font("돋움체", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_insert.Location = new System.Drawing.Point(258, 19);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(86, 23);
            this.btn_insert.TabIndex = 15;
            this.btn_insert.Text = "차량등록";
            this.btn_insert.UseMnemonic = false;
            this.btn_insert.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("돋움체", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(759, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Face ID";
            // 
            // FaceID
            // 
            this.FaceID.Location = new System.Drawing.Point(763, 26);
            this.FaceID.Name = "FaceID";
            this.FaceID.Size = new System.Drawing.Size(444, 276);
            this.FaceID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FaceID.TabIndex = 17;
            this.FaceID.TabStop = false;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("돋움체", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_search.Location = new System.Drawing.Point(166, 19);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(86, 23);
            this.btn_search.TabIndex = 18;
            this.btn_search.Text = "전체조회";
            this.btn_search.UseMnemonic = false;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // CarTable2
            // 
            this.CarTable2.AllowUserToAddRows = false;
            this.CarTable2.AllowUserToDeleteRows = false;
            this.CarTable2.AllowUserToOrderColumns = true;
            this.CarTable2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarTable2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Enrty_time,
            this.Exit_time});
            this.CarTable2.Location = new System.Drawing.Point(366, 50);
            this.CarTable2.Name = "CarTable2";
            this.CarTable2.ReadOnly = true;
            this.CarTable2.RowTemplate.Height = 23;
            this.CarTable2.Size = new System.Drawing.Size(391, 241);
            this.CarTable2.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.HeaderText = "idx";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 47;
            // 
            // Enrty_time
            // 
            this.Enrty_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Enrty_time.HeaderText = "입차시간";
            this.Enrty_time.Name = "Enrty_time";
            this.Enrty_time.ReadOnly = true;
            // 
            // Exit_time
            // 
            this.Exit_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Exit_time.HeaderText = "출차시간";
            this.Exit_time.Name = "Exit_time";
            this.Exit_time.ReadOnly = true;
            // 
            // carTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 303);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.FaceID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CarTable2);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.CarTable1);
            this.Location = new System.Drawing.Point(0, 570);
            this.Name = "carTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "carTable";
            this.Deactivate += new System.EventHandler(this.carTable_Deactivate);
            this.Load += new System.EventHandler(this.carTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FaceID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarTable2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_search;
        public System.Windows.Forms.DataGridView CarTable2;
        public System.Windows.Forms.DataGridView CarTable1;
        public System.Windows.Forms.PictureBox FaceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn idx;
        private System.Windows.Forms.DataGridViewTextBoxColumn license_plate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entry_space;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Enrty_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exit_time;
    }
}