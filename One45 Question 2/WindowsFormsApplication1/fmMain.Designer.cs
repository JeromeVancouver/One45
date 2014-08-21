namespace WindowsFormsApplication1
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
            this.tbFile = new System.Windows.Forms.TextBox();
            this.btBrowse = new System.Windows.Forms.Button();
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbFile
            // 
            this.tbFile.Location = new System.Drawing.Point(13, 13);
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(715, 20);
            this.tbFile.TabIndex = 0;
            // 
            // btBrowse
            // 
            this.btBrowse.Location = new System.Drawing.Point(734, 10);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(75, 23);
            this.btBrowse.TabIndex = 1;
            this.btBrowse.Text = "Browse . . . ";
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // lbOutput
            // 
            this.lbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.ItemHeight = 20;
            this.lbOutput.Location = new System.Drawing.Point(13, 39);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(796, 464);
            this.lbOutput.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 525);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.btBrowse);
            this.Controls.Add(this.tbFile);
            this.Name = "Form1";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.Button btBrowse;
        private System.Windows.Forms.ListBox lbOutput;
    }
}

