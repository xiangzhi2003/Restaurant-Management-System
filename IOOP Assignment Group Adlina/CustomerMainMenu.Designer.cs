namespace IOOP_Assignment_Group_Adlina
{
    partial class CustomerMainMenu
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblRestaurant = new System.Windows.Forms.Label();
            this.LblKL = new System.Windows.Forms.Label();
            this.LblAddNew = new System.Windows.Forms.Label();
            this.foodmenubtn = new System.Windows.Forms.Button();
            this.orderfoodbtn = new System.Windows.Forms.Button();
            this.statusbtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.feedbackbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(638, 549);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(64, 549);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 39);
            this.button2.TabIndex = 9;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.LblRestaurant);
            this.panel1.Controls.Add(this.LblKL);
            this.panel1.Controls.Add(this.LblAddNew);
            this.panel1.Location = new System.Drawing.Point(-41, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 165);
            this.panel1.TabIndex = 21;
            // 
            // LblRestaurant
            // 
            this.LblRestaurant.AutoSize = true;
            this.LblRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRestaurant.Location = new System.Drawing.Point(154, 9);
            this.LblRestaurant.Name = "LblRestaurant";
            this.LblRestaurant.Size = new System.Drawing.Size(634, 65);
            this.LblRestaurant.TabIndex = 6;
            this.LblRestaurant.Text = "Hashbrown Restaurant";
            // 
            // LblKL
            // 
            this.LblKL.AutoSize = true;
            this.LblKL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKL.Location = new System.Drawing.Point(319, 74);
            this.LblKL.Name = "LblKL";
            this.LblKL.Size = new System.Drawing.Size(267, 29);
            this.LblKL.TabIndex = 7;
            this.LblKL.Text = "Kuala Lumpur, Malaysia";
            // 
            // LblAddNew
            // 
            this.LblAddNew.AutoSize = true;
            this.LblAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddNew.Location = new System.Drawing.Point(318, 118);
            this.LblAddNew.Name = "LblAddNew";
            this.LblAddNew.Size = new System.Drawing.Size(277, 32);
            this.LblAddNew.TabIndex = 8;
            this.LblAddNew.Text = "Welcome Customer";
            // 
            // foodmenubtn
            // 
            this.foodmenubtn.Location = new System.Drawing.Point(329, 243);
            this.foodmenubtn.Name = "foodmenubtn";
            this.foodmenubtn.Size = new System.Drawing.Size(142, 36);
            this.foodmenubtn.TabIndex = 22;
            this.foodmenubtn.Text = "Food Menu";
            this.foodmenubtn.UseVisualStyleBackColor = true;
            this.foodmenubtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // orderfoodbtn
            // 
            this.orderfoodbtn.Location = new System.Drawing.Point(329, 305);
            this.orderfoodbtn.Name = "orderfoodbtn";
            this.orderfoodbtn.Size = new System.Drawing.Size(142, 39);
            this.orderfoodbtn.TabIndex = 23;
            this.orderfoodbtn.Text = "Order Food";
            this.orderfoodbtn.UseVisualStyleBackColor = true;
            this.orderfoodbtn.Click += new System.EventHandler(this.orderfoodbtn_Click);
            // 
            // statusbtn
            // 
            this.statusbtn.Location = new System.Drawing.Point(329, 370);
            this.statusbtn.Name = "statusbtn";
            this.statusbtn.Size = new System.Drawing.Size(142, 55);
            this.statusbtn.TabIndex = 24;
            this.statusbtn.Text = "View Order and Reservation Status";
            this.statusbtn.UseVisualStyleBackColor = true;
            this.statusbtn.Click += new System.EventHandler(this.statusbtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(329, 504);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(142, 43);
            this.updatebtn.TabIndex = 25;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // feedbackbtn
            // 
            this.feedbackbtn.Location = new System.Drawing.Point(329, 441);
            this.feedbackbtn.Name = "feedbackbtn";
            this.feedbackbtn.Size = new System.Drawing.Size(142, 41);
            this.feedbackbtn.TabIndex = 26;
            this.feedbackbtn.Text = "Feedback";
            this.feedbackbtn.UseVisualStyleBackColor = true;
            this.feedbackbtn.Click += new System.EventHandler(this.feedbackbtn_Click);
            // 
            // CustomerMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(898, 627);
            this.Controls.Add(this.feedbackbtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.statusbtn);
            this.Controls.Add(this.orderfoodbtn);
            this.Controls.Add(this.foodmenubtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CustomerMainMenu";
            this.Text = "CustomerMainMenu";
            this.Load += new System.EventHandler(this.CustomerMainMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblRestaurant;
        private System.Windows.Forms.Label LblKL;
        private System.Windows.Forms.Label LblAddNew;
        private System.Windows.Forms.Button foodmenubtn;
        private System.Windows.Forms.Button orderfoodbtn;
        private System.Windows.Forms.Button statusbtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button feedbackbtn;
    }
}