using C1.Win.C1Ribbon;

namespace CpMinerva
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.c1Ribbon1 = new C1.Win.C1Ribbon.C1Ribbon();
            this.ribbonApplicationMenu1 = new C1.Win.C1Ribbon.RibbonApplicationMenu();
            this.ribbonBottomToolBar1 = new C1.Win.C1Ribbon.RibbonBottomToolBar();
            this.ribbonConfigToolBar1 = new C1.Win.C1Ribbon.RibbonConfigToolBar();
            this.ribbonQat1 = new C1.Win.C1Ribbon.RibbonQat();
            this.tabCatalogos = new C1.Win.C1Ribbon.RibbonTab();
            this.ribbonGroup1 = new C1.Win.C1Ribbon.RibbonGroup();
            this.btnCaProductos = new C1.Win.C1Ribbon.RibbonButton();
            this.btnCaProveedores = new C1.Win.C1Ribbon.RibbonButton();
            this.btnCaClientes = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonTab2 = new C1.Win.C1Ribbon.RibbonTab();
            this.ribbonGroup2 = new C1.Win.C1Ribbon.RibbonGroup();
            this.ribbonButton4 = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonButton5 = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonGroup6 = new C1.Win.C1Ribbon.RibbonGroup();
            this.ribbonButton6 = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonTab5 = new C1.Win.C1Ribbon.RibbonTab();
            this.ribbonGroup5 = new C1.Win.C1Ribbon.RibbonGroup();
            this.ribbonTab3 = new C1.Win.C1Ribbon.RibbonTab();
            this.ribbonGroup3 = new C1.Win.C1Ribbon.RibbonGroup();
            this.btnAdUsuarios = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonTab4 = new C1.Win.C1Ribbon.RibbonTab();
            this.ribbonGroup4 = new C1.Win.C1Ribbon.RibbonGroup();
            this.ribbonButton8 = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonButton9 = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonTopToolBar1 = new C1.Win.C1Ribbon.RibbonTopToolBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Ribbon1
            // 
            this.c1Ribbon1.ApplicationMenuHolder = this.ribbonApplicationMenu1;
            this.c1Ribbon1.AutoSizeElement = C1.Framework.AutoSizeElement.Width;
            this.c1Ribbon1.BottomToolBarHolder = this.ribbonBottomToolBar1;
            this.c1Ribbon1.ConfigToolBarHolder = this.ribbonConfigToolBar1;
            this.c1Ribbon1.Location = new System.Drawing.Point(0, 0);
            this.c1Ribbon1.Name = "c1Ribbon1";
            this.c1Ribbon1.QatHolder = this.ribbonQat1;
            this.c1Ribbon1.Size = new System.Drawing.Size(625, 154);
            this.c1Ribbon1.Tabs.Add(this.tabCatalogos);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab2);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab5);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab3);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab4);
            this.c1Ribbon1.TopToolBarHolder = this.ribbonTopToolBar1;
            this.c1Ribbon1.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Office2010Black;
            // 
            // ribbonApplicationMenu1
            // 
            this.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1";
            // 
            // ribbonBottomToolBar1
            // 
            this.ribbonBottomToolBar1.Name = "ribbonBottomToolBar1";
            // 
            // ribbonConfigToolBar1
            // 
            this.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1";
            // 
            // ribbonQat1
            // 
            this.ribbonQat1.Name = "ribbonQat1";
            // 
            // tabCatalogos
            // 
            this.tabCatalogos.Groups.Add(this.ribbonGroup1);
            this.tabCatalogos.Name = "tabCatalogos";
            this.tabCatalogos.Text = "Catálogos";
            // 
            // ribbonGroup1
            // 
            this.ribbonGroup1.Items.Add(this.btnCaProductos);
            this.ribbonGroup1.Items.Add(this.btnCaProveedores);
            this.ribbonGroup1.Items.Add(this.btnCaClientes);
            this.ribbonGroup1.Name = "ribbonGroup1";
            this.ribbonGroup1.Text = "Gestión de Catálogos";
            // 
            // btnCaProductos
            // 
            this.btnCaProductos.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCaProductos.LargeImage")));
            this.btnCaProductos.Name = "btnCaProductos";
            this.btnCaProductos.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnCaProductos.SmallImage")));
            this.btnCaProductos.Text = "Productos";
            this.btnCaProductos.ToolTip = "Gestión de Productos";
            this.btnCaProductos.Click += new System.EventHandler(this.btnCaProductos_Click);
            // 
            // btnCaProveedores
            // 
            this.btnCaProveedores.LargeImage = global::CpMinerva.Properties.Resources.provider;
            this.btnCaProveedores.Name = "btnCaProveedores";
            this.btnCaProveedores.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnCaProveedores.SmallImage")));
            this.btnCaProveedores.Text = "Proveedores";
            this.btnCaProveedores.ToolTip = "Gestión de Proveedores";
            // 
            // btnCaClientes
            // 
            this.btnCaClientes.LargeImage = global::CpMinerva.Properties.Resources.clients;
            this.btnCaClientes.Name = "btnCaClientes";
            this.btnCaClientes.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnCaClientes.SmallImage")));
            this.btnCaClientes.Text = "Clientes";
            this.btnCaClientes.ToolTip = "Gestión de Clientes";
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Groups.Add(this.ribbonGroup2);
            this.ribbonTab2.Groups.Add(this.ribbonGroup6);
            this.ribbonTab2.Name = "ribbonTab2";
            this.ribbonTab2.Text = "Caja";
            // 
            // ribbonGroup2
            // 
            this.ribbonGroup2.Items.Add(this.ribbonButton4);
            this.ribbonGroup2.Items.Add(this.ribbonButton5);
            this.ribbonGroup2.Name = "ribbonGroup2";
            this.ribbonGroup2.Text = "Compras y Ventas";
            // 
            // ribbonButton4
            // 
            this.ribbonButton4.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.LargeImage")));
            this.ribbonButton4.Name = "ribbonButton4";
            this.ribbonButton4.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.SmallImage")));
            this.ribbonButton4.Text = "Compra";
            this.ribbonButton4.ToolTip = "Gestión de Compras";
            // 
            // ribbonButton5
            // 
            this.ribbonButton5.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton5.LargeImage")));
            this.ribbonButton5.Name = "ribbonButton5";
            this.ribbonButton5.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton5.SmallImage")));
            this.ribbonButton5.Text = "Venta";
            this.ribbonButton5.ToolTip = "Gestión de Ventas";
            // 
            // ribbonGroup6
            // 
            this.ribbonGroup6.Items.Add(this.ribbonButton6);
            this.ribbonGroup6.Name = "ribbonGroup6";
            this.ribbonGroup6.Text = "Arqueo";
            // 
            // ribbonButton6
            // 
            this.ribbonButton6.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton6.LargeImage")));
            this.ribbonButton6.Name = "ribbonButton6";
            this.ribbonButton6.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton6.SmallImage")));
            this.ribbonButton6.Text = "Arqueo de Caja";
            this.ribbonButton6.ToolTip = "Arqueo de Caja";
            // 
            // ribbonTab5
            // 
            this.ribbonTab5.Groups.Add(this.ribbonGroup5);
            this.ribbonTab5.Name = "ribbonTab5";
            this.ribbonTab5.Text = "Reportes";
            // 
            // ribbonGroup5
            // 
            this.ribbonGroup5.Name = "ribbonGroup5";
            this.ribbonGroup5.Text = "Group";
            // 
            // ribbonTab3
            // 
            this.ribbonTab3.Groups.Add(this.ribbonGroup3);
            this.ribbonTab3.Name = "ribbonTab3";
            this.ribbonTab3.Text = "Administración";
            // 
            // ribbonGroup3
            // 
            this.ribbonGroup3.Items.Add(this.btnAdUsuarios);
            this.ribbonGroup3.Name = "ribbonGroup3";
            this.ribbonGroup3.Text = "Empleados y Usuario";
            // 
            // btnAdUsuarios
            // 
            this.btnAdUsuarios.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAdUsuarios.LargeImage")));
            this.btnAdUsuarios.Name = "btnAdUsuarios";
            this.btnAdUsuarios.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnAdUsuarios.SmallImage")));
            this.btnAdUsuarios.Text = "Usuarios";
            this.btnAdUsuarios.ToolTip = "Gestión de Usuarios";
            // 
            // ribbonTab4
            // 
            this.ribbonTab4.Groups.Add(this.ribbonGroup4);
            this.ribbonTab4.Name = "ribbonTab4";
            this.ribbonTab4.Text = "Ayuda";
            // 
            // ribbonGroup4
            // 
            this.ribbonGroup4.Items.Add(this.ribbonButton8);
            this.ribbonGroup4.Items.Add(this.ribbonButton9);
            this.ribbonGroup4.Name = "ribbonGroup4";
            this.ribbonGroup4.Text = "Ayuda";
            // 
            // ribbonButton8
            // 
            this.ribbonButton8.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton8.LargeImage")));
            this.ribbonButton8.Name = "ribbonButton8";
            this.ribbonButton8.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton8.SmallImage")));
            this.ribbonButton8.Text = "Manual de Usuario";
            this.ribbonButton8.ToolTip = "Manual de Usuario";
            // 
            // ribbonButton9
            // 
            this.ribbonButton9.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton9.LargeImage")));
            this.ribbonButton9.Name = "ribbonButton9";
            this.ribbonButton9.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton9.SmallImage")));
            this.ribbonButton9.Text = "Acerca De...";
            this.ribbonButton9.ToolTip = "Acerca De...";
            // 
            // ribbonTopToolBar1
            // 
            this.ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::CpMinerva.Properties.Resources.principal;
            this.pictureBox1.Location = new System.Drawing.Point(0, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(625, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 340);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.c1Ribbon1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::: Principal - Minerva :::";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1Ribbon c1Ribbon1;
        private RibbonApplicationMenu ribbonApplicationMenu1;
        private RibbonBottomToolBar ribbonBottomToolBar1;
        private RibbonConfigToolBar ribbonConfigToolBar1;
        private RibbonQat ribbonQat1;
        private RibbonTab tabCatalogos;
        private RibbonGroup ribbonGroup1;
        private RibbonButton btnCaProductos;
        private RibbonTab ribbonTab2;
        private RibbonGroup ribbonGroup2;
        private RibbonTab ribbonTab5;
        private RibbonGroup ribbonGroup5;
        private RibbonTab ribbonTab3;
        private RibbonGroup ribbonGroup3;
        private RibbonTab ribbonTab4;
        private RibbonGroup ribbonGroup4;
        private RibbonTopToolBar ribbonTopToolBar1;
        private RibbonButton btnCaProveedores;
        private RibbonButton btnCaClientes;
        private RibbonButton ribbonButton4;
        private RibbonButton ribbonButton5;
        private RibbonGroup ribbonGroup6;
        private RibbonButton ribbonButton6;
        private RibbonButton btnAdUsuarios;
        private RibbonButton ribbonButton8;
        private RibbonButton ribbonButton9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}