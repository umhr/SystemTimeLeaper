namespace TimeShift
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.yearIncriment = new System.Windows.Forms.Button();
            this.yearDecrement = new System.Windows.Forms.Button();
            this.monthIncriment = new System.Windows.Forms.Button();
            this.monthDecrement = new System.Windows.Forms.Button();
            this.daysIncriment = new System.Windows.Forms.Button();
            this.daysDecrement = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button2 = new System.Windows.Forms.Button();
            this.ntp_button = new System.Windows.Forms.Button();
            this.hourIncriment = new System.Windows.Forms.Button();
            this.timeTB = new System.Windows.Forms.TextBox();
            this.hourDecrement = new System.Windows.Forms.Button();
            this.minuteIncriment = new System.Windows.Forms.Button();
            this.minuteDecrement = new System.Windows.Forms.Button();
            this.secIncriment = new System.Windows.Forms.Button();
            this.secDecrement = new System.Windows.Forms.Button();
            this.epochsec = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.randomButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "適用";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // yearIncriment
            // 
            this.yearIncriment.Location = new System.Drawing.Point(243, 10);
            this.yearIncriment.Name = "yearIncriment";
            this.yearIncriment.Size = new System.Drawing.Size(36, 23);
            this.yearIncriment.TabIndex = 2;
            this.yearIncriment.Text = "年+";
            this.yearIncriment.UseVisualStyleBackColor = true;
            this.yearIncriment.Click += new System.EventHandler(this.yearIncriment_Click);
            // 
            // yearDecrement
            // 
            this.yearDecrement.Location = new System.Drawing.Point(243, 39);
            this.yearDecrement.Name = "yearDecrement";
            this.yearDecrement.Size = new System.Drawing.Size(36, 23);
            this.yearDecrement.TabIndex = 3;
            this.yearDecrement.Text = "年-";
            this.yearDecrement.UseVisualStyleBackColor = true;
            this.yearDecrement.Click += new System.EventHandler(this.yearDecrement_Click);
            // 
            // monthIncriment
            // 
            this.monthIncriment.Location = new System.Drawing.Point(285, 10);
            this.monthIncriment.Name = "monthIncriment";
            this.monthIncriment.Size = new System.Drawing.Size(36, 23);
            this.monthIncriment.TabIndex = 4;
            this.monthIncriment.Text = "月+";
            this.monthIncriment.UseVisualStyleBackColor = true;
            this.monthIncriment.Click += new System.EventHandler(this.monthIncriment_Click);
            // 
            // monthDecrement
            // 
            this.monthDecrement.Location = new System.Drawing.Point(285, 39);
            this.monthDecrement.Name = "monthDecrement";
            this.monthDecrement.Size = new System.Drawing.Size(36, 23);
            this.monthDecrement.TabIndex = 5;
            this.monthDecrement.Text = "月-";
            this.monthDecrement.UseVisualStyleBackColor = true;
            this.monthDecrement.Click += new System.EventHandler(this.monthDecrement_Click);
            // 
            // daysIncriment
            // 
            this.daysIncriment.Location = new System.Drawing.Point(327, 10);
            this.daysIncriment.Name = "daysIncriment";
            this.daysIncriment.Size = new System.Drawing.Size(36, 23);
            this.daysIncriment.TabIndex = 6;
            this.daysIncriment.Text = "日+";
            this.daysIncriment.UseVisualStyleBackColor = true;
            this.daysIncriment.Click += new System.EventHandler(this.daysIncriment_Click);
            // 
            // daysDecrement
            // 
            this.daysDecrement.Location = new System.Drawing.Point(327, 39);
            this.daysDecrement.Name = "daysDecrement";
            this.daysDecrement.Size = new System.Drawing.Size(36, 23);
            this.daysDecrement.TabIndex = 7;
            this.daysDecrement.Text = "日-";
            this.daysDecrement.UseVisualStyleBackColor = true;
            this.daysDecrement.Click += new System.EventHandler(this.daysDecrement_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(10, 10);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "次の閏日";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ntp_button
            // 
            this.ntp_button.Location = new System.Drawing.Point(10, 277);
            this.ntp_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ntp_button.Name = "ntp_button";
            this.ntp_button.Size = new System.Drawing.Size(112, 23);
            this.ntp_button.TabIndex = 11;
            this.ntp_button.Text = "NTPサーバから取得";
            this.ntp_button.UseVisualStyleBackColor = true;
            this.ntp_button.Click += new System.EventHandler(this.ntp_button_Click);
            // 
            // hourIncriment
            // 
            this.hourIncriment.Location = new System.Drawing.Point(369, 10);
            this.hourIncriment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hourIncriment.Name = "hourIncriment";
            this.hourIncriment.Size = new System.Drawing.Size(36, 23);
            this.hourIncriment.TabIndex = 12;
            this.hourIncriment.Text = "時+";
            this.hourIncriment.UseVisualStyleBackColor = true;
            this.hourIncriment.Click += new System.EventHandler(this.hourIncriment_Click);
            // 
            // timeTB
            // 
            this.timeTB.Location = new System.Drawing.Point(316, 150);
            this.timeTB.Name = "timeTB";
            this.timeTB.Size = new System.Drawing.Size(80, 19);
            this.timeTB.TabIndex = 13;
            this.timeTB.TextChanged += new System.EventHandler(this.timeTB_TextChanged);
            // 
            // hourDecrement
            // 
            this.hourDecrement.Location = new System.Drawing.Point(369, 39);
            this.hourDecrement.Name = "hourDecrement";
            this.hourDecrement.Size = new System.Drawing.Size(36, 23);
            this.hourDecrement.TabIndex = 14;
            this.hourDecrement.Text = "時-";
            this.hourDecrement.UseVisualStyleBackColor = true;
            this.hourDecrement.Click += new System.EventHandler(this.hourDecrement_Click);
            // 
            // minuteIncriment
            // 
            this.minuteIncriment.Location = new System.Drawing.Point(411, 10);
            this.minuteIncriment.Name = "minuteIncriment";
            this.minuteIncriment.Size = new System.Drawing.Size(36, 23);
            this.minuteIncriment.TabIndex = 15;
            this.minuteIncriment.Text = "分+";
            this.minuteIncriment.UseVisualStyleBackColor = true;
            this.minuteIncriment.Click += new System.EventHandler(this.minuteIncriment_Click);
            // 
            // minuteDecrement
            // 
            this.minuteDecrement.Location = new System.Drawing.Point(411, 38);
            this.minuteDecrement.Name = "minuteDecrement";
            this.minuteDecrement.Size = new System.Drawing.Size(36, 23);
            this.minuteDecrement.TabIndex = 16;
            this.minuteDecrement.Text = "分-";
            this.minuteDecrement.UseVisualStyleBackColor = true;
            this.minuteDecrement.Click += new System.EventHandler(this.minuteDecrement_Click);
            // 
            // secIncriment
            // 
            this.secIncriment.Location = new System.Drawing.Point(453, 10);
            this.secIncriment.Name = "secIncriment";
            this.secIncriment.Size = new System.Drawing.Size(36, 23);
            this.secIncriment.TabIndex = 17;
            this.secIncriment.Text = "秒+";
            this.secIncriment.UseVisualStyleBackColor = true;
            this.secIncriment.Click += new System.EventHandler(this.secIncriment_Click);
            // 
            // secDecrement
            // 
            this.secDecrement.Location = new System.Drawing.Point(453, 39);
            this.secDecrement.Name = "secDecrement";
            this.secDecrement.Size = new System.Drawing.Size(36, 23);
            this.secDecrement.TabIndex = 18;
            this.secDecrement.Text = "秒-";
            this.secDecrement.UseVisualStyleBackColor = true;
            this.secDecrement.Click += new System.EventHandler(this.secDecrement_Click);
            // 
            // epochsec
            // 
            this.epochsec.AutoSize = true;
            this.epochsec.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.epochsec.Location = new System.Drawing.Point(284, 172);
            this.epochsec.Name = "epochsec";
            this.epochsec.Size = new System.Drawing.Size(35, 12);
            this.epochsec.TabIndex = 19;
            this.epochsec.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "時刻:";
            // 
            // randomButton
            // 
            this.randomButton.Location = new System.Drawing.Point(10, 220);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(112, 23);
            this.randomButton.TabIndex = 21;
            this.randomButton.Text = "ランダム（未来10年）";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(241, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 312);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.randomButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.epochsec);
            this.Controls.Add(this.secDecrement);
            this.Controls.Add(this.secIncriment);
            this.Controls.Add(this.minuteDecrement);
            this.Controls.Add(this.minuteIncriment);
            this.Controls.Add(this.hourDecrement);
            this.Controls.Add(this.timeTB);
            this.Controls.Add(this.hourIncriment);
            this.Controls.Add(this.ntp_button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.daysDecrement);
            this.Controls.Add(this.daysIncriment);
            this.Controls.Add(this.monthDecrement);
            this.Controls.Add(this.monthIncriment);
            this.Controls.Add(this.yearDecrement);
            this.Controls.Add(this.yearIncriment);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "SystemTimeLeaper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button yearIncriment;
        private System.Windows.Forms.Button yearDecrement;
        private System.Windows.Forms.Button monthIncriment;
        private System.Windows.Forms.Button monthDecrement;
        private System.Windows.Forms.Button daysIncriment;
        private System.Windows.Forms.Button daysDecrement;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ntp_button;
        private System.Windows.Forms.Button hourIncriment;
        private System.Windows.Forms.TextBox timeTB;
        private System.Windows.Forms.Button hourDecrement;
        private System.Windows.Forms.Button minuteIncriment;
        private System.Windows.Forms.Button minuteDecrement;
        private System.Windows.Forms.Button secIncriment;
        private System.Windows.Forms.Button secDecrement;
        private System.Windows.Forms.Label epochsec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.Label label2;
    }
}

