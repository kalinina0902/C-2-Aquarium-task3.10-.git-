namespace Aquarium_task3._10_
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.off = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.on = new System.Windows.Forms.RadioButton();
            this.temperature = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.Startwork = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temperature)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.off);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.on);
            this.groupBox1.Location = new System.Drawing.Point(1, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(75, 67);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // off
            // 
            this.off.AutoSize = true;
            this.off.Location = new System.Drawing.Point(6, 39);
            this.off.Name = "off";
            this.off.Size = new System.Drawing.Size(39, 17);
            this.off.TabIndex = 7;
            this.off.Text = "Off";
            this.off.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Освещение";
            // 
            // on
            // 
            this.on.AutoSize = true;
            this.on.Checked = true;
            this.on.Location = new System.Drawing.Point(6, 16);
            this.on.Name = "on";
            this.on.Size = new System.Drawing.Size(39, 17);
            this.on.TabIndex = 6;
            this.on.TabStop = true;
            this.on.Text = "On";
            this.on.UseVisualStyleBackColor = true;
            // 
            // temperature
            // 
            this.temperature.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.temperature.Location = new System.Drawing.Point(1, 131);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(104, 45);
            this.temperature.TabIndex = 10;
            this.temperature.Scroll += new System.EventHandler(this.temperature_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Температура:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Startwork
            // 
            this.Startwork.BackColor = System.Drawing.SystemColors.Control;
            this.Startwork.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Startwork.BackgroundImage")));
            this.Startwork.Location = new System.Drawing.Point(1, 15);
            this.Startwork.Name = "Startwork";
            this.Startwork.Size = new System.Drawing.Size(75, 23);
            this.Startwork.TabIndex = 8;
            this.Startwork.Text = "Запуск";
            this.Startwork.UseVisualStyleBackColor = false;
            this.Startwork.Click += new System.EventHandler(this.Startwork_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(832, 509);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Startwork);
            this.Controls.Add(this.temperature);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temperature)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton off;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton on;
        private System.Windows.Forms.TrackBar temperature;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Startwork;
        private System.Windows.Forms.Label label1;
    }
}

