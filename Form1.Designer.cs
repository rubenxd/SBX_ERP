
namespace SBX_ERP
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnl_arriba = new System.Windows.Forms.Panel();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_fecha_hora = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.btn_config = new System.Windows.Forms.Button();
            this.btn_producto = new System.Windows.Forms.Button();
            this.btn_comercial = new System.Windows.Forms.Button();
            this.pnl_centro = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnl_arriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_menu.SuspendLayout();
            this.pnl_centro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_arriba
            // 
            this.pnl_arriba.BackColor = System.Drawing.Color.SeaGreen;
            this.pnl_arriba.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_arriba.Controls.Add(this.lbl_usuario);
            this.pnl_arriba.Controls.Add(this.lbl_fecha_hora);
            this.pnl_arriba.Controls.Add(this.pictureBox1);
            this.pnl_arriba.Controls.Add(this.label1);
            this.pnl_arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_arriba.Location = new System.Drawing.Point(0, 0);
            this.pnl_arriba.Name = "pnl_arriba";
            this.pnl_arriba.Size = new System.Drawing.Size(800, 30);
            this.pnl_arriba.TabIndex = 1;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_usuario.Location = new System.Drawing.Point(139, 5);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(57, 15);
            this.lbl_usuario.TabIndex = 13;
            this.lbl_usuario.Text = "Usuario";
            // 
            // lbl_fecha_hora
            // 
            this.lbl_fecha_hora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_fecha_hora.AutoSize = true;
            this.lbl_fecha_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_hora.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_fecha_hora.Location = new System.Drawing.Point(465, 5);
            this.lbl_fecha_hora.Name = "lbl_fecha_hora";
            this.lbl_fecha_hora.Size = new System.Drawing.Size(89, 15);
            this.lbl_fecha_hora.TabIndex = 12;
            this.lbl_fecha_hora.Text = "Fecha y hora";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(37, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "SBX";
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackColor = System.Drawing.Color.Gray;
            this.pnl_menu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_menu.Controls.Add(this.btn_config);
            this.pnl_menu.Controls.Add(this.btn_producto);
            this.pnl_menu.Controls.Add(this.btn_comercial);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_menu.Location = new System.Drawing.Point(0, 30);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(800, 61);
            this.pnl_menu.TabIndex = 2;
            // 
            // btn_config
            // 
            this.btn_config.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_config.FlatAppearance.BorderSize = 0;
            this.btn_config.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_config.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_config.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_config.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_config.Image = ((System.Drawing.Image)(resources.GetObject("btn_config.Image")));
            this.btn_config.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_config.Location = new System.Drawing.Point(154, 0);
            this.btn_config.Name = "btn_config";
            this.btn_config.Size = new System.Drawing.Size(82, 57);
            this.btn_config.TabIndex = 2;
            this.btn_config.Text = "Config";
            this.btn_config.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_config.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_config.UseVisualStyleBackColor = true;
            this.btn_config.Visible = false;
            this.btn_config.Click += new System.EventHandler(this.btn_config_Click);
            // 
            // btn_producto
            // 
            this.btn_producto.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_producto.FlatAppearance.BorderSize = 0;
            this.btn_producto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_producto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_producto.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_producto.Image = ((System.Drawing.Image)(resources.GetObject("btn_producto.Image")));
            this.btn_producto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_producto.Location = new System.Drawing.Point(72, 0);
            this.btn_producto.Name = "btn_producto";
            this.btn_producto.Size = new System.Drawing.Size(82, 57);
            this.btn_producto.TabIndex = 1;
            this.btn_producto.Text = "Financiero";
            this.btn_producto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_producto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_producto.UseVisualStyleBackColor = true;
            this.btn_producto.Visible = false;
            // 
            // btn_comercial
            // 
            this.btn_comercial.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_comercial.FlatAppearance.BorderSize = 0;
            this.btn_comercial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_comercial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_comercial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comercial.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_comercial.Image = ((System.Drawing.Image)(resources.GetObject("btn_comercial.Image")));
            this.btn_comercial.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_comercial.Location = new System.Drawing.Point(0, 0);
            this.btn_comercial.Name = "btn_comercial";
            this.btn_comercial.Size = new System.Drawing.Size(72, 57);
            this.btn_comercial.TabIndex = 0;
            this.btn_comercial.Text = "Comercial";
            this.btn_comercial.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_comercial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_comercial.UseVisualStyleBackColor = true;
            this.btn_comercial.Click += new System.EventHandler(this.btn_comercial_Click);
            // 
            // pnl_centro
            // 
            this.pnl_centro.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_centro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_centro.Controls.Add(this.pictureBox2);
            this.pnl_centro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_centro.Location = new System.Drawing.Point(0, 91);
            this.pnl_centro.Name = "pnl_centro";
            this.pnl_centro.Size = new System.Drawing.Size(800, 359);
            this.pnl_centro.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(397, 130);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(389, 222);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_centro);
            this.Controls.Add(this.pnl_menu);
            this.Controls.Add(this.pnl_arriba);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_arriba.ResumeLayout(false);
            this.pnl_arriba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_menu.ResumeLayout(false);
            this.pnl_centro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_arriba;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_fecha_hora;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_menu;
        public System.Windows.Forms.Button btn_producto;
        public System.Windows.Forms.Button btn_comercial;
        private System.Windows.Forms.Panel pnl_centro;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Button btn_config;
    }
}

