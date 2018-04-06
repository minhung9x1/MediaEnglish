using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;


namespace MediaEnglish
{
    public partial class Form1 : Form
    {
        public MyMedia Player;

        public Dictionary<int, Song> ListFiles;
        private Song _currentSong;
        private System.Windows.Forms.Timer Timerr;

        public Song CurrentSong
        {
            get { return _currentSong; }
            set
            {
                if (!object.Equals(_currentSong, value))
                {
                    _currentSong = value;
                    CurrentSongChange(_currentSong);
                }
            }
        }

        public Form1()
        {
            InitializeComponent();

            // Timerr.Enabled = true;
            Player = new MyMedia();

            Player.OpenStatusChange += Player_OpenStatusChange;
            Player.PlayStatusChange += Player_PlayStatusChange;

            lstBoxSong.AllowDrop = true;
            lstBoxSong.DragEnter += LstBoxSong_DragEnter;
            lstBoxSong.DragDrop += LstBoxSong_DragDrop;
            lstBoxSong.DoubleClick += LstBoxSong_DoubleClick;
   
            lstBoxSong.SelectedIndexChanged += LstBoxSong_SelectedIndexChanged;
            lstBoxSong.DisplayMember = "FileName";
            lstBoxSong.ValueMember = "Id";

            Timerr = new System.Windows.Forms.Timer();
            Timerr.Interval = 500;
            Timerr.Tick += Timerr_Tick;
            richTextBox1.SetInnerMargins(24, 24, 20, 0);
            tableLayoutPanel1.RowStyles[0].Height = 48;
            comboBox1.DrawItem += ComboBoxFonts_DrawItem;
            comboBox1.DataSource = System.Drawing.FontFamily.Families.ToList();
            comboBox1.DisplayMember = "Name";
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font((FontFamily)((ComboBox) sender).SelectedItem,(int)numericUpDown2.Value);
        }

        private void LstBoxSong_DragDrop(object sender, DragEventArgs e)
        {
            if (ListFiles == null)
                ListFiles = new Dictionary<int, Song>();
            string[] files = (string[]) e.Data.GetData(DataFormats.FileDrop);
            int indexMax = ListFiles.Count > 0 ? ListFiles.Keys.Max(x => x) : 1;
            foreach (string file in files)
            {
                indexMax++;
                var temp = new Song()
                {
                    Id = indexMax,
                    Path = file,
                    FileName = Path.GetFileName(file)
                };
                ListFiles.Add(indexMax, temp);
                lstBoxSong.Items.Add(temp);
            }
        }

        private void LstBoxSong_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void Timerr_Tick(object sender, EventArgs e)
        {
           UpdateTimeForSeek();
        }

        private void Player_PlayStatusChange(WMPPlayState status)
        {
            lblStatus.Text = status.ToString().Replace("wmpps", "");
            if (status == WMPPlayState.wmppsStopped && rbList.Checked)
            {
                BeginInvoke(new Action(() => NextSong()));
            }

            if (status == WMPPlayState.wmppsPlaying)
            {
                trackBar1.Maximum = (int)Player.During;
                TimeSpan t = TimeSpan.FromSeconds(Player.During);
                lblDuring.Text = t.Hours==0? t.ToString(@"mm\:ss") : t.ToString(@"hh\:mm\:ss");
                Timerr.Start();
                btnPlay.Text = "Pause";
            }
            else
            {
                Timerr.Stop();
                btnPlay.Text = "Play";
            }
            if (status == WMPPlayState.wmppsMediaEnded)
            {
                lblPosition.Text = "00:00:00";
                trackBar1.Value = 0;
            }
        }

        private void Player_OpenStatusChange(WMPOpenState status)
        {
        }

        private void LstBoxSong_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void CurrentSongChange(Song current)
        {
            Player.FileName = current.Path;
            this.Text = "Media English Player - "+ current.FileName;
        }

        private void LstBoxSong_DoubleClick(object sender, EventArgs e)
        {
            if (lstBoxSong.SelectedIndex < 0) return;
            CurrentSong = ListFiles[((Song) lstBoxSong.SelectedItem).Id];
        }


        private void btnPlay_Click(object sender, EventArgs e)
        {
            PlayClick(2);
        }

