namespace class_gen
{
    partial class SaveForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveForm));
            this.CopyToClipboard = new System.Windows.Forms.Button();
            this.SaveAs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CopyToClipboard
            // 
            this.CopyToClipboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.CopyToClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyToClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CopyToClipboard.Location = new System.Drawing.Point(0, 0);
            this.CopyToClipboard.Name = "CopyToClipboard";
            this.CopyToClipboard.Size = new System.Drawing.Size(214, 57);
            this.CopyToClipboard.TabIndex = 0;
            this.CopyToClipboard.Text = "Copy to clipboard";
            this.CopyToClipboard.UseVisualStyleBackColor = true;
            this.CopyToClipboard.Click += new System.EventHandler(this.CopyToClipboard_Click);
            // 
            // SaveAs
            // 
            this.SaveAs.Dock = System.Windows.Forms.DockStyle.Top;
            this.SaveAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveAs.Location = new System.Drawing.Point(0, 57);
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(214, 57);
            this.SaveAs.TabIndex = 1;
            this.SaveAs.Text = "Save as";
            this.SaveAs.UseVisualStyleBackColor = true;
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // SaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 114);
            this.Controls.Add(this.SaveAs);
            this.Controls.Add(this.CopyToClipboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaveForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Export type";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CopyToClipboard;
        private System.Windows.Forms.Button SaveAs;
    }
}