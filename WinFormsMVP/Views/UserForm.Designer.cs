namespace WinFormsMVP.Views
{
    partial class UserForm
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
            this.userAddressLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchUserTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // userAddressLabel
            // 
            this.userAddressLabel.AutoSize = true;
            this.userAddressLabel.Location = new System.Drawing.Point(145, 138);
            this.userAddressLabel.Name = "userAddressLabel";
            this.userAddressLabel.Size = new System.Drawing.Size(33, 12);
            this.userAddressLabel.TabIndex = 7;
            this.userAddressLabel.Text = "label2";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(87, 138);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(33, 12);
            this.userNameLabel.TabIndex = 6;
            this.userNameLabel.Text = "label1";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(195, 89);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Button";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchUserTextBox
            // 
            this.searchUserTextBox.Location = new System.Drawing.Point(89, 89);
            this.searchUserTextBox.Name = "searchUserTextBox";
            this.searchUserTextBox.Size = new System.Drawing.Size(100, 22);
            this.searchUserTextBox.TabIndex = 4;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 263);
            this.Controls.Add(this.userAddressLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchUserTextBox);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userAddressLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchUserTextBox;
    }
}