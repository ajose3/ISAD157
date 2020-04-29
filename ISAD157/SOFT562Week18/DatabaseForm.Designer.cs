namespace SOFT562Week18
{
    partial class DatabaseForm
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
            this.dataGridViewFacebookUser = new System.Windows.Forms.DataGridView();
            this.closeButton = new System.Windows.Forms.Button();
            this.dataGridViewFacebookFriendships = new System.Windows.Forms.DataGridView();
            this.dataGridViewMessages = new System.Windows.Forms.DataGridView();
            this.dataGridViewUniversities = new System.Windows.Forms.DataGridView();
            this.dataGridViewWorkplace = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.userIDbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uniComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.workComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacebookUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacebookFriendships)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUniversities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkplace)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFacebookUser
            // 
            this.dataGridViewFacebookUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFacebookUser.Location = new System.Drawing.Point(312, 68);
            this.dataGridViewFacebookUser.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewFacebookUser.Name = "dataGridViewFacebookUser";
            this.dataGridViewFacebookUser.RowHeadersWidth = 51;
            this.dataGridViewFacebookUser.RowTemplate.Height = 24;
            this.dataGridViewFacebookUser.Size = new System.Drawing.Size(474, 294);
            this.dataGridViewFacebookUser.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(25, 21);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(96, 35);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Close ";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // dataGridViewFacebookFriendships
            // 
            this.dataGridViewFacebookFriendships.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFacebookFriendships.Location = new System.Drawing.Point(841, 68);
            this.dataGridViewFacebookFriendships.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewFacebookFriendships.Name = "dataGridViewFacebookFriendships";
            this.dataGridViewFacebookFriendships.RowHeadersWidth = 51;
            this.dataGridViewFacebookFriendships.RowTemplate.Height = 24;
            this.dataGridViewFacebookFriendships.Size = new System.Drawing.Size(384, 294);
            this.dataGridViewFacebookFriendships.TabIndex = 9;
            // 
            // dataGridViewMessages
            // 
            this.dataGridViewMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMessages.Location = new System.Drawing.Point(39, 436);
            this.dataGridViewMessages.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewMessages.Name = "dataGridViewMessages";
            this.dataGridViewMessages.RowHeadersWidth = 51;
            this.dataGridViewMessages.RowTemplate.Height = 24;
            this.dataGridViewMessages.Size = new System.Drawing.Size(473, 294);
            this.dataGridViewMessages.TabIndex = 10;
            // 
            // dataGridViewUniversities
            // 
            this.dataGridViewUniversities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUniversities.Location = new System.Drawing.Point(539, 436);
            this.dataGridViewUniversities.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewUniversities.Name = "dataGridViewUniversities";
            this.dataGridViewUniversities.RowHeadersWidth = 51;
            this.dataGridViewUniversities.RowTemplate.Height = 24;
            this.dataGridViewUniversities.Size = new System.Drawing.Size(360, 294);
            this.dataGridViewUniversities.TabIndex = 11;
            // 
            // dataGridViewWorkplace
            // 
            this.dataGridViewWorkplace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorkplace.Location = new System.Drawing.Point(932, 436);
            this.dataGridViewWorkplace.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewWorkplace.Name = "dataGridViewWorkplace";
            this.dataGridViewWorkplace.RowHeadersWidth = 51;
            this.dataGridViewWorkplace.RowTemplate.Height = 24;
            this.dataGridViewWorkplace.Size = new System.Drawing.Size(349, 294);
            this.dataGridViewWorkplace.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "User ID:";
            // 
            // userIDbox
            // 
            this.userIDbox.Location = new System.Drawing.Point(105, 112);
            this.userIDbox.Name = "userIDbox";
            this.userIDbox.Size = new System.Drawing.Size(100, 20);
            this.userIDbox.TabIndex = 14;
            this.userIDbox.TextChanged += new System.EventHandler(this.userIDbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "First Name:";
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(105, 155);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameBox.TabIndex = 16;
            this.firstNameBox.TextChanged += new System.EventHandler(this.firstNameBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Last Name:";
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(105, 193);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameBox.TabIndex = 18;
            this.lastNameBox.TextChanged += new System.EventHandler(this.lastNameBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Select University:";
            // 
            // uniComboBox
            // 
            this.uniComboBox.FormattingEnabled = true;
            this.uniComboBox.Items.AddRange(new object[] {
            "All"});
            this.uniComboBox.Location = new System.Drawing.Point(107, 255);
            this.uniComboBox.Name = "uniComboBox";
            this.uniComboBox.Size = new System.Drawing.Size(180, 21);
            this.uniComboBox.TabIndex = 20;
            this.uniComboBox.SelectedIndexChanged += new System.EventHandler(this.uniComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Select Workplace:";
            // 
            // workComboBox
            // 
            this.workComboBox.FormattingEnabled = true;
            this.workComboBox.Items.AddRange(new object[] {
            "All"});
            this.workComboBox.Location = new System.Drawing.Point(108, 292);
            this.workComboBox.Name = "workComboBox";
            this.workComboBox.Size = new System.Drawing.Size(179, 21);
            this.workComboBox.TabIndex = 22;
            this.workComboBox.SelectedIndexChanged += new System.EventHandler(this.workComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Messages Table:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(312, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Facebook Users Table:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(838, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Facebook Friendships Table:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(536, 406);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Universities Table:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(929, 406);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Workplace Table:";
            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.workComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uniComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userIDbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewWorkplace);
            this.Controls.Add(this.dataGridViewUniversities);
            this.Controls.Add(this.dataGridViewMessages);
            this.Controls.Add(this.dataGridViewFacebookFriendships);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.dataGridViewFacebookUser);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DatabaseForm";
            this.Text = "Database Form Test";
            this.Load += new System.EventHandler(this.DatabaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacebookUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacebookFriendships)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUniversities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkplace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFacebookUser;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridView dataGridViewFacebookFriendships;
        private System.Windows.Forms.DataGridView dataGridViewMessages;
        private System.Windows.Forms.DataGridView dataGridViewUniversities;
        private System.Windows.Forms.DataGridView dataGridViewWorkplace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userIDbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox uniComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox workComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