        private void PlayClick(int number)
        {
            if (CurrentSong == null) return;

            if (Player.isPlaying)
            {
                Player.Pause();
                if (!chkPauseTime.Checked) number = 0;
                UpdateSeek(number * -1);
                btnPlay.Text = "Play";
            }
            else
            {
                Player.Play();
                btnPlay.Text = "Pause";
            }
        }

        private void btnNextTime_Click(object sender, EventArgs e)
        {
            UpdateSeek((int)numericUpDown1.Value);
        }

        private void UpdateSeek(int number)
        {
            if (CurrentSong == null) return;
            Player.Seek = Player.Seek + number;
            UpdateTimeForSeek();
        }

        private void UpdateTimeForSeek()
        {
            TimeSpan t = TimeSpan.FromSeconds(Player.Seek);
            lblPosition.Text = t.Hours==0 ? t.ToString(@"mm\:ss") : t.ToString(@"hh\:mm\:ss");
            trackBar1.Value = (int) Player.Seek;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (Player == null) return false;
            switch (keyData)
            {
                case Keys.F6:
                case Keys.Control | Keys.Left:
                    UpdateSeek((int)numericUpDown1.Value * -1);
                    return true;
                case Keys.F7:
                case Keys.Control | Keys.Right:
                    UpdateSeek((int)numericUpDown1.Value);
                    return true;
                case Keys.F5:
                case Keys.Control | Keys.Space:
                    PlayClick(2);
                    return true;
                case Keys.F8:
                    PlayClick(3);
                    return true;
                case Keys.Control | Keys.O:
                    btnOpen.PerformClick();
                    return true;
            
                case Keys.Control | Keys.Down:
                    NextSongNotInList();
                    NextSong();
                    return true;
                case Keys.Control | Keys.Up:
                    PrevSongNotInList();
                    PrevSong();
                    return true;
                case Keys.Control | Keys.B:
                    BoldRickText();
                    return true;
                case Keys.Control | Keys.R:
                    ColorRichText();
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnPrevTime_Click(object sender, EventArgs e)
        {
            UpdateSeek((int)numericUpDown1.Value *-1);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Multiselect = true;
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                ListFiles = new Dictionary<int, Song>();
                lstBoxSong.Items.Clear();
                foreach (var item in dlgOpen.FileNames)
                {
                    int maxId = ListFiles.Any() ? ListFiles.Max(x => x.Key) : 0;
                    ListFiles.Add(maxId + 1, new Song()
                    {
                        Id = maxId + 1,
                        Path = item,
                        FileName = Path.GetFileName(item)
                    });
                }

                LoadDataSourceSong();
                lstBoxSong.SelectedIndex = 0;
                CurrentSong = ListFiles.Values.First();
            }
        }


        private void LoadDataSourceSong()
        {
            foreach (var item in ListFiles.Values)
            {
                lstBoxSong.Items.Add(item);
            }
        }

        private void NextSong()
        {
            if (lstBoxSong.SelectedIndex < lstBoxSong.Items.Count - 1 && lstBoxSong.SelectedIndex >-1)
            {
                lstBoxSong.SelectedIndex = lstBoxSong.SelectedIndex + 1;
                CurrentSong = ListFiles[((Song) lstBoxSong.SelectedItem).Id];
            }
        }

        private void PrevSong()
        {
            if (lstBoxSong.SelectedIndex > 0)
            {
                lstBoxSong.SelectedIndex = lstBoxSong.SelectedIndex - 1;
                CurrentSong = ListFiles[((Song) lstBoxSong.SelectedItem).Id];
            }
        }
        
        private void NextSongNotInList()
        {
            if (lstBoxSong.Items.Count != 1) return;
            var item = (Song)lstBoxSong.Items[0];
            var folder = Path.GetDirectoryName(item.Path);
            var allFiles = new DirectoryInfo(folder);
            var lstSongs = from n in allFiles.GetFiles()
                where new string[] {".mp3",".wav",".wma"}.Contains(n.Extension.ToLower())
                select n;
            var nextFile= lstSongs.SkipWhile(x => x.Name != item.FileName).Skip(1).FirstOrDefault();
            if (nextFile == null) return;
            lstBoxSong.Items.Clear();
            ListFiles = new Dictionary<int, Song>();
            var newSong = new Song
            {
                Path = nextFile.FullName,
                Id = 1,
                FileName = nextFile.Name
            };
            ListFiles.Add(1,newSong);
            lstBoxSong.Items.Add(newSong);
            CurrentSong = newSong;
          
        }
        private void PrevSongNotInList()
        {
            if (lstBoxSong.Items.Count != 1) return;
            var item = (Song)lstBoxSong.Items[0];
            var folder = Path.GetDirectoryName(item.Path);
            var allFiles = new DirectoryInfo(folder);
            var lstSongs = from n in allFiles.GetFiles()
                select n;
            var prevFile= lstSongs.TakeWhile(x => x.Name != item.FileName).LastOrDefault();
            if (prevFile == null) return;
            lstBoxSong.Items.Clear();
            ListFiles = new Dictionary<int, Song>();
            var newSong = new Song
            {
                Path = prevFile.FullName,
                Id = 1,
                FileName = prevFile.Name
            };
            ListFiles.Add(1,newSong);
            lstBoxSong.Items.Add(newSong);
            CurrentSong = newSong;
       
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            NextSongNotInList();
            NextSong();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            PrevSongNotInList();
            PrevSong();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (CurrentSong == null) return;
            Player.Seek = trackBar1.Value;
            TimeSpan t = TimeSpan.FromSeconds(Player.Seek);
            lblPosition.Text = t.Hours == 0 ? t.ToString(@"mm\:ss") : t.ToString(@"hh\:mm\:ss");
        }

        private void trackBar1_MouseDown(object sender, MouseEventArgs e)
        {
            Timerr.Stop();
        }

        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            Timerr.Start();
        }

