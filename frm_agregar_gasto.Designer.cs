
namespace SBX_ERP
{
    partial class frm_agregar_gasto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_agregar_gasto));
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nom_proveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_valor_iva = new System.Windows.Forms.TextBox();
            this.btn_buscar_proveedor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_arriba = new System.Windows.Forms.Panel();
            this.lbl_cerrar = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_proveedor = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_Gasto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.pnl_arriba.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-6, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 47;
            this.label3.Text = "Nombre";
            this.label3.Visible = false;
            // 
            // txt_nom_proveedor
            // 
            this.txt_nom_proveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nom_proveedor.Enabled = false;
            this.txt_nom_proveedor.Location = new System.Drawing.Point(80, 198);
            this.txt_nom_proveedor.MaxLength = 200;
            this.txt_nom_proveedor.Name = "txt_nom_proveedor";
            this.txt_nom_proveedor.Size = new System.Drawing.Size(197, 20);
            this.txt_nom_proveedor.TabIndex = 2;
            this.txt_nom_proveedor.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F);
            this.label2.Location = new System.Drawing.Point(18, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 45;
            this.label2.Text = "Valor IVA";
            // 
            // txt_valor_iva
            // 
            this.txt_valor_iva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor_iva.Location = new System.Drawing.Point(80, 99);
            this.txt_valor_iva.Name = "txt_valor_iva";
            this.txt_valor_iva.Size = new System.Drawing.Size(197, 20);
            this.txt_valor_iva.TabIndex = 5;
            // 
            // btn_buscar_proveedor
            // 
            this.btn_buscar_proveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_buscar_proveedor.BackColor = System.Drawing.SystemColors.Control;
            this.btn_buscar_proveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar_proveedor.FlatAppearance.BorderSize = 0;
            this.btn_buscar_proveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_buscar_proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar_proveedor.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar_proveedor.Image")));
            this.btn_buscar_proveedor.Location = new System.Drawing.Point(294, 189);
            this.btn_buscar_proveedor.Name = "btn_buscar_proveedor";
            this.btn_buscar_proveedor.Size = new System.Drawing.Size(22, 22);
            this.btn_buscar_proveedor.TabIndex = 1;
            this.btn_buscar_proveedor.UseVisualStyleBackColor = false;
            this.btn_buscar_proveedor.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(5, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Agregar Gasto";
            // 
            // pnl_arriba
            // 
            this.pnl_arriba.BackColor = System.Drawing.Color.DimGray;
            this.pnl_arriba.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_arriba.Controls.Add(this.label1);
            this.pnl_arriba.Controls.Add(this.lbl_cerrar);
            this.pnl_arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_arriba.Location = new System.Drawing.Point(0, 0);
            this.pnl_arriba.Name = "pnl_arriba";
            this.pnl_arriba.Size = new System.Drawing.Size(310, 28);
            this.pnl_arriba.TabIndex = 3;
            // 
            // lbl_cerrar
            // 
            this.lbl_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cerrar.AutoSize = true;
            this.lbl_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_cerrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cerrar.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_cerrar.Location = new System.Drawing.Point(283, 3);
            this.lbl_cerrar.Name = "lbl_cerrar";
            this.lbl_cerrar.Size = new System.Drawing.Size(17, 16);
            this.lbl_cerrar.TabIndex = 0;
            this.lbl_cerrar.Text = "X";
            this.lbl_cerrar.Click += new System.EventHandler(this.lbl_cerrar_Click);
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(-6, 193);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 15);
            this.label20.TabIndex = 43;
            this.label20.Text = "Proveedor";
            this.label20.Visible = false;
            // 
            // txt_proveedor
            // 
            this.txt_proveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_proveedor.Enabled = false;
            this.txt_proveedor.Location = new System.Drawing.Point(80, 191);
            this.txt_proveedor.MaxLength = 50;
            this.txt_proveedor.Name = "txt_proveedor";
            this.txt_proveedor.Size = new System.Drawing.Size(197, 20);
            this.txt_proveedor.TabIndex = 0;
            this.txt_proveedor.Text = "0";
            this.txt_proveedor.Visible = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.DimGray;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(165, 136);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(80, 30);
            this.btn_cancelar.TabIndex = 7;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.DimGray;
            this.btn_aceptar.FlatAppearance.BorderSize = 0;
            this.btn_aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_aceptar.Location = new System.Drawing.Point(93, 136);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(66, 30);
            this.btn_aceptar.TabIndex = 6;
            this.btn_aceptar.Text = "Guardar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "Gasto";
            // 
            // cbx_Gasto
            // 
            this.cbx_Gasto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbx_Gasto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Gasto.FormattingEnabled = true;
            this.cbx_Gasto.Location = new System.Drawing.Point(80, 46);
            this.cbx_Gasto.Name = "cbx_Gasto";
            this.cbx_Gasto.Size = new System.Drawing.Size(197, 21);
            this.cbx_Gasto.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F);
            this.label4.Location = new System.Drawing.Point(18, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "Valor";
            // 
            // txt_valor
            // 
            this.txt_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor.Location = new System.Drawing.Point(80, 73);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(197, 20);
            this.txt_valor.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_nom_proveedor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_valor_iva);
            this.panel1.Controls.Add(this.btn_buscar_proveedor);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.txt_proveedor);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.btn_aceptar);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbx_Gasto);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_valor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 190);
            this.panel1.TabIndex = 4;
            // 
            // frm_agregar_gasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 190);
            this.Controls.Add(this.pnl_arriba);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_agregar_gasto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_agregar_gasto";
            this.Load += new System.EventHandler(this.frm_agregar_gasto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.pnl_arriba.ResumeLayout(false);
            this.pnl_arriba.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel pnl_arriba;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_cerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nom_proveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_valor_iva;
        private System.Windows.Forms.Button btn_buscar_proveedor;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_proveedor;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_Gasto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_valor;
    }
}