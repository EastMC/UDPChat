namespace UDPChat
{
    partial class Chat
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
            this.TextBoxViewHistory = new System.Windows.Forms.TextBox();
            this.TextBoxMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextBoxViewHistory
            // 
            this.TextBoxViewHistory.AcceptsReturn = true;
            this.TextBoxViewHistory.BackColor = System.Drawing.Color.White;
            this.TextBoxViewHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxViewHistory.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxViewHistory.Location = new System.Drawing.Point(0, 0);
            this.TextBoxViewHistory.Multiline = true;
            this.TextBoxViewHistory.Name = "TextBoxViewHistory";
            this.TextBoxViewHistory.ReadOnly = true;
            this.TextBoxViewHistory.Size = new System.Drawing.Size(464, 327);
            this.TextBoxViewHistory.TabIndex = 0;
            // 
            // TextBoxMessage
            // 
            this.TextBoxMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TextBoxMessage.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxMessage.Location = new System.Drawing.Point(0, 304);
            this.TextBoxMessage.Name = "TextBoxMessage";
            this.TextBoxMessage.Size = new System.Drawing.Size(464, 23);
            this.TextBoxMessage.TabIndex = 1;
            this.TextBoxMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxMessage_KeyPress);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 327);
            this.Controls.Add(this.TextBoxMessage);
            this.Controls.Add(this.TextBoxViewHistory);
            this.Name = "Chat";
            this.ShowIcon = false;
            this.Text = "UDP";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Chat_FormClosed);
            this.Load += new System.EventHandler(this.Chat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxViewHistory;
        private System.Windows.Forms.TextBox TextBoxMessage;
    }
}