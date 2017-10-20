namespace AsyncAwaitTest
{
    partial class AsyncAwaitTest
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
            this.buttonProperCase = new System.Windows.Forms.Button();
            this.buttonUnproperCase = new System.Windows.Forms.Button();
            this.textBoxDebug = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonProperCase
            // 
            this.buttonProperCase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonProperCase.Location = new System.Drawing.Point(12, 12);
            this.buttonProperCase.Name = "buttonProperCase";
            this.buttonProperCase.Size = new System.Drawing.Size(310, 640);
            this.buttonProperCase.TabIndex = 0;
            this.buttonProperCase.Text = "Big Friendly Button";
            this.buttonProperCase.UseVisualStyleBackColor = true;
            this.buttonProperCase.Click += new System.EventHandler(this.buttonProperCase_Click);
            // 
            // buttonUnproperCase
            // 
            this.buttonUnproperCase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonUnproperCase.Location = new System.Drawing.Point(12, 658);
            this.buttonUnproperCase.Name = "buttonUnproperCase";
            this.buttonUnproperCase.Size = new System.Drawing.Size(310, 23);
            this.buttonUnproperCase.TabIndex = 1;
            this.buttonUnproperCase.Text = "Small Unfriendly Button";
            this.buttonUnproperCase.UseVisualStyleBackColor = true;
            this.buttonUnproperCase.Click += new System.EventHandler(this.buttonUnproperCase_Click);
            // 
            // textBoxDebug
            // 
            this.textBoxDebug.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDebug.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDebug.Location = new System.Drawing.Point(328, 12);
            this.textBoxDebug.Multiline = true;
            this.textBoxDebug.Name = "textBoxDebug";
            this.textBoxDebug.ReadOnly = true;
            this.textBoxDebug.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDebug.Size = new System.Drawing.Size(917, 669);
            this.textBoxDebug.TabIndex = 2;
            // 
            // AsyncAwaitTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 693);
            this.Controls.Add(this.textBoxDebug);
            this.Controls.Add(this.buttonUnproperCase);
            this.Controls.Add(this.buttonProperCase);
            this.Name = "AsyncAwaitTest";
            this.Text = "Async Await Test";
            this.Load += new System.EventHandler(this.AsyncAwaitTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonProperCase;
        private System.Windows.Forms.Button buttonUnproperCase;
        private System.Windows.Forms.TextBox textBoxDebug;
    }
}

