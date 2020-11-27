
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCHome));
            this.btnNoTakeOut = new System.Windows.Forms.Button();
            this.bntTakeout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNoTakeOut
            // 
            this.btnNoTakeOut.BackColor = System.Drawing.Color.Goldenrod;
            this.btnNoTakeOut.CausesValidation = false;
            this.btnNoTakeOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNoTakeOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoTakeOut.Font = new System.Drawing.Font("한컴 윤체 M", 12F);
            this.btnNoTakeOut.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnNoTakeOut.Location = new System.Drawing.Point(231, 332);
            this.btnNoTakeOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNoTakeOut.Name = "btnNoTakeOut";
            this.btnNoTakeOut.Size = new System.Drawing.Size(139, 50);
            this.btnNoTakeOut.TabIndex = 4;
            this.btnNoTakeOut.Text = "매장";
            this.btnNoTakeOut.UseVisualStyleBackColor = false;
            this.btnNoTakeOut.Click += new System.EventHandler(this.btnNoTakeOut_Click);
            // 
            // bntTakeout
            // 
            this.bntTakeout.BackColor = System.Drawing.Color.Goldenrod;
            this.bntTakeout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bntTakeout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntTakeout.Font = new System.Drawing.Font("한컴 윤체 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bntTakeout.ForeColor = System.Drawing.Color.SaddleBrown;
            this.bntTakeout.Location = new System.Drawing.Point(72, 332);
            this.bntTakeout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bntTakeout.Name = "bntTakeout";
            this.bntTakeout.Size = new System.Drawing.Size(139, 50);
            this.bntTakeout.TabIndex = 3;
            this.bntTakeout.Text = "포장";
            this.bntTakeout.UseVisualStyleBackColor = false;
            this.bntTakeout.Click += new System.EventHandler(this.bntTakeout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(145, 88);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.OldLace;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("한컴 윤체 L", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBox1.Location = new System.Drawing.Point(172, 221);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(95, 28);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "어서오세요";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.OldLace;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("한컴 윤체 L", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBox2.Location = new System.Drawing.Point(277, 260);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 28);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "를 선택하세요";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.OldLace;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("한컴 윤체 M", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox3.Location = new System.Drawing.Point(43, 254);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(235, 37);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "포장 / 매장이용 여부";
            // 
            // UCHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNoTakeOut);
            this.Controls.Add(this.bntTakeout);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCHome";
            this.Size = new System.Drawing.Size(445, 719);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNoTakeOut;
        private System.Windows.Forms.Button bntTakeout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}
