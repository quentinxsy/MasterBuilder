namespace MasterBuilder
{
    partial class Form2
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
            this.TimerBox = new System.Windows.Forms.MaskedTextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CountdownBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // TimerBox
            // 
            this.TimerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerBox.Location = new System.Drawing.Point(44, 203);
            this.TimerBox.Mask = "00:00:00";
            this.TimerBox.Name = "TimerBox";
            this.TimerBox.Size = new System.Drawing.Size(110, 30);
            this.TimerBox.TabIndex = 0;
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(42, 278);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(91, 33);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(266, 278);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(91, 33);
            this.ResetButton.TabIndex = 2;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Set Timer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "(Hour/Minute/Second)";
            // 
            // CountdownBox
            // 
            this.CountdownBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CountdownBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountdownBox.Location = new System.Drawing.Point(126, 101);
            this.CountdownBox.Mask = "00:00:00";
            this.CountdownBox.Name = "CountdownBox";
            this.CountdownBox.ReadOnly = true;
            this.CountdownBox.Size = new System.Drawing.Size(190, 46);
            this.CountdownBox.TabIndex = 5;
            this.CountdownBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CountdownBox_KeyDown);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 351);
            this.Controls.Add(this.CountdownBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.TimerBox);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox TimerBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox CountdownBox;
    }
}