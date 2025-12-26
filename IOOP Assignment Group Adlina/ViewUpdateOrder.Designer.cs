namespace IOOP_Assignment_Group_Adlina
{
    partial class ViewUpdateOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnupdatestatus = new System.Windows.Forms.Button();
            this.cmbstatus = new System.Windows.Forms.ComboBox();
            this.listViewOrders = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order";
            // 
            // btnupdatestatus
            // 
            this.btnupdatestatus.Location = new System.Drawing.Point(618, 391);
            this.btnupdatestatus.Name = "btnupdatestatus";
            this.btnupdatestatus.Size = new System.Drawing.Size(119, 47);
            this.btnupdatestatus.TabIndex = 2;
            this.btnupdatestatus.Text = "update status";
            this.btnupdatestatus.UseVisualStyleBackColor = true;
            this.btnupdatestatus.Click += new System.EventHandler(this.btnupdatestatus_Click);
            // 
            // cmbstatus
            // 
            this.cmbstatus.FormattingEnabled = true;
            this.cmbstatus.Items.AddRange(new object[] {
            "In Progress",
            "Completed"});
            this.cmbstatus.Location = new System.Drawing.Point(491, 396);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(121, 24);
            this.cmbstatus.TabIndex = 3;
            this.cmbstatus.Tag = "";
            // 
            // listViewOrders
            // 
            this.listViewOrders.FormattingEnabled = true;
            this.listViewOrders.ItemHeight = 16;
            this.listViewOrders.Location = new System.Drawing.Point(64, 82);
            this.listViewOrders.Name = "listViewOrders";
            this.listViewOrders.Size = new System.Drawing.Size(673, 308);
            this.listViewOrders.TabIndex = 4;
            this.listViewOrders.SelectedIndexChanged += new System.EventHandler(this.listViewOrders_SelectedIndexChanged_1);
            // 
            // ViewUpdateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewOrders);
            this.Controls.Add(this.cmbstatus);
            this.Controls.Add(this.btnupdatestatus);
            this.Controls.Add(this.label1);
            this.Name = "ViewUpdateOrder";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnupdatestatus;
        private System.Windows.Forms.ComboBox cmbstatus;
        private System.Windows.Forms.ListBox listViewOrders;
    }
}