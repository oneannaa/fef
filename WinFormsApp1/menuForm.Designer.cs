namespace WinFormsApp1
{
    partial class menuForm
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
            managerBtN = new Button();
            companyBtN = new Button();
            SuspendLayout();
            // 
            // managerBtN
            // 
            managerBtN.Location = new Point(57, 107);
            managerBtN.Name = "managerBtN";
            managerBtN.Size = new Size(180, 97);
            managerBtN.TabIndex = 0;
            managerBtN.Text = "Менеджеры";
            managerBtN.UseVisualStyleBackColor = true;
            managerBtN.Click += managerBtN_Click;
            // 
            // companyBtN
            // 
            companyBtN.Location = new Point(57, 256);
            companyBtN.Name = "companyBtN";
            companyBtN.Size = new Size(182, 97);
            companyBtN.TabIndex = 1;
            companyBtN.Text = "Компании";
            companyBtN.UseVisualStyleBackColor = true;
            companyBtN.Click += companyBtN_Click;
            // 
            // menuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 450);
            Controls.Add(companyBtN);
            Controls.Add(managerBtN);
            Name = "menuForm";
            Text = "Меню";
            ResumeLayout(false);
        }

        #endregion

        private Button managerBtN;
        private Button companyBtN;
    }
}