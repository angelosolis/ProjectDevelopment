namespace ProjectDevelopment
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.txtBOMNo = new System.Windows.Forms.TextBox();
            this.txtJONo = new System.Windows.Forms.TextBox();
            this.txtPreparedByCode = new System.Windows.Forms.TextBox();
            this.txtApprovedByCode = new System.Windows.Forms.TextBox();
            this.txtReleasedByName = new System.Windows.Forms.TextBox();
            this.txtBOMRequestedByName = new System.Windows.Forms.TextBox();
            this.txtBoMDescription = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBOMQtyOrd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtMaterialCode = new System.Windows.Forms.TextBox();
            this.txtMaterialDescription = new System.Windows.Forms.TextBox();
            this.txtUnitOfMeasure = new System.Windows.Forms.TextBox();
            this.txtQuantityNeeded = new System.Windows.Forms.TextBox();
            this.txtTotalQuantityNeeded = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "BILL OF MATERIALS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Description:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(41, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(623, 193);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValuePushed += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dataGridView1_CellValuePushed);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Material Code";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 97;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Material Description";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Unit of Measure";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 107;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Quantity Needed";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 112;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "Total Quantity Needed";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 139;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Prepared By:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Approved By:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(525, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "BOM No:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(526, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "JO No:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Product Code:";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(133, 76);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(106, 20);
            this.txtProductCode.TabIndex = 3;
            // 
            // txtBOMNo
            // 
            this.txtBOMNo.Location = new System.Drawing.Point(575, 108);
            this.txtBOMNo.Name = "txtBOMNo";
            this.txtBOMNo.Size = new System.Drawing.Size(89, 20);
            this.txtBOMNo.TabIndex = 3;
            // 
            // txtJONo
            // 
            this.txtJONo.Location = new System.Drawing.Point(575, 142);
            this.txtJONo.Name = "txtJONo";
            this.txtJONo.Size = new System.Drawing.Size(89, 20);
            this.txtJONo.TabIndex = 3;
            // 
            // txtPreparedByCode
            // 
            this.txtPreparedByCode.Location = new System.Drawing.Point(125, 377);
            this.txtPreparedByCode.Name = "txtPreparedByCode";
            this.txtPreparedByCode.Size = new System.Drawing.Size(81, 20);
            this.txtPreparedByCode.TabIndex = 3;
            // 
            // txtApprovedByCode
            // 
            this.txtApprovedByCode.Location = new System.Drawing.Point(125, 412);
            this.txtApprovedByCode.Name = "txtApprovedByCode";
            this.txtApprovedByCode.Size = new System.Drawing.Size(81, 20);
            this.txtApprovedByCode.TabIndex = 3;
            // 
            // txtReleasedByName
            // 
            this.txtReleasedByName.Location = new System.Drawing.Point(237, 372);
            this.txtReleasedByName.Name = "txtReleasedByName";
            this.txtReleasedByName.Size = new System.Drawing.Size(81, 20);
            this.txtReleasedByName.TabIndex = 3;
            // 
            // txtBOMRequestedByName
            // 
            this.txtBOMRequestedByName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBOMRequestedByName.Location = new System.Drawing.Point(237, 412);
            this.txtBOMRequestedByName.Name = "txtBOMRequestedByName";
            this.txtBOMRequestedByName.Size = new System.Drawing.Size(81, 20);
            this.txtBOMRequestedByName.TabIndex = 3;
            // 
            // txtBoMDescription
            // 
            this.txtBoMDescription.Location = new System.Drawing.Point(115, 107);
            this.txtBoMDescription.Name = "txtBoMDescription";
            this.txtBoMDescription.Size = new System.Drawing.Size(193, 20);
            this.txtBoMDescription.TabIndex = 3;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(566, 75);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(81, 20);
            this.textBox11.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(234, 395);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(234, 434);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Name:";
            // 
            // txtBOMQtyOrd
            // 
            this.txtBOMQtyOrd.Location = new System.Drawing.Point(133, 142);
            this.txtBOMQtyOrd.Name = "txtBOMQtyOrd";
            this.txtBOMQtyOrd.Size = new System.Drawing.Size(81, 20);
            this.txtBOMQtyOrd.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantity Ordered :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(486, 404);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(589, 404);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // txtMaterialCode
            // 
            this.txtMaterialCode.Location = new System.Drawing.Point(83, 198);
            this.txtMaterialCode.Name = "txtMaterialCode";
            this.txtMaterialCode.Size = new System.Drawing.Size(99, 20);
            this.txtMaterialCode.TabIndex = 3;
            // 
            // txtMaterialDescription
            // 
            this.txtMaterialDescription.Location = new System.Drawing.Point(180, 198);
            this.txtMaterialDescription.Name = "txtMaterialDescription";
            this.txtMaterialDescription.Size = new System.Drawing.Size(128, 20);
            this.txtMaterialDescription.TabIndex = 3;
            // 
            // txtUnitOfMeasure
            // 
            this.txtUnitOfMeasure.Location = new System.Drawing.Point(304, 198);
            this.txtUnitOfMeasure.Name = "txtUnitOfMeasure";
            this.txtUnitOfMeasure.Size = new System.Drawing.Size(110, 20);
            this.txtUnitOfMeasure.TabIndex = 3;
            // 
            // txtQuantityNeeded
            // 
            this.txtQuantityNeeded.Location = new System.Drawing.Point(410, 198);
            this.txtQuantityNeeded.Name = "txtQuantityNeeded";
            this.txtQuantityNeeded.Size = new System.Drawing.Size(115, 20);
            this.txtQuantityNeeded.TabIndex = 3;
            // 
            // txtTotalQuantityNeeded
            // 
            this.txtTotalQuantityNeeded.Location = new System.Drawing.Point(523, 198);
            this.txtTotalQuantityNeeded.Name = "txtTotalQuantityNeeded";
            this.txtTotalQuantityNeeded.Size = new System.Drawing.Size(141, 20);
            this.txtTotalQuantityNeeded.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBOMQtyOrd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoMDescription);
            this.Controls.Add(this.txtTotalQuantityNeeded);
            this.Controls.Add(this.txtQuantityNeeded);
            this.Controls.Add(this.txtUnitOfMeasure);
            this.Controls.Add(this.txtMaterialDescription);
            this.Controls.Add(this.txtMaterialCode);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.txtJONo);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.txtBOMNo);
            this.Controls.Add(this.txtApprovedByCode);
            this.Controls.Add(this.txtBOMRequestedByName);
            this.Controls.Add(this.txtReleasedByName);
            this.Controls.Add(this.txtPreparedByCode);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.TextBox txtBOMNo;
        private System.Windows.Forms.TextBox txtJONo;
        private System.Windows.Forms.TextBox txtPreparedByCode;
        private System.Windows.Forms.TextBox txtApprovedByCode;
        private System.Windows.Forms.TextBox txtReleasedByName;
        private System.Windows.Forms.TextBox txtBOMRequestedByName;
        private System.Windows.Forms.TextBox txtBoMDescription;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBOMQtyOrd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtMaterialCode;
        private System.Windows.Forms.TextBox txtMaterialDescription;
        private System.Windows.Forms.TextBox txtUnitOfMeasure;
        private System.Windows.Forms.TextBox txtQuantityNeeded;
        private System.Windows.Forms.TextBox txtTotalQuantityNeeded;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

