namespace TrainOrgWinFormsApp.Forms
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
            labelName = new Label();
            textName = new TextBox();
            labelPassword = new Label();
            textPassword = new TextBox();
            labelStatus = new Label();
            buttonSave = new Button();
            labelRole = new Label();
            comboBoxRole = new ComboBox();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(12, 9);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Name";
            // 
            // textName
            // 
            textName.Location = new Point(75, 6);
            textName.Name = "textName";
            textName.Size = new Size(121, 23);
            textName.TabIndex = 1;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(12, 32);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(57, 15);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Password";
            // 
            // textPassword
            // 
            textPassword.Location = new Point(75, 29);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(121, 23);
            textPassword.TabIndex = 3;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(181, 9);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(0, 15);
            labelStatus.TabIndex = 5;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(713, 415);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += button1_Click;
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Location = new Point(13, 57);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(30, 15);
            labelRole.TabIndex = 7;
            labelRole.Text = "Role";
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(75, 54);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(121, 23);
            comboBoxRole.TabIndex = 8;
            comboBoxRole.SelectedIndexChanged += comboBoxRole_SelectedIndexChanged;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxRole);
            Controls.Add(labelRole);
            Controls.Add(buttonSave);
            Controls.Add(labelStatus);
            Controls.Add(textPassword);
            Controls.Add(labelPassword);
            Controls.Add(textName);
            Controls.Add(labelName);
            Name = "UserForm";
            Text = "UserForm";
            Load += UserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private TextBox textName;
        private Label labelPassword;
        private TextBox textPassword;
        private Label labelStatus;
        private Button buttonSave;
        private Label labelRole;
        private ComboBox comboBoxRole;
    }
}