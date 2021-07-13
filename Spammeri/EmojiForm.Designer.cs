
namespace Spammeri
{
    partial class EmojiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmojiForm));
            this.addBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.emojiTxt = new System.Windows.Forms.TextBox();
            this.emojisList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.Location = new System.Drawing.Point(12, 446);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(604, 40);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removeBtn.Enabled = false;
            this.removeBtn.Location = new System.Drawing.Point(12, 492);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(604, 40);
            this.removeBtn.TabIndex = 1;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // emojiTxt
            // 
            this.emojiTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emojiTxt.Location = new System.Drawing.Point(12, 409);
            this.emojiTxt.Name = "emojiTxt";
            this.emojiTxt.Size = new System.Drawing.Size(604, 31);
            this.emojiTxt.TabIndex = 2;
            // 
            // emojisList
            // 
            this.emojisList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emojisList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emojisList.FormattingEnabled = true;
            this.emojisList.ItemHeight = 25;
            this.emojisList.Location = new System.Drawing.Point(12, 12);
            this.emojisList.Name = "emojisList";
            this.emojisList.Size = new System.Drawing.Size(604, 377);
            this.emojisList.TabIndex = 3;
            this.emojisList.SelectedIndexChanged += new System.EventHandler(this.emojisList_SelectedIndexChanged);
            // 
            // EmojiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 544);
            this.Controls.Add(this.emojisList);
            this.Controls.Add(this.emojiTxt);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmojiForm";
            this.Text = "Emojis";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmojiForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.TextBox emojiTxt;
        private System.Windows.Forms.ListBox emojisList;
    }
}