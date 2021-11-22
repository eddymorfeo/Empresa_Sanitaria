
namespace Empresa_Sanitaria
{
    partial class Listar_Requerimiento
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
            this.lbl_lista = new System.Windows.Forms.Label();
            this.lbl_tipo_requerimiento = new System.Windows.Forms.Label();
            this.cmb_requerimiento_tipo = new System.Windows.Forms.ComboBox();
            this.lbl_prioridad = new System.Windows.Forms.Label();
            this.cmb_prioridad = new System.Windows.Forms.ComboBox();
            this.chk_pendiente = new System.Windows.Forms.CheckBox();
            this.chk_resuelto = new System.Windows.Forms.CheckBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.dgv_lista_requerimiento = new System.Windows.Forms.DataGridView();
            this.tipo_requerimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dias_plazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_resuelto = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista_requerimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_lista
            // 
            this.lbl_lista.AutoSize = true;
            this.lbl_lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lista.Location = new System.Drawing.Point(288, 9);
            this.lbl_lista.Name = "lbl_lista";
            this.lbl_lista.Size = new System.Drawing.Size(204, 20);
            this.lbl_lista.TabIndex = 0;
            this.lbl_lista.Text = "Lista de Requerimientos";
            // 
            // lbl_tipo_requerimiento
            // 
            this.lbl_tipo_requerimiento.AutoSize = true;
            this.lbl_tipo_requerimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo_requerimiento.Location = new System.Drawing.Point(124, 42);
            this.lbl_tipo_requerimiento.Name = "lbl_tipo_requerimiento";
            this.lbl_tipo_requerimiento.Size = new System.Drawing.Size(149, 16);
            this.lbl_tipo_requerimiento.TabIndex = 2;
            this.lbl_tipo_requerimiento.Text = "Tipo Requerimiento:";
            // 
            // cmb_requerimiento_tipo
            // 
            this.cmb_requerimiento_tipo.FormattingEnabled = true;
            this.cmb_requerimiento_tipo.Location = new System.Drawing.Point(279, 37);
            this.cmb_requerimiento_tipo.Name = "cmb_requerimiento_tipo";
            this.cmb_requerimiento_tipo.Size = new System.Drawing.Size(213, 21);
            this.cmb_requerimiento_tipo.TabIndex = 3;
            this.cmb_requerimiento_tipo.Text = "Todos";
            // 
            // lbl_prioridad
            // 
            this.lbl_prioridad.AutoSize = true;
            this.lbl_prioridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prioridad.Location = new System.Drawing.Point(124, 89);
            this.lbl_prioridad.Name = "lbl_prioridad";
            this.lbl_prioridad.Size = new System.Drawing.Size(76, 16);
            this.lbl_prioridad.TabIndex = 4;
            this.lbl_prioridad.Text = "Prioridad:";
            // 
            // cmb_prioridad
            // 
            this.cmb_prioridad.FormattingEnabled = true;
            this.cmb_prioridad.Location = new System.Drawing.Point(279, 84);
            this.cmb_prioridad.Name = "cmb_prioridad";
            this.cmb_prioridad.Size = new System.Drawing.Size(213, 21);
            this.cmb_prioridad.TabIndex = 5;
            this.cmb_prioridad.Text = "Todos";
            // 
            // chk_pendiente
            // 
            this.chk_pendiente.AutoSize = true;
            this.chk_pendiente.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_pendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_pendiente.Location = new System.Drawing.Point(158, 146);
            this.chk_pendiente.Name = "chk_pendiente";
            this.chk_pendiente.Size = new System.Drawing.Size(105, 20);
            this.chk_pendiente.TabIndex = 6;
            this.chk_pendiente.Text = "Pendientes";
            this.chk_pendiente.UseVisualStyleBackColor = true;
            // 
            // chk_resuelto
            // 
            this.chk_resuelto.AutoSize = true;
            this.chk_resuelto.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_resuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_resuelto.Location = new System.Drawing.Point(316, 146);
            this.chk_resuelto.Name = "chk_resuelto";
            this.chk_resuelto.Size = new System.Drawing.Size(97, 20);
            this.chk_resuelto.TabIndex = 7;
            this.chk_resuelto.Text = "Resueltos";
            this.chk_resuelto.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(527, 135);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(145, 31);
            this.btn_buscar.TabIndex = 8;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // dgv_lista_requerimiento
            // 
            this.dgv_lista_requerimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lista_requerimiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipo_requerimiento,
            this.prioridad,
            this.descripcion,
            this.dias_plazo});
            this.dgv_lista_requerimiento.Location = new System.Drawing.Point(127, 203);
            this.dgv_lista_requerimiento.Name = "dgv_lista_requerimiento";
            this.dgv_lista_requerimiento.Size = new System.Drawing.Size(571, 150);
            this.dgv_lista_requerimiento.TabIndex = 9;
            // 
            // tipo_requerimiento
            // 
            this.tipo_requerimiento.HeaderText = "Tipo Requerimiento";
            this.tipo_requerimiento.Name = "tipo_requerimiento";
            // 
            // prioridad
            // 
            this.prioridad.HeaderText = "Prioridad";
            this.prioridad.Name = "prioridad";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            // 
            // dias_plazo
            // 
            this.dias_plazo.HeaderText = "Días Plazo";
            this.dias_plazo.Name = "dias_plazo";
            // 
            // btn_resuelto
            // 
            this.btn_resuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resuelto.Location = new System.Drawing.Point(127, 381);
            this.btn_resuelto.Name = "btn_resuelto";
            this.btn_resuelto.Size = new System.Drawing.Size(185, 34);
            this.btn_resuelto.TabIndex = 10;
            this.btn_resuelto.Text = "Marcar como Resuelto";
            this.btn_resuelto.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Location = new System.Drawing.Point(348, 381);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(158, 34);
            this.btn_eliminar.TabIndex = 11;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_atras
            // 
            this.btn_atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atras.Location = new System.Drawing.Point(540, 381);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(158, 34);
            this.btn_atras.TabIndex = 12;
            this.btn_atras.Text = "Atrás";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.button4_Click);
            // 
            // Listar_Requerimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_resuelto);
            this.Controls.Add(this.dgv_lista_requerimiento);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.chk_resuelto);
            this.Controls.Add(this.chk_pendiente);
            this.Controls.Add(this.cmb_prioridad);
            this.Controls.Add(this.lbl_prioridad);
            this.Controls.Add(this.cmb_requerimiento_tipo);
            this.Controls.Add(this.lbl_tipo_requerimiento);
            this.Controls.Add(this.lbl_lista);
            this.Name = "Listar_Requerimiento";
            this.Text = "Listar_Requerimiento";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista_requerimiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_lista;
        private System.Windows.Forms.Label lbl_tipo_requerimiento;
        private System.Windows.Forms.ComboBox cmb_requerimiento_tipo;
        private System.Windows.Forms.Label lbl_prioridad;
        private System.Windows.Forms.ComboBox cmb_prioridad;
        private System.Windows.Forms.CheckBox chk_pendiente;
        private System.Windows.Forms.CheckBox chk_resuelto;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridView dgv_lista_requerimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_requerimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn prioridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dias_plazo;
        private System.Windows.Forms.Button btn_resuelto;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_atras;
    }
}