namespace WindowsFormsControlLibrary1
{
    partial class UserControl1
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.numExcept = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numCreate = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtExcept = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCreate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numExcept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCreate)).BeginInit();
            this.SuspendLayout();
            // 
            // numExcept
            // 
            this.numExcept.Location = new System.Drawing.Point(115, 26);
            this.numExcept.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numExcept.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numExcept.Name = "numExcept";
            this.numExcept.Size = new System.Drawing.Size(120, 21);
            this.numExcept.TabIndex = 0;
            this.numExcept.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "제외 게임 생성";
            // 
            // numCreate
            // 
            this.numCreate.Location = new System.Drawing.Point(115, 53);
            this.numCreate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCreate.Name = "numCreate";
            this.numCreate.Size = new System.Drawing.Size(120, 21);
            this.numCreate.TabIndex = 2;
            this.numCreate.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "게임 생성";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(267, 25);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(68, 48);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "생성";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // txtExcept
            // 
            this.txtExcept.Location = new System.Drawing.Point(26, 139);
            this.txtExcept.Multiline = true;
            this.txtExcept.Name = "txtExcept";
            this.txtExcept.Size = new System.Drawing.Size(142, 193);
            this.txtExcept.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "제외 게임 생성";
            // 
            // txtCreate
            // 
            this.txtCreate.Location = new System.Drawing.Point(188, 139);
            this.txtCreate.Multiline = true;
            this.txtCreate.Name = "txtCreate";
            this.txtCreate.Size = new System.Drawing.Size(147, 193);
            this.txtCreate.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "게임 생성";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCreate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtExcept);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numCreate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numExcept);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(353, 345);
            ((System.ComponentModel.ISupportInitialize)(this.numExcept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCreate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numExcept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtExcept;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCreate;
        private System.Windows.Forms.Label label4;
    }
}
