namespace Proyecto_Cuatro
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
            cmbNumero = new ComboBox();
            txtMes = new TextBox();
            btnProcesar = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // cmbNumero
            // 
            cmbNumero.FormattingEnabled = true;
            cmbNumero.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cmbNumero.Location = new Point(83, 52);
            cmbNumero.Name = "cmbNumero";
            cmbNumero.Size = new Size(215, 23);
            cmbNumero.TabIndex = 0;
            // 
            // txtMes
            // 
            txtMes.Location = new Point(83, 119);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(215, 23);
            txtMes.TabIndex = 1;
            // 
            // btnProcesar
            // 
            btnProcesar.Location = new Point(144, 172);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(89, 23);
            btnProcesar.TabIndex = 2;
            btnProcesar.Text = "Procesar";
            btnProcesar.UseVisualStyleBackColor = true;
            btnProcesar.Click += btnProcesar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 34);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 3;
            label1.Text = "Seleccione un numero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(144, 101);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 4;
            label2.Text = "Mes seleccionado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 252);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnProcesar);
            Controls.Add(txtMes);
            Controls.Add(cmbNumero);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbNumero;
        private TextBox txtMes;
        private Button btnProcesar;
        private Label label1;
        private Label label2;
    }
}
