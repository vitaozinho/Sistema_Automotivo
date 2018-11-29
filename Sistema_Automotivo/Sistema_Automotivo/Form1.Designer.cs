namespace Sistema_Automotivo
{
    partial class Form1
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
            this.btnCad = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCad
            // 
            this.btnCad.Location = new System.Drawing.Point(36, 83);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(119, 57);
            this.btnCad.TabIndex = 0;
            this.btnCad.Text = "Cadastrar-se";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(182, 83);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(117, 57);
            this.btnLog.TabIndex = 1;
            this.btnLog.Text = "Login";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 206);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnCad);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Automotivo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.Button btnLog;
    }
}

