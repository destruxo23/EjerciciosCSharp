namespace Proyecto_diecisiete
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
            txtNombres = new TextBox();
            txtApellidos = new TextBox();
            txtCelular = new TextBox();
            txtNumID = new TextBox();
            btnCrearVenta = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtTotal = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtNumVenta = new TextBox();
            label8 = new Label();
            txtTotalVenta = new TextBox();
            label9 = new Label();
            txtCliente = new TextBox();
            label10 = new Label();
            txtFecha = new TextBox();
            label11 = new Label();
            btnConsultar = new Button();
            SuspendLayout();
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(25, 52);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(128, 23);
            txtNombres.TabIndex = 0;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(203, 52);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(130, 23);
            txtApellidos.TabIndex = 1;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(203, 114);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(130, 23);
            txtCelular.TabIndex = 2;
            // 
            // txtNumID
            // 
            txtNumID.Location = new Point(25, 114);
            txtNumID.Name = "txtNumID";
            txtNumID.Size = new Size(128, 23);
            txtNumID.TabIndex = 3;
            // 
            // btnCrearVenta
            // 
            btnCrearVenta.Location = new Point(129, 206);
            btnCrearVenta.Name = "btnCrearVenta";
            btnCrearVenta.Size = new Size(90, 34);
            btnCrearVenta.TabIndex = 4;
            btnCrearVenta.Text = "Crear venta";
            btnCrearVenta.UseVisualStyleBackColor = true;
            btnCrearVenta.Click += btnCrearVenta_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 34);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 5;
            label1.Text = "Nombres";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 34);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 6;
            label2.Text = "Apellidos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 96);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 7;
            label3.Text = "Num ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(203, 96);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 8;
            label4.Text = "Celular";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(110, 168);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(128, 23);
            txtTotal.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(144, 150);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 10;
            label5.Text = "Total venta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(144, 9);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 11;
            label6.Text = "Crear venta";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(129, 275);
            label7.Name = "label7";
            label7.Size = new Size(90, 15);
            label7.TabIndex = 12;
            label7.Text = "Consultar venta";
            // 
            // txtNumVenta
            // 
            txtNumVenta.Location = new Point(52, 322);
            txtNumVenta.Name = "txtNumVenta";
            txtNumVenta.Size = new Size(128, 23);
            txtNumVenta.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(67, 304);
            label8.Name = "label8";
            label8.Size = new Size(99, 15);
            label8.TabIndex = 14;
            label8.Text = "Numero de venta";
            // 
            // txtTotalVenta
            // 
            txtTotalVenta.Location = new Point(25, 442);
            txtTotalVenta.Name = "txtTotalVenta";
            txtTotalVenta.Size = new Size(128, 23);
            txtTotalVenta.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 424);
            label9.Name = "label9";
            label9.Size = new Size(92, 15);
            label9.TabIndex = 16;
            label9.Text = "Total de la venta";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(25, 388);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(128, 23);
            txtCliente.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(25, 370);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 18;
            label10.Text = "Cliente";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(25, 491);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(128, 23);
            txtFecha.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(25, 473);
            label11.Name = "label11";
            label11.Size = new Size(38, 15);
            label11.TabIndex = 20;
            label11.Text = "Fecha";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(219, 313);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(92, 39);
            btnConsultar.TabIndex = 21;
            btnConsultar.Text = "Consultar Venta";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 540);
            Controls.Add(btnConsultar);
            Controls.Add(label11);
            Controls.Add(txtFecha);
            Controls.Add(label10);
            Controls.Add(txtCliente);
            Controls.Add(label9);
            Controls.Add(txtTotalVenta);
            Controls.Add(label8);
            Controls.Add(txtNumVenta);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtTotal);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCrearVenta);
            Controls.Add(txtNumID);
            Controls.Add(txtCelular);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombres);
            Name = "Form1";
            Text = "Ingreso y consulta de ventas";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombres;
        private TextBox txtApellidos;
        private TextBox txtCelular;
        private TextBox txtNumID;
        private Button btnCrearVenta;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTotal;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtNumVenta;
        private Label label8;
        private TextBox txtTotalVenta;
        private Label label9;
        private TextBox txtCliente;
        private Label label10;
        private TextBox txtFecha;
        private Label label11;
        private Button btnConsultar;
    }
}
