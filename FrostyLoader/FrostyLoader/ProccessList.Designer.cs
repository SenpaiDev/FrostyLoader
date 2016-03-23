namespace FrostyLoader {
    partial class ProccessList {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ProcessListINForm = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ProcessListINForm
            // 
            this.ProcessListINForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProcessListINForm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProcessListINForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProcessListINForm.FormattingEnabled = true;
            this.ProcessListINForm.Location = new System.Drawing.Point(0, 0);
            this.ProcessListINForm.Name = "ProcessListINForm";
            this.ProcessListINForm.Size = new System.Drawing.Size(284, 261);
            this.ProcessListINForm.TabIndex = 0;
            this.ProcessListINForm.DoubleClick += new System.EventHandler(this.ProcessListINForm_DoubleClick);
            // 
            // ProccessList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ProcessListINForm);
            this.Name = "ProccessList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProccessList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ProcessListINForm;
    }
}