
namespace BMPtoCcode
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
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.OpenFile = new System.Windows.Forms.Button();
            this.Convert = new System.Windows.Forms.Button();
            this.BMPaddressTextBox = new System.Windows.Forms.TextBox();
            this.OpenFont = new System.Windows.Forms.Button();
            this.FontAddressTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FontSizeCombo = new System.Windows.Forms.ComboBox();
            this.ConvertFontBtn = new System.Windows.Forms.Button();
            this.OutFormatComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "BMPFile";
            this.OpenFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // OpenFile
            // 
            this.OpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenFile.Location = new System.Drawing.Point(13, 20);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(111, 26);
            this.OpenFile.TabIndex = 0;
            this.OpenFile.Text = "Open BMP";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // Convert
            // 
            this.Convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Convert.Location = new System.Drawing.Point(311, 52);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(148, 26);
            this.Convert.TabIndex = 1;
            this.Convert.Text = "Convert BMP";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // BMPaddressTextBox
            // 
            this.BMPaddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BMPaddressTextBox.Location = new System.Drawing.Point(129, 22);
            this.BMPaddressTextBox.Name = "BMPaddressTextBox";
            this.BMPaddressTextBox.Size = new System.Drawing.Size(330, 24);
            this.BMPaddressTextBox.TabIndex = 2;
            this.BMPaddressTextBox.TextChanged += new System.EventHandler(this.addressTextBox_TextChanged);
            // 
            // OpenFont
            // 
            this.OpenFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenFont.Location = new System.Drawing.Point(13, 84);
            this.OpenFont.Name = "OpenFont";
            this.OpenFont.Size = new System.Drawing.Size(111, 26);
            this.OpenFont.TabIndex = 3;
            this.OpenFont.Text = "Open Font";
            this.OpenFont.UseVisualStyleBackColor = true;
            this.OpenFont.Click += new System.EventHandler(this.OpenFont_Click);
            // 
            // FontAddressTextBox
            // 
            this.FontAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FontAddressTextBox.Location = new System.Drawing.Point(130, 84);
            this.FontAddressTextBox.Name = "FontAddressTextBox";
            this.FontAddressTextBox.Size = new System.Drawing.Size(330, 24);
            this.FontAddressTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Font size, px:";
            // 
            // FontSizeCombo
            // 
            this.FontSizeCombo.FormattingEnabled = true;
            this.FontSizeCombo.Items.AddRange(new object[] {
            "8",
            "10",
            "11",
            "12",
            "14",
            "16",
            "20",
            "24",
            "30",
            "40"});
            this.FontSizeCombo.Location = new System.Drawing.Point(129, 124);
            this.FontSizeCombo.Name = "FontSizeCombo";
            this.FontSizeCombo.Size = new System.Drawing.Size(65, 21);
            this.FontSizeCombo.TabIndex = 6;
            this.FontSizeCombo.SelectedIndexChanged += new System.EventHandler(this.FontSizeCombo_SelectedIndexChanged);
            // 
            // ConvertFontBtn
            // 
            this.ConvertFontBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConvertFontBtn.Location = new System.Drawing.Point(311, 119);
            this.ConvertFontBtn.Name = "ConvertFontBtn";
            this.ConvertFontBtn.Size = new System.Drawing.Size(148, 26);
            this.ConvertFontBtn.TabIndex = 7;
            this.ConvertFontBtn.Text = "Convert Font";
            this.ConvertFontBtn.UseVisualStyleBackColor = true;
            this.ConvertFontBtn.Click += new System.EventHandler(this.ConvertFontBtn_Click);
            // 
            // OutFormatComboBox
            // 
            this.OutFormatComboBox.FormattingEnabled = true;
            this.OutFormatComboBox.Location = new System.Drawing.Point(130, 52);
            this.OutFormatComboBox.Name = "OutFormatComboBox";
            this.OutFormatComboBox.Size = new System.Drawing.Size(121, 21);
            this.OutFormatComboBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(21, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Output format:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 156);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OutFormatComboBox);
            this.Controls.Add(this.ConvertFontBtn);
            this.Controls.Add(this.FontSizeCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FontAddressTextBox);
            this.Controls.Add(this.OpenFont);
            this.Controls.Add(this.BMPaddressTextBox);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.OpenFile);
            this.Name = "Form1";
            this.Text = "Font and BMP converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.TextBox BMPaddressTextBox;
        private System.Windows.Forms.Button OpenFont;
        private System.Windows.Forms.TextBox FontAddressTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FontSizeCombo;
        private System.Windows.Forms.Button ConvertFontBtn;
        private System.Windows.Forms.ComboBox OutFormatComboBox;
        private System.Windows.Forms.Label label2;
    }
}

