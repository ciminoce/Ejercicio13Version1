namespace Ejercicio13
{
    partial class frmOpercionesBasicas
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtNumero1 = new TextBox();
            label2 = new Label();
            txtNumero2 = new TextBox();
            gbOperaciones = new GroupBox();
            rbtDivision = new RadioButton();
            rbtProducto = new RadioButton();
            rbtResta = new RadioButton();
            rbtSuma = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            btnOK = new Button();
            btnCancelar = new Button();
            btnSalir = new Button();
            errorProvider1 = new ErrorProvider(components);
            gbOperaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 42);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese un número:";
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(171, 39);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(92, 23);
            txtNumero1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 81);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 0;
            label2.Text = "Ingrese otro número:";
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(171, 78);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(92, 23);
            txtNumero2.TabIndex = 1;
            // 
            // gbOperaciones
            // 
            gbOperaciones.Controls.Add(rbtDivision);
            gbOperaciones.Controls.Add(rbtProducto);
            gbOperaciones.Controls.Add(rbtResta);
            gbOperaciones.Controls.Add(rbtSuma);
            gbOperaciones.Location = new Point(49, 123);
            gbOperaciones.Name = "gbOperaciones";
            gbOperaciones.Size = new Size(214, 141);
            gbOperaciones.TabIndex = 2;
            gbOperaciones.TabStop = false;
            gbOperaciones.Text = " Operaciones Básicas ";
            // 
            // rbtDivision
            // 
            rbtDivision.AutoSize = true;
            rbtDivision.Location = new Point(19, 102);
            rbtDivision.Name = "rbtDivision";
            rbtDivision.Size = new Size(67, 19);
            rbtDivision.TabIndex = 3;
            rbtDivision.Text = "División";
            rbtDivision.UseVisualStyleBackColor = true;
            // 
            // rbtProducto
            // 
            rbtProducto.AutoSize = true;
            rbtProducto.Location = new Point(19, 77);
            rbtProducto.Name = "rbtProducto";
            rbtProducto.Size = new Size(74, 19);
            rbtProducto.TabIndex = 2;
            rbtProducto.Text = "Producto";
            rbtProducto.UseVisualStyleBackColor = true;
            // 
            // rbtResta
            // 
            rbtResta.AutoSize = true;
            rbtResta.Location = new Point(19, 52);
            rbtResta.Name = "rbtResta";
            rbtResta.Size = new Size(53, 19);
            rbtResta.TabIndex = 1;
            rbtResta.Text = "Resta";
            rbtResta.UseVisualStyleBackColor = true;
            // 
            // rbtSuma
            // 
            rbtSuma.AutoSize = true;
            rbtSuma.Checked = true;
            rbtSuma.Location = new Point(19, 27);
            rbtSuma.Name = "rbtSuma";
            rbtSuma.Size = new Size(55, 19);
            rbtSuma.TabIndex = 0;
            rbtSuma.TabStop = true;
            rbtSuma.Text = "Suma";
            rbtSuma.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(54, 292);
            button1.Name = "button1";
            button1.Size = new Size(75, 58);
            button1.TabIndex = 3;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(188, 292);
            button2.Name = "button2";
            button2.Size = new Size(75, 58);
            button2.TabIndex = 3;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.Image = Properties.Resources.ok_24px;
            btnOK.Location = new Point(54, 292);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 58);
            btnOK.TabIndex = 3;
            btnOK.Text = "OK";
            btnOK.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.cancel_24px;
            btnCancelar.Location = new Point(188, 292);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 58);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Image = Properties.Resources.exit_24px;
            btnSalir.Location = new Point(54, 356);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(209, 58);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmOpercionesBasicas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 450);
            ControlBox = false;
            Controls.Add(btnCancelar);
            Controls.Add(btnSalir);
            Controls.Add(btnOK);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(gbOperaciones);
            Controls.Add(txtNumero2);
            Controls.Add(label2);
            Controls.Add(txtNumero1);
            Controls.Add(label1);
            MaximumSize = new Size(331, 489);
            MinimumSize = new Size(331, 489);
            Name = "frmOpercionesBasicas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Operciones Básicas";
            gbOperaciones.ResumeLayout(false);
            gbOperaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero1;
        private Label label2;
        private TextBox txtNumero2;
        private GroupBox gbOperaciones;
        private RadioButton rbtDivision;
        private RadioButton rbtProducto;
        private RadioButton rbtResta;
        private RadioButton rbtSuma;
        private Button button1;
        private Button button2;
        private Button btnOK;
        private Button btnCancelar;
        private Button btnSalir;
        private ErrorProvider errorProvider1;
    }
}