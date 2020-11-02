namespace GUI_READ_WRITE_DATA
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
            this.LBoxCountries = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGetCountriesSA = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnSaveToFile = new System.Windows.Forms.Button();
            this.BtnAddToList = new System.Windows.Forms.Button();
            this.LBoxData = new System.Windows.Forms.ListBox();
            this.TxtData = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnAddItemToList = new System.Windows.Forms.Button();
            this.TxtToDoItem = new System.Windows.Forms.TextBox();
            this.LBoxToDoList = new System.Windows.Forms.ListBox();
            this.BtnSaveToDoList = new System.Windows.Forms.Button();
            this.BtnLoadToDoList = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBoxCountries
            // 
            this.LBoxCountries.FormattingEnabled = true;
            this.LBoxCountries.Location = new System.Drawing.Point(19, 54);
            this.LBoxCountries.Name = "LBoxCountries";
            this.LBoxCountries.Size = new System.Drawing.Size(191, 147);
            this.LBoxCountries.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Countries of South America";
            // 
            // BtnGetCountriesSA
            // 
            this.BtnGetCountriesSA.Location = new System.Drawing.Point(19, 218);
            this.BtnGetCountriesSA.Name = "BtnGetCountriesSA";
            this.BtnGetCountriesSA.Size = new System.Drawing.Size(191, 23);
            this.BtnGetCountriesSA.TabIndex = 2;
            this.BtnGetCountriesSA.Text = "Get and Display Countries";
            this.BtnGetCountriesSA.UseVisualStyleBackColor = true;
            this.BtnGetCountriesSA.Click += new System.EventHandler(this.BtnGetCountriesSA_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Turquoise;
            this.groupBox1.Controls.Add(this.BtnGetCountriesSA);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LBoxCountries);
            this.groupBox1.Location = new System.Drawing.Point(20, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 259);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EXAMPLE #1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.BtnSaveToFile);
            this.groupBox2.Controls.Add(this.BtnAddToList);
            this.groupBox2.Controls.Add(this.LBoxData);
            this.groupBox2.Controls.Add(this.TxtData);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(285, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 328);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EXAMPLE #2";
            // 
            // BtnSaveToFile
            // 
            this.BtnSaveToFile.Location = new System.Drawing.Point(59, 285);
            this.BtnSaveToFile.Name = "BtnSaveToFile";
            this.BtnSaveToFile.Size = new System.Drawing.Size(219, 27);
            this.BtnSaveToFile.TabIndex = 4;
            this.BtnSaveToFile.Text = "Save to File";
            this.BtnSaveToFile.UseVisualStyleBackColor = true;
            this.BtnSaveToFile.Click += new System.EventHandler(this.BtnSaveToFile_Click);
            // 
            // BtnAddToList
            // 
            this.BtnAddToList.Location = new System.Drawing.Point(103, 69);
            this.BtnAddToList.Name = "BtnAddToList";
            this.BtnAddToList.Size = new System.Drawing.Size(200, 23);
            this.BtnAddToList.TabIndex = 3;
            this.BtnAddToList.Text = "Add data to List Box below";
            this.BtnAddToList.UseVisualStyleBackColor = true;
            this.BtnAddToList.Click += new System.EventHandler(this.BtnAddToList_Click);
            // 
            // LBoxData
            // 
            this.LBoxData.FormattingEnabled = true;
            this.LBoxData.Location = new System.Drawing.Point(30, 107);
            this.LBoxData.Name = "LBoxData";
            this.LBoxData.Size = new System.Drawing.Size(273, 160);
            this.LBoxData.TabIndex = 2;
            // 
            // TxtData
            // 
            this.TxtData.Location = new System.Drawing.Point(103, 31);
            this.TxtData.Name = "TxtData";
            this.TxtData.Size = new System.Drawing.Size(200, 20);
            this.TxtData.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Data";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox3.Controls.Add(this.BtnRemove);
            this.groupBox3.Controls.Add(this.BtnAddItemToList);
            this.groupBox3.Controls.Add(this.TxtToDoItem);
            this.groupBox3.Controls.Add(this.LBoxToDoList);
            this.groupBox3.Controls.Add(this.BtnSaveToDoList);
            this.groupBox3.Controls.Add(this.BtnLoadToDoList);
            this.groupBox3.Location = new System.Drawing.Point(20, 302);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 352);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Example #3";
            // 
            // BtnAddItemToList
            // 
            this.BtnAddItemToList.Location = new System.Drawing.Point(49, 86);
            this.BtnAddItemToList.Name = "BtnAddItemToList";
            this.BtnAddItemToList.Size = new System.Drawing.Size(122, 24);
            this.BtnAddItemToList.TabIndex = 5;
            this.BtnAddItemToList.Text = "Add item to List";
            this.BtnAddItemToList.UseVisualStyleBackColor = true;
            this.BtnAddItemToList.Click += new System.EventHandler(this.BtnAddItemToList_Click);
            // 
            // TxtToDoItem
            // 
            this.TxtToDoItem.Location = new System.Drawing.Point(21, 58);
            this.TxtToDoItem.Name = "TxtToDoItem";
            this.TxtToDoItem.Size = new System.Drawing.Size(176, 20);
            this.TxtToDoItem.TabIndex = 4;
            // 
            // LBoxToDoList
            // 
            this.LBoxToDoList.FormattingEnabled = true;
            this.LBoxToDoList.Location = new System.Drawing.Point(22, 120);
            this.LBoxToDoList.Name = "LBoxToDoList";
            this.LBoxToDoList.Size = new System.Drawing.Size(176, 134);
            this.LBoxToDoList.TabIndex = 3;
            // 
            // BtnSaveToDoList
            // 
            this.BtnSaveToDoList.Location = new System.Drawing.Point(19, 317);
            this.BtnSaveToDoList.Name = "BtnSaveToDoList";
            this.BtnSaveToDoList.Size = new System.Drawing.Size(179, 23);
            this.BtnSaveToDoList.TabIndex = 2;
            this.BtnSaveToDoList.Text = "Save To-Do List";
            this.BtnSaveToDoList.UseVisualStyleBackColor = true;
            this.BtnSaveToDoList.Click += new System.EventHandler(this.BtnSaveToDoList_Click);
            // 
            // BtnLoadToDoList
            // 
            this.BtnLoadToDoList.Location = new System.Drawing.Point(19, 26);
            this.BtnLoadToDoList.Name = "BtnLoadToDoList";
            this.BtnLoadToDoList.Size = new System.Drawing.Size(179, 23);
            this.BtnLoadToDoList.TabIndex = 1;
            this.BtnLoadToDoList.Text = "Load To-Do List";
            this.BtnLoadToDoList.UseVisualStyleBackColor = true;
            this.BtnLoadToDoList.Click += new System.EventHandler(this.BtnLoadToDoList_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(19, 272);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(178, 23);
            this.BtnRemove.TabIndex = 6;
            this.BtnRemove.Text = "Delete selected item";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 666);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "GUI_READ_WRITE_DATA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LBoxCountries;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGetCountriesSA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSaveToFile;
        private System.Windows.Forms.Button BtnAddToList;
        private System.Windows.Forms.ListBox LBoxData;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnSaveToDoList;
        private System.Windows.Forms.Button BtnLoadToDoList;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button BtnAddItemToList;
        private System.Windows.Forms.TextBox TxtToDoItem;
        private System.Windows.Forms.ListBox LBoxToDoList;
        private System.Windows.Forms.Button BtnRemove;
    }
}

