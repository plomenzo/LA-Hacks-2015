namespace LA_Hacks_2015
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        //FormBorderStyle = FormBorderStyle.None;
        //WindowState = FormWindowState.Maximized;

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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.level_2_Button = new System.Windows.Forms.Label();
            this.level_1_Button = new System.Windows.Forms.Label();
            this.appTitle = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.TEST = new System.Windows.Forms.Button();
            this.introButton = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-3, -38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1456, 1036);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::LA_Hacks_2015.Properties.Resources.batman;
            this.tabPage1.Controls.Add(this.introButton);
            this.tabPage1.Controls.Add(this.level_2_Button);
            this.tabPage1.Controls.Add(this.level_1_Button);
            this.tabPage1.Controls.Add(this.appTitle);
            this.tabPage1.Controls.Add(this.exitLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1448, 1010);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // level_2_Button
            // 
            this.level_2_Button.AutoSize = true;
            this.level_2_Button.Enabled = false;
            this.level_2_Button.Font = new System.Drawing.Font("SketchFlow Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level_2_Button.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.level_2_Button.Location = new System.Drawing.Point(154, 416);
            this.level_2_Button.Name = "level_2_Button";
            this.level_2_Button.Size = new System.Drawing.Size(230, 21);
            this.level_2_Button.TabIndex = 3;
            this.level_2_Button.Text = "Level 2 If Statements";
            // 
            // level_1_Button
            // 
            this.level_1_Button.AutoSize = true;
            this.level_1_Button.Enabled = false;
            this.level_1_Button.Font = new System.Drawing.Font("SketchFlow Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level_1_Button.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.level_1_Button.Location = new System.Drawing.Point(154, 361);
            this.level_1_Button.Name = "level_1_Button";
            this.level_1_Button.Size = new System.Drawing.Size(203, 21);
            this.level_1_Button.TabIndex = 2;
            this.level_1_Button.Text = "Level 1 Data Types";
            this.level_1_Button.Click += new System.EventHandler(this.level_1_Button_Click);
            // 
            // appTitle
            // 
            this.appTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appTitle.AutoSize = true;
            this.appTitle.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appTitle.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.appTitle.Location = new System.Drawing.Point(459, 135);
            this.appTitle.Name = "appTitle";
            this.appTitle.Size = new System.Drawing.Size(497, 85);
            this.appTitle.TabIndex = 1;
            this.appTitle.Text = "Hackerman Coding";
            // 
            // exitLabel
            // 
            this.exitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitLabel.AutoSize = true;
            this.exitLabel.Font = new System.Drawing.Font("SketchFlow Print", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.exitLabel.Location = new System.Drawing.Point(1332, 58);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(85, 37);
            this.exitLabel.TabIndex = 0;
            this.exitLabel.Text = "Exit";
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(750, 390);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.TEST);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(750, 390);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // TEST
            // 
            this.TEST.Location = new System.Drawing.Point(375, 154);
            this.TEST.Name = "TEST";
            this.TEST.Size = new System.Drawing.Size(75, 23);
            this.TEST.TabIndex = 0;
            this.TEST.Text = "TEST";
            this.TEST.UseVisualStyleBackColor = true;
            // 
            // introButton
            // 
            this.introButton.AutoSize = true;
            this.introButton.Font = new System.Drawing.Font("SketchFlow Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.introButton.Location = new System.Drawing.Point(158, 316);
            this.introButton.Name = "introButton";
            this.introButton.Size = new System.Drawing.Size(62, 21);
            this.introButton.TabIndex = 4;
            this.introButton.Text = "Intro";
            this.introButton.Click += new System.EventHandler(this.introButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 842);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button TEST;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label appTitle;
        private System.Windows.Forms.Label level_1_Button;
        private System.Windows.Forms.Label level_2_Button;
        private System.Windows.Forms.Label introButton;
    }
}

