namespace WinFormsApp1
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
            liDesordenado = new ListBox();
            liOrdenado = new ListBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // liDesordenado
            // 
            liDesordenado.FormattingEnabled = true;
            liDesordenado.ItemHeight = 15;
            liDesordenado.Location = new Point(12, 80);
            liDesordenado.Name = "liDesordenado";
            liDesordenado.Size = new Size(128, 169);
            liDesordenado.TabIndex = 0;
            // 
            // liOrdenado
            // 
            liOrdenado.FormattingEnabled = true;
            liOrdenado.ItemHeight = 15;
            liOrdenado.Location = new Point(244, 80);
            liOrdenado.Name = "liOrdenado";
            liOrdenado.Size = new Size(131, 169);
            liOrdenado.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 62);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 2;
            label1.Text = "Desordenado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(244, 62);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Ordenado";
            // 
            // button1
            // 
            button1.Location = new Point(146, 151);
            button1.Name = "button1";
            button1.Size = new Size(92, 23);
            button1.TabIndex = 4;
            button1.Text = "Ordenar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 298);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(liOrdenado);
            Controls.Add(liDesordenado);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox liDesordenado;
        private ListBox liOrdenado;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}
