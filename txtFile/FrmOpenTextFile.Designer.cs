namespace txtFile
{
    partial class FrmOpenTextFile
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.lvShowText = new System.Windows.Forms.ListView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(267, 268);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(85, 24);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lvShowText
            // 
            this.lvShowText.HideSelection = false;
            this.lvShowText.Location = new System.Drawing.Point(59, 29);
            this.lvShowText.Name = "lvShowText";
            this.lvShowText.Size = new System.Drawing.Size(530, 213);
            this.lvShowText.TabIndex = 2;
            this.lvShowText.UseCompatibleStateImageBehavior = false;
            this.lvShowText.View = System.Windows.Forms.View.Tile;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmOpenTextFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(673, 320);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lvShowText);
            this.Name = "FrmOpenTextFile";
            this.Text = "FrmOpenTextFile";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ListView lvShowText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}