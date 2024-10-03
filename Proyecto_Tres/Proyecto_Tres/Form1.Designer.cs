namespace Proyecto_Tres
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
            txtValorCompra = new TextBox();
            txtDescuento = new TextBox();
            txtValorCD = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // txtValorCompra
            // 
            txtValorCompra.Location = new Point(51, 39);
            txtValorCompra.Name = "txtValorCompra";
            txtValorCompra.Size = new Size(207, 23);
            txtValorCompra.TabIndex = 0;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(51, 98);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(207, 23);
            txtDescuento.TabIndex = 1;
            // 
            // txtValorCD
            // 
            txtValorCD.Location = new Point(51, 164);
            txtValorCD.Name = "txtValorCD";
            txtValorCD.Size = new Size(207, 23);
            txtValorCD.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 21);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 3;
            label1.Text = "Valor de la compra";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 80);
            label2.Name = "label2";
            label2.Size = new Size(134, 15);
            label2.TabIndex = 4;
            label2.Text = "Descuento que se aplica";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 146);
            label3.Name = "label3";
            label3.Size = new Size(186, 15);
            label3.TabIndex = 5;
            label3.Text = "Valor de la compra con descuento";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(114, 218);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 273);
            Controls.Add(btnCalcular);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtValorCD);
            Controls.Add(txtDescuento);
            Controls.Add(txtValorCompra);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValorCompra;
        private TextBox txtDescuento;
        private TextBox txtValorCD;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCalcular;
    }
}
