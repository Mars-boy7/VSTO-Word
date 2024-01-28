using System;
using System.Windows.Forms;

namespace WordAddIn2
{
    public class FileUploadManager
    {
        public void UploadFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // 设置文件对话框属性（过滤器等）

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    // 处理文件上传逻辑，例如将文件上传到服务器
                    MessageBox.Show($"已选择文件: {filePath}");
                }
            }
        }
    }
}