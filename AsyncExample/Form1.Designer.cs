namespace AsyncExample
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
            this.btnProcessFile = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCountNonAsync = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProcessFile
            // 
            this.btnProcessFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessFile.Location = new System.Drawing.Point(243, 154);
            this.btnProcessFile.Name = "btnProcessFile";
            this.btnProcessFile.Size = new System.Drawing.Size(300, 93);
            this.btnProcessFile.TabIndex = 0;
            this.btnProcessFile.Text = "Process File";
            this.btnProcessFile.UseVisualStyleBackColor = true;
            this.btnProcessFile.Click += new System.EventHandler(this.btnProcessFile_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(243, 296);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 16);
            this.lblCount.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(633, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 93);
            this.button1.TabIndex = 2;
            this.button1.Text = "ProcessFileNonAsync";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCountNonAsync
            // 
            this.lblCountNonAsync.AutoSize = true;
            this.lblCountNonAsync.Location = new System.Drawing.Point(633, 254);
            this.lblCountNonAsync.Name = "lblCountNonAsync";
            this.lblCountNonAsync.Size = new System.Drawing.Size(0, 13);
            this.lblCountNonAsync.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 444);
            this.Controls.Add(this.lblCountNonAsync);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnProcessFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcessFile;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCountNonAsync;
    }
}

