namespace автокликер
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tb_coordX = new System.Windows.Forms.TextBox();
            this.tb_coordY = new System.Windows.Forms.TextBox();
            this.lbl_coordX = new System.Windows.Forms.Label();
            this.lbl_coordY = new System.Windows.Forms.Label();
            this.panel_Сoordinates = new System.Windows.Forms.Panel();
            this.tb_coordText = new System.Windows.Forms.TextBox();
            this.panel_BasicSettings = new System.Windows.Forms.Panel();
            this.lbl_TimeCount = new System.Windows.Forms.Label();
            this.lbl_AmountOfTimeElapsed = new System.Windows.Forms.Label();
            this.lbl_TimeStopDimension = new System.Windows.Forms.Label();
            this.lbl_TimeStop = new System.Windows.Forms.Label();
            this.tb_TimeStop = new System.Windows.Forms.TextBox();
            this.tb_ClickCount = new System.Windows.Forms.TextBox();
            this.lbl_ClickCountDimension = new System.Windows.Forms.Label();
            this.lbl_ClickCount = new System.Windows.Forms.Label();
            this.lbl_ClickStopDimension = new System.Windows.Forms.Label();
            this.tb_ClickStop = new System.Windows.Forms.TextBox();
            this.lbl_ClickStop = new System.Windows.Forms.Label();
            this.lbl_ClickIntervalDimension = new System.Windows.Forms.Label();
            this.lbl_СlickInterval = new System.Windows.Forms.Label();
            this.tb_ClickInterval = new System.Windows.Forms.TextBox();
            this.tb_BasicSettingsText = new System.Windows.Forms.TextBox();
            this.panel_MouseSettings = new System.Windows.Forms.Panel();
            this.rButtonRMC = new System.Windows.Forms.RadioButton();
            this.rButtonLMC = new System.Windows.Forms.RadioButton();
            this.lbl_MouseSettings = new System.Windows.Forms.Label();
            this.panel_ButtonControl = new System.Windows.Forms.Panel();
            this.lbl_ButtonESC = new System.Windows.Forms.Label();
            this.lbl_ButtonDEL = new System.Windows.Forms.Label();
            this.cb_WindowsTop = new System.Windows.Forms.CheckBox();
            this.panel_CoordList = new System.Windows.Forms.Panel();
            this.lbl_CountPointClick = new System.Windows.Forms.Label();
            this.lbl_CountPointClickText = new System.Windows.Forms.Label();
            this.rtb_CoordList = new System.Windows.Forms.RichTextBox();
            this.tb_CoordListText = new System.Windows.Forms.TextBox();
            this.button_SaveListCoord = new System.Windows.Forms.Button();
            this.button_LoadCoord = new System.Windows.Forms.Button();
            this.button_StartClick = new System.Windows.Forms.Button();
            this.button_CloseApp = new System.Windows.Forms.Button();
            this.lbl_Null = new System.Windows.Forms.Label();
            this.panel_Сoordinates.SuspendLayout();
            this.panel_BasicSettings.SuspendLayout();
            this.panel_MouseSettings.SuspendLayout();
            this.panel_ButtonControl.SuspendLayout();
            this.panel_CoordList.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_coordX
            // 
            this.tb_coordX.Enabled = false;
            this.tb_coordX.Location = new System.Drawing.Point(95, 28);
            this.tb_coordX.Name = "tb_coordX";
            this.tb_coordX.Size = new System.Drawing.Size(100, 20);
            this.tb_coordX.TabIndex = 0;
            // 
            // tb_coordY
            // 
            this.tb_coordY.Enabled = false;
            this.tb_coordY.Location = new System.Drawing.Point(95, 54);
            this.tb_coordY.Name = "tb_coordY";
            this.tb_coordY.Size = new System.Drawing.Size(100, 20);
            this.tb_coordY.TabIndex = 1;
            // 
            // lbl_coordX
            // 
            this.lbl_coordX.AutoSize = true;
            this.lbl_coordX.Location = new System.Drawing.Point(4, 31);
            this.lbl_coordX.Name = "lbl_coordX";
            this.lbl_coordX.Size = new System.Drawing.Size(89, 13);
            this.lbl_coordX.TabIndex = 2;
            this.lbl_coordX.Text = "Координата - Х :";
            // 
            // lbl_coordY
            // 
            this.lbl_coordY.AutoSize = true;
            this.lbl_coordY.Location = new System.Drawing.Point(4, 57);
            this.lbl_coordY.Name = "lbl_coordY";
            this.lbl_coordY.Size = new System.Drawing.Size(90, 13);
            this.lbl_coordY.TabIndex = 3;
            this.lbl_coordY.Text = "Координата - У :";
            // 
            // panel_Сoordinates
            // 
            this.panel_Сoordinates.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Сoordinates.Controls.Add(this.tb_coordText);
            this.panel_Сoordinates.Controls.Add(this.lbl_coordY);
            this.panel_Сoordinates.Controls.Add(this.tb_coordY);
            this.panel_Сoordinates.Controls.Add(this.lbl_coordX);
            this.panel_Сoordinates.Controls.Add(this.tb_coordX);
            this.panel_Сoordinates.Location = new System.Drawing.Point(13, 12);
            this.panel_Сoordinates.Name = "panel_Сoordinates";
            this.panel_Сoordinates.Size = new System.Drawing.Size(205, 80);
            this.panel_Сoordinates.TabIndex = 4;
            // 
            // tb_coordText
            // 
            this.tb_coordText.Enabled = false;
            this.tb_coordText.Location = new System.Drawing.Point(3, 3);
            this.tb_coordText.Name = "tb_coordText";
            this.tb_coordText.Size = new System.Drawing.Size(192, 20);
            this.tb_coordText.TabIndex = 5;
            this.tb_coordText.Text = "Координаты";
            this.tb_coordText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel_BasicSettings
            // 
            this.panel_BasicSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_BasicSettings.Controls.Add(this.lbl_TimeCount);
            this.panel_BasicSettings.Controls.Add(this.lbl_AmountOfTimeElapsed);
            this.panel_BasicSettings.Controls.Add(this.lbl_TimeStopDimension);
            this.panel_BasicSettings.Controls.Add(this.lbl_TimeStop);
            this.panel_BasicSettings.Controls.Add(this.tb_TimeStop);
            this.panel_BasicSettings.Controls.Add(this.tb_ClickCount);
            this.panel_BasicSettings.Controls.Add(this.lbl_ClickCountDimension);
            this.panel_BasicSettings.Controls.Add(this.lbl_ClickCount);
            this.panel_BasicSettings.Controls.Add(this.lbl_ClickStopDimension);
            this.panel_BasicSettings.Controls.Add(this.tb_ClickStop);
            this.panel_BasicSettings.Controls.Add(this.lbl_ClickStop);
            this.panel_BasicSettings.Controls.Add(this.lbl_ClickIntervalDimension);
            this.panel_BasicSettings.Controls.Add(this.lbl_СlickInterval);
            this.panel_BasicSettings.Controls.Add(this.tb_ClickInterval);
            this.panel_BasicSettings.Controls.Add(this.tb_BasicSettingsText);
            this.panel_BasicSettings.Location = new System.Drawing.Point(13, 98);
            this.panel_BasicSettings.Name = "panel_BasicSettings";
            this.panel_BasicSettings.Size = new System.Drawing.Size(204, 160);
            this.panel_BasicSettings.TabIndex = 5;
            // 
            // lbl_TimeCount
            // 
            this.lbl_TimeCount.AutoSize = true;
            this.lbl_TimeCount.Location = new System.Drawing.Point(134, 137);
            this.lbl_TimeCount.Name = "lbl_TimeCount";
            this.lbl_TimeCount.Size = new System.Drawing.Size(49, 13);
            this.lbl_TimeCount.TabIndex = 15;
            this.lbl_TimeCount.Text = "00:00:00";
            // 
            // lbl_AmountOfTimeElapsed
            // 
            this.lbl_AmountOfTimeElapsed.AutoSize = true;
            this.lbl_AmountOfTimeElapsed.Location = new System.Drawing.Point(3, 137);
            this.lbl_AmountOfTimeElapsed.Name = "lbl_AmountOfTimeElapsed";
            this.lbl_AmountOfTimeElapsed.Size = new System.Drawing.Size(99, 13);
            this.lbl_AmountOfTimeElapsed.TabIndex = 14;
            this.lbl_AmountOfTimeElapsed.Text = "Времени прошло :";
            // 
            // lbl_TimeStopDimension
            // 
            this.lbl_TimeStopDimension.AutoSize = true;
            this.lbl_TimeStopDimension.Location = new System.Drawing.Point(156, 110);
            this.lbl_TimeStopDimension.Name = "lbl_TimeStopDimension";
            this.lbl_TimeStopDimension.Size = new System.Drawing.Size(37, 13);
            this.lbl_TimeStopDimension.TabIndex = 13;
            this.lbl_TimeStopDimension.Text = "минут";
            // 
            // lbl_TimeStop
            // 
            this.lbl_TimeStop.AutoSize = true;
            this.lbl_TimeStop.Location = new System.Drawing.Point(3, 110);
            this.lbl_TimeStop.Name = "lbl_TimeStop";
            this.lbl_TimeStop.Size = new System.Drawing.Size(106, 13);
            this.lbl_TimeStop.TabIndex = 12;
            this.lbl_TimeStop.Text = "Остановить после :";
            // 
            // tb_TimeStop
            // 
            this.tb_TimeStop.Location = new System.Drawing.Point(111, 107);
            this.tb_TimeStop.Name = "tb_TimeStop";
            this.tb_TimeStop.Size = new System.Drawing.Size(39, 20);
            this.tb_TimeStop.TabIndex = 11;
            // 
            // tb_ClickCount
            // 
            this.tb_ClickCount.Enabled = false;
            this.tb_ClickCount.Location = new System.Drawing.Point(111, 81);
            this.tb_ClickCount.Name = "tb_ClickCount";
            this.tb_ClickCount.Size = new System.Drawing.Size(39, 20);
            this.tb_ClickCount.TabIndex = 10;
            // 
            // lbl_ClickCountDimension
            // 
            this.lbl_ClickCountDimension.AutoSize = true;
            this.lbl_ClickCountDimension.Location = new System.Drawing.Point(153, 84);
            this.lbl_ClickCountDimension.Name = "lbl_ClickCountDimension";
            this.lbl_ClickCountDimension.Size = new System.Drawing.Size(50, 13);
            this.lbl_ClickCountDimension.TabIndex = 9;
            this.lbl_ClickCountDimension.Text = "нажатий";
            // 
            // lbl_ClickCount
            // 
            this.lbl_ClickCount.AutoSize = true;
            this.lbl_ClickCount.Location = new System.Drawing.Point(51, 84);
            this.lbl_ClickCount.Name = "lbl_ClickCount";
            this.lbl_ClickCount.Size = new System.Drawing.Size(58, 13);
            this.lbl_ClickCount.TabIndex = 7;
            this.lbl_ClickCount.Text = "Нажатий :";
            // 
            // lbl_ClickStopDimension
            // 
            this.lbl_ClickStopDimension.AutoSize = true;
            this.lbl_ClickStopDimension.Location = new System.Drawing.Point(153, 56);
            this.lbl_ClickStopDimension.Name = "lbl_ClickStopDimension";
            this.lbl_ClickStopDimension.Size = new System.Drawing.Size(50, 13);
            this.lbl_ClickStopDimension.TabIndex = 6;
            this.lbl_ClickStopDimension.Text = "нажатий";
            // 
            // tb_ClickStop
            // 
            this.tb_ClickStop.Location = new System.Drawing.Point(111, 53);
            this.tb_ClickStop.Name = "tb_ClickStop";
            this.tb_ClickStop.Size = new System.Drawing.Size(39, 20);
            this.tb_ClickStop.TabIndex = 5;
            // 
            // lbl_ClickStop
            // 
            this.lbl_ClickStop.AutoSize = true;
            this.lbl_ClickStop.Location = new System.Drawing.Point(3, 56);
            this.lbl_ClickStop.Name = "lbl_ClickStop";
            this.lbl_ClickStop.Size = new System.Drawing.Size(106, 13);
            this.lbl_ClickStop.TabIndex = 4;
            this.lbl_ClickStop.Text = "Остановить после :";
            // 
            // lbl_ClickIntervalDimension
            // 
            this.lbl_ClickIntervalDimension.AutoSize = true;
            this.lbl_ClickIntervalDimension.Location = new System.Drawing.Point(178, 32);
            this.lbl_ClickIntervalDimension.Name = "lbl_ClickIntervalDimension";
            this.lbl_ClickIntervalDimension.Size = new System.Drawing.Size(21, 13);
            this.lbl_ClickIntervalDimension.TabIndex = 3;
            this.lbl_ClickIntervalDimension.Text = "мк";
            // 
            // lbl_СlickInterval
            // 
            this.lbl_СlickInterval.AutoSize = true;
            this.lbl_СlickInterval.Location = new System.Drawing.Point(3, 32);
            this.lbl_СlickInterval.Name = "lbl_СlickInterval";
            this.lbl_СlickInterval.Size = new System.Drawing.Size(108, 13);
            this.lbl_СlickInterval.TabIndex = 2;
            this.lbl_СlickInterval.Text = "Интервал нажатий :";
            // 
            // tb_ClickInterval
            // 
            this.tb_ClickInterval.Location = new System.Drawing.Point(111, 29);
            this.tb_ClickInterval.Name = "tb_ClickInterval";
            this.tb_ClickInterval.Size = new System.Drawing.Size(61, 20);
            this.tb_ClickInterval.TabIndex = 1;
            // 
            // tb_BasicSettingsText
            // 
            this.tb_BasicSettingsText.Enabled = false;
            this.tb_BasicSettingsText.Location = new System.Drawing.Point(6, 3);
            this.tb_BasicSettingsText.Name = "tb_BasicSettingsText";
            this.tb_BasicSettingsText.Size = new System.Drawing.Size(192, 20);
            this.tb_BasicSettingsText.TabIndex = 0;
            this.tb_BasicSettingsText.Text = "Основные настройки";
            this.tb_BasicSettingsText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel_MouseSettings
            // 
            this.panel_MouseSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_MouseSettings.Controls.Add(this.rButtonRMC);
            this.panel_MouseSettings.Controls.Add(this.rButtonLMC);
            this.panel_MouseSettings.Controls.Add(this.lbl_MouseSettings);
            this.panel_MouseSettings.Location = new System.Drawing.Point(13, 264);
            this.panel_MouseSettings.Name = "panel_MouseSettings";
            this.panel_MouseSettings.Size = new System.Drawing.Size(204, 35);
            this.panel_MouseSettings.TabIndex = 6;
            // 
            // rButtonRMC
            // 
            this.rButtonRMC.AutoSize = true;
            this.rButtonRMC.Location = new System.Drawing.Point(154, 8);
            this.rButtonRMC.Name = "rButtonRMC";
            this.rButtonRMC.Size = new System.Drawing.Size(49, 17);
            this.rButtonRMC.TabIndex = 2;
            this.rButtonRMC.Text = "ПКМ";
            this.rButtonRMC.UseVisualStyleBackColor = true;
            // 
            // rButtonLMC
            // 
            this.rButtonLMC.AutoSize = true;
            this.rButtonLMC.Checked = true;
            this.rButtonLMC.Location = new System.Drawing.Point(99, 8);
            this.rButtonLMC.Name = "rButtonLMC";
            this.rButtonLMC.Size = new System.Drawing.Size(49, 17);
            this.rButtonLMC.TabIndex = 1;
            this.rButtonLMC.TabStop = true;
            this.rButtonLMC.Text = "ЛКМ";
            this.rButtonLMC.UseVisualStyleBackColor = true;
            // 
            // lbl_MouseSettings
            // 
            this.lbl_MouseSettings.AutoSize = true;
            this.lbl_MouseSettings.Location = new System.Drawing.Point(3, 10);
            this.lbl_MouseSettings.Name = "lbl_MouseSettings";
            this.lbl_MouseSettings.Size = new System.Drawing.Size(95, 13);
            this.lbl_MouseSettings.TabIndex = 0;
            this.lbl_MouseSettings.Text = "Настройки мыши";
            // 
            // panel_ButtonControl
            // 
            this.panel_ButtonControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ButtonControl.Controls.Add(this.lbl_ButtonESC);
            this.panel_ButtonControl.Controls.Add(this.lbl_ButtonDEL);
            this.panel_ButtonControl.Location = new System.Drawing.Point(13, 305);
            this.panel_ButtonControl.Name = "panel_ButtonControl";
            this.panel_ButtonControl.Size = new System.Drawing.Size(110, 55);
            this.panel_ButtonControl.TabIndex = 7;
            // 
            // lbl_ButtonESC
            // 
            this.lbl_ButtonESC.AutoSize = true;
            this.lbl_ButtonESC.Location = new System.Drawing.Point(-2, 31);
            this.lbl_ButtonESC.Name = "lbl_ButtonESC";
            this.lbl_ButtonESC.Size = new System.Drawing.Size(61, 13);
            this.lbl_ButtonESC.TabIndex = 1;
            this.lbl_ButtonESC.Text = "[ESC] Стоп";
            // 
            // lbl_ButtonDEL
            // 
            this.lbl_ButtonDEL.AutoSize = true;
            this.lbl_ButtonDEL.Location = new System.Drawing.Point(-1, 9);
            this.lbl_ButtonDEL.Name = "lbl_ButtonDEL";
            this.lbl_ButtonDEL.Size = new System.Drawing.Size(106, 13);
            this.lbl_ButtonDEL.TabIndex = 0;
            this.lbl_ButtonDEL.Text = "[DEL] Удалить лист";
            // 
            // cb_WindowsTop
            // 
            this.cb_WindowsTop.AutoSize = true;
            this.cb_WindowsTop.Location = new System.Drawing.Point(125, 315);
            this.cb_WindowsTop.Name = "cb_WindowsTop";
            this.cb_WindowsTop.Size = new System.Drawing.Size(87, 17);
            this.cb_WindowsTop.TabIndex = 8;
            this.cb_WindowsTop.Text = "Окно в топе";
            this.cb_WindowsTop.UseVisualStyleBackColor = true;
            this.cb_WindowsTop.Click += new System.EventHandler(this.checkBoxWindowsTop_Click);
            // 
            // panel_CoordList
            // 
            this.panel_CoordList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_CoordList.Controls.Add(this.lbl_CountPointClick);
            this.panel_CoordList.Controls.Add(this.lbl_CountPointClickText);
            this.panel_CoordList.Controls.Add(this.rtb_CoordList);
            this.panel_CoordList.Controls.Add(this.tb_CoordListText);
            this.panel_CoordList.Location = new System.Drawing.Point(223, 12);
            this.panel_CoordList.Name = "panel_CoordList";
            this.panel_CoordList.Size = new System.Drawing.Size(154, 298);
            this.panel_CoordList.TabIndex = 9;
            // 
            // lbl_CountPointClick
            // 
            this.lbl_CountPointClick.AutoSize = true;
            this.lbl_CountPointClick.Location = new System.Drawing.Point(114, 272);
            this.lbl_CountPointClick.Name = "lbl_CountPointClick";
            this.lbl_CountPointClick.Size = new System.Drawing.Size(13, 13);
            this.lbl_CountPointClick.TabIndex = 3;
            this.lbl_CountPointClick.Text = "0";
            // 
            // lbl_CountPointClickText
            // 
            this.lbl_CountPointClickText.AutoSize = true;
            this.lbl_CountPointClickText.Location = new System.Drawing.Point(11, 272);
            this.lbl_CountPointClickText.Name = "lbl_CountPointClickText";
            this.lbl_CountPointClickText.Size = new System.Drawing.Size(61, 13);
            this.lbl_CountPointClickText.TabIndex = 2;
            this.lbl_CountPointClickText.Text = "Значений :";
            // 
            // rtb_CoordList
            // 
            this.rtb_CoordList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtb_CoordList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_CoordList.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtb_CoordList.Location = new System.Drawing.Point(14, 39);
            this.rtb_CoordList.Name = "rtb_CoordList";
            this.rtb_CoordList.ReadOnly = true;
            this.rtb_CoordList.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.rtb_CoordList.Size = new System.Drawing.Size(126, 230);
            this.rtb_CoordList.TabIndex = 1;
            this.rtb_CoordList.Text = "";
            // 
            // tb_CoordListText
            // 
            this.tb_CoordListText.Enabled = false;
            this.tb_CoordListText.Location = new System.Drawing.Point(14, 13);
            this.tb_CoordListText.Name = "tb_CoordListText";
            this.tb_CoordListText.Size = new System.Drawing.Size(126, 20);
            this.tb_CoordListText.TabIndex = 0;
            this.tb_CoordListText.Text = "Координатный лист";
            this.tb_CoordListText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_SaveListCoord
            // 
            this.button_SaveListCoord.Location = new System.Drawing.Point(302, 345);
            this.button_SaveListCoord.Name = "button_SaveListCoord";
            this.button_SaveListCoord.Size = new System.Drawing.Size(75, 23);
            this.button_SaveListCoord.TabIndex = 10;
            this.button_SaveListCoord.Text = "Сохранить";
            this.button_SaveListCoord.UseVisualStyleBackColor = true;
            this.button_SaveListCoord.Click += new System.EventHandler(this.buttonSaveListCoord_Click);
            // 
            // button_LoadCoord
            // 
            this.button_LoadCoord.Location = new System.Drawing.Point(302, 316);
            this.button_LoadCoord.Name = "button_LoadCoord";
            this.button_LoadCoord.Size = new System.Drawing.Size(75, 23);
            this.button_LoadCoord.TabIndex = 11;
            this.button_LoadCoord.Text = "Загрузить";
            this.button_LoadCoord.UseVisualStyleBackColor = true;
            this.button_LoadCoord.Click += new System.EventHandler(this.buttonLoadCoord_Click);
            // 
            // button_StartClick
            // 
            this.button_StartClick.Location = new System.Drawing.Point(223, 316);
            this.button_StartClick.Name = "button_StartClick";
            this.button_StartClick.Size = new System.Drawing.Size(73, 23);
            this.button_StartClick.TabIndex = 12;
            this.button_StartClick.Text = "Старт";
            this.button_StartClick.UseVisualStyleBackColor = true;
            this.button_StartClick.Click += new System.EventHandler(this.buttonStartClick_Click);
            // 
            // button_CloseApp
            // 
            this.button_CloseApp.Location = new System.Drawing.Point(223, 345);
            this.button_CloseApp.Name = "button_CloseApp";
            this.button_CloseApp.Size = new System.Drawing.Size(73, 23);
            this.button_CloseApp.TabIndex = 13;
            this.button_CloseApp.Text = "Выход";
            this.button_CloseApp.UseVisualStyleBackColor = true;
            this.button_CloseApp.Click += new System.EventHandler(this.buttonCloseApp_Click);
            // 
            // lbl_Null
            // 
            this.lbl_Null.AutoSize = true;
            this.lbl_Null.Location = new System.Drawing.Point(151, 357);
            this.lbl_Null.Name = "lbl_Null";
            this.lbl_Null.Size = new System.Drawing.Size(0, 13);
            this.lbl_Null.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(388, 382);
            this.Controls.Add(this.lbl_Null);
            this.Controls.Add(this.button_CloseApp);
            this.Controls.Add(this.button_StartClick);
            this.Controls.Add(this.button_LoadCoord);
            this.Controls.Add(this.button_SaveListCoord);
            this.Controls.Add(this.panel_CoordList);
            this.Controls.Add(this.cb_WindowsTop);
            this.Controls.Add(this.panel_ButtonControl);
            this.Controls.Add(this.panel_MouseSettings);
            this.Controls.Add(this.panel_BasicSettings);
            this.Controls.Add(this.panel_Сoordinates);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(404, 421);
            this.Name = "MainForm";
            this.Text = "Автокликер";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.panel_Сoordinates.ResumeLayout(false);
            this.panel_Сoordinates.PerformLayout();
            this.panel_BasicSettings.ResumeLayout(false);
            this.panel_BasicSettings.PerformLayout();
            this.panel_MouseSettings.ResumeLayout(false);
            this.panel_MouseSettings.PerformLayout();
            this.panel_ButtonControl.ResumeLayout(false);
            this.panel_ButtonControl.PerformLayout();
            this.panel_CoordList.ResumeLayout(false);
            this.panel_CoordList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_coordX;
        private System.Windows.Forms.TextBox tb_coordY;
        private System.Windows.Forms.Label lbl_coordX;
        private System.Windows.Forms.Label lbl_coordY;
        private System.Windows.Forms.Panel panel_Сoordinates;
        private System.Windows.Forms.TextBox tb_coordText;
        private System.Windows.Forms.Panel panel_BasicSettings;
        private System.Windows.Forms.Label lbl_TimeCount;
        private System.Windows.Forms.Label lbl_AmountOfTimeElapsed;
        private System.Windows.Forms.Label lbl_TimeStopDimension;
        private System.Windows.Forms.Label lbl_TimeStop;
        private System.Windows.Forms.TextBox tb_TimeStop;
        private System.Windows.Forms.TextBox tb_ClickCount;
        private System.Windows.Forms.Label lbl_ClickCountDimension;
        private System.Windows.Forms.Label lbl_ClickCount;
        private System.Windows.Forms.Label lbl_ClickStopDimension;
        private System.Windows.Forms.TextBox tb_ClickStop;
        private System.Windows.Forms.Label lbl_ClickStop;
        private System.Windows.Forms.Label lbl_ClickIntervalDimension;
        private System.Windows.Forms.Label lbl_СlickInterval;
        private System.Windows.Forms.TextBox tb_ClickInterval;
        private System.Windows.Forms.TextBox tb_BasicSettingsText;
        private System.Windows.Forms.Panel panel_MouseSettings;
        private System.Windows.Forms.RadioButton rButtonRMC;
        private System.Windows.Forms.RadioButton rButtonLMC;
        private System.Windows.Forms.Label lbl_MouseSettings;
        private System.Windows.Forms.Panel panel_ButtonControl;
        private System.Windows.Forms.Label lbl_ButtonESC;
        private System.Windows.Forms.Label lbl_ButtonDEL;
        private System.Windows.Forms.CheckBox cb_WindowsTop;
        private System.Windows.Forms.Panel panel_CoordList;
        private System.Windows.Forms.Label lbl_CountPointClick;
        private System.Windows.Forms.Label lbl_CountPointClickText;
        private System.Windows.Forms.RichTextBox rtb_CoordList;
        private System.Windows.Forms.TextBox tb_CoordListText;
        private System.Windows.Forms.Button button_SaveListCoord;
        private System.Windows.Forms.Button button_LoadCoord;
        private System.Windows.Forms.Button button_StartClick;
        private System.Windows.Forms.Button button_CloseApp;
        private System.Windows.Forms.Label lbl_Null;
    }
}

