namespace IOOP_Assignment_Group_Adlina
{
    partial class AdminMenuForm
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
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnManAllUser = new System.Windows.Forms.Button();
            this.BtnViewFeed = new System.Windows.Forms.Button();
            this.BtnViewSales = new System.Windows.Forms.Button();
            this.BtnManProfile1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblRestaurant = new System.Windows.Forms.Label();
            this.LblKL = new System.Windows.Forms.Label();
            this.LblAddNew = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnLogout
            // 
            this.BtnLogout.BackColor = System.Drawing.Color.Bisque;
            this.BtnLogout.Location = new System.Drawing.Point(269, 396);
            this.BtnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(58, 29);
            this.BtnLogout.TabIndex = 9;
            this.BtnLogout.Text = "Sign out";
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnManAllUser
            // 
            this.BtnManAllUser.BackColor = System.Drawing.Color.Bisque;
            this.BtnManAllUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManAllUser.Location = new System.Drawing.Point(65, 150);
            this.BtnManAllUser.Name = "BtnManAllUser";
            this.BtnManAllUser.Size = new System.Drawing.Size(177, 79);
            this.BtnManAllUser.TabIndex = 11;
            this.BtnManAllUser.Text = "Manage Users";
            this.BtnManAllUser.UseVisualStyleBackColor = false;
            this.BtnManAllUser.Click += new System.EventHandler(this.ManAllUser_Click);
            // 
            // BtnViewFeed
            // 
            this.BtnViewFeed.BackColor = System.Drawing.Color.Bisque;
            this.BtnViewFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnViewFeed.Location = new System.Drawing.Point(65, 277);
            this.BtnViewFeed.Name = "BtnViewFeed";
            this.BtnViewFeed.Size = new System.Drawing.Size(177, 79);
            this.BtnViewFeed.TabIndex = 12;
            this.BtnViewFeed.Text = "View Feedback";
            this.BtnViewFeed.UseVisualStyleBackColor = false;
            this.BtnViewFeed.Click += new System.EventHandler(this.BtnViewFeed_Click);
            // 
            // BtnViewSales
            // 
            this.BtnViewSales.BackColor = System.Drawing.Color.Bisque;
            this.BtnViewSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnViewSales.Location = new System.Drawing.Point(361, 150);
            this.BtnViewSales.Name = "BtnViewSales";
            this.BtnViewSales.Size = new System.Drawing.Size(173, 79);
            this.BtnViewSales.TabIndex = 13;
            this.BtnViewSales.Text = "View Sales";
            this.BtnViewSales.UseVisualStyleBackColor = false;
            this.BtnViewSales.Click += new System.EventHandler(this.BtnViewSales_Click);
            // 
            // BtnManProfile1
            // 
            this.BtnManProfile1.BackColor = System.Drawing.Color.Bisque;
            this.BtnManProfile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManProfile1.Location = new System.Drawing.Point(361, 277);
            this.BtnManProfile1.Name = "BtnManProfile1";
            this.BtnManProfile1.Size = new System.Drawing.Size(173, 79);
            this.BtnManProfile1.TabIndex = 14;
            this.BtnManProfile1.Text = "Manage Profile";
            this.BtnManProfile1.UseVisualStyleBackColor = false;
            this.BtnManProfile1.Click += new System.EventHandler(this.BtnManProfile1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Peru;
            this.panel2.Controls.Add(this.LblRestaurant);
            this.panel2.Controls.Add(this.LblKL);
            this.panel2.Controls.Add(this.LblAddNew);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 128);
            this.panel2.TabIndex = 21;
            // 
            // LblRestaurant
            // 
            this.LblRestaurant.AutoSize = true;
            this.LblRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRestaurant.Location = new System.Drawing.Point(107, 17);
            this.LblRestaurant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRestaurant.Name = "LblRestaurant";
            this.LblRestaurant.Size = new System.Drawing.Size(426, 44);
            this.LblRestaurant.TabIndex = 6;
            this.LblRestaurant.Text = "Hashbrown Restaurant";
            // 
            // LblKL
            // 
            this.LblKL.AutoSize = true;
            this.LblKL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKL.Location = new System.Drawing.Point(212, 61);
            this.LblKL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblKL.Name = "LblKL";
            this.LblKL.Size = new System.Drawing.Size(176, 20);
            this.LblKL.TabIndex = 7;
            this.LblKL.Text = "Kuala Lumpur, Malaysia";
            // 
            // LblAddNew
            // 
            this.LblAddNew.AutoSize = true;
            this.LblAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddNew.Location = new System.Drawing.Point(212, 93);
            this.LblAddNew.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAddNew.Name = "LblAddNew";
            this.LblAddNew.Size = new System.Drawing.Size(70, 24);
            this.LblAddNew.TabIndex = 8;
            this.LblAddNew.Text = "Admin";
            this.LblAddNew.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblAddNew.Click += new System.EventHandler(this.LblAddNew_Click);
            // 
            // AdminMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(601, 464);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtnManProfile1);
            this.Controls.Add(this.BtnViewSales);
            this.Controls.Add(this.BtnViewFeed);
            this.Controls.Add(this.BtnManAllUser);
            this.Controls.Add(this.BtnLogout);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminMenuForm";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.AdminMenuForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Button BtnManAllUser;
        private System.Windows.Forms.Button BtnViewFeed;
        private System.Windows.Forms.Button BtnViewSales;
        private System.Windows.Forms.Button BtnManProfile1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblRestaurant;
        private System.Windows.Forms.Label LblKL;
        private System.Windows.Forms.Label LblAddNew;
    }
}