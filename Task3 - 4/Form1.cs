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

namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string currentFolderPath = string.Empty;
        private Timer slideShowTimer;
        private bool isSlideShowRunning = false;

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Виберіть папку з фотографіями";
                folderDialog.ShowNewFolderButton = false;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFolderPath = folderDialog.SelectedPath;
                    LoadPhotosToList();
                }
            }
        }
        private void LoadPhotosToList()
        {
            listBoxPhotos.Items.Clear();
            pictureBox.Image?.Dispose(); 
            pictureBox.Image = null;

            if (string.IsNullOrEmpty(currentFolderPath)) return;

            try
            {
                string[] validExtensions = { ".jpg", ".jpeg", ".png", ".bmp", ".gif" };

                string[] files = Directory.GetFiles(currentFolderPath)
                                          .Where(f => validExtensions.Contains(Path.GetExtension(f).ToLower()))
                                          .ToArray();

                if (files.Length == 0)
                {
                    MessageBox.Show("У вибраній папці не знайдено підтримуваних зображень.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                foreach (string file in files)
                {
                    listBoxPhotos.Items.Add(Path.GetFileName(file));
                }

                if (listBoxPhotos.Items.Count > 0)
                {
                    listBoxPhotos.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при завантаженні файлів: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ListBoxPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxPhotos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBoxPhotos.SelectedIndex == -1 || string.IsNullOrEmpty(currentFolderPath))
                return;

            string selectedFileName = listBoxPhotos.SelectedItem.ToString();
            string fullImagePath = Path.Combine(currentFolderPath, selectedFileName);

            try
            {
                if (pictureBox.Image != null)
                {
                    pictureBox.Image.Dispose();
                }

                byte[] bytes = File.ReadAllBytes(fullImagePath);
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    pictureBox.Image = Image.FromStream(ms);
                }

                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не вдалося відкрити зображення.\n{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pictureBox.Image = null;
            }
        }
        private void ShowNextPhoto()
        {
            if (listBoxPhotos.Items.Count == 0) return;

            int nextIndex = listBoxPhotos.SelectedIndex + 1;
            if (nextIndex >= listBoxPhotos.Items.Count)
            {
                nextIndex = 0; 
            }
            listBoxPhotos.SelectedIndex = nextIndex;
        }
        private void ShowPreviousPhoto()
        {
            if (listBoxPhotos.Items.Count == 0) return;

            int prevIndex = listBoxPhotos.SelectedIndex - 1;
            if (prevIndex < 0)
            {
                prevIndex = listBoxPhotos.Items.Count - 1; 
            }
            listBoxPhotos.SelectedIndex = prevIndex;
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                Image img = pictureBox.Image;
                img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox.Image = img;
            }
        }
        private void StartSlideShow()
        {
            if (listBoxPhotos.Items.Count == 0) return;
            isSlideShowRunning = true;
            btnSlideShow.Text = "Стоп";
            btnSlideShow.BackColor = Color.LightCoral;
            slideShowTimer.Start();
        }

        private void StopSlideShow()
        {
            isSlideShowRunning = false;
            btnSlideShow.Text = "Слайд-шоу";
            btnSlideShow.BackColor = SystemColors.Control;
            slideShowTimer.Stop();
        }
        private void btnSlideShow_Click(object sender, EventArgs e)
        {
            if (isSlideShowRunning)
            {
                StopSlideShow();
            }
            else
            {
                StartSlideShow();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ShowNextPhoto();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            ShowPreviousPhoto();
        }
    }
}
