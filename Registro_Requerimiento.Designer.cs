
namespace Empresa_Sanitaria
{
    partial class Registro_Requerimiento
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
            this.lbl_registro = new System.Windows.Forms.Label();
            this.btn_listar = new System.Windows.Forms.Button();
            this.lbl_tipo_requerimiento = new System.Windows.Forms.Label();
            this.lbl_asignado = new System.Windows.Forms.Label();
            this.cmb_tipo_requerimiento = new System.Windows.Forms.ComboBox();
            this.cmb_asignar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.lbl_prioridad = new System.Windows.Forms.Label();
            this.cmb_prioridad = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_registro
            // 
            this.lbl_registro.AutoSize = true;
            this.lbl_registro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_registro.Location = new System.Drawing.Point(314, 13);
            this.lbl_registro.Name = "lbl_registro";
            this.lbl_registro.Size = new System.Drawing.Size(199, 20);
            this.lbl_registro.TabIndex = 0;
            this.lbl_registro.Text = "Registro Requerimiento";
            // 
            // btn_listar
            // 
            this.btn_listar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listar.Location = new System.Drawing.Point(532, 392);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(197, 22);
            this.btn_listar.TabIndex = 1;
            this.btn_listar.Text = "Ir a Listar Requerimientos";
            this.btn_listar.UseVisualStyleBackColor = true;
            this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
            // 
            // lbl_tipo_requerimiento
            // 
            this.lbl_tipo_requerimiento.AutoSize = true;
            this.lbl_tipo_requerimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo_requerimiento.Location = new System.Drawing.Point(113, 59);
            this.lbl_tipo_requerimiento.Name = "lbl_tipo_requerimiento";
            this.lbl_tipo_requerimiento.Size = new System.Drawing.Size(149, 16);
            this.lbl_tipo_requerimiento.TabIndex = 2;
            this.lbl_tipo_requerimiento.Text = "Tipo Requerimiento:";
            // 
            // lbl_asignado
            // 
            this.lbl_asignado.AutoSize = true;
            this.lbl_asignado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_asignado.Location = new System.Drawing.Point(113, 121);
            this.lbl_asignado.Name = "lbl_asignado";
            this.lbl_asignado.Size = new System.Drawing.Size(91, 16);
            this.lbl_asignado.TabIndex = 3;
            this.lbl_asignado.Text = "Asignado a:";
            // 
            // cmb_tipo_requerimiento
            // 
            this.cmb_tipo_requerimiento.FormattingEnabled = true;
            this.cmb_tipo_requerimiento.Location = new System.Drawing.Point(268, 54);
            this.cmb_tipo_requerimiento.Name = "cmb_tipo_requerimiento";
            this.cmb_tipo_requerimiento.Size = new System.Drawing.Size(286, 21);
            this.cmb_tipo_requerimiento.TabIndex = 4;
            this.cmb_tipo_requerimiento.Text = "Seleccionar";
            this.cmb_tipo_requerimiento.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmb_asignar
            // 
            this.cmb_asignar.FormattingEnabled = true;
            this.cmb_asignar.Location = new System.Drawing.Point(268, 116);
            this.cmb_asignar.Name = "cmb_asignar";
            this.cmb_asignar.Size = new System.Drawing.Size(286, 21);
            this.cmb_asignar.TabIndex = 5;
            this.cmb_asignar.Text = "Seleccionar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "(Base de Datos, Sistema, Servidores)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "(Este usuario será responsable de resolver el requerimiento)";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.Location = new System.Drawing.Point(113, 174);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(226, 16);
            this.lbl_descripcion.TabIndex = 8;
            this.lbl_descripcion.Text = "Descripción del Requerimiento:";
            // 
            // lbl_prioridad
            // 
            this.lbl_prioridad.AutoSize = true;
            this.lbl_prioridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prioridad.Location = new System.Drawing.Point(113, 318);
            this.lbl_prioridad.Name = "lbl_prioridad";
            this.lbl_prioridad.Size = new System.Drawing.Size(76, 16);
            this.lbl_prioridad.TabIndex = 10;
            this.lbl_prioridad.Text = "Prioridad:";
            // 
            // cmb_prioridad
            // 
            this.cmb_prioridad.FormattingEnabled = true;
            this.cmb_prioridad.Location = new System.Drawing.Point(268, 313);
            this.cmb_prioridad.Name = "cmb_prioridad";
            this.cmb_prioridad.Size = new System.Drawing.Size(229, 21);
            this.cmb_prioridad.TabIndex = 11;
            this.cmb_prioridad.Text = "Seleccionar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "(Alta, Media, Baja)";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(95, 392);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(151, 22);
            this.btn_guardar.TabIndex = 13;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(309, 392);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(165, 22);
            this.btn_limpiar.TabIndex = 14;
            this.btn_limpiar.Text = "Limpiar Campos";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(116, 194);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(545, 97);
            this.txt_descripcion.TabIndex = 15;
            // 
            // Registro_Requerimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_prioridad);
            this.Controls.Add(this.lbl_prioridad);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_asignar);
            this.Controls.Add(this.cmb_tipo_requerimiento);
            this.Controls.Add(this.lbl_asignado);
            this.Controls.Add(this.lbl_tipo_requerimiento);
            this.Controls.Add(this.btn_listar);
            this.Controls.Add(this.lbl_registro);
            this.Name = "Registro_Requerimiento";
            this.Text = "Registro_Requerimiento";
            this.Load += new System.EventHandler(this.Registro_Requerimiento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_registro;
        private System.Windows.Forms.Button btn_listar;
        private System.Windows.Forms.Label lbl_tipo_requerimiento;
        private System.Windows.Forms.Label lbl_asignado;
        private System.Windows.Forms.ComboBox cmb_tipo_requerimiento;
        private System.Windows.Forms.ComboBox cmb_asignar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label lbl_prioridad;
        private System.Windows.Forms.ComboBox cmb_prioridad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.TextBox txt_descripcion;
    }
}