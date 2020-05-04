namespace Bookstore
{
    partial class FindExistingItems
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
            this.uxOutput = new System.Windows.Forms.ListBox();
            this.uxInput = new System.Windows.Forms.TextBox();
            this.uxSearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxOutput
            // 
            this.uxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxOutput.FormattingEnabled = true;
            this.uxOutput.ItemHeight = 25;
            this.uxOutput.Location = new System.Drawing.Point(12, 57);
            this.uxOutput.Name = "uxOutput";
            this.uxOutput.Size = new System.Drawing.Size(776, 379);
            this.uxOutput.TabIndex = 3;
            // 
            // uxInput
            // 
            this.uxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxInput.Location = new System.Drawing.Point(12, 14);
            this.uxInput.Name = "uxInput";
            this.uxInput.Size = new System.Drawing.Size(643, 36);
            this.uxInput.TabIndex = 2;
            // 
            // uxSearchButton
            // 
            this.uxSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSearchButton.Location = new System.Drawing.Point(661, 14);
            this.uxSearchButton.Name = "uxSearchButton";
            this.uxSearchButton.Size = new System.Drawing.Size(127, 37);
            this.uxSearchButton.TabIndex = 4;
            this.uxSearchButton.Text = "SEARCH";
            this.uxSearchButton.UseVisualStyleBackColor = true;
            // 
            // FindExistingItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxSearchButton);
            this.Controls.Add(this.uxOutput);
            this.Controls.Add(this.uxInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FindExistingItems";
            this.ShowIcon = false;
            this.Text = "Find Existing Items";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FindExistingItems_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox uxOutput;
        private System.Windows.Forms.TextBox uxInput;
        private System.Windows.Forms.Button uxSearchButton;


    }
}