
namespace KursachForms1
{
    partial class CheckDish
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
            mainTextBox = new TextBox();
            deleteDataButton = new Button();
            dishComboBox = new ComboBox();
            dishDataGridView = new DataGridView();
            markupLabel = new Label();
            editDataButton = new Button();
            resaveDataButton = new Button();
            notesTextBox = new TextBox();
            countButton = new Button();
            sumButton = new Button();
            avgButton = new Button();
            saveToFileButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dishDataGridView).BeginInit();
            SuspendLayout();
            // 
            // mainTextBox
            // 
            mainTextBox.Location = new Point(2, 3);
            mainTextBox.Multiline = true;
            mainTextBox.Name = "mainTextBox";
            mainTextBox.Size = new Size(462, 621);
            mainTextBox.TabIndex = 0;
            mainTextBox.TextChanged += mainTextBox_TextChanged;
            // 
            // deleteDataButton
            // 
            deleteDataButton.Location = new Point(631, 344);
            deleteDataButton.Name = "deleteDataButton";
            deleteDataButton.Size = new Size(192, 29);
            deleteDataButton.TabIndex = 1;
            deleteDataButton.Text = "Удалить данные из бд";
            deleteDataButton.UseVisualStyleBackColor = true;
            deleteDataButton.Click += deleteDataButton_Click;
            // 
            // dishComboBox
            // 
            dishComboBox.FormattingEnabled = true;
            dishComboBox.Location = new Point(589, 301);
            dishComboBox.Name = "dishComboBox";
            dishComboBox.Size = new Size(274, 28);
            dishComboBox.TabIndex = 2;
            dishComboBox.SelectedIndexChanged += dishComboBox_SelectedIndexChanged;
            // 
            // dishDataGridView
            // 
            dishDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dishDataGridView.Location = new Point(563, 103);
            dishDataGridView.Name = "dishDataGridView";
            dishDataGridView.RowHeadersWidth = 51;
            dishDataGridView.Size = new Size(316, 192);
            dishDataGridView.TabIndex = 3;
            dishDataGridView.CellContentClick += dishDataGridView_CellContentClick;
            // 
            // markupLabel
            // 
            markupLabel.AutoSize = true;
            markupLabel.Location = new Point(684, 80);
            markupLabel.Name = "markupLabel";
            markupLabel.Size = new Size(110, 20);
            markupLabel.TabIndex = 4;
            markupLabel.Text = "Наценка блюд";
            // 
            // editDataButton
            // 
            editDataButton.Location = new Point(621, 388);
            editDataButton.Name = "editDataButton";
            editDataButton.Size = new Size(202, 29);
            editDataButton.TabIndex = 5;
            editDataButton.Text = "Редактировать данные";
            editDataButton.UseVisualStyleBackColor = true;
            editDataButton.Click += editDataButton_Click;
            //


            // resaveDataButton
            // 
            resaveDataButton.Location = new Point(631, 38);
            resaveDataButton.Name = "resaveDataButton";
            resaveDataButton.Size = new Size(220, 29);
            resaveDataButton.TabIndex = 6;
            resaveDataButton.Text = "Пересохранить данные в бд";
            resaveDataButton.UseVisualStyleBackColor = true;
            resaveDataButton.Click += resaveDataButton_Click;
            // 
            // notesTextBox
            // 
            notesTextBox.Location = new Point(491, 423);
            notesTextBox.Multiline = true;
            notesTextBox.Name = "notesTextBox";
            notesTextBox.Size = new Size(462, 149);
            notesTextBox.TabIndex = 7;
            notesTextBox.TextChanged += notesTextBox_TextChanged;
            // 
            // countButton
            // 
            countButton.Location = new Point(510, 595);
            countButton.Name = "countButton";
            countButton.Size = new Size(94, 29);
            countButton.TabIndex = 8;
            countButton.Text = "Count";
            countButton.UseVisualStyleBackColor = true;
            countButton.Click += countButton_Click;
            // 
            // sumButton
            // 
            sumButton.Location = new Point(684, 595);
            sumButton.Name = "sumButton";
            sumButton.Size = new Size(94, 29);
            sumButton.TabIndex = 9;
            sumButton.Text = "Sum";
            sumButton.UseVisualStyleBackColor = true;
            sumButton.Click += sumButton_Click;
            // 
            // avgButton
            // 
            avgButton.Location = new Point(859, 595);
            avgButton.Name = "avgButton";
            avgButton.Size = new Size(94, 29);
            avgButton.TabIndex = 10;
            avgButton.Text = "Avg";
            avgButton.UseVisualStyleBackColor = true;
            avgButton.Click += avgButton_Click;
            // 
            // saveToFileButton
            // 
            saveToFileButton.Location = new Point(904, 276);
            saveToFileButton.Name = "saveToFileButton";
            saveToFileButton.Size = new Size(94, 53);
            saveToFileButton.TabIndex = 11;
            saveToFileButton.Text = "Данные в файл";
            saveToFileButton.UseVisualStyleBackColor = true;
            saveToFileButton.Click += saveToFileButton_Click;
            // 
            // CheckDish
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 636);
            Controls.Add(saveToFileButton);
            Controls.Add(avgButton);
            Controls.Add(sumButton);
            Controls.Add(countButton);
            Controls.Add(notesTextBox);
            Controls.Add(resaveDataButton);
            Controls.Add(editDataButton);
            Controls.Add(markupLabel);
            Controls.Add(dishDataGridView);
            Controls.Add(dishComboBox);
            Controls.Add(deleteDataButton);
            Controls.Add(mainTextBox);
            Name = "CheckDish";
            Text = "CheckDish";
            Load += CheckDish_Load;
            ((System.ComponentModel.ISupportInitialize)dishDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private TextBox mainTextBox;
        private Button deleteDataButton;
        private ComboBox dishComboBox;
        private DataGridView dishDataGridView;
        private Label markupLabel;
        private Button editDataButton;
        private Button resaveDataButton;
        private TextBox notesTextBox;
        private Button countButton;
        private Button sumButton;
        private Button avgButton;
        private Button saveToFileButton;
    } 
}
