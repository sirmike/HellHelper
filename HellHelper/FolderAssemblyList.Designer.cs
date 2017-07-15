namespace HellHelper
{
    partial class FolderAssemblyList
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
            this.assemblyList = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // assemblyList
            // 
            this.assemblyList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assemblyList.Location = new System.Drawing.Point(0, 0);
            this.assemblyList.Multiline = true;
            this.assemblyList.Name = "assemblyList";
            this.assemblyList.ReadOnly = true;
            this.assemblyList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.assemblyList.Size = new System.Drawing.Size(673, 429);
            this.assemblyList.TabIndex = 0;
            // 
            // FolderAssemblyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 429);
            this.Controls.Add(this.assemblyList);
            this.KeyPreview = true;
            this.Name = "FolderAssemblyList";
            this.Text = "FolderAssemblyList";
            this.Load += new System.EventHandler(this.FolderAssemblyList_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FolderAssemblyList_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox assemblyList;
    }
}