namespace CafeKiosk
{
    partial class UCCoffee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCoffee));
            this.btnEspresso = new System.Windows.Forms.PictureBox();
            this.btnAme = new System.Windows.Forms.PictureBox();
            this.btnMoc = new System.Windows.Forms.PictureBox();
            this.btnCara = new System.Windows.Forms.PictureBox();
            this.btnDol = new System.Windows.Forms.PictureBox();
            this.btnLatte = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnEspresso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLatte)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEspresso
            // 
            this.btnEspresso.Image = ((System.Drawing.Image)(resources.GetObject("btnEspresso.Image")));
            this.btnEspresso.Location = new System.Drawing.Point(35, 42);
            this.btnEspresso.Name = "btnEspresso";
            this.btnEspresso.Size = new System.Drawing.Size(139, 130);
            this.btnEspresso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEspresso.TabIndex = 0;
            this.btnEspresso.TabStop = false;
            this.btnEspresso.Click += new System.EventHandler(this.btnEspresso_Click);
            // 
            // btnAme
            // 
            this.btnAme.Image = ((System.Drawing.Image)(resources.GetObject("btnAme.Image")));
            this.btnAme.Location = new System.Drawing.Point(212, 42);
            this.btnAme.Name = "btnAme";
            this.btnAme.Size = new System.Drawing.Size(139, 130);
            this.btnAme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAme.TabIndex = 1;
            this.btnAme.TabStop = false;
            this.btnAme.Click += new System.EventHandler(this.btnAme_Click);
            // 
            // btnMoc
            // 
            this.btnMoc.Image = ((System.Drawing.Image)(resources.GetObject("btnMoc.Image")));
            this.btnMoc.Location = new System.Drawing.Point(212, 214);
            this.btnMoc.Name = "btnMoc";
            this.btnMoc.Size = new System.Drawing.Size(139, 130);
            this.btnMoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMoc.TabIndex = 3;
            this.btnMoc.TabStop = false;
            this.btnMoc.Click += new System.EventHandler(this.btnMoc_Click);
            // 
            // btnCara
            // 
            this.btnCara.Image = ((System.Drawing.Image)(resources.GetObject("btnCara.Image")));
            this.btnCara.Location = new System.Drawing.Point(35, 214);
            this.btnCara.Name = "btnCara";
            this.btnCara.Size = new System.Drawing.Size(139, 130);
            this.btnCara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCara.TabIndex = 2;
            this.btnCara.TabStop = false;
            this.btnCara.Click += new System.EventHandler(this.btnCara_Click);
            // 
            // btnDol
            // 
            this.btnDol.Image = ((System.Drawing.Image)(resources.GetObject("btnDol.Image")));
            this.btnDol.Location = new System.Drawing.Point(212, 394);
            this.btnDol.Name = "btnDol";
            this.btnDol.Size = new System.Drawing.Size(139, 130);
            this.btnDol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDol.TabIndex = 5;
            this.btnDol.TabStop = false;
            this.btnDol.Click += new System.EventHandler(this.btnDol_Click);
            // 
            // btnLatte
            // 
            this.btnLatte.Image = ((System.Drawing.Image)(resources.GetObject("btnLatte.Image")));
            this.btnLatte.Location = new System.Drawing.Point(35, 394);
            this.btnLatte.Name = "btnLatte";
            this.btnLatte.Size = new System.Drawing.Size(139, 130);
            this.btnLatte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLatte.TabIndex = 4;
            this.btnLatte.TabStop = false;
            this.btnLatte.Click += new System.EventHandler(this.btnLatte_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(46, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "에스프레소 2000";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(235, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "아메리카 2000";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(235, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "카페모카 2000";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(32, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "카라멜마끼야또 2000";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(238, 527);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "돌체라떼 2000";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(59, 527);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "카페라떼 2000";
            // 
            // UCCoffee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDol);
            this.Controls.Add(this.btnLatte);
            this.Controls.Add(this.btnMoc);
            this.Controls.Add(this.btnCara);
            this.Controls.Add(this.btnAme);
            this.Controls.Add(this.btnEspresso);
            this.Name = "UCCoffee";
            this.Size = new System.Drawing.Size(389, 575);
            ((System.ComponentModel.ISupportInitialize)(this.btnEspresso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLatte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnEspresso;
        private System.Windows.Forms.PictureBox btnAme;
        private System.Windows.Forms.PictureBox btnMoc;
        private System.Windows.Forms.PictureBox btnCara;
        private System.Windows.Forms.PictureBox btnDol;
        private System.Windows.Forms.PictureBox btnLatte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
