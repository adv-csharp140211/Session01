namespace App01
{
    partial class Form1
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
            labelA = new Label();
            labelB = new Label();
            textBoxA = new TextBox();
            textBoxB = new TextBox();
            buttonAdd = new Button();
            buttonSub = new Button();
            buttonMul = new Button();
            buttonDiv = new Button();
            label1 = new Label();
            textBoxResult = new TextBox();
            buttonUsers = new Button();
            SuspendLayout();
            // 
            // labelA
            // 
            labelA.AutoSize = true;
            labelA.Location = new Point(48, 30);
            labelA.Name = "labelA";
            labelA.Size = new Size(15, 15);
            labelA.TabIndex = 0;
            labelA.Text = "A";
            // 
            // labelB
            // 
            labelB.AutoSize = true;
            labelB.Location = new Point(48, 59);
            labelB.Name = "labelB";
            labelB.Size = new Size(14, 15);
            labelB.TabIndex = 1;
            labelB.Text = "B";
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(92, 27);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(345, 23);
            textBoxA.TabIndex = 2;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(92, 56);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(345, 23);
            textBoxB.TabIndex = 3;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(92, 85);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(65, 23);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "➕";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonSub
            // 
            buttonSub.Location = new Point(163, 85);
            buttonSub.Name = "buttonSub";
            buttonSub.Size = new Size(65, 23);
            buttonSub.TabIndex = 5;
            buttonSub.Text = "➖";
            buttonSub.UseVisualStyleBackColor = true;
            buttonSub.Click += buttonSub_Click;
            // 
            // buttonMul
            // 
            buttonMul.Location = new Point(234, 85);
            buttonMul.Name = "buttonMul";
            buttonMul.Size = new Size(65, 23);
            buttonMul.TabIndex = 6;
            buttonMul.Text = "✖️";
            buttonMul.UseVisualStyleBackColor = true;
            buttonMul.Click += buttonMul_Click;
            // 
            // buttonDiv
            // 
            buttonDiv.Location = new Point(305, 85);
            buttonDiv.Name = "buttonDiv";
            buttonDiv.Size = new Size(65, 23);
            buttonDiv.TabIndex = 7;
            buttonDiv.Text = "➗";
            buttonDiv.UseVisualStyleBackColor = true;
            buttonDiv.Click += buttonDiv_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 124);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 8;
            label1.Text = "Result";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(92, 121);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(345, 23);
            textBoxResult.TabIndex = 9;
            // 
            // buttonUsers
            // 
            buttonUsers.Location = new Point(92, 186);
            buttonUsers.Name = "buttonUsers";
            buttonUsers.Size = new Size(75, 23);
            buttonUsers.TabIndex = 10;
            buttonUsers.Text = "Users";
            buttonUsers.UseVisualStyleBackColor = true;
            buttonUsers.Click += buttonUsers_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 221);
            Controls.Add(buttonUsers);
            Controls.Add(textBoxResult);
            Controls.Add(label1);
            Controls.Add(buttonDiv);
            Controls.Add(buttonMul);
            Controls.Add(buttonSub);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxB);
            Controls.Add(textBoxA);
            Controls.Add(labelB);
            Controls.Add(labelA);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelA;
        private Label labelB;
        private TextBox textBoxA;
        private TextBox textBoxB;
        private Button buttonAdd;
        private Button buttonSub;
        private Button buttonMul;
        private Button buttonDiv;
        private Label label1;
        private TextBox textBoxResult;
        private Button buttonUsers;
    }
}
