namespace MoveCardsBetweenDecks
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
            this.labelDeck1 = new System.Windows.Forms.Label();
            this.labelDeck2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.reset1 = new System.Windows.Forms.Button();
            this.shuffle1 = new System.Windows.Forms.Button();
            this.reset2 = new System.Windows.Forms.Button();
            this.shuffle2 = new System.Windows.Forms.Button();
            this.moveToDeck2 = new System.Windows.Forms.Button();
            this.moveToDeck1 = new System.Windows.Forms.Button();
            this.sort1 = new System.Windows.Forms.Button();
            this.sort2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDeck1
            // 
            this.labelDeck1.AutoSize = true;
            this.labelDeck1.Location = new System.Drawing.Point(12, 9);
            this.labelDeck1.Name = "labelDeck1";
            this.labelDeck1.Size = new System.Drawing.Size(60, 17);
            this.labelDeck1.TabIndex = 0;
            this.labelDeck1.Text = "Deck #1";
            // 
            // labelDeck2
            // 
            this.labelDeck2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDeck2.AutoSize = true;
            this.labelDeck2.Location = new System.Drawing.Point(217, 9);
            this.labelDeck2.Name = "labelDeck2";
            this.labelDeck2.Size = new System.Drawing.Size(60, 17);
            this.labelDeck2.TabIndex = 1;
            this.labelDeck2.Text = "Deck #2";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(15, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 308);
            this.listBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(220, 29);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(150, 308);
            this.listBox2.TabIndex = 3;
            // 
            // reset1
            // 
            this.reset1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.reset1.Location = new System.Drawing.Point(15, 340);
            this.reset1.Name = "reset1";
            this.reset1.Size = new System.Drawing.Size(150, 23);
            this.reset1.TabIndex = 4;
            this.reset1.Text = "Reset Deck #1";
            this.reset1.UseVisualStyleBackColor = true;
            this.reset1.Click += new System.EventHandler(this.reset1_Click);
            // 
            // shuffle1
            // 
            this.shuffle1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.shuffle1.Location = new System.Drawing.Point(15, 369);
            this.shuffle1.Name = "shuffle1";
            this.shuffle1.Size = new System.Drawing.Size(150, 23);
            this.shuffle1.TabIndex = 5;
            this.shuffle1.Text = "Shuffle Deck #1";
            this.shuffle1.UseVisualStyleBackColor = true;
            this.shuffle1.Click += new System.EventHandler(this.shuffle1_Click);
            // 
            // reset2
            // 
            this.reset2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reset2.Location = new System.Drawing.Point(220, 340);
            this.reset2.Name = "reset2";
            this.reset2.Size = new System.Drawing.Size(150, 23);
            this.reset2.TabIndex = 6;
            this.reset2.Text = "Reset Deck #2";
            this.reset2.UseVisualStyleBackColor = true;
            this.reset2.Click += new System.EventHandler(this.reset2_Click);
            // 
            // shuffle2
            // 
            this.shuffle2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.shuffle2.Location = new System.Drawing.Point(220, 369);
            this.shuffle2.Name = "shuffle2";
            this.shuffle2.Size = new System.Drawing.Size(150, 23);
            this.shuffle2.TabIndex = 7;
            this.shuffle2.Text = "Shuffle Deck #2";
            this.shuffle2.UseVisualStyleBackColor = true;
            this.shuffle2.Click += new System.EventHandler(this.shuffle2_Click);
            // 
            // moveToDeck2
            // 
            this.moveToDeck2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.moveToDeck2.Location = new System.Drawing.Point(171, 123);
            this.moveToDeck2.Name = "moveToDeck2";
            this.moveToDeck2.Size = new System.Drawing.Size(43, 23);
            this.moveToDeck2.TabIndex = 8;
            this.moveToDeck2.Text = ">>";
            this.moveToDeck2.UseVisualStyleBackColor = true;
            this.moveToDeck2.Click += new System.EventHandler(this.moveToDeck2_Click);
            // 
            // moveToDeck1
            // 
            this.moveToDeck1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.moveToDeck1.Location = new System.Drawing.Point(171, 160);
            this.moveToDeck1.Name = "moveToDeck1";
            this.moveToDeck1.Size = new System.Drawing.Size(43, 23);
            this.moveToDeck1.TabIndex = 9;
            this.moveToDeck1.Text = "<<";
            this.moveToDeck1.UseVisualStyleBackColor = true;
            this.moveToDeck1.Click += new System.EventHandler(this.moveToDeck1_Click);
            // 
            // sort1
            // 
            this.sort1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sort1.Location = new System.Drawing.Point(15, 398);
            this.sort1.Name = "sort1";
            this.sort1.Size = new System.Drawing.Size(150, 23);
            this.sort1.TabIndex = 10;
            this.sort1.Text = "Sort Deck #1";
            this.sort1.UseVisualStyleBackColor = true;
            this.sort1.Click += new System.EventHandler(this.sort1_Click);
            // 
            // sort2
            // 
            this.sort2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sort2.Location = new System.Drawing.Point(220, 398);
            this.sort2.Name = "sort2";
            this.sort2.Size = new System.Drawing.Size(150, 23);
            this.sort2.TabIndex = 11;
            this.sort2.Text = "Sort Deck #2";
            this.sort2.UseVisualStyleBackColor = true;
            this.sort2.Click += new System.EventHandler(this.sort2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 433);
            this.Controls.Add(this.sort2);
            this.Controls.Add(this.sort1);
            this.Controls.Add(this.moveToDeck1);
            this.Controls.Add(this.moveToDeck2);
            this.Controls.Add(this.shuffle2);
            this.Controls.Add(this.reset2);
            this.Controls.Add(this.shuffle1);
            this.Controls.Add(this.reset1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelDeck2);
            this.Controls.Add(this.labelDeck1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "MainForm";
            this.Text = "Two Decks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDeck1;
        private System.Windows.Forms.Label labelDeck2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button reset1;
        private System.Windows.Forms.Button shuffle1;
        private System.Windows.Forms.Button reset2;
        private System.Windows.Forms.Button shuffle2;
        private System.Windows.Forms.Button moveToDeck2;
        private System.Windows.Forms.Button moveToDeck1;
        private System.Windows.Forms.Button sort1;
        private System.Windows.Forms.Button sort2;
    }
}