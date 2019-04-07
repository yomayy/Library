namespace Library
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.genreList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.genreEdit = new System.Windows.Forms.TextBox();
            this.genreAdd = new System.Windows.Forms.Button();
            this.genreDel = new System.Windows.Forms.Button();
            this.genreReset = new System.Windows.Forms.Button();
            this.genreUpdate = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(900, 562);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(892, 529);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Жанры";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(892, 529);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Издательства";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(892, 529);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Библиотекари";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(892, 529);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Читатели";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(892, 529);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Книги";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 29);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(892, 529);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Авторы";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 29);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(892, 529);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Журнал";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.genreList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 523);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Просмотр";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.genreUpdate);
            this.groupBox2.Controls.Add(this.genreReset);
            this.groupBox2.Controls.Add(this.genreDel);
            this.groupBox2.Controls.Add(this.genreAdd);
            this.groupBox2.Controls.Add(this.genreEdit);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(396, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(493, 523);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Редактирование";
            // 
            // genreList
            // 
            this.genreList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.genreList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genreList.FullRowSelect = true;
            this.genreList.Location = new System.Drawing.Point(3, 23);
            this.genreList.Name = "genreList";
            this.genreList.Size = new System.Drawing.Size(387, 497);
            this.genreList.TabIndex = 0;
            this.genreList.UseCompatibleStateImageBehavior = false;
            this.genreList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Название жанра";
            this.columnHeader2.Width = 300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название жанра";
            // 
            // genreEdit
            // 
            this.genreEdit.Location = new System.Drawing.Point(6, 132);
            this.genreEdit.Name = "genreEdit";
            this.genreEdit.Size = new System.Drawing.Size(302, 27);
            this.genreEdit.TabIndex = 1;
            // 
            // genreAdd
            // 
            this.genreAdd.Location = new System.Drawing.Point(97, 165);
            this.genreAdd.Name = "genreAdd";
            this.genreAdd.Size = new System.Drawing.Size(211, 28);
            this.genreAdd.TabIndex = 2;
            this.genreAdd.Text = "Добавить";
            this.genreAdd.UseVisualStyleBackColor = true;
            // 
            // genreDel
            // 
            this.genreDel.Location = new System.Drawing.Point(97, 199);
            this.genreDel.Name = "genreDel";
            this.genreDel.Size = new System.Drawing.Size(211, 28);
            this.genreDel.TabIndex = 3;
            this.genreDel.Text = "Удалить";
            this.genreDel.UseVisualStyleBackColor = true;
            // 
            // genreReset
            // 
            this.genreReset.Location = new System.Drawing.Point(97, 267);
            this.genreReset.Name = "genreReset";
            this.genreReset.Size = new System.Drawing.Size(211, 28);
            this.genreReset.TabIndex = 4;
            this.genreReset.Text = "Очистить";
            this.genreReset.UseVisualStyleBackColor = true;
            // 
            // genreUpdate
            // 
            this.genreUpdate.Location = new System.Drawing.Point(97, 233);
            this.genreUpdate.Name = "genreUpdate";
            this.genreUpdate.Size = new System.Drawing.Size(211, 28);
            this.genreUpdate.TabIndex = 5;
            this.genreUpdate.Text = "Изменить";
            this.genreUpdate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автоматизированная система управления библиотекой";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button genreUpdate;
        private System.Windows.Forms.Button genreReset;
        private System.Windows.Forms.Button genreDel;
        private System.Windows.Forms.Button genreAdd;
        private System.Windows.Forms.TextBox genreEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView genreList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

