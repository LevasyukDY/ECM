namespace CacheWork
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cacheTextBox = new System.Windows.Forms.TextBox();
            this.mainMemoryTextBox = new System.Windows.Forms.TextBox();
            this.cacheLabel = new System.Windows.Forms.Label();
            this.mainMemoryLabel = new System.Windows.Forms.Label();
            this.segmentTextBox = new System.Windows.Forms.TextBox();
            this.stringTextBox = new System.Windows.Forms.TextBox();
            this.elementTextBox = new System.Windows.Forms.TextBox();
            this.segmentLabel = new System.Windows.Forms.Label();
            this.stringLabel = new System.Windows.Forms.Label();
            this.elementLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.newElementLabel = new System.Windows.Forms.Label();
            this.newElementTextBox = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.stringFromLabel = new System.Windows.Forms.Label();
            this.stringFromTextBox = new System.Windows.Forms.TextBox();
            this.elementFromLabel = new System.Windows.Forms.Label();
            this.elementFromTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cacheTextBox
            // 
            this.cacheTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.cacheTextBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cacheTextBox.Location = new System.Drawing.Point(12, 43);
            this.cacheTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cacheTextBox.Multiline = true;
            this.cacheTextBox.Name = "cacheTextBox";
            this.cacheTextBox.ReadOnly = true;
            this.cacheTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cacheTextBox.Size = new System.Drawing.Size(164, 333);
            this.cacheTextBox.TabIndex = 0;
            // 
            // mainMemoryTextBox
            // 
            this.mainMemoryTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.mainMemoryTextBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainMemoryTextBox.Location = new System.Drawing.Point(201, 43);
            this.mainMemoryTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainMemoryTextBox.Multiline = true;
            this.mainMemoryTextBox.Name = "mainMemoryTextBox";
            this.mainMemoryTextBox.ReadOnly = true;
            this.mainMemoryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mainMemoryTextBox.Size = new System.Drawing.Size(164, 333);
            this.mainMemoryTextBox.TabIndex = 1;
            // 
            // cacheLabel
            // 
            this.cacheLabel.AutoSize = true;
            this.cacheLabel.BackColor = System.Drawing.SystemColors.Window;
            this.cacheLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cacheLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cacheLabel.Location = new System.Drawing.Point(40, 11);
            this.cacheLabel.Name = "cacheLabel";
            this.cacheLabel.Size = new System.Drawing.Size(109, 21);
            this.cacheLabel.TabIndex = 2;
            this.cacheLabel.Text = "КЭШ память";
            // 
            // mainMemoryLabel
            // 
            this.mainMemoryLabel.AutoSize = true;
            this.mainMemoryLabel.BackColor = System.Drawing.SystemColors.Window;
            this.mainMemoryLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainMemoryLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainMemoryLabel.Location = new System.Drawing.Point(208, 11);
            this.mainMemoryLabel.Name = "mainMemoryLabel";
            this.mainMemoryLabel.Size = new System.Drawing.Size(151, 21);
            this.mainMemoryLabel.TabIndex = 3;
            this.mainMemoryLabel.Text = "Основная память";
            // 
            // segmentTextBox
            // 
            this.segmentTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.segmentTextBox.Location = new System.Drawing.Point(487, 43);
            this.segmentTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.segmentTextBox.Name = "segmentTextBox";
            this.segmentTextBox.Size = new System.Drawing.Size(91, 22);
            this.segmentTextBox.TabIndex = 4;
            this.segmentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stringTextBox
            // 
            this.stringTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stringTextBox.Location = new System.Drawing.Point(487, 78);
            this.stringTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stringTextBox.Name = "stringTextBox";
            this.stringTextBox.Size = new System.Drawing.Size(91, 22);
            this.stringTextBox.TabIndex = 5;
            this.stringTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // elementTextBox
            // 
            this.elementTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.elementTextBox.Location = new System.Drawing.Point(488, 112);
            this.elementTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.elementTextBox.Name = "elementTextBox";
            this.elementTextBox.Size = new System.Drawing.Size(91, 22);
            this.elementTextBox.TabIndex = 6;
            this.elementTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // segmentLabel
            // 
            this.segmentLabel.BackColor = System.Drawing.SystemColors.InfoText;
            this.segmentLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.segmentLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.segmentLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.segmentLabel.Location = new System.Drawing.Point(405, 43);
            this.segmentLabel.Name = "segmentLabel";
            this.segmentLabel.Size = new System.Drawing.Size(76, 22);
            this.segmentLabel.TabIndex = 7;
            this.segmentLabel.Text = "Сегмент:";
            this.segmentLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // stringLabel
            // 
            this.stringLabel.BackColor = System.Drawing.SystemColors.InfoText;
            this.stringLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stringLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stringLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.stringLabel.Location = new System.Drawing.Point(405, 78);
            this.stringLabel.Name = "stringLabel";
            this.stringLabel.Size = new System.Drawing.Size(76, 22);
            this.stringLabel.TabIndex = 8;
            this.stringLabel.Text = "Строка:";
            this.stringLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // elementLabel
            // 
            this.elementLabel.BackColor = System.Drawing.SystemColors.InfoText;
            this.elementLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.elementLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.elementLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.elementLabel.Location = new System.Drawing.Point(405, 112);
            this.elementLabel.Name = "elementLabel";
            this.elementLabel.Size = new System.Drawing.Size(77, 22);
            this.elementLabel.TabIndex = 9;
            this.elementLabel.Text = "Элемент:";
            this.elementLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.SkyBlue;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton.Location = new System.Drawing.Point(451, 141);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 27);
            this.searchButton.TabIndex = 10;
            this.searchButton.Text = "Найти";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // newElementLabel
            // 
            this.newElementLabel.BackColor = System.Drawing.SystemColors.InfoText;
            this.newElementLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newElementLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newElementLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.newElementLabel.Location = new System.Drawing.Point(405, 201);
            this.newElementLabel.Name = "newElementLabel";
            this.newElementLabel.Size = new System.Drawing.Size(77, 22);
            this.newElementLabel.TabIndex = 12;
            this.newElementLabel.Text = "Элемент:";
            this.newElementLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // newElementTextBox
            // 
            this.newElementTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newElementTextBox.Location = new System.Drawing.Point(487, 201);
            this.newElementTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newElementTextBox.Name = "newElementTextBox";
            this.newElementTextBox.Size = new System.Drawing.Size(91, 22);
            this.newElementTextBox.TabIndex = 11;
            this.newElementTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.SkyBlue;
            this.changeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeButton.Location = new System.Drawing.Point(445, 230);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(88, 27);
            this.changeButton.TabIndex = 13;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.SystemColors.InfoText;
            this.statusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.statusLabel.Location = new System.Drawing.Point(12, 384);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(64, 23);
            this.statusLabel.TabIndex = 14;
            this.statusLabel.Text = "Статус:";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusTextBox
            // 
            this.statusTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.statusTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.statusTextBox.Location = new System.Drawing.Point(74, 383);
            this.statusTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(535, 26);
            this.statusTextBox.TabIndex = 15;
            this.statusTextBox.Text = " Файл основной памяти заполнен произвольными значениями";
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.SystemColors.InfoText;
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.timeLabel.Location = new System.Drawing.Point(377, 282);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(77, 22);
            this.timeLabel.TabIndex = 17;
            this.timeLabel.Text = "Время:";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timeTextBox
            // 
            this.timeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.timeTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeTextBox.Location = new System.Drawing.Point(451, 282);
            this.timeTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.ReadOnly = true;
            this.timeTextBox.Size = new System.Drawing.Size(158, 22);
            this.timeTextBox.TabIndex = 16;
            this.timeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stringFromLabel
            // 
            this.stringFromLabel.BackColor = System.Drawing.SystemColors.InfoText;
            this.stringFromLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stringFromLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stringFromLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.stringFromLabel.Location = new System.Drawing.Point(377, 312);
            this.stringFromLabel.Name = "stringFromLabel";
            this.stringFromLabel.Size = new System.Drawing.Size(77, 22);
            this.stringFromLabel.TabIndex = 19;
            this.stringFromLabel.Text = "Строка:";
            this.stringFromLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // stringFromTextBox
            // 
            this.stringFromTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.stringFromTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stringFromTextBox.Location = new System.Drawing.Point(451, 312);
            this.stringFromTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stringFromTextBox.Name = "stringFromTextBox";
            this.stringFromTextBox.ReadOnly = true;
            this.stringFromTextBox.Size = new System.Drawing.Size(158, 22);
            this.stringFromTextBox.TabIndex = 18;
            this.stringFromTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // elementFromLabel
            // 
            this.elementFromLabel.BackColor = System.Drawing.SystemColors.InfoText;
            this.elementFromLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.elementFromLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.elementFromLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.elementFromLabel.Location = new System.Drawing.Point(377, 342);
            this.elementFromLabel.Name = "elementFromLabel";
            this.elementFromLabel.Size = new System.Drawing.Size(77, 22);
            this.elementFromLabel.TabIndex = 21;
            this.elementFromLabel.Text = "Элемент:";
            this.elementFromLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // elementFromTextBox
            // 
            this.elementFromTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.elementFromTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.elementFromTextBox.Location = new System.Drawing.Point(451, 342);
            this.elementFromTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.elementFromTextBox.Name = "elementFromTextBox";
            this.elementFromTextBox.ReadOnly = true;
            this.elementFromTextBox.Size = new System.Drawing.Size(158, 22);
            this.elementFromTextBox.TabIndex = 20;
            this.elementFromTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CacheWork.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(621, 415);
            this.Controls.Add(this.elementFromLabel);
            this.Controls.Add(this.elementFromTextBox);
            this.Controls.Add(this.stringFromLabel);
            this.Controls.Add(this.stringFromTextBox);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.newElementLabel);
            this.Controls.Add(this.newElementTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.elementLabel);
            this.Controls.Add(this.stringLabel);
            this.Controls.Add(this.segmentLabel);
            this.Controls.Add(this.elementTextBox);
            this.Controls.Add(this.stringTextBox);
            this.Controls.Add(this.segmentTextBox);
            this.Controls.Add(this.mainMemoryLabel);
            this.Controls.Add(this.cacheLabel);
            this.Controls.Add(this.mainMemoryTextBox);
            this.Controls.Add(this.cacheTextBox);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Моделирование работы КЭШ памяти";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cacheTextBox;
        private System.Windows.Forms.TextBox mainMemoryTextBox;
        private System.Windows.Forms.Label cacheLabel;
        private System.Windows.Forms.Label mainMemoryLabel;
        private System.Windows.Forms.TextBox segmentTextBox;
        private System.Windows.Forms.TextBox stringTextBox;
        private System.Windows.Forms.TextBox elementTextBox;
        private System.Windows.Forms.Label segmentLabel;
        private System.Windows.Forms.Label stringLabel;
        private System.Windows.Forms.Label elementLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label newElementLabel;
        private System.Windows.Forms.TextBox newElementTextBox;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Label stringFromLabel;
        private System.Windows.Forms.TextBox stringFromTextBox;
        private System.Windows.Forms.Label elementFromLabel;
        private System.Windows.Forms.TextBox elementFromTextBox;
    }
}

