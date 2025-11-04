namespace Accounting_App.Accountiing
{
    partial class FrmReport
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.Btndeletereport = new System.Windows.Forms.ToolStripButton();
            this.btnEditreport = new System.Windows.Forms.ToolStripButton();
            this.BtnPrintReport = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.txtenddate = new System.Windows.Forms.MaskedTextBox();
            this.txtstartdate = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmcustomer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgreport = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgreport)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnRefresh,
            this.Btndeletereport,
            this.btnEditreport,
            this.BtnPrintReport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(658, 62);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Image = global::Accounting_App.Properties.Resources._1371476394_refresh_red;
            this.BtnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(88, 59);
            this.BtnRefresh.Text = "Refresh Report";
            this.BtnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // Btndeletereport
            // 
            this.Btndeletereport.Image = global::Accounting_App.Properties.Resources._1371476007_Close_Box_Red;
            this.Btndeletereport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btndeletereport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btndeletereport.Name = "Btndeletereport";
            this.Btndeletereport.Size = new System.Drawing.Size(82, 59);
            this.Btndeletereport.Text = "Delete Report";
            this.Btndeletereport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btndeletereport.Click += new System.EventHandler(this.Btndeletereport_Click);
            // 
            // btnEditreport
            // 
            this.btnEditreport.Image = global::Accounting_App.Properties.Resources._1371475973_document_edit;
            this.btnEditreport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditreport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditreport.Name = "btnEditreport";
            this.btnEditreport.Size = new System.Drawing.Size(69, 59);
            this.btnEditreport.Text = "Edit Report";
            this.btnEditreport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditreport.Click += new System.EventHandler(this.BtnEditreport_Click);
            // 
            // BtnPrintReport
            // 
            this.BtnPrintReport.Image = global::Accounting_App.Properties.Resources._1371476276_Print;
            this.BtnPrintReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnPrintReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnPrintReport.Name = "BtnPrintReport";
            this.BtnPrintReport.Size = new System.Drawing.Size(74, 59);
            this.BtnPrintReport.Text = "Print Report";
            this.BtnPrintReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsubmit);
            this.groupBox1.Controls.Add(this.txtenddate);
            this.groupBox1.Controls.Add(this.txtstartdate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmcustomer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seerch";
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(6, 41);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(81, 33);
            this.btnsubmit.TabIndex = 3;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.Btnsubmit_Click);
            // 
            // txtenddate
            // 
            this.txtenddate.Location = new System.Drawing.Point(533, 18);
            this.txtenddate.Mask = "0000/00/00";
            this.txtenddate.Name = "txtenddate";
            this.txtenddate.Size = new System.Drawing.Size(100, 24);
            this.txtenddate.TabIndex = 2;
            this.txtenddate.ValidatingType = typeof(System.DateTime);
            // 
            // txtstartdate
            // 
            this.txtstartdate.Location = new System.Drawing.Point(331, 18);
            this.txtstartdate.Mask = "0000/00/00";
            this.txtstartdate.Name = "txtstartdate";
            this.txtstartdate.Size = new System.Drawing.Size(100, 24);
            this.txtstartdate.TabIndex = 2;
            this.txtstartdate.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "From Hstory:";
            // 
            // cmcustomer
            // 
            this.cmcustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmcustomer.FormattingEnabled = true;
            this.cmcustomer.Location = new System.Drawing.Point(112, 18);
            this.cmcustomer.Name = "cmcustomer";
            this.cmcustomer.Size = new System.Drawing.Size(121, 24);
            this.cmcustomer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "From Hstory:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Party:";
            // 
            // dgreport
            // 
            this.dgreport.AllowUserToAddRows = false;
            this.dgreport.AllowUserToDeleteRows = false;
            this.dgreport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgreport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgreport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CustomerID,
            this.Amount,
            this.Date,
            this.Description});
            this.dgreport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgreport.Location = new System.Drawing.Point(0, 151);
            this.dgreport.Name = "dgreport";
            this.dgreport.ReadOnly = true;
            this.dgreport.Size = new System.Drawing.Size(658, 230);
            this.dgreport.TabIndex = 4;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "DataTime";
            this.Date.HeaderText = "Datatime";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Discription";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 381);
            this.Controls.Add(this.dgreport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.FrmReport_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgreport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnRefresh;
        private System.Windows.Forms.ToolStripButton Btndeletereport;
        private System.Windows.Forms.ToolStripButton btnEditreport;
        private System.Windows.Forms.ToolStripButton BtnPrintReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.MaskedTextBox txtenddate;
        private System.Windows.Forms.MaskedTextBox txtstartdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmcustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgreport;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}