namespace Proyecto_quince
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPrincipal = new TextBox();
            txtResultado = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnSubcadena = new Button();
            btnMayuscula = new Button();
            btnMinuscula = new Button();
            SuspendLayout();
            // 
            // txtPrincipal
            // 
            txtPrincipal.Location = new Point(58, 51);
            txtPrincipal.Name = "txtPrincipal";
            txtPrincipal.Size = new Size(290, 23);
            txtPrincipal.TabIndex = 0;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(58, 115);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(290, 23);
            txtResultado.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 33);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 2;
            label1.Text = "Cadena principal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 97);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 3;
            label2.Text = "Resultado";
            // 
            // btnSubcadena
            // 
            btnSubcadena.Location = new Point(58, 172);
            btnSubcadena.Name = "btnSubcadena";
            btnSubcadena.Size = new Size(75, 23);
            btnSubcadena.TabIndex = 4;
            btnSubcadena.Text = "Subcadena";
            btnSubcadena.UseVisualStyleBackColor = true;
            btnSubcadena.Click += btnSubcadena_Click;
            // 
            // btnMayuscula
            // 
            btnMayuscula.Location = new Point(169, 172);
            btnMayuscula.Name = "btnMayuscula";
            btnMayuscula.Size = new Size(75, 23);
            btnMayuscula.TabIndex = 5;
            btnMayuscula.Text = "Mayuscula";
            btnMayuscula.UseVisualStyleBackColor = true;
            btnMayuscula.Click += btnMayuscula_Click;
            // 
            // btnMinuscula
            // 
            btnMinuscula.Location = new Point(273, 172);
            btnMinuscula.Name = "btnMinuscula";
            btnMinuscula.Size = new Size(75, 23);
            btnMinuscula.TabIndex = 6;
            btnMinuscula.Text = "Minuscula";
            btnMinuscula.UseVisualStyleBackColor = true;
            btnMinuscula.Click += btnMinuscula_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 222);
            Controls.Add(btnMinuscula);
            Controls.Add(btnMayuscula);
            Controls.Add(btnSubcadena);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtResultado);
            Controls.Add(txtPrincipal);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPrincipal;
        private TextBox txtResultado;
        private Label label1;
        private Label label2;
        private Button btnSubcadena;
        private Button btnMayuscula;
        private Button btnMinuscula;
    }
}
