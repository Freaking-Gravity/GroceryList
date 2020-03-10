namespace Grocery_Custom
{
    partial class Grocery_List_Object
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Item_Quantity_Control = new System.Windows.Forms.NumericUpDown();
            this.Item_Name = new System.Windows.Forms.Label();
            this.Default_Price_Label = new System.Windows.Forms.Label();
            this.Total_Label = new System.Windows.Forms.Label();
            this.Item_Picture = new System.Windows.Forms.PictureBox();
            this.Cost_Label = new System.Windows.Forms.Label();
            this.Total_Cost_Label = new System.Windows.Forms.Label();
            this.Item_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Item_Quantity_Control)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Item_Quantity_Control
            // 
            this.Item_Quantity_Control.Location = new System.Drawing.Point(125, 81);
            this.Item_Quantity_Control.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Item_Quantity_Control.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Item_Quantity_Control.Name = "Item_Quantity_Control";
            this.Item_Quantity_Control.Size = new System.Drawing.Size(44, 22);
            this.Item_Quantity_Control.TabIndex = 0;
            this.Item_Quantity_Control.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Item_Quantity_Control.ValueChanged += new System.EventHandler(this.Item_Quantity_Control_ValueChanged);
            // 
            // Item_Name
            // 
            this.Item_Name.AutoSize = true;
            this.Item_Name.Location = new System.Drawing.Point(13, 14);
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.Size = new System.Drawing.Size(79, 17);
            this.Item_Name.TabIndex = 1;
            this.Item_Name.Text = "Item_Name";
            // 
            // Default_Price_Label
            // 
            this.Default_Price_Label.AutoSize = true;
            this.Default_Price_Label.Location = new System.Drawing.Point(98, 14);
            this.Default_Price_Label.Name = "Default_Price_Label";
            this.Default_Price_Label.Size = new System.Drawing.Size(44, 17);
            this.Default_Price_Label.TabIndex = 2;
            this.Default_Price_Label.Text = "Price:";
            // 
            // Total_Label
            // 
            this.Total_Label.AutoSize = true;
            this.Total_Label.Location = new System.Drawing.Point(13, 149);
            this.Total_Label.Name = "Total_Label";
            this.Total_Label.Size = new System.Drawing.Size(76, 17);
            this.Total_Label.TabIndex = 3;
            this.Total_Label.Text = "Total Cost:";
            // 
            // Item_Picture
            // 
            this.Item_Picture.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Item_Picture.Location = new System.Drawing.Point(3, 41);
            this.Item_Picture.Name = "Item_Picture";
            this.Item_Picture.Size = new System.Drawing.Size(114, 102);
            this.Item_Picture.TabIndex = 4;
            this.Item_Picture.TabStop = false;
            this.Item_Picture.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Item_Picture_MouseDoubleClick);
            // 
            // Cost_Label
            // 
            this.Cost_Label.AutoSize = true;
            this.Cost_Label.Location = new System.Drawing.Point(136, 14);
            this.Cost_Label.Name = "Cost_Label";
            this.Cost_Label.Size = new System.Drawing.Size(44, 17);
            this.Cost_Label.TabIndex = 5;
            this.Cost_Label.Text = "$0.00";
            // 
            // Total_Cost_Label
            // 
            this.Total_Cost_Label.AutoSize = true;
            this.Total_Cost_Label.Location = new System.Drawing.Point(98, 149);
            this.Total_Cost_Label.Name = "Total_Cost_Label";
            this.Total_Cost_Label.Size = new System.Drawing.Size(44, 17);
            this.Total_Cost_Label.TabIndex = 6;
            this.Total_Cost_Label.Text = "$0.00";
            // 
            // Item_Delete
            // 
            this.Item_Delete.BackColor = System.Drawing.Color.Red;
            this.Item_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Item_Delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Item_Delete.Location = new System.Drawing.Point(167, 149);
            this.Item_Delete.Name = "Item_Delete";
            this.Item_Delete.Size = new System.Drawing.Size(25, 25);
            this.Item_Delete.TabIndex = 11;
            this.Item_Delete.Text = "X";
            this.Item_Delete.UseVisualStyleBackColor = false;
            this.Item_Delete.Click += new System.EventHandler(this.Item_Delete_Click);
            // 
            // Grocery_List_Object
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Item_Delete);
            this.Controls.Add(this.Total_Cost_Label);
            this.Controls.Add(this.Cost_Label);
            this.Controls.Add(this.Item_Picture);
            this.Controls.Add(this.Total_Label);
            this.Controls.Add(this.Default_Price_Label);
            this.Controls.Add(this.Item_Name);
            this.Controls.Add(this.Item_Quantity_Control);
            this.Name = "Grocery_List_Object";
            this.Size = new System.Drawing.Size(195, 177);
            this.Load += new System.EventHandler(this.Grocery_List_Object_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Item_Quantity_Control)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item_Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Item_Quantity_Control;
        private System.Windows.Forms.Label Item_Name;
        private System.Windows.Forms.Label Default_Price_Label;
        private System.Windows.Forms.Label Total_Label;
        private System.Windows.Forms.PictureBox Item_Picture;
        private System.Windows.Forms.Label Cost_Label;
        private System.Windows.Forms.Label Total_Cost_Label;
        private System.Windows.Forms.Button Item_Delete;
    }
}
