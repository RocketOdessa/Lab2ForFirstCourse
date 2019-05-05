namespace МОЯПОПЫТКАНОМЕР
{
    partial class Form1
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
            System.Windows.Forms.Button searchRectAndCube;
            this.Calculate = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.Rectangle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textHeight = new System.Windows.Forms.TextBox();
            this.textWigth = new System.Windows.Forms.TextBox();
            this.textHeigth_par = new System.Windows.Forms.TextBox();
            this.HeightParallel = new System.Windows.Forms.Label();
            this.HeightRect = new System.Windows.Forms.Label();
            this.widthRect = new System.Windows.Forms.Label();
            this.dataGridRect = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Square = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rectWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rectHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagonalRect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perimetrRect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridParallel = new System.Windows.Forms.DataGridView();
            this.IDParallel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parallelHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parallelSquare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeParallel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddToGrid = new System.Windows.Forms.Button();
            this.forSearchButton = new System.Windows.Forms.RichTextBox();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            searchRectAndCube = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParallel)).BeginInit();
            this.SuspendLayout();
            // 
            // searchRectAndCube
            // 
            searchRectAndCube.Location = new System.Drawing.Point(380, 417);
            searchRectAndCube.Name = "searchRectAndCube";
            searchRectAndCube.Size = new System.Drawing.Size(108, 48);
            searchRectAndCube.TabIndex = 14;
            searchRectAndCube.Text = "Search";
            searchRectAndCube.UseVisualStyleBackColor = true;
            searchRectAndCube.Click += new System.EventHandler(this.searchRectAndCube_Click);
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(483, 122);
            this.Calculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(108, 46);
            this.Calculate.TabIndex = 0;
            this.Calculate.Text = "Start";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(258, 155);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(204, 154);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(11, 155);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(204, 154);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            // 
            // Rectangle
            // 
            this.Rectangle.AutoSize = true;
            this.Rectangle.Location = new System.Drawing.Point(11, 137);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(72, 17);
            this.Rectangle.TabIndex = 3;
            this.Rectangle.Text = "Rectangle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Parallelepiped";
            // 
            // textHeight
            // 
            this.textHeight.Location = new System.Drawing.Point(14, 48);
            this.textHeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textHeight.Name = "textHeight";
            this.textHeight.Size = new System.Drawing.Size(89, 22);
            this.textHeight.TabIndex = 5;
            // 
            // textWigth
            // 
            this.textWigth.Location = new System.Drawing.Point(14, 94);
            this.textWigth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textWigth.Name = "textWigth";
            this.textWigth.Size = new System.Drawing.Size(89, 22);
            this.textWigth.TabIndex = 6;
            // 
            // textHeigth_par
            // 
            this.textHeigth_par.Location = new System.Drawing.Point(258, 48);
            this.textHeigth_par.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textHeigth_par.Name = "textHeigth_par";
            this.textHeigth_par.Size = new System.Drawing.Size(89, 22);
            this.textHeigth_par.TabIndex = 7;
            // 
            // HeightParallel
            // 
            this.HeightParallel.AutoSize = true;
            this.HeightParallel.Location = new System.Drawing.Point(364, 53);
            this.HeightParallel.Name = "HeightParallel";
            this.HeightParallel.Size = new System.Drawing.Size(96, 17);
            this.HeightParallel.TabIndex = 8;
            this.HeightParallel.Text = "HeightParallel";
            // 
            // HeightRect
            // 
            this.HeightRect.AutoSize = true;
            this.HeightRect.Location = new System.Drawing.Point(123, 53);
            this.HeightRect.Name = "HeightRect";
            this.HeightRect.Size = new System.Drawing.Size(78, 17);
            this.HeightRect.TabIndex = 9;
            this.HeightRect.Text = "HeightRect";
            // 
            // widthRect
            // 
            this.widthRect.AutoSize = true;
            this.widthRect.Location = new System.Drawing.Point(123, 97);
            this.widthRect.Name = "widthRect";
            this.widthRect.Size = new System.Drawing.Size(73, 17);
            this.widthRect.TabIndex = 10;
            this.widthRect.Text = "WidthRect";
            // 
            // dataGridRect
            // 
            this.dataGridRect.AllowUserToDeleteRows = false;
            this.dataGridRect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Square,
            this.rectWidth,
            this.rectHeight,
            this.diagonalRect,
            this.perimetrRect});
            this.dataGridRect.Location = new System.Drawing.Point(610, 12);
            this.dataGridRect.Name = "dataGridRect";
            this.dataGridRect.RowTemplate.Height = 24;
            this.dataGridRect.Size = new System.Drawing.Size(645, 196);
            this.dataGridRect.TabIndex = 11;
            // 
            // ID
            // 
            this.ID.HeaderText = "N-Rect";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Square
            // 
            this.Square.HeaderText = "SquareRect";
            this.Square.Name = "Square";
            this.Square.ReadOnly = true;
            // 
            // rectWidth
            // 
            this.rectWidth.HeaderText = "width";
            this.rectWidth.Name = "rectWidth";
            this.rectWidth.ReadOnly = true;
            // 
            // rectHeight
            // 
            this.rectHeight.HeaderText = "Height";
            this.rectHeight.Name = "rectHeight";
            this.rectHeight.ReadOnly = true;
            // 
            // diagonalRect
            // 
            this.diagonalRect.HeaderText = "Diagonal";
            this.diagonalRect.Name = "diagonalRect";
            this.diagonalRect.ReadOnly = true;
            // 
            // perimetrRect
            // 
            this.perimetrRect.HeaderText = "Perimetr";
            this.perimetrRect.Name = "perimetrRect";
            this.perimetrRect.ReadOnly = true;
            // 
            // dataGridParallel
            // 
            this.dataGridParallel.AllowUserToDeleteRows = false;
            this.dataGridParallel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridParallel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDParallel,
            this.parallelHeight,
            this.parallelSquare,
            this.volumeParallel});
            this.dataGridParallel.Location = new System.Drawing.Point(610, 271);
            this.dataGridParallel.Name = "dataGridParallel";
            this.dataGridParallel.RowTemplate.Height = 24;
            this.dataGridParallel.Size = new System.Drawing.Size(645, 150);
            this.dataGridParallel.TabIndex = 12;
            // 
            // IDParallel
            // 
            this.IDParallel.HeaderText = "M-Parallel";
            this.IDParallel.Name = "IDParallel";
            this.IDParallel.ReadOnly = true;
            // 
            // parallelHeight
            // 
            this.parallelHeight.HeaderText = "HeightParallel";
            this.parallelHeight.Name = "parallelHeight";
            this.parallelHeight.ReadOnly = true;
            // 
            // parallelSquare
            // 
            this.parallelSquare.HeaderText = "SquareParallel";
            this.parallelSquare.Name = "parallelSquare";
            this.parallelSquare.ReadOnly = true;
            // 
            // volumeParallel
            // 
            this.volumeParallel.HeaderText = "Volume";
            this.volumeParallel.Name = "volumeParallel";
            this.volumeParallel.ReadOnly = true;
            // 
            // AddToGrid
            // 
            this.AddToGrid.Location = new System.Drawing.Point(483, 303);
            this.AddToGrid.Name = "AddToGrid";
            this.AddToGrid.Size = new System.Drawing.Size(108, 44);
            this.AddToGrid.TabIndex = 13;
            this.AddToGrid.Text = "AddToGrid";
            this.AddToGrid.UseVisualStyleBackColor = true;
            this.AddToGrid.Click += new System.EventHandler(this.AddToGrid_Click);
            // 
            // forSearchButton
            // 
            this.forSearchButton.Location = new System.Drawing.Point(57, 314);
            this.forSearchButton.Name = "forSearchButton";
            this.forSearchButton.ReadOnly = true;
            this.forSearchButton.Size = new System.Drawing.Size(308, 259);
            this.forSearchButton.TabIndex = 15;
            this.forSearchButton.Text = "";
            // 
            // openDialog
            // 
            this.openDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 585);
            this.Controls.Add(this.forSearchButton);
            this.Controls.Add(searchRectAndCube);
            this.Controls.Add(this.AddToGrid);
            this.Controls.Add(this.dataGridParallel);
            this.Controls.Add(this.dataGridRect);
            this.Controls.Add(this.widthRect);
            this.Controls.Add(this.HeightRect);
            this.Controls.Add(this.HeightParallel);
            this.Controls.Add(this.textHeigth_par);
            this.Controls.Add(this.textWigth);
            this.Controls.Add(this.textHeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rectangle);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Calculate);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParallel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label Rectangle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textHeight;
        private System.Windows.Forms.TextBox textWigth;
        private System.Windows.Forms.TextBox textHeigth_par;
        private System.Windows.Forms.Label HeightParallel;
        private System.Windows.Forms.Label HeightRect;
        private System.Windows.Forms.Label widthRect;
        private System.Windows.Forms.DataGridView dataGridRect;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Square;
        private System.Windows.Forms.DataGridViewTextBoxColumn rectWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn rectHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagonalRect;
        private System.Windows.Forms.DataGridViewTextBoxColumn perimetrRect;
        private System.Windows.Forms.DataGridView dataGridParallel;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDParallel;
        private System.Windows.Forms.DataGridViewTextBoxColumn parallelHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn parallelSquare;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeParallel;
        private System.Windows.Forms.Button AddToGrid;
        private System.Windows.Forms.RichTextBox forSearchButton;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.SaveFileDialog saveDialog;
    }
}

