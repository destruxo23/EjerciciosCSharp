namespace Proyecto_Seis
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
            btnProcesar = new Button();
            liTextos = new ListBox();
            label1 = new Label();
            txtCaja = new TextBox();
            SuspendLayout();
            // 
            // btnProcesar
            // 
            btnProcesar.Location = new Point(147, 73);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(75, 23);
            btnProcesar.TabIndex = 0;
            btnProcesar.Text = "Procesar";
            btnProcesar.UseVisualStyleBackColor = true;
            btnProcesar.Click += btnProcesar_Click;
            // 
            // liTextos
            // 
            liTextos.FormattingEnabled = true;
            liTextos.ItemHeight = 15;
            liTextos.Location = new Point(43, 116);
            liTextos.Name = "liTextos";
            liTextos.Size = new Size(284, 214);
            liTextos.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 26);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 2;
            label1.Text = "Ingrese un número";
            // 
            // txtCaja
            // 
            txtCaja.Location = new Point(92, 44);
            txtCaja.Name = "txtCaja";
            txtCaja.Size = new Size(178, 23);
            txtCaja.TabIndex = 3;
            txtCaja.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 386);
            Controls.Add(txtCaja);
            Controls.Add(label1);
            Controls.Add(liTextos);
            Controls.Add(btnProcesar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProcesar;
        private ListBox liTextos;
        private Label label1;
        private TextBox txtCaja;
    }
}
