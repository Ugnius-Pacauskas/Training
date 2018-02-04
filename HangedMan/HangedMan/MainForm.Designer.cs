namespace HangedMan
{
    partial class MainForm
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
            this.SeacretWordLabel = new System.Windows.Forms.Label();
            this.WinStateLabel = new System.Windows.Forms.Label();
            this.LivesLabel = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SeacretWordLabel
            // 
            this.SeacretWordLabel.AutoSize = true;
            this.SeacretWordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.SeacretWordLabel.Location = new System.Drawing.Point(144, 38);
            this.SeacretWordLabel.Name = "SeacretWordLabel";
            this.SeacretWordLabel.Size = new System.Drawing.Size(86, 31);
            this.SeacretWordLabel.TabIndex = 0;
            this.SeacretWordLabel.Text = "label1";
            // 
            // WinStateLabel
            // 
            this.WinStateLabel.AutoSize = true;
            this.WinStateLabel.Location = new System.Drawing.Point(165, 98);
            this.WinStateLabel.Name = "WinStateLabel";
            this.WinStateLabel.Size = new System.Drawing.Size(35, 13);
            this.WinStateLabel.TabIndex = 1;
            this.WinStateLabel.Text = "label2";
            // 
            // LivesLabel
            // 
            this.LivesLabel.AutoSize = true;
            this.LivesLabel.Location = new System.Drawing.Point(231, 305);
            this.LivesLabel.Name = "LivesLabel";
            this.LivesLabel.Size = new System.Drawing.Size(35, 13);
            this.LivesLabel.TabIndex = 2;
            this.LivesLabel.Text = "label3";
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(150, 300);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 23);
            this.StartBtn.TabIndex = 3;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.LivesLabel);
            this.Controls.Add(this.WinStateLabel);
            this.Controls.Add(this.SeacretWordLabel);
            this.Name = "MainForm";
            this.Text = "HangedMan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SeacretWordLabel;
        private System.Windows.Forms.Label WinStateLabel;
        private System.Windows.Forms.Label LivesLabel;
        private System.Windows.Forms.Button StartBtn;
    }
}