        private void lstBoxSong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (lstBoxSong.SelectedIndex > -1)
                {
                    RemoveItem();
                }
                e.Handled = false;
            }
        }

        private void RemoveItem()
        {
            var item = lstBoxSong.SelectedItem;
            var index = lstBoxSong.SelectedIndex;
            lstBoxSong.Items.RemoveAt(index);
            ListFiles.Remove(((Song) item).Id);
            if (index < lstBoxSong.Items.Count)
            {
                lstBoxSong.SelectedIndex = index;
            }
            else
            {
                lstBoxSong.SelectedIndex = index - 1;
            }
        }

        private bool colspan = false;
        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (colspan)
            {
                tableLayoutPanel1.RowStyles[0].Height = 48;
                colspan = false;
            }
            else
            {
                tableLayoutPanel1.RowStyles[0].Height = 80;
                colspan = true;
            }
           
           
        }
        private void ComboBoxFonts_DrawItem(object sender, DrawItemEventArgs e)
        {
            var comboBox = (ComboBox)sender;
            var fontFamily = (FontFamily)comboBox.Items[e.Index];
            var font = new Font(fontFamily, comboBox.Font.SizeInPoints);
            e.DrawBackground();
            e.Graphics.DrawString(font.Name, font, Brushes.Black, e.Bounds.X, e.Bounds.Y);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily,(int)numericUpDown2.Value);
        }

        private void BoldRickText()
        {
            if (richTextBox1.SelectionFont.Bold)
            {
                richTextBox1.SelectionFont = richTextBox1.Font;
            }
            else
            {
              //  int selStart = richTextBox1.SelectionStart;
               // int selLength = richTextBox1.SelectionLength;
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
               // richTextBox1.SelectionStart = selStart + selLength;
               // richTextBox1.SelectionLength = 0;
               // richTextBox1.SelectionFont = richTextBox1.Font;
               // richTextBox1.Select(selStart, selLength);
            }
        }

        private void ColorRichText()
        {
            if (richTextBox1.SelectionBackColor == Color.Yellow)
            {
                richTextBox1.SelectionBackColor = richTextBox1.BackColor;
            }
            else
            {
               // int selStart = richTextBox1.SelectionStart;
               // int selLength = richTextBox1.SelectionLength;
                richTextBox1.SelectionBackColor = Color.Yellow;
               // richTextBox1.SelectionStart = selStart + selLength;
               // richTextBox1.SelectionLength = 0;
               // richTextBox1.SelectionBackColor = richTextBox1.BackColor;
                //richTextBox1.Select(selStart, selLength);
            }
        }
    }
}