namespace WinFormsApp1
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
            TextInput1 = new TextBox();
            TextInput2 = new TextBox();
            TextResult = new TextBox();
            Add = new Button();
            Minus = new Button();
            Multiply = new Button();
            Divide = new Button();
            SuspendLayout();
            // 
            // TextInput1
            // 
            TextInput1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextInput1.Location = new Point(12, 26);
            TextInput1.Name = "TextInput1";
            TextInput1.Size = new Size(388, 23);
            TextInput1.TabIndex = 0;
            // 
            // TextInput2
            // 
            TextInput2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextInput2.Location = new Point(12, 113);
            TextInput2.Name = "TextInput2";
            TextInput2.Size = new Size(388, 23);
            TextInput2.TabIndex = 1;
            // 
            // TextResult
            // 
            TextResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextResult.Location = new Point(12, 201);
            TextResult.Name = "TextResult";
            TextResult.Size = new Size(388, 23);
            TextResult.TabIndex = 2;
            // 
            // Add
            // 
            Add.Location = new Point(12, 74);
            Add.Name = "Add";
            Add.Size = new Size(46, 23);
            Add.TabIndex = 3;
            Add.Text = "+";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Minus
            // 
            Minus.Location = new Point(131, 74);
            Minus.Name = "Minus";
            Minus.Size = new Size(46, 23);
            Minus.TabIndex = 4;
            Minus.Text = "-";
            Minus.UseVisualStyleBackColor = true;
            Minus.Click += Minus_Click;
            // 
            // Multiply
            // 
            Multiply.Location = new Point(245, 74);
            Multiply.Name = "Multiply";
            Multiply.Size = new Size(46, 23);
            Multiply.TabIndex = 5;
            Multiply.Text = "*";
            Multiply.UseVisualStyleBackColor = true;
            Multiply.Click += Multiply_Click;
            // 
            // Divide
            // 
            Divide.Location = new Point(354, 74);
            Divide.Name = "Divide";
            Divide.Size = new Size(46, 23);
            Divide.TabIndex = 6;
            Divide.Text = "/";
            Divide.UseVisualStyleBackColor = true;
            Divide.Click += Divide_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 277);
            Controls.Add(Divide);
            Controls.Add(Multiply);
            Controls.Add(Minus);
            Controls.Add(Add);
            Controls.Add(TextResult);
            Controls.Add(TextInput2);
            Controls.Add(TextInput1);
            Name = "Form1";
            Text = "My app";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextInput1;
        private TextBox TextInput2;
        private TextBox TextResult;
        private Button Add;
        private Button Minus;
        private Button Multiply;
        private Button Divide;
    }
}