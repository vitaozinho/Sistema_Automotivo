namespace Sistema_Automotivo
{
    partial class Compra
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
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCompra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combomarcas = new System.Windows.Forms.ComboBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.combomodelos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(200, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ano";
            // 
            // txtcor
            // 
            this.txtcor.Location = new System.Drawing.Point(292, 92);
            this.txtcor.Name = "txtcor";
            this.txtcor.Size = new System.Drawing.Size(87, 20);
            this.txtcor.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(242, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cor";
            // 
            // btnCompra
            // 
            this.btnCompra.Location = new System.Drawing.Point(98, 129);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(75, 23);
            this.btnCompra.TabIndex = 16;
            this.btnCompra.Text = "Comprar";
            this.btnCompra.UseVisualStyleBackColor = true;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Selecione o modelo :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Selecione a marca :";
            // 
            // combomarcas
            // 
            this.combomarcas.FormattingEnabled = true;
            this.combomarcas.Location = new System.Drawing.Point(200, 27);
            this.combomarcas.Name = "combomarcas";
            this.combomarcas.Size = new System.Drawing.Size(179, 21);
            this.combomarcas.TabIndex = 12;
            this.combomarcas.SelectedIndexChanged += new System.EventHandler(this.combomarcas_SelectedIndexChanged);
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(76, 88);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(100, 20);
            this.txtAno.TabIndex = 22;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(309, 128);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 23;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // combomodelos
            // 
            this.combomodelos.FormattingEnabled = true;
            this.combomodelos.Location = new System.Drawing.Point(200, 54);
            this.combomodelos.Name = "combomodelos";
            this.combomodelos.Size = new System.Drawing.Size(179, 21);
            this.combomodelos.TabIndex = 24;
            this.combomodelos.SelectedIndexChanged += new System.EventHandler(this.combomodelos_SelectedIndexChanged);
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 184);
            this.Controls.Add(this.combomodelos);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCompra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combomarcas);
            this.Name = "Compra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.Compra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combomarcas;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ComboBox combomodelos;

    }
}