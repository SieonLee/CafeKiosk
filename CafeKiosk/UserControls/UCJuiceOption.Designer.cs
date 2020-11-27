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
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnToCart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIce = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btnTall = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuantity
            // 
            this.lblQuantity.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblQuantity.Font = new System.Drawing.Font("한컴 윤체 L", 9F);
            this.lblQuantity.Location = new System.Drawing.Point(120, 15);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(50, 36);
            this.lblQuantity.TabIndex = 17;
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("한컴 윤체 L", 9F);
            this.btnPlus.Location = new System.Drawing.Point(200, 14);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(50, 36);
            this.btnPlus.TabIndex = 16;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("한컴 윤체 L", 9F);
            this.btnMinus.Location = new System.Drawing.Point(40, 14);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(50, 36);
            this.btnMinus.TabIndex = 15;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("한컴 윤체 L", 9F);
            this.label3.Location = new System.Drawing.Point(38, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "옵션";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("한컴 윤체 L", 9F);
            this.label2.Location = new System.Drawing.Point(38, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "사이즈";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("한컴 윤체 L", 9F);
            this.label1.Location = new System.Drawing.Point(38, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "수량";
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("한컴 윤체 L", 9F);
            this.btnReturn.Location = new System.Drawing.Point(114, 510);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(113, 36);
            this.btnReturn.TabIndex = 21;
            this.btnReturn.Text = "이전 화면";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnToCart
            // 
            this.btnToCart.Font = new System.Drawing.Font("한컴 윤체 L", 9F);
            this.btnToCart.Location = new System.Drawing.Point(273, 510);
            this.btnToCart.Name = "btnToCart";
            this.btnToCart.Size = new System.Drawing.Size(131, 36);
            this.btnToCart.TabIndex = 22;
            this.btnToCart.Text = "장바구니 담기";
            this.btnToCart.UseVisualStyleBackColor = true;
            this.btnToCart.Click += new System.EventHandler(this.btnToCart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIce);
            this.groupBox1.Location = new System.Drawing.Point(114, 282);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 55);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // btnIce
            // 
            this.btnIce.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnIce.Font = new System.Drawing.Font("한컴 윤체 L", 9F);
            this.btnIce.Location = new System.Drawing.Point(40, 12);
            this.btnIce.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIce.Name = "btnIce";
            this.btnIce.Size = new System.Drawing.Size(82, 36);
            this.btnIce.TabIndex = 26;
            this.btnIce.TabStop = true;
            this.btnIce.Text = "아이스";
            this.btnIce.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIce.UseVisualStyleBackColor = true;
            this.btnIce.CheckedChanged += new System.EventHandler(this.btnIce_CheckedChanged);
            this.btnIce.Click += new System.EventHandler(this.btnIce_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.btnTall);
            this.groupBox3.Location = new System.Drawing.Point(114, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 55);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton2.Font = new System.Drawing.Font("한컴 윤체 L", 9F);
            this.radioButton2.Location = new System.Drawing.Point(168, 13);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(82, 36);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "그란데";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btnTall
            // 
            this.btnTall.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnTall.Font = new System.Drawing.Font("한컴 윤체 L", 9F);
            this.btnTall.Location = new System.Drawing.Point(40, 13);
            this.btnTall.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTall.Name = "btnTall";
            this.btnTall.Size = new System.Drawing.Size(82, 36);
            this.btnTall.TabIndex = 20;
            this.btnTall.TabStop = true;
            this.btnTall.Text = "톨";
            this.btnTall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTall.UseVisualStyleBackColor = true;
            this.btnTall.CheckedChanged += new System.EventHandler(this.btnTall_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMinus);
            this.groupBox2.Controls.Add(this.btnPlus);
            this.groupBox2.Controls.Add(this.lblQuantity);
            this.groupBox2.Location = new System.Drawing.Point(114, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 55);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // UCJuiceOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnToCart);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCJuiceOption";
            this.Size = new System.Drawing.Size(445, 719);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.RadioButton btnTall;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton btnIce;
    }
}
