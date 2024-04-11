namespace C_App5
{
    partial class Memo
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxMain = new System.Windows.Forms.TextBox();
            this.EndButton = new System.Windows.Forms.Button();
            this.ReadButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.radioB1 = new System.Windows.Forms.RadioButton();
            this.radioB2 = new System.Windows.Forms.RadioButton();
            this.radioB3 = new System.Windows.Forms.RadioButton();
            this.radioB4 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioB5 = new System.Windows.Forms.RadioButton();
            this.newSaveButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fileLabel1 = new System.Windows.Forms.Label();
            this.fileLabel2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxMain
            // 
            this.textBoxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMain.Location = new System.Drawing.Point(19, 28);
            this.textBoxMain.Multiline = true;
            this.textBoxMain.Name = "textBoxMain";
            this.textBoxMain.Size = new System.Drawing.Size(361, 349);
            this.textBoxMain.TabIndex = 0;
            this.textBoxMain.Click += new System.EventHandler(this.textBoxMain_Click);
            // 
            // EndButton
            // 
            this.EndButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EndButton.Location = new System.Drawing.Point(281, 512);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(75, 23);
            this.EndButton.TabIndex = 1;
            this.EndButton.Text = "終了";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // ReadButton
            // 
            this.ReadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadButton.Location = new System.Drawing.Point(119, 512);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(75, 23);
            this.ReadButton.TabIndex = 2;
            this.ReadButton.Text = "開く";
            this.ReadButton.UseVisualStyleBackColor = true;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(200, 512);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "上書保存";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // radioB1
            // 
            this.radioB1.AutoSize = true;
            this.radioB1.Checked = true;
            this.radioB1.Location = new System.Drawing.Point(14, 27);
            this.radioB1.Name = "radioB1";
            this.radioB1.Size = new System.Drawing.Size(57, 16);
            this.radioB1.TabIndex = 3;
            this.radioB1.TabStop = true;
            this.radioB1.Text = "UTF-8";
            this.radioB1.UseVisualStyleBackColor = true;
            // 
            // radioB2
            // 
            this.radioB2.AutoSize = true;
            this.radioB2.Location = new System.Drawing.Point(77, 27);
            this.radioB2.Name = "radioB2";
            this.radioB2.Size = new System.Drawing.Size(70, 16);
            this.radioB2.TabIndex = 3;
            this.radioB2.TabStop = true;
            this.radioB2.Text = "Shift-JIS";
            this.radioB2.UseVisualStyleBackColor = true;
            // 
            // radioB3
            // 
            this.radioB3.AutoSize = true;
            this.radioB3.Location = new System.Drawing.Point(153, 27);
            this.radioB3.Name = "radioB3";
            this.radioB3.Size = new System.Drawing.Size(66, 16);
            this.radioB3.TabIndex = 3;
            this.radioB3.TabStop = true;
            this.radioB3.Text = "EUC-JP";
            this.radioB3.UseVisualStyleBackColor = true;
            // 
            // radioB4
            // 
            this.radioB4.AutoSize = true;
            this.radioB4.Location = new System.Drawing.Point(225, 27);
            this.radioB4.Name = "radioB4";
            this.radioB4.Size = new System.Drawing.Size(108, 16);
            this.radioB4.TabIndex = 3;
            this.radioB4.TabStop = true;
            this.radioB4.Text = "JIS(iso-2022-jp)";
            this.radioB4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radioB5);
            this.groupBox1.Controls.Add(this.radioB4);
            this.groupBox1.Controls.Add(this.newSaveButton);
            this.groupBox1.Controls.Add(this.radioB3);
            this.groupBox1.Controls.Add(this.radioB1);
            this.groupBox1.Controls.Add(this.radioB2);
            this.groupBox1.Location = new System.Drawing.Point(23, 390);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 98);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文字コード";
            // 
            // radioB5
            // 
            this.radioB5.AutoSize = true;
            this.radioB5.Location = new System.Drawing.Point(14, 62);
            this.radioB5.Name = "radioB5";
            this.radioB5.Size = new System.Drawing.Size(64, 16);
            this.radioB5.TabIndex = 3;
            this.radioB5.TabStop = true;
            this.radioB5.Text = "Unicode";
            this.radioB5.UseVisualStyleBackColor = true;
            // 
            // newSaveButton
            // 
            this.newSaveButton.Enabled = false;
            this.newSaveButton.Location = new System.Drawing.Point(247, 59);
            this.newSaveButton.Name = "newSaveButton";
            this.newSaveButton.Size = new System.Drawing.Size(75, 23);
            this.newSaveButton.TabIndex = 2;
            this.newSaveButton.Text = "別名保存";
            this.newSaveButton.UseVisualStyleBackColor = true;
            this.newSaveButton.Click += new System.EventHandler(this.newSaveButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "テキストファイル|*.txt|すべてのファイル|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "テキストファイル|*.txt|すべてのファイル|*.*";
            // 
            // fileLabel1
            // 
            this.fileLabel1.AutoSize = true;
            this.fileLabel1.Location = new System.Drawing.Point(20, 8);
            this.fileLabel1.Name = "fileLabel1";
            this.fileLabel1.Size = new System.Drawing.Size(51, 12);
            this.fileLabel1.TabIndex = 5;
            this.fileLabel1.Text = "ファイル名";
            // 
            // fileLabel2
            // 
            this.fileLabel2.AutoSize = true;
            this.fileLabel2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.fileLabel2.Location = new System.Drawing.Point(77, 9);
            this.fileLabel2.Name = "fileLabel2";
            this.fileLabel2.Size = new System.Drawing.Size(0, 12);
            this.fileLabel2.TabIndex = 5;
            // 
            // Memo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 557);
            this.Controls.Add(this.fileLabel2);
            this.Controls.Add(this.fileLabel1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ReadButton);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.textBoxMain);
            this.Controls.Add(this.groupBox1);
            this.Name = "Memo";
            this.Text = "メモ帳";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMain;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.RadioButton radioB1;
        private System.Windows.Forms.RadioButton radioB2;
        private System.Windows.Forms.RadioButton radioB3;
        private System.Windows.Forms.RadioButton radioB4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button newSaveButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RadioButton radioB5;
        private System.Windows.Forms.Label fileLabel1;
        private System.Windows.Forms.Label fileLabel2;
    }
}

