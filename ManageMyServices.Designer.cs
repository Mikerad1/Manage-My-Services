namespace Manage_My_Services_2
{
    partial class frmManageMyServices
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnNo = new System.Windows.Forms.RadioButton();
            this.rbtnYes = new System.Windows.Forms.RadioButton();
            this.lblMachineName = new System.Windows.Forms.Label();
            this.txtMachineName = new System.Windows.Forms.TextBox();
            this.btnGetServices = new System.Windows.Forms.Button();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.btnStartService = new System.Windows.Forms.Button();
            this.btnStopService = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDependantServices = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRestartServices = new System.Windows.Forms.Button();
            this.btnRestartDependantServices = new System.Windows.Forms.Button();
            this.txtSearchDependantServices = new System.Windows.Forms.TextBox();
            this.lblFindDependantServices = new System.Windows.Forms.Label();
            this.btnStopDependantServices = new System.Windows.Forms.Button();
            this.btnStartDependantServices = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDependantServices)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnNo);
            this.groupBox1.Controls.Add(this.rbtnYes);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Local Machine?";
            // 
            // rbtnNo
            // 
            this.rbtnNo.AutoSize = true;
            this.rbtnNo.Location = new System.Drawing.Point(7, 44);
            this.rbtnNo.Name = "rbtnNo";
            this.rbtnNo.Size = new System.Drawing.Size(39, 17);
            this.rbtnNo.TabIndex = 1;
            this.rbtnNo.TabStop = true;
            this.rbtnNo.Text = "No";
            this.rbtnNo.UseVisualStyleBackColor = true;
            this.rbtnNo.CheckedChanged += new System.EventHandler(this.RbtnNo_CheckedChanged);
            // 
            // rbtnYes
            // 
            this.rbtnYes.AutoSize = true;
            this.rbtnYes.Location = new System.Drawing.Point(7, 20);
            this.rbtnYes.Name = "rbtnYes";
            this.rbtnYes.Size = new System.Drawing.Size(43, 17);
            this.rbtnYes.TabIndex = 0;
            this.rbtnYes.TabStop = true;
            this.rbtnYes.Text = "Yes";
            this.rbtnYes.UseVisualStyleBackColor = true;
            this.rbtnYes.CheckedChanged += new System.EventHandler(this.RbtnYes_CheckedChanged);
            // 
            // lblMachineName
            // 
            this.lblMachineName.AutoSize = true;
            this.lblMachineName.Location = new System.Drawing.Point(133, 12);
            this.lblMachineName.Name = "lblMachineName";
            this.lblMachineName.Size = new System.Drawing.Size(82, 13);
            this.lblMachineName.TabIndex = 1;
            this.lblMachineName.Text = "Machine Name:";
            // 
            // txtMachineName
            // 
            this.txtMachineName.Location = new System.Drawing.Point(221, 12);
            this.txtMachineName.Name = "txtMachineName";
            this.txtMachineName.Size = new System.Drawing.Size(128, 20);
            this.txtMachineName.TabIndex = 2;
            // 
            // btnGetServices
            // 
            this.btnGetServices.Location = new System.Drawing.Point(221, 38);
            this.btnGetServices.Name = "btnGetServices";
            this.btnGetServices.Size = new System.Drawing.Size(91, 23);
            this.btnGetServices.TabIndex = 3;
            this.btnGetServices.Text = "Get Services";
            this.btnGetServices.UseVisualStyleBackColor = true;
            this.btnGetServices.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // dgvServices
            // 
            this.dgvServices.AllowUserToAddRows = false;
            this.dgvServices.AllowUserToDeleteRows = false;
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Location = new System.Drawing.Point(12, 176);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.ReadOnly = true;
            this.dgvServices.Size = new System.Drawing.Size(572, 282);
            this.dgvServices.TabIndex = 4;
            this.dgvServices.SelectionChanged += new System.EventHandler(this.DgvServices_SelectionChanged);
            // 
            // btnStartService
            // 
            this.btnStartService.Location = new System.Drawing.Point(307, 147);
            this.btnStartService.Name = "btnStartService";
            this.btnStartService.Size = new System.Drawing.Size(83, 23);
            this.btnStartService.TabIndex = 5;
            this.btnStartService.Text = "Start Service";
            this.btnStartService.UseVisualStyleBackColor = true;
            this.btnStartService.Click += new System.EventHandler(this.BtnStartService_Click);
            // 
            // btnStopService
            // 
            this.btnStopService.Location = new System.Drawing.Point(396, 147);
            this.btnStopService.Name = "btnStopService";
            this.btnStopService.Size = new System.Drawing.Size(80, 23);
            this.btnStopService.TabIndex = 6;
            this.btnStopService.Text = "Stop Service";
            this.btnStopService.UseVisualStyleBackColor = true;
            this.btnStopService.Click += new System.EventHandler(this.BtnStopService_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Find services:";
            // 
            // txtServiceName
            // 
            this.txtServiceName.Location = new System.Drawing.Point(75, 150);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(226, 20);
            this.txtServiceName.TabIndex = 8;
            this.txtServiceName.TextChanged += new System.EventHandler(this.TxtServiceName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Services:";
            // 
            // dgvDependantServices
            // 
            this.dgvDependantServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDependantServices.Location = new System.Drawing.Point(590, 176);
            this.dgvDependantServices.Name = "dgvDependantServices";
            this.dgvDependantServices.Size = new System.Drawing.Size(572, 282);
            this.dgvDependantServices.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(587, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Dependant Services:";
            // 
            // btnRestartServices
            // 
            this.btnRestartServices.Location = new System.Drawing.Point(482, 148);
            this.btnRestartServices.Name = "btnRestartServices";
            this.btnRestartServices.Size = new System.Drawing.Size(99, 23);
            this.btnRestartServices.TabIndex = 12;
            this.btnRestartServices.Text = "Restart Services";
            this.btnRestartServices.UseVisualStyleBackColor = true;
            this.btnRestartServices.Click += new System.EventHandler(this.BtnRestartServices_Click);
            // 
            // btnRestartDependantServices
            // 
            this.btnRestartDependantServices.Enabled = false;
            this.btnRestartDependantServices.Location = new System.Drawing.Point(1063, 147);
            this.btnRestartDependantServices.Name = "btnRestartDependantServices";
            this.btnRestartDependantServices.Size = new System.Drawing.Size(99, 23);
            this.btnRestartDependantServices.TabIndex = 17;
            this.btnRestartDependantServices.Text = "Restart Services";
            this.btnRestartDependantServices.UseVisualStyleBackColor = true;
            this.btnRestartDependantServices.Click += new System.EventHandler(this.BtnRestartDependantServices_Click);
            // 
            // txtSearchDependantServices
            // 
            this.txtSearchDependantServices.Enabled = false;
            this.txtSearchDependantServices.Location = new System.Drawing.Point(719, 150);
            this.txtSearchDependantServices.Name = "txtSearchDependantServices";
            this.txtSearchDependantServices.Size = new System.Drawing.Size(163, 20);
            this.txtSearchDependantServices.TabIndex = 16;
            this.txtSearchDependantServices.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // lblFindDependantServices
            // 
            this.lblFindDependantServices.AutoSize = true;
            this.lblFindDependantServices.Enabled = false;
            this.lblFindDependantServices.Location = new System.Drawing.Point(719, 134);
            this.lblFindDependantServices.Name = "lblFindDependantServices";
            this.lblFindDependantServices.Size = new System.Drawing.Size(126, 13);
            this.lblFindDependantServices.TabIndex = 15;
            this.lblFindDependantServices.Text = "Find dependant services:";
            // 
            // btnStopDependantServices
            // 
            this.btnStopDependantServices.Enabled = false;
            this.btnStopDependantServices.Location = new System.Drawing.Point(977, 147);
            this.btnStopDependantServices.Name = "btnStopDependantServices";
            this.btnStopDependantServices.Size = new System.Drawing.Size(80, 23);
            this.btnStopDependantServices.TabIndex = 14;
            this.btnStopDependantServices.Text = "Stop Service";
            this.btnStopDependantServices.UseVisualStyleBackColor = true;
            this.btnStopDependantServices.Click += new System.EventHandler(this.BtnStopDependantServices_Click);
            // 
            // btnStartDependantServices
            // 
            this.btnStartDependantServices.Enabled = false;
            this.btnStartDependantServices.Location = new System.Drawing.Point(888, 148);
            this.btnStartDependantServices.Name = "btnStartDependantServices";
            this.btnStartDependantServices.Size = new System.Drawing.Size(83, 23);
            this.btnStartDependantServices.TabIndex = 13;
            this.btnStartDependantServices.Text = "Start Service";
            this.btnStartDependantServices.UseVisualStyleBackColor = true;
            this.btnStartDependantServices.Click += new System.EventHandler(this.BtnStartDependantServices_Click);
            // 
            // frmManageMyServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 497);
            this.Controls.Add(this.btnRestartDependantServices);
            this.Controls.Add(this.txtSearchDependantServices);
            this.Controls.Add(this.lblFindDependantServices);
            this.Controls.Add(this.btnStopDependantServices);
            this.Controls.Add(this.btnStartDependantServices);
            this.Controls.Add(this.btnRestartServices);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDependantServices);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServiceName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStopService);
            this.Controls.Add(this.btnStartService);
            this.Controls.Add(this.dgvServices);
            this.Controls.Add(this.btnGetServices);
            this.Controls.Add(this.txtMachineName);
            this.Controls.Add(this.lblMachineName);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmManageMyServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage My Services";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDependantServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnNo;
        private System.Windows.Forms.RadioButton rbtnYes;
        private System.Windows.Forms.Label lblMachineName;
        private System.Windows.Forms.TextBox txtMachineName;
        private System.Windows.Forms.Button btnGetServices;
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.Button btnStartService;
        private System.Windows.Forms.Button btnStopService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDependantServices;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRestartServices;
        private System.Windows.Forms.Button btnRestartDependantServices;
        private System.Windows.Forms.TextBox txtSearchDependantServices;
        private System.Windows.Forms.Label lblFindDependantServices;
        private System.Windows.Forms.Button btnStopDependantServices;
        private System.Windows.Forms.Button btnStartDependantServices;
    }
}

