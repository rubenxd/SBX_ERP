
namespace SBX_ERP
{
    partial class frm_vehiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_vehiculos));
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.pnl_centro = new System.Windows.Forms.Panel();
            this.lbl_codigo_tercero = new System.Windows.Forms.Label();
            this.btn_buscar_2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_km = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_placa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_vehiculo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tercero = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnl_menu.SuspendLayout();
            this.pnl_centro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackColor = System.Drawing.Color.Gray;
            this.pnl_menu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_menu.Controls.Add(this.btn_buscar);
            this.pnl_menu.Controls.Add(this.btn_guardar);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(344, 41);
            this.pnl_menu.TabIndex = 0;
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
            // pnl_centro
            // 
            this.pnl_centro.BackColor = System.Drawing.SystemColors.Menu;
            this.pnl_centro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_centro.Controls.Add(this.lbl_codigo_tercero);
            this.pnl_centro.Controls.Add(this.btn_buscar_2);
            this.pnl_centro.Controls.Add(this.label1);
            this.pnl_centro.Controls.Add(this.txt_nombre);
            this.pnl_centro.Controls.Add(this.label12);
            this.pnl_centro.Controls.Add(this.txt_km);
            this.pnl_centro.Controls.Add(this.label11);
            this.pnl_centro.Controls.Add(this.txt_modelo);
            this.pnl_centro.Controls.Add(this.label10);
            this.pnl_centro.Controls.Add(this.txt_placa);
            this.pnl_centro.Controls.Add(this.label9);
            this.pnl_centro.Controls.Add(this.txt_vehiculo);
            this.pnl_centro.Controls.Add(this.label2);
            this.pnl_centro.Controls.Add(this.txt_tercero);
            this.pnl_centro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_centro.Location = new System.Drawing.Point(0, 41);
            this.pnl_centro.Name = "pnl_centro";
            this.pnl_centro.Size = new System.Drawing.Size(344, 196);
            this.pnl_centro.TabIndex = 6;
            // 
            // lbl_codigo_tercero
            // 
            this.lbl_codigo_tercero.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_codigo_tercero.AutoSize = true;
            this.lbl_codigo_tercero.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo_tercero.Location = new System.Drawing.Point(6, 216);
            this.lbl_codigo_tercero.Name = "lbl_codigo_tercero";
            this.lbl_codigo_tercero.Size = new System.Drawing.Size(106, 16);
            this.lbl_codigo_tercero.TabIndex = 71;
            this.lbl_codigo_tercero.Text = "Codigo_tercero";
            this.lbl_codigo_tercero.Visible = false;
            // 
            // btn_buscar_2
            // 
            this.btn_buscar_2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_buscar_2.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_buscar_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar_2.FlatAppearance.BorderSize = 0;
            this.btn_buscar_2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_buscar_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar_2.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar_2.Image")));
            this.btn_buscar_2.Location = new System.Drawing.Point(306, 14);
            this.btn_buscar_2.Name = "btn_buscar_2";
            this.btn_buscar_2.Size = new System.Drawing.Size(22, 15);
            this.btn_buscar_2.TabIndex = 2;
            this.btn_buscar_2.UseVisualStyleBackColor = false;
            this.btn_buscar_2.Click += new System.EventHandler(this.btn_buscar_2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 69;
            this.label1.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_nombre.Enabled = false;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(79, 40);
            this.txt_nombre.MaxLength = 50;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(209, 23);
            this.txt_nombre.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 16);
            this.label12.TabIndex = 67;
            this.label12.Text = "KM";
            // 
            // txt_km
            // 
            this.txt_km.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_km.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_km.Location = new System.Drawing.Point(79, 156);
            this.txt_km.MaxLength = 50;
            this.txt_km.Name = "txt_km";
            this.txt_km.Size = new System.Drawing.Size(209, 23);
            this.txt_km.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 16);
            this.label11.TabIndex = 65;
            this.label11.Text = "Modelo *";
            // 
            // txt_modelo
            // 
            this.txt_modelo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_modelo.Location = new System.Drawing.Point(79, 127);
            this.txt_modelo.MaxLength = 50;
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(209, 23);
            this.txt_modelo.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 63;
            this.label10.Text = "Placa *";
            // 
            // txt_placa
            // 
            this.txt_placa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_placa.Location = new System.Drawing.Point(79, 98);
            this.txt_placa.MaxLength = 50;
            this.txt_placa.Name = "txt_placa";
            this.txt_placa.Size = new System.Drawing.Size(209, 23);
            this.txt_placa.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 61;
            this.label9.Text = "Vehiculo *";
            // 
            // txt_vehiculo
            // 
            this.txt_vehiculo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_vehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vehiculo.Location = new System.Drawing.Point(79, 69);
            this.txt_vehiculo.MaxLength = 50;
            this.txt_vehiculo.Name = "txt_vehiculo";
            this.txt_vehiculo.Size = new System.Drawing.Size(209, 23);
            this.txt_vehiculo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Tercero *";
            // 
            // txt_tercero
            // 
            this.txt_tercero.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_tercero.Enabled = false;
            this.txt_tercero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tercero.Location = new System.Drawing.Point(79, 11);
            this.txt_tercero.MaxLength = 50;
            this.txt_tercero.Name = "txt_tercero";
            this.txt_tercero.Size = new System.Drawing.Size(209, 23);
            this.txt_tercero.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_vehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 237);
            this.Controls.Add(this.pnl_centro);
            this.Controls.Add(this.pnl_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_vehiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehiculos";
            this.pnl_menu.ResumeLayout(false);
            this.pnl_centro.ResumeLayout(false);
            this.pnl_centro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_menu;
        public System.Windows.Forms.Button btn_buscar;
        public System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Panel pnl_centro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_km;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_modelo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_placa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_vehiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tercero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Button btn_buscar_2;
        private System.Windows.Forms.Label lbl_codigo_tercero;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}