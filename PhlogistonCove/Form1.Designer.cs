namespace PhlogistonCove
{
    partial class Mainfrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainfrm));
            this.pnlMap = new System.Windows.Forms.Panel();
            this.lblSelectedCellInfo = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.tmrGeneration = new System.Windows.Forms.Timer(this.components);
            this.btnPause = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMap
            // 
            this.pnlMap.Location = new System.Drawing.Point(13, 13);
            this.pnlMap.Name = "pnlMap";
            this.pnlMap.Size = new System.Drawing.Size(510, 508);
            this.pnlMap.TabIndex = 0;
            // 
            // lblSelectedCellInfo
            // 
            this.lblSelectedCellInfo.AutoSize = true;
            this.lblSelectedCellInfo.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedCellInfo.Location = new System.Drawing.Point(12, 536);
            this.lblSelectedCellInfo.Name = "lblSelectedCellInfo";
            this.lblSelectedCellInfo.Size = new System.Drawing.Size(268, 25);
            this.lblSelectedCellInfo.TabIndex = 1;
            this.lblSelectedCellInfo.Text = "The desert waits to be monitered";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Khaki;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Beige;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReset.Location = new System.Drawing.Point(529, 13);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(279, 30);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset the Dunes";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tmrGeneration
            // 
            this.tmrGeneration.Enabled = true;
            this.tmrGeneration.Tick += new System.EventHandler(this.tmrGeneration_Tick);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPause.FlatAppearance.BorderColor = System.Drawing.Color.Beige;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(529, 49);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(279, 30);
            this.btnPause.TabIndex = 3;
            this.btnPause.Text = "Pause the desert";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(614, 338);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Mainfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 614);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblSelectedCellInfo);
            this.Controls.Add(this.pnlMap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(836, 653);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(836, 653);
            this.Name = "Mainfrm";
            this.Text = "Phlogiston Cove";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMap;
        private System.Windows.Forms.Label lblSelectedCellInfo;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Timer tmrGeneration;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

