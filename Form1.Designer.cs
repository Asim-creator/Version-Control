namespace Comparator
{
    partial class frmmain
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
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtfee = new System.Windows.Forms.TextBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.lblid = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblfee = new System.Windows.Forms.Label();
            this.btndisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(294, 32);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(119, 36);
            this.txtid.TabIndex = 0;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(294, 99);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(119, 38);
            this.txtname.TabIndex = 1;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(294, 159);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(119, 35);
            this.txtaddress.TabIndex = 2;
            // 
            // txtfee
            // 
            this.txtfee.Location = new System.Drawing.Point(294, 219);
            this.txtfee.Multiline = true;
            this.txtfee.Name = "txtfee";
            this.txtfee.Size = new System.Drawing.Size(119, 36);
            this.txtfee.TabIndex = 3;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(482, 400);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(125, 38);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lblid
            // 
            this.lblid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblid.Location = new System.Drawing.Point(146, 50);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(100, 23);
            this.lblid.TabIndex = 5;
            this.lblid.Text = "ID";
            // 
            // lblname
            // 
            this.lblname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblname.Location = new System.Drawing.Point(149, 114);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(100, 23);
            this.lblname.TabIndex = 6;
            this.lblname.Text = "Name";
            // 
            // lbladdress
            // 
            this.lbladdress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbladdress.Location = new System.Drawing.Point(149, 171);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(100, 23);
            this.lbladdress.TabIndex = 7;
            this.lbladdress.Text = "Address";
            // 
            // lblfee
            // 
            this.lblfee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblfee.Location = new System.Drawing.Point(149, 232);
            this.lblfee.Name = "lblfee";
            this.lblfee.Size = new System.Drawing.Size(100, 23);
            this.lblfee.TabIndex = 8;
            this.lblfee.Text = "Fee";
            // 
            // btndisplay
            // 
            this.btndisplay.Location = new System.Drawing.Point(241, 321);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(132, 39);
            this.btndisplay.TabIndex = 9;
            this.btndisplay.Text = "Display";
            this.btndisplay.UseVisualStyleBackColor = true;
            this.btndisplay.Click += new System.EventHandler(this.btndisplay_Click);
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 450);
            this.Controls.Add(this.btndisplay);
            this.Controls.Add(this.lblfee);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.txtfee);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Name = "frmmain";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtfee;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblfee;
        private System.Windows.Forms.Button btndisplay;
    }
}

