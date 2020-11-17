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
            this.textBoxPortSend = new System.Windows.Forms.TextBox();
            this.textBoxPortReceive = new System.Windows.Forms.TextBox();
            this.labelPortSend = new System.Windows.Forms.Label();
            this.labelPortReceive = new System.Windows.Forms.Label();
            this.textBoxLANNet = new System.Windows.Forms.TextBox();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.textBoxLANMask = new System.Windows.Forms.TextBox();
            this.labelLANParams = new System.Windows.Forms.Label();
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
            // textBoxPortSend
            // 
            this.textBoxPortSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPortSend.Location = new System.Drawing.Point(167, 118);
            this.textBoxPortSend.Name = "textBoxPortSend";
            this.textBoxPortSend.Size = new System.Drawing.Size(58, 26);
            this.textBoxPortSend.TabIndex = 5;
            this.textBoxPortSend.Text = "8020";
            // 
            // textBoxPortReceive
            // 
            this.textBoxPortReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPortReceive.Location = new System.Drawing.Point(167, 150);
            this.textBoxPortReceive.Name = "textBoxPortReceive";
            this.textBoxPortReceive.Size = new System.Drawing.Size(58, 26);
            this.textBoxPortReceive.TabIndex = 6;
            this.textBoxPortReceive.Text = "8030";
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
            // textBoxLANNet
            // 
            this.textBoxLANNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLANNet.Location = new System.Drawing.Point(16, 209);
            this.textBoxLANNet.Name = "textBoxLANNet";
            this.textBoxLANNet.Size = new System.Drawing.Size(136, 26);
            this.textBoxLANNet.TabIndex = 7;
            this.textBoxLANNet.Text = "10.0.251.0";
            this.textBoxLANNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // textBoxLANMask
            // 
            this.textBoxLANMask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLANMask.Location = new System.Drawing.Point(167, 209);
            this.textBoxLANMask.Name = "textBoxLANMask";
            this.textBoxLANMask.Size = new System.Drawing.Size(43, 26);
            this.textBoxLANMask.TabIndex = 8;
            this.textBoxLANMask.Text = "24";
            // 
            // labelLANParams
            // 
            this.labelLANParams.AutoSize = true;
            this.labelLANParams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLANParams.Location = new System.Drawing.Point(3, 186);
            this.labelLANParams.Name = "labelLANParams";
            this.labelLANParams.Size = new System.Drawing.Size(222, 20);
            this.labelLANParams.TabIndex = 12;
            this.labelLANParams.Text = "Параметры локальной сети";
            // 
            // FormStartup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(236, 258);
            this.Controls.Add(this.labelLANParams);
            this.Controls.Add(this.textBoxLANMask);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.textBoxLANNet);
            this.Controls.Add(this.labelPortReceive);
            this.Controls.Add(this.labelPortSend);
            this.Controls.Add(this.textBoxPortReceive);
            this.Controls.Add(this.textBoxPortSend);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonEnter;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPortSend;
        private System.Windows.Forms.TextBox textBoxPortReceive;
        private System.Windows.Forms.Label labelPortSend;
        private System.Windows.Forms.Label labelPortReceive;
        private System.Windows.Forms.TextBox textBoxLANNet;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.TextBox textBoxLANMask;
        private System.Windows.Forms.Label labelLANParams;
    }
}

