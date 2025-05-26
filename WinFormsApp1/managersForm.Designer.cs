namespace WinFormsApp1
{
    partial class managersForm
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
            backBtN = new Button();
            addBtN = new Button();
            deleteBtN = new Button();
            editBtN = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // backBtN
            // 
            backBtN.Location = new Point(29, 29);
            backBtN.Name = "backBtN";
            backBtN.Size = new Size(94, 29);
            backBtN.TabIndex = 0;
            backBtN.Text = "Назад";
            backBtN.UseVisualStyleBackColor = true;
            backBtN.Click += backBtN_Click;
            // 
            // addBtN
            // 
            addBtN.Location = new Point(544, 29);
            addBtN.Name = "addBtN";
            addBtN.Size = new Size(124, 61);
            addBtN.TabIndex = 1;
            addBtN.Text = "Добавление";
            addBtN.UseVisualStyleBackColor = true;
            addBtN.Click += addBtN_Click;
            // 
            // deleteBtN
            // 
            deleteBtN.Location = new Point(674, 29);
            deleteBtN.Name = "deleteBtN";
            deleteBtN.Size = new Size(114, 61);
            deleteBtN.TabIndex = 2;
            deleteBtN.Text = "Удалить";
            deleteBtN.UseVisualStyleBackColor = true;
            // 
            // editBtN
            // 
            editBtN.Location = new Point(658, 396);
            editBtN.Name = "editBtN";
            editBtN.Size = new Size(130, 42);
            editBtN.TabIndex = 3;
            editBtN.Text = "Редактировать";
            editBtN.UseVisualStyleBackColor = true;
            editBtN.Click += editBtN_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(45, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(707, 254);
            dataGridView1.TabIndex = 4;
            // 
            // managersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(editBtN);
            Controls.Add(deleteBtN);
            Controls.Add(addBtN);
            Controls.Add(backBtN);
            Name = "managersForm";
            Text = "Менеджеры";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button backBtN;
        private Button addBtN;
        private Button deleteBtN;
        private Button editBtN;
        private DataGridView dataGridView1;
    }
}