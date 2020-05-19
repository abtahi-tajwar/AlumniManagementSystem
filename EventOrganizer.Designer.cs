namespace CSFinalProject_University_
{
    partial class EventOrganizer
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
            this.btnEAdd = new System.Windows.Forms.Button();
            this.btnEDel = new System.Windows.Forms.Button();
            this.lblEventOrg = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEAdd
            // 
            this.btnEAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEAdd.Location = new System.Drawing.Point(170, 341);
            this.btnEAdd.Name = "btnEAdd";
            this.btnEAdd.Size = new System.Drawing.Size(126, 58);
            this.btnEAdd.TabIndex = 0;
            this.btnEAdd.Text = "Add";
            this.btnEAdd.UseVisualStyleBackColor = true;
            // 
            // btnEDel
            // 
            this.btnEDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEDel.Location = new System.Drawing.Point(417, 341);
            this.btnEDel.Name = "btnEDel";
            this.btnEDel.Size = new System.Drawing.Size(108, 58);
            this.btnEDel.TabIndex = 1;
            this.btnEDel.Text = "Delete";
            this.btnEDel.UseVisualStyleBackColor = true;
            // 
            // lblEventOrg
            // 
            this.lblEventOrg.AutoSize = true;
            this.lblEventOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventOrg.Location = new System.Drawing.Point(53, 48);
            this.lblEventOrg.Name = "lblEventOrg";
            this.lblEventOrg.Size = new System.Drawing.Size(209, 29);
            this.lblEventOrg.TabIndex = 2;
            this.lblEventOrg.Text = "Organize Event:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(655, 376);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(105, 46);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // EventOrganizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblEventOrg);
            this.Controls.Add(this.btnEDel);
            this.Controls.Add(this.btnEAdd);
            this.Name = "EventOrganizer";
            this.Text = "Event Organizer";
            this.Load += new System.EventHandler(this.EventOrganizer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEAdd;
        private System.Windows.Forms.Button btnEDel;
        private System.Windows.Forms.Label lblEventOrg;
        private System.Windows.Forms.Button btnBack;
    }
}