
namespace SnakeGIT
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonRight = new System.Windows.Forms.PictureBox();
            this.buttonLeft = new System.Windows.Forms.PictureBox();
            this.buttonDown = new System.Windows.Forms.PictureBox();
            this.buttonUp = new System.Windows.Forms.PictureBox();
            this.buttonD = new System.Windows.Forms.PictureBox();
            this.buttonA = new System.Windows.Forms.PictureBox();
            this.buttonS = new System.Windows.Forms.PictureBox();
            this.buttonW = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(184, 617);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 55);
            this.label2.TabIndex = 8;
            this.label2.Text = "PLAYER1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(750, 617);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 55);
            this.label3.TabIndex = 9;
            this.label3.Text = "PLAYER2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(245, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(746, 55);
            this.label4.TabIndex = 10;
            this.label4.Text = "ЗАДАЧА: НАБРАТЬ 100 ОЧКОВ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(233, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 39);
            this.label5.TabIndex = 11;
            this.label5.Text = "+1 очко";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(233, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 39);
            this.label6.TabIndex = 12;
            this.label6.Text = "+1 хп";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(233, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 39);
            this.label7.TabIndex = 13;
            this.label7.Text = "x2 скорость";
            // 
            // buttonRight
            // 
            this.buttonRight.Image = global::SnakeGIT.Properties.Resources.ArrowRightState;
            this.buttonRight.Location = new System.Drawing.Point(918, 502);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(69, 65);
            this.buttonRight.TabIndex = 21;
            this.buttonRight.TabStop = false;
            // 
            // buttonLeft
            // 
            this.buttonLeft.Image = global::SnakeGIT.Properties.Resources.ArrowLeftState;
            this.buttonLeft.Location = new System.Drawing.Point(768, 502);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(69, 65);
            this.buttonLeft.TabIndex = 20;
            this.buttonLeft.TabStop = false;
            // 
            // buttonDown
            // 
            this.buttonDown.Image = global::SnakeGIT.Properties.Resources.ArrowDownState;
            this.buttonDown.Location = new System.Drawing.Point(843, 502);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(69, 65);
            this.buttonDown.TabIndex = 19;
            this.buttonDown.TabStop = false;
            // 
            // buttonUp
            // 
            this.buttonUp.Image = global::SnakeGIT.Properties.Resources.ArrowUpState;
            this.buttonUp.Location = new System.Drawing.Point(843, 430);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(69, 66);
            this.buttonUp.TabIndex = 18;
            this.buttonUp.TabStop = false;
            // 
            // buttonD
            // 
            this.buttonD.Image = global::SnakeGIT.Properties.Resources.DState;
            this.buttonD.Location = new System.Drawing.Point(341, 502);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(69, 65);
            this.buttonD.TabIndex = 17;
            this.buttonD.TabStop = false;
            // 
            // buttonA
            // 
            this.buttonA.Image = global::SnakeGIT.Properties.Resources.AState;
            this.buttonA.Location = new System.Drawing.Point(191, 502);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(69, 65);
            this.buttonA.TabIndex = 16;
            this.buttonA.TabStop = false;
            // 
            // buttonS
            // 
            this.buttonS.Image = global::SnakeGIT.Properties.Resources.SState;
            this.buttonS.Location = new System.Drawing.Point(266, 502);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(69, 65);
            this.buttonS.TabIndex = 15;
            this.buttonS.TabStop = false;
            // 
            // buttonW
            // 
            this.buttonW.Image = global::SnakeGIT.Properties.Resources.WState;
            this.buttonW.Location = new System.Drawing.Point(266, 430);
            this.buttonW.Name = "buttonW";
            this.buttonW.Size = new System.Drawing.Size(69, 66);
            this.buttonW.TabIndex = 14;
            this.buttonW.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Purple;
            this.pictureBox5.Location = new System.Drawing.Point(133, 326);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(60, 60);
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.PowderBlue;
            this.pictureBox4.Location = new System.Drawing.Point(133, 194);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 60);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Red;
            this.pictureBox3.Location = new System.Drawing.Point(133, 260);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 60);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(428, 681);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 37);
            this.label1.TabIndex = 22;
            this.label1.Text = "Press Space to start";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1142, 737);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.buttonS);
            this.Controls.Add(this.buttonW);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Name = "Form1";
            this.Text = "v";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.buttonRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox buttonW;
        private System.Windows.Forms.PictureBox buttonS;
        private System.Windows.Forms.PictureBox buttonA;
        private System.Windows.Forms.PictureBox buttonD;
        private System.Windows.Forms.PictureBox buttonRight;
        private System.Windows.Forms.PictureBox buttonLeft;
        private System.Windows.Forms.PictureBox buttonDown;
        private System.Windows.Forms.PictureBox buttonUp;
        private System.Windows.Forms.Label label1;
    }
}

