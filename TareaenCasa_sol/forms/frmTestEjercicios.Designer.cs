namespace TareaenCasa_sol.forms
{
    partial class frmTestEjercicios
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTabla = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnCalcularTabla = new System.Windows.Forms.Button();
            this.btnCalculaFactorial = new System.Windows.Forms.Button();
            this.txtResultadoFac = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la tabla de multiplicar";
            // 
            // txtTabla
            // 
            this.txtTabla.Location = new System.Drawing.Point(370, 62);
            this.txtTabla.Name = "txtTabla";
            this.txtTabla.Size = new System.Drawing.Size(100, 26);
            this.txtTabla.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese un entero";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(379, 305);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 26);
            this.txtNum.TabIndex = 3;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(95, 111);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(375, 164);
            this.txtResultado.TabIndex = 4;
            // 
            // btnCalcularTabla
            // 
            this.btnCalcularTabla.Location = new System.Drawing.Point(504, 57);
            this.btnCalcularTabla.Name = "btnCalcularTabla";
            this.btnCalcularTabla.Size = new System.Drawing.Size(124, 37);
            this.btnCalcularTabla.TabIndex = 5;
            this.btnCalcularTabla.Text = "Calcular Tabla";
            this.btnCalcularTabla.UseVisualStyleBackColor = true;
            this.btnCalcularTabla.Click += new System.EventHandler(this.btnCalcularTabla_Click);
            // 
            // btnCalculaFactorial
            // 
            this.btnCalculaFactorial.Location = new System.Drawing.Point(504, 303);
            this.btnCalculaFactorial.Name = "btnCalculaFactorial";
            this.btnCalculaFactorial.Size = new System.Drawing.Size(176, 31);
            this.btnCalculaFactorial.TabIndex = 6;
            this.btnCalculaFactorial.Text = "Calcula Factorial";
            this.btnCalculaFactorial.UseVisualStyleBackColor = true;
            this.btnCalculaFactorial.Click += new System.EventHandler(this.btnCalculaFactorial_Click);
            // 
            // txtResultadoFac
            // 
            this.txtResultadoFac.Location = new System.Drawing.Point(379, 337);
            this.txtResultadoFac.Name = "txtResultadoFac";
            this.txtResultadoFac.Size = new System.Drawing.Size(100, 26);
            this.txtResultadoFac.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "El factorial es";
            // 
            // frmTestEjercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 501);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResultadoFac);
            this.Controls.Add(this.btnCalculaFactorial);
            this.Controls.Add(this.btnCalcularTabla);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTabla);
            this.Controls.Add(this.label1);
            this.Name = "frmTestEjercicios";
            this.Text = "Tabla de multiplicar y factorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTabla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnCalcularTabla;
        private System.Windows.Forms.Button btnCalculaFactorial;
        private System.Windows.Forms.TextBox txtResultadoFac;
        private System.Windows.Forms.Label label3;
    }
}