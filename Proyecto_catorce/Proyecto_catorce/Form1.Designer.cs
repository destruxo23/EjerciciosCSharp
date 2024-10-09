namespace Proyecto_catorce
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
            txtCompra = new TextBox();
            txtDescuento = new TextBox();
            txtTotalNeto = new TextBox();
            btnCalcular = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtCompra
            // 
            txtCompra.Location = new Point(111, 47);
            txtCompra.Name = "txtCompra";
            txtCompra.Size = new Size(100, 23);
            txtCompra.TabIndex = 0;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(111, 104);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(100, 23);
            txtDescuento.TabIndex = 1;
            // 
            // txtTotalNeto
            // 
            txtTotalNeto.Location = new Point(111, 162);
            txtTotalNeto.Name = "txtTotalNeto";
            txtTotalNeto.Size = new Size(100, 23);
            txtTotalNeto.TabIndex = 2;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(122, 218);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 29);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 4;
            label1.Text = "Total compra";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 86);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 5;
            label2.Text = "Descuento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 144);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 6;
            label3.Text = "Total neto";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 291);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCalcular);
            Controls.Add(txtTotalNeto);
            Controls.Add(txtDescuento);
            Controls.Add(txtCompra);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCompra;
        private TextBox txtDescuento;
        private TextBox txtTotalNeto;
        private Button btnCalcular;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
