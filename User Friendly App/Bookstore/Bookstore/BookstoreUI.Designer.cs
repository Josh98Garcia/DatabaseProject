namespace Bookstore
{
    partial class Bookstore
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
            this.uxInsert = new System.Windows.Forms.Button();
            this.uxSelect = new System.Windows.Forms.Button();
            this.uxInsFinDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxInsert
            // 
            this.uxInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxInsert.Location = new System.Drawing.Point(12, 13);
            this.uxInsert.Name = "uxInsert";
            this.uxInsert.Size = new System.Drawing.Size(155, 36);
            this.uxInsert.TabIndex = 2;
            this.uxInsert.Text = "Insert New Item";
            this.uxInsert.UseVisualStyleBackColor = true;
            // 
            // uxSelect
            // 
            this.uxSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSelect.Location = new System.Drawing.Point(173, 13);
            this.uxSelect.Name = "uxSelect";
            this.uxSelect.Size = new System.Drawing.Size(155, 36);
            this.uxSelect.TabIndex = 3;
            this.uxSelect.Text = "Find Existing Item";
            this.uxSelect.UseVisualStyleBackColor = true;
            // 
            // uxInsFinDescription
            // 
            this.uxInsFinDescription.Location = new System.Drawing.Point(13, 56);
            this.uxInsFinDescription.Multiline = true;
            this.uxInsFinDescription.Name = "uxInsFinDescription";
            this.uxInsFinDescription.Size = new System.Drawing.Size(314, 245);
            this.uxInsFinDescription.TabIndex = 4;
            this.uxInsFinDescription.Text = "Stuff goes here";
            // 
            // Bookstore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 313);
            this.Controls.Add(this.uxInsFinDescription);
            this.Controls.Add(this.uxSelect);
            this.Controls.Add(this.uxInsert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Bookstore";
            this.ShowIcon = false;
            this.Text = "Bookstore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button uxInsert;
        private System.Windows.Forms.Button uxSelect;
        private System.Windows.Forms.TextBox uxInsFinDescription;
    }
}

