namespace Timer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.startButton = new System.Windows.Forms.Button();
            this.countLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.exampleTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(172, 209);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(101, 29);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(169, 88);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(44, 13);
            this.countLabel.TabIndex = 1;
            this.countLabel.Text = "Counter";
            // 
            // colorLabel
            // 
            this.colorLabel.BackColor = System.Drawing.Color.White;
            this.colorLabel.Location = new System.Drawing.Point(169, 125);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(104, 23);
            this.colorLabel.TabIndex = 2;
            // 
            // timerLabel
            // 
            this.timerLabel.Location = new System.Drawing.Point(169, 162);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(280, 44);
            this.timerLabel.TabIndex = 3;
            this.timerLabel.Text = "Timer";
            // 
            // exampleTimer
            // 
            this.exampleTimer.Interval = 1000;
            this.exampleTimer.Tick += new System.EventHandler(this.exampleTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(473, 387);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Timer exampleTimer;
    }
}

