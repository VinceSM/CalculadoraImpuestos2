namespace CalculadoraImpuestos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ElegirProducto = new System.Windows.Forms.DomainUpDown();
            this.lblCantidadItem = new System.Windows.Forms.Label();
            this.txtCantidadItem = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ElegirProducto
            // 
            this.ElegirProducto.Location = new System.Drawing.Point(132, 45);
            this.ElegirProducto.Name = "ElegirProducto";
            this.ElegirProducto.ReadOnly = true;
            this.ElegirProducto.Size = new System.Drawing.Size(130, 20);
            this.ElegirProducto.TabIndex = 0;
            this.ElegirProducto.SelectedItemChanged += new System.EventHandler(this.ElegirProducto_SelectedItemChanged);
            // 
            // lblCantidadItem
            // 
            this.lblCantidadItem.AutoSize = true;
            this.lblCantidadItem.Location = new System.Drawing.Point(12, 89);
            this.lblCantidadItem.Name = "lblCantidadItem";
            this.lblCantidadItem.Size = new System.Drawing.Size(118, 13);
            this.lblCantidadItem.TabIndex = 1;
            this.lblCantidadItem.Text = "Cantidad del Producto: ";
            // 
            // txtCantidadItem
            // 
            this.txtCantidadItem.Location = new System.Drawing.Point(132, 82);
            this.txtCantidadItem.Name = "txtCantidadItem";
            this.txtCantidadItem.Size = new System.Drawing.Size(130, 20);
            this.txtCantidadItem.TabIndex = 2;
            this.txtCantidadItem.TextChanged += new System.EventHandler(this.txtCantidadItem_TextChanged);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(12, 52);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(115, 13);
            this.lblProducto.TabIndex = 3;
            this.lblProducto.Text = "Seleccionar Producto: ";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(12, 130);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(89, 13);
            this.lblPais.TabIndex = 4;
            this.lblPais.Text = "Seleccione Pais: ";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(460, 182);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(70, 13);
            this.lblSubtotal.TabIndex = 6;
            this.lblSubtotal.Text = "SUBTOTAL: ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(460, 230);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 13);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "TOTAL:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(568, 175);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(126, 20);
            this.txtSubtotal.TabIndex = 8;
            this.txtSubtotal.TextChanged += new System.EventHandler(this.txtSubtotal_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(568, 223);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(126, 20);
            this.txtTotal.TabIndex = 9;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // cbCountry
            // 
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(132, 122);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(130, 21);
            this.cbCountry.TabIndex = 11;
            this.cbCountry.SelectedIndexChanged += new System.EventHandler(this.cbCountry_SelectedIndexChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(12, 171);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(102, 13);
            this.lblEstado.TabIndex = 12;
            this.lblEstado.Text = "Seleccione Estado: ";
            // 
            // cbState
            // 
            this.cbState.FormattingEnabled = true;
            this.cbState.Location = new System.Drawing.Point(132, 163);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(130, 21);
            this.cbState.TabIndex = 13;
            this.cbState.SelectedIndexChanged += new System.EventHandler(this.cbState_SelectedIndexChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(15, 220);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cbState);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.txtCantidadItem);
            this.Controls.Add(this.lblCantidadItem);
            this.Controls.Add(this.ElegirProducto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DomainUpDown ElegirProducto;
        private System.Windows.Forms.Label lblCantidadItem;
        private System.Windows.Forms.TextBox txtCantidadItem;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

