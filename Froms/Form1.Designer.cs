namespace SmartLoyalty
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
            this.panelSide = new System.Windows.Forms.Panel();
            this.panelLeftBottom = new System.Windows.Forms.Panel();
            this.lblLoginUser = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.BtnReport = new System.Windows.Forms.Button();
            this.BtnRedmPoint = new System.Windows.Forms.Button();
            this.BtnAddPoint = new System.Windows.Forms.Button();
            this.BtnCustReg = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.panelLeftTop = new System.Windows.Forms.Panel();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelformArea = new System.Windows.Forms.Panel();
            this.panelSide.SuspendLayout();
            this.panelLeftBottom.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSide
            // 
            this.panelSide.Controls.Add(this.panelLeftBottom);
            this.panelSide.Controls.Add(this.panelButtons);
            this.panelSide.Controls.Add(this.panelLeftTop);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(183, 515);
            this.panelSide.TabIndex = 0;
            // 
            // panelLeftBottom
            // 
            this.panelLeftBottom.Controls.Add(this.lblLoginUser);
            this.panelLeftBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeftBottom.Location = new System.Drawing.Point(0, 489);
            this.panelLeftBottom.Name = "panelLeftBottom";
            this.panelLeftBottom.Size = new System.Drawing.Size(183, 26);
            this.panelLeftBottom.TabIndex = 2;
            // 
            // lblLoginUser
            // 
            this.lblLoginUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblLoginUser.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginUser.Location = new System.Drawing.Point(0, -4);
            this.lblLoginUser.Name = "lblLoginUser";
            this.lblLoginUser.Size = new System.Drawing.Size(183, 30);
            this.lblLoginUser.TabIndex = 4;
            this.lblLoginUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.BtnLogOut);
            this.panelButtons.Controls.Add(this.BtnReport);
            this.panelButtons.Controls.Add(this.BtnRedmPoint);
            this.panelButtons.Controls.Add(this.BtnAddPoint);
            this.panelButtons.Controls.Add(this.BtnCustReg);
            this.panelButtons.Controls.Add(this.BtnHome);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 56);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(183, 433);
            this.panelButtons.TabIndex = 1;
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.BackColor = System.Drawing.Color.White;
            this.BtnLogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogOut.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogOut.ForeColor = System.Drawing.Color.Black;
            this.BtnLogOut.Location = new System.Drawing.Point(0, 360);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(183, 72);
            this.BtnLogOut.TabIndex = 4;
            this.BtnLogOut.Text = "Log Out";
            this.BtnLogOut.UseVisualStyleBackColor = false;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnTab_Click);
            // 
            // BtnReport
            // 
            this.BtnReport.BackColor = System.Drawing.Color.White;
            this.BtnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReport.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReport.ForeColor = System.Drawing.Color.Black;
            this.BtnReport.Location = new System.Drawing.Point(0, 288);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(183, 72);
            this.BtnReport.TabIndex = 3;
            this.BtnReport.Text = "Report";
            this.BtnReport.UseVisualStyleBackColor = false;
            this.BtnReport.Click += new System.EventHandler(this.BtnTab_Click);
            // 
            // BtnRedmPoint
            // 
            this.BtnRedmPoint.BackColor = System.Drawing.Color.White;
            this.BtnRedmPoint.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRedmPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRedmPoint.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRedmPoint.ForeColor = System.Drawing.Color.Black;
            this.BtnRedmPoint.Location = new System.Drawing.Point(0, 216);
            this.BtnRedmPoint.Name = "BtnRedmPoint";
            this.BtnRedmPoint.Size = new System.Drawing.Size(183, 72);
            this.BtnRedmPoint.TabIndex = 2;
            this.BtnRedmPoint.Text = "Redeem Points";
            this.BtnRedmPoint.UseVisualStyleBackColor = false;
            this.BtnRedmPoint.Click += new System.EventHandler(this.BtnTab_Click);
            // 
            // BtnAddPoint
            // 
            this.BtnAddPoint.BackColor = System.Drawing.Color.White;
            this.BtnAddPoint.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAddPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddPoint.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddPoint.ForeColor = System.Drawing.Color.Black;
            this.BtnAddPoint.Location = new System.Drawing.Point(0, 144);
            this.BtnAddPoint.Name = "BtnAddPoint";
            this.BtnAddPoint.Size = new System.Drawing.Size(183, 72);
            this.BtnAddPoint.TabIndex = 1;
            this.BtnAddPoint.Text = "Add Points";
            this.BtnAddPoint.UseVisualStyleBackColor = false;
            this.BtnAddPoint.Click += new System.EventHandler(this.BtnTab_Click);
            // 
            // BtnCustReg
            // 
            this.BtnCustReg.BackColor = System.Drawing.Color.White;
            this.BtnCustReg.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCustReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCustReg.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCustReg.ForeColor = System.Drawing.Color.Black;
            this.BtnCustReg.Location = new System.Drawing.Point(0, 72);
            this.BtnCustReg.Name = "BtnCustReg";
            this.BtnCustReg.Size = new System.Drawing.Size(183, 72);
            this.BtnCustReg.TabIndex = 0;
            this.BtnCustReg.Text = "Customer Registration";
            this.BtnCustReg.UseVisualStyleBackColor = false;
            this.BtnCustReg.Click += new System.EventHandler(this.BtnTab_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.Color.White;
            this.BtnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.ForeColor = System.Drawing.Color.Black;
            this.BtnHome.Location = new System.Drawing.Point(0, 0);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(183, 72);
            this.BtnHome.TabIndex = 5;
            this.BtnHome.Text = "Home";
            this.BtnHome.UseVisualStyleBackColor = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnTab_Click);
            // 
            // panelLeftTop
            // 
            this.panelLeftTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLeftTop.Location = new System.Drawing.Point(0, 0);
            this.panelLeftTop.Name = "panelLeftTop";
            this.panelLeftTop.Size = new System.Drawing.Size(183, 56);
            this.panelLeftTop.TabIndex = 0;
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelBody.Controls.Add(this.panelformArea);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(183, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(895, 515);
            this.panelBody.TabIndex = 1;
            // 
            // panelformArea
            // 
            this.panelformArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelformArea.BackColor = System.Drawing.Color.White;
            this.panelformArea.Location = new System.Drawing.Point(24, 21);
            this.panelformArea.Name = "panelformArea";
            this.panelformArea.Size = new System.Drawing.Size(848, 471);
            this.panelformArea.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 515);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelSide);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Loyalty";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panelSide.ResumeLayout(false);
            this.panelLeftBottom.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.panelBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelLeftBottom;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.Button BtnReport;
        private System.Windows.Forms.Button BtnRedmPoint;
        private System.Windows.Forms.Button BtnAddPoint;
        private System.Windows.Forms.Button BtnCustReg;
        private System.Windows.Forms.Panel panelLeftTop;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel panelformArea;
        private System.Windows.Forms.Label lblLoginUser;
        private System.Windows.Forms.Button BtnHome;
    }
}

