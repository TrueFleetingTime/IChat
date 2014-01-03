namespace IChatClient
{
    partial class Form1
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
            this.Connectbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PorttextBox = new System.Windows.Forms.TextBox();
            this.IPtextBox = new System.Windows.Forms.TextBox();
            this.ClearContentbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SendContentbutton = new System.Windows.Forms.Button();
            this.ContenttextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MessagetextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Connectbutton
            // 
            this.Connectbutton.Location = new System.Drawing.Point(241, 10);
            this.Connectbutton.Name = "Connectbutton";
            this.Connectbutton.Size = new System.Drawing.Size(75, 23);
            this.Connectbutton.TabIndex = 9;
            this.Connectbutton.Text = "Connect";
            this.Connectbutton.UseVisualStyleBackColor = true;
            this.Connectbutton.Click += new System.EventHandler(this.Connectbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "IP:";
            // 
            // PorttextBox
            // 
            this.PorttextBox.Location = new System.Drawing.Point(185, 12);
            this.PorttextBox.Name = "PorttextBox";
            this.PorttextBox.Size = new System.Drawing.Size(40, 21);
            this.PorttextBox.TabIndex = 6;
            // 
            // IPtextBox
            // 
            this.IPtextBox.Location = new System.Drawing.Point(31, 12);
            this.IPtextBox.Name = "IPtextBox";
            this.IPtextBox.Size = new System.Drawing.Size(100, 21);
            this.IPtextBox.TabIndex = 5;
            // 
            // ClearContentbutton
            // 
            this.ClearContentbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearContentbutton.Location = new System.Drawing.Point(366, 467);
            this.ClearContentbutton.Name = "ClearContentbutton";
            this.ClearContentbutton.Size = new System.Drawing.Size(75, 23);
            this.ClearContentbutton.TabIndex = 20;
            this.ClearContentbutton.Text = "Clear";
            this.ClearContentbutton.UseVisualStyleBackColor = true;
            this.ClearContentbutton.Click += new System.EventHandler(this.ClearContentbutton_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "Content:";
            // 
            // SendContentbutton
            // 
            this.SendContentbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SendContentbutton.Location = new System.Drawing.Point(447, 467);
            this.SendContentbutton.Name = "SendContentbutton";
            this.SendContentbutton.Size = new System.Drawing.Size(75, 23);
            this.SendContentbutton.TabIndex = 18;
            this.SendContentbutton.Text = "Send";
            this.SendContentbutton.UseVisualStyleBackColor = true;
            this.SendContentbutton.Click += new System.EventHandler(this.SendContentbutton_Click);
            // 
            // ContenttextBox
            // 
            this.ContenttextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ContenttextBox.Location = new System.Drawing.Point(7, 371);
            this.ContenttextBox.Multiline = true;
            this.ContenttextBox.Name = "ContenttextBox";
            this.ContenttextBox.Size = new System.Drawing.Size(515, 95);
            this.ContenttextBox.TabIndex = 17;
            this.ContenttextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ContenttextBox_KeyDown);
            this.ContenttextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ContenttextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "Message:";
            // 
            // MessagetextBox
            // 
            this.MessagetextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.MessagetextBox.Location = new System.Drawing.Point(7, 59);
            this.MessagetextBox.Multiline = true;
            this.MessagetextBox.Name = "MessagetextBox";
            this.MessagetextBox.ReadOnly = true;
            this.MessagetextBox.Size = new System.Drawing.Size(515, 294);
            this.MessagetextBox.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 491);
            this.Controls.Add(this.ClearContentbutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SendContentbutton);
            this.Controls.Add(this.ContenttextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MessagetextBox);
            this.Controls.Add(this.Connectbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PorttextBox);
            this.Controls.Add(this.IPtextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connectbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PorttextBox;
        private System.Windows.Forms.TextBox IPtextBox;
        private System.Windows.Forms.Button ClearContentbutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SendContentbutton;
        private System.Windows.Forms.TextBox ContenttextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MessagetextBox;
    }
}

