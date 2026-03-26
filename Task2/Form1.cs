using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadDrives();

        }
        private void LoadDrives()
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                {
                    TreeNode driveNode = new TreeNode(drive.Name);
                    driveNode.Tag = drive.RootDirectory.FullName;

                    driveNode.Nodes.Add("...");
                    treeViewFolders.Nodes.Add(driveNode);
                }
            }
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void treeViewFolders_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode currentNode = e.Node;

            if (currentNode.Nodes.Count == 1 && currentNode.Nodes[0].Text == "...")
            {
                currentNode.Nodes.Clear(); 

                string path = currentNode.Tag.ToString();

                try
                {
                    string[] directories = Directory.GetDirectories(path);

                    foreach (string dir in directories)
                    {
                        DirectoryInfo dirInfo = new DirectoryInfo(dir);

                        if (!dirInfo.Attributes.HasFlag(FileAttributes.Hidden) &&
                            !dirInfo.Attributes.HasFlag(FileAttributes.System))
                        {
                            TreeNode subNode = new TreeNode(dirInfo.Name);
                            subNode.Tag = dirInfo.FullName;
                            subNode.Nodes.Add("..."); 
                            currentNode.Nodes.Add(subNode);
                        }
                    }
                }
                catch (UnauthorizedAccessException)
                {
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка доступу до папки: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void treeViewFolders_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listViewFiles.Items.Clear(); 
            string path = e.Node.Tag.ToString();

            try
            {
                string[] files = Directory.GetFiles(path);

                foreach (string file in files)
                {
                    FileInfo fileInfo = new FileInfo(file);

                    if (!fileInfo.Attributes.HasFlag(FileAttributes.Hidden) &&
                        !fileInfo.Attributes.HasFlag(FileAttributes.System))
                    {
                        ListViewItem item = new ListViewItem(fileInfo.Name);
                        item.SubItems.Add(fileInfo.Extension);
                        item.SubItems.Add((fileInfo.Length / 1024).ToString()); // Розмір у КБ
                        item.SubItems.Add(fileInfo.LastWriteTime.ToString("dd.MM.yyyy HH:mm"));

                        listViewFiles.Items.Add(item);
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка читання файлів: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
