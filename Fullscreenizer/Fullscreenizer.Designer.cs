﻿namespace Fullscreenizer
{
	partial class Fullscreenizer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fullscreenizer));
			this.lbl_apps = new System.Windows.Forms.Label();
			this.lv_apps = new System.Windows.Forms.ListView();
			this.ch_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btn_fullscreenizeApp = new System.Windows.Forms.Button();
			this.gb_apps = new System.Windows.Forms.GroupBox();
			this.num_monitorscale = new System.Windows.Forms.NumericUpDown();
			this.lbl_monitorscale = new System.Windows.Forms.Label();
			this.num_wndmove_y = new System.Windows.Forms.NumericUpDown();
			this.num_wndmove_x = new System.Windows.Forms.NumericUpDown();
			this.lbl_wndmove_y = new System.Windows.Forms.Label();
			this.lbl_wndmove_x = new System.Windows.Forms.Label();
			this.lbl_wndsize_h = new System.Windows.Forms.Label();
			this.lbl_wndsize_w = new System.Windows.Forms.Label();
			this.num_wndsize_h = new System.Windows.Forms.NumericUpDown();
			this.num_wndsize_w = new System.Windows.Forms.NumericUpDown();
			this.chk_moveWindow = new System.Windows.Forms.CheckBox();
			this.chk_scaleToFit = new System.Windows.Forms.CheckBox();
			this.btn_removeApp = new System.Windows.Forms.Button();
			this.btn_showAllApps = new System.Windows.Forms.Button();
			this.chk_enableHotkey = new System.Windows.Forms.CheckBox();
			this.gb_hotkey = new System.Windows.Forms.GroupBox();
			this.cb_hotkeyKey = new System.Windows.Forms.ComboBox();
			this.gb_hotkeyModifier = new System.Windows.Forms.GroupBox();
			this.chk_hotkeyModAlt = new System.Windows.Forms.CheckBox();
			this.chk_hotkeyModShift = new System.Windows.Forms.CheckBox();
			this.chk_hotkeyModCtrl = new System.Windows.Forms.CheckBox();
			this.lbl_website = new System.Windows.Forms.Label();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItemShow = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemClose = new System.Windows.Forms.ToolStripMenuItem();
			this.chk_minimizeToTray = new System.Windows.Forms.CheckBox();
			this.gb_apps.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_monitorscale)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_wndmove_y)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_wndmove_x)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_wndsize_h)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_wndsize_w)).BeginInit();
			this.gb_hotkey.SuspendLayout();
			this.gb_hotkeyModifier.SuspendLayout();
			this.contextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbl_apps
			// 
			this.lbl_apps.AutoSize = true;
			this.lbl_apps.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_apps.Location = new System.Drawing.Point(16, 11);
			this.lbl_apps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_apps.Name = "lbl_apps";
			this.lbl_apps.Size = new System.Drawing.Size(68, 29);
			this.lbl_apps.TabIndex = 1;
			this.lbl_apps.Text = "Apps";
			// 
			// lv_apps
			// 
			this.lv_apps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_title});
			this.lv_apps.FullRowSelect = true;
			this.lv_apps.GridLines = true;
			this.lv_apps.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lv_apps.HideSelection = false;
			this.lv_apps.Location = new System.Drawing.Point(8, 17);
			this.lv_apps.Margin = new System.Windows.Forms.Padding(4);
			this.lv_apps.MultiSelect = false;
			this.lv_apps.Name = "lv_apps";
			this.lv_apps.Size = new System.Drawing.Size(436, 181);
			this.lv_apps.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lv_apps.TabIndex = 0;
			this.lv_apps.TabStop = false;
			this.lv_apps.UseCompatibleStateImageBehavior = false;
			this.lv_apps.View = System.Windows.Forms.View.Details;
			// 
			// ch_title
			// 
			this.ch_title.Text = "Title";
			// 
			// btn_fullscreenizeApp
			// 
			this.btn_fullscreenizeApp.Location = new System.Drawing.Point(8, 207);
			this.btn_fullscreenizeApp.Margin = new System.Windows.Forms.Padding(4);
			this.btn_fullscreenizeApp.Name = "btn_fullscreenizeApp";
			this.btn_fullscreenizeApp.Size = new System.Drawing.Size(101, 28);
			this.btn_fullscreenizeApp.TabIndex = 3;
			this.btn_fullscreenizeApp.TabStop = false;
			this.btn_fullscreenizeApp.Text = "Fullscreenize";
			this.btn_fullscreenizeApp.UseVisualStyleBackColor = true;
			this.btn_fullscreenizeApp.Click += new System.EventHandler(this.btn_fullscreenizeApp_Click);
			// 
			// gb_apps
			// 
			this.gb_apps.Controls.Add(this.num_monitorscale);
			this.gb_apps.Controls.Add(this.lbl_monitorscale);
			this.gb_apps.Controls.Add(this.num_wndmove_y);
			this.gb_apps.Controls.Add(this.num_wndmove_x);
			this.gb_apps.Controls.Add(this.lbl_wndmove_y);
			this.gb_apps.Controls.Add(this.lbl_wndmove_x);
			this.gb_apps.Controls.Add(this.lbl_wndsize_h);
			this.gb_apps.Controls.Add(this.lbl_wndsize_w);
			this.gb_apps.Controls.Add(this.num_wndsize_h);
			this.gb_apps.Controls.Add(this.num_wndsize_w);
			this.gb_apps.Controls.Add(this.chk_moveWindow);
			this.gb_apps.Controls.Add(this.chk_scaleToFit);
			this.gb_apps.Controls.Add(this.btn_removeApp);
			this.gb_apps.Controls.Add(this.lv_apps);
			this.gb_apps.Controls.Add(this.btn_showAllApps);
			this.gb_apps.Controls.Add(this.btn_fullscreenizeApp);
			this.gb_apps.Location = new System.Drawing.Point(21, 44);
			this.gb_apps.Margin = new System.Windows.Forms.Padding(4);
			this.gb_apps.Name = "gb_apps";
			this.gb_apps.Padding = new System.Windows.Forms.Padding(4);
			this.gb_apps.Size = new System.Drawing.Size(456, 305);
			this.gb_apps.TabIndex = 0;
			this.gb_apps.TabStop = false;
			// 
			// num_monitorscale
			// 
			this.num_monitorscale.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
			this.num_monitorscale.Location = new System.Drawing.Point(363, 241);
			this.num_monitorscale.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.num_monitorscale.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.num_monitorscale.Name = "num_monitorscale";
			this.num_monitorscale.Size = new System.Drawing.Size(81, 22);
			this.num_monitorscale.TabIndex = 17;
			this.num_monitorscale.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.num_monitorscale.ValueChanged += new System.EventHandler(this.num_monitorscale_ValueChanged);
			// 
			// lbl_monitorscale
			// 
			this.lbl_monitorscale.AutoSize = true;
			this.lbl_monitorscale.Location = new System.Drawing.Point(338, 244);
			this.lbl_monitorscale.Name = "lbl_monitorscale";
			this.lbl_monitorscale.Size = new System.Drawing.Size(19, 16);
			this.lbl_monitorscale.TabIndex = 16;
			this.lbl_monitorscale.Text = "S:";
			// 
			// num_wndmove_y
			// 
			this.num_wndmove_y.Location = new System.Drawing.Point(236, 270);
			this.num_wndmove_y.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.num_wndmove_y.Name = "num_wndmove_y";
			this.num_wndmove_y.Size = new System.Drawing.Size(96, 22);
			this.num_wndmove_y.TabIndex = 15;
			this.num_wndmove_y.ValueChanged += new System.EventHandler(this.num_wndmove_y_ValueChanged);
			// 
			// num_wndmove_x
			// 
			this.num_wndmove_x.Location = new System.Drawing.Point(108, 270);
			this.num_wndmove_x.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.num_wndmove_x.Name = "num_wndmove_x";
			this.num_wndmove_x.Size = new System.Drawing.Size(96, 22);
			this.num_wndmove_x.TabIndex = 14;
			this.num_wndmove_x.ValueChanged += new System.EventHandler(this.num_wndmove_x_ValueChanged);
			// 
			// lbl_wndmove_y
			// 
			this.lbl_wndmove_y.AutoSize = true;
			this.lbl_wndmove_y.Location = new System.Drawing.Point(210, 272);
			this.lbl_wndmove_y.Name = "lbl_wndmove_y";
			this.lbl_wndmove_y.Size = new System.Drawing.Size(19, 16);
			this.lbl_wndmove_y.TabIndex = 13;
			this.lbl_wndmove_y.Text = "Y:";
			// 
			// lbl_wndmove_x
			// 
			this.lbl_wndmove_x.AutoSize = true;
			this.lbl_wndmove_x.Location = new System.Drawing.Point(79, 272);
			this.lbl_wndmove_x.Name = "lbl_wndmove_x";
			this.lbl_wndmove_x.Size = new System.Drawing.Size(18, 16);
			this.lbl_wndmove_x.TabIndex = 12;
			this.lbl_wndmove_x.Text = "X:";
			// 
			// lbl_wndsize_h
			// 
			this.lbl_wndsize_h.AutoSize = true;
			this.lbl_wndsize_h.Location = new System.Drawing.Point(210, 244);
			this.lbl_wndsize_h.Name = "lbl_wndsize_h";
			this.lbl_wndsize_h.Size = new System.Drawing.Size(20, 16);
			this.lbl_wndsize_h.TabIndex = 11;
			this.lbl_wndsize_h.Text = "H:";
			// 
			// lbl_wndsize_w
			// 
			this.lbl_wndsize_w.AutoSize = true;
			this.lbl_wndsize_w.Location = new System.Drawing.Point(79, 244);
			this.lbl_wndsize_w.Name = "lbl_wndsize_w";
			this.lbl_wndsize_w.Size = new System.Drawing.Size(23, 16);
			this.lbl_wndsize_w.TabIndex = 10;
			this.lbl_wndsize_w.Text = "W:";
			// 
			// num_wndsize_h
			// 
			this.num_wndsize_h.Location = new System.Drawing.Point(236, 241);
			this.num_wndsize_h.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.num_wndsize_h.Name = "num_wndsize_h";
			this.num_wndsize_h.Size = new System.Drawing.Size(96, 22);
			this.num_wndsize_h.TabIndex = 9;
			this.num_wndsize_h.Value = new decimal(new int[] {
            1080,
            0,
            0,
            0});
			this.num_wndsize_h.ValueChanged += new System.EventHandler(this.num_wndsize_h_ValueChanged);
			// 
			// num_wndsize_w
			// 
			this.num_wndsize_w.Location = new System.Drawing.Point(108, 242);
			this.num_wndsize_w.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.num_wndsize_w.Name = "num_wndsize_w";
			this.num_wndsize_w.Size = new System.Drawing.Size(96, 22);
			this.num_wndsize_w.TabIndex = 7;
			this.num_wndsize_w.Value = new decimal(new int[] {
            1920,
            0,
            0,
            0});
			this.num_wndsize_w.ValueChanged += new System.EventHandler(this.num_wndsize_w_ValueChanged);
			// 
			// chk_moveWindow
			// 
			this.chk_moveWindow.AutoSize = true;
			this.chk_moveWindow.Checked = true;
			this.chk_moveWindow.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk_moveWindow.Location = new System.Drawing.Point(8, 271);
			this.chk_moveWindow.Margin = new System.Windows.Forms.Padding(4);
			this.chk_moveWindow.Name = "chk_moveWindow";
			this.chk_moveWindow.Size = new System.Drawing.Size(63, 20);
			this.chk_moveWindow.TabIndex = 6;
			this.chk_moveWindow.Text = "Move";
			this.chk_moveWindow.UseVisualStyleBackColor = true;
			this.chk_moveWindow.CheckedChanged += new System.EventHandler(this.chk_moveWindow_CheckedChanged);
			// 
			// chk_scaleToFit
			// 
			this.chk_scaleToFit.AutoSize = true;
			this.chk_scaleToFit.Checked = true;
			this.chk_scaleToFit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk_scaleToFit.Location = new System.Drawing.Point(8, 243);
			this.chk_scaleToFit.Margin = new System.Windows.Forms.Padding(4);
			this.chk_scaleToFit.Name = "chk_scaleToFit";
			this.chk_scaleToFit.Size = new System.Drawing.Size(64, 20);
			this.chk_scaleToFit.TabIndex = 5;
			this.chk_scaleToFit.Text = "Scale";
			this.chk_scaleToFit.UseVisualStyleBackColor = true;
			this.chk_scaleToFit.CheckedChanged += new System.EventHandler(this.chk_scaleToFit_CheckedChanged);
			// 
			// btn_removeApp
			// 
			this.btn_removeApp.Location = new System.Drawing.Point(276, 207);
			this.btn_removeApp.Margin = new System.Windows.Forms.Padding(4);
			this.btn_removeApp.Name = "btn_removeApp";
			this.btn_removeApp.Size = new System.Drawing.Size(76, 28);
			this.btn_removeApp.TabIndex = 4;
			this.btn_removeApp.Text = "Remove";
			this.btn_removeApp.UseVisualStyleBackColor = true;
			this.btn_removeApp.Click += new System.EventHandler(this.btn_removeApp_Click);
			// 
			// btn_showAllApps
			// 
			this.btn_showAllApps.Location = new System.Drawing.Point(360, 207);
			this.btn_showAllApps.Margin = new System.Windows.Forms.Padding(4);
			this.btn_showAllApps.Name = "btn_showAllApps";
			this.btn_showAllApps.Size = new System.Drawing.Size(85, 28);
			this.btn_showAllApps.TabIndex = 3;
			this.btn_showAllApps.TabStop = false;
			this.btn_showAllApps.Text = "Show All";
			this.btn_showAllApps.UseVisualStyleBackColor = true;
			this.btn_showAllApps.Click += new System.EventHandler(this.btn_showAllApps_Click);
			// 
			// chk_enableHotkey
			// 
			this.chk_enableHotkey.AutoCheck = false;
			this.chk_enableHotkey.AutoSize = true;
			this.chk_enableHotkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chk_enableHotkey.Location = new System.Drawing.Point(21, 357);
			this.chk_enableHotkey.Margin = new System.Windows.Forms.Padding(4);
			this.chk_enableHotkey.Name = "chk_enableHotkey";
			this.chk_enableHotkey.Size = new System.Drawing.Size(109, 33);
			this.chk_enableHotkey.TabIndex = 9;
			this.chk_enableHotkey.TabStop = false;
			this.chk_enableHotkey.Text = "Hotkey";
			this.chk_enableHotkey.UseVisualStyleBackColor = true;
			this.chk_enableHotkey.Click += new System.EventHandler(this.chk_enableHotkey_Click);
			// 
			// gb_hotkey
			// 
			this.gb_hotkey.Controls.Add(this.cb_hotkeyKey);
			this.gb_hotkey.Controls.Add(this.gb_hotkeyModifier);
			this.gb_hotkey.Location = new System.Drawing.Point(21, 387);
			this.gb_hotkey.Margin = new System.Windows.Forms.Padding(4);
			this.gb_hotkey.Name = "gb_hotkey";
			this.gb_hotkey.Padding = new System.Windows.Forms.Padding(4);
			this.gb_hotkey.Size = new System.Drawing.Size(456, 58);
			this.gb_hotkey.TabIndex = 10;
			this.gb_hotkey.TabStop = false;
			// 
			// cb_hotkeyKey
			// 
			this.cb_hotkeyKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_hotkeyKey.FormattingEnabled = true;
			this.cb_hotkeyKey.Location = new System.Drawing.Point(201, 21);
			this.cb_hotkeyKey.Margin = new System.Windows.Forms.Padding(4);
			this.cb_hotkeyKey.Name = "cb_hotkeyKey";
			this.cb_hotkeyKey.Size = new System.Drawing.Size(243, 24);
			this.cb_hotkeyKey.TabIndex = 11;
			this.cb_hotkeyKey.TabStop = false;
			this.cb_hotkeyKey.SelectionChangeCommitted += new System.EventHandler(this.cb_hotkeyKey_SelectionChangeCommitted);
			// 
			// gb_hotkeyModifier
			// 
			this.gb_hotkeyModifier.Controls.Add(this.chk_hotkeyModAlt);
			this.gb_hotkeyModifier.Controls.Add(this.chk_hotkeyModShift);
			this.gb_hotkeyModifier.Controls.Add(this.chk_hotkeyModCtrl);
			this.gb_hotkeyModifier.Location = new System.Drawing.Point(8, 11);
			this.gb_hotkeyModifier.Margin = new System.Windows.Forms.Padding(4);
			this.gb_hotkeyModifier.Name = "gb_hotkeyModifier";
			this.gb_hotkeyModifier.Padding = new System.Windows.Forms.Padding(4);
			this.gb_hotkeyModifier.Size = new System.Drawing.Size(185, 36);
			this.gb_hotkeyModifier.TabIndex = 11;
			this.gb_hotkeyModifier.TabStop = false;
			// 
			// chk_hotkeyModAlt
			// 
			this.chk_hotkeyModAlt.AutoCheck = false;
			this.chk_hotkeyModAlt.AutoSize = true;
			this.chk_hotkeyModAlt.Location = new System.Drawing.Point(133, 12);
			this.chk_hotkeyModAlt.Margin = new System.Windows.Forms.Padding(4);
			this.chk_hotkeyModAlt.Name = "chk_hotkeyModAlt";
			this.chk_hotkeyModAlt.Size = new System.Drawing.Size(43, 20);
			this.chk_hotkeyModAlt.TabIndex = 0;
			this.chk_hotkeyModAlt.TabStop = false;
			this.chk_hotkeyModAlt.Text = "alt";
			this.chk_hotkeyModAlt.UseVisualStyleBackColor = true;
			this.chk_hotkeyModAlt.Click += new System.EventHandler(this.chk_hotkeyModAlt_Click);
			// 
			// chk_hotkeyModShift
			// 
			this.chk_hotkeyModShift.AutoCheck = false;
			this.chk_hotkeyModShift.AutoSize = true;
			this.chk_hotkeyModShift.Location = new System.Drawing.Point(65, 12);
			this.chk_hotkeyModShift.Margin = new System.Windows.Forms.Padding(4);
			this.chk_hotkeyModShift.Name = "chk_hotkeyModShift";
			this.chk_hotkeyModShift.Size = new System.Drawing.Size(52, 20);
			this.chk_hotkeyModShift.TabIndex = 0;
			this.chk_hotkeyModShift.TabStop = false;
			this.chk_hotkeyModShift.Text = "shift";
			this.chk_hotkeyModShift.UseVisualStyleBackColor = true;
			this.chk_hotkeyModShift.Click += new System.EventHandler(this.chk_hotkeyModShift_Click);
			// 
			// chk_hotkeyModCtrl
			// 
			this.chk_hotkeyModCtrl.AutoCheck = false;
			this.chk_hotkeyModCtrl.AutoSize = true;
			this.chk_hotkeyModCtrl.Checked = true;
			this.chk_hotkeyModCtrl.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk_hotkeyModCtrl.Location = new System.Drawing.Point(7, 12);
			this.chk_hotkeyModCtrl.Margin = new System.Windows.Forms.Padding(4);
			this.chk_hotkeyModCtrl.Name = "chk_hotkeyModCtrl";
			this.chk_hotkeyModCtrl.Size = new System.Drawing.Size(46, 20);
			this.chk_hotkeyModCtrl.TabIndex = 0;
			this.chk_hotkeyModCtrl.TabStop = false;
			this.chk_hotkeyModCtrl.Text = "ctrl";
			this.chk_hotkeyModCtrl.UseVisualStyleBackColor = true;
			this.chk_hotkeyModCtrl.Click += new System.EventHandler(this.chk_hotkeyModCtrl_Click);
			// 
			// lbl_website
			// 
			this.lbl_website.AutoSize = true;
			this.lbl_website.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbl_website.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_website.Location = new System.Drawing.Point(364, 4);
			this.lbl_website.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_website.Name = "lbl_website";
			this.lbl_website.Size = new System.Drawing.Size(124, 17);
			this.lbl_website.TabIndex = 12;
			this.lbl_website.Text = "GitHub Repository";
			this.lbl_website.Click += new System.EventHandler(this.lbl_website_Click);
			// 
			// notifyIcon
			// 
			this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "Fullscreenizer";
			this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemShow,
            this.toolStripSeparator,
            this.toolStripMenuItemClose});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(115, 58);
			// 
			// toolStripMenuItemShow
			// 
			this.toolStripMenuItemShow.Name = "toolStripMenuItemShow";
			this.toolStripMenuItemShow.Size = new System.Drawing.Size(114, 24);
			this.toolStripMenuItemShow.Text = "Show";
			this.toolStripMenuItemShow.Click += new System.EventHandler(this.toolStripMenuItemShow_Click);
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(111, 6);
			// 
			// toolStripMenuItemClose
			// 
			this.toolStripMenuItemClose.Name = "toolStripMenuItemClose";
			this.toolStripMenuItemClose.Size = new System.Drawing.Size(114, 24);
			this.toolStripMenuItemClose.Text = "Close";
			this.toolStripMenuItemClose.Click += new System.EventHandler(this.toolStripMenuItemClose_Click);
			// 
			// chk_minimizeToTray
			// 
			this.chk_minimizeToTray.AutoSize = true;
			this.chk_minimizeToTray.Checked = true;
			this.chk_minimizeToTray.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk_minimizeToTray.Location = new System.Drawing.Point(349, 28);
			this.chk_minimizeToTray.Margin = new System.Windows.Forms.Padding(4);
			this.chk_minimizeToTray.Name = "chk_minimizeToTray";
			this.chk_minimizeToTray.Size = new System.Drawing.Size(120, 20);
			this.chk_minimizeToTray.TabIndex = 7;
			this.chk_minimizeToTray.Text = "Minimize to tray";
			this.chk_minimizeToTray.UseVisualStyleBackColor = true;
			this.chk_minimizeToTray.CheckedChanged += new System.EventHandler(this.chk_minimizeToTray_CheckedChanged);
			// 
			// Fullscreenizer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(492, 458);
			this.Controls.Add(this.chk_minimizeToTray);
			this.Controls.Add(this.lbl_website);
			this.Controls.Add(this.gb_hotkey);
			this.Controls.Add(this.chk_enableHotkey);
			this.Controls.Add(this.gb_apps);
			this.Controls.Add(this.lbl_apps);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "Fullscreenizer";
			this.Text = "Fullscreenizer";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fullscreenizer_FormClosing);
			this.Resize += new System.EventHandler(this.Fullscreenizer_Resize);
			this.gb_apps.ResumeLayout(false);
			this.gb_apps.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_monitorscale)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_wndmove_y)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_wndmove_x)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_wndsize_h)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_wndsize_w)).EndInit();
			this.gb_hotkey.ResumeLayout(false);
			this.gb_hotkeyModifier.ResumeLayout(false);
			this.gb_hotkeyModifier.PerformLayout();
			this.contextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_apps;
		private System.Windows.Forms.ListView lv_apps;
		private System.Windows.Forms.Button btn_fullscreenizeApp;
		private System.Windows.Forms.GroupBox gb_apps;
		private System.Windows.Forms.CheckBox chk_enableHotkey;
		private System.Windows.Forms.GroupBox gb_hotkey;
		private System.Windows.Forms.ComboBox cb_hotkeyKey;
		private System.Windows.Forms.GroupBox gb_hotkeyModifier;
		private System.Windows.Forms.CheckBox chk_hotkeyModAlt;
		private System.Windows.Forms.CheckBox chk_hotkeyModShift;
		private System.Windows.Forms.CheckBox chk_hotkeyModCtrl;
		private System.Windows.Forms.Label lbl_website;
		private System.Windows.Forms.ColumnHeader ch_title;
		private System.Windows.Forms.Button btn_showAllApps;
		private System.Windows.Forms.Button btn_removeApp;
		private System.Windows.Forms.CheckBox chk_scaleToFit;
		private System.Windows.Forms.CheckBox chk_moveWindow;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShow;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemClose;
		private System.Windows.Forms.CheckBox chk_minimizeToTray;
		private System.Windows.Forms.NumericUpDown num_wndsize_w;
		private System.Windows.Forms.Label lbl_wndsize_h;
		private System.Windows.Forms.Label lbl_wndsize_w;
		private System.Windows.Forms.NumericUpDown num_wndsize_h;
		private System.Windows.Forms.NumericUpDown num_wndmove_y;
		private System.Windows.Forms.NumericUpDown num_wndmove_x;
		private System.Windows.Forms.Label lbl_wndmove_y;
		private System.Windows.Forms.Label lbl_wndmove_x;
		private System.Windows.Forms.NumericUpDown num_monitorscale;
		private System.Windows.Forms.Label lbl_monitorscale;
	}
}

