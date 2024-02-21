namespace factura
{
    partial class Menu_principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nomencladoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosTCPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeServiciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contratosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearContratosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contratosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cotizaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nomencladoresToolStripMenuItem,
            this.contratosToolStripMenuItem,
            this.gestionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(817, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nomencladoresToolStripMenuItem
            // 
            this.nomencladoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosTCPToolStripMenuItem,
            this.datosClientesToolStripMenuItem,
            this.tiposDeServiciosToolStripMenuItem});
            this.nomencladoresToolStripMenuItem.Name = "nomencladoresToolStripMenuItem";
            this.nomencladoresToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.nomencladoresToolStripMenuItem.Text = "Nomencladores";
            this.nomencladoresToolStripMenuItem.Click += new System.EventHandler(this.nomencladoresToolStripMenuItem_Click);
            // 
            // datosTCPToolStripMenuItem
            // 
            this.datosTCPToolStripMenuItem.Name = "datosTCPToolStripMenuItem";
            this.datosTCPToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.datosTCPToolStripMenuItem.Text = "Datos TCP";
            this.datosTCPToolStripMenuItem.Click += new System.EventHandler(this.datosTCPToolStripMenuItem_Click);
            // 
            // datosClientesToolStripMenuItem
            // 
            this.datosClientesToolStripMenuItem.Name = "datosClientesToolStripMenuItem";
            this.datosClientesToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.datosClientesToolStripMenuItem.Text = "Datos Empresas";
            this.datosClientesToolStripMenuItem.Click += new System.EventHandler(this.datosClientesToolStripMenuItem_Click);
            // 
            // tiposDeServiciosToolStripMenuItem
            // 
            this.tiposDeServiciosToolStripMenuItem.Name = "tiposDeServiciosToolStripMenuItem";
            this.tiposDeServiciosToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.tiposDeServiciosToolStripMenuItem.Text = "Tipos de servicios";
            this.tiposDeServiciosToolStripMenuItem.Click += new System.EventHandler(this.tiposDeServiciosToolStripMenuItem_Click);
            // 
            // contratosToolStripMenuItem
            // 
            this.contratosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearContratosToolStripMenuItem,
            this.contratosToolStripMenuItem1});
            this.contratosToolStripMenuItem.Name = "contratosToolStripMenuItem";
            this.contratosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.contratosToolStripMenuItem.Text = "Contratos";
            this.contratosToolStripMenuItem.Click += new System.EventHandler(this.contratosToolStripMenuItem_Click);
            // 
            // crearContratosToolStripMenuItem
            // 
            this.crearContratosToolStripMenuItem.Name = "crearContratosToolStripMenuItem";
            this.crearContratosToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.crearContratosToolStripMenuItem.Text = "Crear Contratos";
            this.crearContratosToolStripMenuItem.Click += new System.EventHandler(this.crearContratosToolStripMenuItem_Click);
            // 
            // contratosToolStripMenuItem1
            // 
            this.contratosToolStripMenuItem1.Name = "contratosToolStripMenuItem1";
            this.contratosToolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.contratosToolStripMenuItem1.Text = "Estados de contratos";
            this.contratosToolStripMenuItem1.Click += new System.EventHandler(this.contratosToolStripMenuItem1_Click);
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cotizaciónToolStripMenuItem,
            this.facturaToolStripMenuItem});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.gestionToolStripMenuItem.Text = "Gestion";
            // 
            // cotizaciónToolStripMenuItem
            // 
            this.cotizaciónToolStripMenuItem.Name = "cotizaciónToolStripMenuItem";
            this.cotizaciónToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.cotizaciónToolStripMenuItem.Text = "Cotización";
            this.cotizaciónToolStripMenuItem.Click += new System.EventHandler(this.cotizaciónToolStripMenuItem_Click);
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.facturaToolStripMenuItem.Text = "Factura";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Menu_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 498);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu_principal";
            this.Text = "Programa de Facturacion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nomencladoresToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datosTCPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeServiciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contratosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearContratosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contratosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cotizaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem;
    }
}

