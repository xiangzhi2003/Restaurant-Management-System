namespace IOOP_Assignment_Group_Adlina
{
    partial class AddUserForm
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
            this.LblKL = new System.Windows.Forms.Label();
            this.LblRestaurant = new System.Windows.Forms.Label();
            this.LblAddNew = new System.Windows.Forms.Label();
            this.LblNewUser = new System.Windows.Forms.Label();
            this.LblNewEmail = new System.Windows.Forms.Label();
            this.LblNewRole = new System.Windows.Forms.Label();
            this.LblNewPass = new System.Windows.Forms.Label();
            this.TbUsernameAdmin = new System.Windows.Forms.TextBox();
            this.TbEmailAdmin = new System.Windows.Forms.TextBox();
            this.CbRoleAdmin = new System.Windows.Forms.ComboBox();
            this.LblGenPass = new System.Windows.Forms.Label();
            this.BtnBack1 = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblKL
            // 
            this.LblKL.AutoSize = true;
            this.LblKL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKL.Location = new System.Drawing.Point(256, 63);
            this.LblKL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblKL.Name = "LblKL";
            this.LblKL.Size = new System.Drawing.Size(176, 20);
            this.LblKL.TabIndex = 7;
            this.LblKL.Text = "Kuala Lumpur, Malaysia";
            this.LblKL.Click += new System.EventHandler(this.LblKL_Click);
            // 
            // LblRestaurant
            // 
            this.LblRestaurant.AutoSize = true;
            this.LblRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRestaurant.Location = new System.Drawing.Point(153, 8);
            this.LblRestaurant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRestaurant.Name = "LblRestaurant";
            this.LblRestaurant.Size = new System.Drawing.Size(426, 44);
            this.LblRestaurant.TabIndex = 6;
            this.LblRestaurant.Text = "Hashbrown Restaurant";
            // 
            // LblAddNew
            // 
            this.LblAddNew.AutoSize = true;
            this.LblAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddNew.Location = new System.Drawing.Point(266, 96);
            this.LblAddNew.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAddNew.Name = "LblAddNew";
            this.LblAddNew.Size = new System.Drawing.Size(145, 24);
            this.LblAddNew.TabIndex = 8;
            this.LblAddNew.Text = "Add New User";
            // 
            // LblNewUser
            // 
            this.LblNewUser.AutoSize = true;
            this.LblNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNewUser.Location = new System.Drawing.Point(237, 172);
            this.LblNewUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNewUser.Name = "LblNewUser";
            this.LblNewUser.Size = new System.Drawing.Size(73, 17);
            this.LblNewUser.TabIndex = 9;
            this.LblNewUser.Text = "Username";
            // 
            // LblNewEmail
            // 
            this.LblNewEmail.AutoSize = true;
            this.LblNewEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNewEmail.Location = new System.Drawing.Point(237, 231);
            this.LblNewEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNewEmail.Name = "LblNewEmail";
            this.LblNewEmail.Size = new System.Drawing.Size(42, 17);
            this.LblNewEmail.TabIndex = 10;
            this.LblNewEmail.Text = "Email";
            // 
            // LblNewRole
            // 
            this.LblNewRole.AutoSize = true;
            this.LblNewRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNewRole.Location = new System.Drawing.Point(237, 291);
            this.LblNewRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNewRole.Name = "LblNewRole";
            this.LblNewRole.Size = new System.Drawing.Size(44, 17);
            this.LblNewRole.TabIndex = 11;
            this.LblNewRole.Text = "Roles";
            // 
            // LblNewPass
            // 
            this.LblNewPass.AutoSize = true;
            this.LblNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNewPass.Location = new System.Drawing.Point(238, 357);
            this.LblNewPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNewPass.Name = "LblNewPass";
            this.LblNewPass.Size = new System.Drawing.Size(180, 17);
            this.LblNewPass.TabIndex = 12;
            this.LblNewPass.Text = "Auto-generated Password :";
            // 
            // TbUsernameAdmin
            // 
            this.TbUsernameAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbUsernameAdmin.Location = new System.Drawing.Point(240, 191);
            this.TbUsernameAdmin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TbUsernameAdmin.Name = "TbUsernameAdmin";
            this.TbUsernameAdmin.Size = new System.Drawing.Size(233, 21);
            this.TbUsernameAdmin.TabIndex = 13;
            // 
            // TbEmailAdmin
            // 
            this.TbEmailAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbEmailAdmin.Location = new System.Drawing.Point(240, 250);
            this.TbEmailAdmin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TbEmailAdmin.Name = "TbEmailAdmin";
            this.TbEmailAdmin.Size = new System.Drawing.Size(233, 21);
            this.TbEmailAdmin.TabIndex = 14;
            // 
            // CbRoleAdmin
            // 
            this.CbRoleAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbRoleAdmin.FormattingEnabled = true;
            this.CbRoleAdmin.Items.AddRange(new object[] {
            "Manager",
            "Chef",
            "Customer"});
            this.CbRoleAdmin.Location = new System.Drawing.Point(240, 309);
            this.CbRoleAdmin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CbRoleAdmin.Name = "CbRoleAdmin";
            this.CbRoleAdmin.Size = new System.Drawing.Size(92, 25);
            this.CbRoleAdmin.TabIndex = 15;
            // 
            // LblGenPass
            // 
            this.LblGenPass.AutoSize = true;
            this.LblGenPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGenPass.Location = new System.Drawing.Point(238, 386);
            this.LblGenPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblGenPass.Name = "LblGenPass";
            this.LblGenPass.Size = new System.Drawing.Size(100, 17);
            this.LblGenPass.TabIndex = 16;
            this.LblGenPass.Text = "New Password";
            // 
            // BtnBack1
            // 
            this.BtnBack1.Location = new System.Drawing.Point(112, 466);
            this.BtnBack1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnBack1.Name = "BtnBack1";
            this.BtnBack1.Size = new System.Drawing.Size(59, 29);
            this.BtnBack1.TabIndex = 18;
            this.BtnBack1.Text = "Back";
            this.BtnBack1.UseVisualStyleBackColor = true;
            this.BtnBack1.Click += new System.EventHandler(this.BtnBack1_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(521, 466);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(59, 29);
            this.BtnAdd.TabIndex = 19;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.LblRestaurant);
            this.panel1.Controls.Add(this.LblKL);
            this.panel1.Controls.Add(this.LblAddNew);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 136);
            this.panel1.TabIndex = 20;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(708, 568);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnBack1);
            this.Controls.Add(this.LblGenPass);
            this.Controls.Add(this.CbRoleAdmin);
            this.Controls.Add(this.TbEmailAdmin);
            this.Controls.Add(this.TbUsernameAdmin);
            this.Controls.Add(this.LblNewPass);
            this.Controls.Add(this.LblNewRole);
            this.Controls.Add(this.LblNewEmail);
            this.Controls.Add(this.LblNewUser);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "AddUserForm";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.AddUserForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblKL;
        private System.Windows.Forms.Label LblRestaurant;
        private System.Windows.Forms.Label LblAddNew;
        private System.Windows.Forms.Label LblNewUser;
        private System.Windows.Forms.Label LblNewEmail;
        private System.Windows.Forms.Label LblNewRole;
        private System.Windows.Forms.Label LblNewPass;
        private System.Windows.Forms.TextBox TbUsernameAdmin;
        private System.Windows.Forms.TextBox TbEmailAdmin;
        private System.Windows.Forms.ComboBox CbRoleAdmin;
        private System.Windows.Forms.Label LblGenPass;
        private System.Windows.Forms.Button BtnBack1;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Panel panel1;
    }
}