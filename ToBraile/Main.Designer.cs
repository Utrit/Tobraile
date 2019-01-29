namespace ToBraile
{
    partial class ToBraile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToBraile));
            this.DargNDropPicBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.inputw = new System.Windows.Forms.TextBox();
            this.inputh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DargNDropPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DargNDropPicBox
            // 
            this.DargNDropPicBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.DargNDropPicBox.Image = ((System.Drawing.Image)(resources.GetObject("DargNDropPicBox.Image")));
            this.DargNDropPicBox.Location = new System.Drawing.Point(7, 10);
            this.DargNDropPicBox.Name = "DargNDropPicBox";
            this.DargNDropPicBox.Size = new System.Drawing.Size(256, 256);
            this.DargNDropPicBox.TabIndex = 0;
            this.DargNDropPicBox.TabStop = false;
            this.DargNDropPicBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.DargNDropPicBox_DragDrop);
            this.DargNDropPicBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.DargNDropPicBox_DragEnter);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Location = new System.Drawing.Point(7, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(177, 274);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(72, 17);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "4x2 Braile";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // inputw
            // 
            this.inputw.Location = new System.Drawing.Point(57, 271);
            this.inputw.MaxLength = 3;
            this.inputw.Name = "inputw";
            this.inputw.Size = new System.Drawing.Size(44, 20);
            this.inputw.TabIndex = 5;
            this.inputw.Text = "256";
            this.inputw.KeyUp += new System.Windows.Forms.KeyEventHandler(this.inputw_KeyUp);
            // 
            // inputh
            // 
            this.inputh.Location = new System.Drawing.Point(127, 272);
            this.inputh.MaxLength = 3;
            this.inputh.Name = "inputh";
            this.inputh.Size = new System.Drawing.Size(44, 20);
            this.inputh.TabIndex = 6;
            this.inputh.Text = "256";
            this.inputh.KeyUp += new System.Windows.Forms.KeyEventHandler(this.inputh_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(4, -6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Made by Utrit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fit size";
            // 
            // ToBraile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 333);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputh);
            this.Controls.Add(this.inputw);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DargNDropPicBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ToBraile";
            this.Text = "ToBraile";
            ((System.ComponentModel.ISupportInitialize)(this.DargNDropPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DargNDropPicBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox inputw;
        private System.Windows.Forms.TextBox inputh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

