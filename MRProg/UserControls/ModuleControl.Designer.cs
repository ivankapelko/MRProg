namespace MRProg.UserControls
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
            this._chooseFile = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this._progressBar = new MetroFramework.Controls.MetroProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.metroButton14 = new MetroFramework.Controls.MetroButton();
            this.metroButton15 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this._eepromProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.metroButton12 = new MetroFramework.Controls.MetroButton();
            this.metroButton13 = new MetroFramework.Controls.MetroButton();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.metroButton7 = new MetroFramework.Controls.MetroButton();
            this._relayProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.metroButton11 = new MetroFramework.Controls.MetroButton();
            this.metroButton10 = new MetroFramework.Controls.MetroButton();
            this.metroButton8 = new MetroFramework.Controls.MetroButton();
            this.metroButton9 = new MetroFramework.Controls.MetroButton();
            this._flashbootProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this._versionLable = new System.Windows.Forms.Label();
            this._fuzeLable = new System.Windows.Forms.Label();
            this._openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this._workProgramCheckBox = new System.Windows.Forms.CheckBox();
            this._eepromCheckBox = new System.Windows.Forms.CheckBox();
            this._relayDiscretCheckBox = new System.Windows.Forms.CheckBox();
            this._flashCheckBox = new System.Windows.Forms.CheckBox();
            this._moduleNameLable = new System.Windows.Forms.Label();
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
            // _chooseFile
            // 
            this._chooseFile.Location = new System.Drawing.Point(7, 19);
            this._chooseFile.Name = "_chooseFile";
            this._chooseFile.Size = new System.Drawing.Size(141, 23);
            this._chooseFile.TabIndex = 2;
            this._chooseFile.Text = "Выбрать файл";
            this._chooseFile.UseSelectable = true;
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
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(3, 78);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(194, 26);
            this.metroButton2.TabIndex = 7;
            this.metroButton2.Text = "В рабочий режим";
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(3, 110);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(194, 26);
            this.metroButton3.TabIndex = 8;
            this.metroButton3.Text = "В режим загрузчика";
            this.metroButton3.UseSelectable = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this._eepromCheckBox);
            this.groupBox4.Controls.Add(this.metroButton14);
            this.groupBox4.Controls.Add(this.metroButton15);
            this.groupBox4.Controls.Add(this.metroButton4);
            this.groupBox4.Controls.Add(this.metroButton5);
            this.groupBox4.Controls.Add(this._eepromProgressBar);
            this.groupBox4.Location = new System.Drawing.Point(203, 87);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(643, 91);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Eeprom";
            // 
            // metroButton14
            // 
            this.metroButton14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton14.Location = new System.Drawing.Point(387, 7);
            this.metroButton14.Name = "metroButton14";
            this.metroButton14.Size = new System.Drawing.Size(119, 20);
            this.metroButton14.TabIndex = 9;
            this.metroButton14.Text = "Записать в устр.";
            this.metroButton14.UseSelectable = true;
            // 
            // metroButton15
            // 
            this.metroButton15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton15.Location = new System.Drawing.Point(512, 7);
            this.metroButton15.Name = "metroButton15";
            this.metroButton15.Size = new System.Drawing.Size(119, 20);
            this.metroButton15.TabIndex = 8;
            this.metroButton15.Text = "Прочитать из устр.";
            this.metroButton15.UseSelectable = true;
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(7, 31);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(141, 23);
            this.metroButton4.TabIndex = 2;
            this.metroButton4.Text = "Выбрать файл";
            this.metroButton4.UseSelectable = true;
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
            this.groupBox5.Controls.Add(this._relayDiscretCheckBox);
            this.groupBox5.Controls.Add(this.metroButton12);
            this.groupBox5.Controls.Add(this.metroButton13);
            this.groupBox5.Controls.Add(this.metroButton6);
            this.groupBox5.Controls.Add(this.metroButton7);
            this.groupBox5.Controls.Add(this._relayProgressBar);
            this.groupBox5.Location = new System.Drawing.Point(203, 185);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(643, 91);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Реле и дискреты";
            // 
            // metroButton12
            // 
            this.metroButton12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton12.Location = new System.Drawing.Point(387, 7);
            this.metroButton12.Name = "metroButton12";
            this.metroButton12.Size = new System.Drawing.Size(119, 20);
            this.metroButton12.TabIndex = 7;
            this.metroButton12.Text = "Записать в устр.";
            this.metroButton12.UseSelectable = true;
            // 
            // metroButton13
            // 
            this.metroButton13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton13.Location = new System.Drawing.Point(512, 7);
            this.metroButton13.Name = "metroButton13";
            this.metroButton13.Size = new System.Drawing.Size(119, 20);
            this.metroButton13.TabIndex = 6;
            this.metroButton13.Text = "Прочитать из устр.";
            this.metroButton13.UseSelectable = true;
            // 
            // metroButton6
            // 
            this.metroButton6.Location = new System.Drawing.Point(7, 32);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(141, 23);
            this.metroButton6.TabIndex = 2;
            this.metroButton6.Text = "Выбрать файл";
            this.metroButton6.UseSelectable = true;
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
            this.groupBox6.Controls.Add(this._flashCheckBox);
            this.groupBox6.Controls.Add(this.metroButton11);
            this.groupBox6.Controls.Add(this.metroButton10);
            this.groupBox6.Controls.Add(this.metroButton8);
            this.groupBox6.Controls.Add(this.metroButton9);
            this.groupBox6.Controls.Add(this._flashbootProgressBar);
            this.groupBox6.Location = new System.Drawing.Point(203, 282);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(643, 95);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Flash (Загрузчик)";
            // 
            // metroButton11
            // 
            this.metroButton11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton11.Location = new System.Drawing.Point(387, 7);
            this.metroButton11.Name = "metroButton11";
            this.metroButton11.Size = new System.Drawing.Size(119, 20);
            this.metroButton11.TabIndex = 5;
            this.metroButton11.Text = "Записать в устр.";
            this.metroButton11.UseSelectable = true;
            // 
            // metroButton10
            // 
            this.metroButton10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton10.Location = new System.Drawing.Point(512, 7);
            this.metroButton10.Name = "metroButton10";
            this.metroButton10.Size = new System.Drawing.Size(119, 20);
            this.metroButton10.TabIndex = 4;
            this.metroButton10.Text = "Прочитать из устр.";
            this.metroButton10.UseSelectable = true;
            // 
            // metroButton8
            // 
            this.metroButton8.Location = new System.Drawing.Point(7, 19);
            this.metroButton8.Name = "metroButton8";
            this.metroButton8.Size = new System.Drawing.Size(141, 23);
            this.metroButton8.TabIndex = 2;
            this.metroButton8.Text = "Выбрать файл";
            this.metroButton8.UseSelectable = true;
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
            // _versionLable
            // 
            this._versionLable.AutoSize = true;
            this._versionLable.Location = new System.Drawing.Point(13, 22);
            this._versionLable.Name = "_versionLable";
            this._versionLable.Size = new System.Drawing.Size(22, 13);
            this._versionLable.TabIndex = 0;
            this._versionLable.Text = "ver";
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
            // _openFileDialog
            // 
            this._openFileDialog.FileName = "openFileDialog1";
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
            // _eepromCheckBox
            // 
            this._eepromCheckBox.AutoSize = true;
            this._eepromCheckBox.Location = new System.Drawing.Point(155, 34);
            this._eepromCheckBox.Name = "_eepromCheckBox";
            this._eepromCheckBox.Size = new System.Drawing.Size(15, 14);
            this._eepromCheckBox.TabIndex = 10;
            this._eepromCheckBox.UseVisualStyleBackColor = true;
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
            // _flashCheckBox
            // 
            this._flashCheckBox.AutoSize = true;
            this._flashCheckBox.Location = new System.Drawing.Point(155, 22);
            this._flashCheckBox.Name = "_flashCheckBox";
            this._flashCheckBox.Size = new System.Drawing.Size(15, 14);
            this._flashCheckBox.TabIndex = 12;
            this._flashCheckBox.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
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
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroProgressBar _eepromProgressBar;
        private System.Windows.Forms.GroupBox groupBox5;
        private MetroFramework.Controls.MetroButton metroButton6;
        private MetroFramework.Controls.MetroButton metroButton7;
        private MetroFramework.Controls.MetroProgressBar _relayProgressBar;
        private System.Windows.Forms.GroupBox groupBox6;
        private MetroFramework.Controls.MetroButton metroButton8;
        private MetroFramework.Controls.MetroButton metroButton9;
        private MetroFramework.Controls.MetroProgressBar _flashbootProgressBar;
        private MetroFramework.Controls.MetroButton metroButton14;
        private MetroFramework.Controls.MetroButton metroButton15;
        private MetroFramework.Controls.MetroButton metroButton12;
        private MetroFramework.Controls.MetroButton metroButton13;
        private MetroFramework.Controls.MetroButton metroButton11;
        private MetroFramework.Controls.MetroButton metroButton10;
        private System.Windows.Forms.Label _fuzeLable;
        private System.Windows.Forms.Label _versionLable;
        private System.Windows.Forms.OpenFileDialog _openFileDialog;
        private System.Windows.Forms.CheckBox _workProgramCheckBox;
        private System.Windows.Forms.CheckBox _eepromCheckBox;
        private System.Windows.Forms.CheckBox _relayDiscretCheckBox;
        private System.Windows.Forms.CheckBox _flashCheckBox;
        private System.Windows.Forms.Label _moduleNameLable;
    }
}
