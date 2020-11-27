namespace CafeKiosk
{
    partial class UCJuiceOption
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
            this.btnIce = new System.Windows.Forms.Button();
            this.btnGrande = new System.Windows.Forms.Button();
            this.btnTall = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnToCart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIce
            // 
            this.btnIce.Location = new System.Drawing.Point(140, 195);
            this.btnIce.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIce.Name = "btnIce";
            this.btnIce.Size = new System.Drawing.Size(86, 29);
            this.btnIce.TabIndex = 20;
            this.btnIce.Text = "얼음";
            this.btnIce.UseVisualStyleBackColor = true;
            // 
            // btnGrande
            // 
            this.btnGrande.Location = new System.Drawing.Point(288, 139);
            this.btnGrande.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGrande.Name = "btnGrande";
            this.btnGrande.Size = new System.Drawing.Size(86, 29);
            this.btnGrande.TabIndex = 19;
            this.btnGrande.Text = "그란데";
            this.btnGrande.UseVisualStyleBackColor = true;
            // 
            // btnTall
            // 
            this.btnTall.Location = new System.Drawing.Point(141, 140);
            this.btnTall.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTall.Name = "btnTall";
            this.btnTall.Size = new System.Drawing.Size(86, 29);
            this.btnTall.TabIndex = 18;
            this.btnTall.Text = "톨";
            this.btnTall.UseVisualStyleBackColor = true;
            this.btnTall.Click += new System.EventHandler(this.btnTall_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(249, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 31);
            this.label4.TabIndex = 17;
            this.label4.Text = "1";
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(288, 85);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(86, 29);
            this.btnPlus.TabIndex = 16;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
           
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(141, 85);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(86, 29);
            this.btnMinus.TabIndex = 15;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
           
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(64, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "옵션";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(64, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "사이즈";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(64, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "수량";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(152, 307);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 21;
            this.btnReturn.Text = "돌아가기";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnToCart
            // 
            this.btnToCart.Location = new System.Drawing.Point(288, 307);
            this.btnToCart.Name = "btnToCart";
            this.btnToCart.Size = new System.Drawing.Size(75, 23);
            this.btnToCart.TabIndex = 22;
            this.btnToCart.Text = "장바구니";
            this.btnToCart.UseVisualStyleBackColor = true;
            this.btnToCart.Click += new System.EventHandler(this.btnToCart_Click);
            // 
            // UCJuiceOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnToCart);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnIce);
            this.Controls.Add(this.btnGrande);
            this.Controls.Add(this.btnTall);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCJuiceOption";
            this.Size = new System.Drawing.Size(445, 719);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIce;
        private System.Windows.Forms.Button btnGrande;
        private System.Windows.Forms.Button btnTall;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnToCart;
    }
}
