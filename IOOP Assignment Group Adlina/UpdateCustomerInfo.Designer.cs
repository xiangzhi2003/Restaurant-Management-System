namespace IOOP_Assignment_Group_Adlina
{
    partial class UpdateCustomerInfo
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
            this.lblrest = new System.Windows.Forms.Label();
            this.lblUP = new System.Windows.Forms.Label();
            this.lblkl = new System.Windows.Forms.Label();
            this.usernamebtn = new System.Windows.Forms.Button();
            this.emailbtn = new System.Windows.Forms.Button();
            this.passbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblrest
            // 
            this.lblrest.AutoSize = true;
            this.lblrest.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrest.Location = new System.Drawing.Point(111, 31);
            this.lblrest.Name = "lblrest";
            this.lblrest.Size = new System.Drawing.Size(586, 64);
            this.lblrest.TabIndex = 0;
            this.lblrest.Text = "Hashbrown Resturant";
            // 
            // lblUP
            // 
            this.lblUP.AutoSize = true;
            this.lblUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUP.Location = new System.Drawing.Point(316, 143);
            this.lblUP.Name = "lblUP";
            this.lblUP.Size = new System.Drawing.Size(150, 26);
            this.lblUP.TabIndex = 1;
            this.lblUP.Text = "Update Profile";
            // 
            // lblkl
            // 
            this.lblkl.AutoSize = true;
            this.lblkl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkl.Location = new System.Drawing.Point(256, 98);
            this.lblkl.Name = "lblkl";
            this.lblkl.Size = new System.Drawing.Size(267, 29);
            this.lblkl.TabIndex = 2;
            this.lblkl.Text = "Kuala Lumpur, Malaysia";
            // 
            // usernamebtn
            // 
            this.usernamebtn.Location = new System.Drawing.Point(321, 205);
            this.usernamebtn.Name = "usernamebtn";
            this.usernamebtn.Size = new System.Drawing.Size(134, 58);
            this.usernamebtn.TabIndex = 3;
            this.usernamebtn.Text = "Change Username";
            this.usernamebtn.UseVisualStyleBackColor = true;
            this.usernamebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // emailbtn
            // 
            this.emailbtn.Location = new System.Drawing.Point(321, 269);
            this.emailbtn.Name = "emailbtn";
            this.emailbtn.Size = new System.Drawing.Size(134, 58);
            this.emailbtn.TabIndex = 4;
            this.emailbtn.Text = "Change Email";
            this.emailbtn.UseVisualStyleBackColor = true;
            this.emailbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // passbtn
            // 
            this.passbtn.Location = new System.Drawing.Point(321, 334);
            this.passbtn.Name = "passbtn";
            this.passbtn.Size = new System.Drawing.Size(134, 57);
            this.passbtn.TabIndex = 5;
            this.passbtn.Text = "Change Password";
            this.passbtn.UseVisualStyleBackColor = true;
            this.passbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // UpdateCustomerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 442);
            this.Controls.Add(this.passbtn);
            this.Controls.Add(this.emailbtn);
            this.Controls.Add(this.usernamebtn);
            this.Controls.Add(this.lblkl);
            this.Controls.Add(this.lblUP);
            this.Controls.Add(this.lblrest);
            this.Name = "UpdateCustomerInfo";
            this.Text = "UpdateCustomerInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblrest;
        private System.Windows.Forms.Label lblUP;
        private System.Windows.Forms.Label lblkl;
        private System.Windows.Forms.Button usernamebtn;
        private System.Windows.Forms.Button emailbtn;
        private System.Windows.Forms.Button passbtn;
    }
}