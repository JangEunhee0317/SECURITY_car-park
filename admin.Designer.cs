namespace security_admin
{
    partial class admin
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.차량관리MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.영상통화ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.모든창닫기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.차량관리MenuItem,
            this.영상통화ToolStripMenuItem,
            this.모든창닫기ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1230, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 차량관리MenuItem
            // 
            this.차량관리MenuItem.Name = "차량관리MenuItem";
            this.차량관리MenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F1)));
            this.차량관리MenuItem.Size = new System.Drawing.Size(111, 20);
            this.차량관리MenuItem.Text = "차량관리(Alt+F1)";
            this.차량관리MenuItem.Click += new System.EventHandler(this.차량관리ToolStripMenuItem_Click);
            // 
            // 영상통화ToolStripMenuItem
            // 
            this.영상통화ToolStripMenuItem.Name = "영상통화ToolStripMenuItem";
            this.영상통화ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F2)));
            this.영상통화ToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.영상통화ToolStripMenuItem.Text = "영상통화(Alt+F2)";
            this.영상통화ToolStripMenuItem.Click += new System.EventHandler(this.영상통화ToolStripMenuItem_Click);
            // 
            // 모든창닫기ToolStripMenuItem
            // 
            this.모든창닫기ToolStripMenuItem.Name = "모든창닫기ToolStripMenuItem";
            this.모든창닫기ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.모든창닫기ToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.모든창닫기ToolStripMenuItem.Text = "모든 창 닫기(Alt+F4)";
            this.모든창닫기ToolStripMenuItem.Click += new System.EventHandler(this.모든창닫기ToolStripMenuItem_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 941);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "차량관리_관리자";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.admin_Closing);
            this.Load += new System.EventHandler(this.admin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 차량관리MenuItem;
        private System.Windows.Forms.ToolStripMenuItem 영상통화ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 모든창닫기ToolStripMenuItem;
    }
}

