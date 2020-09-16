namespace Example_1_ConfigureAwait
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonConfigureAwaitTrueAkaDefault = new System.Windows.Forms.Button();
            this.buttonConfigureAwaitFalse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonConfigureAwaitTrueAkaDefault
            // 
            this.buttonConfigureAwaitTrueAkaDefault.Location = new System.Drawing.Point(190, 12);
            this.buttonConfigureAwaitTrueAkaDefault.Name = "buttonConfigureAwaitTrueAkaDefault";
            this.buttonConfigureAwaitTrueAkaDefault.Size = new System.Drawing.Size(75, 23);
            this.buttonConfigureAwaitTrueAkaDefault.TabIndex = 0;
            this.buttonConfigureAwaitTrueAkaDefault.Text = "Go!";
            this.buttonConfigureAwaitTrueAkaDefault.UseVisualStyleBackColor = true;
            this.buttonConfigureAwaitTrueAkaDefault.Click += new System.EventHandler(this.buttonConfigureAwaitTrueAkaDefault_Click);
            // 
            // buttonConfigureAwaitFalse
            // 
            this.buttonConfigureAwaitFalse.Location = new System.Drawing.Point(190, 41);
            this.buttonConfigureAwaitFalse.Name = "buttonConfigureAwaitFalse";
            this.buttonConfigureAwaitFalse.Size = new System.Drawing.Size(75, 23);
            this.buttonConfigureAwaitFalse.TabIndex = 0;
            this.buttonConfigureAwaitFalse.Text = "Go!";
            this.buttonConfigureAwaitFalse.UseVisualStyleBackColor = true;
            this.buttonConfigureAwaitFalse.Click += new System.EventHandler(this.buttonConfigureAwaitFalse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Run with default";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Run with ConfigureAwait(false)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 84);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConfigureAwaitFalse);
            this.Controls.Add(this.buttonConfigureAwaitTrueAkaDefault);
            this.Name = "Form1";
            this.Text = "Demo: ConfigureAwait";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConfigureAwaitTrueAkaDefault;
        private System.Windows.Forms.Button buttonConfigureAwaitFalse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

