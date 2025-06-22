namespace LegeHenne
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPath = new TextBox();
            cmdReadFromFile = new Button();
            txtTicks = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 17);
            label1.Name = "label1";
            label1.Size = new Size(481, 15);
            label1.TabIndex = 0;
            label1.Text = "Der Pfad ist C:\\Users\\myUserName\\source\\repos\\LegeHenne\\bin\\Debug\\net8.0-windows";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 57);
            label2.Name = "label2";
            label2.Size = new Size(270, 15);
            label2.TabIndex = 1;
            label2.Text = "Gewuenstes Ziel ist C:\\texte\\soft\\mql5\\offlineBars";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 246);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 2;
            label3.Text = "Anzahl erzeugte Ticks";
            // 
            // txtPath
            // 
            txtPath.Location = new Point(14, 133);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(238, 23);
            txtPath.TabIndex = 3;
            // 
            // cmdReadFromFile
            // 
            cmdReadFromFile.Location = new Point(19, 200);
            cmdReadFromFile.Name = "cmdReadFromFile";
            cmdReadFromFile.Size = new Size(151, 23);
            cmdReadFromFile.TabIndex = 4;
            cmdReadFromFile.Text = "Create the csv File";
            cmdReadFromFile.UseVisualStyleBackColor = true;
            cmdReadFromFile.Click += cmdReadFromFile_Click;
            // 
            // txtTicks
            // 
            txtTicks.Location = new Point(19, 264);
            txtTicks.Name = "txtTicks";
            txtTicks.Size = new Size(100, 23);
            txtTicks.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 115);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 6;
            label4.Text = "File name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 318);
            Controls.Add(label4);
            Controls.Add(txtTicks);
            Controls.Add(cmdReadFromFile);
            Controls.Add(txtPath);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPath;
        private Button cmdReadFromFile;
        private TextBox txtTicks;
        private Label label4;
    }
}
