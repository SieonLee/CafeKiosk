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
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnToCart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIce
            // 
            this.btnIce.Location = new System.Drawing.Point(31, 20);
            this.btnIce.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIce.Name = "btnIce";
            this.btnIce.Size = new System.Drawing.Size(86, 29);
            this.btnIce.TabIndex = 20;
            this.btnIce.Text = "얼음";
            this.btnIce.UseVisualStyleBackColor = true;
            // 
            // btnGrande
            // 
            this.btnGrande.Location = new System.Drawing.Point(173, 19);
            this.btnGrande.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGrande.Name = "btnGrande";
            this.btnGrande.Size = new System.Drawing.Size(86, 29);
            this.btnGrande.TabIndex = 19;
            this.btnGrande.Text = "그란데";
            this.btnGrande.UseVisualStyleBackColor = true;
            // 
            // btnTall
            // 
            this.btnTall.Location = new System.Drawing.Point(31, 19);
            this.btnTall.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTall.Name = "btnTall";
            this.btnTall.Size = new System.Drawing.Size(86, 29);
            this.btnTall.TabIndex = 18;
            this.btnTall.Text = "톨";
            this.btnTall.UseVisualStyleBackColor = true;
            this.btnTall.Click += new System.EventHandler(this.btnTall_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.Location = new System.Drawing.Point(135, 27);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(27, 25);
            this.lblQuantity.TabIndex = 17;
            this.lblQuantity.Text = "1";
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(173, 25);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(86, 29);
            this.btnPlus.TabIndex = 16;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(31, 25);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(86, 29);
            this.btnMinus.TabIndex = 15;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(38, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "옵션";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(38, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "사이즈";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(38, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "수량";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(161, 627);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(113, 31);
            this.btnReturn.TabIndex = 21;
            this.btnReturn.Text = "이전 화면";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnToCart
            // 
            this.btnToCart.Location = new System.Drawing.Point(290, 627);
            this.btnToCart.Name = "btnToCart";
            this.btnToCart.Size = new System.Drawing.Size(131, 32);
            this.btnToCart.TabIndex = 22;
            this.btnToCart.Text = "장바구니 담기";
            this.btnToCart.UseVisualStyleBackColor = true;
            this.btnToCart.Click += new System.EventHandler(this.btnToCart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIce);
            this.groupBox1.Location = new System.Drawing.Point(130, 350);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 68);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTall);
            this.groupBox3.Controls.Add(this.btnGrande);
            this.groupBox3.Location = new System.Drawing.Point(130, 253);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 68);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMinus);
            this.groupBox2.Controls.Add(this.btnPlus);
            this.groupBox2.Controls.Add(this.lblQuantity);
            this.groupBox2.Location = new System.Drawing.Point(130, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 68);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // UCJuiceOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnToCart);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCJuiceOption";
            this.Size = new System.Drawing.Size(445, 719);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIce;
        private System.Windows.Forms.Button btnGrande;
        private System.Windows.Forms.Button btnTall;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnToCart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
