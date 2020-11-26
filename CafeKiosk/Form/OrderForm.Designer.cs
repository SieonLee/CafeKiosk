namespace CafeKiosk
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.panelslide = new System.Windows.Forms.Panel();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnDessert = new System.Windows.Forms.Button();
            this.btnJuice = new System.Windows.Forms.Button();
            this.btnCoffee = new System.Windows.Forms.Button();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTop.BackgroundImage")));
            this.panelTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(501, 99);
            this.panelTop.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Wheat;
            this.panelLeft.Controls.Add(this.btnStart);
            this.panelLeft.Controls.Add(this.panelslide);
            this.panelLeft.Controls.Add(this.btnCart);
            this.panelLeft.Controls.Add(this.btnDessert);
            this.panelLeft.Controls.Add(this.btnJuice);
            this.panelLeft.Controls.Add(this.btnCoffee);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 99);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(112, 575);
            this.panelLeft.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.OldLace;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.OldLace;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.Location = new System.Drawing.Point(12, 73);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 38);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "시작";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panelslide
            // 
            this.panelslide.BackColor = System.Drawing.Color.DarkOrange;
            this.panelslide.Location = new System.Drawing.Point(0, 73);
            this.panelslide.Name = "panelslide";
            this.panelslide.Size = new System.Drawing.Size(17, 38);
            this.panelslide.TabIndex = 0;
            // 
            // btnCart
            // 
            this.btnCart.BackColor = System.Drawing.Color.OldLace;
            this.btnCart.FlatAppearance.BorderColor = System.Drawing.Color.OldLace;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Location = new System.Drawing.Point(12, 424);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(100, 38);
            this.btnCart.TabIndex = 5;
            this.btnCart.Text = "장바구니";
            this.btnCart.UseVisualStyleBackColor = false;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnDessert
            // 
            this.btnDessert.BackColor = System.Drawing.Color.OldLace;
            this.btnDessert.FlatAppearance.BorderColor = System.Drawing.Color.OldLace;
            this.btnDessert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDessert.Location = new System.Drawing.Point(12, 326);
            this.btnDessert.Name = "btnDessert";
            this.btnDessert.Size = new System.Drawing.Size(100, 38);
            this.btnDessert.TabIndex = 4;
            this.btnDessert.Text = "디저트";
            this.btnDessert.UseVisualStyleBackColor = false;
            this.btnDessert.Click += new System.EventHandler(this.btnDessert_Click);
            // 
            // btnJuice
            // 
            this.btnJuice.BackColor = System.Drawing.Color.OldLace;
            this.btnJuice.FlatAppearance.BorderColor = System.Drawing.Color.OldLace;
            this.btnJuice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJuice.Location = new System.Drawing.Point(12, 241);
            this.btnJuice.Name = "btnJuice";
            this.btnJuice.Size = new System.Drawing.Size(100, 38);
            this.btnJuice.TabIndex = 3;
            this.btnJuice.Text = "쥬스";
            this.btnJuice.UseVisualStyleBackColor = false;
            this.btnJuice.Click += new System.EventHandler(this.btnJuice_Click);
            // 
            // btnCoffee
            // 
            this.btnCoffee.BackColor = System.Drawing.Color.OldLace;
            this.btnCoffee.FlatAppearance.BorderColor = System.Drawing.Color.OldLace;
            this.btnCoffee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoffee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCoffee.Location = new System.Drawing.Point(12, 158);
            this.btnCoffee.Name = "btnCoffee";
            this.btnCoffee.Size = new System.Drawing.Size(100, 38);
            this.btnCoffee.TabIndex = 2;
            this.btnCoffee.Text = "커피";
            this.btnCoffee.UseVisualStyleBackColor = false;
            this.btnCoffee.Click += new System.EventHandler(this.btnCoffee_Click);
            // 
            // panelCenter
            // 
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelCenter.Location = new System.Drawing.Point(112, 99);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(389, 575);
            this.panelCenter.TabIndex = 0;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(501, 674);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.panelLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnDessert;
        private System.Windows.Forms.Button btnJuice;
        private System.Windows.Forms.Button btnCoffee;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Panel panelslide;
        private System.Windows.Forms.Button btnStart;
    }
}