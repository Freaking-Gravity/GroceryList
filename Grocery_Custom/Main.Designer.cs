namespace Grocery_Custom
{
    partial class MDI_Parent
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
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.Menu_Open = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.GroupBox();
            this.Settings_Tab = new System.Windows.Forms.Button();
            this.Savings_Tab = new System.Windows.Forms.Button();
            this.Coupons_Tab = new System.Windows.Forms.Button();
            this.Grocery_Button = new System.Windows.Forms.Button();
            this.toolStripContainer1.SuspendLayout();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(150, 150);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(150, 175);
            this.toolStripContainer1.TabIndex = 0;
            // 
            // Menu_Open
            // 
            this.Menu_Open.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Menu_Open.FlatAppearance.BorderSize = 0;
            this.Menu_Open.Location = new System.Drawing.Point(0, 0);
            this.Menu_Open.Name = "Menu_Open";
            this.Menu_Open.Size = new System.Drawing.Size(43, 28);
            this.Menu_Open.TabIndex = 3;
            this.Menu_Open.UseVisualStyleBackColor = false;
            this.Menu_Open.Click += new System.EventHandler(this.Open_Menu_Click);
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.Settings_Tab);
            this.Menu.Controls.Add(this.Savings_Tab);
            this.Menu.Controls.Add(this.Coupons_Tab);
            this.Menu.Controls.Add(this.Grocery_Button);
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(107, 614);
            this.Menu.TabIndex = 7;
            this.Menu.TabStop = false;
            this.Menu.Visible = false;
            // 
            // Settings_Tab
            // 
            this.Settings_Tab.Image = global::Grocery_Custom.Properties.Resources.Settings;
            this.Settings_Tab.Location = new System.Drawing.Point(12, 448);
            this.Settings_Tab.Name = "Settings_Tab";
            this.Settings_Tab.Size = new System.Drawing.Size(75, 75);
            this.Settings_Tab.TabIndex = 3;
            this.Settings_Tab.UseVisualStyleBackColor = true;
            this.Settings_Tab.Click += new System.EventHandler(this.Settings_Tab_Click);
            // 
            // Savings_Tab
            // 
            this.Savings_Tab.Image = global::Grocery_Custom.Properties.Resources.List;
            this.Savings_Tab.Location = new System.Drawing.Point(12, 304);
            this.Savings_Tab.Name = "Savings_Tab";
            this.Savings_Tab.Size = new System.Drawing.Size(75, 75);
            this.Savings_Tab.TabIndex = 2;
            this.Savings_Tab.UseVisualStyleBackColor = true;
            this.Savings_Tab.Click += new System.EventHandler(this.Savings_Tab_Click);
            // 
            // Coupons_Tab
            // 
            this.Coupons_Tab.Image = global::Grocery_Custom.Properties.Resources.Coupon;
            this.Coupons_Tab.Location = new System.Drawing.Point(12, 154);
            this.Coupons_Tab.Name = "Coupons_Tab";
            this.Coupons_Tab.Size = new System.Drawing.Size(75, 75);
            this.Coupons_Tab.TabIndex = 1;
            this.Coupons_Tab.UseVisualStyleBackColor = true;
            this.Coupons_Tab.Click += new System.EventHandler(this.Coupons_Tab_Click);
            // 
            // Grocery_Button
            // 
            this.Grocery_Button.Image = global::Grocery_Custom.Properties.Resources.Grocery;
            this.Grocery_Button.Location = new System.Drawing.Point(12, 21);
            this.Grocery_Button.Name = "Grocery_Button";
            this.Grocery_Button.Size = new System.Drawing.Size(75, 75);
            this.Grocery_Button.TabIndex = 0;
            this.Grocery_Button.UseVisualStyleBackColor = true;
            this.Grocery_Button.Click += new System.EventHandler(this.Grocery_Button_Click);
            // 
            // MDI_Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 617);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Menu_Open);
            this.IsMdiContainer = true;
            this.Name = "MDI_Parent";
            this.Text = "Mum\'s Grocery List";
            this.Click += new System.EventHandler(this.MDI_Parent_Click);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Button Menu_Open;
        private System.Windows.Forms.GroupBox Menu;
        private System.Windows.Forms.Button Settings_Tab;
        private System.Windows.Forms.Button Savings_Tab;
        private System.Windows.Forms.Button Coupons_Tab;
        private System.Windows.Forms.Button Grocery_Button;
    }
}

