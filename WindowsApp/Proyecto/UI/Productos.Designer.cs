namespace UI
{
    partial class Productos
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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnTraerTodo = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnObtenerPorId = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtCodBar = new System.Windows.Forms.TextBox();
            this.btnObtenerPorCodBar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtFechaDesde = new System.Windows.Forms.TextBox();
            this.txtFechaHasta = new System.Windows.Forms.TextBox();
            this.btnObtenerEntreFechas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(51, 74);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 62;
            this.dgvProductos.RowTemplate.Height = 28;
            this.dgvProductos.Size = new System.Drawing.Size(1190, 429);
            this.dgvProductos.TabIndex = 0;
            // 
            // btnTraerTodo
            // 
            this.btnTraerTodo.Location = new System.Drawing.Point(51, 15);
            this.btnTraerTodo.Name = "btnTraerTodo";
            this.btnTraerTodo.Size = new System.Drawing.Size(125, 30);
            this.btnTraerTodo.TabIndex = 1;
            this.btnTraerTodo.Text = "Traer Todo";
            this.btnTraerTodo.UseVisualStyleBackColor = true;
            this.btnTraerTodo.Click += new System.EventHandler(this.btnTraerTodo_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(49, 529);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(125, 49);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnObtenerPorId
            // 
            this.btnObtenerPorId.Location = new System.Drawing.Point(940, 537);
            this.btnObtenerPorId.Name = "btnObtenerPorId";
            this.btnObtenerPorId.Size = new System.Drawing.Size(176, 33);
            this.btnObtenerPorId.TabIndex = 3;
            this.btnObtenerPorId.Text = "Obtener Por ID";
            this.btnObtenerPorId.UseVisualStyleBackColor = true;
            this.btnObtenerPorId.Click += new System.EventHandler(this.btnObtenerPorId_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(1142, 540);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 26);
            this.txtId.TabIndex = 4;
            // 
            // txtCodBar
            // 
            this.txtCodBar.Location = new System.Drawing.Point(412, 19);
            this.txtCodBar.Name = "txtCodBar";
            this.txtCodBar.Size = new System.Drawing.Size(100, 26);
            this.txtCodBar.TabIndex = 6;
            // 
            // btnObtenerPorCodBar
            // 
            this.btnObtenerPorCodBar.Location = new System.Drawing.Point(202, 14);
            this.btnObtenerPorCodBar.Name = "btnObtenerPorCodBar";
            this.btnObtenerPorCodBar.Size = new System.Drawing.Size(176, 33);
            this.btnObtenerPorCodBar.TabIndex = 5;
            this.btnObtenerPorCodBar.Text = "Obtener Por CodBar";
            this.btnObtenerPorCodBar.UseVisualStyleBackColor = true;
            this.btnObtenerPorCodBar.Click += new System.EventHandler(this.btnObtenerPorCodBar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(220, 529);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(125, 49);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(398, 529);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(125, 49);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtFechaDesde
            // 
            this.txtFechaDesde.Location = new System.Drawing.Point(891, 22);
            this.txtFechaDesde.Name = "txtFechaDesde";
            this.txtFechaDesde.Size = new System.Drawing.Size(100, 26);
            this.txtFechaDesde.TabIndex = 9;
            // 
            // txtFechaHasta
            // 
            this.txtFechaHasta.Location = new System.Drawing.Point(1016, 22);
            this.txtFechaHasta.Name = "txtFechaHasta";
            this.txtFechaHasta.Size = new System.Drawing.Size(100, 26);
            this.txtFechaHasta.TabIndex = 10;
            // 
            // btnObtenerEntreFechas
            // 
            this.btnObtenerEntreFechas.Location = new System.Drawing.Point(651, 19);
            this.btnObtenerEntreFechas.Name = "btnObtenerEntreFechas";
            this.btnObtenerEntreFechas.Size = new System.Drawing.Size(201, 33);
            this.btnObtenerEntreFechas.TabIndex = 11;
            this.btnObtenerEntreFechas.Text = "Obtener Entre Fechas";
            this.btnObtenerEntreFechas.UseVisualStyleBackColor = true;
            this.btnObtenerEntreFechas.Click += new System.EventHandler(this.btnObtenerEntreFechas_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1289, 610);
            this.Controls.Add(this.btnObtenerEntreFechas);
            this.Controls.Add(this.txtFechaHasta);
            this.Controls.Add(this.txtFechaDesde);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtCodBar);
            this.Controls.Add(this.btnObtenerPorCodBar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnObtenerPorId);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnTraerTodo);
            this.Controls.Add(this.dgvProductos);
            this.Name = "Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnTraerTodo;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnObtenerPorId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtCodBar;
        private System.Windows.Forms.Button btnObtenerPorCodBar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtFechaDesde;
        private System.Windows.Forms.TextBox txtFechaHasta;
        private System.Windows.Forms.Button btnObtenerEntreFechas;
    }
}