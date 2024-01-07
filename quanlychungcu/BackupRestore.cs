using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace quanlychungcu
{
    public partial class BackupRestore : Form
    {
        private Connect cn = new Connect();
        private string backupFolderPath;
        private string restoreFolderPath;
        private string databaseName;
        public BackupRestore()
        {
            InitializeComponent();

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(cn.connStr);
            databaseName = builder.InitialCatalog;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Chọn thư mục lưu file backup";

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                backupFolderPath = folderBrowserDialog.SelectedPath;
                lbDuongDan.Text = backupFolderPath;
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(backupFolderPath))
                {
                    MessageBox.Show("Vui lòng chọn thư mục lưu file backup trước khi thực hiện backup.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(cn.connStr))
                {
                    connection.Open();

                    // Sử dụng lệnh SQL để backup cơ sở dữ liệu
                    string backupFileName = $"Backup_{databaseName}_{DateTime.Now:yyyyMMdd_HHmm}.bak";
                    string backupFilePath = Path.Combine(backupFolderPath, backupFileName);

                    string backupQuery = $"BACKUP DATABASE {databaseName} TO DISK='{backupFilePath}'";
                    using (SqlCommand command = new SqlCommand(backupQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Backup thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Backup lỗi. Error: {ex.Message}");
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(backupFolderPath))
                {
                    MessageBox.Show("Vui lòng chọn thư mục lưu file backup trước khi thực hiện backup.");
                    return;
                }

                // Thực hiện khôi phục
                RestoreDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Restore failed. Error: {ex.Message}");
            }
        }

        private void RestoreDatabase()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cn.connStr))
                {
                    connection.Open();

                    string restoreFilePath = GetLatestBackupFilePath(); // Lấy đường dẫn tới tệp backup
                    string restoreQuery = $"USE master; RESTORE DATABASE {databaseName} FROM DISK = '{restoreFilePath}' WITH REPLACE;";

                    using (SqlCommand command = new SqlCommand(restoreQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Restore completed successfully!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Restore failed. Error: {ex.Message}");
            }
        }
        private string GetLatestBackupFilePath()
        {
            // Đặt đường dẫn đến tệp backup. Bạn có thể thay đổi logic này tùy thuộc vào cách bạn lưu trữ các tệp backup.
            string[] backupFiles = System.IO.Directory.GetFiles(backupFolderPath, $"Backup_{databaseName}_*.bak");

            if (backupFiles.Length > 0)
            {
                Array.Sort(backupFiles);
                return backupFiles[backupFiles.Length - 1];
            }

            throw new Exception("Không tìm thấy tệp backup trong thư mục đã chọn.");
        }

        private void btnChonDDRestore_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Backup Files (*.bak)|*.bak";
            openFileDialog.Title = "Chọn tệp backup để khôi phục";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                restoreFolderPath = openFileDialog.FileName;
                lbduongDanRestore.Text = restoreFolderPath;
            }
        }
    }
}
