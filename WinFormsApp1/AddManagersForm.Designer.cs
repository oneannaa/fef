namespace WinFormsApp1
{
    partial class AddManagersForm
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
            editBtN = new Button();
            dataGridView1 = new DataGridView();
            famTB = new TextBox();
            nameTB = new TextBox();
            otchestvoTB = new TextBox();
            dataTB = new TextBox();
            spravkaTB = new TextBox();
            dopuskTB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // backBtN
            // 
            backBtN.Location = new Point(16, 385);
            backBtN.Name = "backBtN";
            backBtN.Size = new Size(79, 29);
            backBtN.TabIndex = 0;
            backBtN.Text = "Назад";
            backBtN.UseVisualStyleBackColor = true;
            backBtN.Click += backBtN_Click;
            // 
            // editBtN
            // 
            editBtN.Location = new Point(694, 385);
            editBtN.Name = "editBtN";
            editBtN.Size = new Size(94, 46);
            editBtN.TabIndex = 1;
            editBtN.Text = "Добавить";
            editBtN.UseVisualStyleBackColor = true;
            editBtN.Click += editBtN_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(116, 153);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(554, 278);
            dataGridView1.TabIndex = 2;
            // 
            // famTB
            // 
            famTB.Location = new Point(35, 31);
            famTB.Name = "famTB";
            famTB.Size = new Size(125, 27);
            famTB.TabIndex = 3;
            // 
            // nameTB
            // 
            nameTB.Location = new Point(320, 33);
            nameTB.Name = "nameTB";
            nameTB.Size = new Size(125, 27);
            nameTB.TabIndex = 4;
            // 
            // otchestvoTB
            // 
            otchestvoTB.Location = new Point(619, 32);
            otchestvoTB.Name = "otchestvoTB";
            otchestvoTB.Size = new Size(125, 27);
            otchestvoTB.TabIndex = 5;
            // 
            // dataTB
            // 
            dataTB.Location = new Point(35, 108);
            dataTB.Name = "dataTB";
            dataTB.Size = new Size(125, 27);
            dataTB.TabIndex = 6;
            // 
            // spravkaTB
            // 
            spravkaTB.Location = new Point(320, 108);
            spravkaTB.Name = "spravkaTB";
            spravkaTB.Size = new Size(125, 27);
            spravkaTB.TabIndex = 7;
            // 
            // dopuskTB
            // 
            dopuskTB.Location = new Point(619, 108);
            dopuskTB.Name = "dopuskTB";
            dopuskTB.Size = new Size(125, 27);
            dopuskTB.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 10);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 9;
            label1.Text = "Фамилия";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(325, 12);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 10;
            label2.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(619, 10);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 11;
            label3.Text = "Отчество";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 88);
            label4.Name = "label4";
            label4.Size = new Size(118, 20);
            label4.TabIndex = 12;
            label4.Text = "День Рождение";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(323, 87);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 13;
            label5.Text = "МедСправка";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(625, 88);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 14;
            label6.Text = "Допуск";
            // 
            // AddManagersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dopuskTB);
            Controls.Add(spravkaTB);
            Controls.Add(dataTB);
            Controls.Add(otchestvoTB);
            Controls.Add(nameTB);
            Controls.Add(famTB);
            Controls.Add(dataGridView1);
            Controls.Add(editBtN);
            Controls.Add(backBtN);
            Name = "AddManagersForm";
            Text = "Добавление";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backBtN;
        private Button editBtN;
        private DataGridView dataGridView1;
        private TextBox famTB;
        private TextBox nameTB;
        private TextBox otchestvoTB;
        private TextBox dataTB;
        private TextBox spravkaTB;
        private TextBox dopuskTB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}