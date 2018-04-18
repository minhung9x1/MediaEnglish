namespace MediaEnglish
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstBoxSong = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkPauseTime = new System.Windows.Forms.CheckBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSetting = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDuring = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevTime = new System.Windows.Forms.Button();
            this.btnNextTime = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.rbList = new System.Windows.Forms.RadioButton();
            this.btnPrev = new System.Windows.Forms.Button();
            this.rbFile = new System.Windows.Forms.RadioButton();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.chkOnTop = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 553);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1023, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1023, 553);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 83);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lstBoxSong);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1017, 467);
            this.splitContainer1.SplitterDistance = 214;
            this.splitContainer1.TabIndex = 11;
            // 
            // lstBoxSong
            // 
            this.lstBoxSong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstBoxSong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBoxSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxSong.FormattingEnabled = true;
            this.lstBoxSong.ItemHeight = 16;
            this.lstBoxSong.Location = new System.Drawing.Point(0, 0);
            this.lstBoxSong.Name = "lstBoxSong";
            this.lstBoxSong.Size = new System.Drawing.Size(214, 467);
            this.lstBoxSong.TabIndex = 0;
            this.lstBoxSong.SelectedIndexChanged += new System.EventHandler(this.LstBoxSong_SelectedIndexChanged);
            this.lstBoxSong.DoubleClick += new System.EventHandler(this.LstBoxSong_DoubleClick);
            this.lstBoxSong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstBoxSong_KeyDown);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(799, 467);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkOnTop);
            this.panel1.Controls.Add(this.chkPauseTime);
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSetting);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lblDuring);
            this.panel1.Controls.Add(this.lblPosition);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPrevTime);
            this.panel1.Controls.Add(this.btnNextTime);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.rbList);
            this.panel1.Controls.Add(this.btnPrev);
            this.panel1.Controls.Add(this.rbFile);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.btnOpen);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 74);
            this.panel1.TabIndex = 1;
            // 
            // chkPauseTime
            // 
            this.chkPauseTime.AutoSize = true;
            this.chkPauseTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPauseTime.Location = new System.Drawing.Point(500, 54);
            this.chkPauseTime.Name = "chkPauseTime";
            this.chkPauseTime.Size = new System.Drawing.Size(97, 20);
            this.chkPauseTime.TabIndex = 19;
            this.chkPauseTime.Text = "Lùi khi dừng";
            this.chkPauseTime.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(442, 51);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(42, 22);
            this.numericUpDown2.TabIndex = 18;
            this.numericUpDown2.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(219, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 23);
            this.comboBox1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Repeat";
            // 
            // btnSetting
            // 
            this.btnSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.Location = new System.Drawing.Point(983, 14);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(25, 10);
            this.btnSetting.TabIndex = 15;
            this.btnSetting.Text = "s";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(147, 14);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(36, 18);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "Play";
            // 
            // lblDuring
            // 
            this.lblDuring.AutoSize = true;
            this.lblDuring.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuring.Location = new System.Drawing.Point(666, 14);
            this.lblDuring.Name = "lblDuring";
            this.lblDuring.Size = new System.Drawing.Size(56, 16);
            this.lblDuring.TabIndex = 13;
            this.lblDuring.Text = "00:00:00";
            // 
            // lblPosition
            // 
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(217, 14);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPosition.Size = new System.Drawing.Size(56, 16);
            this.lblPosition.TabIndex = 13;
            this.lblPosition.Text = "00:00:00";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(780, 45);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(37, 22);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = ">|";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevTime
            // 
            this.btnPrevTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevTime.Location = new System.Drawing.Point(835, 45);
            this.btnPrevTime.Name = "btnPrevTime";
            this.btnPrevTime.Size = new System.Drawing.Size(37, 22);
            this.btnPrevTime.TabIndex = 3;
            this.btnPrevTime.Text = "<<";
            this.btnPrevTime.UseVisualStyleBackColor = true;
            this.btnPrevTime.Click += new System.EventHandler(this.btnPrevTime_Click);
            // 
            // btnNextTime
            // 
            this.btnNextTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextTime.Location = new System.Drawing.Point(925, 45);
            this.btnNextTime.Name = "btnNextTime";
            this.btnNextTime.Size = new System.Drawing.Size(37, 22);
            this.btnNextTime.TabIndex = 3;
            this.btnNextTime.Text = ">>";
            this.btnNextTime.UseVisualStyleBackColor = true;
            this.btnNextTime.Click += new System.EventHandler(this.btnNextTime_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(878, 45);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(40, 22);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // rbList
            // 
            this.rbList.AutoSize = true;
            this.rbList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbList.Location = new System.Drawing.Point(123, 50);
            this.rbList.Name = "rbList";
            this.rbList.Size = new System.Drawing.Size(46, 20);
            this.rbList.TabIndex = 8;
            this.rbList.Text = "List";
            this.rbList.UseVisualStyleBackColor = true;
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(737, 45);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(37, 22);
            this.btnPrev.TabIndex = 3;
            this.btnPrev.Text = "|<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // rbFile
            // 
            this.rbFile.AutoSize = true;
            this.rbFile.Checked = true;
            this.rbFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFile.Location = new System.Drawing.Point(69, 50);
            this.rbFile.Name = "rbFile";
            this.rbFile.Size = new System.Drawing.Size(48, 20);
            this.rbFile.TabIndex = 8;
            this.rbFile.TabStop = true;
            this.rbFile.Text = "File";
            this.rbFile.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(737, 7);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(80, 32);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(12, 8);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(80, 32);
            this.btnOpen.TabIndex = 7;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(270, 10);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(393, 45);
            this.trackBar1.TabIndex = 12;
            this.trackBar1.TickFrequency = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseDown);
            this.trackBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseUp);
            // 
            // chkOnTop
            // 
            this.chkOnTop.AutoSize = true;
            this.chkOnTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnTop.Location = new System.Drawing.Point(603, 55);
            this.chkOnTop.Name = "chkOnTop";
            this.chkOnTop.Size = new System.Drawing.Size(69, 20);
            this.chkOnTop.TabIndex = 20;
            this.chkOnTop.Text = "OnTop";
            this.chkOnTop.UseVisualStyleBackColor = true;
            this.chkOnTop.CheckedChanged += new System.EventHandler(this.chkOnTop_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 575);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Media English Player";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lstBoxSong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDuring;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevTime;
        private System.Windows.Forms.Button btnNextTime;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RadioButton rbList;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.RadioButton rbFile;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.CheckBox chkPauseTime;
        private System.Windows.Forms.CheckBox chkOnTop;
    }
}

