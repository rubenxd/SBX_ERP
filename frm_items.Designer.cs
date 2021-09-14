
namespace SBX_ERP
{
    partial class frm_items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_items));
            this.pnl_botones = new System.Windows.Forms.Panel();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_consultas = new System.Windows.Forms.Button();
            this.pnl_centro = new System.Windows.Forms.Panel();
            this.rd_salida = new System.Windows.Forms.RadioButton();
            this.rd_entrada = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_stock_maximo = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_stock_minimo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_precio_venta = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_costo = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txt_margen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_tipo_item = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbx_estado = new System.Windows.Forms.ComboBox();
            this.btn_buscar_producto = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_codigo_barras = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_referencia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_item = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnl_botones.SuspendLayout();
            this.pnl_centro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_botones
            // 
            this.pnl_botones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_botones.Controls.Add(this.btn_limpiar);
            this.pnl_botones.Controls.Add(this.btn_guardar);
            this.pnl_botones.Controls.Add(this.btn_consultas);
            this.pnl_botones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_botones.Location = new System.Drawing.Point(0, 0);
            this.pnl_botones.Name = "pnl_botones";
            this.pnl_botones.Size = new System.Drawing.Size(372, 42);
            this.pnl_botones.TabIndex = 0;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpiar.FlatAppearance.BorderSize = 0;
            this.btn_limpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Image = ((System.Drawing.Image)(resources.GetObject("btn_limpiar.Image")));
            this.btn_limpiar.Location = new System.Drawing.Point(76, 8);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(26, 26);
            this.btn_limpiar.TabIndex = 3;
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.Location = new System.Drawing.Point(10, 8);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(26, 26);
            this.btn_guardar.TabIndex = 1;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_consultas
            // 
            this.btn_consultas.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_consultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_consultas.FlatAppearance.BorderSize = 0;
            this.btn_consultas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_consultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultas.Image = ((System.Drawing.Image)(resources.GetObject("btn_consultas.Image")));
            this.btn_consultas.Location = new System.Drawing.Point(44, 8);
            this.btn_consultas.Name = "btn_consultas";
            this.btn_consultas.Size = new System.Drawing.Size(26, 26);
            this.btn_consultas.TabIndex = 2;
            this.btn_consultas.UseVisualStyleBackColor = false;
            this.btn_consultas.Click += new System.EventHandler(this.btn_consultas_Click);
            // 
            // pnl_centro
            // 
            this.pnl_centro.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_centro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_centro.Controls.Add(this.rd_salida);
            this.pnl_centro.Controls.Add(this.rd_entrada);
            this.pnl_centro.Controls.Add(this.label12);
            this.pnl_centro.Controls.Add(this.txt_cantidad);
            this.pnl_centro.Controls.Add(this.label21);
            this.pnl_centro.Controls.Add(this.txt_stock_maximo);
            this.pnl_centro.Controls.Add(this.label17);
            this.pnl_centro.Controls.Add(this.txt_stock_minimo);
            this.pnl_centro.Controls.Add(this.label14);
            this.pnl_centro.Controls.Add(this.txt_precio_venta);
            this.pnl_centro.Controls.Add(this.label11);
            this.pnl_centro.Controls.Add(this.txt_costo);
            this.pnl_centro.Controls.Add(this.label28);
            this.pnl_centro.Controls.Add(this.txt_margen);
            this.pnl_centro.Controls.Add(this.label1);
            this.pnl_centro.Controls.Add(this.cbx_tipo_item);
            this.pnl_centro.Controls.Add(this.label8);
            this.pnl_centro.Controls.Add(this.cbx_estado);
            this.pnl_centro.Controls.Add(this.btn_buscar_producto);
            this.pnl_centro.Controls.Add(this.label15);
            this.pnl_centro.Controls.Add(this.txt_descripcion);
            this.pnl_centro.Controls.Add(this.label19);
            this.pnl_centro.Controls.Add(this.txt_codigo_barras);
            this.pnl_centro.Controls.Add(this.label4);
            this.pnl_centro.Controls.Add(this.txt_nombre);
            this.pnl_centro.Controls.Add(this.label3);
            this.pnl_centro.Controls.Add(this.txt_referencia);
            this.pnl_centro.Controls.Add(this.label2);
            this.pnl_centro.Controls.Add(this.txt_item);
            this.pnl_centro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_centro.Location = new System.Drawing.Point(0, 42);
            this.pnl_centro.Name = "pnl_centro";
            this.pnl_centro.Size = new System.Drawing.Size(372, 433);
            this.pnl_centro.TabIndex = 5;
            // 
            // rd_salida
            // 
            this.rd_salida.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rd_salida.AutoSize = true;
            this.rd_salida.BackColor = System.Drawing.Color.SteelBlue;
            this.rd_salida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_salida.ForeColor = System.Drawing.SystemColors.Window;
            this.rd_salida.Location = new System.Drawing.Point(234, 397);
            this.rd_salida.Name = "rd_salida";
            this.rd_salida.Size = new System.Drawing.Size(75, 19);
            this.rd_salida.TabIndex = 16;
            this.rd_salida.TabStop = true;
            this.rd_salida.Text = "Salida -";
            this.rd_salida.UseVisualStyleBackColor = false;
            // 
            // rd_entrada
            // 
            this.rd_entrada.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rd_entrada.AutoSize = true;
            this.rd_entrada.BackColor = System.Drawing.Color.SteelBlue;
            this.rd_entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_entrada.ForeColor = System.Drawing.SystemColors.Window;
            this.rd_entrada.Location = new System.Drawing.Point(113, 397);
            this.rd_entrada.Name = "rd_entrada";
            this.rd_entrada.Size = new System.Drawing.Size(87, 19);
            this.rd_entrada.TabIndex = 15;
            this.rd_entrada.TabStop = true;
            this.rd_entrada.Text = "Entrada +";
            this.rd_entrada.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 371);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 15);
            this.label12.TabIndex = 88;
            this.label12.Text = "Cantidad *";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_cantidad.Location = new System.Drawing.Point(113, 369);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(197, 20);
            this.txt_cantidad.TabIndex = 14;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(18, 345);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(84, 15);
            this.label21.TabIndex = 84;
            this.label21.Text = "Stock maximo";
            // 
            // txt_stock_maximo
            // 
            this.txt_stock_maximo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_stock_maximo.Location = new System.Drawing.Point(113, 343);
            this.txt_stock_maximo.Name = "txt_stock_maximo";
            this.txt_stock_maximo.Size = new System.Drawing.Size(197, 20);
            this.txt_stock_maximo.TabIndex = 13;
            this.txt_stock_maximo.Text = "0";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(18, 319);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 15);
            this.label17.TabIndex = 83;
            this.label17.Text = "Stock minimo";
            // 
            // txt_stock_minimo
            // 
            this.txt_stock_minimo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_stock_minimo.Location = new System.Drawing.Point(113, 317);
            this.txt_stock_minimo.Name = "txt_stock_minimo";
            this.txt_stock_minimo.Size = new System.Drawing.Size(197, 20);
            this.txt_stock_minimo.TabIndex = 12;
            this.txt_stock_minimo.Text = "0";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 267);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 15);
            this.label14.TabIndex = 79;
            this.label14.Text = "Precio venta *";
            // 
            // txt_precio_venta
            // 
            this.txt_precio_venta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_precio_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio_venta.Location = new System.Drawing.Point(113, 265);
            this.txt_precio_venta.Name = "txt_precio_venta";
            this.txt_precio_venta.Size = new System.Drawing.Size(197, 20);
            this.txt_precio_venta.TabIndex = 10;
            this.txt_precio_venta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_venta_KeyPress);
            this.txt_precio_venta.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_precio_venta_KeyUp);
            this.txt_precio_venta.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_precio_venta_PreviewKeyDown);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 15);
            this.label11.TabIndex = 76;
            this.label11.Text = "Costo *";
            // 
            // txt_costo
            // 
            this.txt_costo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_costo.Location = new System.Drawing.Point(113, 239);
            this.txt_costo.Name = "txt_costo";
            this.txt_costo.Size = new System.Drawing.Size(197, 20);
            this.txt_costo.TabIndex = 9;
            this.txt_costo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_costo_KeyPress);
            this.txt_costo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_costo_KeyUp);
            this.txt_costo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_costo_PreviewKeyDown);
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(18, 291);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(56, 15);
            this.label28.TabIndex = 80;
            this.label28.Text = "Margen *";
            // 
            // txt_margen
            // 
            this.txt_margen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_margen.Location = new System.Drawing.Point(113, 291);
            this.txt_margen.Name = "txt_margen";
            this.txt_margen.Size = new System.Drawing.Size(197, 20);
            this.txt_margen.TabIndex = 11;
            this.txt_margen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_margen_KeyPress);
            this.txt_margen.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_margen_KeyUp);
            this.txt_margen.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_margen_PreviewKeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 59;
            this.label1.Text = "Tipo Item";
            // 
            // cbx_tipo_item
            // 
            this.cbx_tipo_item.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbx_tipo_item.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_tipo_item.FormattingEnabled = true;
            this.cbx_tipo_item.Items.AddRange(new object[] {
            "Producto",
            "Servicio",
            "TOT"});
            this.cbx_tipo_item.Location = new System.Drawing.Point(113, 212);
            this.cbx_tipo_item.Name = "cbx_tipo_item";
            this.cbx_tipo_item.Size = new System.Drawing.Size(197, 21);
            this.cbx_tipo_item.TabIndex = 8;
            this.cbx_tipo_item.SelectedIndexChanged += new System.EventHandler(this.cbx_tipo_item_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 15);
            this.label8.TabIndex = 56;
            this.label8.Text = "Estado";
            // 
            // cbx_estado
            // 
            this.cbx_estado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbx_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_estado.FormattingEnabled = true;
            this.cbx_estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbx_estado.Location = new System.Drawing.Point(113, 185);
            this.cbx_estado.Name = "cbx_estado";
            this.cbx_estado.Size = new System.Drawing.Size(197, 21);
            this.cbx_estado.TabIndex = 7;
            // 
            // btn_buscar_producto
            // 
            this.btn_buscar_producto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_buscar_producto.BackColor = System.Drawing.SystemColors.Window;
            this.btn_buscar_producto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar_producto.FlatAppearance.BorderSize = 0;
            this.btn_buscar_producto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_buscar_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar_producto.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar_producto.Image")));
            this.btn_buscar_producto.Location = new System.Drawing.Point(328, 9);
            this.btn_buscar_producto.Name = "btn_buscar_producto";
            this.btn_buscar_producto.Size = new System.Drawing.Size(22, 22);
            this.btn_buscar_producto.TabIndex = 2;
            this.btn_buscar_producto.UseVisualStyleBackColor = false;
            this.btn_buscar_producto.Click += new System.EventHandler(this.btn_buscar_producto_Click);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(18, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 15);
            this.label15.TabIndex = 53;
            this.label15.Text = "Descripcion";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_descripcion.Location = new System.Drawing.Point(113, 63);
            this.txt_descripcion.MaxLength = 200;
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(197, 64);
            this.txt_descripcion.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(18, 161);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 15);
            this.label19.TabIndex = 52;
            this.label19.Text = "Código Barras";
            // 
            // txt_codigo_barras
            // 
            this.txt_codigo_barras.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_codigo_barras.Location = new System.Drawing.Point(113, 159);
            this.txt_codigo_barras.MaxLength = 100;
            this.txt_codigo_barras.Name = "txt_codigo_barras";
            this.txt_codigo_barras.Size = new System.Drawing.Size(197, 20);
            this.txt_codigo_barras.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 51;
            this.label4.Text = "Nombre *";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_nombre.Location = new System.Drawing.Point(113, 37);
            this.txt_nombre.MaxLength = 200;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(197, 20);
            this.txt_nombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 48;
            this.label3.Text = "Referencia";
            // 
            // txt_referencia
            // 
            this.txt_referencia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_referencia.Location = new System.Drawing.Point(113, 133);
            this.txt_referencia.MaxLength = 20;
            this.txt_referencia.Name = "txt_referencia";
            this.txt_referencia.Size = new System.Drawing.Size(197, 20);
            this.txt_referencia.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 45;
            this.label2.Text = "Item";
            // 
            // txt_item
            // 
            this.txt_item.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_item.Enabled = false;
            this.txt_item.Location = new System.Drawing.Point(113, 11);
            this.txt_item.MaxLength = 10;
            this.txt_item.Name = "txt_item";
            this.txt_item.Size = new System.Drawing.Size(197, 20);
            this.txt_item.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 475);
            this.Controls.Add(this.pnl_centro);
            this.Controls.Add(this.pnl_botones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_items";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Items";
            this.Load += new System.EventHandler(this.frm_items_Load);
            this.pnl_botones.ResumeLayout(false);
            this.pnl_centro.ResumeLayout(false);
            this.pnl_centro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_botones;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_consultas;
        private System.Windows.Forms.Panel pnl_centro;
        private System.Windows.Forms.Button btn_buscar_producto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_codigo_barras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_referencia;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_item;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbx_estado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_tipo_item;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_precio_venta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_costo;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txt_margen;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt_stock_maximo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_stock_minimo;
        private System.Windows.Forms.RadioButton rd_salida;
        private System.Windows.Forms.RadioButton rd_entrada;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}