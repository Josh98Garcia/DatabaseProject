namespace Bookstore
{
    partial class InsertNewItem
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
            this.uxInsertDisplay = new System.Windows.Forms.ListBox();
            this.uxInsertAuthor = new System.Windows.Forms.Button();
            this.uxInsertUser = new System.Windows.Forms.Button();
            this.uxInsertPublisher = new System.Windows.Forms.Button();
            this.uxInsertBook = new System.Windows.Forms.Button();
            this.uxInsertOrder = new System.Windows.Forms.Button();
            this.uxInsertContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxInsertDisplay
            // 
            this.uxInsertDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxInsertDisplay.FormattingEnabled = true;
            this.uxInsertDisplay.ItemHeight = 25;
            this.uxInsertDisplay.Location = new System.Drawing.Point(12, 86);
            this.uxInsertDisplay.Name = "uxInsertDisplay";
            this.uxInsertDisplay.Size = new System.Drawing.Size(424, 354);
            this.uxInsertDisplay.TabIndex = 4;
            // 
            // uxInsertAuthor
            // 
            this.uxInsertAuthor.Location = new System.Drawing.Point(12, 43);
            this.uxInsertAuthor.Name = "uxInsertAuthor";
            this.uxInsertAuthor.Size = new System.Drawing.Size(135, 37);
            this.uxInsertAuthor.TabIndex = 5;
            this.uxInsertAuthor.Text = "Insert New Author";
            this.uxInsertAuthor.UseVisualStyleBackColor = true;
            // 
            // uxInsertUser
            // 
            this.uxInsertUser.Location = new System.Drawing.Point(12, 5);
            this.uxInsertUser.Name = "uxInsertUser";
            this.uxInsertUser.Size = new System.Drawing.Size(135, 37);
            this.uxInsertUser.TabIndex = 6;
            this.uxInsertUser.Text = "Insert New User";
            this.uxInsertUser.UseVisualStyleBackColor = true;
            // 
            // uxInsertPublisher
            // 
            this.uxInsertPublisher.Location = new System.Drawing.Point(153, 5);
            this.uxInsertPublisher.Name = "uxInsertPublisher";
            this.uxInsertPublisher.Size = new System.Drawing.Size(150, 37);
            this.uxInsertPublisher.TabIndex = 7;
            this.uxInsertPublisher.Text = "Insert New Publisher";
            this.uxInsertPublisher.UseVisualStyleBackColor = true;
            // 
            // uxInsertBook
            // 
            this.uxInsertBook.Location = new System.Drawing.Point(153, 43);
            this.uxInsertBook.Name = "uxInsertBook";
            this.uxInsertBook.Size = new System.Drawing.Size(150, 37);
            this.uxInsertBook.TabIndex = 8;
            this.uxInsertBook.Text = "Insert New Book";
            this.uxInsertBook.UseVisualStyleBackColor = true;
            // 
            // uxInsertOrder
            // 
            this.uxInsertOrder.Location = new System.Drawing.Point(309, 5);
            this.uxInsertOrder.Name = "uxInsertOrder";
            this.uxInsertOrder.Size = new System.Drawing.Size(127, 37);
            this.uxInsertOrder.TabIndex = 9;
            this.uxInsertOrder.Text = "Insert New Order";
            this.uxInsertOrder.UseVisualStyleBackColor = true;
            // 
            // uxInsertContinue
            // 
            this.uxInsertContinue.Location = new System.Drawing.Point(309, 43);
            this.uxInsertContinue.Name = "uxInsertContinue";
            this.uxInsertContinue.Size = new System.Drawing.Size(127, 37);
            this.uxInsertContinue.TabIndex = 10;
            this.uxInsertContinue.Text = "Continue";
            this.uxInsertContinue.UseVisualStyleBackColor = true;
            // 
            // InsertNewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 450);
            this.Controls.Add(this.uxInsertContinue);
            this.Controls.Add(this.uxInsertOrder);
            this.Controls.Add(this.uxInsertBook);
            this.Controls.Add(this.uxInsertPublisher);
            this.Controls.Add(this.uxInsertUser);
            this.Controls.Add(this.uxInsertAuthor);
            this.Controls.Add(this.uxInsertDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "InsertNewItem";
            this.ShowIcon = false;
            this.Text = "Insert New Item";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox uxInsertDisplay;
        private System.Windows.Forms.Button uxInsertAuthor;
        private System.Windows.Forms.Button uxInsertUser;
        private System.Windows.Forms.Button uxInsertPublisher;
        private System.Windows.Forms.Button uxInsertBook;
        private System.Windows.Forms.Button uxInsertOrder;
        private System.Windows.Forms.Button uxInsertContinue;
    }
}