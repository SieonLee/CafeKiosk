
namespace CafeKiosk
{
    partial class UCCartt
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
            this.label = new System.Windows.Forms.Label();
            this.lblIsPack = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.optionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderLineOptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderLineOptionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.Wheat;
            this.label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label.Location = new System.Drawing.Point(79, 44);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(117, 32);
            this.label.TabIndex = 6;
            this.label.Text = "포장 여부";
            // 
            // lblIsPack
            // 
            this.lblIsPack.BackColor = System.Drawing.Color.Wheat;
            this.lblIsPack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIsPack.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblIsPack.Location = new System.Drawing.Point(219, 44);
            this.lblIsPack.Name = "lblIsPack";
            this.lblIsPack.Size = new System.Drawing.Size(117, 32);
            this.lblIsPack.TabIndex = 7;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.BackColor = System.Drawing.Color.Wheat;
            this.lblTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalPrice.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTotalPrice.Location = new System.Drawing.Point(301, 572);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(117, 32);
            this.lblTotalPrice.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.optionNameDataGridViewTextBoxColumn,
            this.menuNameDataGridViewTextBoxColumn,
            this.menuPriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderLineOptionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 108);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(408, 445);
            this.dataGridView1.TabIndex = 9;
            // 
            // optionNameDataGridViewTextBoxColumn
            // 
            this.optionNameDataGridViewTextBoxColumn.DataPropertyName = "OptionName";
            this.optionNameDataGridViewTextBoxColumn.HeaderText = "OptionName";
            this.optionNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.optionNameDataGridViewTextBoxColumn.Name = "optionNameDataGridViewTextBoxColumn";
            this.optionNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // menuNameDataGridViewTextBoxColumn
            // 
            this.menuNameDataGridViewTextBoxColumn.DataPropertyName = "MenuName";
            this.menuNameDataGridViewTextBoxColumn.HeaderText = "MenuName";
            this.menuNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.menuNameDataGridViewTextBoxColumn.Name = "menuNameDataGridViewTextBoxColumn";
            this.menuNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // menuPriceDataGridViewTextBoxColumn
            // 
            this.menuPriceDataGridViewTextBoxColumn.DataPropertyName = "MenuPrice";
            this.menuPriceDataGridViewTextBoxColumn.HeaderText = "MenuPrice";
            this.menuPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.menuPriceDataGridViewTextBoxColumn.Name = "menuPriceDataGridViewTextBoxColumn";
            this.menuPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderLineOptionBindingSource
            // 
            this.orderLineOptionBindingSource.DataSource = typeof(CafeKiosk.Data.OrderLineOption);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(176, 574);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "총 금액 : ";
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(219, 638);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(91, 39);
            this.btnPrev.TabIndex = 11;
            this.btnPrev.Text = "이전화면";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(327, 638);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(91, 39);
            this.btnCheckOut.TabIndex = 12;
            this.btnCheckOut.Text = "결제";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // UCCartt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblIsPack);
            this.Controls.Add(this.label);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCCartt";
            this.Size = new System.Drawing.Size(445, 719);
            this.Load += new System.EventHandler(this.UCCartt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderLineOptionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblIsPack;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.BindingSource orderLineOptionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn optionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuPriceDataGridViewTextBoxColumn;
    }
}
