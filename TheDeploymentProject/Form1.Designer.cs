namespace TheDeploymentProject
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
            this.whitmanButton = new System.Windows.Forms.Button();
            this.authorLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nextVerseButton = new System.Windows.Forms.Button();
            this.poemTextbox = new System.Windows.Forms.RichTextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.RoberFrostButton = new System.Windows.Forms.Button();
            this.RWServiceButton = new System.Windows.Forms.Button();
            this.RJoeButton = new System.Windows.Forms.Button();
            this.LWallaceButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // whitmanButton
            // 
            this.whitmanButton.Location = new System.Drawing.Point(12, 12);
            this.whitmanButton.Name = "whitmanButton";
            this.whitmanButton.Size = new System.Drawing.Size(152, 45);
            this.whitmanButton.TabIndex = 0;
            this.whitmanButton.Text = "Walt Whitman";
            this.whitmanButton.UseVisualStyleBackColor = true;
            this.whitmanButton.Click += new System.EventHandler(this.whitmanButton_click);
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel.Location = new System.Drawing.Point(34, 47);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(99, 20);
            this.authorLabel.TabIndex = 1;
            this.authorLabel.Text = "poem author";
            this.authorLabel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nextVerseButton);
            this.panel1.Controls.Add(this.poemTextbox);
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Controls.Add(this.authorLabel);
            this.panel1.Location = new System.Drawing.Point(12, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 365);
            this.panel1.TabIndex = 2;
            // 
            // nextVerseButton
            // 
            this.nextVerseButton.Location = new System.Drawing.Point(41, 320);
            this.nextVerseButton.Name = "nextVerseButton";
            this.nextVerseButton.Size = new System.Drawing.Size(75, 23);
            this.nextVerseButton.TabIndex = 4;
            this.nextVerseButton.Text = "Next Verse";
            this.nextVerseButton.UseVisualStyleBackColor = true;
            this.nextVerseButton.Visible = false;
            this.nextVerseButton.Click += new System.EventHandler(this.nextVerseButton_Click);
            // 
            // poemTextbox
            // 
            this.poemTextbox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.poemTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.poemTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poemTextbox.Location = new System.Drawing.Point(24, 79);
            this.poemTextbox.Name = "poemTextbox";
            this.poemTextbox.Size = new System.Drawing.Size(693, 235);
            this.poemTextbox.TabIndex = 3;
            this.poemTextbox.Text = "poem text";
            this.poemTextbox.Visible = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(19, 15);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(115, 25);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "poem title";
            this.titleLabel.Visible = false;
            // 
            // RoberFrostButton
            // 
            this.RoberFrostButton.Location = new System.Drawing.Point(346, 12);
            this.RoberFrostButton.Name = "RoberFrostButton";
            this.RoberFrostButton.Size = new System.Drawing.Size(152, 45);
            this.RoberFrostButton.TabIndex = 3;
            this.RoberFrostButton.Text = "Robert Frost";
            this.RoberFrostButton.UseVisualStyleBackColor = true;
            this.RoberFrostButton.Click += new System.EventHandler(this.RoberFrostButton_Click);
            // 
            // RWServiceButton
            // 
            this.RWServiceButton.Location = new System.Drawing.Point(680, 12);
            this.RWServiceButton.Name = "RWServiceButton";
            this.RWServiceButton.Size = new System.Drawing.Size(152, 45);
            this.RWServiceButton.TabIndex = 4;
            this.RWServiceButton.Text = "Robert W. Service";
            this.RWServiceButton.UseVisualStyleBackColor = true;
            this.RWServiceButton.Click += new System.EventHandler(this.RWServiceButton_Click);
            // 
            // RJoeButton
            // 
            this.RJoeButton.Location = new System.Drawing.Point(513, 12);
            this.RJoeButton.Name = "RJoeButton";
            this.RJoeButton.Size = new System.Drawing.Size(152, 45);
            this.RJoeButton.TabIndex = 5;
            this.RJoeButton.Text = "Rita Joe";
            this.RJoeButton.UseVisualStyleBackColor = true;
            this.RJoeButton.Click += new System.EventHandler(this.RJoeButton_Click);
            // 
            // LWallaceButton
            // 
            this.LWallaceButton.Location = new System.Drawing.Point(179, 12);
            this.LWallaceButton.Name = "LWallaceButton";
            this.LWallaceButton.Size = new System.Drawing.Size(152, 45);
            this.LWallaceButton.TabIndex = 6;
            this.LWallaceButton.Text = "Lila Wallace";
            this.LWallaceButton.UseVisualStyleBackColor = true;
            this.LWallaceButton.Click += new System.EventHandler(this.LWallaceButton_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 519);
            this.Controls.Add(this.LWallaceButton);
            this.Controls.Add(this.RJoeButton);
            this.Controls.Add(this.RWServiceButton);
            this.Controls.Add(this.RoberFrostButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.whitmanButton);
            this.Name = "Form1";
            this.Text = "The Deployment Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button whitmanButton;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.RichTextBox poemTextbox;
        private System.Windows.Forms.Button nextVerseButton;
        private System.Windows.Forms.Button RoberFrostButton;
        private System.Windows.Forms.Button RWServiceButton;
        private System.Windows.Forms.Button RJoeButton;
        private System.Windows.Forms.Button LWallaceButton;
    }
}

