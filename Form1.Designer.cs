namespace _0303
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
            StartButton = new Button();
            StopButton = new Button();
            numericupdown1 = new NumericUpDown();
            numericupdown2 = new NumericUpDown();
            numericupdown3 = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericupdown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericupdown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericupdown3).BeginInit();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            StartButton.Location = new Point(250, 344);
            StartButton.Margin = new Padding(3, 4, 3, 4);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(103, 41);
            StartButton.TabIndex = 0;
            StartButton.Text = "Старт";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // StopButton
            // 
            StopButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            StopButton.Location = new Point(466, 344);
            StopButton.Margin = new Padding(3, 4, 3, 4);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(104, 41);
            StopButton.TabIndex = 0;
            StopButton.Text = "Стоп";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click;
            // 
            // numericupdown1
            // 
            numericupdown1.Location = new Point(160, 234);
            numericupdown1.Margin = new Padding(3, 4, 3, 4);
            numericupdown1.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            numericupdown1.Minimum = new decimal(new int[] { 37, 0, 0, 0 });
            numericupdown1.Name = "numericupdown1";
            numericupdown1.Size = new Size(129, 27);
            numericupdown1.TabIndex = 1;
            numericupdown1.Value = new decimal(new int[] { 37, 0, 0, 0 });
            // 
            // numericupdown2
            // 
            numericupdown2.Location = new Point(356, 234);
            numericupdown2.Margin = new Padding(3, 4, 3, 4);
            numericupdown2.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            numericupdown2.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericupdown2.Name = "numericupdown2";
            numericupdown2.Size = new Size(139, 27);
            numericupdown2.TabIndex = 1;
            numericupdown2.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // numericupdown3
            // 
            numericupdown3.Location = new Point(585, 234);
            numericupdown3.Margin = new Padding(3, 4, 3, 4);
            numericupdown3.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericupdown3.Name = "numericupdown3";
            numericupdown3.Size = new Size(138, 27);
            numericupdown3.TabIndex = 1;
            numericupdown3.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(177, 185);
            label1.Name = "label1";
            label1.Size = new Size(89, 28);
            label1.TabIndex = 2;
            label1.Text = "Частота";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(335, 185);
            label2.Name = "label2";
            label2.Size = new Size(202, 28);
            label2.TabIndex = 2;
            label2.Text = "Довжина звучання";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(592, 185);
            label3.Name = "label3";
            label3.Size = new Size(131, 28);
            label3.TabIndex = 2;
            label3.Text = "К-сть звуків";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericupdown3);
            Controls.Add(numericupdown2);
            Controls.Add(numericupdown1);
            Controls.Add(StopButton);
            Controls.Add(StartButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericupdown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericupdown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericupdown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartButton;
        private Button StopButton;
        private NumericUpDown numericupdown1;
        private NumericUpDown numericupdown2;
        private NumericUpDown numericupdown3;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}