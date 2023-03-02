namespace Stitch_Pattern
{
    partial class Stiches
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stiches));
            this.btnGenerate = new System.Windows.Forms.Button();
            this.pnlStitchDisplay = new System.Windows.Forms.Panel();
            this.tbrX = new System.Windows.Forms.TrackBar();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.tbrY = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tbrX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrY)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(338, 12);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // pnlStitchDisplay
            // 
            this.pnlStitchDisplay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlStitchDisplay.Location = new System.Drawing.Point(12, 61);
            this.pnlStitchDisplay.Name = "pnlStitchDisplay";
            this.pnlStitchDisplay.Size = new System.Drawing.Size(450, 450);
            this.pnlStitchDisplay.TabIndex = 3;
            // 
            // tbrX
            // 
            this.tbrX.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbrX.Location = new System.Drawing.Point(12, 10);
            this.tbrX.Maximum = 30;
            this.tbrX.Minimum = 1;
            this.tbrX.Name = "tbrX";
            this.tbrX.Size = new System.Drawing.Size(157, 45);
            this.tbrX.TabIndex = 4;
            this.tbrX.Value = 15;
            this.tbrX.Scroll += new System.EventHandler(this.tbrX_Scroll);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblX.Location = new System.Drawing.Point(12, 41);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(19, 13);
            this.lblX.TabIndex = 11;
            this.lblX.Text = "15";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblY.Location = new System.Drawing.Point(175, 41);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(19, 13);
            this.lblY.TabIndex = 13;
            this.lblY.Text = "15";
            // 
            // tbrY
            // 
            this.tbrY.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbrY.Location = new System.Drawing.Point(175, 10);
            this.tbrY.Maximum = 30;
            this.tbrY.Minimum = 1;
            this.tbrY.Name = "tbrY";
            this.tbrY.Size = new System.Drawing.Size(157, 45);
            this.tbrY.TabIndex = 12;
            this.tbrY.Value = 15;
            this.tbrY.Scroll += new System.EventHandler(this.tbrY_Scroll);
            // 
            // Stiches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(488, 537);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.tbrY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.tbrX);
            this.Controls.Add(this.pnlStitchDisplay);
            this.Controls.Add(this.btnGenerate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stiches";
            this.Text = "Stiches";
            ((System.ComponentModel.ISupportInitialize)(this.tbrX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Panel pnlStitchDisplay;
        private System.Windows.Forms.TrackBar tbrX;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TrackBar tbrY;
    }
}

