namespace Grocery_Custom
{
    partial class Settings_MDI
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Help_Button = new System.Windows.Forms.Button();
            this.Light_Mode = new System.Windows.Forms.RadioButton();
            this.Dark_Theme = new System.Windows.Forms.RadioButton();
            this.Test_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(164, 235);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(47, 22);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Help_Button
            // 
            this.Help_Button.Location = new System.Drawing.Point(101, 503);
            this.Help_Button.Name = "Help_Button";
            this.Help_Button.Size = new System.Drawing.Size(75, 25);
            this.Help_Button.TabIndex = 1;
            this.Help_Button.Text = "Help";
            this.Help_Button.UseVisualStyleBackColor = true;
            // 
            // Light_Mode
            // 
            this.Light_Mode.AutoSize = true;
            this.Light_Mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Light_Mode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Light_Mode.Location = new System.Drawing.Point(58, 106);
            this.Light_Mode.Name = "Light_Mode";
            this.Light_Mode.Size = new System.Drawing.Size(134, 24);
            this.Light_Mode.TabIndex = 2;
            this.Light_Mode.TabStop = true;
            this.Light_Mode.Text = "Light Theme";
            this.Light_Mode.UseVisualStyleBackColor = true;
            // 
            // Dark_Theme
            // 
            this.Dark_Theme.AutoSize = true;
            this.Dark_Theme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dark_Theme.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Dark_Theme.Location = new System.Drawing.Point(58, 155);
            this.Dark_Theme.Name = "Dark_Theme";
            this.Dark_Theme.Size = new System.Drawing.Size(132, 24);
            this.Dark_Theme.TabIndex = 3;
            this.Dark_Theme.TabStop = true;
            this.Dark_Theme.Text = "Dark Theme";
            this.Dark_Theme.UseVisualStyleBackColor = true;
            // 
            // Test_Label
            // 
            this.Test_Label.AutoSize = true;
            this.Test_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Test_Label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Test_Label.Location = new System.Drawing.Point(12, 234);
            this.Test_Label.Name = "Test_Label";
            this.Test_Label.Size = new System.Drawing.Size(94, 20);
            this.Test_Label.TabIndex = 4;
            this.Test_Label.Text = "Text Size:";
            // 
            // Settings_MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(277, 575);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Test_Label);
            this.Controls.Add(this.Dark_Theme);
            this.Controls.Add(this.Light_Mode);
            this.Controls.Add(this.Help_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings_MDI";
            this.Text = "Settings_MDI";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button Help_Button;
        private System.Windows.Forms.RadioButton Light_Mode;
        private System.Windows.Forms.RadioButton Dark_Theme;
        private System.Windows.Forms.Label Test_Label;
    }
}