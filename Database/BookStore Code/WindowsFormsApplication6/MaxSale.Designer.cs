namespace WindowsFormsApplication6
{
    partial class MaxSale
    {

        private System.ComponentModel.IContainer components = null;

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

        private void InitializeComponent()
        {
            this.ByName = new System.Windows.Forms.Button();
            this.ByType = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.ByName.AutoSize = true;
            this.ByName.Location = new System.Drawing.Point(466, 217);
            this.ByName.Name = "ByName";
            this.ByName.Size = new System.Drawing.Size(348, 101);
            this.ByName.TabIndex = 0;
            this.ByName.Text = "Search by Name";
            this.ByName.UseVisualStyleBackColor = true;
            this.ByName.Click += new System.EventHandler(this.button1_Click);

            this.ByType.Location = new System.Drawing.Point(103, 217);
            this.ByType.Name = "ByType";
            this.ByType.Size = new System.Drawing.Size(311, 101);
            this.ByType.TabIndex = 2;
            this.ByType.Text = "Search by Type";
            this.ByType.UseVisualStyleBackColor = true;
            this.ByType.Click += new System.EventHandler(this.ByType_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1442, 989);
            this.Controls.Add(this.ByType);
            this.Controls.Add(this.ByName);
            this.Name = "MaxSale";
            this.Text = "MAX SALE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ByName;
        private System.Windows.Forms.Button ByType;
    }
}