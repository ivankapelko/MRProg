﻿namespace MRProg.UserControls
{
    partial class ModuleControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._workProgramCheckBox = new System.Windows.Forms.CheckBox();
            this._chooseFile = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this._progressBar = new MetroFramework.Controls.MetroProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._fuzeLable = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._versionLable = new System.Windows.Forms.Label();
            this._toWorkState = new MetroFramework.Controls.MetroButton();
            this._toLoaderState = new MetroFramework.Controls.MetroButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this._eepromCheckBox = new System.Windows.Forms.CheckBox();
            this._writeEepromButton = new MetroFramework.Controls.MetroButton();
            this._readEepromButton = new MetroFramework.Controls.MetroButton();
            this._chooseFileEepromButton = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this._eepromProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.metroButton16 = new MetroFramework.Controls.MetroButton();
            this._relayDiscretCheckBox = new System.Windows.Forms.CheckBox();
            this._writeDiscretRelayButton = new MetroFramework.Controls.MetroButton();
            this._readDiscretRelayButton1 = new MetroFramework.Controls.MetroButton();
            this._chooseFileRelayButton = new MetroFramework.Controls.MetroButton();
            this.metroButton7 = new MetroFramework.Controls.MetroButton();
            this._relayProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._countReadPage = new System.Windows.Forms.TextBox();
            this._startReadPage = new System.Windows.Forms.TextBox();
            this._flashCheckBox = new System.Windows.Forms.CheckBox();
            this._writeFlashButton = new MetroFramework.Controls.MetroButton();
            this.readFlashButton = new MetroFramework.Controls.MetroButton();
            this._chooseFlashFileButton = new MetroFramework.Controls.MetroButton();
            this.metroButton9 = new MetroFramework.Controls.MetroButton();
            this._flashbootProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this._openFileDialogWorkProgramm = new System.Windows.Forms.OpenFileDialog();
            this._moduleNameLable = new System.Windows.Forms.Label();
            this._openFileDialogEeprom = new System.Windows.Forms.OpenFileDialog();
            this._openFileDialogRelayDiscret = new System.Windows.Forms.OpenFileDialog();
            this._openFileDialogFlash = new System.Windows.Forms.OpenFileDialog();
            this._saveFileDialogEeprom = new System.Windows.Forms.SaveFileDialog();
            this._saveFileDialogRelayDiscret = new System.Windows.Forms.SaveFileDialog();
            this._saveFileDialogFlash = new System.Windows.Forms.SaveFileDialog();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this._workProgramCheckBox);
            this.groupBox3.Controls.Add(this._chooseFile);
            this.groupBox3.Controls.Add(this.metroButton1);
            this.groupBox3.Controls.Add(this._progressBar);
            this.groupBox3.Location = new System.Drawing.Point(203, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(643, 78);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Рабочая программа";
            // 
            // _workProgramCheckBox
            // 
            this._workProgramCheckBox.AutoSize = true;
            this._workProgramCheckBox.Location = new System.Drawing.Point(155, 22);
            this._workProgramCheckBox.Name = "_workProgramCheckBox";
            this._workProgramCheckBox.Size = new System.Drawing.Size(15, 14);
            this._workProgramCheckBox.TabIndex = 3;
            this._workProgramCheckBox.UseVisualStyleBackColor = true;
            // 
            // _chooseFile
            // 
            this._chooseFile.Location = new System.Drawing.Point(7, 19);
            this._chooseFile.Name = "_chooseFile";
            this._chooseFile.Size = new System.Drawing.Size(141, 23);
            this._chooseFile.TabIndex = 2;
            this._chooseFile.Text = "Выбрать файл";
            this._chooseFile.UseSelectable = true;
            this._chooseFile.Click += new System.EventHandler(this._chooseFile_Click_1);
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.Location = new System.Drawing.Point(613, 48);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(24, 21);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "С";
            this.metroButton1.UseSelectable = true;
            // 
            // _progressBar
            // 
            this._progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._progressBar.Location = new System.Drawing.Point(7, 48);
            this._progressBar.Name = "_progressBar";
            this._progressBar.Size = new System.Drawing.Size(600, 23);
            this._progressBar.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this._fuzeLable);
            this.groupBox2.Location = new System.Drawing.Point(71, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(126, 50);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фьюзы";
            // 
            // _fuzeLable
            // 
            this._fuzeLable.AutoSize = true;
            this._fuzeLable.Location = new System.Drawing.Point(39, 23);
            this._fuzeLable.Name = "_fuzeLable";
            this._fuzeLable.Size = new System.Drawing.Size(27, 13);
            this._fuzeLable.TabIndex = 0;
            this._fuzeLable.Text = "fuze";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this._versionLable);
            this.groupBox1.Location = new System.Drawing.Point(1, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(64, 50);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Версия";
            // 
            // _versionLable
            // 
            this._versionLable.AutoSize = true;
            this._versionLable.Location = new System.Drawing.Point(13, 22);
            this._versionLable.Name = "_versionLable";
            this._versionLable.Size = new System.Drawing.Size(22, 13);
            this._versionLable.TabIndex = 0;
            this._versionLable.Text = "ver";
            // 
            // _toWorkState
            // 
            this._toWorkState.Location = new System.Drawing.Point(3, 78);
            this._toWorkState.Name = "_toWorkState";
            this._toWorkState.Size = new System.Drawing.Size(194, 26);
            this._toWorkState.TabIndex = 7;
            this._toWorkState.Text = "В рабочий режим";
            this._toWorkState.UseSelectable = true;
            this._toWorkState.Click += new System.EventHandler(this._toWorkState_Click);
            // 
            // _toLoaderState
            // 
            this._toLoaderState.Location = new System.Drawing.Point(3, 110);
            this._toLoaderState.Name = "_toLoaderState";
            this._toLoaderState.Size = new System.Drawing.Size(194, 26);
            this._toLoaderState.TabIndex = 8;
            this._toLoaderState.Text = "В режим загрузчика";
            this._toLoaderState.UseSelectable = true;
            this._toLoaderState.Click += new System.EventHandler(this._toLoaderState_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this._eepromCheckBox);
            this.groupBox4.Controls.Add(this._writeEepromButton);
            this.groupBox4.Controls.Add(this._readEepromButton);
            this.groupBox4.Controls.Add(this._chooseFileEepromButton);
            this.groupBox4.Controls.Add(this.metroButton5);
            this.groupBox4.Controls.Add(this._eepromProgressBar);
            this.groupBox4.Location = new System.Drawing.Point(203, 87);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(643, 91);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Eeprom";
            // 
            // _eepromCheckBox
            // 
            this._eepromCheckBox.AutoSize = true;
            this._eepromCheckBox.Location = new System.Drawing.Point(155, 34);
            this._eepromCheckBox.Name = "_eepromCheckBox";
            this._eepromCheckBox.Size = new System.Drawing.Size(15, 14);
            this._eepromCheckBox.TabIndex = 10;
            this._eepromCheckBox.UseVisualStyleBackColor = true;
            // 
            // _writeEepromButton
            // 
            this._writeEepromButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._writeEepromButton.Location = new System.Drawing.Point(387, 7);
            this._writeEepromButton.Name = "_writeEepromButton";
            this._writeEepromButton.Size = new System.Drawing.Size(119, 20);
            this._writeEepromButton.TabIndex = 9;
            this._writeEepromButton.Text = "Записать в устр.";
            this._writeEepromButton.UseSelectable = true;
            this._writeEepromButton.Click += new System.EventHandler(this._writeEepromButton_Click);
            // 
            // _readEepromButton
            // 
            this._readEepromButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._readEepromButton.Location = new System.Drawing.Point(512, 7);
            this._readEepromButton.Name = "_readEepromButton";
            this._readEepromButton.Size = new System.Drawing.Size(119, 20);
            this._readEepromButton.TabIndex = 8;
            this._readEepromButton.Text = "Прочитать из устр.";
            this._readEepromButton.UseSelectable = true;
            this._readEepromButton.Click += new System.EventHandler(this._readEepromButton_Click);
            // 
            // _chooseFileEepromButton
            // 
            this._chooseFileEepromButton.Location = new System.Drawing.Point(7, 31);
            this._chooseFileEepromButton.Name = "_chooseFileEepromButton";
            this._chooseFileEepromButton.Size = new System.Drawing.Size(141, 23);
            this._chooseFileEepromButton.TabIndex = 2;
            this._chooseFileEepromButton.Text = "Выбрать файл";
            this._chooseFileEepromButton.UseSelectable = true;
            this._chooseFileEepromButton.Click += new System.EventHandler(this._chooseFileEepromButton_Click);
            // 
            // metroButton5
            // 
            this.metroButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton5.Location = new System.Drawing.Point(613, 60);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(24, 21);
            this.metroButton5.TabIndex = 1;
            this.metroButton5.Text = "С";
            this.metroButton5.UseSelectable = true;
            // 
            // _eepromProgressBar
            // 
            this._eepromProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._eepromProgressBar.Location = new System.Drawing.Point(7, 60);
            this._eepromProgressBar.Name = "_eepromProgressBar";
            this._eepromProgressBar.Size = new System.Drawing.Size(600, 23);
            this._eepromProgressBar.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox5.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox5.Controls.Add(this.metroButton16);
            this.groupBox5.Controls.Add(this._relayDiscretCheckBox);
            this.groupBox5.Controls.Add(this._writeDiscretRelayButton);
            this.groupBox5.Controls.Add(this._readDiscretRelayButton1);
            this.groupBox5.Controls.Add(this._chooseFileRelayButton);
            this.groupBox5.Controls.Add(this.metroButton7);
            this.groupBox5.Controls.Add(this._relayProgressBar);
            this.groupBox5.Location = new System.Drawing.Point(203, 185);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(643, 91);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Реле и дискреты";
            // 
            // metroButton16
            // 
            this.metroButton16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton16.Location = new System.Drawing.Point(512, 7);
            this.metroButton16.Name = "metroButton16";
            this.metroButton16.Size = new System.Drawing.Size(119, 20);
            this.metroButton16.TabIndex = 12;
            this.metroButton16.Text = "Сконфигурировать";
            this.metroButton16.UseSelectable = true;
            // 
            // _relayDiscretCheckBox
            // 
            this._relayDiscretCheckBox.AutoSize = true;
            this._relayDiscretCheckBox.Location = new System.Drawing.Point(155, 36);
            this._relayDiscretCheckBox.Name = "_relayDiscretCheckBox";
            this._relayDiscretCheckBox.Size = new System.Drawing.Size(15, 14);
            this._relayDiscretCheckBox.TabIndex = 11;
            this._relayDiscretCheckBox.UseVisualStyleBackColor = true;
            // 
            // _writeDiscretRelayButton
            // 
            this._writeDiscretRelayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._writeDiscretRelayButton.Location = new System.Drawing.Point(263, 7);
            this._writeDiscretRelayButton.Name = "_writeDiscretRelayButton";
            this._writeDiscretRelayButton.Size = new System.Drawing.Size(119, 20);
            this._writeDiscretRelayButton.TabIndex = 7;
            this._writeDiscretRelayButton.Text = "Записать в устр.";
            this._writeDiscretRelayButton.UseSelectable = true;
            this._writeDiscretRelayButton.Click += new System.EventHandler(this._writeDiscretRelayButton_Click);
            // 
            // _readDiscretRelayButton1
            // 
            this._readDiscretRelayButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._readDiscretRelayButton1.Location = new System.Drawing.Point(387, 7);
            this._readDiscretRelayButton1.Name = "_readDiscretRelayButton1";
            this._readDiscretRelayButton1.Size = new System.Drawing.Size(119, 20);
            this._readDiscretRelayButton1.TabIndex = 6;
            this._readDiscretRelayButton1.Text = "Прочитать из устр.";
            this._readDiscretRelayButton1.UseSelectable = true;
            this._readDiscretRelayButton1.Click += new System.EventHandler(this._readDiscretRelayButton1_Click);
            // 
            // _chooseFileRelayButton
            // 
            this._chooseFileRelayButton.Location = new System.Drawing.Point(7, 32);
            this._chooseFileRelayButton.Name = "_chooseFileRelayButton";
            this._chooseFileRelayButton.Size = new System.Drawing.Size(141, 23);
            this._chooseFileRelayButton.TabIndex = 2;
            this._chooseFileRelayButton.Text = "Выбрать файл";
            this._chooseFileRelayButton.UseSelectable = true;
            this._chooseFileRelayButton.Click += new System.EventHandler(this._chooseFileRelayButton_Click);
            // 
            // metroButton7
            // 
            this.metroButton7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton7.Location = new System.Drawing.Point(613, 61);
            this.metroButton7.Name = "metroButton7";
            this.metroButton7.Size = new System.Drawing.Size(24, 21);
            this.metroButton7.TabIndex = 1;
            this.metroButton7.Text = "С";
            this.metroButton7.UseSelectable = true;
            // 
            // _relayProgressBar
            // 
            this._relayProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._relayProgressBar.Location = new System.Drawing.Point(7, 61);
            this._relayProgressBar.Name = "_relayProgressBar";
            this._relayProgressBar.Size = new System.Drawing.Size(600, 23);
            this._relayProgressBar.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox6.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this._countReadPage);
            this.groupBox6.Controls.Add(this._startReadPage);
            this.groupBox6.Controls.Add(this._flashCheckBox);
            this.groupBox6.Controls.Add(this._writeFlashButton);
            this.groupBox6.Controls.Add(this.readFlashButton);
            this.groupBox6.Controls.Add(this._chooseFlashFileButton);
            this.groupBox6.Controls.Add(this.metroButton9);
            this.groupBox6.Controls.Add(this._flashbootProgressBar);
            this.groupBox6.Location = new System.Drawing.Point(203, 282);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(643, 95);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Flash (Загрузчик)";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Количество страниц";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Начальная страница";
            // 
            // _countReadPage
            // 
            this._countReadPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._countReadPage.Location = new System.Drawing.Point(579, 39);
            this._countReadPage.Name = "_countReadPage";
            this._countReadPage.Size = new System.Drawing.Size(51, 20);
            this._countReadPage.TabIndex = 16;
            this._countReadPage.Text = "480";
            // 
            // _startReadPage
            // 
            this._startReadPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._startReadPage.Location = new System.Drawing.Point(382, 39);
            this._startReadPage.Name = "_startReadPage";
            this._startReadPage.Size = new System.Drawing.Size(42, 20);
            this._startReadPage.TabIndex = 15;
            this._startReadPage.Text = "512";
            // 
            // _flashCheckBox
            // 
            this._flashCheckBox.AutoSize = true;
            this._flashCheckBox.Location = new System.Drawing.Point(155, 22);
            this._flashCheckBox.Name = "_flashCheckBox";
            this._flashCheckBox.Size = new System.Drawing.Size(15, 14);
            this._flashCheckBox.TabIndex = 12;
            this._flashCheckBox.UseVisualStyleBackColor = true;
            // 
            // _writeFlashButton
            // 
            this._writeFlashButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._writeFlashButton.Location = new System.Drawing.Point(387, 7);
            this._writeFlashButton.Name = "_writeFlashButton";
            this._writeFlashButton.Size = new System.Drawing.Size(119, 20);
            this._writeFlashButton.TabIndex = 5;
            this._writeFlashButton.Text = "Записать в устр.";
            this._writeFlashButton.UseSelectable = true;
            this._writeFlashButton.Click += new System.EventHandler(this._writeFlashButton_Click);
            // 
            // readFlashButton
            // 
            this.readFlashButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.readFlashButton.Location = new System.Drawing.Point(512, 7);
            this.readFlashButton.Name = "readFlashButton";
            this.readFlashButton.Size = new System.Drawing.Size(119, 20);
            this.readFlashButton.TabIndex = 4;
            this.readFlashButton.Text = "Прочитать из устр.";
            this.readFlashButton.UseSelectable = true;
            this.readFlashButton.Click += new System.EventHandler(this.readFlashButton_Click);
            // 
            // _chooseFlashFileButton
            // 
            this._chooseFlashFileButton.Location = new System.Drawing.Point(7, 19);
            this._chooseFlashFileButton.Name = "_chooseFlashFileButton";
            this._chooseFlashFileButton.Size = new System.Drawing.Size(141, 23);
            this._chooseFlashFileButton.TabIndex = 2;
            this._chooseFlashFileButton.Text = "Выбрать файл";
            this._chooseFlashFileButton.UseSelectable = true;
            this._chooseFlashFileButton.Click += new System.EventHandler(this._chooseFlashFileButton_Click);
            // 
            // metroButton9
            // 
            this.metroButton9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton9.Location = new System.Drawing.Point(613, 67);
            this.metroButton9.Name = "metroButton9";
            this.metroButton9.Size = new System.Drawing.Size(24, 21);
            this.metroButton9.TabIndex = 1;
            this.metroButton9.Text = "С";
            this.metroButton9.UseSelectable = true;
            // 
            // _flashbootProgressBar
            // 
            this._flashbootProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._flashbootProgressBar.Location = new System.Drawing.Point(7, 67);
            this._flashbootProgressBar.Name = "_flashbootProgressBar";
            this._flashbootProgressBar.Size = new System.Drawing.Size(600, 23);
            this._flashbootProgressBar.TabIndex = 0;
            // 
            // _openFileDialogWorkProgramm
            // 
            this._openFileDialogWorkProgramm.Filter = "Файл прошивки (*.bin)|*.bin";
            // 
            // _moduleNameLable
            // 
            this._moduleNameLable.AutoSize = true;
            this._moduleNameLable.Location = new System.Drawing.Point(3, 3);
            this._moduleNameLable.Name = "_moduleNameLable";
            this._moduleNameLable.Size = new System.Drawing.Size(117, 13);
            this._moduleNameLable.TabIndex = 13;
            this._moduleNameLable.Text = "Модуль не определен";
            // 
            // _openFileDialogEeprom
            // 
            this._openFileDialogEeprom.Filter = "Файл  (*.bin)|*.bin";
            // 
            // _openFileDialogRelayDiscret
            // 
            this._openFileDialogRelayDiscret.Filter = "Файл  (*.drc)|*drc";
            // 
            // _openFileDialogFlash
            // 
            this._openFileDialogFlash.Filter = "Файл  (*.bin)|*.bin";
            // 
            // _saveFileDialogEeprom
            // 
            this._saveFileDialogEeprom.Filter = "Файл  (*.bin)|*.bin";
            // 
            // _saveFileDialogRelayDiscret
            // 
            this._saveFileDialogRelayDiscret.Filter = "Файл  (*.drc)|*.drc";
            // 
            // _saveFileDialogFlash
            // 
            this._saveFileDialogFlash.Filter = "Файл  (*.bin)|*.bin";
            // 
            // ModuleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this._moduleNameLable);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this._toLoaderState);
            this.Controls.Add(this._toWorkState);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModuleControl";
            this.Size = new System.Drawing.Size(853, 387);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroButton _chooseFile;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroProgressBar _progressBar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton _toWorkState;
        private MetroFramework.Controls.MetroButton _toLoaderState;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroButton _chooseFileEepromButton;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroProgressBar _eepromProgressBar;
        private System.Windows.Forms.GroupBox groupBox5;
        private MetroFramework.Controls.MetroButton _chooseFileRelayButton;
        private MetroFramework.Controls.MetroButton metroButton7;
        private MetroFramework.Controls.MetroProgressBar _relayProgressBar;
        private System.Windows.Forms.GroupBox groupBox6;
        private MetroFramework.Controls.MetroButton _chooseFlashFileButton;
        private MetroFramework.Controls.MetroButton metroButton9;
        private MetroFramework.Controls.MetroProgressBar _flashbootProgressBar;
        private MetroFramework.Controls.MetroButton _writeEepromButton;
        private MetroFramework.Controls.MetroButton _readEepromButton;
        private MetroFramework.Controls.MetroButton _writeDiscretRelayButton;
        private MetroFramework.Controls.MetroButton _readDiscretRelayButton1;
        private MetroFramework.Controls.MetroButton _writeFlashButton;
        private MetroFramework.Controls.MetroButton readFlashButton;
        private System.Windows.Forms.Label _fuzeLable;
        private System.Windows.Forms.Label _versionLable;
        private System.Windows.Forms.OpenFileDialog _openFileDialogWorkProgramm;
        private System.Windows.Forms.CheckBox _workProgramCheckBox;
        private System.Windows.Forms.CheckBox _eepromCheckBox;
        private System.Windows.Forms.CheckBox _relayDiscretCheckBox;
        private System.Windows.Forms.CheckBox _flashCheckBox;
        private System.Windows.Forms.Label _moduleNameLable;
        private MetroFramework.Controls.MetroButton metroButton16;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _countReadPage;
        private System.Windows.Forms.TextBox _startReadPage;
        private System.Windows.Forms.OpenFileDialog _openFileDialogEeprom;
        private System.Windows.Forms.OpenFileDialog _openFileDialogRelayDiscret;
        private System.Windows.Forms.OpenFileDialog _openFileDialogFlash;
        private System.Windows.Forms.SaveFileDialog _saveFileDialogEeprom;
        private System.Windows.Forms.SaveFileDialog _saveFileDialogRelayDiscret;
        private System.Windows.Forms.SaveFileDialog _saveFileDialogFlash;
    }
}
