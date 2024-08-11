namespace TrainOrgWinFormsApp
{
    partial class SessionForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelId = new Label();
            textBoxId = new TextBox();
            textBoxStartTime = new TextBox();
            textBoxEndTime = new TextBox();
            labelStartTime = new Label();
            labelEndTime = new Label();
            buttonSave = new Button();
            labelUser = new Label();
            textBoxUser = new TextBox();
            SuspendLayout();
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(12, 9);
            labelId.Name = "labelId";
            labelId.Size = new Size(21, 15);
            labelId.TabIndex = 0;
            labelId.Text = "ID:";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(79, 6);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(100, 23);
            textBoxId.TabIndex = 1;
            // 
            // textBoxStartTime
            // 
            textBoxStartTime.Location = new Point(79, 35);
            textBoxStartTime.Name = "textBoxStartTime";
            textBoxStartTime.Size = new Size(100, 23);
            textBoxStartTime.TabIndex = 2;
            // 
            // textBoxEndTime
            // 
            textBoxEndTime.Location = new Point(79, 67);
            textBoxEndTime.Name = "textBoxEndTime";
            textBoxEndTime.Size = new Size(100, 23);
            textBoxEndTime.TabIndex = 3;
            // 
            // labelStartTime
            // 
            labelStartTime.AutoSize = true;
            labelStartTime.Location = new Point(12, 38);
            labelStartTime.Name = "labelStartTime";
            labelStartTime.Size = new Size(61, 15);
            labelStartTime.TabIndex = 4;
            labelStartTime.Text = "Start time:";
            // 
            // labelEndTime
            // 
            labelEndTime.AutoSize = true;
            labelEndTime.Location = new Point(12, 67);
            labelEndTime.Name = "labelEndTime";
            labelEndTime.Size = new Size(57, 15);
            labelEndTime.TabIndex = 5;
            labelEndTime.Text = "End time:";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(105, 156);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "buttonSave";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Location = new Point(12, 96);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(33, 15);
            labelUser.TabIndex = 8;
            labelUser.Text = "User:";
            labelUser.Click += label1_Click;
            // 
            // textBoxUser
            // 
            textBoxUser.Location = new Point(79, 96);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(100, 23);
            textBoxUser.TabIndex = 7;
            // 
            // SessionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelUser);
            Controls.Add(textBoxUser);
            Controls.Add(buttonSave);
            Controls.Add(labelEndTime);
            Controls.Add(labelStartTime);
            Controls.Add(textBoxEndTime);
            Controls.Add(textBoxStartTime);
            Controls.Add(textBoxId);
            Controls.Add(labelId);
            Name = "SessionForm";
            Text = "Session";
            Load += SessionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelId;
        private TextBox textBoxId;
        private TextBox textBoxStartTime;
        private TextBox textBoxEndTime;
        private Label labelStartTime;
        private Label labelEndTime;
        private Button buttonSave;
        private Label labelUser;
        private TextBox textBoxUser;
    }
}
