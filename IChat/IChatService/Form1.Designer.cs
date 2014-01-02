namespace IChatService
{
    partial class IChatService
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.IPtextBox = new System.Windows.Forms.TextBox();
            this.PorttextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Listeningbutton = new System.Windows.Forms.Button();
            this.ClientListcomboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MessagetextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ContenttextBox = new System.Windows.Forms.TextBox();
            this.SendContentbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ClearContentbutton = new System.Windows.Forms.Button();
            this.StopListenbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IPtextBox
            // 
            this.IPtextBox.Location = new System.Drawing.Point(38, 12);
            this.IPtextBox.Name = "IPtextBox";
            this.IPtextBox.Size = new System.Drawing.Size(100, 21);
            this.IPtextBox.TabIndex = 0;
            // 
            // PorttextBox
            // 
            this.PorttextBox.Location = new System.Drawing.Point(192, 12);
            this.PorttextBox.Name = "PorttextBox";
            this.PorttextBox.Size = new System.Drawing.Size(40, 21);
            this.PorttextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port:";
            // 
            // Listeningbutton
            // 
            this.Listeningbutton.Location = new System.Drawing.Point(248, 10);
            this.Listeningbutton.Name = "Listeningbutton";
            this.Listeningbutton.Size = new System.Drawing.Size(75, 23);
            this.Listeningbutton.TabIndex = 4;
            this.Listeningbutton.Text = "Listening";
            this.Listeningbutton.UseVisualStyleBackColor = true;
            this.Listeningbutton.Click += new System.EventHandler(this.Listeningbutton_Click);
            // 
            // ClientListcomboBox
            // 
            this.ClientListcomboBox.FormattingEnabled = true;
            this.ClientListcomboBox.Location = new System.Drawing.Point(87, 461);
            this.ClientListcomboBox.Name = "ClientListcomboBox";
            this.ClientListcomboBox.Size = new System.Drawing.Size(121, 20);
            this.ClientListcomboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "ClientList:";
            // 
            // MessagetextBox
            // 
            this.MessagetextBox.Location = new System.Drawing.Point(12, 51);
            this.MessagetextBox.Multiline = true;
            this.MessagetextBox.Name = "MessagetextBox";
            this.MessagetextBox.ReadOnly = true;
            this.MessagetextBox.Size = new System.Drawing.Size(515, 294);
            this.MessagetextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Message:";
            // 
            // ContenttextBox
            // 
            this.ContenttextBox.Location = new System.Drawing.Point(12, 363);
            this.ContenttextBox.Multiline = true;
            this.ContenttextBox.Name = "ContenttextBox";
            this.ContenttextBox.Size = new System.Drawing.Size(515, 95);
            this.ContenttextBox.TabIndex = 9;
            // 
            // SendContentbutton
            // 
            this.SendContentbutton.Location = new System.Drawing.Point(452, 459);
            this.SendContentbutton.Name = "SendContentbutton";
            this.SendContentbutton.Size = new System.Drawing.Size(75, 23);
            this.SendContentbutton.TabIndex = 10;
            this.SendContentbutton.Text = "Send";
            this.SendContentbutton.UseVisualStyleBackColor = true;
            this.SendContentbutton.Click += new System.EventHandler(this.SendContentbutton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "Content:";
            // 
            // ClearContentbutton
            // 
            this.ClearContentbutton.Location = new System.Drawing.Point(371, 459);
            this.ClearContentbutton.Name = "ClearContentbutton";
            this.ClearContentbutton.Size = new System.Drawing.Size(75, 23);
            this.ClearContentbutton.TabIndex = 12;
            this.ClearContentbutton.Text = "Clear";
            this.ClearContentbutton.UseVisualStyleBackColor = true;
            // 
            // StopListenbutton
            // 
            this.StopListenbutton.Location = new System.Drawing.Point(344, 10);
            this.StopListenbutton.Name = "StopListenbutton";
            this.StopListenbutton.Size = new System.Drawing.Size(75, 23);
            this.StopListenbutton.TabIndex = 13;
            this.StopListenbutton.Text = "StopListen";
            this.StopListenbutton.UseVisualStyleBackColor = true;
            // 
            // IChatService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 485);
            this.Controls.Add(this.StopListenbutton);
            this.Controls.Add(this.ClearContentbutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SendContentbutton);
            this.Controls.Add(this.ContenttextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MessagetextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClientListcomboBox);
            this.Controls.Add(this.Listeningbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PorttextBox);
            this.Controls.Add(this.IPtextBox);
            this.Name = "IChatService";
            this.Text = "爱聊服务中心";
            this.Load += new System.EventHandler(this.IChatService_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IPtextBox;
        private System.Windows.Forms.TextBox PorttextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Listeningbutton;
        private System.Windows.Forms.ComboBox ClientListcomboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MessagetextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ContenttextBox;
        private System.Windows.Forms.Button SendContentbutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ClearContentbutton;
        private System.Windows.Forms.Button StopListenbutton;
    }
}

