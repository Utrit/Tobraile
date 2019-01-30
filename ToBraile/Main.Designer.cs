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
            this.ConvertButton = new System.Windows.Forms.Button();
            this.inputw = new System.Windows.Forms.TextBox();
            this.inputh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FitCheck = new System.Windows.Forms.CheckBox();
            this.NegativeButton = new System.Windows.Forms.Button();
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
            // ConvertButton
            // 
            this.ConvertButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ConvertButton.Location = new System.Drawing.Point(7, 293);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(256, 37);
            this.ConvertButton.TabIndex = 2;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputw
            // 
            this.inputw.Location = new System.Drawing.Point(71, 271);
            this.inputw.MaxLength = 3;
            this.inputw.Name = "inputw";
            this.inputw.Size = new System.Drawing.Size(25, 20);
            this.inputw.TabIndex = 5;
            this.inputw.Text = "256";
            this.inputw.KeyUp += new System.Windows.Forms.KeyEventHandler(this.inputw_KeyUp);
            // 
            // inputh
            // 
            this.inputh.Location = new System.Drawing.Point(125, 270);
            this.inputh.MaxLength = 3;
            this.inputh.Name = "inputh";
            this.inputh.Size = new System.Drawing.Size(25, 20);
            this.inputh.TabIndex = 6;
            this.inputh.Text = "256";
            this.inputh.KeyUp += new System.Windows.Forms.KeyEventHandler(this.inputh_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 7);
            this.label1.TabIndex = 7;
            this.label1.Text = "Made by Utrit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "X";
            // 
            // FitCheck
            // 
            this.FitCheck.AutoSize = true;
            this.FitCheck.Location = new System.Drawing.Point(7, 273);
            this.FitCheck.Name = "FitCheck";
            this.FitCheck.Size = new System.Drawing.Size(58, 17);
            this.FitCheck.TabIndex = 10;
            this.FitCheck.Text = "Fit size";
            this.FitCheck.UseVisualStyleBackColor = true;
            // 
            // NegativeButton
            // 
            this.NegativeButton.Location = new System.Drawing.Point(156, 267);
            this.NegativeButton.Name = "NegativeButton";
            this.NegativeButton.Size = new System.Drawing.Size(107, 24);
            this.NegativeButton.TabIndex = 11;
            this.NegativeButton.Text = "Negative";
            this.NegativeButton.UseVisualStyleBackColor = true;
            this.NegativeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // ToBraile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 333);
            this.Controls.Add(this.NegativeButton);
            this.Controls.Add(this.FitCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputh);
            this.Controls.Add(this.inputw);
            this.Controls.Add(this.ConvertButton);
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
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.TextBox inputw;
        private System.Windows.Forms.TextBox inputh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox FitCheck;
        private System.Windows.Forms.Button NegativeButton;
    }
}

