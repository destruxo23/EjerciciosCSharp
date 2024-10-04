namespace Proyecto_Cinco
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
            txtNumero = new TextBox();
            label1 = new Label();
            liTabla = new ListBox();
            btnProcesar = new Button();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(83, 44);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(187, 23);
            txtNumero.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 26);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 1;
            label1.Text = "Ingrese un número";
            // 
            // liTabla
            // 
            liTabla.FormattingEnabled = true;
            liTabla.ItemHeight = 15;
            liTabla.Location = new Point(34, 113);
            liTabla.Name = "liTabla";
            liTabla.Size = new Size(288, 184);
            liTabla.TabIndex = 2;
            // 
            // btnProcesar
            // 
            btnProcesar.Location = new Point(138, 73);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(75, 23);
            btnProcesar.TabIndex = 3;
            btnProcesar.Text = "Procesar";
            btnProcesar.UseVisualStyleBackColor = true;
            btnProcesar.Click += btnProcesar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 318);
            Controls.Add(btnProcesar);
            Controls.Add(liTabla);
            Controls.Add(label1);
            Controls.Add(txtNumero);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero;
        private Label label1;
        private ListBox liTabla;
        private Button btnProcesar;
    }
}
