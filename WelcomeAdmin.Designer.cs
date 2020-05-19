namespace CSFinalProject_University_
{
    partial class WelcomeAdmin
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
            this.btnEvent = new System.Windows.Forms.Button();
            this.btnMentor = new System.Windows.Forms.Button();
            this.lblWelAdmin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEvent
            // 
            this.btnEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvent.Location = new System.Drawing.Point(162, 178);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Size = new System.Drawing.Size(379, 58);
            this.btnEvent.TabIndex = 0;
            this.btnEvent.Text = "Event";
            this.btnEvent.UseVisualStyleBackColor = true;
            this.btnEvent.Click += new System.EventHandler(this.btnEvent_Click);
            // 
            // btnMentor
            // 
            this.btnMentor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMentor.Location = new System.Drawing.Point(162, 270);
            this.btnMentor.Name = "btnMentor";
            this.btnMentor.Size = new System.Drawing.Size(379, 52);
            this.btnMentor.TabIndex = 1;
            this.btnMentor.Text = "Mentor";
            this.btnMentor.UseVisualStyleBackColor = true;
            this.btnMentor.Click += new System.EventHandler(this.btnMentor_Click);
            // 
            // lblWelAdmin
            // 
            this.lblWelAdmin.AutoSize = true;
            this.lblWelAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelAdmin.Location = new System.Drawing.Point(71, 68);
            this.lblWelAdmin.Name = "lblWelAdmin";
            this.lblWelAdmin.Size = new System.Drawing.Size(200, 29);
            this.lblWelAdmin.TabIndex = 2;
            this.lblWelAdmin.Text = "Welcome,Admin";
            // 
            // WelcomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWelAdmin);
            this.Controls.Add(this.btnMentor);
            this.Controls.Add(this.btnEvent);
            this.Name = "WelcomeAdmin";
            this.Text = "Welcome Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEvent;
        private System.Windows.Forms.Button btnMentor;
        private System.Windows.Forms.Label lblWelAdmin;
    }
}