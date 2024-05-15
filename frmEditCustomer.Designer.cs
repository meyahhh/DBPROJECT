
namespace DBPROJECT
{
    partial class frmEditCustomer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditCustomer));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSaveCust = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnRefreshCust = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCustCon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCustAdd = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictBoxUser = new System.Windows.Forms.PictureBox();
            this.btnLoadPhotoCust = new System.Windows.Forms.Button();
            this.btnClearPhotoCust = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.OldLace;
            this.groupBox2.Controls.Add(this.btnSaveCust);
            this.groupBox2.Controls.Add(this.btnRefreshCust);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtCustCon);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtCustAdd);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtCusName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(304, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 262);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btnSaveCust
            // 
            this.btnSaveCust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSaveCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCust.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSaveCust.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSaveCust.ImageIndex = 0;
            this.btnSaveCust.ImageList = this.imageList1;
            this.btnSaveCust.Location = new System.Drawing.Point(226, 224);
            this.btnSaveCust.Name = "btnSaveCust";
            this.btnSaveCust.Size = new System.Drawing.Size(92, 23);
            this.btnSaveCust.TabIndex = 1007;
            this.btnSaveCust.Text = "Save";
            this.btnSaveCust.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveCust.UseVisualStyleBackColor = true;
            this.btnSaveCust.Click += new System.EventHandler(this.btnSaveCust_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "save-icon-5402-Windows.ico");
            this.imageList1.Images.SetKeyName(1, "refresh-icon-png-40262-Windows.ico");
            this.imageList1.Images.SetKeyName(2, "edit-icon-png-3597.png");
            this.imageList1.Images.SetKeyName(3, "camera-icon-39.jpg");
            this.imageList1.Images.SetKeyName(4, "clear-icon-9196.gif");
            this.imageList1.Images.SetKeyName(5, "save-icon-5402.png");
            this.imageList1.Images.SetKeyName(6, "refresh-icon-10850.png");
            this.imageList1.Images.SetKeyName(7, "arrow-icon-1156.png");
            this.imageList1.Images.SetKeyName(8, "arrow-icon-1151.png");
            this.imageList1.Images.SetKeyName(9, "rightdouble.png");
            this.imageList1.Images.SetKeyName(10, "leftdouble-arrow.png");
            this.imageList1.Images.SetKeyName(11, "fast-forward-double-right-arrows-symbol.png");
            this.imageList1.Images.SetKeyName(12, "left-arrow.png");
            this.imageList1.Images.SetKeyName(13, "right-arrow.png");
            this.imageList1.Images.SetKeyName(14, "forgot-password-icon-18359.png");
            this.imageList1.Images.SetKeyName(15, "email-icon-122.png");
            // 
            // btnRefreshCust
            // 
            this.btnRefreshCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshCust.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRefreshCust.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRefreshCust.ImageKey = "refresh-icon-png-40262-Windows.ico";
            this.btnRefreshCust.ImageList = this.imageList1;
            this.btnRefreshCust.Location = new System.Drawing.Point(324, 224);
            this.btnRefreshCust.Name = "btnRefreshCust";
            this.btnRefreshCust.Size = new System.Drawing.Size(80, 23);
            this.btnRefreshCust.TabIndex = 1007;
            this.btnRefreshCust.Text = "Refresh";
            this.btnRefreshCust.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefreshCust.UseVisualStyleBackColor = true;
            this.btnRefreshCust.Click += new System.EventHandler(this.btnRefreshCust_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.ImageIndex = 15;
            this.button3.ImageList = this.imageList1;
            this.button3.Location = new System.Drawing.Point(16, 224);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 23);
            this.button3.TabIndex = 47;
            this.button3.Text = "Send Email";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(13, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 16);
            this.label7.TabIndex = 1006;
            this.label7.Text = "Contact Number";
            // 
            // txtCustCon
            // 
            this.txtCustCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustCon.Location = new System.Drawing.Point(135, 143);
            this.txtCustCon.Name = "txtCustCon";
            this.txtCustCon.Size = new System.Drawing.Size(191, 22);
            this.txtCustCon.TabIndex = 2;
            this.txtCustCon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustCon_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(13, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 1005;
            this.label8.Text = "Address";
            // 
            // txtCustAdd
            // 
            this.txtCustAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustAdd.Location = new System.Drawing.Point(135, 67);
            this.txtCustAdd.Name = "txtCustAdd";
            this.txtCustAdd.Size = new System.Drawing.Size(269, 22);
            this.txtCustAdd.TabIndex = 1;
            this.txtCustAdd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustAdd_KeyDown);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(135, 106);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(269, 22);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            // 
            // txtCusName
            // 
            this.txtCusName.AcceptsReturn = true;
            this.txtCusName.AcceptsTab = true;
            this.txtCusName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusName.Location = new System.Drawing.Point(135, 30);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.ReadOnly = true;
            this.txtCusName.Size = new System.Drawing.Size(269, 22);
            this.txtCusName.TabIndex = 1002;
            this.txtCusName.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(13, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(11, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Customer Name";
            // 
            // pictBoxUser
            // 
            this.pictBoxUser.BackColor = System.Drawing.Color.OldLace;
            this.pictBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictBoxUser.Location = new System.Drawing.Point(12, 12);
            this.pictBoxUser.Name = "pictBoxUser";
            this.pictBoxUser.Size = new System.Drawing.Size(274, 262);
            this.pictBoxUser.TabIndex = 31;
            this.pictBoxUser.TabStop = false;
            // 
            // btnLoadPhotoCust
            // 
            this.btnLoadPhotoCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadPhotoCust.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLoadPhotoCust.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLoadPhotoCust.ImageIndex = 3;
            this.btnLoadPhotoCust.ImageList = this.imageList1;
            this.btnLoadPhotoCust.Location = new System.Drawing.Point(12, 280);
            this.btnLoadPhotoCust.Name = "btnLoadPhotoCust";
            this.btnLoadPhotoCust.Size = new System.Drawing.Size(149, 23);
            this.btnLoadPhotoCust.TabIndex = 47;
            this.btnLoadPhotoCust.Text = "Load New Photo";
            this.btnLoadPhotoCust.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadPhotoCust.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadPhotoCust.UseVisualStyleBackColor = true;
            this.btnLoadPhotoCust.Click += new System.EventHandler(this.btnLoadPhotoCust_Click);
            // 
            // btnClearPhotoCust
            // 
            this.btnClearPhotoCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearPhotoCust.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClearPhotoCust.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClearPhotoCust.ImageIndex = 4;
            this.btnClearPhotoCust.ImageList = this.imageList1;
            this.btnClearPhotoCust.Location = new System.Drawing.Point(177, 280);
            this.btnClearPhotoCust.Name = "btnClearPhotoCust";
            this.btnClearPhotoCust.Size = new System.Drawing.Size(109, 23);
            this.btnClearPhotoCust.TabIndex = 47;
            this.btnClearPhotoCust.Text = "Clear Photo";
            this.btnClearPhotoCust.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClearPhotoCust.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearPhotoCust.UseVisualStyleBackColor = true;
            this.btnClearPhotoCust.Click += new System.EventHandler(this.btnClearPhotoCust_Click);
            // 
            // frmEditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 315);
            this.Controls.Add(this.btnClearPhotoCust);
            this.Controls.Add(this.btnLoadPhotoCust);
            this.Controls.Add(this.pictBoxUser);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmEditCustomer";
            this.Text = "Edit Customer";
            this.Load += new System.EventHandler(this.frmEditCustomer_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCustCon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCustAdd;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictBoxUser;
        private System.Windows.Forms.Button btnLoadPhotoCust;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnClearPhotoCust;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnRefreshCust;
        private System.Windows.Forms.Button btnSaveCust;
    }
}