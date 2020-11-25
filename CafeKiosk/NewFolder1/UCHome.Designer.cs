
namespace CafeKiosk
{
    partial class UCHome
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNoTakeOut = new System.Windows.Forms.Button();
            this.bntTakeout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Wheat;
            this.label1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(95, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "포장 하시겠습니까?";
            // 
            // btnNoTakeOut
            // 
            this.btnNoTakeOut.BackColor = System.Drawing.Color.Wheat;
            this.btnNoTakeOut.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNoTakeOut.Location = new System.Drawing.Point(217, 240);
            this.btnNoTakeOut.Name = "btnNoTakeOut";
            this.btnNoTakeOut.Size = new System.Drawing.Size(134, 163);
            this.btnNoTakeOut.TabIndex = 4;
            this.btnNoTakeOut.Text = "포장 안함";
            this.btnNoTakeOut.UseVisualStyleBackColor = false;
            this.btnNoTakeOut.Click += new System.EventHandler(this.btnNoTakeOut_Click);
            // 
            // bntTakeout
            // 
            this.bntTakeout.BackColor = System.Drawing.Color.Wheat;
            this.bntTakeout.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bntTakeout.Location = new System.Drawing.Point(37, 240);
            this.bntTakeout.Name = "bntTakeout";
            this.bntTakeout.Size = new System.Drawing.Size(134, 163);
            this.bntTakeout.TabIndex = 3;
            this.bntTakeout.Text = "포장";
            this.bntTakeout.UseVisualStyleBackColor = false;
            this.bntTakeout.Click += new System.EventHandler(this.bntTakeout_Click);
            // 
            // UCHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNoTakeOut);
            this.Controls.Add(this.bntTakeout);
            this.Name = "UCHome";
            this.Size = new System.Drawing.Size(389, 575);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNoTakeOut;
        private System.Windows.Forms.Button bntTakeout;
    }
}
