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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSyrup = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnWhip = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnHot = new System.Windows.Forms.RadioButton();
            this.btnIce = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGrande = new System.Windows.Forms.RadioButton();
            this.btnTall = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnToCart = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSyrup);
            this.groupBox2.Location = new System.Drawing.Point(230, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 57);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            // 
            // btnSyrup
            // 
            this.btnSyrup.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnSyrup.Location = new System.Drawing.Point(35, 20);
            this.btnSyrup.Name = "btnSyrup";
            this.btnSyrup.Size = new System.Drawing.Size(84, 22);
            this.btnSyrup.TabIndex = 0;
            this.btnSyrup.TabStop = true;
            this.btnSyrup.Text = "시럽 추가";
            this.btnSyrup.UseVisualStyleBackColor = true;
            this.btnSyrup.CheckedChanged += new System.EventHandler(this.btnSyrup_CheckedChanged);
            this.btnSyrup.Click += new System.EventHandler(this.btnSyrup_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnWhip);
            this.groupBox1.Location = new System.Drawing.Point(82, 320);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 57);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            // 
            // btnWhip
            // 
            this.btnWhip.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnWhip.Location = new System.Drawing.Point(35, 20);
            this.btnWhip.Name = "btnWhip";
            this.btnWhip.Size = new System.Drawing.Size(84, 22);
            this.btnWhip.TabIndex = 0;
            this.btnWhip.TabStop = true;
            this.btnWhip.Text = "휘핑 추가";
            this.btnWhip.UseVisualStyleBackColor = true;
            this.btnWhip.CheckedChanged += new System.EventHandler(this.btnWhip_CheckedChanged);
            this.btnWhip.Click += new System.EventHandler(this.btnWhip_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnHot);
            this.groupBox3.Controls.Add(this.btnIce);
            this.groupBox3.Location = new System.Drawing.Point(82, 255);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 59);
            this.groupBox3.TabIndex = 62;
            this.groupBox3.TabStop = false;
            // 
            // btnHot
            // 
            this.btnHot.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnHot.Location = new System.Drawing.Point(180, 20);
            this.btnHot.Name = "btnHot";
            this.btnHot.Size = new System.Drawing.Size(84, 22);
            this.btnHot.TabIndex = 3;
            this.btnHot.TabStop = true;
            this.btnHot.Text = "핫";
            this.btnHot.UseVisualStyleBackColor = true;
            this.btnHot.Click += new System.EventHandler(this.btnHot_CheckedChanged);
            // 
            // btnIce
            // 
            this.btnIce.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnIce.Location = new System.Drawing.Point(26, 20);
            this.btnIce.Name = "btnIce";
            this.btnIce.Size = new System.Drawing.Size(84, 22);
            this.btnIce.TabIndex = 2;
            this.btnIce.TabStop = true;
            this.btnIce.Text = "아이스";
            this.btnIce.UseVisualStyleBackColor = true;
            this.btnIce.Click += new System.EventHandler(this.btnIce_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnGrande);
            this.groupBox4.Controls.Add(this.btnTall);
            this.groupBox4.Location = new System.Drawing.Point(82, 201);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(283, 48);
            this.groupBox4.TabIndex = 61;
            this.groupBox4.TabStop = false;
            // 
            // btnGrande
            // 
            this.btnGrande.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnGrande.Location = new System.Drawing.Point(180, 15);
            this.btnGrande.Name = "btnGrande";
            this.btnGrande.Size = new System.Drawing.Size(84, 22);
            this.btnGrande.TabIndex = 1;
            this.btnGrande.TabStop = true;
            this.btnGrande.Text = "그란데";
            this.btnGrande.UseVisualStyleBackColor = true;
            this.btnGrande.Click += new System.EventHandler(this.btnGrande_CheckedChanged);
            // 
            // btnTall
            // 
            this.btnTall.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnTall.Location = new System.Drawing.Point(26, 15);
            this.btnTall.Name = "btnTall";
            this.btnTall.Size = new System.Drawing.Size(84, 22);
            this.btnTall.TabIndex = 0;
            this.btnTall.TabStop = true;
            this.btnTall.Text = "톨";
            this.btnTall.UseVisualStyleBackColor = true;
            this.btnTall.Click += new System.EventHandler(this.btnTall_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(24, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 23);
            this.label3.TabIndex = 55;
            this.label3.Text = "옵션";
            // 
            // btnToCart
            // 
            this.btnToCart.Location = new System.Drawing.Point(262, 408);
            this.btnToCart.Name = "btnToCart";
            this.btnToCart.Size = new System.Drawing.Size(92, 23);
            this.btnToCart.TabIndex = 60;
            this.btnToCart.Text = "장바구니 담기";
            this.btnToCart.UseVisualStyleBackColor = true;
            this.btnToCart.Click += new System.EventHandler(this.btnToCart_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(149, 408);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 59;
            this.btnReturn.Text = "이전 화면";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblQuantity.Location = new System.Drawing.Point(203, 144);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(48, 25);
            this.lblQuantity.TabIndex = 58;
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(262, 145);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(84, 23);
            this.btnPlus.TabIndex = 57;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(108, 145);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(84, 23);
            this.btnMinus.TabIndex = 56;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 53;
            this.label1.Text = "수량";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(24, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 54;
            this.label2.Text = "사이즈";
            // 
            // UCCoffeeOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnToCart);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Name = "UCCoffeeOption";
            this.Size = new System.Drawing.Size(389, 575);
            this.DpiChangedBeforeParent += new System.EventHandler(this.btnReturn_Click);
            this.DpiChangedAfterParent += new System.EventHandler(this.btnReturn_Click);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton btnSyrup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btnWhip;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton btnHot;
        private System.Windows.Forms.RadioButton btnIce;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton btnGrande;
        private System.Windows.Forms.RadioButton btnTall;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnToCart;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
