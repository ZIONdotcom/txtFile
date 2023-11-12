namespace txtFile
{
    partial class FrmStudentRecord
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
            this.uploadbtn = new System.Windows.Forms.Button();
            this.Findbtn = new System.Windows.Forms.Button();
            this.regbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lvdisplay = new System.Windows.Forms.ListView();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // uploadbtn
            // 
            this.uploadbtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.uploadbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadbtn.Location = new System.Drawing.Point(438, 201);
            this.uploadbtn.Name = "uploadbtn";
            this.uploadbtn.Size = new System.Drawing.Size(97, 35);
            this.uploadbtn.TabIndex = 9;
            this.uploadbtn.Text = "Upload";
            this.uploadbtn.UseVisualStyleBackColor = false;
            this.uploadbtn.Click += new System.EventHandler(this.uploadbtn_Click);
            // 
            // Findbtn
            // 
            this.Findbtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Findbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Findbtn.Location = new System.Drawing.Point(438, 137);
            this.Findbtn.Name = "Findbtn";
            this.Findbtn.Size = new System.Drawing.Size(97, 35);
            this.Findbtn.TabIndex = 8;
            this.Findbtn.Text = "Find";
            this.Findbtn.UseVisualStyleBackColor = false;
            this.Findbtn.Click += new System.EventHandler(this.Findbtn_Click);
            // 
            // regbtn
            // 
            this.regbtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.regbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.regbtn.Location = new System.Drawing.Point(438, 74);
            this.regbtn.Name = "regbtn";
            this.regbtn.Size = new System.Drawing.Size(97, 35);
            this.regbtn.TabIndex = 7;
            this.regbtn.Text = "Register";
            this.regbtn.UseVisualStyleBackColor = false;
            this.regbtn.Click += new System.EventHandler(this.regbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "View Record";
            // 
            // lvdisplay
            // 
            this.lvdisplay.HideSelection = false;
            this.lvdisplay.Location = new System.Drawing.Point(43, 64);
            this.lvdisplay.Name = "lvdisplay";
            this.lvdisplay.Size = new System.Drawing.Size(360, 201);
            this.lvdisplay.TabIndex = 5;
            this.lvdisplay.UseCompatibleStateImageBehavior = false;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // FrmStudentRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(604, 296);
            this.Controls.Add(this.uploadbtn);
            this.Controls.Add(this.Findbtn);
            this.Controls.Add(this.regbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvdisplay);
            this.Name = "FrmStudentRecord";
            this.Text = "FrmStudentRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uploadbtn;
        private System.Windows.Forms.Button Findbtn;
        private System.Windows.Forms.Button regbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvdisplay;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}