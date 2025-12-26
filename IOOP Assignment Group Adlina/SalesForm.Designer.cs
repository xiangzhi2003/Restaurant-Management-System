namespace IOOP_Assignment_Group_Adlina
{
    partial class SalesForm
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
            this.CbSales = new System.Windows.Forms.ComboBox();
            this.LblFilter1 = new System.Windows.Forms.Label();
            this.BtnBack5 = new System.Windows.Forms.Button();
            this.LblSales = new System.Windows.Forms.Label();
            this.LblKL = new System.Windows.Forms.Label();
            this.LblRestaurant = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CbSales
            // 
            this.CbSales.FormattingEnabled = true;
            this.CbSales.Items.AddRange(new object[] {
            "Daily",
            "Monthly",
            "Yearly"});
            this.CbSales.Location = new System.Drawing.Point(247, 185);
            this.CbSales.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CbSales.Name = "CbSales";
            this.CbSales.Size = new System.Drawing.Size(123, 21);
            this.CbSales.TabIndex = 31;
            this.CbSales.SelectedIndexChanged += new System.EventHandler(this.CbSales_SelectedIndexChanged);
            // 
            // LblFilter1
            // 
            this.LblFilter1.AutoSize = true;
            this.LblFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFilter1.Location = new System.Drawing.Point(195, 188);
            this.LblFilter1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFilter1.Name = "LblFilter1";
            this.LblFilter1.Size = new System.Drawing.Size(51, 17);
            this.LblFilter1.TabIndex = 30;
            this.LblFilter1.Text = "Filter : ";
            // 
            // BtnBack5
            // 
            this.BtnBack5.Location = new System.Drawing.Point(50, 644);
            this.BtnBack5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnBack5.Name = "BtnBack5";
            this.BtnBack5.Size = new System.Drawing.Size(59, 29);
            this.BtnBack5.TabIndex = 28;
            this.BtnBack5.Text = "Back";
            this.BtnBack5.UseVisualStyleBackColor = true;
            this.BtnBack5.Click += new System.EventHandler(this.BtnBack5_Click);
            // 
            // LblSales
            // 
            this.LblSales.AutoSize = true;
            this.LblSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSales.Location = new System.Drawing.Point(228, 136);
            this.LblSales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSales.Name = "LblSales";
            this.LblSales.Size = new System.Drawing.Size(129, 24);
            this.LblSales.TabIndex = 27;
            this.LblSales.Text = "Sales Report";
            // 
            // LblKL
            // 
            this.LblKL.AutoSize = true;
            this.LblKL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKL.Location = new System.Drawing.Point(208, 102);
            this.LblKL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblKL.Name = "LblKL";
            this.LblKL.Size = new System.Drawing.Size(176, 20);
            this.LblKL.TabIndex = 26;
            this.LblKL.Text = "Kuala Lumpur, Malaysia";
            // 
            // LblRestaurant
            // 
            this.LblRestaurant.AutoSize = true;
            this.LblRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRestaurant.Location = new System.Drawing.Point(93, 58);
            this.LblRestaurant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRestaurant.Name = "LblRestaurant";
            this.LblRestaurant.Size = new System.Drawing.Size(426, 44);
            this.LblRestaurant.TabIndex = 25;
            this.LblRestaurant.Text = "Hashbrown Restaurant";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(92, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(411, 359);
            this.dataGridView1.TabIndex = 32;
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(600, 725);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CbSales);
            this.Controls.Add(this.LblFilter1);
            this.Controls.Add(this.BtnBack5);
            this.Controls.Add(this.LblSales);
            this.Controls.Add(this.LblKL);
            this.Controls.Add(this.LblRestaurant);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "SalesForm";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbSales;
        private System.Windows.Forms.Label LblFilter1;
        private System.Windows.Forms.Button BtnBack5;
        private System.Windows.Forms.Label LblSales;
        private System.Windows.Forms.Label LblKL;
        private System.Windows.Forms.Label LblRestaurant;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}