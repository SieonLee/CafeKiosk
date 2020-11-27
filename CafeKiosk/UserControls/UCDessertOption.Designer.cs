﻿namespace CafeKiosk
{
    partial class UCDessertOption
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
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnToCart = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreamMore = new System.Windows.Forms.RadioButton();
            this.btnCreamLess = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddIceC = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddFork = new System.Windows.Forms.RadioButton();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(290, 169);
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
            this.btnMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinus.Location = new System.Drawing.Point(137, 169);
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
            this.label3.Location = new System.Drawing.Point(38, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "옵션";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(38, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "수량";
            // 
            // btnToCart
            // 
            this.btnToCart.Location = new System.Drawing.Point(290, 627);
            this.btnToCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnToCart.Name = "btnToCart";
            this.btnToCart.Size = new System.Drawing.Size(132, 31);
            this.btnToCart.TabIndex = 25;
            this.btnToCart.Text = "장바구니 담기";
            this.btnToCart.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(161, 627);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(113, 31);
            this.btnReturn.TabIndex = 24;
            this.btnReturn.Text = "이전 화면";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreamMore);
            this.groupBox1.Controls.Add(this.btnCreamLess);
            this.groupBox1.Location = new System.Drawing.Point(114, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 68);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // btnCreamMore
            // 
            this.btnCreamMore.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnCreamMore.AutoSize = true;
            this.btnCreamMore.Location = new System.Drawing.Point(172, 25);
            this.btnCreamMore.Name = "btnCreamMore";
            this.btnCreamMore.Size = new System.Drawing.Size(82, 25);
            this.btnCreamMore.TabIndex = 28;
            this.btnCreamMore.TabStop = true;
            this.btnCreamMore.Text = "휘핑 많이";
            this.btnCreamMore.UseVisualStyleBackColor = true;
            this.btnCreamMore.CheckedChanged += new System.EventHandler(this.btnCreamMore_CheckedChanged);
            this.btnCreamMore.Click += new System.EventHandler(this.btnCreamMore_Click);
            // 
            // btnCreamLess
            // 
            this.btnCreamLess.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnCreamLess.AutoSize = true;
            this.btnCreamLess.Location = new System.Drawing.Point(29, 25);
            this.btnCreamLess.Name = "btnCreamLess";
            this.btnCreamLess.Size = new System.Drawing.Size(82, 25);
            this.btnCreamLess.TabIndex = 27;
            this.btnCreamLess.TabStop = true;
            this.btnCreamLess.Text = "휘핑 적게";
            this.btnCreamLess.UseVisualStyleBackColor = true;
            this.btnCreamLess.CheckedChanged += new System.EventHandler(this.btnCreamLess_CheckedChanged);
            this.btnCreamLess.Click += new System.EventHandler(this.btnCreamLess_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddIceC);
            this.groupBox2.Location = new System.Drawing.Point(114, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 68);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // btnAddIceC
            // 
            this.btnAddIceC.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnAddIceC.AutoSize = true;
            this.btnAddIceC.Location = new System.Drawing.Point(29, 25);
            this.btnAddIceC.Name = "btnAddIceC";
            this.btnAddIceC.Size = new System.Drawing.Size(127, 25);
            this.btnAddIceC.TabIndex = 27;
            this.btnAddIceC.TabStop = true;
            this.btnAddIceC.Text = "아이스크림 추가";
            this.btnAddIceC.UseVisualStyleBackColor = true;
            this.btnAddIceC.CheckedChanged += new System.EventHandler(this.btnAddIceC_CheckedChanged);
            this.btnAddIceC.Click += new System.EventHandler(this.btnAddIceC_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddFork);
            this.groupBox3.Location = new System.Drawing.Point(114, 397);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 68);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            // 
            // btnAddFork
            // 
            this.btnAddFork.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnAddFork.AutoSize = true;
            this.btnAddFork.Location = new System.Drawing.Point(29, 25);
            this.btnAddFork.Name = "btnAddFork";
            this.btnAddFork.Size = new System.Drawing.Size(82, 25);
            this.btnAddFork.TabIndex = 27;
            this.btnAddFork.TabStop = true;
            this.btnAddFork.Text = "포크 추가";
            this.btnAddFork.UseVisualStyleBackColor = true;
            this.btnAddFork.CheckedChanged += new System.EventHandler(this.btnAddFork_CheckedChanged);
            this.btnAddFork.Click += new System.EventHandler(this.btnAddFork_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblQuantity.Location = new System.Drawing.Point(229, 167);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(55, 31);
            this.lblQuantity.TabIndex = 28;
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCDessertOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnToCart);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCDessertOption";
            this.Size = new System.Drawing.Size(445, 719);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnToCart;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton btnCreamMore;
        private System.Windows.Forms.RadioButton btnCreamLess;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton btnAddIceC;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton btnAddFork;
        private System.Windows.Forms.Label lblQuantity;
    }
}