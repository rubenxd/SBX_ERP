
namespace SBX_ERP
{
    partial class frm_orden_servicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_orden_servicio));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.btn_cotizacion = new System.Windows.Forms.Button();
            this.btn_quitar_uno = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_nota = new System.Windows.Forms.TextBox();
            this.lbl_placa = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_identificacion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_vehiculo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_placa = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_buscar_items = new System.Windows.Forms.Button();
            this.txt_items = new System.Windows.Forms.TextBox();
            this.dtg_venta = new System.Windows.Forms.DataGridView();
            this.cl_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_precioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_km = new System.Windows.Forms.TextBox();
            this.pnl_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_venta)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackColor = System.Drawing.Color.Gray;
            this.pnl_menu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_menu.Controls.Add(this.btn_cotizacion);
            this.pnl_menu.Controls.Add(this.btn_quitar_uno);
            this.pnl_menu.Controls.Add(this.btn_buscar);
            this.pnl_menu.Controls.Add(this.btn_guardar);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(818, 41);
            this.pnl_menu.TabIndex = 0;
            // 
            // btn_cotizacion
            // 
            this.btn_cotizacion.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_cotizacion.FlatAppearance.BorderSize = 0;
            this.btn_cotizacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_cotizacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_cotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cotizacion.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_cotizacion.Image = ((System.Drawing.Image)(resources.GetObject("btn_cotizacion.Image")));
            this.btn_cotizacion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cotizacion.Location = new System.Drawing.Point(117, 0);
            this.btn_cotizacion.Name = "btn_cotizacion";
            this.btn_cotizacion.Size = new System.Drawing.Size(39, 37);
            this.btn_cotizacion.TabIndex = 4;
            this.btn_cotizacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cotizacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_cotizacion.UseVisualStyleBackColor = true;
            this.btn_cotizacion.Click += new System.EventHandler(this.btn_cotizacion_Click);
            // 
            // btn_quitar_uno
            // 
            this.btn_quitar_uno.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_quitar_uno.FlatAppearance.BorderSize = 0;
            this.btn_quitar_uno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_quitar_uno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_quitar_uno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quitar_uno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitar_uno.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_quitar_uno.Image = ((System.Drawing.Image)(resources.GetObject("btn_quitar_uno.Image")));
            this.btn_quitar_uno.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_quitar_uno.Location = new System.Drawing.Point(78, 0);
            this.btn_quitar_uno.Name = "btn_quitar_uno";
            this.btn_quitar_uno.Size = new System.Drawing.Size(39, 37);
            this.btn_quitar_uno.TabIndex = 3;
            this.btn_quitar_uno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_quitar_uno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_quitar_uno.UseVisualStyleBackColor = true;
            this.btn_quitar_uno.Click += new System.EventHandler(this.btn_quitar_uno_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_buscar.Location = new System.Drawing.Point(39, 0);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(39, 37);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar.Location = new System.Drawing.Point(0, 0);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(39, 37);
            this.btn_guardar.TabIndex = 1;
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_km);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_nota);
            this.groupBox1.Controls.Add(this.lbl_placa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_identificacion);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_modelo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_vehiculo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_placa);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(796, 159);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(59, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 65;
            this.label7.Text = "Nota";
            // 
            // txt_nota
            // 
            this.txt_nota.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nota.Location = new System.Drawing.Point(155, 117);
            this.txt_nota.MaxLength = 50;
            this.txt_nota.Name = "txt_nota";
            this.txt_nota.Size = new System.Drawing.Size(578, 23);
            this.txt_nota.TabIndex = 64;
            // 
            // lbl_placa
            // 
            this.lbl_placa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_placa.AutoSize = true;
            this.lbl_placa.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_placa.Location = new System.Drawing.Point(267, 22);
            this.lbl_placa.Name = "lbl_placa";
            this.lbl_placa.Size = new System.Drawing.Size(43, 16);
            this.lbl_placa.TabIndex = 61;
            this.lbl_placa.Text = "Placa";
            this.lbl_placa.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 60;
            this.label5.Text = "Identificacion";
            // 
            // txt_identificacion
            // 
            this.txt_identificacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_identificacion.Enabled = false;
            this.txt_identificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_identificacion.Location = new System.Drawing.Point(155, 59);
            this.txt_identificacion.MaxLength = 50;
            this.txt_identificacion.Name = "txt_identificacion";
            this.txt_identificacion.Size = new System.Drawing.Size(218, 23);
            this.txt_identificacion.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 58;
            this.label6.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_nombre.Enabled = false;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(155, 88);
            this.txt_nombre.MaxLength = 50;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(218, 23);
            this.txt_nombre.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(448, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 54;
            this.label3.Text = "Modelo";
            // 
            // txt_modelo
            // 
            this.txt_modelo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_modelo.Enabled = false;
            this.txt_modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_modelo.Location = new System.Drawing.Point(515, 56);
            this.txt_modelo.MaxLength = 50;
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(218, 23);
            this.txt_modelo.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(448, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "Vehiculo";
            // 
            // txt_vehiculo
            // 
            this.txt_vehiculo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_vehiculo.Enabled = false;
            this.txt_vehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vehiculo.Location = new System.Drawing.Point(515, 85);
            this.txt_vehiculo.MaxLength = 50;
            this.txt_vehiculo.Name = "txt_vehiculo";
            this.txt_vehiculo.Size = new System.Drawing.Size(218, 23);
            this.txt_vehiculo.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "Placa";
            // 
            // txt_placa
            // 
            this.txt_placa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_placa.Location = new System.Drawing.Point(155, 19);
            this.txt_placa.MaxLength = 50;
            this.txt_placa.Name = "txt_placa";
            this.txt_placa.Size = new System.Drawing.Size(105, 23);
            this.txt_placa.TabIndex = 1;
            this.txt_placa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_placa_KeyPress);
            this.txt_placa.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_placa_PreviewKeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_buscar_items);
            this.groupBox2.Controls.Add(this.txt_items);
            this.groupBox2.Controls.Add(this.dtg_venta);
            this.groupBox2.Location = new System.Drawing.Point(12, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(796, 271);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            // 
            // btn_buscar_items
            // 
            this.btn_buscar_items.BackColor = System.Drawing.SystemColors.Control;
            this.btn_buscar_items.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar_items.FlatAppearance.BorderSize = 0;
            this.btn_buscar_items.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_buscar_items.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar_items.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar_items.Image")));
            this.btn_buscar_items.Location = new System.Drawing.Point(180, 17);
            this.btn_buscar_items.Name = "btn_buscar_items";
            this.btn_buscar_items.Size = new System.Drawing.Size(22, 22);
            this.btn_buscar_items.TabIndex = 3;
            this.btn_buscar_items.UseVisualStyleBackColor = false;
            this.btn_buscar_items.Click += new System.EventHandler(this.btn_buscar_items_Click);
            // 
            // txt_items
            // 
            this.txt_items.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_items.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_items.Location = new System.Drawing.Point(10, 18);
            this.txt_items.MaxLength = 50;
            this.txt_items.Name = "txt_items";
            this.txt_items.Size = new System.Drawing.Size(148, 23);
            this.txt_items.TabIndex = 2;
            this.txt_items.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_items_KeyPress);
            this.txt_items.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_items_PreviewKeyDown);
            // 
            // dtg_venta
            // 
            this.dtg_venta.AllowUserToAddRows = false;
            this.dtg_venta.AllowUserToDeleteRows = false;
            this.dtg_venta.AllowUserToOrderColumns = true;
            this.dtg_venta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_venta.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtg_venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_venta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_item,
            this.cl_Nombre,
            this.cl_Descripcion,
            this.cl_referencia,
            this.cl_cantidad,
            this.cl_costo,
            this.cl_precioVenta,
            this.cl_descuento,
            this.cl_total});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_venta.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_venta.Location = new System.Drawing.Point(10, 48);
            this.dtg_venta.Name = "dtg_venta";
            this.dtg_venta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_venta.Size = new System.Drawing.Size(774, 217);
            this.dtg_venta.TabIndex = 4;
            this.dtg_venta.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dtg_venta_RowValidating);
            // 
            // cl_item
            // 
            this.cl_item.HeaderText = "Item";
            this.cl_item.Name = "cl_item";
            this.cl_item.ReadOnly = true;
            // 
            // cl_Nombre
            // 
            this.cl_Nombre.HeaderText = "Nombre";
            this.cl_Nombre.Name = "cl_Nombre";
            this.cl_Nombre.ReadOnly = true;
            // 
            // cl_Descripcion
            // 
            this.cl_Descripcion.HeaderText = "Descripcion";
            this.cl_Descripcion.Name = "cl_Descripcion";
            this.cl_Descripcion.ReadOnly = true;
            // 
            // cl_referencia
            // 
            this.cl_referencia.HeaderText = "Referencia";
            this.cl_referencia.Name = "cl_referencia";
            this.cl_referencia.ReadOnly = true;
            // 
            // cl_cantidad
            // 
            this.cl_cantidad.HeaderText = "Cantidad";
            this.cl_cantidad.Name = "cl_cantidad";
            // 
            // cl_costo
            // 
            this.cl_costo.HeaderText = "costo";
            this.cl_costo.Name = "cl_costo";
            this.cl_costo.Visible = false;
            // 
            // cl_precioVenta
            // 
            this.cl_precioVenta.HeaderText = "Precio venta";
            this.cl_precioVenta.Name = "cl_precioVenta";
            // 
            // cl_descuento
            // 
            this.cl_descuento.HeaderText = "Descuento";
            this.cl_descuento.Name = "cl_descuento";
            // 
            // cl_total
            // 
            this.cl_total.HeaderText = "Total";
            this.cl_total.Name = "cl_total";
            this.cl_total.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(399, 488);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 23);
            this.label4.TabIndex = 56;
            this.label4.Text = "Total";
            // 
            // txt_total
            // 
            this.txt_total.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_total.Enabled = false;
            this.txt_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(457, 484);
            this.txt_total.MaxLength = 50;
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(351, 30);
            this.txt_total.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(448, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 16);
            this.label8.TabIndex = 67;
            this.label8.Text = "Km";
            // 
            // txt_km
            // 
            this.txt_km.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_km.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_km.Location = new System.Drawing.Point(515, 22);
            this.txt_km.MaxLength = 50;
            this.txt_km.Name = "txt_km";
            this.txt_km.Size = new System.Drawing.Size(105, 23);
            this.txt_km.TabIndex = 66;
            // 
            // frm_orden_servicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 522);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnl_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_orden_servicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orden servicio";
            this.pnl_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_venta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnl_menu;
        public System.Windows.Forms.Button btn_buscar;
        public System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_placa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_vehiculo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_modelo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_identificacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtg_venta;
        private System.Windows.Forms.TextBox txt_items;
        private System.Windows.Forms.Button btn_buscar_items;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label lbl_placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_precioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_total;
        public System.Windows.Forms.Button btn_quitar_uno;
        public System.Windows.Forms.Button btn_cotizacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_nota;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_km;
    }
}