namespace GroupProjectForms
{
    partial class frmAddModifyPackage
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
            this.lblPkgName = new System.Windows.Forms.Label();
            this.txtPkgName = new System.Windows.Forms.TextBox();
            this.lblPkgStart = new System.Windows.Forms.Label();
            this.lblPkgEnd = new System.Windows.Forms.Label();
            this.lblPkgDesc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPkgDesc = new System.Windows.Forms.TextBox();
            this.txtPkgBase = new System.Windows.Forms.TextBox();
            this.txtPkgComm = new System.Windows.Forms.TextBox();
            this.dtPkgStart = new System.Windows.Forms.DateTimePicker();
            this.dtPkgEnd = new System.Windows.Forms.DateTimePicker();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPkgName
            // 
            this.lblPkgName.AutoSize = true;
            this.lblPkgName.Location = new System.Drawing.Point(24, 26);
            this.lblPkgName.Name = "lblPkgName";
            this.lblPkgName.Size = new System.Drawing.Size(35, 13);
            this.lblPkgName.TabIndex = 0;
            this.lblPkgName.Text = "Name";
            // 
            // txtPkgName
            // 
            this.txtPkgName.Location = new System.Drawing.Point(145, 23);
            this.txtPkgName.Name = "txtPkgName";
            this.txtPkgName.Size = new System.Drawing.Size(133, 20);
            this.txtPkgName.TabIndex = 1;
            this.txtPkgName.Tag = "Package Name";
            // 
            // lblPkgStart
            // 
            this.lblPkgStart.AutoSize = true;
            this.lblPkgStart.Location = new System.Drawing.Point(24, 58);
            this.lblPkgStart.Name = "lblPkgStart";
            this.lblPkgStart.Size = new System.Drawing.Size(55, 13);
            this.lblPkgStart.TabIndex = 2;
            this.lblPkgStart.Text = "Start Date";
            // 
            // lblPkgEnd
            // 
            this.lblPkgEnd.AutoSize = true;
            this.lblPkgEnd.Location = new System.Drawing.Point(24, 87);
            this.lblPkgEnd.Name = "lblPkgEnd";
            this.lblPkgEnd.Size = new System.Drawing.Size(52, 13);
            this.lblPkgEnd.TabIndex = 3;
            this.lblPkgEnd.Text = "End Date";
            // 
            // lblPkgDesc
            // 
            this.lblPkgDesc.AutoSize = true;
            this.lblPkgDesc.Location = new System.Drawing.Point(24, 117);
            this.lblPkgDesc.Name = "lblPkgDesc";
            this.lblPkgDesc.Size = new System.Drawing.Size(60, 13);
            this.lblPkgDesc.TabIndex = 4;
            this.lblPkgDesc.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Base Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Agency Commission";
            // 
            // txtPkgDesc
            // 
            this.txtPkgDesc.Location = new System.Drawing.Point(145, 114);
            this.txtPkgDesc.Name = "txtPkgDesc";
            this.txtPkgDesc.Size = new System.Drawing.Size(286, 20);
            this.txtPkgDesc.TabIndex = 8;
            this.txtPkgDesc.Tag = "Package Desciption";
            // 
            // txtPkgBase
            // 
            this.txtPkgBase.Location = new System.Drawing.Point(145, 147);
            this.txtPkgBase.Name = "txtPkgBase";
            this.txtPkgBase.Size = new System.Drawing.Size(100, 20);
            this.txtPkgBase.TabIndex = 9;
            this.txtPkgBase.Tag = "Base Price";
            // 
            // txtPkgComm
            // 
            this.txtPkgComm.Location = new System.Drawing.Point(145, 179);
            this.txtPkgComm.Name = "txtPkgComm";
            this.txtPkgComm.Size = new System.Drawing.Size(100, 20);
            this.txtPkgComm.TabIndex = 10;
            this.txtPkgComm.Tag = "Agency Commission";
            // 
            // dtPkgStart
            // 
            this.dtPkgStart.Location = new System.Drawing.Point(145, 52);
            this.dtPkgStart.Name = "dtPkgStart";
            this.dtPkgStart.ShowCheckBox = true;
            this.dtPkgStart.Size = new System.Drawing.Size(200, 20);
            this.dtPkgStart.TabIndex = 12;
            this.dtPkgStart.ValueChanged += new System.EventHandler(this.dtPkgStart_ValueChanged);
            // 
            // dtPkgEnd
            // 
            this.dtPkgEnd.Location = new System.Drawing.Point(145, 81);
            this.dtPkgEnd.Name = "dtPkgEnd";
            this.dtPkgEnd.ShowCheckBox = true;
            this.dtPkgEnd.Size = new System.Drawing.Size(200, 20);
            this.dtPkgEnd.TabIndex = 13;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(145, 209);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 14;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(270, 209);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmAddModifyPackage
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(443, 244);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.dtPkgEnd);
            this.Controls.Add(this.dtPkgStart);
            this.Controls.Add(this.txtPkgComm);
            this.Controls.Add(this.txtPkgBase);
            this.Controls.Add(this.txtPkgDesc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPkgDesc);
            this.Controls.Add(this.lblPkgEnd);
            this.Controls.Add(this.lblPkgStart);
            this.Controls.Add(this.txtPkgName);
            this.Controls.Add(this.lblPkgName);
            this.Name = "frmAddModifyPackage";
            this.Text = "AddModifyPackage";
            this.Load += new System.EventHandler(this.AddModifyPackage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPkgName;
        private System.Windows.Forms.TextBox txtPkgName;
        private System.Windows.Forms.Label lblPkgStart;
        private System.Windows.Forms.Label lblPkgEnd;
        private System.Windows.Forms.Label lblPkgDesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPkgDesc;
        private System.Windows.Forms.TextBox txtPkgBase;
        private System.Windows.Forms.TextBox txtPkgComm;
        private System.Windows.Forms.DateTimePicker dtPkgStart;
        private System.Windows.Forms.DateTimePicker dtPkgEnd;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
    }
}