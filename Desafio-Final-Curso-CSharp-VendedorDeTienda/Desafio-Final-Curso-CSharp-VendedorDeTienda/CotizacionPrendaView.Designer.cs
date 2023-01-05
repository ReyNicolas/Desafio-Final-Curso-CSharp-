﻿using Desafio_Final_Curso_CSharp_VendedorDeTienda.Views;

namespace Desafio_Final_Curso_CSharp_VendedorDeTienda
{
    partial class CotizacionPrendaView: Form
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblDireccionTienda = new System.Windows.Forms.Label();
            this.lblNombreTienda = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.linklblHistorial = new System.Windows.Forms.LinkLabel();
            this.lblCodigoVendedor = new System.Windows.Forms.Label();
            this.lblNombreApellidoVendedor = new System.Windows.Forms.Label();
            this.gpBoxPrecioUnitarioYCantidad = new System.Windows.Forms.GroupBox();
            this.txtBoxCantidadACotizar = new System.Windows.Forms.TextBox();
            this.txtBoxPrecioUnitario = new System.Windows.Forms.TextBox();
            this.lblCantidadACotizar = new System.Windows.Forms.Label();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.lblResultadoPrecioMostrar = new System.Windows.Forms.Label();
            this.lblResultadoPrecioTexto = new System.Windows.Forms.Label();
            this.btnCotizarPrenda = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUnidadesDisponibles = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbPrendas = new System.Windows.Forms.GroupBox();
            this.gpBoxCalidad = new System.Windows.Forms.GroupBox();
            this.rdBtnPrendaPremium = new System.Windows.Forms.RadioButton();
            this.rdBtnPrendaStandard = new System.Windows.Forms.RadioButton();
            this.tabCtrlPrendas = new System.Windows.Forms.TabControl();
            this.tabPgPantalon = new System.Windows.Forms.TabPage();
            this.rdBtnPantalonChupin = new System.Windows.Forms.RadioButton();
            this.rdBtnPantalonComun = new System.Windows.Forms.RadioButton();
            this.tabPgCamisa = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdBtnCuelloMao = new System.Windows.Forms.RadioButton();
            this.rdBtnCuelloComun = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdBtnMangaCorta = new System.Windows.Forms.RadioButton();
            this.rdBtnMangaLarga = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.gpBoxPrecioUnitarioYCantidad.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbPrendas.SuspendLayout();
            this.gpBoxCalidad.SuspendLayout();
            this.tabCtrlPrendas.SuspendLayout();
            this.tabPgPantalon.SuspendLayout();
            this.tabPgCamisa.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblDireccionTienda);
            this.splitContainer1.Panel1.Controls.Add(this.lblNombreTienda);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1143, 910);
            this.splitContainer1.SplitterDistance = 58;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblDireccionTienda
            // 
            this.lblDireccionTienda.AutoSize = true;
            this.lblDireccionTienda.Location = new System.Drawing.Point(976, 15);
            this.lblDireccionTienda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccionTienda.Name = "lblDireccionTienda";
            this.lblDireccionTienda.Size = new System.Drawing.Size(156, 25);
            this.lblDireccionTienda.TabIndex = 1;
            this.lblDireccionTienda.Text = "lblDireccionTienda";
            // 
            // lblNombreTienda
            // 
            this.lblNombreTienda.AutoSize = true;
            this.lblNombreTienda.Location = new System.Drawing.Point(17, 15);
            this.lblNombreTienda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreTienda.Name = "lblNombreTienda";
            this.lblNombreTienda.Size = new System.Drawing.Size(149, 25);
            this.lblNombreTienda.TabIndex = 0;
            this.lblNombreTienda.Text = "lblNombreTienda";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.linklblHistorial);
            this.splitContainer2.Panel1.Controls.Add(this.lblCodigoVendedor);
            this.splitContainer2.Panel1.Controls.Add(this.lblNombreApellidoVendedor);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gpBoxPrecioUnitarioYCantidad);
            this.splitContainer2.Panel2.Controls.Add(this.lblResultadoPrecioMostrar);
            this.splitContainer2.Panel2.Controls.Add(this.lblResultadoPrecioTexto);
            this.splitContainer2.Panel2.Controls.Add(this.btnCotizarPrenda);
            this.splitContainer2.Panel2.Controls.Add(this.panel1);
            this.splitContainer2.Panel2.Controls.Add(this.gbPrendas);
            this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.splitContainer2.Size = new System.Drawing.Size(1143, 845);
            this.splitContainer2.SplitterDistance = 68;
            this.splitContainer2.SplitterWidth = 7;
            this.splitContainer2.TabIndex = 0;
            // 
            // linklblHistorial
            // 
            this.linklblHistorial.AutoSize = true;
            this.linklblHistorial.Location = new System.Drawing.Point(996, 17);
            this.linklblHistorial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linklblHistorial.Name = "linklblHistorial";
            this.linklblHistorial.Size = new System.Drawing.Size(123, 25);
            this.linklblHistorial.TabIndex = 4;
            this.linklblHistorial.TabStop = true;
            this.linklblHistorial.Text = "linklblHistorial";
            // 
            // lblCodigoVendedor
            // 
            this.lblCodigoVendedor.AutoSize = true;
            this.lblCodigoVendedor.Location = new System.Drawing.Point(480, 17);
            this.lblCodigoVendedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoVendedor.Name = "lblCodigoVendedor";
            this.lblCodigoVendedor.Size = new System.Drawing.Size(167, 25);
            this.lblCodigoVendedor.TabIndex = 3;
            this.lblCodigoVendedor.Text = "lblCodigoVendedor";
            // 
            // lblNombreApellidoVendedor
            // 
            this.lblNombreApellidoVendedor.AutoSize = true;
            this.lblNombreApellidoVendedor.Location = new System.Drawing.Point(17, 17);
            this.lblNombreApellidoVendedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreApellidoVendedor.Name = "lblNombreApellidoVendedor";
            this.lblNombreApellidoVendedor.Size = new System.Drawing.Size(240, 25);
            this.lblNombreApellidoVendedor.TabIndex = 2;
            this.lblNombreApellidoVendedor.Text = "lblNombreApellidoVendedor";
            // 
            // gpBoxPrecioUnitarioYCantidad
            // 
            this.gpBoxPrecioUnitarioYCantidad.Controls.Add(this.txtBoxCantidadACotizar);
            this.gpBoxPrecioUnitarioYCantidad.Controls.Add(this.txtBoxPrecioUnitario);
            this.gpBoxPrecioUnitarioYCantidad.Controls.Add(this.lblCantidadACotizar);
            this.gpBoxPrecioUnitarioYCantidad.Controls.Add(this.lblPrecioUnitario);
            this.gpBoxPrecioUnitarioYCantidad.Location = new System.Drawing.Point(180, 556);
            this.gpBoxPrecioUnitarioYCantidad.Name = "gpBoxPrecioUnitarioYCantidad";
            this.gpBoxPrecioUnitarioYCantidad.Size = new System.Drawing.Size(776, 109);
            this.gpBoxPrecioUnitarioYCantidad.TabIndex = 5;
            this.gpBoxPrecioUnitarioYCantidad.TabStop = false;
            this.gpBoxPrecioUnitarioYCantidad.Text = "Precio Unitario Y Cantidad";
            // 
            // txtBoxCantidadACotizar
            // 
            this.txtBoxCantidadACotizar.Location = new System.Drawing.Point(595, 47);
            this.txtBoxCantidadACotizar.Name = "txtBoxCantidadACotizar";
            this.txtBoxCantidadACotizar.Size = new System.Drawing.Size(98, 31);
            this.txtBoxCantidadACotizar.TabIndex = 3;
            // 
            // txtBoxPrecioUnitario
            // 
            this.txtBoxPrecioUnitario.Location = new System.Drawing.Point(209, 50);
            this.txtBoxPrecioUnitario.Name = "txtBoxPrecioUnitario";
            this.txtBoxPrecioUnitario.Size = new System.Drawing.Size(157, 31);
            this.txtBoxPrecioUnitario.TabIndex = 2;
            this.txtBoxPrecioUnitario.TextChanged += new System.EventHandler(this.txtBoxPrecioUnitario_TextChanged);
            // 
            // lblCantidadACotizar
            // 
            this.lblCantidadACotizar.AutoSize = true;
            this.lblCantidadACotizar.Location = new System.Drawing.Point(417, 53);
            this.lblCantidadACotizar.Name = "lblCantidadACotizar";
            this.lblCantidadACotizar.Size = new System.Drawing.Size(160, 25);
            this.lblCantidadACotizar.TabIndex = 1;
            this.lblCantidadACotizar.Text = "Cantidad A Cotizar";
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Location = new System.Drawing.Point(51, 53);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(127, 25);
            this.lblPrecioUnitario.TabIndex = 0;
            this.lblPrecioUnitario.Text = "Precio Unitario";
            // 
            // lblResultadoPrecioMostrar
            // 
            this.lblResultadoPrecioMostrar.AutoSize = true;
            this.lblResultadoPrecioMostrar.Location = new System.Drawing.Point(624, 709);
            this.lblResultadoPrecioMostrar.Name = "lblResultadoPrecioMostrar";
            this.lblResultadoPrecioMostrar.Size = new System.Drawing.Size(0, 25);
            this.lblResultadoPrecioMostrar.TabIndex = 4;
            this.lblResultadoPrecioMostrar.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblResultadoPrecioTexto
            // 
            this.lblResultadoPrecioTexto.AutoSize = true;
            this.lblResultadoPrecioTexto.Location = new System.Drawing.Point(510, 709);
            this.lblResultadoPrecioTexto.Name = "lblResultadoPrecioTexto";
            this.lblResultadoPrecioTexto.Size = new System.Drawing.Size(94, 25);
            this.lblResultadoPrecioTexto.TabIndex = 3;
            this.lblResultadoPrecioTexto.Text = "Resultado:";
            // 
            // btnCotizarPrenda
            // 
            this.btnCotizarPrenda.Location = new System.Drawing.Point(180, 684);
            this.btnCotizarPrenda.Name = "btnCotizarPrenda";
            this.btnCotizarPrenda.Size = new System.Drawing.Size(276, 74);
            this.btnCotizarPrenda.TabIndex = 2;
            this.btnCotizarPrenda.Text = "Cotizar";
            this.btnCotizarPrenda.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblUnidadesDisponibles);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(167, 447);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 77);
            this.panel1.TabIndex = 1;
            // 
            // lblUnidadesDisponibles
            // 
            this.lblUnidadesDisponibles.AutoSize = true;
            this.lblUnidadesDisponibles.Location = new System.Drawing.Point(297, 33);
            this.lblUnidadesDisponibles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnidadesDisponibles.Name = "lblUnidadesDisponibles";
            this.lblUnidadesDisponibles.Size = new System.Drawing.Size(19, 25);
            this.lblUnidadesDisponibles.TabIndex = 1;
            this.lblUnidadesDisponibles.Text = "_";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Unidades de stock disponible:";
            // 
            // gbPrendas
            // 
            this.gbPrendas.Controls.Add(this.gpBoxCalidad);
            this.gbPrendas.Controls.Add(this.tabCtrlPrendas);
            this.gbPrendas.Location = new System.Drawing.Point(167, 28);
            this.gbPrendas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbPrendas.Name = "gbPrendas";
            this.gbPrendas.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbPrendas.Size = new System.Drawing.Size(790, 408);
            this.gbPrendas.TabIndex = 0;
            this.gbPrendas.TabStop = false;
            this.gbPrendas.Text = "Prendas";
            this.gbPrendas.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gpBoxCalidad
            // 
            this.gpBoxCalidad.Controls.Add(this.rdBtnPrendaPremium);
            this.gpBoxCalidad.Controls.Add(this.rdBtnPrendaStandard);
            this.gpBoxCalidad.Location = new System.Drawing.Point(46, 53);
            this.gpBoxCalidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpBoxCalidad.Name = "gpBoxCalidad";
            this.gpBoxCalidad.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpBoxCalidad.Size = new System.Drawing.Size(649, 128);
            this.gpBoxCalidad.TabIndex = 1;
            this.gpBoxCalidad.TabStop = false;
            this.gpBoxCalidad.Text = "Calidad";
            // 
            // rdBtnPrendaPremium
            // 
            this.rdBtnPrendaPremium.AutoSize = true;
            this.rdBtnPrendaPremium.Location = new System.Drawing.Point(326, 65);
            this.rdBtnPrendaPremium.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdBtnPrendaPremium.Name = "rdBtnPrendaPremium";
            this.rdBtnPrendaPremium.Size = new System.Drawing.Size(108, 29);
            this.rdBtnPrendaPremium.TabIndex = 1;
            this.rdBtnPrendaPremium.Text = "Premium";
            this.rdBtnPrendaPremium.UseVisualStyleBackColor = true;
            // 
            // rdBtnPrendaStandard
            // 
            this.rdBtnPrendaStandard.AutoSize = true;
            this.rdBtnPrendaStandard.Checked = true;
            this.rdBtnPrendaStandard.Location = new System.Drawing.Point(91, 60);
            this.rdBtnPrendaStandard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdBtnPrendaStandard.Name = "rdBtnPrendaStandard";
            this.rdBtnPrendaStandard.Size = new System.Drawing.Size(108, 29);
            this.rdBtnPrendaStandard.TabIndex = 0;
            this.rdBtnPrendaStandard.TabStop = true;
            this.rdBtnPrendaStandard.Text = "Standard";
            this.rdBtnPrendaStandard.UseVisualStyleBackColor = true;
            this.rdBtnPrendaStandard.CheckedChanged += new System.EventHandler(this.rdBtnPrendaStandard_CheckedChanged);
            // 
            // tabCtrlPrendas
            // 
            this.tabCtrlPrendas.Controls.Add(this.tabPgPantalon);
            this.tabCtrlPrendas.Controls.Add(this.tabPgCamisa);
            this.tabCtrlPrendas.Location = new System.Drawing.Point(9, 192);
            this.tabCtrlPrendas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabCtrlPrendas.Name = "tabCtrlPrendas";
            this.tabCtrlPrendas.SelectedIndex = 0;
            this.tabCtrlPrendas.Size = new System.Drawing.Size(773, 192);
            this.tabCtrlPrendas.TabIndex = 0;
            // 
            // tabPgPantalon
            // 
            this.tabPgPantalon.BackColor = System.Drawing.Color.Silver;
            this.tabPgPantalon.Controls.Add(this.rdBtnPantalonChupin);
            this.tabPgPantalon.Controls.Add(this.rdBtnPantalonComun);
            this.tabPgPantalon.Location = new System.Drawing.Point(4, 34);
            this.tabPgPantalon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPgPantalon.Name = "tabPgPantalon";
            this.tabPgPantalon.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPgPantalon.Size = new System.Drawing.Size(765, 154);
            this.tabPgPantalon.TabIndex = 0;
            this.tabPgPantalon.Text = "Pantalon";
            // 
            // rdBtnPantalonChupin
            // 
            this.rdBtnPantalonChupin.AutoSize = true;
            this.rdBtnPantalonChupin.Location = new System.Drawing.Point(404, 55);
            this.rdBtnPantalonChupin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdBtnPantalonChupin.Name = "rdBtnPantalonChupin";
            this.rdBtnPantalonChupin.Size = new System.Drawing.Size(93, 29);
            this.rdBtnPantalonChupin.TabIndex = 1;
            this.rdBtnPantalonChupin.Text = "Chupin";
            this.rdBtnPantalonChupin.UseVisualStyleBackColor = true;
            this.rdBtnPantalonChupin.CheckedChanged += new System.EventHandler(this.rdBtnPantalonChupin_CheckedChanged);
            // 
            // rdBtnPantalonComun
            // 
            this.rdBtnPantalonComun.AutoSize = true;
            this.rdBtnPantalonComun.Checked = true;
            this.rdBtnPantalonComun.Location = new System.Drawing.Point(104, 48);
            this.rdBtnPantalonComun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdBtnPantalonComun.Name = "rdBtnPantalonComun";
            this.rdBtnPantalonComun.Size = new System.Drawing.Size(95, 29);
            this.rdBtnPantalonComun.TabIndex = 0;
            this.rdBtnPantalonComun.TabStop = true;
            this.rdBtnPantalonComun.Text = "Comun";
            this.rdBtnPantalonComun.UseVisualStyleBackColor = true;
            // 
            // tabPgCamisa
            // 
            this.tabPgCamisa.BackColor = System.Drawing.Color.Silver;
            this.tabPgCamisa.Controls.Add(this.panel3);
            this.tabPgCamisa.Controls.Add(this.panel2);
            this.tabPgCamisa.Location = new System.Drawing.Point(4, 34);
            this.tabPgCamisa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPgCamisa.Name = "tabPgCamisa";
            this.tabPgCamisa.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPgCamisa.Size = new System.Drawing.Size(765, 154);
            this.tabPgCamisa.TabIndex = 1;
            this.tabPgCamisa.Text = "Camisa";
            this.tabPgCamisa.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdBtnCuelloMao);
            this.panel3.Controls.Add(this.rdBtnCuelloComun);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(119, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(407, 64);
            this.panel3.TabIndex = 9;
            // 
            // rdBtnCuelloMao
            // 
            this.rdBtnCuelloMao.AutoSize = true;
            this.rdBtnCuelloMao.Location = new System.Drawing.Point(218, 14);
            this.rdBtnCuelloMao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdBtnCuelloMao.Name = "rdBtnCuelloMao";
            this.rdBtnCuelloMao.Size = new System.Drawing.Size(73, 29);
            this.rdBtnCuelloMao.TabIndex = 7;
            this.rdBtnCuelloMao.Text = "Mao";
            this.rdBtnCuelloMao.UseVisualStyleBackColor = true;
            this.rdBtnCuelloMao.CheckedChanged += new System.EventHandler(this.rdBtnCuelloMao_CheckedChanged);
            // 
            // rdBtnCuelloComun
            // 
            this.rdBtnCuelloComun.AutoSize = true;
            this.rdBtnCuelloComun.Checked = true;
            this.rdBtnCuelloComun.Location = new System.Drawing.Point(89, 14);
            this.rdBtnCuelloComun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdBtnCuelloComun.Name = "rdBtnCuelloComun";
            this.rdBtnCuelloComun.Size = new System.Drawing.Size(95, 29);
            this.rdBtnCuelloComun.TabIndex = 4;
            this.rdBtnCuelloComun.TabStop = true;
            this.rdBtnCuelloComun.Text = "Comun";
            this.rdBtnCuelloComun.UseVisualStyleBackColor = true;
            this.rdBtnCuelloComun.CheckedChanged += new System.EventHandler(this.rdBtnCuelloComun_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cuello";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdBtnMangaCorta);
            this.panel2.Controls.Add(this.rdBtnMangaLarga);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(119, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 52);
            this.panel2.TabIndex = 8;
            // 
            // rdBtnMangaCorta
            // 
            this.rdBtnMangaCorta.AutoSize = true;
            this.rdBtnMangaCorta.Location = new System.Drawing.Point(211, 11);
            this.rdBtnMangaCorta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdBtnMangaCorta.Name = "rdBtnMangaCorta";
            this.rdBtnMangaCorta.Size = new System.Drawing.Size(80, 29);
            this.rdBtnMangaCorta.TabIndex = 6;
            this.rdBtnMangaCorta.Text = "Corta";
            this.rdBtnMangaCorta.UseVisualStyleBackColor = true;
            // 
            // rdBtnMangaLarga
            // 
            this.rdBtnMangaLarga.AutoSize = true;
            this.rdBtnMangaLarga.Checked = true;
            this.rdBtnMangaLarga.Location = new System.Drawing.Point(91, 11);
            this.rdBtnMangaLarga.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdBtnMangaLarga.Name = "rdBtnMangaLarga";
            this.rdBtnMangaLarga.Size = new System.Drawing.Size(80, 29);
            this.rdBtnMangaLarga.TabIndex = 5;
            this.rdBtnMangaLarga.TabStop = true;
            this.rdBtnMangaLarga.Text = "Larga";
            this.rdBtnMangaLarga.UseVisualStyleBackColor = true;
            this.rdBtnMangaLarga.CheckedChanged += new System.EventHandler(this.rdBtnMangaLarga_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manga";
            // 
            // CotizacionPrendaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 910);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CotizacionPrendaView";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.gpBoxPrecioUnitarioYCantidad.ResumeLayout(false);
            this.gpBoxPrecioUnitarioYCantidad.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbPrendas.ResumeLayout(false);
            this.gpBoxCalidad.ResumeLayout(false);
            this.gpBoxCalidad.PerformLayout();
            this.tabCtrlPrendas.ResumeLayout(false);
            this.tabPgPantalon.ResumeLayout(false);
            this.tabPgPantalon.PerformLayout();
            this.tabPgCamisa.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Label lblDireccionTienda;
        private Label lblNombreTienda;
        private SplitContainer splitContainer2;
        private LinkLabel linklblHistorial;
        private Label lblCodigoVendedor;
        private Label lblNombreApellidoVendedor;
        private GroupBox gbPrendas;
        private TabControl tabCtrlPrendas;
        private TabPage tabPgPantalon;
        private TabPage tabPgCamisa;
        private Panel panel1;
        private Label lblUnidadesDisponibles;
        private Label label3;
        private RadioButton rdBtnPantalonChupin;
        private RadioButton rdBtnPantalonComun;
        private RadioButton rdBtnCuelloMao;
        private RadioButton rdBtnMangaCorta;
        private RadioButton rdBtnMangaLarga;
        private RadioButton rdBtnCuelloComun;
        private Label label2;
        private Label label1;
        private GroupBox gpBoxCalidad;
        private RadioButton rdBtnPrendaPremium;
        private RadioButton rdBtnPrendaStandard;
        private Button btnCotizarPrenda;
        private Label lblResultadoPrecioMostrar;
        private Label lblResultadoPrecioTexto;
        private GroupBox gpBoxPrecioUnitarioYCantidad;
        private TextBox txtBoxCantidadACotizar;
        private TextBox txtBoxPrecioUnitario;
        private Label lblCantidadACotizar;
        private Label lblPrecioUnitario;
        private Panel panel3;
        private Panel panel2;
    }
}