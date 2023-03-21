namespace Ejercicio2
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.gbCrear = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.gbPersona = new System.Windows.Forms.GroupBox();
            this.gbMorir = new System.Windows.Forms.GroupBox();
            this.btnMorir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreser = new System.Windows.Forms.Button();
            this.btnPeso = new System.Windows.Forms.Button();
            this.txtyears = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblYears = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.gbCrear.SuspendLayout();
            this.gbPersona.SuspendLayout();
            this.gbMorir.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ejercicio 2 Clase Persona";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(86, 29);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(65, 20);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // gbCrear
            // 
            this.gbCrear.Controls.Add(this.label3);
            this.gbCrear.Controls.Add(this.label2);
            this.gbCrear.Controls.Add(this.btnCargar);
            this.gbCrear.Controls.Add(this.txtNombre);
            this.gbCrear.Controls.Add(this.txtApellido);
            this.gbCrear.Location = new System.Drawing.Point(33, 48);
            this.gbCrear.Name = "gbCrear";
            this.gbCrear.Size = new System.Drawing.Size(206, 111);
            this.gbCrear.TabIndex = 3;
            this.gbCrear.TabStop = false;
            this.gbCrear.Text = "Crear una Persona";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(91, 16);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(91, 52);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(133, 78);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(58, 23);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.Text = "Nacer";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // gbPersona
            // 
            this.gbPersona.Controls.Add(this.lblPeso);
            this.gbPersona.Controls.Add(this.lblYears);
            this.gbPersona.Controls.Add(this.label5);
            this.gbPersona.Controls.Add(this.label4);
            this.gbPersona.Controls.Add(this.txtPeso);
            this.gbPersona.Controls.Add(this.txtyears);
            this.gbPersona.Controls.Add(this.btnPeso);
            this.gbPersona.Controls.Add(this.btnCreser);
            this.gbPersona.Controls.Add(this.lblNombre);
            this.gbPersona.Controls.Add(this.lblApellido);
            this.gbPersona.Location = new System.Drawing.Point(34, 165);
            this.gbPersona.Name = "gbPersona";
            this.gbPersona.Size = new System.Drawing.Size(205, 202);
            this.gbPersona.TabIndex = 4;
            this.gbPersona.TabStop = false;
            this.gbPersona.Text = "Persona";
            // 
            // gbMorir
            // 
            this.gbMorir.Controls.Add(this.btnMorir);
            this.gbMorir.Location = new System.Drawing.Point(34, 373);
            this.gbMorir.Name = "gbMorir";
            this.gbMorir.Size = new System.Drawing.Size(206, 53);
            this.gbMorir.TabIndex = 5;
            this.gbMorir.TabStop = false;
            this.gbMorir.Text = "Terminar Persona";
            // 
            // btnMorir
            // 
            this.btnMorir.Location = new System.Drawing.Point(68, 19);
            this.btnMorir.Name = "btnMorir";
            this.btnMorir.Size = new System.Drawing.Size(75, 23);
            this.btnMorir.TabIndex = 0;
            this.btnMorir.Text = "Morir";
            this.btnMorir.UseVisualStyleBackColor = true;
            this.btnMorir.Click += new System.EventHandler(this.btnMorir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apellido: ";
            // 
            // btnCreser
            // 
            this.btnCreser.Location = new System.Drawing.Point(112, 126);
            this.btnCreser.Name = "btnCreser";
            this.btnCreser.Size = new System.Drawing.Size(75, 23);
            this.btnCreser.TabIndex = 3;
            this.btnCreser.Text = "Creser";
            this.btnCreser.UseVisualStyleBackColor = true;
            this.btnCreser.Click += new System.EventHandler(this.btnCreser_Click);
            // 
            // btnPeso
            // 
            this.btnPeso.Location = new System.Drawing.Point(112, 166);
            this.btnPeso.Name = "btnPeso";
            this.btnPeso.Size = new System.Drawing.Size(75, 23);
            this.btnPeso.TabIndex = 4;
            this.btnPeso.Text = "Subir Peso";
            this.btnPeso.UseVisualStyleBackColor = true;
            this.btnPeso.Click += new System.EventHandler(this.btnPeso_Click);
            // 
            // txtyears
            // 
            this.txtyears.Location = new System.Drawing.Point(6, 128);
            this.txtyears.Name = "txtyears";
            this.txtyears.Size = new System.Drawing.Size(100, 20);
            this.txtyears.TabIndex = 5;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(6, 169);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Anos: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Peso:";
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYears.Location = new System.Drawing.Point(64, 60);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(18, 20);
            this.lblYears.TabIndex = 9;
            this.lblYears.Text = "0";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(64, 94);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(18, 20);
            this.lblPeso.TabIndex = 10;
            this.lblPeso.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 435);
            this.Controls.Add(this.gbMorir);
            this.Controls.Add(this.gbPersona);
            this.Controls.Add(this.gbCrear);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbCrear.ResumeLayout(false);
            this.gbCrear.PerformLayout();
            this.gbPersona.ResumeLayout(false);
            this.gbPersona.PerformLayout();
            this.gbMorir.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.GroupBox gbCrear;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbPersona;
        private System.Windows.Forms.GroupBox gbMorir;
        private System.Windows.Forms.Button btnMorir;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtyears;
        private System.Windows.Forms.Button btnPeso;
        private System.Windows.Forms.Button btnCreser;
    }
}

