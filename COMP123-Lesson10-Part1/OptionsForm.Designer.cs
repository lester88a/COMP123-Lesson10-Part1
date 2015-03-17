namespace COMP123_Lesson10_Part1
{
    partial class OptionsForm
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
            this.ColourOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.ShowCheckBox = new System.Windows.Forms.CheckBox();
            this.OptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.PinkTextBox = new System.Windows.Forms.TextBox();
            this.GreenTextBox = new System.Windows.Forms.TextBox();
            this.BlueTextBox = new System.Windows.Forms.TextBox();
            this.WhiteTextBox = new System.Windows.Forms.TextBox();
            this.PinkRadioButton = new System.Windows.Forms.RadioButton();
            this.GreenRadioButton = new System.Windows.Forms.RadioButton();
            this.BlueRadioButton = new System.Windows.Forms.RadioButton();
            this.DefaultRadioButton = new System.Windows.Forms.RadioButton();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.ColourOptionsGroupBox.SuspendLayout();
            this.OptionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ColourOptionsGroupBox
            // 
            this.ColourOptionsGroupBox.Controls.Add(this.ShowCheckBox);
            this.ColourOptionsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ColourOptionsGroupBox.Name = "ColourOptionsGroupBox";
            this.ColourOptionsGroupBox.Size = new System.Drawing.Size(129, 77);
            this.ColourOptionsGroupBox.TabIndex = 0;
            this.ColourOptionsGroupBox.TabStop = false;
            this.ColourOptionsGroupBox.Text = "Color Options";
            // 
            // ShowCheckBox
            // 
            this.ShowCheckBox.AutoSize = true;
            this.ShowCheckBox.Location = new System.Drawing.Point(7, 20);
            this.ShowCheckBox.Name = "ShowCheckBox";
            this.ShowCheckBox.Size = new System.Drawing.Size(53, 17);
            this.ShowCheckBox.TabIndex = 0;
            this.ShowCheckBox.Text = "Show";
            this.ShowCheckBox.UseVisualStyleBackColor = true;
            this.ShowCheckBox.CheckedChanged += new System.EventHandler(this.ShowCheckBox_CheckedChanged);
            // 
            // OptionsGroupBox
            // 
            this.OptionsGroupBox.Controls.Add(this.PinkTextBox);
            this.OptionsGroupBox.Controls.Add(this.GreenTextBox);
            this.OptionsGroupBox.Controls.Add(this.BlueTextBox);
            this.OptionsGroupBox.Controls.Add(this.WhiteTextBox);
            this.OptionsGroupBox.Controls.Add(this.PinkRadioButton);
            this.OptionsGroupBox.Controls.Add(this.GreenRadioButton);
            this.OptionsGroupBox.Controls.Add(this.BlueRadioButton);
            this.OptionsGroupBox.Controls.Add(this.DefaultRadioButton);
            this.OptionsGroupBox.Controls.Add(this.AcceptButton);
            this.OptionsGroupBox.Location = new System.Drawing.Point(148, 13);
            this.OptionsGroupBox.Name = "OptionsGroupBox";
            this.OptionsGroupBox.Size = new System.Drawing.Size(290, 311);
            this.OptionsGroupBox.TabIndex = 1;
            this.OptionsGroupBox.TabStop = false;
            this.OptionsGroupBox.Text = "Options";
            this.OptionsGroupBox.Visible = false;
            // 
            // PinkTextBox
            // 
            this.PinkTextBox.BackColor = System.Drawing.Color.Pink;
            this.PinkTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PinkTextBox.Enabled = false;
            this.PinkTextBox.Location = new System.Drawing.Point(73, 92);
            this.PinkTextBox.Name = "PinkTextBox";
            this.PinkTextBox.Size = new System.Drawing.Size(100, 20);
            this.PinkTextBox.TabIndex = 8;
            // 
            // GreenTextBox
            // 
            this.GreenTextBox.BackColor = System.Drawing.Color.Green;
            this.GreenTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GreenTextBox.Enabled = false;
            this.GreenTextBox.Location = new System.Drawing.Point(73, 68);
            this.GreenTextBox.Name = "GreenTextBox";
            this.GreenTextBox.Size = new System.Drawing.Size(100, 20);
            this.GreenTextBox.TabIndex = 7;
            // 
            // BlueTextBox
            // 
            this.BlueTextBox.BackColor = System.Drawing.Color.Blue;
            this.BlueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BlueTextBox.Enabled = false;
            this.BlueTextBox.Location = new System.Drawing.Point(73, 44);
            this.BlueTextBox.Name = "BlueTextBox";
            this.BlueTextBox.Size = new System.Drawing.Size(100, 20);
            this.BlueTextBox.TabIndex = 6;
            // 
            // WhiteTextBox
            // 
            this.WhiteTextBox.BackColor = System.Drawing.Color.White;
            this.WhiteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WhiteTextBox.Enabled = false;
            this.WhiteTextBox.Location = new System.Drawing.Point(73, 20);
            this.WhiteTextBox.Name = "WhiteTextBox";
            this.WhiteTextBox.Size = new System.Drawing.Size(100, 20);
            this.WhiteTextBox.TabIndex = 5;
            // 
            // PinkRadioButton
            // 
            this.PinkRadioButton.AutoSize = true;
            this.PinkRadioButton.Location = new System.Drawing.Point(7, 92);
            this.PinkRadioButton.Name = "PinkRadioButton";
            this.PinkRadioButton.Size = new System.Drawing.Size(46, 17);
            this.PinkRadioButton.TabIndex = 4;
            this.PinkRadioButton.TabStop = true;
            this.PinkRadioButton.Text = "Pink";
            this.PinkRadioButton.UseVisualStyleBackColor = true;
            // 
            // GreenRadioButton
            // 
            this.GreenRadioButton.AutoSize = true;
            this.GreenRadioButton.Location = new System.Drawing.Point(7, 68);
            this.GreenRadioButton.Name = "GreenRadioButton";
            this.GreenRadioButton.Size = new System.Drawing.Size(54, 17);
            this.GreenRadioButton.TabIndex = 3;
            this.GreenRadioButton.Text = "Green";
            this.GreenRadioButton.UseVisualStyleBackColor = true;
            // 
            // BlueRadioButton
            // 
            this.BlueRadioButton.AutoSize = true;
            this.BlueRadioButton.Location = new System.Drawing.Point(7, 44);
            this.BlueRadioButton.Name = "BlueRadioButton";
            this.BlueRadioButton.Size = new System.Drawing.Size(46, 17);
            this.BlueRadioButton.TabIndex = 2;
            this.BlueRadioButton.Text = "Blue";
            this.BlueRadioButton.UseVisualStyleBackColor = true;
            // 
            // DefaultRadioButton
            // 
            this.DefaultRadioButton.AutoSize = true;
            this.DefaultRadioButton.Checked = true;
            this.DefaultRadioButton.Location = new System.Drawing.Point(7, 20);
            this.DefaultRadioButton.Name = "DefaultRadioButton";
            this.DefaultRadioButton.Size = new System.Drawing.Size(59, 17);
            this.DefaultRadioButton.TabIndex = 1;
            this.DefaultRadioButton.TabStop = true;
            this.DefaultRadioButton.Text = "Default";
            this.DefaultRadioButton.UseVisualStyleBackColor = true;
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(103, 282);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(75, 23);
            this.AcceptButton.TabIndex = 0;
            this.AcceptButton.Text = "Accept";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 336);
            this.Controls.Add(this.OptionsGroupBox);
            this.Controls.Add(this.ColourOptionsGroupBox);
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Options Form";
            this.ColourOptionsGroupBox.ResumeLayout(false);
            this.ColourOptionsGroupBox.PerformLayout();
            this.OptionsGroupBox.ResumeLayout(false);
            this.OptionsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ColourOptionsGroupBox;
        private System.Windows.Forms.CheckBox ShowCheckBox;
        private System.Windows.Forms.GroupBox OptionsGroupBox;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.RadioButton GreenRadioButton;
        private System.Windows.Forms.RadioButton BlueRadioButton;
        private System.Windows.Forms.RadioButton DefaultRadioButton;
        private System.Windows.Forms.RadioButton PinkRadioButton;
        private System.Windows.Forms.TextBox WhiteTextBox;
        private System.Windows.Forms.TextBox PinkTextBox;
        private System.Windows.Forms.TextBox GreenTextBox;
        private System.Windows.Forms.TextBox BlueTextBox;
    }
}

