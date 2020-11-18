namespace UDPChat
{
    partial class FormStartup
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
            this.ButtonEnter = new System.Windows.Forms.Button();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPortSend = new System.Windows.Forms.Label();
            this.labelPortReceive = new System.Windows.Forms.Label();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.numericUpDownPortSend = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPortReceive = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPortSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPortReceive)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonEnter
            // 
            this.ButtonEnter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonEnter.Location = new System.Drawing.Point(150, 84);
            this.ButtonEnter.Name = "ButtonEnter";
            this.ButtonEnter.Size = new System.Drawing.Size(75, 23);
            this.ButtonEnter.TabIndex = 3;
            this.ButtonEnter.Text = "Вход";
            this.ButtonEnter.UseVisualStyleBackColor = true;
            this.ButtonEnter.Click += new System.EventHandler(this.ButtonEnter_Click);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(85, 12);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(140, 26);
            this.textBoxLogin.TabIndex = 1;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxPassword.Location = new System.Drawing.Point(85, 44);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(140, 26);
            this.TextBoxPassword.TabIndex = 2;
            this.TextBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPassword_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // labelPortSend
            // 
            this.labelPortSend.AutoSize = true;
            this.labelPortSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPortSend.Location = new System.Drawing.Point(35, 121);
            this.labelPortSend.Name = "labelPortSend";
            this.labelPortSend.Size = new System.Drawing.Size(126, 20);
            this.labelPortSend.TabIndex = 7;
            this.labelPortSend.Text = "Порт передачи";
            // 
            // labelPortReceive
            // 
            this.labelPortReceive.AutoSize = true;
            this.labelPortReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPortReceive.Location = new System.Drawing.Point(53, 153);
            this.labelPortReceive.Name = "labelPortReceive";
            this.labelPortReceive.Size = new System.Drawing.Size(108, 20);
            this.labelPortReceive.TabIndex = 8;
            this.labelPortReceive.Text = "Порт приема";
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSettings.BackgroundImage = global::UDPChat.Properties.Resources.settingsIcon;
            this.buttonSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Location = new System.Drawing.Point(16, 80);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(30, 30);
            this.buttonSettings.TabIndex = 4;
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // numericUpDownPortSend
            // 
            this.numericUpDownPortSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownPortSend.Location = new System.Drawing.Point(167, 119);
            this.numericUpDownPortSend.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownPortSend.Name = "numericUpDownPortSend";
            this.numericUpDownPortSend.Size = new System.Drawing.Size(58, 26);
            this.numericUpDownPortSend.TabIndex = 14;
            this.numericUpDownPortSend.Value = new decimal(new int[] {
            8100,
            0,
            0,
            0});
            // 
            // numericUpDownPortReceive
            // 
            this.numericUpDownPortReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownPortReceive.Location = new System.Drawing.Point(167, 151);
            this.numericUpDownPortReceive.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownPortReceive.Name = "numericUpDownPortReceive";
            this.numericUpDownPortReceive.Size = new System.Drawing.Size(58, 26);
            this.numericUpDownPortReceive.TabIndex = 15;
            this.numericUpDownPortReceive.Value = new decimal(new int[] {
            8101,
            0,
            0,
            0});
            // 
            // FormStartup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(236, 189);
            this.Controls.Add(this.numericUpDownPortReceive);
            this.Controls.Add(this.numericUpDownPortSend);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.labelPortReceive);
            this.Controls.Add(this.labelPortSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.ButtonEnter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStartup";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.ShowInTaskbar = false;
            this.Text = "UDP";
            this.Load += new System.EventHandler(this.FormStartup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPortSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPortReceive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonEnter;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPortSend;
        private System.Windows.Forms.Label labelPortReceive;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.NumericUpDown numericUpDownPortSend;
        private System.Windows.Forms.NumericUpDown numericUpDownPortReceive;
    }
}

