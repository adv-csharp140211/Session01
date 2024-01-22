namespace App01.UI
{
    partial class FormUser
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
            label1 = new Label();
            textBoxId = new TextBox();
            textBoxFirstName = new TextBox();
            label2 = new Label();
            textBoxLastName = new TextBox();
            label3 = new Label();
            textBoxEmail = new TextBox();
            label4 = new Label();
            textBoxTel = new TextBox();
            label5 = new Label();
            buttonFirst = new Button();
            buttonPrev = new Button();
            buttonSave = new Button();
            buttonDel = new Button();
            buttonNew = new Button();
            buttonNext = new Button();
            buttonLast = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(157, 39);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(227, 36);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(242, 23);
            textBoxId.TabIndex = 1;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(227, 65);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(242, 23);
            textBoxFirstName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 68);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 2;
            label2.Text = "First Name";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(227, 94);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(242, 23);
            textBoxLastName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(157, 97);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 4;
            label3.Text = "Last Name";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(227, 123);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(242, 23);
            textBoxEmail.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(157, 126);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 6;
            label4.Text = "Email";
            // 
            // textBoxTel
            // 
            textBoxTel.Location = new Point(227, 152);
            textBoxTel.Name = "textBoxTel";
            textBoxTel.Size = new Size(242, 23);
            textBoxTel.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(157, 155);
            label5.Name = "label5";
            label5.Size = new Size(21, 15);
            label5.TabIndex = 8;
            label5.Text = "Tel";
            // 
            // buttonFirst
            // 
            buttonFirst.Location = new Point(99, 215);
            buttonFirst.Name = "buttonFirst";
            buttonFirst.Size = new Size(75, 23);
            buttonFirst.TabIndex = 10;
            buttonFirst.Text = "<<";
            buttonFirst.UseVisualStyleBackColor = true;
            // 
            // buttonPrev
            // 
            buttonPrev.Location = new Point(180, 215);
            buttonPrev.Name = "buttonPrev";
            buttonPrev.Size = new Size(75, 23);
            buttonPrev.TabIndex = 11;
            buttonPrev.Text = "<";
            buttonPrev.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(261, 215);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 12;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDel
            // 
            buttonDel.Location = new Point(342, 216);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(75, 22);
            buttonDel.TabIndex = 13;
            buttonDel.Text = "Del";
            buttonDel.UseVisualStyleBackColor = true;
            // 
            // buttonNew
            // 
            buttonNew.Location = new Point(423, 216);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(75, 23);
            buttonNew.TabIndex = 14;
            buttonNew.Text = "New";
            buttonNew.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(504, 216);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(75, 23);
            buttonNext.TabIndex = 15;
            buttonNext.Text = ">";
            buttonNext.UseVisualStyleBackColor = true;
            // 
            // buttonLast
            // 
            buttonLast.Location = new Point(585, 216);
            buttonLast.Name = "buttonLast";
            buttonLast.Size = new Size(75, 23);
            buttonLast.TabIndex = 16;
            buttonLast.Text = ">>";
            buttonLast.UseVisualStyleBackColor = true;
            // 
            // FormUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLast);
            Controls.Add(buttonNext);
            Controls.Add(buttonNew);
            Controls.Add(buttonDel);
            Controls.Add(buttonSave);
            Controls.Add(buttonPrev);
            Controls.Add(buttonFirst);
            Controls.Add(textBoxTel);
            Controls.Add(label5);
            Controls.Add(textBoxEmail);
            Controls.Add(label4);
            Controls.Add(textBoxLastName);
            Controls.Add(label3);
            Controls.Add(textBoxFirstName);
            Controls.Add(label2);
            Controls.Add(textBoxId);
            Controls.Add(label1);
            Name = "FormUser";
            Text = "FormUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxId;
        private TextBox textBoxFirstName;
        private Label label2;
        private TextBox textBoxLastName;
        private Label label3;
        private TextBox textBoxEmail;
        private Label label4;
        private TextBox textBoxTel;
        private Label label5;
        private Button buttonFirst;
        private Button buttonPrev;
        private Button buttonSave;
        private Button buttonDel;
        private Button buttonNew;
        private Button buttonNext;
        private Button buttonLast;
    }
}