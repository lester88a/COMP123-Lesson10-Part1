namespace COMP123_Lesson10_Part1
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
            this.SalesChannelGroupBox = new System.Windows.Forms.GroupBox();
            this.ShowCheckBox = new System.Windows.Forms.CheckBox();
            this.OptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SalesChannelGroupBox.SuspendLayout();
            this.OptionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalesChannelGroupBox
            // 
            this.SalesChannelGroupBox.Controls.Add(this.ShowCheckBox);
            this.SalesChannelGroupBox.Location = new System.Drawing.Point(12, 12);
            this.SalesChannelGroupBox.Name = "SalesChannelGroupBox";
            this.SalesChannelGroupBox.Size = new System.Drawing.Size(129, 77);
            this.SalesChannelGroupBox.TabIndex = 0;
            this.SalesChannelGroupBox.TabStop = false;
            this.SalesChannelGroupBox.Text = "Sales Channel";
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
            this.OptionsGroupBox.Controls.Add(this.SubmitButton);
            this.OptionsGroupBox.Location = new System.Drawing.Point(148, 13);
            this.OptionsGroupBox.Name = "OptionsGroupBox";
            this.OptionsGroupBox.Size = new System.Drawing.Size(356, 311);
            this.OptionsGroupBox.TabIndex = 1;
            this.OptionsGroupBox.TabStop = false;
            this.OptionsGroupBox.Text = "Options";
            this.OptionsGroupBox.Visible = false;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(142, 282);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 0;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 336);
            this.Controls.Add(this.OptionsGroupBox);
            this.Controls.Add(this.SalesChannelGroupBox);
            this.Name = "SalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales From";
            this.SalesChannelGroupBox.ResumeLayout(false);
            this.SalesChannelGroupBox.PerformLayout();
            this.OptionsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SalesChannelGroupBox;
        private System.Windows.Forms.CheckBox ShowCheckBox;
        private System.Windows.Forms.GroupBox OptionsGroupBox;
        private System.Windows.Forms.Button SubmitButton;
    }
}

