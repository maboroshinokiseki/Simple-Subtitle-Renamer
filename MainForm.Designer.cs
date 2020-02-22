namespace SimpleSubtitleRenamer
{
    partial class MainForm
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
            this.tableLayoutPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_Files = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_Videos = new System.Windows.Forms.TableLayoutPanel();
            this.listBox_Videos = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel_VideoButtons = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel_VideoButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.button_VideoMoveUp = new System.Windows.Forms.Button();
            this.button_VideoMoveDown = new System.Windows.Forms.Button();
            this.button_VideoDelete = new System.Windows.Forms.Button();
            this.button_VideoClear = new System.Windows.Forms.Button();
            this.tableLayoutPanel_Subtitles = new System.Windows.Forms.TableLayoutPanel();
            this.listBox_Subtitles = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel_SubtitleButtons = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel_SubtitleButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.button_SubtitleMoveUp = new System.Windows.Forms.Button();
            this.button_SubtitleMoveDown = new System.Windows.Forms.Button();
            this.button_SubtitleDelete = new System.Windows.Forms.Button();
            this.button_SubtitleClear = new System.Windows.Forms.Button();
            this.button_Rename = new System.Windows.Forms.Button();
            this.checkBox_Preview = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel_Prepend = new System.Windows.Forms.TableLayoutPanel();
            this.label_Prepend = new System.Windows.Forms.Label();
            this.textBox_Prepend = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel_Append = new System.Windows.Forms.TableLayoutPanel();
            this.label_Append = new System.Windows.Forms.Label();
            this.textBox_Append = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel_Main.SuspendLayout();
            this.tableLayoutPanel_Files.SuspendLayout();
            this.tableLayoutPanel_Videos.SuspendLayout();
            this.tableLayoutPanel_VideoButtons.SuspendLayout();
            this.flowLayoutPanel_VideoButtons.SuspendLayout();
            this.tableLayoutPanel_Subtitles.SuspendLayout();
            this.tableLayoutPanel_SubtitleButtons.SuspendLayout();
            this.flowLayoutPanel_SubtitleButtons.SuspendLayout();
            this.tableLayoutPanel_Prepend.SuspendLayout();
            this.tableLayoutPanel_Append.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Main
            // 
            this.tableLayoutPanel_Main.ColumnCount = 1;
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Main.Controls.Add(this.tableLayoutPanel_Files, 0, 2);
            this.tableLayoutPanel_Main.Controls.Add(this.tableLayoutPanel_Prepend, 0, 0);
            this.tableLayoutPanel_Main.Controls.Add(this.tableLayoutPanel_Append, 0, 1);
            this.tableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Main.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Main.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel_Main.Name = "tableLayoutPanel_Main";
            this.tableLayoutPanel_Main.RowCount = 3;
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_Main.Size = new System.Drawing.Size(1067, 554);
            this.tableLayoutPanel_Main.TabIndex = 0;
            // 
            // tableLayoutPanel_Files
            // 
            this.tableLayoutPanel_Files.ColumnCount = 2;
            this.tableLayoutPanel_Files.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Files.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Files.Controls.Add(this.tableLayoutPanel_Videos, 0, 0);
            this.tableLayoutPanel_Files.Controls.Add(this.tableLayoutPanel_Subtitles, 0, 0);
            this.tableLayoutPanel_Files.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Files.Location = new System.Drawing.Point(4, 80);
            this.tableLayoutPanel_Files.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel_Files.Name = "tableLayoutPanel_Files";
            this.tableLayoutPanel_Files.RowCount = 1;
            this.tableLayoutPanel_Files.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Files.Size = new System.Drawing.Size(1059, 470);
            this.tableLayoutPanel_Files.TabIndex = 1;
            // 
            // tableLayoutPanel_Videos
            // 
            this.tableLayoutPanel_Videos.ColumnCount = 2;
            this.tableLayoutPanel_Videos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Videos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_Videos.Controls.Add(this.listBox_Videos, 0, 0);
            this.tableLayoutPanel_Videos.Controls.Add(this.tableLayoutPanel_VideoButtons, 1, 0);
            this.tableLayoutPanel_Videos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Videos.Location = new System.Drawing.Point(533, 4);
            this.tableLayoutPanel_Videos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel_Videos.Name = "tableLayoutPanel_Videos";
            this.tableLayoutPanel_Videos.RowCount = 1;
            this.tableLayoutPanel_Videos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Videos.Size = new System.Drawing.Size(522, 462);
            this.tableLayoutPanel_Videos.TabIndex = 1;
            // 
            // listBox_Videos
            // 
            this.listBox_Videos.AllowDrop = true;
            this.listBox_Videos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Videos.FormattingEnabled = true;
            this.listBox_Videos.ItemHeight = 16;
            this.listBox_Videos.Location = new System.Drawing.Point(4, 4);
            this.listBox_Videos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox_Videos.Name = "listBox_Videos";
            this.listBox_Videos.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox_Videos.Size = new System.Drawing.Size(390, 454);
            this.listBox_Videos.TabIndex = 0;
            this.listBox_Videos.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBox_Videos_DragDrop);
            this.listBox_Videos.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            // 
            // tableLayoutPanel_VideoButtons
            // 
            this.tableLayoutPanel_VideoButtons.AutoSize = true;
            this.tableLayoutPanel_VideoButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel_VideoButtons.ColumnCount = 1;
            this.tableLayoutPanel_VideoButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_VideoButtons.Controls.Add(this.flowLayoutPanel_VideoButtons, 0, 1);
            this.tableLayoutPanel_VideoButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_VideoButtons.Location = new System.Drawing.Point(402, 4);
            this.tableLayoutPanel_VideoButtons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel_VideoButtons.Name = "tableLayoutPanel_VideoButtons";
            this.tableLayoutPanel_VideoButtons.RowCount = 3;
            this.tableLayoutPanel_VideoButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_VideoButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_VideoButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel_VideoButtons.Size = new System.Drawing.Size(116, 454);
            this.tableLayoutPanel_VideoButtons.TabIndex = 1;
            // 
            // flowLayoutPanel_VideoButtons
            // 
            this.flowLayoutPanel_VideoButtons.AutoSize = true;
            this.flowLayoutPanel_VideoButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel_VideoButtons.Controls.Add(this.button_VideoMoveUp);
            this.flowLayoutPanel_VideoButtons.Controls.Add(this.button_VideoMoveDown);
            this.flowLayoutPanel_VideoButtons.Controls.Add(this.button_VideoDelete);
            this.flowLayoutPanel_VideoButtons.Controls.Add(this.button_VideoClear);
            this.flowLayoutPanel_VideoButtons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_VideoButtons.Location = new System.Drawing.Point(4, 154);
            this.flowLayoutPanel_VideoButtons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel_VideoButtons.Name = "flowLayoutPanel_VideoButtons";
            this.flowLayoutPanel_VideoButtons.Size = new System.Drawing.Size(108, 144);
            this.flowLayoutPanel_VideoButtons.TabIndex = 2;
            // 
            // button_VideoMoveUp
            // 
            this.button_VideoMoveUp.Location = new System.Drawing.Point(4, 4);
            this.button_VideoMoveUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_VideoMoveUp.Name = "button_VideoMoveUp";
            this.button_VideoMoveUp.Size = new System.Drawing.Size(100, 28);
            this.button_VideoMoveUp.TabIndex = 0;
            this.button_VideoMoveUp.Text = "▲";
            this.button_VideoMoveUp.UseVisualStyleBackColor = true;
            this.button_VideoMoveUp.Click += new System.EventHandler(this.Button_VideoMoveUp_Click);
            // 
            // button_VideoMoveDown
            // 
            this.button_VideoMoveDown.Location = new System.Drawing.Point(4, 40);
            this.button_VideoMoveDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_VideoMoveDown.Name = "button_VideoMoveDown";
            this.button_VideoMoveDown.Size = new System.Drawing.Size(100, 28);
            this.button_VideoMoveDown.TabIndex = 1;
            this.button_VideoMoveDown.Text = "▼";
            this.button_VideoMoveDown.UseVisualStyleBackColor = true;
            this.button_VideoMoveDown.Click += new System.EventHandler(this.Button_VideoMoveDown_Click);
            // 
            // button_VideoDelete
            // 
            this.button_VideoDelete.Location = new System.Drawing.Point(4, 76);
            this.button_VideoDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_VideoDelete.Name = "button_VideoDelete";
            this.button_VideoDelete.Size = new System.Drawing.Size(100, 28);
            this.button_VideoDelete.TabIndex = 2;
            this.button_VideoDelete.Text = "Delete";
            this.button_VideoDelete.UseVisualStyleBackColor = true;
            this.button_VideoDelete.Click += new System.EventHandler(this.Button_VideoDelete_Click);
            // 
            // button_VideoClear
            // 
            this.button_VideoClear.Location = new System.Drawing.Point(4, 112);
            this.button_VideoClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_VideoClear.Name = "button_VideoClear";
            this.button_VideoClear.Size = new System.Drawing.Size(100, 28);
            this.button_VideoClear.TabIndex = 3;
            this.button_VideoClear.Text = "Clear";
            this.button_VideoClear.UseVisualStyleBackColor = true;
            this.button_VideoClear.Click += new System.EventHandler(this.Button_VideoClear_Click);
            // 
            // tableLayoutPanel_Subtitles
            // 
            this.tableLayoutPanel_Subtitles.ColumnCount = 2;
            this.tableLayoutPanel_Subtitles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Subtitles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_Subtitles.Controls.Add(this.listBox_Subtitles, 0, 0);
            this.tableLayoutPanel_Subtitles.Controls.Add(this.tableLayoutPanel_SubtitleButtons, 1, 0);
            this.tableLayoutPanel_Subtitles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Subtitles.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel_Subtitles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel_Subtitles.Name = "tableLayoutPanel_Subtitles";
            this.tableLayoutPanel_Subtitles.RowCount = 1;
            this.tableLayoutPanel_Subtitles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Subtitles.Size = new System.Drawing.Size(521, 462);
            this.tableLayoutPanel_Subtitles.TabIndex = 0;
            // 
            // listBox_Subtitles
            // 
            this.listBox_Subtitles.AllowDrop = true;
            this.listBox_Subtitles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Subtitles.FormattingEnabled = true;
            this.listBox_Subtitles.ItemHeight = 16;
            this.listBox_Subtitles.Location = new System.Drawing.Point(4, 4);
            this.listBox_Subtitles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox_Subtitles.Name = "listBox_Subtitles";
            this.listBox_Subtitles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox_Subtitles.Size = new System.Drawing.Size(389, 454);
            this.listBox_Subtitles.TabIndex = 0;
            this.listBox_Subtitles.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBox_Subtitles_DragDrop);
            this.listBox_Subtitles.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            // 
            // tableLayoutPanel_SubtitleButtons
            // 
            this.tableLayoutPanel_SubtitleButtons.AutoSize = true;
            this.tableLayoutPanel_SubtitleButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel_SubtitleButtons.ColumnCount = 1;
            this.tableLayoutPanel_SubtitleButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_SubtitleButtons.Controls.Add(this.flowLayoutPanel_SubtitleButtons, 0, 1);
            this.tableLayoutPanel_SubtitleButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_SubtitleButtons.Location = new System.Drawing.Point(401, 4);
            this.tableLayoutPanel_SubtitleButtons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel_SubtitleButtons.Name = "tableLayoutPanel_SubtitleButtons";
            this.tableLayoutPanel_SubtitleButtons.RowCount = 3;
            this.tableLayoutPanel_SubtitleButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_SubtitleButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_SubtitleButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel_SubtitleButtons.Size = new System.Drawing.Size(116, 454);
            this.tableLayoutPanel_SubtitleButtons.TabIndex = 1;
            // 
            // flowLayoutPanel_SubtitleButtons
            // 
            this.flowLayoutPanel_SubtitleButtons.AutoSize = true;
            this.flowLayoutPanel_SubtitleButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel_SubtitleButtons.Controls.Add(this.button_SubtitleMoveUp);
            this.flowLayoutPanel_SubtitleButtons.Controls.Add(this.button_SubtitleMoveDown);
            this.flowLayoutPanel_SubtitleButtons.Controls.Add(this.button_SubtitleDelete);
            this.flowLayoutPanel_SubtitleButtons.Controls.Add(this.button_SubtitleClear);
            this.flowLayoutPanel_SubtitleButtons.Controls.Add(this.button_Rename);
            this.flowLayoutPanel_SubtitleButtons.Controls.Add(this.checkBox_Preview);
            this.flowLayoutPanel_SubtitleButtons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_SubtitleButtons.Location = new System.Drawing.Point(4, 122);
            this.flowLayoutPanel_SubtitleButtons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel_SubtitleButtons.Name = "flowLayoutPanel_SubtitleButtons";
            this.flowLayoutPanel_SubtitleButtons.Size = new System.Drawing.Size(108, 209);
            this.flowLayoutPanel_SubtitleButtons.TabIndex = 2;
            // 
            // button_SubtitleMoveUp
            // 
            this.button_SubtitleMoveUp.Location = new System.Drawing.Point(4, 4);
            this.button_SubtitleMoveUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_SubtitleMoveUp.Name = "button_SubtitleMoveUp";
            this.button_SubtitleMoveUp.Size = new System.Drawing.Size(100, 28);
            this.button_SubtitleMoveUp.TabIndex = 0;
            this.button_SubtitleMoveUp.Text = "▲";
            this.button_SubtitleMoveUp.UseVisualStyleBackColor = true;
            this.button_SubtitleMoveUp.Click += new System.EventHandler(this.Button_SubtitleMoveUp_Click);
            // 
            // button_SubtitleMoveDown
            // 
            this.button_SubtitleMoveDown.Location = new System.Drawing.Point(4, 40);
            this.button_SubtitleMoveDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_SubtitleMoveDown.Name = "button_SubtitleMoveDown";
            this.button_SubtitleMoveDown.Size = new System.Drawing.Size(100, 28);
            this.button_SubtitleMoveDown.TabIndex = 1;
            this.button_SubtitleMoveDown.Text = "▼";
            this.button_SubtitleMoveDown.UseVisualStyleBackColor = true;
            this.button_SubtitleMoveDown.Click += new System.EventHandler(this.Button_SubtitleMoveDown_Click);
            // 
            // button_SubtitleDelete
            // 
            this.button_SubtitleDelete.Location = new System.Drawing.Point(4, 76);
            this.button_SubtitleDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_SubtitleDelete.Name = "button_SubtitleDelete";
            this.button_SubtitleDelete.Size = new System.Drawing.Size(100, 28);
            this.button_SubtitleDelete.TabIndex = 2;
            this.button_SubtitleDelete.Text = "Delete";
            this.button_SubtitleDelete.UseVisualStyleBackColor = true;
            this.button_SubtitleDelete.Click += new System.EventHandler(this.Button_SubtitleDelete_Click);
            // 
            // button_SubtitleClear
            // 
            this.button_SubtitleClear.Location = new System.Drawing.Point(4, 112);
            this.button_SubtitleClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_SubtitleClear.Name = "button_SubtitleClear";
            this.button_SubtitleClear.Size = new System.Drawing.Size(100, 28);
            this.button_SubtitleClear.TabIndex = 3;
            this.button_SubtitleClear.Text = "Clear";
            this.button_SubtitleClear.UseVisualStyleBackColor = true;
            this.button_SubtitleClear.Click += new System.EventHandler(this.Button_SubtitleClear_Click);
            // 
            // button_Rename
            // 
            this.button_Rename.Location = new System.Drawing.Point(4, 148);
            this.button_Rename.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Rename.Name = "button_Rename";
            this.button_Rename.Size = new System.Drawing.Size(100, 28);
            this.button_Rename.TabIndex = 4;
            this.button_Rename.Text = "Rename";
            this.button_Rename.UseVisualStyleBackColor = true;
            this.button_Rename.Click += new System.EventHandler(this.Button_Rename_Click);
            // 
            // checkBox_Preview
            // 
            this.checkBox_Preview.AutoSize = true;
            this.checkBox_Preview.Location = new System.Drawing.Point(4, 184);
            this.checkBox_Preview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_Preview.Name = "checkBox_Preview";
            this.checkBox_Preview.Size = new System.Drawing.Size(79, 21);
            this.checkBox_Preview.TabIndex = 5;
            this.checkBox_Preview.Text = "Preview";
            this.checkBox_Preview.UseVisualStyleBackColor = true;
            this.checkBox_Preview.CheckedChanged += new System.EventHandler(this.CheckBox_Preview_CheckedChanged);
            // 
            // tableLayoutPanel_Prepend
            // 
            this.tableLayoutPanel_Prepend.AutoSize = true;
            this.tableLayoutPanel_Prepend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel_Prepend.ColumnCount = 2;
            this.tableLayoutPanel_Prepend.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel_Prepend.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Prepend.Controls.Add(this.label_Prepend, 0, 0);
            this.tableLayoutPanel_Prepend.Controls.Add(this.textBox_Prepend, 1, 0);
            this.tableLayoutPanel_Prepend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Prepend.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel_Prepend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel_Prepend.Name = "tableLayoutPanel_Prepend";
            this.tableLayoutPanel_Prepend.RowCount = 1;
            this.tableLayoutPanel_Prepend.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Prepend.Size = new System.Drawing.Size(1059, 30);
            this.tableLayoutPanel_Prepend.TabIndex = 2;
            // 
            // label_Prepend
            // 
            this.label_Prepend.AutoSize = true;
            this.label_Prepend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Prepend.Location = new System.Drawing.Point(4, 0);
            this.label_Prepend.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Prepend.Name = "label_Prepend";
            this.label_Prepend.Size = new System.Drawing.Size(72, 30);
            this.label_Prepend.TabIndex = 0;
            this.label_Prepend.Text = "Prepend:";
            this.label_Prepend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_Prepend
            // 
            this.textBox_Prepend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Prepend.Location = new System.Drawing.Point(84, 4);
            this.textBox_Prepend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Prepend.Name = "textBox_Prepend";
            this.textBox_Prepend.Size = new System.Drawing.Size(971, 22);
            this.textBox_Prepend.TabIndex = 1;
            this.textBox_Prepend.TextChanged += new System.EventHandler(this.TextBox_Prepend_TextChanged);
            // 
            // tableLayoutPanel_Append
            // 
            this.tableLayoutPanel_Append.AutoSize = true;
            this.tableLayoutPanel_Append.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel_Append.ColumnCount = 2;
            this.tableLayoutPanel_Append.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel_Append.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Append.Controls.Add(this.label_Append, 0, 0);
            this.tableLayoutPanel_Append.Controls.Add(this.textBox_Append, 1, 0);
            this.tableLayoutPanel_Append.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Append.Location = new System.Drawing.Point(4, 42);
            this.tableLayoutPanel_Append.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel_Append.Name = "tableLayoutPanel_Append";
            this.tableLayoutPanel_Append.RowCount = 1;
            this.tableLayoutPanel_Append.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Append.Size = new System.Drawing.Size(1059, 30);
            this.tableLayoutPanel_Append.TabIndex = 3;
            // 
            // label_Append
            // 
            this.label_Append.AutoSize = true;
            this.label_Append.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Append.Location = new System.Drawing.Point(4, 0);
            this.label_Append.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Append.Name = "label_Append";
            this.label_Append.Size = new System.Drawing.Size(72, 30);
            this.label_Append.TabIndex = 0;
            this.label_Append.Text = "Append:";
            this.label_Append.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_Append
            // 
            this.textBox_Append.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Append.Location = new System.Drawing.Point(84, 4);
            this.textBox_Append.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Append.Name = "textBox_Append";
            this.textBox_Append.Size = new System.Drawing.Size(971, 22);
            this.textBox_Append.TabIndex = 1;
            this.textBox_Append.TextChanged += new System.EventHandler(this.TextBox_Append_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tableLayoutPanel_Main);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Simple Subtitle Renamer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel_Main.ResumeLayout(false);
            this.tableLayoutPanel_Main.PerformLayout();
            this.tableLayoutPanel_Files.ResumeLayout(false);
            this.tableLayoutPanel_Videos.ResumeLayout(false);
            this.tableLayoutPanel_Videos.PerformLayout();
            this.tableLayoutPanel_VideoButtons.ResumeLayout(false);
            this.tableLayoutPanel_VideoButtons.PerformLayout();
            this.flowLayoutPanel_VideoButtons.ResumeLayout(false);
            this.tableLayoutPanel_Subtitles.ResumeLayout(false);
            this.tableLayoutPanel_Subtitles.PerformLayout();
            this.tableLayoutPanel_SubtitleButtons.ResumeLayout(false);
            this.tableLayoutPanel_SubtitleButtons.PerformLayout();
            this.flowLayoutPanel_SubtitleButtons.ResumeLayout(false);
            this.flowLayoutPanel_SubtitleButtons.PerformLayout();
            this.tableLayoutPanel_Prepend.ResumeLayout(false);
            this.tableLayoutPanel_Prepend.PerformLayout();
            this.tableLayoutPanel_Append.ResumeLayout(false);
            this.tableLayoutPanel_Append.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Main;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Files;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Subtitles;
        private System.Windows.Forms.ListBox listBox_Subtitles;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_SubtitleButtons;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_SubtitleButtons;
        private System.Windows.Forms.Button button_SubtitleMoveUp;
        private System.Windows.Forms.Button button_SubtitleMoveDown;
        private System.Windows.Forms.Button button_SubtitleDelete;
        private System.Windows.Forms.Button button_SubtitleClear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Videos;
        private System.Windows.Forms.ListBox listBox_Videos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_VideoButtons;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_VideoButtons;
        private System.Windows.Forms.Button button_VideoMoveUp;
        private System.Windows.Forms.Button button_VideoMoveDown;
        private System.Windows.Forms.Button button_VideoDelete;
        private System.Windows.Forms.Button button_VideoClear;
        private System.Windows.Forms.Button button_Rename;
        private System.Windows.Forms.CheckBox checkBox_Preview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Prepend;
        private System.Windows.Forms.Label label_Prepend;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Append;
        private System.Windows.Forms.Label label_Append;
        private System.Windows.Forms.TextBox textBox_Prepend;
        private System.Windows.Forms.TextBox textBox_Append;
    }
}

