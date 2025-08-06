namespace AesCryptografer
{
    partial class mainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chb_encrypt_place = new System.Windows.Forms.CheckBox();
            this.btn_select_dir_crypt = new System.Windows.Forms.Button();
            this.btn_clear_crypt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_directory_to_crypt = new System.Windows.Forms.TextBox();
            this.btn_addfile_crypt = new System.Windows.Forms.Button();
            this.chb_delete_file_crypt = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_pass_crypt_2 = new System.Windows.Forms.TextBox();
            this.btn_crypt = new System.Windows.Forms.Button();
            this.txb_pass_crypt_1 = new System.Windows.Forms.TextBox();
            this.dgv_file_crypt = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chb_decrypt_place = new System.Windows.Forms.CheckBox();
            this.btn_select_dir_decrypt = new System.Windows.Forms.Button();
            this.btn_clear_decrypt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_directory_to_decrypt = new System.Windows.Forms.TextBox();
            this.btn_addfile_decrypt = new System.Windows.Forms.Button();
            this.chb_delete_file_decrypt = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_decrypt = new System.Windows.Forms.Button();
            this.txb_pass_decrypt = new System.Windows.Forms.TextBox();
            this.dgv_file_decrypt = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_file_crypt)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_file_decrypt)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(650, 495);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chb_encrypt_place);
            this.tabPage1.Controls.Add(this.btn_select_dir_crypt);
            this.tabPage1.Controls.Add(this.btn_clear_crypt);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txb_directory_to_crypt);
            this.tabPage1.Controls.Add(this.btn_addfile_crypt);
            this.tabPage1.Controls.Add(this.chb_delete_file_crypt);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txb_pass_crypt_2);
            this.tabPage1.Controls.Add(this.btn_crypt);
            this.tabPage1.Controls.Add(this.txb_pass_crypt_1);
            this.tabPage1.Controls.Add(this.dgv_file_crypt);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(642, 469);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Зашифровать";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chb_encrypt_place
            // 
            this.chb_encrypt_place.AutoSize = true;
            this.chb_encrypt_place.Location = new System.Drawing.Point(405, 43);
            this.chb_encrypt_place.Name = "chb_encrypt_place";
            this.chb_encrypt_place.Size = new System.Drawing.Size(170, 17);
            this.chb_encrypt_place.TabIndex = 20;
            this.chb_encrypt_place.Text = "Шифровать файлы на месте";
            this.chb_encrypt_place.UseVisualStyleBackColor = true;
            this.chb_encrypt_place.CheckedChanged += new System.EventHandler(this.chb_encrypt_place_CheckedChanged);
            // 
            // btn_select_dir_crypt
            // 
            this.btn_select_dir_crypt.Location = new System.Drawing.Point(480, 86);
            this.btn_select_dir_crypt.Name = "btn_select_dir_crypt";
            this.btn_select_dir_crypt.Size = new System.Drawing.Size(132, 27);
            this.btn_select_dir_crypt.TabIndex = 11;
            this.btn_select_dir_crypt.Text = "Обзор";
            this.btn_select_dir_crypt.UseVisualStyleBackColor = true;
            this.btn_select_dir_crypt.Click += new System.EventHandler(this.btn_select_dir_crypt_Click);
            // 
            // btn_clear_crypt
            // 
            this.btn_clear_crypt.Location = new System.Drawing.Point(24, 423);
            this.btn_clear_crypt.Name = "btn_clear_crypt";
            this.btn_clear_crypt.Size = new System.Drawing.Size(124, 33);
            this.btn_clear_crypt.TabIndex = 10;
            this.btn_clear_crypt.Text = "Очистить список";
            this.btn_clear_crypt.UseVisualStyleBackColor = true;
            this.btn_clear_crypt.Click += new System.EventHandler(this.btn_clear_crypt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Сохранить файлы в:";
            // 
            // txb_directory_to_crypt
            // 
            this.txb_directory_to_crypt.Location = new System.Drawing.Point(136, 88);
            this.txb_directory_to_crypt.Multiline = true;
            this.txb_directory_to_crypt.Name = "txb_directory_to_crypt";
            this.txb_directory_to_crypt.Size = new System.Drawing.Size(338, 23);
            this.txb_directory_to_crypt.TabIndex = 8;
            // 
            // btn_addfile_crypt
            // 
            this.btn_addfile_crypt.Location = new System.Drawing.Point(172, 422);
            this.btn_addfile_crypt.Name = "btn_addfile_crypt";
            this.btn_addfile_crypt.Size = new System.Drawing.Size(207, 33);
            this.btn_addfile_crypt.TabIndex = 1;
            this.btn_addfile_crypt.Text = "Выбрать файлы:";
            this.btn_addfile_crypt.UseVisualStyleBackColor = true;
            this.btn_addfile_crypt.Click += new System.EventHandler(this.btn_addfile_crypt_Click);
            // 
            // chb_delete_file_crypt
            // 
            this.chb_delete_file_crypt.AutoSize = true;
            this.chb_delete_file_crypt.Location = new System.Drawing.Point(405, 22);
            this.chb_delete_file_crypt.Name = "chb_delete_file_crypt";
            this.chb_delete_file_crypt.Size = new System.Drawing.Size(206, 17);
            this.chb_delete_file_crypt.TabIndex = 7;
            this.chb_delete_file_crypt.Text = "Удалить файлы после шифрования";
            this.chb_delete_file_crypt.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Повторите ключ шифрования:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ключ шифрования:";
            // 
            // txb_pass_crypt_2
            // 
            this.txb_pass_crypt_2.Location = new System.Drawing.Point(182, 47);
            this.txb_pass_crypt_2.Multiline = true;
            this.txb_pass_crypt_2.Name = "txb_pass_crypt_2";
            this.txb_pass_crypt_2.PasswordChar = '*';
            this.txb_pass_crypt_2.Size = new System.Drawing.Size(177, 24);
            this.txb_pass_crypt_2.TabIndex = 4;
            // 
            // btn_crypt
            // 
            this.btn_crypt.Location = new System.Drawing.Point(405, 423);
            this.btn_crypt.Name = "btn_crypt";
            this.btn_crypt.Size = new System.Drawing.Size(206, 32);
            this.btn_crypt.TabIndex = 3;
            this.btn_crypt.Text = "Зашифровать";
            this.btn_crypt.UseVisualStyleBackColor = true;
            this.btn_crypt.Click += new System.EventHandler(this.btn_crypt_Click);
            // 
            // txb_pass_crypt_1
            // 
            this.txb_pass_crypt_1.Location = new System.Drawing.Point(182, 17);
            this.txb_pass_crypt_1.Multiline = true;
            this.txb_pass_crypt_1.Name = "txb_pass_crypt_1";
            this.txb_pass_crypt_1.PasswordChar = '*';
            this.txb_pass_crypt_1.Size = new System.Drawing.Size(177, 24);
            this.txb_pass_crypt_1.TabIndex = 2;
            // 
            // dgv_file_crypt
            // 
            this.dgv_file_crypt.AllowUserToAddRows = false;
            this.dgv_file_crypt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_file_crypt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_file_crypt.Location = new System.Drawing.Point(21, 117);
            this.dgv_file_crypt.Name = "dgv_file_crypt";
            this.dgv_file_crypt.ReadOnly = true;
            this.dgv_file_crypt.Size = new System.Drawing.Size(590, 299);
            this.dgv_file_crypt.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chb_decrypt_place);
            this.tabPage2.Controls.Add(this.btn_select_dir_decrypt);
            this.tabPage2.Controls.Add(this.btn_clear_decrypt);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txb_directory_to_decrypt);
            this.tabPage2.Controls.Add(this.btn_addfile_decrypt);
            this.tabPage2.Controls.Add(this.chb_delete_file_decrypt);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btn_decrypt);
            this.tabPage2.Controls.Add(this.txb_pass_decrypt);
            this.tabPage2.Controls.Add(this.dgv_file_decrypt);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(642, 469);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Дешифровать";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chb_decrypt_place
            // 
            this.chb_decrypt_place.AutoSize = true;
            this.chb_decrypt_place.Location = new System.Drawing.Point(23, 47);
            this.chb_decrypt_place.Name = "chb_decrypt_place";
            this.chb_decrypt_place.Size = new System.Drawing.Size(184, 17);
            this.chb_decrypt_place.TabIndex = 24;
            this.chb_decrypt_place.Text = "Дешифровать файлы на месте";
            this.chb_decrypt_place.UseVisualStyleBackColor = true;
            this.chb_decrypt_place.CheckedChanged += new System.EventHandler(this.chb_decrypt_place_CheckedChanged);
            // 
            // btn_select_dir_decrypt
            // 
            this.btn_select_dir_decrypt.Location = new System.Drawing.Point(482, 77);
            this.btn_select_dir_decrypt.Name = "btn_select_dir_decrypt";
            this.btn_select_dir_decrypt.Size = new System.Drawing.Size(132, 27);
            this.btn_select_dir_decrypt.TabIndex = 23;
            this.btn_select_dir_decrypt.Text = "Обзор";
            this.btn_select_dir_decrypt.UseVisualStyleBackColor = true;
            this.btn_select_dir_decrypt.Click += new System.EventHandler(this.btn_select_dir_decrypt_Click);
            // 
            // btn_clear_decrypt
            // 
            this.btn_clear_decrypt.Location = new System.Drawing.Point(26, 413);
            this.btn_clear_decrypt.Name = "btn_clear_decrypt";
            this.btn_clear_decrypt.Size = new System.Drawing.Size(167, 33);
            this.btn_clear_decrypt.TabIndex = 22;
            this.btn_clear_decrypt.Text = "Очистить список";
            this.btn_clear_decrypt.UseVisualStyleBackColor = true;
            this.btn_clear_decrypt.Click += new System.EventHandler(this.btn_clear_decrypt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Сохранить файлы в:";
            // 
            // txb_directory_to_decrypt
            // 
            this.txb_directory_to_decrypt.Location = new System.Drawing.Point(138, 79);
            this.txb_directory_to_decrypt.Multiline = true;
            this.txb_directory_to_decrypt.Name = "txb_directory_to_decrypt";
            this.txb_directory_to_decrypt.Size = new System.Drawing.Size(338, 23);
            this.txb_directory_to_decrypt.TabIndex = 20;
            // 
            // btn_addfile_decrypt
            // 
            this.btn_addfile_decrypt.Location = new System.Drawing.Point(218, 413);
            this.btn_addfile_decrypt.Name = "btn_addfile_decrypt";
            this.btn_addfile_decrypt.Size = new System.Drawing.Size(210, 33);
            this.btn_addfile_decrypt.TabIndex = 13;
            this.btn_addfile_decrypt.Text = "Выбрать файлы:";
            this.btn_addfile_decrypt.UseVisualStyleBackColor = true;
            this.btn_addfile_decrypt.Click += new System.EventHandler(this.btn_addfile_decrypt_Click);
            // 
            // chb_delete_file_decrypt
            // 
            this.chb_delete_file_decrypt.AutoSize = true;
            this.chb_delete_file_decrypt.Location = new System.Drawing.Point(23, 24);
            this.chb_delete_file_decrypt.Name = "chb_delete_file_decrypt";
            this.chb_delete_file_decrypt.Size = new System.Drawing.Size(218, 17);
            this.chb_delete_file_decrypt.TabIndex = 19;
            this.chb_delete_file_decrypt.Text = "Удалить файлы после дешифрования";
            this.chb_delete_file_decrypt.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ключ дешифрования:";
            // 
            // btn_decrypt
            // 
            this.btn_decrypt.Location = new System.Drawing.Point(441, 413);
            this.btn_decrypt.Name = "btn_decrypt";
            this.btn_decrypt.Size = new System.Drawing.Size(173, 32);
            this.btn_decrypt.TabIndex = 15;
            this.btn_decrypt.Text = "Дешифровать";
            this.btn_decrypt.UseVisualStyleBackColor = true;
            this.btn_decrypt.Click += new System.EventHandler(this.btn_decrypt_Click);
            // 
            // txb_pass_decrypt
            // 
            this.txb_pass_decrypt.Location = new System.Drawing.Point(361, 33);
            this.txb_pass_decrypt.Multiline = true;
            this.txb_pass_decrypt.Name = "txb_pass_decrypt";
            this.txb_pass_decrypt.PasswordChar = '*';
            this.txb_pass_decrypt.Size = new System.Drawing.Size(247, 24);
            this.txb_pass_decrypt.TabIndex = 14;
            // 
            // dgv_file_decrypt
            // 
            this.dgv_file_decrypt.AllowUserToAddRows = false;
            this.dgv_file_decrypt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_file_decrypt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_file_decrypt.Location = new System.Drawing.Point(23, 108);
            this.dgv_file_decrypt.Name = "dgv_file_decrypt";
            this.dgv_file_decrypt.ReadOnly = true;
            this.dgv_file_decrypt.Size = new System.Drawing.Size(590, 299);
            this.dgv_file_decrypt.TabIndex = 12;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 519);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(690, 558);
            this.MinimumSize = new System.Drawing.Size(690, 558);
            this.Name = "mainForm";
            this.Text = "Aes256 Cryptografer";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_file_crypt)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_file_decrypt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_addfile_crypt;
        private System.Windows.Forms.DataGridView dgv_file_crypt;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_pass_crypt_2;
        private System.Windows.Forms.Button btn_crypt;
        private System.Windows.Forms.TextBox txb_pass_crypt_1;
        private System.Windows.Forms.Button btn_select_dir_crypt;
        private System.Windows.Forms.Button btn_clear_crypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_directory_to_crypt;
        private System.Windows.Forms.CheckBox chb_delete_file_crypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_select_dir_decrypt;
        private System.Windows.Forms.Button btn_clear_decrypt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_directory_to_decrypt;
        private System.Windows.Forms.Button btn_addfile_decrypt;
        private System.Windows.Forms.CheckBox chb_delete_file_decrypt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_decrypt;
        private System.Windows.Forms.TextBox txb_pass_decrypt;
        private System.Windows.Forms.DataGridView dgv_file_decrypt;
        private System.Windows.Forms.CheckBox chb_encrypt_place;
        private System.Windows.Forms.CheckBox chb_decrypt_place;
    }
}

