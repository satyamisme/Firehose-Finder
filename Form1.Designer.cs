﻿namespace FirehoseFinder
{
    partial class Formfhf
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formfhf));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_firehose = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_final = new System.Windows.Forms.DataGridView();
            this.Column_Sel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Full = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_SW_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_hwid = new System.Windows.Forms.Label();
            this.button_rename_fhf = new System.Windows.Forms.Button();
            this.textBox_oemid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_modelid = new System.Windows.Forms.Label();
            this.textBox_hwid = new System.Windows.Forms.TextBox();
            this.label_oemid = new System.Windows.Forms.Label();
            this.button_path = new System.Windows.Forms.Button();
            this.textBox_oemhash = new System.Windows.Forms.TextBox();
            this.label_oemhash = new System.Windows.Forms.Label();
            this.textBox_modelid = new System.Windows.Forms.TextBox();
            this.statusStrip_firehose = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_filescompleted = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar_filescompleted = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel_vol = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabPage_phone = new System.Windows.Forms.TabPage();
            this.textBox_ADB_commandstring = new System.Windows.Forms.TextBox();
            this.button_ADB_comstart = new System.Windows.Forms.Button();
            this.comboBox_ADB_commands = new System.Windows.Forms.ComboBox();
            this.button_ADB_clear = new System.Windows.Forms.Button();
            this.button_ADB_start = new System.Windows.Forms.Button();
            this.textBox_ADB = new System.Windows.Forms.TextBox();
            this.tabPage_guide = new System.Windows.Forms.TabPage();
            this.linkLabel_issues = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage_about = new System.Windows.Forms.TabPage();
            this.richTextBox_about = new System.Windows.Forms.RichTextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker_Read_File = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage_firehose.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_final)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip_firehose.SuspendLayout();
            this.tabPage_phone.SuspendLayout();
            this.tabPage_guide.SuspendLayout();
            this.tabPage_about.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_firehose);
            this.tabControl1.Controls.Add(this.tabPage_phone);
            this.tabControl1.Controls.Add(this.tabPage_guide);
            this.tabControl1.Controls.Add(this.tabPage_about);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1250, 613);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_firehose
            // 
            this.tabPage_firehose.Controls.Add(this.panel2);
            this.tabPage_firehose.Controls.Add(this.panel1);
            this.tabPage_firehose.Controls.Add(this.statusStrip_firehose);
            this.tabPage_firehose.Location = new System.Drawing.Point(4, 25);
            this.tabPage_firehose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_firehose.Name = "tabPage_firehose";
            this.tabPage_firehose.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_firehose.Size = new System.Drawing.Size(1242, 584);
            this.tabPage_firehose.TabIndex = 0;
            this.tabPage_firehose.Text = "Работа с файлами";
            this.tabPage_firehose.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_final);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1236, 449);
            this.panel2.TabIndex = 18;
            // 
            // dataGridView_final
            // 
            this.dataGridView_final.AllowUserToAddRows = false;
            this.dataGridView_final.AllowUserToDeleteRows = false;
            this.dataGridView_final.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_final.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Sel,
            this.Column_Name,
            this.Column_id,
            this.Column_rate,
            this.Column_Full,
            this.Column_SW_type});
            this.dataGridView_final.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView_final.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_final.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_final.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_final.Name = "dataGridView_final";
            this.dataGridView_final.RowHeadersWidth = 51;
            this.dataGridView_final.RowTemplate.Height = 24;
            this.dataGridView_final.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_final.Size = new System.Drawing.Size(1236, 449);
            this.dataGridView_final.TabIndex = 15;
            this.dataGridView_final.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_final_CellClick);
            this.dataGridView_final.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_final_CellDoubleClick);
            // 
            // Column_Sel
            // 
            this.Column_Sel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column_Sel.HeaderText = "Выбор";
            this.Column_Sel.MinimumWidth = 6;
            this.Column_Sel.Name = "Column_Sel";
            this.Column_Sel.Width = 57;
            // 
            // Column_Name
            // 
            this.Column_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column_Name.HeaderText = "Файл";
            this.Column_Name.MinimumWidth = 6;
            this.Column_Name.Name = "Column_Name";
            this.Column_Name.Width = 74;
            // 
            // Column_id
            // 
            this.Column_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column_id.HeaderText = "HW-OEM-MODEL-HASH-SW(Ver)";
            this.Column_id.MinimumWidth = 6;
            this.Column_id.Name = "Column_id";
            this.Column_id.Width = 252;
            // 
            // Column_rate
            // 
            this.Column_rate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column_rate.HeaderText = "Рейтинг (max10)";
            this.Column_rate.MinimumWidth = 6;
            this.Column_rate.Name = "Column_rate";
            this.Column_rate.Width = 133;
            // 
            // Column_Full
            // 
            this.Column_Full.HeaderText = "Full Ids";
            this.Column_Full.MinimumWidth = 6;
            this.Column_Full.Name = "Column_Full";
            this.Column_Full.Visible = false;
            this.Column_Full.Width = 125;
            // 
            // Column_SW_type
            // 
            this.Column_SW_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column_SW_type.HeaderText = "Тип ПО";
            this.Column_SW_type.MinimumWidth = 6;
            this.Column_SW_type.Name = "Column_SW_type";
            this.Column_SW_type.Width = 62;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_hwid);
            this.panel1.Controls.Add(this.button_rename_fhf);
            this.panel1.Controls.Add(this.textBox_oemid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label_modelid);
            this.panel1.Controls.Add(this.textBox_hwid);
            this.panel1.Controls.Add(this.label_oemid);
            this.panel1.Controls.Add(this.button_path);
            this.panel1.Controls.Add(this.textBox_oemhash);
            this.panel1.Controls.Add(this.label_oemhash);
            this.panel1.Controls.Add(this.textBox_modelid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1236, 101);
            this.panel1.TabIndex = 17;
            // 
            // label_hwid
            // 
            this.label_hwid.AutoSize = true;
            this.label_hwid.Location = new System.Drawing.Point(5, 11);
            this.label_hwid.Name = "label_hwid";
            this.label_hwid.Size = new System.Drawing.Size(70, 17);
            this.label_hwid.TabIndex = 1;
            this.label_hwid.Text = "HW_ID 0x";
            // 
            // button_rename_fhf
            // 
            this.button_rename_fhf.Location = new System.Drawing.Point(290, 68);
            this.button_rename_fhf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_rename_fhf.Name = "button_rename_fhf";
            this.button_rename_fhf.Size = new System.Drawing.Size(324, 23);
            this.button_rename_fhf.TabIndex = 10;
            this.button_rename_fhf.Text = "Переименовать файл по идентификаторам";
            this.button_rename_fhf.UseVisualStyleBackColor = true;
            this.button_rename_fhf.Visible = false;
            this.button_rename_fhf.Click += new System.EventHandler(this.Button__rename_fhf_Click);
            // 
            // textBox_oemid
            // 
            this.textBox_oemid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_oemid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_oemid.Location = new System.Drawing.Point(242, 10);
            this.textBox_oemid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_oemid.MaxLength = 4;
            this.textBox_oemid.Name = "textBox_oemid";
            this.textBox_oemid.Size = new System.Drawing.Size(43, 22);
            this.textBox_oemid.TabIndex = 4;
            this.textBox_oemid.Text = "0043";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(661, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Алгоритм SHA-256";
            // 
            // label_modelid
            // 
            this.label_modelid.AutoSize = true;
            this.label_modelid.Location = new System.Drawing.Point(287, 14);
            this.label_modelid.Name = "label_modelid";
            this.label_modelid.Size = new System.Drawing.Size(96, 17);
            this.label_modelid.TabIndex = 3;
            this.label_modelid.Text = "MODEL_ID 0x";
            // 
            // textBox_hwid
            // 
            this.textBox_hwid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_hwid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_hwid.Location = new System.Drawing.Point(81, 9);
            this.textBox_hwid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_hwid.MaxLength = 8;
            this.textBox_hwid.Name = "textBox_hwid";
            this.textBox_hwid.Size = new System.Drawing.Size(73, 22);
            this.textBox_hwid.TabIndex = 0;
            this.textBox_hwid.Text = "0009A0E1";
            // 
            // label_oemid
            // 
            this.label_oemid.AutoSize = true;
            this.label_oemid.Location = new System.Drawing.Point(159, 11);
            this.label_oemid.Name = "label_oemid";
            this.label_oemid.Size = new System.Drawing.Size(78, 17);
            this.label_oemid.TabIndex = 5;
            this.label_oemid.Text = "OEM_ID 0x";
            // 
            // button_path
            // 
            this.button_path.Location = new System.Drawing.Point(5, 68);
            this.button_path.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_path.Name = "button_path";
            this.button_path.Size = new System.Drawing.Size(275, 23);
            this.button_path.TabIndex = 9;
            this.button_path.Text = "~Рабочий стол";
            this.button_path.UseVisualStyleBackColor = true;
            this.button_path.Click += new System.EventHandler(this.Button_path_Click);
            // 
            // textBox_oemhash
            // 
            this.textBox_oemhash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_oemhash.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_oemhash.Location = new System.Drawing.Point(95, 42);
            this.textBox_oemhash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_oemhash.MaxLength = 64;
            this.textBox_oemhash.Name = "textBox_oemhash";
            this.textBox_oemhash.Size = new System.Drawing.Size(559, 22);
            this.textBox_oemhash.TabIndex = 6;
            this.textBox_oemhash.Text = "7C6DCA9BF5674291AA39DD55760C0D4B65C7A4223097AAB1DB791E2192002DDF";
            // 
            // label_oemhash
            // 
            this.label_oemhash.AutoSize = true;
            this.label_oemhash.Location = new System.Drawing.Point(5, 43);
            this.label_oemhash.Name = "label_oemhash";
            this.label_oemhash.Size = new System.Drawing.Size(85, 17);
            this.label_oemhash.TabIndex = 7;
            this.label_oemhash.Text = "OEM_HASH";
            // 
            // textBox_modelid
            // 
            this.textBox_modelid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_modelid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_modelid.Location = new System.Drawing.Point(389, 11);
            this.textBox_modelid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_modelid.MaxLength = 4;
            this.textBox_modelid.Name = "textBox_modelid";
            this.textBox_modelid.Size = new System.Drawing.Size(43, 22);
            this.textBox_modelid.TabIndex = 2;
            this.textBox_modelid.Text = "0000";
            // 
            // statusStrip_firehose
            // 
            this.statusStrip_firehose.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip_firehose.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_filescompleted,
            this.toolStripProgressBar_filescompleted,
            this.toolStripStatusLabel_vol});
            this.statusStrip_firehose.Location = new System.Drawing.Point(3, 552);
            this.statusStrip_firehose.Name = "statusStrip_firehose";
            this.statusStrip_firehose.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip_firehose.Size = new System.Drawing.Size(1236, 30);
            this.statusStrip_firehose.TabIndex = 12;
            this.statusStrip_firehose.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_filescompleted
            // 
            this.toolStripStatusLabel_filescompleted.Name = "toolStripStatusLabel_filescompleted";
            this.toolStripStatusLabel_filescompleted.Size = new System.Drawing.Size(0, 24);
            // 
            // toolStripProgressBar_filescompleted
            // 
            this.toolStripProgressBar_filescompleted.AutoToolTip = true;
            this.toolStripProgressBar_filescompleted.Name = "toolStripProgressBar_filescompleted";
            this.toolStripProgressBar_filescompleted.Size = new System.Drawing.Size(400, 22);
            this.toolStripProgressBar_filescompleted.Step = 1;
            // 
            // toolStripStatusLabel_vol
            // 
            this.toolStripStatusLabel_vol.Name = "toolStripStatusLabel_vol";
            this.toolStripStatusLabel_vol.Size = new System.Drawing.Size(0, 24);
            // 
            // tabPage_phone
            // 
            this.tabPage_phone.Controls.Add(this.textBox_ADB_commandstring);
            this.tabPage_phone.Controls.Add(this.button_ADB_comstart);
            this.tabPage_phone.Controls.Add(this.comboBox_ADB_commands);
            this.tabPage_phone.Controls.Add(this.button_ADB_clear);
            this.tabPage_phone.Controls.Add(this.button_ADB_start);
            this.tabPage_phone.Controls.Add(this.textBox_ADB);
            this.tabPage_phone.Location = new System.Drawing.Point(4, 25);
            this.tabPage_phone.Name = "tabPage_phone";
            this.tabPage_phone.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_phone.Size = new System.Drawing.Size(1242, 584);
            this.tabPage_phone.TabIndex = 2;
            this.tabPage_phone.Text = "Работа с устройством";
            this.tabPage_phone.UseVisualStyleBackColor = true;
            // 
            // textBox_ADB_commandstring
            // 
            this.textBox_ADB_commandstring.Location = new System.Drawing.Point(9, 479);
            this.textBox_ADB_commandstring.Name = "textBox_ADB_commandstring";
            this.textBox_ADB_commandstring.Size = new System.Drawing.Size(213, 22);
            this.textBox_ADB_commandstring.TabIndex = 6;
            this.textBox_ADB_commandstring.Visible = false;
            this.textBox_ADB_commandstring.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_ADB_commandstring_KeyUp);
            // 
            // button_ADB_comstart
            // 
            this.button_ADB_comstart.Enabled = false;
            this.button_ADB_comstart.Location = new System.Drawing.Point(228, 479);
            this.button_ADB_comstart.Name = "button_ADB_comstart";
            this.button_ADB_comstart.Size = new System.Drawing.Size(206, 23);
            this.button_ADB_comstart.TabIndex = 5;
            this.button_ADB_comstart.Text = "Выполнить команду";
            this.button_ADB_comstart.UseVisualStyleBackColor = true;
            this.button_ADB_comstart.Click += new System.EventHandler(this.Button_ADB_comstart_Click);
            // 
            // comboBox_ADB_commands
            // 
            this.comboBox_ADB_commands.Enabled = false;
            this.comboBox_ADB_commands.FormattingEnabled = true;
            this.comboBox_ADB_commands.Items.AddRange(new object[] {
            "Перегрузить устройство в аварийный режим",
            "Получить список параметров устройства",
            "Командная строка (ADB Shell)"});
            this.comboBox_ADB_commands.Location = new System.Drawing.Point(9, 449);
            this.comboBox_ADB_commands.Name = "comboBox_ADB_commands";
            this.comboBox_ADB_commands.Size = new System.Drawing.Size(425, 24);
            this.comboBox_ADB_commands.TabIndex = 4;
            this.comboBox_ADB_commands.Text = "Выберите команду";
            this.comboBox_ADB_commands.SelectedIndexChanged += new System.EventHandler(this.ComboBox_ADB_commands_SelectedIndexChanged);
            // 
            // button_ADB_clear
            // 
            this.button_ADB_clear.Location = new System.Drawing.Point(228, 420);
            this.button_ADB_clear.Name = "button_ADB_clear";
            this.button_ADB_clear.Size = new System.Drawing.Size(206, 23);
            this.button_ADB_clear.TabIndex = 3;
            this.button_ADB_clear.Text = "Очистить и закрыть ADB";
            this.button_ADB_clear.UseVisualStyleBackColor = true;
            this.button_ADB_clear.Click += new System.EventHandler(this.Button_ADB_clear_Click);
            // 
            // button_ADB_start
            // 
            this.button_ADB_start.Location = new System.Drawing.Point(9, 420);
            this.button_ADB_start.Name = "button_ADB_start";
            this.button_ADB_start.Size = new System.Drawing.Size(213, 23);
            this.button_ADB_start.TabIndex = 2;
            this.button_ADB_start.Text = "Подключить ADB";
            this.button_ADB_start.UseVisualStyleBackColor = true;
            this.button_ADB_start.Click += new System.EventHandler(this.Button_ADB_start_Click);
            // 
            // textBox_ADB
            // 
            this.textBox_ADB.Location = new System.Drawing.Point(9, 7);
            this.textBox_ADB.Multiline = true;
            this.textBox_ADB.Name = "textBox_ADB";
            this.textBox_ADB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_ADB.Size = new System.Drawing.Size(425, 407);
            this.textBox_ADB.TabIndex = 1;
            // 
            // tabPage_guide
            // 
            this.tabPage_guide.Controls.Add(this.linkLabel_issues);
            this.tabPage_guide.Controls.Add(this.label3);
            this.tabPage_guide.Location = new System.Drawing.Point(4, 25);
            this.tabPage_guide.Name = "tabPage_guide";
            this.tabPage_guide.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_guide.Size = new System.Drawing.Size(1242, 584);
            this.tabPage_guide.TabIndex = 3;
            this.tabPage_guide.Text = "Справочник ID";
            this.tabPage_guide.UseVisualStyleBackColor = true;
            // 
            // linkLabel_issues
            // 
            this.linkLabel_issues.AutoSize = true;
            this.linkLabel_issues.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linkLabel_issues.LinkArea = new System.Windows.Forms.LinkArea(291, 50);
            this.linkLabel_issues.Location = new System.Drawing.Point(3, 532);
            this.linkLabel_issues.Name = "linkLabel_issues";
            this.linkLabel_issues.Size = new System.Drawing.Size(1063, 49);
            this.linkLabel_issues.TabIndex = 1;
            this.linkLabel_issues.TabStop = true;
            this.linkLabel_issues.Text = resources.GetString("linkLabel_issues.Text");
            this.linkLabel_issues.UseCompatibleTextRendering = true;
            this.linkLabel_issues.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_issues_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(741, 34);
            this.label3.TabIndex = 0;
            this.label3.Text = "Тут планируется разместить справочник идентификаторов с фильтрами и сортировкой.\r" +
    "\nДля удобства пользования информация будет иметь приоритет в зависимости от подк" +
    "лючённого устройства.";
            // 
            // tabPage_about
            // 
            this.tabPage_about.Controls.Add(this.richTextBox_about);
            this.tabPage_about.Location = new System.Drawing.Point(4, 25);
            this.tabPage_about.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_about.Name = "tabPage_about";
            this.tabPage_about.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_about.Size = new System.Drawing.Size(1242, 584);
            this.tabPage_about.TabIndex = 1;
            this.tabPage_about.Text = "О программе";
            this.tabPage_about.UseVisualStyleBackColor = true;
            // 
            // richTextBox_about
            // 
            this.richTextBox_about.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_about.Location = new System.Drawing.Point(3, 2);
            this.richTextBox_about.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox_about.Name = "richTextBox_about";
            this.richTextBox_about.Size = new System.Drawing.Size(1236, 580);
            this.richTextBox_about.TabIndex = 1;
            this.richTextBox_about.Text = "";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Укажите путь к папке с программерами";
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // backgroundWorker_Read_File
            // 
            this.backgroundWorker_Read_File.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_Read_File_DoWork);
            this.backgroundWorker_Read_File.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_Read_File_RunWorkerCompleted);
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "";
            // 
            // Formfhf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 613);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Formfhf";
            this.Text = "Firehose Finder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Formfhf_FormClosing);
            this.Load += new System.EventHandler(this.Formfhf_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_firehose.ResumeLayout(false);
            this.tabPage_firehose.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_final)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip_firehose.ResumeLayout(false);
            this.statusStrip_firehose.PerformLayout();
            this.tabPage_phone.ResumeLayout(false);
            this.tabPage_phone.PerformLayout();
            this.tabPage_guide.ResumeLayout(false);
            this.tabPage_guide.PerformLayout();
            this.tabPage_about.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_firehose;
        private System.Windows.Forms.TabPage tabPage_about;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.StatusStrip statusStrip_firehose;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar_filescompleted;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_filescompleted;
        private System.Windows.Forms.RichTextBox richTextBox_about;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_vol;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView_final;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_hwid;
        private System.Windows.Forms.Button button_rename_fhf;
        private System.Windows.Forms.TextBox textBox_oemid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_modelid;
        private System.Windows.Forms.TextBox textBox_hwid;
        private System.Windows.Forms.Label label_oemid;
        private System.Windows.Forms.Button button_path;
        private System.Windows.Forms.TextBox textBox_oemhash;
        private System.Windows.Forms.Label label_oemhash;
        private System.Windows.Forms.TextBox textBox_modelid;
        private System.ComponentModel.BackgroundWorker backgroundWorker_Read_File;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column_Sel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Full;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_SW_type;
        private System.Windows.Forms.TabPage tabPage_phone;
        private System.Windows.Forms.TabPage tabPage_guide;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel_issues;
        private System.Windows.Forms.Button button_ADB_start;
        private System.Windows.Forms.TextBox textBox_ADB;
        private System.Windows.Forms.Button button_ADB_clear;
        private System.Windows.Forms.ComboBox comboBox_ADB_commands;
        private System.Windows.Forms.Button button_ADB_comstart;
        private System.Windows.Forms.TextBox textBox_ADB_commandstring;
    }
}

