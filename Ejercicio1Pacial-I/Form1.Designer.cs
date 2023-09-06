namespace Ejercicio1Pacial_I
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbl1 = new Label();
            lblCantidad = new Label();
            lblValorAPagarImpuesto = new Label();
            txtCantidadImpuesto = new TextBox();
            btnCalcularImpuesto = new Button();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1.Location = new Point(134, 24);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(392, 21);
            lbl1.TabIndex = 0;
            lbl1.Text = "Calculo de Impuesto a las Actividades Económicas";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidad.Location = new Point(84, 94);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(81, 21);
            lblCantidad.TabIndex = 1;
            lblCantidad.Text = "Cantidad:";
            // 
            // lblValorAPagarImpuesto
            // 
            lblValorAPagarImpuesto.AutoSize = true;
            lblValorAPagarImpuesto.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorAPagarImpuesto.Location = new Point(84, 147);
            lblValorAPagarImpuesto.Name = "lblValorAPagarImpuesto";
            lblValorAPagarImpuesto.Size = new Size(151, 21);
            lblValorAPagarImpuesto.TabIndex = 2;
            lblValorAPagarImpuesto.Text = "El valor a pagar es:";
            // 
            // txtCantidadImpuesto
            // 
            txtCantidadImpuesto.Location = new Point(171, 95);
            txtCantidadImpuesto.Name = "txtCantidadImpuesto";
            txtCantidadImpuesto.Size = new Size(158, 23);
            txtCantidadImpuesto.TabIndex = 3;
            // 
            // btnCalcularImpuesto
            // 
            btnCalcularImpuesto.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcularImpuesto.Location = new Point(171, 191);
            btnCalcularImpuesto.Name = "btnCalcularImpuesto";
            btnCalcularImpuesto.Size = new Size(158, 67);
            btnCalcularImpuesto.TabIndex = 4;
            btnCalcularImpuesto.Text = "Calcular";
            btnCalcularImpuesto.UseVisualStyleBackColor = true;
            btnCalcularImpuesto.Click += btnCalcularImpuesto_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 286);
            Controls.Add(btnCalcularImpuesto);
            Controls.Add(txtCantidadImpuesto);
            Controls.Add(lblValorAPagarImpuesto);
            Controls.Add(lblCantidad);
            Controls.Add(lbl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label lblCantidad;
        private Label lblValorAPagarImpuesto;
        private TextBox txtCantidadImpuesto;
        private Button btnCalcularImpuesto;
    }
}