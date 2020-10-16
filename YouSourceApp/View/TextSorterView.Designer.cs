namespace YouSourceApp
{
    partial class TextSorterView
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
            this.cbSortStrategy = new System.Windows.Forms.ComboBox();
            this.bnSortText = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.tbInputText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbSortStrategy
            // 
            this.cbSortStrategy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSortStrategy.FormattingEnabled = true;
            this.cbSortStrategy.Location = new System.Drawing.Point(12, 12);
            this.cbSortStrategy.Name = "cbSortStrategy";
            this.cbSortStrategy.Size = new System.Drawing.Size(121, 21);
            this.cbSortStrategy.TabIndex = 0;
            // 
            // bnSortText
            // 
            this.bnSortText.Location = new System.Drawing.Point(12, 102);
            this.bnSortText.Name = "bnSortText";
            this.bnSortText.Size = new System.Drawing.Size(75, 23);
            this.bnSortText.TabIndex = 1;
            this.bnSortText.Text = "Sort";
            this.bnSortText.UseVisualStyleBackColor = true;
            this.bnSortText.Click += new System.EventHandler(this.btnSortText_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(9, 76);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(37, 13);
            this.lblOutput.TabIndex = 3;
            this.lblOutput.Text = "output";
            // 
            // tbInputText
            // 
            this.tbInputText.Location = new System.Drawing.Point(12, 39);
            this.tbInputText.Name = "tbInputText";
            this.tbInputText.Size = new System.Drawing.Size(121, 20);
            this.tbInputText.TabIndex = 4;
            // 
            // TextSorterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 137);
            this.Controls.Add(this.tbInputText);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.bnSortText);
            this.Controls.Add(this.cbSortStrategy);
            this.Name = "TextSorterView";
            this.Text = "YouSourceApp";
            this.Load += new System.EventHandler(this.TextSorterView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSortStrategy;
        private System.Windows.Forms.Button bnSortText;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox tbInputText;
    }
}

