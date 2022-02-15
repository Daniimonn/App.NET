namespace PeliculasTarea1
{
    partial class Inicio
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
            this.btnAcceder = new System.Windows.Forms.Button();
            this.btnCerrarInicio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAcceder
            // 
            this.btnAcceder.Location = new System.Drawing.Point(1072, 453);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(117, 53);
            this.btnAcceder.TabIndex = 0;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = true;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // btnCerrarInicio
            // 
            this.btnCerrarInicio.Location = new System.Drawing.Point(765, 453);
            this.btnCerrarInicio.Name = "btnCerrarInicio";
            this.btnCerrarInicio.Size = new System.Drawing.Size(113, 53);
            this.btnCerrarInicio.TabIndex = 1;
            this.btnCerrarInicio.Text = "Cerrar";
            this.btnCerrarInicio.UseVisualStyleBackColor = true;
            this.btnCerrarInicio.Click += new System.EventHandler(this.btnCerrarInicio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(858, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido al Gestor del Videoclub";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(718, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(564, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pincha en Acceder para ingresar al gestor, si desa abandonar pincha en Cerrar";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrarInicio);
            this.Controls.Add(this.btnAcceder);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.Button btnCerrarInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

