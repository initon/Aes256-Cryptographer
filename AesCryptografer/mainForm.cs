using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace AesCryptografer
{
    public partial class mainForm : Form
    {

        public mainForm()
        {
            InitializeComponent();
        }

        public string sizeConver(long size)
        {
            string[] sizeletters = new string[] { "bytes", "KB", "MB", "GB", "TB" };
            for (int i = 0; i < 5; i++)
            {
                if (size < 1024)
                {
                    string fileSize = size.ToString() + sizeletters[i];
                    return fileSize;
                }
                size /= 1024;
            }
            return "";
        }

        private void btn_addfile_crypt_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All Files *.* | *.*";
            open.Multiselect = true;
            open.Title = "Add Files";

            DataTable table = new DataTable();

            if (open.ShowDialog() == DialogResult.OK)
            {
                table.Columns.Add("Имя файла");
                table.Columns.Add("Размер");
                table.Columns.Add("Путь");

                foreach (string file in open.FileNames)
                {

                    FileInfo file_info = new FileInfo(file);
                    DataRow dr = table.NewRow();
                    dr[0] = file_info.Name;
                    dr[1] = sizeConver(file_info.Length);
                    dr[2] = file_info.FullName;
                    table.Rows.Add(dr);
                }
            }
            dgv_file_crypt.DataSource = table;
        }

        private void btn_clear_crypt_Click(object sender, EventArgs e)
        {
            dgv_file_crypt.DataSource = null;

        }

        private void btn_select_dir_crypt_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
                txb_directory_to_crypt.Text = fbd.SelectedPath;
        }

        private void btn_crypt_Click(object sender, EventArgs e)
        {
            // Проверка паролей на пустоту
            if (txb_pass_crypt_1.Text == string.Empty || txb_pass_crypt_2.Text == string.Empty)
            {
                MessageBox.Show("Поле пароля пустое!");
                return;
            }

            // Проверка паролей на эквиалетность
            if (txb_pass_crypt_1.Text != txb_pass_crypt_2.Text)
            {
                MessageBox.Show("Пароли не совпадают!");
                return;
            }

            // Проверка поле директории для шифрования файлов
            if (!chb_encrypt_place.Checked && (txb_directory_to_crypt.Text == string.Empty || !Directory.Exists(txb_directory_to_crypt.Text)))
            {
                MessageBox.Show("Выберите директорию для зашифрованных файлов!");
                return;
            }

            // Проверка на количество записей в DataGridView
            if (dgv_file_crypt.RowCount == 0)
            {
                MessageBox.Show("Выберите файлы для шифрования!");
                return;
            }

            FileEncrypt();
        }


        private void FileEncrypt()
        {
            bool delete_file = chb_delete_file_crypt.Checked;

            foreach (DataGridViewRow row in dgv_file_crypt.Rows)
            {
                string filename = row.Cells[0].Value.ToString();
                string pathFile = row.Cells[2].Value.ToString();

                string path_encrypt_file = string.Empty;

                if (chb_encrypt_place.Checked)
                {
                    path_encrypt_file = pathFile + ".temp";
                }
                else
                {
                    path_encrypt_file = Path.Combine(txb_directory_to_crypt.Text, filename);
                }
                // Шифруем файлы
                try
                {
                    bool result = FileEncryptor.EncryptFile(pathFile, path_encrypt_file, txb_pass_crypt_1.Text);
                    if (result)
                    {
                        // Если удаляем файл, смотрим, чтобы файл не шифровался по месту
                        if (delete_file && !chb_encrypt_place.Checked)
                        {
                            File.Delete(pathFile);
                        }
                        // Если файл шифруется по месту, то удаляем исходный файл и изменяем имя временного файла
                        if (chb_encrypt_place.Checked)
                        {
                            File.Delete(pathFile);
                            File.Move(path_encrypt_file, pathFile);
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Исключение при шифровании файла: " + e.ToString());
                }
            }

            MessageBox.Show("Выполнено!");
        }

        private void chb_encrypt_place_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_encrypt_place.Checked)
            {
                btn_select_dir_crypt.Enabled = false;
                txb_directory_to_crypt.Enabled = false;
                chb_delete_file_crypt.Enabled = false;
            }
            else
            {
                btn_select_dir_crypt.Enabled = true;
                txb_directory_to_crypt.Enabled = true;
                chb_delete_file_crypt.Enabled = true;
            }
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btn_select_dir_decrypt_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
                txb_directory_to_decrypt.Text = fbd.SelectedPath;
        }

        private void btn_clear_decrypt_Click(object sender, EventArgs e)
        {
            dgv_file_decrypt.DataSource = null;
        }

        private void btn_addfile_decrypt_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All Files *.* | *.*";
            open.Multiselect = true;
            open.Title = "Add Files";

            DataTable table = new DataTable();

            if (open.ShowDialog() == DialogResult.OK)
            {
                table.Columns.Add("Имя файла");
                table.Columns.Add("Размер");
                table.Columns.Add("Путь");

                foreach (string file in open.FileNames)
                {

                    FileInfo file_info = new FileInfo(file);
                    DataRow dr = table.NewRow();
                    dr[0] = file_info.Name;
                    dr[1] = sizeConver(file_info.Length);
                    dr[2] = file_info.FullName;
                    table.Rows.Add(dr);
                }
            }
            dgv_file_decrypt.DataSource = table;
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            // Проверка паролей на пустоту
            if (txb_pass_decrypt.Text == string.Empty)
            {
                MessageBox.Show("Поле пароля пустое!");
                return;
            }

            // Проверка поле директории для шифрования файлов
            if (!chb_decrypt_place.Checked && (txb_directory_to_decrypt.Text == string.Empty || !Directory.Exists(txb_directory_to_decrypt.Text)))
            {
                MessageBox.Show("Выберите директорию для зашифрованных файлов!");
                return;
            }

            // Проверка на количество записей в DataGridView
            if (dgv_file_decrypt.RowCount == 0)
            {
                MessageBox.Show("Выберите файлы для шифрования!");
                return;
            }

            FileDecrypt();

        }

        private void FileDecrypt()
        {
            bool delete_file = chb_delete_file_decrypt.Checked;

            foreach (DataGridViewRow row in dgv_file_decrypt.Rows)
            {
                string filename = row.Cells[0].Value.ToString();
                string pathFile = row.Cells[2].Value.ToString();

                // Дешифруем файлы
                try
                {
                    string path_decrypt_file = string.Empty;

                    if (chb_decrypt_place.Checked)
                    {
                        path_decrypt_file = pathFile + ".temp";
                    }
                    else
                    {
                        path_decrypt_file = Path.Combine(txb_directory_to_decrypt.Text, filename);
                    }

                    bool result = FileEncryptor.DecryptFile(pathFile, path_decrypt_file, txb_pass_decrypt.Text);
                    if (result)
                    {
                        // Если удаляем файл, смотрим, чтобы файл не шифровался по месту
                        if (delete_file && !chb_decrypt_place.Checked)
                        {
                            File.Delete(pathFile);
                        }
                        // Если файл шифруется по месту, то удаляем исходный файл и изменяем имя временного файла
                        if (chb_decrypt_place.Checked)
                        {
                            File.Delete(pathFile);
                            File.Move(path_decrypt_file, pathFile);
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Исключение при шифровании файла: " + e.ToString());
                }
            }

            MessageBox.Show("Выполнено!");
        }

        private void chb_decrypt_place_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_decrypt_place.Checked)
            {
                btn_select_dir_decrypt.Enabled = false;
                txb_directory_to_decrypt.Enabled = false;
                chb_delete_file_decrypt.Enabled = false;
            }
            else
            {
                btn_select_dir_decrypt.Enabled = true;
                txb_directory_to_decrypt.Enabled = true;
                chb_delete_file_decrypt.Enabled = true;
            }
        }
    }
}
