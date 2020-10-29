namespace ConvertidorGrados
{
    partial class Convertidor
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxWrite = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxResults = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCelToFah = new System.Windows.Forms.RadioButton();
            this.rbFahToCel = new System.Windows.Forms.RadioButton();
            this.btnConvert = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxWrite
            // 
            this.tbxWrite.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxWrite.Location = new System.Drawing.Point(25, 60);
            this.tbxWrite.Name = "tbxWrite";
            this.tbxWrite.Size = new System.Drawing.Size(355, 46);
            this.tbxWrite.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese los grados a convertir:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(22, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Resultados:";
            // 
            // tbxResults
            // 
            this.tbxResults.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxResults.Location = new System.Drawing.Point(27, 215);
            this.tbxResults.Name = "tbxResults";
            this.tbxResults.Size = new System.Drawing.Size(355, 46);
            this.tbxResults.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFahToCel);
            this.groupBox1.Controls.Add(this.rbCelToFah);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(416, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 133);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Convertir de:";
            // 
            // rbCelToFah
            // 
            this.rbCelToFah.AutoSize = true;
            this.rbCelToFah.Location = new System.Drawing.Point(6, 32);
            this.rbCelToFah.Name = "rbCelToFah";
            this.rbCelToFah.Size = new System.Drawing.Size(245, 29);
            this.rbCelToFah.TabIndex = 0;
            this.rbCelToFah.TabStop = true;
            this.rbCelToFah.Text = "Celsius a Fahrenheit";
            this.rbCelToFah.UseVisualStyleBackColor = true;
            // 
            // rbFahToCel
            // 
            this.rbFahToCel.AutoSize = true;
            this.rbFahToCel.Location = new System.Drawing.Point(6, 76);
            this.rbFahToCel.Name = "rbFahToCel";
            this.rbFahToCel.Size = new System.Drawing.Size(245, 29);
            this.rbFahToCel.TabIndex = 1;
            this.rbFahToCel.TabStop = true;
            this.rbFahToCel.Text = "Fahrenheit a Celsius";
            this.rbFahToCel.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConvert.Location = new System.Drawing.Point(454, 215);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(186, 46);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "Convertir";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbxResults);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxWrite);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(711, 300);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxWrite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxResults;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFahToCel;
        private System.Windows.Forms.RadioButton rbCelToFah;
        private System.Windows.Forms.Button btnConvert;
    }
}
