﻿namespace Proyecto_Dos
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
            btnProcesar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(44, 86);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(187, 23);
            txtNumero.TabIndex = 0;
            txtNumero.TextChanged += textBox1_TextChanged;
            // 
            // btnProcesar
            // 
            btnProcesar.Location = new Point(96, 127);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(75, 23);
            btnProcesar.TabIndex = 1;
            btnProcesar.Text = "Procesar";
            btnProcesar.UseVisualStyleBackColor = true;
            btnProcesar.Click += btnProcesar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 59);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 2;
            label1.Text = "¿Numero par o impar?";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 230);
            Controls.Add(label1);
            Controls.Add(btnProcesar);
            Controls.Add(txtNumero);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero;
        private Button btnProcesar;
        private Label label1;
    }
}
