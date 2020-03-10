namespace Grocery_Custom
{
    partial class PopBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Name_Parse = new System.Windows.Forms.TextBox();
            this.Price_Parse = new System.Windows.Forms.TextBox();
            this.confirm_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Item Info:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Item Price:";
            // 
            // Name_Parse
            // 
            this.Name_Parse.Location = new System.Drawing.Point(101, 37);
            this.Name_Parse.Name = "Name_Parse";
            this.Name_Parse.Size = new System.Drawing.Size(100, 22);
            this.Name_Parse.TabIndex = 4;
            // 
            // Price_Parse
            // 
            this.Price_Parse.Location = new System.Drawing.Point(101, 101);
            this.Price_Parse.Name = "Price_Parse";
            this.Price_Parse.Size = new System.Drawing.Size(100, 22);
            this.Price_Parse.TabIndex = 5;
            // 
            // confirm_Button
            // 
            this.confirm_Button.Location = new System.Drawing.Point(101, 130);
            this.confirm_Button.Name = "confirm_Button";
            this.confirm_Button.Size = new System.Drawing.Size(100, 23);
            this.confirm_Button.TabIndex = 6;
            this.confirm_Button.Text = "Confirm";
            this.confirm_Button.UseVisualStyleBackColor = true;
            this.confirm_Button.Click += new System.EventHandler(this.confirm_Button_Click);
            // 
            // PopBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.confirm_Button);
            this.Controls.Add(this.Price_Parse);
            this.Controls.Add(this.Name_Parse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PopBox";
            this.Size = new System.Drawing.Size(237, 157);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Name_Parse;
        private System.Windows.Forms.TextBox Price_Parse;
        private System.Windows.Forms.Button confirm_Button;
    }
}
