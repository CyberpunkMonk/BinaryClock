namespace BinaryClock {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing&&(components!=null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.labelHours = new System.Windows.Forms.Label();
            this.labelMinutes = new System.Windows.Forms.Label();
            this.labelSeconds = new System.Windows.Forms.Label();
            this.lightsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.seconds1 = new System.Windows.Forms.Button();
            this.seconds16 = new System.Windows.Forms.Button();
            this.minutes1 = new System.Windows.Forms.Button();
            this.minutes16 = new System.Windows.Forms.Button();
            this.hours1 = new System.Windows.Forms.Button();
            this.hours16 = new System.Windows.Forms.Button();
            this.seconds2 = new System.Windows.Forms.Button();
            this.seconds32 = new System.Windows.Forms.Button();
            this.minutes2 = new System.Windows.Forms.Button();
            this.minutes32 = new System.Windows.Forms.Button();
            this.hours2 = new System.Windows.Forms.Button();
            this.hoursNULL3 = new System.Windows.Forms.Button();
            this.seconds4 = new System.Windows.Forms.Button();
            this.secondsNULL2 = new System.Windows.Forms.Button();
            this.minutes4 = new System.Windows.Forms.Button();
            this.minutesNULL2 = new System.Windows.Forms.Button();
            this.hours4 = new System.Windows.Forms.Button();
            this.hoursNULL2 = new System.Windows.Forms.Button();
            this.seconds8 = new System.Windows.Forms.Button();
            this.secondsNULL1 = new System.Windows.Forms.Button();
            this.minutes8 = new System.Windows.Forms.Button();
            this.minutesNULL1 = new System.Windows.Forms.Button();
            this.hours8 = new System.Windows.Forms.Button();
            this.hoursNULL1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lightsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Location = new System.Drawing.Point(12, 9);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(41, 13);
            this.labelHours.TabIndex = 3;
            this.labelHours.Text = "Hours: ";
            // 
            // labelMinutes
            // 
            this.labelMinutes.AutoSize = true;
            this.labelMinutes.Location = new System.Drawing.Point(59, 9);
            this.labelMinutes.Name = "labelMinutes";
            this.labelMinutes.Size = new System.Drawing.Size(50, 13);
            this.labelMinutes.TabIndex = 4;
            this.labelMinutes.Text = "Minutes: ";
            // 
            // labelSeconds
            // 
            this.labelSeconds.AutoSize = true;
            this.labelSeconds.Location = new System.Drawing.Point(115, 9);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(55, 13);
            this.labelSeconds.TabIndex = 5;
            this.labelSeconds.Text = "Seconds: ";
            // 
            // lightsPanel
            // 
            this.lightsPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.lightsPanel.ColumnCount = 6;
            this.lightsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.lightsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.lightsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.lightsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.lightsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.lightsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.lightsPanel.Controls.Add(this.seconds1, 5, 3);
            this.lightsPanel.Controls.Add(this.seconds16, 4, 3);
            this.lightsPanel.Controls.Add(this.minutes1, 3, 3);
            this.lightsPanel.Controls.Add(this.minutes16, 2, 3);
            this.lightsPanel.Controls.Add(this.hours1, 1, 3);
            this.lightsPanel.Controls.Add(this.hours16, 0, 3);
            this.lightsPanel.Controls.Add(this.seconds2, 5, 2);
            this.lightsPanel.Controls.Add(this.seconds32, 4, 2);
            this.lightsPanel.Controls.Add(this.minutes2, 3, 2);
            this.lightsPanel.Controls.Add(this.minutes32, 2, 2);
            this.lightsPanel.Controls.Add(this.hours2, 1, 2);
            this.lightsPanel.Controls.Add(this.hoursNULL3, 0, 2);
            this.lightsPanel.Controls.Add(this.seconds4, 5, 1);
            this.lightsPanel.Controls.Add(this.secondsNULL2, 4, 1);
            this.lightsPanel.Controls.Add(this.minutes4, 3, 1);
            this.lightsPanel.Controls.Add(this.minutesNULL2, 2, 1);
            this.lightsPanel.Controls.Add(this.hours4, 1, 1);
            this.lightsPanel.Controls.Add(this.hoursNULL2, 0, 1);
            this.lightsPanel.Controls.Add(this.seconds8, 5, 0);
            this.lightsPanel.Controls.Add(this.secondsNULL1, 4, 0);
            this.lightsPanel.Controls.Add(this.minutes8, 3, 0);
            this.lightsPanel.Controls.Add(this.minutesNULL1, 2, 0);
            this.lightsPanel.Controls.Add(this.hours8, 1, 0);
            this.lightsPanel.Controls.Add(this.hoursNULL1, 0, 0);
            this.lightsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lightsPanel.Location = new System.Drawing.Point(0, 92);
            this.lightsPanel.Name = "lightsPanel";
            this.lightsPanel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.lightsPanel.RowCount = 4;
            this.lightsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.lightsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.lightsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.lightsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.lightsPanel.Size = new System.Drawing.Size(284, 169);
            this.lightsPanel.TabIndex = 6;
            // 
            // seconds1
            // 
            this.seconds1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seconds1.Location = new System.Drawing.Point(230, 122);
            this.seconds1.Name = "seconds1";
            this.seconds1.Size = new System.Drawing.Size(39, 32);
            this.seconds1.TabIndex = 23;
            this.seconds1.UseVisualStyleBackColor = true;
            // 
            // seconds16
            // 
            this.seconds16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seconds16.Location = new System.Drawing.Point(187, 122);
            this.seconds16.Name = "seconds16";
            this.seconds16.Size = new System.Drawing.Size(35, 32);
            this.seconds16.TabIndex = 22;
            this.seconds16.UseVisualStyleBackColor = true;
            // 
            // minutes1
            // 
            this.minutes1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minutes1.Location = new System.Drawing.Point(144, 122);
            this.minutes1.Name = "minutes1";
            this.minutes1.Size = new System.Drawing.Size(35, 32);
            this.minutes1.TabIndex = 21;
            this.minutes1.UseVisualStyleBackColor = true;
            // 
            // minutes16
            // 
            this.minutes16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minutes16.Location = new System.Drawing.Point(101, 122);
            this.minutes16.Name = "minutes16";
            this.minutes16.Size = new System.Drawing.Size(35, 32);
            this.minutes16.TabIndex = 20;
            this.minutes16.UseVisualStyleBackColor = true;
            // 
            // hours1
            // 
            this.hours1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hours1.Location = new System.Drawing.Point(58, 122);
            this.hours1.Name = "hours1";
            this.hours1.Size = new System.Drawing.Size(35, 32);
            this.hours1.TabIndex = 19;
            this.hours1.UseVisualStyleBackColor = true;
            // 
            // hours16
            // 
            this.hours16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hours16.Location = new System.Drawing.Point(15, 122);
            this.hours16.Name = "hours16";
            this.hours16.Size = new System.Drawing.Size(35, 32);
            this.hours16.TabIndex = 18;
            this.hours16.UseVisualStyleBackColor = true;
            // 
            // seconds2
            // 
            this.seconds2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seconds2.Location = new System.Drawing.Point(230, 83);
            this.seconds2.Name = "seconds2";
            this.seconds2.Size = new System.Drawing.Size(39, 31);
            this.seconds2.TabIndex = 17;
            this.seconds2.UseVisualStyleBackColor = true;
            // 
            // seconds32
            // 
            this.seconds32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seconds32.Location = new System.Drawing.Point(187, 83);
            this.seconds32.Name = "seconds32";
            this.seconds32.Size = new System.Drawing.Size(35, 31);
            this.seconds32.TabIndex = 16;
            this.seconds32.UseVisualStyleBackColor = true;
            // 
            // minutes2
            // 
            this.minutes2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minutes2.Location = new System.Drawing.Point(144, 83);
            this.minutes2.Name = "minutes2";
            this.minutes2.Size = new System.Drawing.Size(35, 31);
            this.minutes2.TabIndex = 15;
            this.minutes2.UseVisualStyleBackColor = true;
            // 
            // minutes32
            // 
            this.minutes32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minutes32.Location = new System.Drawing.Point(101, 83);
            this.minutes32.Name = "minutes32";
            this.minutes32.Size = new System.Drawing.Size(35, 31);
            this.minutes32.TabIndex = 14;
            this.minutes32.UseVisualStyleBackColor = true;
            // 
            // hours2
            // 
            this.hours2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hours2.Location = new System.Drawing.Point(58, 83);
            this.hours2.Name = "hours2";
            this.hours2.Size = new System.Drawing.Size(35, 31);
            this.hours2.TabIndex = 13;
            this.hours2.UseVisualStyleBackColor = true;
            // 
            // hoursNULL3
            // 
            this.hoursNULL3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hoursNULL3.Location = new System.Drawing.Point(15, 83);
            this.hoursNULL3.Name = "hoursNULL3";
            this.hoursNULL3.Size = new System.Drawing.Size(35, 31);
            this.hoursNULL3.TabIndex = 12;
            this.hoursNULL3.UseVisualStyleBackColor = true;
            // 
            // seconds4
            // 
            this.seconds4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seconds4.Location = new System.Drawing.Point(230, 44);
            this.seconds4.Name = "seconds4";
            this.seconds4.Size = new System.Drawing.Size(39, 31);
            this.seconds4.TabIndex = 11;
            this.seconds4.UseVisualStyleBackColor = true;
            // 
            // secondsNULL2
            // 
            this.secondsNULL2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secondsNULL2.Location = new System.Drawing.Point(187, 44);
            this.secondsNULL2.Name = "secondsNULL2";
            this.secondsNULL2.Size = new System.Drawing.Size(35, 31);
            this.secondsNULL2.TabIndex = 10;
            this.secondsNULL2.UseVisualStyleBackColor = true;
            // 
            // minutes4
            // 
            this.minutes4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minutes4.Location = new System.Drawing.Point(144, 44);
            this.minutes4.Name = "minutes4";
            this.minutes4.Size = new System.Drawing.Size(35, 31);
            this.minutes4.TabIndex = 9;
            this.minutes4.UseVisualStyleBackColor = true;
            // 
            // minutesNULL2
            // 
            this.minutesNULL2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minutesNULL2.Location = new System.Drawing.Point(101, 44);
            this.minutesNULL2.Name = "minutesNULL2";
            this.minutesNULL2.Size = new System.Drawing.Size(35, 31);
            this.minutesNULL2.TabIndex = 8;
            this.minutesNULL2.UseVisualStyleBackColor = true;
            // 
            // hours4
            // 
            this.hours4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hours4.Location = new System.Drawing.Point(58, 44);
            this.hours4.Name = "hours4";
            this.hours4.Size = new System.Drawing.Size(35, 31);
            this.hours4.TabIndex = 7;
            this.hours4.UseVisualStyleBackColor = true;
            // 
            // hoursNULL2
            // 
            this.hoursNULL2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hoursNULL2.Location = new System.Drawing.Point(15, 44);
            this.hoursNULL2.Name = "hoursNULL2";
            this.hoursNULL2.Size = new System.Drawing.Size(35, 31);
            this.hoursNULL2.TabIndex = 6;
            this.hoursNULL2.UseVisualStyleBackColor = true;
            // 
            // seconds8
            // 
            this.seconds8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seconds8.Location = new System.Drawing.Point(230, 5);
            this.seconds8.Name = "seconds8";
            this.seconds8.Size = new System.Drawing.Size(39, 31);
            this.seconds8.TabIndex = 5;
            this.seconds8.UseVisualStyleBackColor = true;
            // 
            // secondsNULL1
            // 
            this.secondsNULL1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secondsNULL1.Location = new System.Drawing.Point(187, 5);
            this.secondsNULL1.Name = "secondsNULL1";
            this.secondsNULL1.Size = new System.Drawing.Size(35, 31);
            this.secondsNULL1.TabIndex = 4;
            this.secondsNULL1.UseVisualStyleBackColor = true;
            // 
            // minutes8
            // 
            this.minutes8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minutes8.Location = new System.Drawing.Point(144, 5);
            this.minutes8.Name = "minutes8";
            this.minutes8.Size = new System.Drawing.Size(35, 31);
            this.minutes8.TabIndex = 3;
            this.minutes8.UseVisualStyleBackColor = true;
            // 
            // minutesNULL1
            // 
            this.minutesNULL1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minutesNULL1.Location = new System.Drawing.Point(101, 5);
            this.minutesNULL1.Name = "minutesNULL1";
            this.minutesNULL1.Size = new System.Drawing.Size(35, 31);
            this.minutesNULL1.TabIndex = 2;
            this.minutesNULL1.UseVisualStyleBackColor = true;
            // 
            // hours8
            // 
            this.hours8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hours8.Location = new System.Drawing.Point(58, 5);
            this.hours8.Name = "hours8";
            this.hours8.Size = new System.Drawing.Size(35, 31);
            this.hours8.TabIndex = 1;
            this.hours8.UseVisualStyleBackColor = true;
            // 
            // hoursNULL1
            // 
            this.hoursNULL1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hoursNULL1.Location = new System.Drawing.Point(15, 5);
            this.hoursNULL1.Name = "hoursNULL1";
            this.hoursNULL1.Size = new System.Drawing.Size(35, 31);
            this.hoursNULL1.TabIndex = 0;
            this.hoursNULL1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lightsPanel);
            this.Controls.Add(this.labelSeconds);
            this.Controls.Add(this.labelMinutes);
            this.Controls.Add(this.labelHours);
            this.Name = "Form1";
            this.Text = "Binary Clock";
            this.lightsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Label labelMinutes;
        private System.Windows.Forms.Label labelSeconds;
        private System.Windows.Forms.TableLayoutPanel lightsPanel;
        private System.Windows.Forms.Button seconds1;
        private System.Windows.Forms.Button seconds16;
        private System.Windows.Forms.Button minutes1;
        private System.Windows.Forms.Button minutes16;
        private System.Windows.Forms.Button hours1;
        private System.Windows.Forms.Button hours16;
        private System.Windows.Forms.Button seconds2;
        private System.Windows.Forms.Button seconds32;
        private System.Windows.Forms.Button minutes2;
        private System.Windows.Forms.Button minutes32;
        private System.Windows.Forms.Button hours2;
        private System.Windows.Forms.Button hoursNULL3;
        private System.Windows.Forms.Button seconds4;
        private System.Windows.Forms.Button secondsNULL2;
        private System.Windows.Forms.Button minutes4;
        private System.Windows.Forms.Button minutesNULL2;
        private System.Windows.Forms.Button hours4;
        private System.Windows.Forms.Button hoursNULL2;
        private System.Windows.Forms.Button seconds8;
        private System.Windows.Forms.Button secondsNULL1;
        private System.Windows.Forms.Button minutes8;
        private System.Windows.Forms.Button minutesNULL1;
        private System.Windows.Forms.Button hours8;
        private System.Windows.Forms.Button hoursNULL1;
        private System.Windows.Forms.Timer timer1;
    }
}

