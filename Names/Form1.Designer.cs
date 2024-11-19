namespace Names
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
            lblName = new Label();
            btnAddName = new Button();
            textBox1 = new TextBox();
            lstNames = new ListBox();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(168, 60);
            lblName.Name = "lblName";
            lblName.Size = new Size(67, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Names";
            // 
            // btnAddName
            // 
            btnAddName.Location = new Point(462, 157);
            btnAddName.Name = "btnAddName";
            btnAddName.Size = new Size(112, 34);
            btnAddName.TabIndex = 1;
            btnAddName.Text = "Add Name";
            btnAddName.UseVisualStyleBackColor = true;
            btnAddName.Click += btnAddName_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(421, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 31);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lstNames
            // 
            lstNames.FormattingEnabled = true;
            lstNames.ItemHeight = 25;
            lstNames.Location = new Point(168, 102);
            lstNames.Name = "lstNames";
            lstNames.Size = new Size(232, 179);
            lstNames.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstNames);
            Controls.Add(textBox1);
            Controls.Add(btnAddName);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Button btnAddName;
        private TextBox textBox1;
        private ListBox lstNames;
    }
}
