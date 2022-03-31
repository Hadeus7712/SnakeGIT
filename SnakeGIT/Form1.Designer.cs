
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
            this.start = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.TextBox();
            this.two = new System.Windows.Forms.TextBox();
            this.one = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start.Location = new System.Drawing.Point(277, 164);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(246, 125);
            this.start.TabIndex = 0;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.SystemColors.Menu;
            this.three.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.three.ForeColor = System.Drawing.SystemColors.WindowText;
            this.three.Location = new System.Drawing.Point(369, 164);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(69, 109);
            this.three.TabIndex = 1;
            this.three.Text = "3";
            this.three.Visible = false;
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.SystemColors.Menu;
            this.two.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 102F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.two.Location = new System.Drawing.Point(369, 151);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(100, 154);
            this.two.TabIndex = 2;
            this.two.Text = "2";
            this.two.Visible = false;
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.SystemColors.Menu;
            this.one.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 122.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.one.Location = new System.Drawing.Point(369, 138);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(100, 185);
            this.one.TabIndex = 3;
            this.one.Text = "1";
            this.one.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.one);
            this.Controls.Add(this.two);
            this.Controls.Add(this.three);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox three;
        private System.Windows.Forms.TextBox two;
        private System.Windows.Forms.TextBox one;
    }
}

