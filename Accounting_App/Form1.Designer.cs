namespace Accounting_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.editPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnAccountside = new System.Windows.Forms.ToolStripButton();
            this.btnpaymentreport = new System.Windows.Forms.ToolStripButton();
            this.btnIncomingreports = new System.Windows.Forms.ToolStripButton();
            this.btnNewtransaction = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblremainder = new System.Windows.Forms.Label();
            this.lblpayment = new System.Windows.Forms.Label();
            this.lblreceived = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(503, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editPasswordToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(62, 22);
            this.toolStripDropDownButton1.Text = "Settings";
            // 
            // editPasswordToolStripMenuItem
            // 
            this.editPasswordToolStripMenuItem.Name = "editPasswordToolStripMenuItem";
            this.editPasswordToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.editPasswordToolStripMenuItem.Text = "EditPassword";
            this.editPasswordToolStripMenuItem.Click += new System.EventHandler(this.editPasswordToolStripMenuItem_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAccountside,
            this.btnpaymentreport,
            this.btnIncomingreports,
            this.btnNewtransaction});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(503, 62);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnAccountside
            // 
            this.btnAccountside.Image = global::Accounting_App.Properties.Resources._1371476468_preferences_contact_list;
            this.btnAccountside.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAccountside.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAccountside.Name = "btnAccountside";
            this.btnAccountside.Size = new System.Drawing.Size(81, 59);
            this.btnAccountside.Text = "Account Side";
            this.btnAccountside.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAccountside.Click += new System.EventHandler(this.btnAccountside_Click);
            // 
            // btnpaymentreport
            // 
            this.btnpaymentreport.Image = global::Accounting_App.Properties.Resources.servicesCosts;
            this.btnpaymentreport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnpaymentreport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnpaymentreport.Name = "btnpaymentreport";
            this.btnpaymentreport.Size = new System.Drawing.Size(96, 59);
            this.btnpaymentreport.Text = "Payment Report";
            this.btnpaymentreport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnpaymentreport.Click += new System.EventHandler(this.btnpaymentreport_Click);
            // 
            // btnIncomingreports
            // 
            this.btnIncomingreports.Image = global::Accounting_App.Properties.Resources._1370791030_credit_card;
            this.btnIncomingreports.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnIncomingreports.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIncomingreports.Name = "btnIncomingreports";
            this.btnIncomingreports.Size = new System.Drawing.Size(105, 59);
            this.btnIncomingreports.Text = "Incoming Reports";
            this.btnIncomingreports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIncomingreports.Click += new System.EventHandler(this.btnIncomingreports_Click);
            // 
            // btnNewtransaction
            // 
            this.btnNewtransaction.Image = global::Accounting_App.Properties.Resources.Users;
            this.btnNewtransaction.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNewtransaction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewtransaction.Name = "btnNewtransaction";
            this.btnNewtransaction.Size = new System.Drawing.Size(98, 59);
            this.btnNewtransaction.Text = "New Transaction";
            this.btnNewtransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewtransaction.Click += new System.EventHandler(this.btnNewtransaction_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Accounting_App.Properties.Resources.Untitled_1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblremainder);
            this.groupBox1.Controls.Add(this.lblpayment);
            this.groupBox1.Controls.Add(this.lblreceived);
            this.groupBox1.Controls.Add(this.s);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(291, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "This month\'s report";
            // 
            // lblremainder
            // 
            this.lblremainder.Location = new System.Drawing.Point(88, 77);
            this.lblremainder.Name = "lblremainder";
            this.lblremainder.Size = new System.Drawing.Size(120, 23);
            this.lblremainder.TabIndex = 5;
            this.lblremainder.Text = "0";
            this.lblremainder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblpayment
            // 
            this.lblpayment.Location = new System.Drawing.Point(78, 49);
            this.lblpayment.Name = "lblpayment";
            this.lblpayment.Size = new System.Drawing.Size(120, 23);
            this.lblpayment.TabIndex = 4;
            this.lblpayment.Text = "0";
            this.lblpayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblreceived
            // 
            this.lblreceived.Location = new System.Drawing.Point(74, 25);
            this.lblreceived.Name = "lblreceived";
            this.lblreceived.Size = new System.Drawing.Size(120, 23);
            this.lblreceived.TabIndex = 3;
            this.lblreceived.Text = "0";
            this.lblreceived.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Location = new System.Drawing.Point(6, 80);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(85, 17);
            this.s.TabIndex = 2;
            this.s.Text = "Remainder :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Payment :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Received:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(291, 224);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 316);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem editPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnAccountside;
        private System.Windows.Forms.ToolStripButton btnpaymentreport;
        private System.Windows.Forms.ToolStripButton btnIncomingreports;
        private System.Windows.Forms.ToolStripButton btnNewtransaction;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblremainder;
        private System.Windows.Forms.Label lblpayment;
        private System.Windows.Forms.Label lblreceived;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.Button btnRefresh;
    }
}