namespace IOOP_Assignment_Group_Adlina
{
    partial class SignUp
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
            this.BtnSignUp = new System.Windows.Forms.Button();
            this.BtnLogin1 = new System.Windows.Forms.Button();
            this.CBSignrole = new System.Windows.Forms.ComboBox();
            this.TbSignEm = new System.Windows.Forms.TextBox();
            this.TbSignUser = new System.Windows.Forms.TextBox();
            this.LblNewRole = new System.Windows.Forms.Label();
            this.LblNewEmail = new System.Windows.Forms.Label();
            this.LblNewUser = new System.Windows.Forms.Label();
            this.LblShowSignup = new System.Windows.Forms.Label();
            this.LblKL = new System.Windows.Forms.Label();
            this.LblRestaurant = new System.Windows.Forms.Label();
            this.TbNewPass = new System.Windows.Forms.TextBox();
            this.LblNewPass = new System.Windows.Forms.Label();
            this.TbSignPass = new System.Windows.Forms.TextBox();
            this.LblSignPass = new System.Windows.Forms.Label();
            this.LblLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.Location = new System.Drawing.Point(516, 531);
            this.BtnSignUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(59, 29);
            this.BtnSignUp.TabIndex = 33;
            this.BtnSignUp.Text = "Sign Up";
            this.BtnSignUp.UseVisualStyleBackColor = true;
            this.BtnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // BtnLogin1
            // 
            this.BtnLogin1.Location = new System.Drawing.Point(190, 531);
            this.BtnLogin1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnLogin1.Name = "BtnLogin1";
            this.BtnLogin1.Size = new System.Drawing.Size(59, 29);
            this.BtnLogin1.TabIndex = 32;
            this.BtnLogin1.Text = "Log In";
            this.BtnLogin1.UseVisualStyleBackColor = true;
            this.BtnLogin1.Click += new System.EventHandler(this.BtnBack3_Click);
            // 
            // CBSignrole
            // 
            this.CBSignrole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBSignrole.FormattingEnabled = true;
            this.CBSignrole.Items.AddRange(new object[] {
            "Manager",
            "Chef",
            "Customer"});
            this.CBSignrole.Location = new System.Drawing.Point(276, 357);
            this.CBSignrole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CBSignrole.Name = "CBSignrole";
            this.CBSignrole.Size = new System.Drawing.Size(92, 25);
            this.CBSignrole.TabIndex = 29;
            this.CBSignrole.SelectedIndexChanged += new System.EventHandler(this.CBSignrole_SelectedIndexChanged);
            // 
            // TbSignEm
            // 
            this.TbSignEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbSignEm.Location = new System.Drawing.Point(276, 296);
            this.TbSignEm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TbSignEm.Name = "TbSignEm";
            this.TbSignEm.Size = new System.Drawing.Size(233, 21);
            this.TbSignEm.TabIndex = 28;
            // 
            // TbSignUser
            // 
            this.TbSignUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbSignUser.Location = new System.Drawing.Point(276, 238);
            this.TbSignUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TbSignUser.Name = "TbSignUser";
            this.TbSignUser.Size = new System.Drawing.Size(233, 21);
            this.TbSignUser.TabIndex = 27;
            // 
            // LblNewRole
            // 
            this.LblNewRole.AutoSize = true;
            this.LblNewRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNewRole.Location = new System.Drawing.Point(274, 338);
            this.LblNewRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNewRole.Name = "LblNewRole";
            this.LblNewRole.Size = new System.Drawing.Size(44, 17);
            this.LblNewRole.TabIndex = 25;
            this.LblNewRole.Text = "Roles";
            // 
            // LblNewEmail
            // 
            this.LblNewEmail.AutoSize = true;
            this.LblNewEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNewEmail.Location = new System.Drawing.Point(274, 278);
            this.LblNewEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNewEmail.Name = "LblNewEmail";
            this.LblNewEmail.Size = new System.Drawing.Size(42, 17);
            this.LblNewEmail.TabIndex = 24;
            this.LblNewEmail.Text = "Email";
            // 
            // LblNewUser
            // 
            this.LblNewUser.AutoSize = true;
            this.LblNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNewUser.Location = new System.Drawing.Point(274, 219);
            this.LblNewUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNewUser.Name = "LblNewUser";
            this.LblNewUser.Size = new System.Drawing.Size(73, 17);
            this.LblNewUser.TabIndex = 23;
            this.LblNewUser.Text = "Username";
            // 
            // LblShowSignup
            // 
            this.LblShowSignup.AutoSize = true;
            this.LblShowSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblShowSignup.Location = new System.Drawing.Point(325, 140);
            this.LblShowSignup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblShowSignup.Name = "LblShowSignup";
            this.LblShowSignup.Size = new System.Drawing.Size(84, 24);
            this.LblShowSignup.TabIndex = 22;
            this.LblShowSignup.Text = "Sign Up";
            // 
            // LblKL
            // 
            this.LblKL.AutoSize = true;
            this.LblKL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKL.Location = new System.Drawing.Point(291, 105);
            this.LblKL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblKL.Name = "LblKL";
            this.LblKL.Size = new System.Drawing.Size(176, 20);
            this.LblKL.TabIndex = 21;
            this.LblKL.Text = "Kuala Lumpur, Malaysia";
            // 
            // LblRestaurant
            // 
            this.LblRestaurant.AutoSize = true;
            this.LblRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRestaurant.Location = new System.Drawing.Point(204, 60);
            this.LblRestaurant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRestaurant.Name = "LblRestaurant";
            this.LblRestaurant.Size = new System.Drawing.Size(426, 44);
            this.LblRestaurant.TabIndex = 20;
            this.LblRestaurant.Text = "Hashbrown Restaurant";
            // 
            // TbNewPass
            // 
            this.TbNewPass.Location = new System.Drawing.Point(274, 445);
            this.TbNewPass.Name = "TbNewPass";
            this.TbNewPass.Size = new System.Drawing.Size(203, 20);
            this.TbNewPass.TabIndex = 38;
            // 
            // LblNewPass
            // 
            this.LblNewPass.AutoSize = true;
            this.LblNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNewPass.Location = new System.Drawing.Point(271, 414);
            this.LblNewPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNewPass.Name = "LblNewPass";
            this.LblNewPass.Size = new System.Drawing.Size(100, 17);
            this.LblNewPass.TabIndex = 37;
            this.LblNewPass.Text = "New Password";
            // 
            // TbSignPass
            // 
            this.TbSignPass.Location = new System.Drawing.Point(277, 428);
            this.TbSignPass.Name = "TbSignPass";
            this.TbSignPass.Size = new System.Drawing.Size(203, 20);
            this.TbSignPass.TabIndex = 38;
            this.TbSignPass.UseSystemPasswordChar = true;
            // 
            // LblSignPass
            // 
            this.LblSignPass.AutoSize = true;
            this.LblSignPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSignPass.Location = new System.Drawing.Point(274, 397);
            this.LblSignPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSignPass.Name = "LblSignPass";
            this.LblSignPass.Size = new System.Drawing.Size(100, 17);
            this.LblSignPass.TabIndex = 37;
            this.LblSignPass.Text = "New Password";
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.Location = new System.Drawing.Point(165, 506);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(132, 13);
            this.LblLogin.TabIndex = 39;
            this.LblLogin.Text = "Already have an account?";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(820, 595);
            this.Controls.Add(this.LblLogin);
            this.Controls.Add(this.TbSignPass);
            this.Controls.Add(this.LblSignPass);
            this.Controls.Add(this.BtnSignUp);
            this.Controls.Add(this.BtnLogin1);
            this.Controls.Add(this.CBSignrole);
            this.Controls.Add(this.TbSignEm);
            this.Controls.Add(this.TbSignUser);
            this.Controls.Add(this.LblNewRole);
            this.Controls.Add(this.LblNewEmail);
            this.Controls.Add(this.LblNewUser);
            this.Controls.Add(this.LblShowSignup);
            this.Controls.Add(this.LblKL);
            this.Controls.Add(this.LblRestaurant);
            this.Name = "SignUp";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSignUp;
        private System.Windows.Forms.Button BtnLogin1;
        private System.Windows.Forms.ComboBox CBSignrole;
        private System.Windows.Forms.TextBox TbSignEm;
        private System.Windows.Forms.TextBox TbSignUser;
        private System.Windows.Forms.Label LblNewRole;
        private System.Windows.Forms.Label LblNewEmail;
        private System.Windows.Forms.Label LblNewUser;
        private System.Windows.Forms.Label LblShowSignup;
        private System.Windows.Forms.Label LblKL;
        private System.Windows.Forms.Label LblRestaurant;
        private System.Windows.Forms.TextBox TbNewPass;
        private System.Windows.Forms.Label LblNewPass;
        private System.Windows.Forms.TextBox TbSignPass;
        private System.Windows.Forms.Label LblSignPass;
        private System.Windows.Forms.Label LblLogin;
    }
}