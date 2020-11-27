namespace CafeKiosk
{
    partial class UCCoffeeOption
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnToCart = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnHot = new System.Windows.Forms.RadioButton();
            this.btnIce = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btnTall = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnWhip = new System.Windows.Forms.RadioButton();
            this.btnSyrup = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(38, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "수량";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(38, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "사이즈";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(38, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "옵션";
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(40, 20);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(50, 25);
            this.btnMinus.TabIndex = 3;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(200, 20);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(50, 25);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblQuantity.Location = new System.Drawing.Point(120, 21);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(50, 25);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(114, 510);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(113, 31);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "이전 화면";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            this.btnReturn.DpiChangedBeforeParent += new System.EventHandler(this.btnReturn_Click);
            this.btnReturn.DpiChangedAfterParent += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnToCart
            // 
            this.btnToCart.Location = new System.Drawing.Point(272, 510);
            this.btnToCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnToCart.Name = "btnToCart";
            this.btnToCart.Size = new System.Drawing.Size(132, 31);
            this.btnToCart.TabIndex = 13;
            this.btnToCart.Text = "장바구니 담기";
            this.btnToCart.UseVisualStyleBackColor = true;
            this.btnToCart.Click += new System.EventHandler(this.btnToCart_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnHot);
            this.groupBox3.Controls.Add(this.btnIce);
            this.groupBox3.Location = new System.Drawing.Point(114, 282);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(290, 55);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            // 
            // btnHot
            // 
            this.btnHot.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnHot.Location = new System.Drawing.Point(168, 19);
            this.btnHot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHot.Name = "btnHot";
            this.btnHot.Size = new System.Drawing.Size(82, 25);
            this.btnHot.TabIndex = 3;
            this.btnHot.TabStop = true;
            this.btnHot.Text = "핫";
            this.btnHot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHot.UseVisualStyleBackColor = true;
            // 
            // btnIce
            // 
            this.btnIce.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnIce.Location = new System.Drawing.Point(40, 19);
            this.btnIce.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIce.Name = "btnIce";
            this.btnIce.Size = new System.Drawing.Size(82, 25);
            this.btnIce.TabIndex = 2;
            this.btnIce.TabStop = true;
            this.btnIce.Text = "아이스";
            this.btnIce.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIce.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton2);
            this.groupBox4.Controls.Add(this.btnTall);
            this.groupBox4.Location = new System.Drawing.Point(114, 216);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(290, 55);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton2.Location = new System.Drawing.Point(168, 19);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(82, 25);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "그란데";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // btnTall
            // 
            this.btnTall.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnTall.Location = new System.Drawing.Point(40, 19);
            this.btnTall.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTall.Name = "btnTall";
            this.btnTall.Size = new System.Drawing.Size(82, 25);
            this.btnTall.TabIndex = 0;
            this.btnTall.TabStop = true;
            this.btnTall.Text = "톨";
            this.btnTall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTall.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSyrup);
            this.groupBox1.Controls.Add(this.btnWhip);
            this.groupBox1.Location = new System.Drawing.Point(114, 348);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(290, 55);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnWhip
            // 
            this.btnWhip.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnWhip.Location = new System.Drawing.Point(40, 19);
            this.btnWhip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnWhip.Name = "btnWhip";
            this.btnWhip.Size = new System.Drawing.Size(82, 25);
            this.btnWhip.TabIndex = 0;
            this.btnWhip.TabStop = true;
            this.btnWhip.Text = "휘핑 추가";
            this.btnWhip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnWhip.UseVisualStyleBackColor = true;
            this.btnWhip.CheckedChanged += new System.EventHandler(this.btnWhip_CheckedChanged);
            this.btnWhip.Click += new System.EventHandler(this.btnWhip_Click);
            // 
            // btnSyrup
            // 
            this.btnSyrup.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnSyrup.Location = new System.Drawing.Point(168, 19);
            this.btnSyrup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSyrup.Name = "btnSyrup";
            this.btnSyrup.Size = new System.Drawing.Size(82, 25);
            this.btnSyrup.TabIndex = 0;
            this.btnSyrup.TabStop = true;
            this.btnSyrup.Text = "시럽 추가";
            this.btnSyrup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSyrup.UseVisualStyleBackColor = true;
            this.btnSyrup.CheckedChanged += new System.EventHandler(this.btnSyrup_CheckedChanged);
            this.btnSyrup.Click += new System.EventHandler(this.btnSyrup_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblQuantity);
            this.groupBox5.Controls.Add(this.btnMinus);
            this.groupBox5.Controls.Add(this.btnPlus);
            this.groupBox5.Location = new System.Drawing.Point(114, 155);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(290, 55);
            this.groupBox5.TabIndex = 29;
            this.groupBox5.TabStop = false;
            // 
            // UCCoffeeOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnToCart);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox5);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCCoffeeOption";
            this.Size = new System.Drawing.Size(445, 719);
            this.DpiChangedBeforeParent += new System.EventHandler(this.btnReturn_Click);
            this.DpiChangedAfterParent += new System.EventHandler(this.btnReturn_Click);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnToCart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton btnHot;
        private System.Windows.Forms.RadioButton btnIce;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton btnTall;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btnWhip;
        private System.Windows.Forms.RadioButton btnSyrup;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}
