namespace Atracction_Park
{
    partial class Form1
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
            this.Locatation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Townshaft = new System.Windows.Forms.Label();
            this.LocationTextBox = new System.Windows.Forms.TextBox();
            this.CatTextBox = new System.Windows.Forms.TextBox();
            this.TSTextBox = new System.Windows.Forms.TextBox();
            this.ZOutButton = new System.Windows.Forms.Button();
            this.ZInButton = new System.Windows.Forms.Button();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Locatation
            // 
            this.Locatation.AutoSize = true;
            this.Locatation.Location = new System.Drawing.Point(12, 232);
            this.Locatation.Name = "Locatation";
            this.Locatation.Size = new System.Drawing.Size(48, 13);
            this.Locatation.TabIndex = 1;
            this.Locatation.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Catagory";
            // 
            // Townshaft
            // 
            this.Townshaft.AutoSize = true;
            this.Townshaft.Location = new System.Drawing.Point(12, 320);
            this.Townshaft.Name = "Townshaft";
            this.Townshaft.Size = new System.Drawing.Size(59, 13);
            this.Townshaft.TabIndex = 3;
            this.Townshaft.Text = "TownShaft";
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.Location = new System.Drawing.Point(100, 232);
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.Size = new System.Drawing.Size(100, 20);
            this.LocationTextBox.TabIndex = 4;
            this.LocationTextBox.TextChanged += new System.EventHandler(this.LocationTextBox_TextChanged);
            // 
            // CatTextBox
            // 
            this.CatTextBox.Location = new System.Drawing.Point(100, 273);
            this.CatTextBox.Name = "CatTextBox";
            this.CatTextBox.Size = new System.Drawing.Size(100, 20);
            this.CatTextBox.TabIndex = 5;
            // 
            // TSTextBox
            // 
            this.TSTextBox.Location = new System.Drawing.Point(100, 320);
            this.TSTextBox.Name = "TSTextBox";
            this.TSTextBox.Size = new System.Drawing.Size(100, 20);
            this.TSTextBox.TabIndex = 6;
            // 
            // ZOutButton
            // 
            this.ZOutButton.Location = new System.Drawing.Point(247, 60);
            this.ZOutButton.Name = "ZOutButton";
            this.ZOutButton.Size = new System.Drawing.Size(48, 41);
            this.ZOutButton.TabIndex = 7;
            this.ZOutButton.Text = "-";
            this.ZOutButton.UseVisualStyleBackColor = true;
            this.ZOutButton.Click += new System.EventHandler(this.ZOutButton_Click);
            // 
            // ZInButton
            // 
            this.ZInButton.Location = new System.Drawing.Point(247, 12);
            this.ZInButton.Name = "ZInButton";
            this.ZInButton.Size = new System.Drawing.Size(48, 42);
            this.ZInButton.TabIndex = 8;
            this.ZInButton.Text = "+";
            this.ZInButton.UseVisualStyleBackColor = true;
            this.ZInButton.Click += new System.EventHandler(this.ZInButton_Click);
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(100, 358);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(100, 20);
            this.CostTextBox.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Atracction_Park.Properties.Resources.map__100000000000000000_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cost";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "DisneyLand";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(247, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "DisneyWorld";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(247, 165);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Universal Studios";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.ZInButton);
            this.Controls.Add(this.ZOutButton);
            this.Controls.Add(this.TSTextBox);
            this.Controls.Add(this.CatTextBox);
            this.Controls.Add(this.LocationTextBox);
            this.Controls.Add(this.Townshaft);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Locatation);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Locatation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Townshaft;
        private System.Windows.Forms.TextBox LocationTextBox;
        private System.Windows.Forms.TextBox CatTextBox;
        private System.Windows.Forms.TextBox TSTextBox;
        private System.Windows.Forms.Button ZOutButton;
        private System.Windows.Forms.Button ZInButton;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

