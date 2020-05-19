namespace CSFinalProject_University_
{
    partial class Mentorship
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
            this.btnMAdd = new System.Windows.Forms.Button();
            this.btnMDel = new System.Windows.Forms.Button();
            this.lblMentor = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMAdd
            // 
            this.btnMAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMAdd.Location = new System.Drawing.Point(187, 328);
            this.btnMAdd.Name = "btnMAdd";
            this.btnMAdd.Size = new System.Drawing.Size(125, 49);
            this.btnMAdd.TabIndex = 0;
            this.btnMAdd.Text = "Add";
            this.btnMAdd.UseVisualStyleBackColor = true;
            // 
            // btnMDel
            // 
            this.btnMDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMDel.Location = new System.Drawing.Point(400, 328);
            this.btnMDel.Name = "btnMDel";
            this.btnMDel.Size = new System.Drawing.Size(116, 49);
            this.btnMDel.TabIndex = 1;
            this.btnMDel.Text = "Delete";
            this.btnMDel.UseVisualStyleBackColor = true;
            // 
            // lblMentor
            // 
            this.lblMentor.AutoSize = true;
            this.lblMentor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMentor.Location = new System.Drawing.Point(60, 57);
            this.lblMentor.Name = "lblMentor";
            this.lblMentor.Size = new System.Drawing.Size(148, 29);
            this.lblMentor.TabIndex = 2;
            this.lblMentor.Text = "Mentorship";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(604, 375);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(132, 41);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Mentorship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblMentor);
            this.Controls.Add(this.btnMDel);
            this.Controls.Add(this.btnMAdd);
            this.Name = "Mentorship";
            this.Text = "Mentorship";
            this.Load += new System.EventHandler(this.Mentorship_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMAdd;
        private System.Windows.Forms.Button btnMDel;
        private System.Windows.Forms.Label lblMentor;
        private System.Windows.Forms.Button btnBack;
    }
}