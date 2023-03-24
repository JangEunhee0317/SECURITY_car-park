namespace security_admin
{
    partial class carImg
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(carImg));
            this.carNo_img = new System.Windows.Forms.PictureBox();
            this.faceId_img = new System.Windows.Forms.PictureBox();
            this.carNo_lb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.time_lb = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_carStat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carNo_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faceId_img)).BeginInit();
            this.SuspendLayout();
            // 
            // carNo_img
            // 
            this.carNo_img.BackColor = System.Drawing.Color.Gainsboro;
            this.carNo_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.carNo_img.Cursor = System.Windows.Forms.Cursors.Default;
            this.carNo_img.Image = ((System.Drawing.Image)(resources.GetObject("carNo_img.Image")));
            this.carNo_img.InitialImage = null;
            this.carNo_img.Location = new System.Drawing.Point(12, 51);
            this.carNo_img.Name = "carNo_img";
            this.carNo_img.Size = new System.Drawing.Size(612, 420);
            this.carNo_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.carNo_img.TabIndex = 8;
            this.carNo_img.TabStop = false;
            // 
            // faceId_img
            // 
            this.faceId_img.BackColor = System.Drawing.Color.Gainsboro;
            this.faceId_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.faceId_img.Cursor = System.Windows.Forms.Cursors.Default;
            this.faceId_img.Image = ((System.Drawing.Image)(resources.GetObject("faceId_img.Image")));
            this.faceId_img.InitialImage = null;
            this.faceId_img.Location = new System.Drawing.Point(630, 51);
            this.faceId_img.Name = "faceId_img";
            this.faceId_img.Size = new System.Drawing.Size(575, 420);
            this.faceId_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.faceId_img.TabIndex = 7;
            this.faceId_img.TabStop = false;
            // 
            // carNo_lb
            // 
            this.carNo_lb.Font = new System.Drawing.Font("돋움체", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.carNo_lb.Location = new System.Drawing.Point(268, 477);
            this.carNo_lb.Name = "carNo_lb";
            this.carNo_lb.Size = new System.Drawing.Size(356, 48);
            this.carNo_lb.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("돋움체", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(21, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 48);
            this.label2.TabIndex = 10;
            this.label2.Text = "방문차량:";
            // 
            // time_lb
            // 
            this.time_lb.AutoSize = true;
            this.time_lb.Font = new System.Drawing.Font("돋움체", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.time_lb.Location = new System.Drawing.Point(12, 9);
            this.time_lb.Name = "time_lb";
            this.time_lb.Size = new System.Drawing.Size(414, 35);
            this.time_lb.TabIndex = 11;
            this.time_lb.Text = "23-03-20 15 : 40 : 10";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_carStat
            // 
            this.label_carStat.Font = new System.Drawing.Font("돋움체", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_carStat.Location = new System.Drawing.Point(753, 477);
            this.label_carStat.Name = "label_carStat";
            this.label_carStat.Size = new System.Drawing.Size(404, 48);
            this.label_carStat.TabIndex = 12;
            this.label_carStat.Text = "상태: 등록차량";
            // 
            // carImg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 531);
            this.Controls.Add(this.label_carStat);
            this.Controls.Add(this.time_lb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.carNo_lb);
            this.Controls.Add(this.carNo_img);
            this.Controls.Add(this.faceId_img);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "carImg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "차량인식";
            this.Load += new System.EventHandler(this.carImg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carNo_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faceId_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label carNo_lb;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label time_lb;
        public System.Windows.Forms.PictureBox carNo_img;
        public System.Windows.Forms.PictureBox faceId_img;
        public System.Windows.Forms.Label label_carStat;
    }
}