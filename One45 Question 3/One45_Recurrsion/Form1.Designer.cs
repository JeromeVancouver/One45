namespace One45_Recurrsion
{
    partial class fmMain
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
            this.lbRecur = new System.Windows.Forms.ListBox();
            this.btGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbRecur
            // 
            this.lbRecur.FormattingEnabled = true;
            this.lbRecur.Location = new System.Drawing.Point(12, 38);
            this.lbRecur.Name = "lbRecur";
            this.lbRecur.Size = new System.Drawing.Size(177, 277);
            this.lbRecur.TabIndex = 0;
            // 
            // btGo
            // 
            this.btGo.Location = new System.Drawing.Point(13, 13);
            this.btGo.Name = "btGo";
            this.btGo.Size = new System.Drawing.Size(75, 23);
            this.btGo.TabIndex = 1;
            this.btGo.Text = "Go";
            this.btGo.UseVisualStyleBackColor = true;
            this.btGo.Click += new System.EventHandler(this.button1_Click);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 323);
            this.Controls.Add(this.btGo);
            this.Controls.Add(this.lbRecur);
            this.Name = "fmMain";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbRecur;
        private System.Windows.Forms.Button btGo;
    }
}

