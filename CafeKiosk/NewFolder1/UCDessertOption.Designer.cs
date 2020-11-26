namespace CafeKiosk
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
            this.btnFork = new System.Windows.Forms.Button();
            this.btnIcecream = new System.Windows.Forms.Button();
            this.btnWhipMore = new System.Windows.Forms.Button();
            this.btnWhipLess = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnCountUp = new System.Windows.Forms.Button();
            this.btnCountDwn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnToCart = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFork
            // 
            this.btnFork.Location = new System.Drawing.Point(131, 521);
            this.btnFork.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFork.Name = "btnFork";
            this.btnFork.Size = new System.Drawing.Size(86, 29);
            this.btnFork.TabIndex = 23;
            this.btnFork.Text = "포크";
            this.btnFork.UseVisualStyleBackColor = true;
            // 
            // btnIcecream
            // 
            this.btnIcecream.Location = new System.Drawing.Point(131, 454);
            this.btnIcecream.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIcecream.Name = "btnIcecream";
            this.btnIcecream.Size = new System.Drawing.Size(143, 29);
            this.btnIcecream.TabIndex = 22;
            this.btnIcecream.Text = "아이스크림 추가";
            this.btnIcecream.UseVisualStyleBackColor = true;
            // 
            // btnWhipMore
            // 
            this.btnWhipMore.Location = new System.Drawing.Point(280, 384);
            this.btnWhipMore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnWhipMore.Name = "btnWhipMore";
            this.btnWhipMore.Size = new System.Drawing.Size(86, 29);
            this.btnWhipMore.TabIndex = 21;
            this.btnWhipMore.Text = "휘핑 많이";
            this.btnWhipMore.UseVisualStyleBackColor = true;
            // 
            // btnWhipLess
            // 
            this.btnWhipLess.Location = new System.Drawing.Point(131, 384);
            this.btnWhipLess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnWhipLess.Name = "btnWhipLess";
            this.btnWhipLess.Size = new System.Drawing.Size(86, 29);
            this.btnWhipLess.TabIndex = 20;
            this.btnWhipLess.Text = "휘핑 적게";
            this.btnWhipLess.UseVisualStyleBackColor = true;
            // 
            // lblQuantity
            // 
            this.lblQuantity.Location = new System.Drawing.Point(223, 276);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(55, 31);
            this.lblQuantity.TabIndex = 17;
            this.lblQuantity.Text = "1";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCountUp
            // 
            this.btnCountUp.Location = new System.Drawing.Point(280, 278);
            this.btnCountUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCountUp.Name = "btnCountUp";
            this.btnCountUp.Size = new System.Drawing.Size(86, 29);
            this.btnCountUp.TabIndex = 16;
            this.btnCountUp.Text = "+";
            this.btnCountUp.UseVisualStyleBackColor = true;
            this.btnCountUp.Click += new System.EventHandler(this.btnCountUp_Click);
            // 
            // btnCountDwn
            // 
            this.btnCountDwn.Location = new System.Drawing.Point(131, 278);
            this.btnCountDwn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCountDwn.Name = "btnCountDwn";
            this.btnCountDwn.Size = new System.Drawing.Size(86, 29);
            this.btnCountDwn.TabIndex = 15;
            this.btnCountDwn.Text = "-";
            this.btnCountDwn.UseVisualStyleBackColor = true;
            this.btnCountDwn.Click += new System.EventHandler(this.btnCountDwn_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(55, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "옵션";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(55, 284);
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
            // 
            // UCDessertOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnToCart);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnFork);
            this.Controls.Add(this.btnIcecream);
            this.Controls.Add(this.btnWhipMore);
            this.Controls.Add(this.btnWhipLess);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnCountUp);
            this.Controls.Add(this.btnCountDwn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCDessertOption";
            this.Size = new System.Drawing.Size(445, 719);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFork;
        private System.Windows.Forms.Button btnIcecream;
        private System.Windows.Forms.Button btnWhipMore;
        private System.Windows.Forms.Button btnWhipLess;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnCountUp;
        private System.Windows.Forms.Button btnCountDwn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnToCart;
        private System.Windows.Forms.Button btnReturn;
    }
}
