namespace Grocery_Custom
{
    partial class Grocery_List_MDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grocery_List_MDI));
            this.Add_Item_Button = new System.Windows.Forms.Button();
            this.Total_Panel = new System.Windows.Forms.Panel();
            this.Grand_Total_Price_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Name_Parse = new System.Windows.Forms.TextBox();
            this.PopBoxMKII = new System.Windows.Forms.GroupBox();
            this.Greetings = new System.Windows.Forms.Label();
            this.Price_Plate = new System.Windows.Forms.Label();
            this.Name_Plate = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Price_Parse = new System.Windows.Forms.TextBox();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Load_Button = new System.Windows.Forms.Button();
            this.Grocery_List_Menu = new System.Windows.Forms.GroupBox();
            this.Open_List_Tab = new System.Windows.Forms.Button();
            this.Total_Panel.SuspendLayout();
            this.PopBoxMKII.SuspendLayout();
            this.Grocery_List_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Add_Item_Button
            // 
            this.Add_Item_Button.BackColor = System.Drawing.Color.LimeGreen;
            this.Add_Item_Button.FlatAppearance.BorderSize = 0;
            this.Add_Item_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Add_Item_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Add_Item_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Item_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Add_Item_Button.Location = new System.Drawing.Point(9, 21);
            this.Add_Item_Button.Name = "Add_Item_Button";
            this.Add_Item_Button.Size = new System.Drawing.Size(75, 25);
            this.Add_Item_Button.TabIndex = 1;
            this.Add_Item_Button.Text = "Add New";
            this.Add_Item_Button.UseVisualStyleBackColor = false;
            this.Add_Item_Button.Click += new System.EventHandler(this.Add_Item_Button_Click);
            // 
            // Total_Panel
            // 
            this.Total_Panel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Total_Panel.Controls.Add(this.Grand_Total_Price_Label);
            this.Total_Panel.Controls.Add(this.label1);
            this.Total_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Total_Panel.Location = new System.Drawing.Point(0, 626);
            this.Total_Panel.Name = "Total_Panel";
            this.Total_Panel.Size = new System.Drawing.Size(355, 37);
            this.Total_Panel.TabIndex = 2;
            // 
            // Grand_Total_Price_Label
            // 
            this.Grand_Total_Price_Label.AutoSize = true;
            this.Grand_Total_Price_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grand_Total_Price_Label.Location = new System.Drawing.Point(213, 4);
            this.Grand_Total_Price_Label.Name = "Grand_Total_Price_Label";
            this.Grand_Total_Price_Label.Size = new System.Drawing.Size(66, 25);
            this.Grand_Total_Price_Label.TabIndex = 1;
            this.Grand_Total_Price_Label.Text = "$0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Cost:";
            // 
            // Name_Parse
            // 
            this.Name_Parse.Location = new System.Drawing.Point(94, 57);
            this.Name_Parse.Name = "Name_Parse";
            this.Name_Parse.Size = new System.Drawing.Size(100, 22);
            this.Name_Parse.TabIndex = 4;
            // 
            // PopBoxMKII
            // 
            this.PopBoxMKII.Controls.Add(this.Greetings);
            this.PopBoxMKII.Controls.Add(this.Price_Plate);
            this.PopBoxMKII.Controls.Add(this.Name_Plate);
            this.PopBoxMKII.Controls.Add(this.button1);
            this.PopBoxMKII.Controls.Add(this.Price_Parse);
            this.PopBoxMKII.Controls.Add(this.Name_Parse);
            this.PopBoxMKII.Location = new System.Drawing.Point(70, 58);
            this.PopBoxMKII.Name = "PopBoxMKII";
            this.PopBoxMKII.Size = new System.Drawing.Size(200, 167);
            this.PopBoxMKII.TabIndex = 5;
            this.PopBoxMKII.TabStop = false;
            this.PopBoxMKII.Visible = false;
            // 
            // Greetings
            // 
            this.Greetings.AutoSize = true;
            this.Greetings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Greetings.Location = new System.Drawing.Point(42, 18);
            this.Greetings.Name = "Greetings";
            this.Greetings.Size = new System.Drawing.Size(117, 25);
            this.Greetings.TabIndex = 9;
            this.Greetings.Text = "Enter Item:";
            // 
            // Price_Plate
            // 
            this.Price_Plate.AutoSize = true;
            this.Price_Plate.Location = new System.Drawing.Point(11, 98);
            this.Price_Plate.Name = "Price_Plate";
            this.Price_Plate.Size = new System.Drawing.Size(74, 17);
            this.Price_Plate.TabIndex = 8;
            this.Price_Plate.Text = "Item Price:";
            // 
            // Name_Plate
            // 
            this.Name_Plate.AutoSize = true;
            this.Name_Plate.Location = new System.Drawing.Point(6, 60);
            this.Name_Plate.Name = "Name_Plate";
            this.Name_Plate.Size = new System.Drawing.Size(79, 17);
            this.Name_Plate.TabIndex = 7;
            this.Name_Plate.Text = "Item Name:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Accept";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Add_List);
            // 
            // Price_Parse
            // 
            this.Price_Parse.Location = new System.Drawing.Point(94, 98);
            this.Price_Parse.Name = "Price_Parse";
            this.Price_Parse.Size = new System.Drawing.Size(100, 22);
            this.Price_Parse.TabIndex = 5;
            // 
            // Save_Button
            // 
            this.Save_Button.Image = ((System.Drawing.Image)(resources.GetObject("Save_Button.Image")));
            this.Save_Button.Location = new System.Drawing.Point(9, 59);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(75, 25);
            this.Save_Button.TabIndex = 6;
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Load_Button
            // 
            this.Load_Button.Image = ((System.Drawing.Image)(resources.GetObject("Load_Button.Image")));
            this.Load_Button.Location = new System.Drawing.Point(9, 96);
            this.Load_Button.Name = "Load_Button";
            this.Load_Button.Size = new System.Drawing.Size(75, 25);
            this.Load_Button.TabIndex = 7;
            this.Load_Button.UseVisualStyleBackColor = true;
            this.Load_Button.Click += new System.EventHandler(this.Load_Button_Click);
            // 
            // Grocery_List_Menu
            // 
            this.Grocery_List_Menu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Grocery_List_Menu.Controls.Add(this.Add_Item_Button);
            this.Grocery_List_Menu.Controls.Add(this.Save_Button);
            this.Grocery_List_Menu.Controls.Add(this.Load_Button);
            this.Grocery_List_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Grocery_List_Menu.Location = new System.Drawing.Point(236, -1);
            this.Grocery_List_Menu.Name = "Grocery_List_Menu";
            this.Grocery_List_Menu.Size = new System.Drawing.Size(96, 220);
            this.Grocery_List_Menu.TabIndex = 8;
            this.Grocery_List_Menu.TabStop = false;
            this.Grocery_List_Menu.Visible = false;
            // 
            // Open_List_Tab
            // 
            this.Open_List_Tab.Location = new System.Drawing.Point(289, 12);
            this.Open_List_Tab.Name = "Open_List_Tab";
            this.Open_List_Tab.Size = new System.Drawing.Size(43, 28);
            this.Open_List_Tab.TabIndex = 9;
            this.Open_List_Tab.Text = "-";
            this.Open_List_Tab.UseVisualStyleBackColor = true;
            this.Open_List_Tab.Click += new System.EventHandler(this.Open_List_Tab_Click);
            // 
            // Grocery_List_MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(355, 663);
            this.Controls.Add(this.Grocery_List_Menu);
            this.Controls.Add(this.PopBoxMKII);
            this.Controls.Add(this.Open_List_Tab);
            this.Controls.Add(this.Total_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Grocery_List_MDI";
            this.ShowInTaskbar = false;
            this.Text = "Grocery_List_MDI";
            this.Load += new System.EventHandler(this.Grocery_List_MDI_Load);
            this.Click += new System.EventHandler(this.Grocery_List_MDI_Click);
            this.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.Grocery_List_MDI_ControlRemoved);
            this.Total_Panel.ResumeLayout(false);
            this.Total_Panel.PerformLayout();
            this.PopBoxMKII.ResumeLayout(false);
            this.PopBoxMKII.PerformLayout();
            this.Grocery_List_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add_Item_Button;
        private System.Windows.Forms.Panel Total_Panel;
        private System.Windows.Forms.Label Grand_Total_Price_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name_Parse;
        private System.Windows.Forms.GroupBox PopBoxMKII;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Price_Parse;
        private System.Windows.Forms.Label Greetings;
        private System.Windows.Forms.Label Price_Plate;
        private System.Windows.Forms.Label Name_Plate;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button Load_Button;
        private System.Windows.Forms.GroupBox Grocery_List_Menu;
        private System.Windows.Forms.Button Open_List_Tab;
    }
}