
namespace Spammeri
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.spamText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.applyEnter = new System.Windows.Forms.CheckBox();
            this.showEmojiBtn = new System.Windows.Forms.Button();
            this.applyHex = new System.Windows.Forms.CheckBox();
            this.applyEmoji = new System.Windows.Forms.CheckBox();
            this.applyMocking = new System.Windows.Forms.CheckBox();
            this.applyCtrlv = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.speedNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.stopHotkeyCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startHotkeyCombo = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sentLbl = new System.Windows.Forms.Label();
            this.spammingLbl = new System.Windows.Forms.Label();
            this.statusTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedNumeric)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // spamText
            // 
            this.spamText.AcceptsReturn = true;
            this.spamText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spamText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spamText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.spamText.Location = new System.Drawing.Point(3, 27);
            this.spamText.Multiline = true;
            this.spamText.Name = "spamText";
            this.spamText.Size = new System.Drawing.Size(1112, 384);
            this.spamText.TabIndex = 0;
            this.spamText.TextChanged += new System.EventHandler(this.spamText_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.spamText);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1118, 414);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Spam text";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 414);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1118, 70);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Features";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.Controls.Add(this.applyEnter, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.showEmojiBtn, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.applyHex, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.applyEmoji, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.applyMocking, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.applyCtrlv, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1112, 40);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // applyEnter
            // 
            this.applyEnter.AutoSize = true;
            this.applyEnter.Checked = true;
            this.applyEnter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.applyEnter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.applyEnter.Location = new System.Drawing.Point(3, 3);
            this.applyEnter.Name = "applyEnter";
            this.applyEnter.Size = new System.Drawing.Size(187, 34);
            this.applyEnter.TabIndex = 3;
            this.applyEnter.Text = "Apply enter to end";
            this.applyEnter.UseVisualStyleBackColor = true;
            // 
            // showEmojiBtn
            // 
            this.showEmojiBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.showEmojiBtn.Location = new System.Drawing.Point(942, 3);
            this.showEmojiBtn.Name = "showEmojiBtn";
            this.showEmojiBtn.Size = new System.Drawing.Size(174, 34);
            this.showEmojiBtn.TabIndex = 11;
            this.showEmojiBtn.Text = "Show Emojis";
            this.showEmojiBtn.UseVisualStyleBackColor = true;
            this.showEmojiBtn.Click += new System.EventHandler(this.showEmojiBtn_Click);
            // 
            // applyHex
            // 
            this.applyHex.AutoSize = true;
            this.applyHex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.applyHex.Location = new System.Drawing.Point(196, 3);
            this.applyHex.Name = "applyHex";
            this.applyHex.Size = new System.Drawing.Size(255, 34);
            this.applyHex.TabIndex = 2;
            this.applyHex.Text = "Apply hex escape detection";
            this.applyHex.UseVisualStyleBackColor = true;
            // 
            // applyEmoji
            // 
            this.applyEmoji.AutoSize = true;
            this.applyEmoji.Checked = true;
            this.applyEmoji.CheckState = System.Windows.Forms.CheckState.Checked;
            this.applyEmoji.Dock = System.Windows.Forms.DockStyle.Fill;
            this.applyEmoji.Location = new System.Drawing.Point(794, 3);
            this.applyEmoji.Name = "applyEmoji";
            this.applyEmoji.Size = new System.Drawing.Size(142, 34);
            this.applyEmoji.TabIndex = 0;
            this.applyEmoji.Text = "Apply emojis";
            this.applyEmoji.UseVisualStyleBackColor = true;
            // 
            // applyMocking
            // 
            this.applyMocking.AutoSize = true;
            this.applyMocking.Checked = true;
            this.applyMocking.CheckState = System.Windows.Forms.CheckState.Checked;
            this.applyMocking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.applyMocking.Location = new System.Drawing.Point(629, 3);
            this.applyMocking.Name = "applyMocking";
            this.applyMocking.Size = new System.Drawing.Size(159, 34);
            this.applyMocking.TabIndex = 1;
            this.applyMocking.Text = "Apply mocking";
            this.applyMocking.UseVisualStyleBackColor = true;
            // 
            // applyCtrlv
            // 
            this.applyCtrlv.AutoSize = true;
            this.applyCtrlv.Checked = true;
            this.applyCtrlv.CheckState = System.Windows.Forms.CheckState.Checked;
            this.applyCtrlv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.applyCtrlv.Location = new System.Drawing.Point(457, 3);
            this.applyCtrlv.Name = "applyCtrlv";
            this.applyCtrlv.Size = new System.Drawing.Size(166, 34);
            this.applyCtrlv.TabIndex = 6;
            this.applyCtrlv.Text = "Use ctrl+v spam";
            this.applyCtrlv.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 484);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 110);
            this.panel1.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel5);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.tableLayoutPanel4);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(801, 110);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controls";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.speedNumeric, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(548, 27);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(253, 80);
            this.tableLayoutPanel5.TabIndex = 13;
            // 
            // speedNumeric
            // 
            this.speedNumeric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.speedNumeric.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.speedNumeric.Location = new System.Drawing.Point(3, 43);
            this.speedNumeric.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.speedNumeric.Name = "speedNumeric";
            this.speedNumeric.Size = new System.Drawing.Size(247, 31);
            this.speedNumeric.TabIndex = 9;
            this.speedNumeric.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 40);
            this.label3.TabIndex = 8;
            this.label3.Text = "Delay (ms):";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(543, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 80);
            this.panel3.TabIndex = 7;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.startBtn, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.stopBtn, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(308, 27);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(235, 80);
            this.tableLayoutPanel4.TabIndex = 12;
            // 
            // startBtn
            // 
            this.startBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startBtn.Enabled = false;
            this.startBtn.Location = new System.Drawing.Point(3, 3);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(229, 34);
            this.startBtn.TabIndex = 5;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.startBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stopBtn.Enabled = false;
            this.stopBtn.Location = new System.Drawing.Point(3, 43);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(229, 34);
            this.stopBtn.TabIndex = 6;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.stopBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(303, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 80);
            this.panel2.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.66667F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.stopHotkeyCombo, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.startHotkeyCombo, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(300, 80);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start hotkey: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stopHotkeyCombo
            // 
            this.stopHotkeyCombo.DisplayMember = "Name";
            this.stopHotkeyCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stopHotkeyCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stopHotkeyCombo.FormattingEnabled = true;
            this.stopHotkeyCombo.Location = new System.Drawing.Point(123, 43);
            this.stopHotkeyCombo.Name = "stopHotkeyCombo";
            this.stopHotkeyCombo.Size = new System.Drawing.Size(174, 33);
            this.stopHotkeyCombo.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stop hotkey: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startHotkeyCombo
            // 
            this.startHotkeyCombo.DisplayMember = "Name";
            this.startHotkeyCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startHotkeyCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startHotkeyCombo.FormattingEnabled = true;
            this.startHotkeyCombo.Location = new System.Drawing.Point(123, 3);
            this.startHotkeyCombo.Name = "startHotkeyCombo";
            this.startHotkeyCombo.Size = new System.Drawing.Size(174, 33);
            this.startHotkeyCombo.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox4.Location = new System.Drawing.Point(801, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(317, 110);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Status";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.52703F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.47297F));
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.sentLbl, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.spammingLbl, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(311, 80);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 40);
            this.label7.TabIndex = 3;
            this.label7.Text = "Spams sent:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 40);
            this.label4.TabIndex = 0;
            this.label4.Text = "Spamming:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sentLbl
            // 
            this.sentLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sentLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sentLbl.ForeColor = System.Drawing.Color.Blue;
            this.sentLbl.Location = new System.Drawing.Point(125, 40);
            this.sentLbl.Name = "sentLbl";
            this.sentLbl.Size = new System.Drawing.Size(183, 40);
            this.sentLbl.TabIndex = 4;
            this.sentLbl.Text = "0";
            this.sentLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // spammingLbl
            // 
            this.spammingLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spammingLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spammingLbl.ForeColor = System.Drawing.Color.Red;
            this.spammingLbl.Location = new System.Drawing.Point(125, 0);
            this.spammingLbl.Name = "spammingLbl";
            this.spammingLbl.Size = new System.Drawing.Size(183, 40);
            this.spammingLbl.TabIndex = 2;
            this.spammingLbl.Text = "False";
            this.spammingLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusTimer
            // 
            this.statusTimer.Enabled = true;
            this.statusTimer.Interval = 10;
            this.statusTimer.Tick += new System.EventHandler(this.statusTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1118, 594);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1140, 650);
            this.Name = "MainForm";
            this.Text = "Spammeri  || FINAL SKIDDING VERSION 1.6";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedNumeric)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox spamText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox applyHex;
        private System.Windows.Forms.CheckBox applyMocking;
        private System.Windows.Forms.CheckBox applyEmoji;
        private System.Windows.Forms.CheckBox applyEnter;
        private System.Windows.Forms.Timer statusTimer;
        private System.Windows.Forms.CheckBox applyCtrlv;
        private System.Windows.Forms.Button showEmojiBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.NumericUpDown speedNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox stopHotkeyCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox startHotkeyCombo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label sentLbl;
        private System.Windows.Forms.Label spammingLbl;
    }
}

