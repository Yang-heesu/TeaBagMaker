namespace TeaBagMaker
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.cbTea = new System.Windows.Forms.ComboBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // cbTea
            // 
            this.cbTea.FormattingEnabled = true;
            this.cbTea.Location = new System.Drawing.Point(12, 12);
            this.cbTea.Name = "cbTea";
            this.cbTea.Size = new System.Drawing.Size(122, 20);
            this.cbTea.TabIndex = 0;
            this.cbTea.SelectedIndexChanged += new System.EventHandler(this.CbTea_SelectedIndexChanged);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(12, 75);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(38, 12);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "label1";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 38);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(122, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "담그기!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(10, 121);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(125, 12);
            this.info.TabIndex = 3;
            this.info.Text = "2019.05.27 3508양희수";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(143, 142);
            this.Controls.Add(this.info);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.cbTea);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTea;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Timer timer;
    }
}

