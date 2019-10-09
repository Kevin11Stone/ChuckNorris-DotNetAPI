namespace ChuckNorrisWindowsForm
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
            this.btnRandomJoke = new System.Windows.Forms.Button();
            this.cmbxCategories = new System.Windows.Forms.ComboBox();
            this.lblCategories = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRandomJoke
            // 
            this.btnRandomJoke.Location = new System.Drawing.Point(37, 32);
            this.btnRandomJoke.Name = "btnRandomJoke";
            this.btnRandomJoke.Size = new System.Drawing.Size(120, 70);
            this.btnRandomJoke.TabIndex = 0;
            this.btnRandomJoke.Text = "Random Joke";
            this.btnRandomJoke.UseVisualStyleBackColor = true;
            this.btnRandomJoke.Click += new System.EventHandler(this.ButtonRandomJoke_Click);
            // 
            // cmbxCategories
            // 
            this.cmbxCategories.FormattingEnabled = true;
            this.cmbxCategories.Location = new System.Drawing.Point(37, 151);
            this.cmbxCategories.Name = "cmbxCategories";
            this.cmbxCategories.Size = new System.Drawing.Size(121, 21);
            this.cmbxCategories.TabIndex = 1;
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(34, 126);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(60, 13);
            this.lblCategories.TabIndex = 2;
            this.lblCategories.Text = "Categories:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 372);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.cmbxCategories);
            this.Controls.Add(this.btnRandomJoke);
            this.Name = "Form1";
            this.Text = "ChuckNorrisAPI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRandomJoke;
        private System.Windows.Forms.ComboBox cmbxCategories;
        private System.Windows.Forms.Label lblCategories;
    }
}

