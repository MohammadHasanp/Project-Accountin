namespace Accounting_App.Customers
{
    partial class CustomerChange
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
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnInsertCustomer = new System.Windows.Forms.ToolStripButton();
            this.DeleteCustomer = new System.Windows.Forms.ToolStripButton();
            this.EditCystomer = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtseerch = new System.Windows.Forms.ToolStripTextBox();
            this.dgCustomerList = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomerList)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefresh,
            this.btnInsertCustomer,
            this.DeleteCustomer,
            this.EditCystomer,
            this.toolStripLabel1,
            this.txtseerch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(558, 62);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::Accounting_App.Properties.Resources._1371476368_Synchronize;
            this.btnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(71, 59);
            this.btnRefresh.Text = "Refresh List";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnInsertCustomer
            // 
            this.btnInsertCustomer.Image = global::Accounting_App.Properties.Resources._1371475930_filenew;
            this.btnInsertCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnInsertCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInsertCustomer.Name = "btnInsertCustomer";
            this.btnInsertCustomer.Size = new System.Drawing.Size(90, 59);
            this.btnInsertCustomer.Text = "New Customer";
            this.btnInsertCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInsertCustomer.Click += new System.EventHandler(this.BtnInsertCustomer_Click);
            // 
            // DeleteCustomer
            // 
            this.DeleteCustomer.Image = global::Accounting_App.Properties.Resources._1371476007_Close_Box_Red;
            this.DeleteCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeleteCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteCustomer.Name = "DeleteCustomer";
            this.DeleteCustomer.Size = new System.Drawing.Size(99, 59);
            this.DeleteCustomer.Text = "Delete Customer";
            this.DeleteCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DeleteCustomer.Click += new System.EventHandler(this.DeleteCustomer_Click);
            // 
            // EditCystomer
            // 
            this.EditCystomer.Image = global::Accounting_App.Properties.Resources._1371475973_document_edit;
            this.EditCystomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditCystomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditCystomer.Name = "EditCystomer";
            this.EditCystomer.Size = new System.Drawing.Size(86, 59);
            this.EditCystomer.Text = "Edit Customer";
            this.EditCystomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditCystomer.Click += new System.EventHandler(this.EditCystomer_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(45, 59);
            this.toolStripLabel1.Text = "Seerch:";
            // 
            // txtseerch
            // 
            this.txtseerch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtseerch.Name = "txtseerch";
            this.txtseerch.Size = new System.Drawing.Size(100, 62);
            this.txtseerch.Click += new System.EventHandler(this.ToolStripTextBox1_Click);
            this.txtseerch.TextChanged += new System.EventHandler(this.ToolStripTextBox1_TextChanged);
            // 
            // dgCustomerList
            // 
            this.dgCustomerList.AllowUserToAddRows = false;
            this.dgCustomerList.AllowUserToDeleteRows = false;
            this.dgCustomerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FullName,
            this.Mobile,
            this.Email,
            this.CustomerImage});
            this.dgCustomerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCustomerList.Location = new System.Drawing.Point(0, 62);
            this.dgCustomerList.Name = "dgCustomerList";
            this.dgCustomerList.ReadOnly = true;
            this.dgCustomerList.Size = new System.Drawing.Size(558, 271);
            this.dgCustomerList.TabIndex = 1;
            this.dgCustomerList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCustomerList_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "CustomerID";
            this.ID.HeaderText = "CstomerId";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "FullName";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Mobile
            // 
            this.Mobile.DataPropertyName = "Mobil";
            this.Mobile.HeaderText = "Mobil";
            this.Mobile.Name = "Mobile";
            this.Mobile.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // CustomerImage
            // 
            this.CustomerImage.DataPropertyName = "CustomerImage";
            this.CustomerImage.HeaderText = "CustomerImage";
            this.CustomerImage.Name = "CustomerImage";
            this.CustomerImage.ReadOnly = true;
            // 
            // CustomerChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 333);
            this.Controls.Add(this.dgCustomerList);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CustomerChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CustomerChange";
            this.Load += new System.EventHandler(this.CustomerChange_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomerList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnInsertCustomer;
        private System.Windows.Forms.ToolStripButton DeleteCustomer;
        private System.Windows.Forms.ToolStripButton EditCystomer;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtseerch;
        private System.Windows.Forms.DataGridView dgCustomerList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerImage;
    }
}