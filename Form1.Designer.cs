
namespace MiPrimerClase
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPersonas = new System.Windows.Forms.Label();
            this.btMostrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btInscribir = new System.Windows.Forms.Button();
            this.lblMostrarIns = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(141, 25);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido:";
            // 
            // lblPersonas
            // 
            this.lblPersonas.AutoSize = true;
            this.lblPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonas.Location = new System.Drawing.Point(12, 61);
            this.lblPersonas.Name = "lblPersonas";
            this.lblPersonas.Size = new System.Drawing.Size(0, 31);
            this.lblPersonas.TabIndex = 4;
            // 
            // btMostrar
            // 
            this.btMostrar.Location = new System.Drawing.Point(261, 22);
            this.btMostrar.Name = "btMostrar";
            this.btMostrar.Size = new System.Drawing.Size(75, 23);
            this.btMostrar.TabIndex = 5;
            this.btMostrar.Text = "Mostrar";
            this.btMostrar.UseVisualStyleBackColor = true;
            this.btMostrar.Click += new System.EventHandler(this.btMostrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Materia";
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(15, 138);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(100, 20);
            this.txtMateria.TabIndex = 7;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(144, 138);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(100, 20);
            this.txtAño.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Año";
            // 
            // btInscribir
            // 
            this.btInscribir.Location = new System.Drawing.Point(261, 138);
            this.btInscribir.Name = "btInscribir";
            this.btInscribir.Size = new System.Drawing.Size(75, 23);
            this.btInscribir.TabIndex = 10;
            this.btInscribir.Text = "Inscribir";
            this.btInscribir.UseVisualStyleBackColor = true;
            this.btInscribir.Click += new System.EventHandler(this.btInscribir_Click);
            // 
            // lblMostrarIns
            // 
            this.lblMostrarIns.AutoSize = true;
            this.lblMostrarIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarIns.Location = new System.Drawing.Point(12, 187);
            this.lblMostrarIns.Name = "lblMostrarIns";
            this.lblMostrarIns.Size = new System.Drawing.Size(0, 31);
            this.lblMostrarIns.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 294);
            this.Controls.Add(this.lblMostrarIns);
            this.Controls.Add(this.btInscribir);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMateria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btMostrar);
            this.Controls.Add(this.lblPersonas);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPersonas;
        private System.Windows.Forms.Button btMostrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btInscribir;
        private System.Windows.Forms.Label lblMostrarIns;
    }
}

