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
            this.lblContinente = new System.Windows.Forms.Label();
            this.ElegirContinente = new System.Windows.Forms.DomainUpDown();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ElegirProducto
            // 
            this.ElegirProducto.Location = new System.Drawing.Point(132, 45);
            this.ElegirProducto.Name = "ElegirProducto";
            this.ElegirProducto.ReadOnly = true;
            this.ElegirProducto.Size = new System.Drawing.Size(163, 20);
            this.ElegirProducto.TabIndex = 0;
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
            this.txtCantidadItem.Size = new System.Drawing.Size(80, 20);
            this.txtCantidadItem.TabIndex = 2;
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
            // lblContinente
            // 
            this.lblContinente.AutoSize = true;
            this.lblContinente.Location = new System.Drawing.Point(15, 130);
            this.lblContinente.Name = "lblContinente";
            this.lblContinente.Size = new System.Drawing.Size(152, 13);
            this.lblContinente.TabIndex = 4;
            this.lblContinente.Text = "Seleccione Continente o Pais: ";
            // 
            // ElegirContinente
            // 
            this.ElegirContinente.Location = new System.Drawing.Point(173, 123);
            this.ElegirContinente.Name = "ElegirContinente";
            this.ElegirContinente.ReadOnly = true;
            this.ElegirContinente.Size = new System.Drawing.Size(163, 20);
            this.ElegirContinente.TabIndex = 5;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(460, 52);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(70, 13);
            this.lblSubtotal.TabIndex = 6;
            this.lblSubtotal.Text = "SUBTOTAL: ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(463, 99);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 13);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "TOTAL:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(553, 45);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(126, 20);
            this.txtSubtotal.TabIndex = 8;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(553, 99);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(126, 20);
            this.txtTotal.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.ElegirContinente);
            this.Controls.Add(this.lblContinente);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.txtCantidadItem);
            this.Controls.Add(this.lblCantidadItem);
            this.Controls.Add(this.ElegirProducto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DomainUpDown ElegirProducto;
        private System.Windows.Forms.Label lblCantidadItem;
        private System.Windows.Forms.TextBox txtCantidadItem;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblContinente;
        private System.Windows.Forms.DomainUpDown ElegirContinente;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtTotal;
    }
}

