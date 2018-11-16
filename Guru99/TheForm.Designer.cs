namespace Guru99
{
    partial class Add
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
            this.button1 = new System.Windows.Forms.Button();
            this.TexBox = new System.Windows.Forms.TextBox();
            this.NumberHandler = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Reminder2 = new System.Windows.Forms.Label();
            this.Reminder1 = new System.Windows.Forms.Label();
            this.Reminder3 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumberHandler)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 225);
            this.button1.TabIndex = 0;
            this.button1.Text = "Press me";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TexBox
            // 
            this.TexBox.Location = new System.Drawing.Point(192, 12);
            this.TexBox.Multiline = true;
            this.TexBox.Name = "TexBox";
            this.TexBox.Size = new System.Drawing.Size(985, 709);
            this.TexBox.TabIndex = 1;
            // 
            // NumberHandler
            // 
            this.NumberHandler.Location = new System.Drawing.Point(4, 266);
            this.NumberHandler.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumberHandler.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumberHandler.Name = "NumberHandler";
            this.NumberHandler.Size = new System.Drawing.Size(151, 20);
            this.NumberHandler.TabIndex = 3;
            this.NumberHandler.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumberHandler.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Amount Of Lines";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Reminder2
            // 
            this.Reminder2.AutoSize = true;
            this.Reminder2.Location = new System.Drawing.Point(12, 378);
            this.Reminder2.MaximumSize = new System.Drawing.Size(150, 200);
            this.Reminder2.Name = "Reminder2";
            this.Reminder2.Size = new System.Drawing.Size(148, 52);
            this.Reminder2.TabIndex = 6;
            this.Reminder2.Text = "1. Change the amount of lines before pressing the button. For some reason it does" +
    "n\'t detect the starting number.";
            this.Reminder2.Click += new System.EventHandler(this.label3_Click);
            // 
            // Reminder1
            // 
            this.Reminder1.AutoSize = true;
            this.Reminder1.Location = new System.Drawing.Point(4, 356);
            this.Reminder1.Name = "Reminder1";
            this.Reminder1.Size = new System.Drawing.Size(80, 13);
            this.Reminder1.TabIndex = 7;
            this.Reminder1.Text = "HOW TO USE:";
            this.Reminder1.Click += new System.EventHandler(this.label2_Click);
            // 
            // Reminder3
            // 
            this.Reminder3.AutoSize = true;
            this.Reminder3.Location = new System.Drawing.Point(12, 443);
            this.Reminder3.Name = "Reminder3";
            this.Reminder3.Size = new System.Drawing.Size(96, 13);
            this.Reminder3.TabIndex = 8;
            this.Reminder3.Text = "2. Press the button";
            this.Reminder3.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 468);
            this.label3.MaximumSize = new System.Drawing.Size(150, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 39);
            this.label3.TabIndex = 9;
            this.label3.Text = "3. Do not touch the browser that opens. It might crash the program";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 733);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Reminder3);
            this.Controls.Add(this.Reminder1);
            this.Controls.Add(this.Reminder2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumberHandler);
            this.Controls.Add(this.TexBox);
            this.Controls.Add(this.button1);
            this.Name = "Add";
            this.Text = "TheForm";
            this.Load += new System.EventHandler(this.Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumberHandler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TexBox;
        private System.Windows.Forms.NumericUpDown NumberHandler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Reminder2;
        private System.Windows.Forms.Label Reminder1;
        private System.Windows.Forms.Label Reminder3;
        private System.Windows.Forms.Label label3;
    }
}