
namespace Typer.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label_countMessages = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_sendingDelay = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_typingDelay = new System.Windows.Forms.NumericUpDown();
            this.button_launch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sendingDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_typingDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // label_countMessages
            // 
            this.label_countMessages.AutoSize = true;
            this.label_countMessages.Location = new System.Drawing.Point(69, 9);
            this.label_countMessages.Name = "label_countMessages";
            this.label_countMessages.Size = new System.Drawing.Size(118, 13);
            this.label_countMessages.TabIndex = 0;
            this.label_countMessages.Text = "Фраз в messages.txt - ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Задержка между отправками сообщений (мс):";
            // 
            // numericUpDown_sendingDelay
            // 
            this.numericUpDown_sendingDelay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numericUpDown_sendingDelay.Location = new System.Drawing.Point(15, 88);
            this.numericUpDown_sendingDelay.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown_sendingDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_sendingDelay.Name = "numericUpDown_sendingDelay";
            this.numericUpDown_sendingDelay.Size = new System.Drawing.Size(241, 20);
            this.numericUpDown_sendingDelay.TabIndex = 16;
            this.numericUpDown_sendingDelay.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Задержка между нажатиями клавиш (мс):";
            // 
            // numericUpDown_typingDelay
            // 
            this.numericUpDown_typingDelay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numericUpDown_typingDelay.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numericUpDown_typingDelay.Location = new System.Drawing.Point(15, 47);
            this.numericUpDown_typingDelay.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown_typingDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_typingDelay.Name = "numericUpDown_typingDelay";
            this.numericUpDown_typingDelay.Size = new System.Drawing.Size(241, 20);
            this.numericUpDown_typingDelay.TabIndex = 14;
            this.numericUpDown_typingDelay.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // button_launch
            // 
            this.button_launch.BackColor = System.Drawing.Color.White;
            this.button_launch.FlatAppearance.BorderSize = 0;
            this.button_launch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_launch.ForeColor = System.Drawing.Color.Black;
            this.button_launch.Location = new System.Drawing.Point(15, 114);
            this.button_launch.Name = "button_launch";
            this.button_launch.Size = new System.Drawing.Size(241, 23);
            this.button_launch.TabIndex = 18;
            this.button_launch.Text = "Старт";
            this.button_launch.UseVisualStyleBackColor = false;
            this.button_launch.Click += new System.EventHandler(this.button_launch_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(276, 157);
            this.Controls.Add(this.button_launch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown_sendingDelay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown_typingDelay);
            this.Controls.Add(this.label_countMessages);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Typer v";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sendingDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_typingDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_countMessages;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_sendingDelay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_typingDelay;
        private System.Windows.Forms.Button button_launch;
    }
}