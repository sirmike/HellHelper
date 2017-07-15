namespace HellHelper
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AssListShowBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.assListProgress = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DependencyFindBtn = new System.Windows.Forms.Button();
            this.DependencyAssVersionTB = new System.Windows.Forms.TextBox();
            this.DependencyAssNameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DependencyProgress = new System.Windows.Forms.ProgressBar();
            this.DependencyPathSelector = new HellHelper.PathSelector();
            this.AssListPathSelector = new HellHelper.PathSelector();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.AssListShowBtn);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.AssListPathSelector);
            this.groupBox1.Controls.Add(this.assListProgress);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assembly list";
            // 
            // AssListShowBtn
            // 
            this.AssListShowBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.AssListShowBtn.Location = new System.Drawing.Point(571, 19);
            this.AssListShowBtn.Name = "AssListShowBtn";
            this.AssListShowBtn.Size = new System.Drawing.Size(75, 23);
            this.AssListShowBtn.TabIndex = 6;
            this.AssListShowBtn.Text = "Show";
            this.AssListShowBtn.UseVisualStyleBackColor = true;
            this.AssListShowBtn.Click += new System.EventHandler(this.AssListShowBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(571, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // assListProgress
            // 
            this.assListProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.assListProgress.Location = new System.Drawing.Point(6, 51);
            this.assListProgress.Name = "assListProgress";
            this.assListProgress.Size = new System.Drawing.Size(641, 11);
            this.assListProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.assListProgress.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.DependencyProgress);
            this.groupBox2.Controls.Add(this.DependencyFindBtn);
            this.groupBox2.Controls.Add(this.DependencyPathSelector);
            this.groupBox2.Controls.Add(this.DependencyAssVersionTB);
            this.groupBox2.Controls.Add(this.DependencyAssNameTB);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(653, 99);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find dependency";
            // 
            // DependencyFindBtn
            // 
            this.DependencyFindBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DependencyFindBtn.Location = new System.Drawing.Point(571, 52);
            this.DependencyFindBtn.Name = "DependencyFindBtn";
            this.DependencyFindBtn.Size = new System.Drawing.Size(75, 23);
            this.DependencyFindBtn.TabIndex = 5;
            this.DependencyFindBtn.Text = "Find";
            this.DependencyFindBtn.UseVisualStyleBackColor = true;
            this.DependencyFindBtn.Click += new System.EventHandler(this.DependencyFindBtn_Click);
            // 
            // DependencyAssVersionTB
            // 
            this.DependencyAssVersionTB.Location = new System.Drawing.Point(490, 52);
            this.DependencyAssVersionTB.Name = "DependencyAssVersionTB";
            this.DependencyAssVersionTB.Size = new System.Drawing.Size(75, 20);
            this.DependencyAssVersionTB.TabIndex = 3;
            // 
            // DependencyAssNameTB
            // 
            this.DependencyAssNameTB.Location = new System.Drawing.Point(142, 52);
            this.DependencyAssNameTB.Name = "DependencyAssNameTB";
            this.DependencyAssNameTB.Size = new System.Drawing.Size(295, 20);
            this.DependencyAssNameTB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "version";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Searched assembly name";
            // 
            // DependencyProgress
            // 
            this.DependencyProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DependencyProgress.Location = new System.Drawing.Point(6, 81);
            this.DependencyProgress.Name = "DependencyProgress";
            this.DependencyProgress.Size = new System.Drawing.Size(640, 11);
            this.DependencyProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.DependencyProgress.TabIndex = 6;
            // 
            // DependencyPathSelector
            // 
            this.DependencyPathSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DependencyPathSelector.Location = new System.Drawing.Point(6, 19);
            this.DependencyPathSelector.Name = "DependencyPathSelector";
            this.DependencyPathSelector.Path = "";
            this.DependencyPathSelector.Size = new System.Drawing.Size(643, 27);
            this.DependencyPathSelector.TabIndex = 4;
            // 
            // AssListPathSelector
            // 
            this.AssListPathSelector.Location = new System.Drawing.Point(5, 18);
            this.AssListPathSelector.Name = "AssListPathSelector";
            this.AssListPathSelector.Path = "";
            this.AssListPathSelector.Size = new System.Drawing.Size(560, 27);
            this.AssListPathSelector.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 201);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Hell Helper";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar assListProgress;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox DependencyAssNameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DependencyAssVersionTB;
        private PathSelector DependencyPathSelector;
        private PathSelector AssListPathSelector;
        private System.Windows.Forms.Button AssListShowBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DependencyFindBtn;
        private System.Windows.Forms.ProgressBar DependencyProgress;
    }
}

