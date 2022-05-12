
namespace Kurs_Interfeces
{
    partial class mainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.panelLogin = new System.Windows.Forms.Panel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.login_label = new System.Windows.Forms.Label();
            this.buttonChangeUser = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.MapBox = new System.Windows.Forms.PictureBox();
            this.contextMenuStripMap = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.labelAddTraficLights = new System.Windows.Forms.Label();
            this.panelMap = new System.Windows.Forms.Panel();
            this.buttonSaveUsers = new System.Windows.Forms.Button();
            this.buttonSaveTraficLights = new System.Windows.Forms.Button();
            this.timerTraficLights = new System.Windows.Forms.Timer(this.components);
            this.buttonTimer = new System.Windows.Forms.Button();
            this.contextMenuStripTraficLight = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemChange = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.labelChangeDelete = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MapBox)).BeginInit();
            this.contextMenuStripMap.SuspendLayout();
            this.panelMap.SuspendLayout();
            this.contextMenuStripTraficLight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.textBoxPassword);
            this.panelLogin.Controls.Add(this.password_label);
            this.panelLogin.Controls.Add(this.textBoxLogin);
            this.panelLogin.Controls.Add(this.login_label);
            this.panelLogin.Location = new System.Drawing.Point(1230, 12);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(114, 135);
            this.panelLogin.TabIndex = 0;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(7, 99);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 23);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Войти";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(7, 64);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(7, 48);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(45, 13);
            this.password_label.TabIndex = 2;
            this.password_label.Text = "Пароль";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(7, 21);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxLogin.TabIndex = 1;
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Location = new System.Drawing.Point(4, 4);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(38, 13);
            this.login_label.TabIndex = 0;
            this.login_label.Text = "Логин";
            // 
            // buttonChangeUser
            // 
            this.buttonChangeUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChangeUser.Location = new System.Drawing.Point(1236, 20);
            this.buttonChangeUser.Name = "buttonChangeUser";
            this.buttonChangeUser.Size = new System.Drawing.Size(100, 43);
            this.buttonChangeUser.TabIndex = 5;
            this.buttonChangeUser.Text = "Сменить пользователя";
            this.buttonChangeUser.UseVisualStyleBackColor = true;
            this.buttonChangeUser.Visible = false;
            this.buttonChangeUser.Click += new System.EventHandler(this.buttonChangeUser_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddUser.Location = new System.Drawing.Point(1237, 156);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(100, 43);
            this.buttonAddUser.TabIndex = 7;
            this.buttonAddUser.Text = "Добавить пользователя";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Visible = false;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // MapBox
            // 
            this.MapBox.BackColor = System.Drawing.SystemColors.Window;
            this.MapBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MapBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MapBox.ContextMenuStrip = this.contextMenuStripMap;
            this.MapBox.Image = ((System.Drawing.Image)(resources.GetObject("MapBox.Image")));
            this.MapBox.Location = new System.Drawing.Point(0, 0);
            this.MapBox.Name = "MapBox";
            this.MapBox.Size = new System.Drawing.Size(1302, 1176);
            this.MapBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.MapBox.TabIndex = 8;
            this.MapBox.TabStop = false;
            // 
            // contextMenuStripMap
            // 
            this.contextMenuStripMap.Enabled = false;
            this.contextMenuStripMap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAdd});
            this.contextMenuStripMap.Name = "contextMenuStripMap";
            this.contextMenuStripMap.Size = new System.Drawing.Size(215, 26);
            // 
            // toolStripMenuItemAdd
            // 
            this.toolStripMenuItemAdd.Enabled = false;
            this.toolStripMenuItemAdd.Name = "toolStripMenuItemAdd";
            this.toolStripMenuItemAdd.Size = new System.Drawing.Size(214, 22);
            this.toolStripMenuItemAdd.Text = "Добавить светофор здесь";
            this.toolStripMenuItemAdd.Click += new System.EventHandler(this.toolStripMenuItemAdd_Click);
            // 
            // labelAddTraficLights
            // 
            this.labelAddTraficLights.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAddTraficLights.AutoSize = true;
            this.labelAddTraficLights.Location = new System.Drawing.Point(1234, 206);
            this.labelAddTraficLights.Name = "labelAddTraficLights";
            this.labelAddTraficLights.Size = new System.Drawing.Size(100, 91);
            this.labelAddTraficLights.TabIndex = 9;
            this.labelAddTraficLights.Text = "Для добавления \r\nнового светофора\r\nнажмите ПКМ\r\nна карте\r\nи выберите пункт\r\n\"Доба" +
    "вить новый \r\nсветофор\"";
            this.labelAddTraficLights.Visible = false;
            // 
            // panelMap
            // 
            this.panelMap.AutoScroll = true;
            this.panelMap.Controls.Add(this.MapBox);
            this.panelMap.Location = new System.Drawing.Point(13, 12);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(1210, 705);
            this.panelMap.TabIndex = 10;
            // 
            // buttonSaveUsers
            // 
            this.buttonSaveUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveUsers.Location = new System.Drawing.Point(1237, 402);
            this.buttonSaveUsers.Name = "buttonSaveUsers";
            this.buttonSaveUsers.Size = new System.Drawing.Size(100, 43);
            this.buttonSaveUsers.TabIndex = 11;
            this.buttonSaveUsers.Text = "Сохранить пользователей";
            this.buttonSaveUsers.UseVisualStyleBackColor = true;
            this.buttonSaveUsers.Visible = false;
            this.buttonSaveUsers.Click += new System.EventHandler(this.buttonSaveUsers_Click);
            // 
            // buttonSaveTraficLights
            // 
            this.buttonSaveTraficLights.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveTraficLights.Location = new System.Drawing.Point(1237, 451);
            this.buttonSaveTraficLights.Name = "buttonSaveTraficLights";
            this.buttonSaveTraficLights.Size = new System.Drawing.Size(100, 43);
            this.buttonSaveTraficLights.TabIndex = 12;
            this.buttonSaveTraficLights.Text = "Сохранить светофоры";
            this.buttonSaveTraficLights.UseVisualStyleBackColor = true;
            this.buttonSaveTraficLights.Visible = false;
            this.buttonSaveTraficLights.Click += new System.EventHandler(this.buttonSaveTraficLights_Click);
            // 
            // timerTraficLights
            // 
            this.timerTraficLights.Interval = 1000;
            this.timerTraficLights.Tick += new System.EventHandler(this.timerTraficLights_Tick);
            // 
            // buttonTimer
            // 
            this.buttonTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTimer.Location = new System.Drawing.Point(1237, 500);
            this.buttonTimer.Name = "buttonTimer";
            this.buttonTimer.Size = new System.Drawing.Size(100, 43);
            this.buttonTimer.TabIndex = 13;
            this.buttonTimer.Text = "Выключить таймер";
            this.buttonTimer.UseVisualStyleBackColor = true;
            this.buttonTimer.Visible = false;
            this.buttonTimer.Click += new System.EventHandler(this.buttonTimer_Click);
            // 
            // contextMenuStripTraficLight
            // 
            this.contextMenuStripTraficLight.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemChange,
            this.toolStripMenuItemDelete});
            this.contextMenuStripTraficLight.Name = "contextMenuStripTraficLight";
            this.contextMenuStripTraficLight.Size = new System.Drawing.Size(235, 48);
            // 
            // toolStripMenuItemChange
            // 
            this.toolStripMenuItemChange.Enabled = false;
            this.toolStripMenuItemChange.Name = "toolStripMenuItemChange";
            this.toolStripMenuItemChange.Size = new System.Drawing.Size(234, 22);
            this.toolStripMenuItemChange.Text = "Изменить данные светофора";
            this.toolStripMenuItemChange.Click += new System.EventHandler(this.toolStripMenuItemChange_Click);
            // 
            // toolStripMenuItemDelete
            // 
            this.toolStripMenuItemDelete.Enabled = false;
            this.toolStripMenuItemDelete.Name = "toolStripMenuItemDelete";
            this.toolStripMenuItemDelete.Size = new System.Drawing.Size(234, 22);
            this.toolStripMenuItemDelete.Text = "Удалить светофор";
            this.toolStripMenuItemDelete.Click += new System.EventHandler(this.toolStripMenuItemDelete_Click);
            // 
            // labelChangeDelete
            // 
            this.labelChangeDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelChangeDelete.AutoSize = true;
            this.labelChangeDelete.Location = new System.Drawing.Point(1234, 303);
            this.labelChangeDelete.Name = "labelChangeDelete";
            this.labelChangeDelete.Size = new System.Drawing.Size(97, 91);
            this.labelChangeDelete.TabIndex = 14;
            this.labelChangeDelete.Text = "Для изменения\r\nили удаления\r\nсветофора\r\nвыберите его\r\nЛКМ или ПКМ\r\nи нажмите ПКМ\r" +
    "\nдля вызова меню";
            this.labelChangeDelete.Visible = false;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1352, 729);
            this.Controls.Add(this.labelChangeDelete);
            this.Controls.Add(this.buttonTimer);
            this.Controls.Add(this.buttonSaveTraficLights);
            this.Controls.Add(this.buttonSaveUsers);
            this.Controls.Add(this.panelMap);
            this.Controls.Add(this.labelAddTraficLights);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.buttonChangeUser);
            this.Name = "mainWindow";
            this.Text = "Работа с светофорами";
            this.ResizeBegin += new System.EventHandler(this.mainWindow_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.mainWindow_ResizeEnd);
            this.Resize += new System.EventHandler(this.mainWindow_Resize);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MapBox)).EndInit();
            this.contextMenuStripMap.ResumeLayout(false);
            this.panelMap.ResumeLayout(false);
            this.panelMap.PerformLayout();
            this.contextMenuStripTraficLight.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonChangeUser;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Label labelAddTraficLights;
        public System.Windows.Forms.PictureBox MapBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMap;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdd;
        public System.Windows.Forms.Panel panelMap;
        private System.Windows.Forms.Button buttonSaveUsers;
        private System.Windows.Forms.Button buttonSaveTraficLights;
        private System.Windows.Forms.Timer timerTraficLights;
        private System.Windows.Forms.Button buttonTimer;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemChange;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelete;
        public System.Windows.Forms.ContextMenuStrip contextMenuStripTraficLight;
        private System.Windows.Forms.Label labelChangeDelete;
    }
}

