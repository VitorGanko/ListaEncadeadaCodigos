namespace bubbleSortScript
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
            this.buttonInit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listaValues = new System.Windows.Forms.ListBox();
            this.tempoBubbleSort = new System.Windows.Forms.ListBox();
            this.ordenarTempo = new System.Windows.Forms.Button();
            this.zerarTudo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonInit
            // 
            this.buttonInit.Location = new System.Drawing.Point(12, 161);
            this.buttonInit.Name = "buttonInit";
            this.buttonInit.Size = new System.Drawing.Size(120, 24);
            this.buttonInit.TabIndex = 0;
            this.buttonInit.Text = "Começar BubbleSort";
            this.buttonInit.UseVisualStyleBackColor = true;
            this.buttonInit.Click += new System.EventHandler(this.buttonInit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tamanho da Lista";
            // 
            // listaValues
            // 
            this.listaValues.FormattingEnabled = true;
            this.listaValues.Location = new System.Drawing.Point(12, 60);
            this.listaValues.Name = "listaValues";
            this.listaValues.Size = new System.Drawing.Size(120, 95);
            this.listaValues.TabIndex = 3;
            // 
            // tempoBubbleSort
            // 
            this.tempoBubbleSort.FormattingEnabled = true;
            this.tempoBubbleSort.Location = new System.Drawing.Point(152, 60);
            this.tempoBubbleSort.Name = "tempoBubbleSort";
            this.tempoBubbleSort.Size = new System.Drawing.Size(418, 95);
            this.tempoBubbleSort.TabIndex = 5;
            // 
            // ordenarTempo
            // 
            this.ordenarTempo.Location = new System.Drawing.Point(152, 161);
            this.ordenarTempo.Name = "ordenarTempo";
            this.ordenarTempo.Size = new System.Drawing.Size(418, 24);
            this.ordenarTempo.TabIndex = 4;
            this.ordenarTempo.Text = "Ordenar Tempo";
            this.ordenarTempo.UseVisualStyleBackColor = true;
            this.ordenarTempo.Click += new System.EventHandler(this.ordenarTempo_Click);
            // 
            // zerarTudo
            // 
            this.zerarTudo.Location = new System.Drawing.Point(388, 9);
            this.zerarTudo.Name = "zerarTudo";
            this.zerarTudo.Size = new System.Drawing.Size(120, 24);
            this.zerarTudo.TabIndex = 6;
            this.zerarTudo.Text = "Zerar Tudo";
            this.zerarTudo.UseVisualStyleBackColor = true;
            this.zerarTudo.Click += new System.EventHandler(this.zerarTudo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 200);
            this.Controls.Add(this.zerarTudo);
            this.Controls.Add(this.tempoBubbleSort);
            this.Controls.Add(this.ordenarTempo);
            this.Controls.Add(this.listaValues);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonInit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listaValues;
        private System.Windows.Forms.ListBox tempoBubbleSort;
        private System.Windows.Forms.Button ordenarTempo;
        private System.Windows.Forms.Button zerarTudo;
    }
}

