namespace Homework__Store_
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
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ExpireDateLabel = new System.Windows.Forms.Label();
            this.ExpireTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClearButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.VegetableCatTextBox = new System.Windows.Forms.TextBox();
            this.SweetCatTextBox = new System.Windows.Forms.TextBox();
            this.MeatCatTextBox = new System.Windows.Forms.TextBox();
            this.StockProductTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StockLabel = new System.Windows.Forms.Label();
            this.AlertLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Items.AddRange(new object[] {
            "Meat",
            "Sweet",
            "Vegetable"});
            this.CategoryComboBox.Location = new System.Drawing.Point(124, 110);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(184, 24);
            this.CategoryComboBox.TabIndex = 0;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CategoryLabel.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CategoryLabel.Location = new System.Drawing.Point(5, 110);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(103, 24);
            this.CategoryLabel.TabIndex = 1;
            this.CategoryLabel.Text = "Category";
            this.CategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeightLabel
            // 
            this.WeightLabel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.WeightLabel.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WeightLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.WeightLabel.Location = new System.Drawing.Point(5, 189);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(103, 24);
            this.WeightLabel.TabIndex = 2;
            this.WeightLabel.Text = "Weight (kg)";
            this.WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(124, 189);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(184, 22);
            this.WeightTextBox.TabIndex = 3;
            // 
            // CostLabel
            // 
            this.CostLabel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CostLabel.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CostLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CostLabel.Location = new System.Drawing.Point(5, 151);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(103, 24);
            this.CostLabel.TabIndex = 4;
            this.CostLabel.Text = "Cost ($)";
            this.CostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(124, 151);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(184, 22);
            this.CostTextBox.TabIndex = 5;
            // 
            // NameLabel
            // 
            this.NameLabel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.NameLabel.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NameLabel.Location = new System.Drawing.Point(5, 69);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(103, 24);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "Name";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(124, 69);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(184, 22);
            this.NameTextBox.TabIndex = 7;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // ExpireDateLabel
            // 
            this.ExpireDateLabel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ExpireDateLabel.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExpireDateLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExpireDateLabel.Location = new System.Drawing.Point(5, 233);
            this.ExpireDateLabel.Name = "ExpireDateLabel";
            this.ExpireDateLabel.Size = new System.Drawing.Size(103, 24);
            this.ExpireDateLabel.TabIndex = 8;
            this.ExpireDateLabel.Text = "Expire Date";
            this.ExpireDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExpireTextBox
            // 
            this.ExpireTextBox.Location = new System.Drawing.Point(124, 235);
            this.ExpireTextBox.Name = "ExpireTextBox";
            this.ExpireTextBox.Size = new System.Drawing.Size(184, 22);
            this.ExpireTextBox.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CategoryComboBox);
            this.panel1.Controls.Add(this.ExpireTextBox);
            this.panel1.Controls.Add(this.CategoryLabel);
            this.panel1.Controls.Add(this.ExpireDateLabel);
            this.panel1.Controls.Add(this.WeightLabel);
            this.panel1.Controls.Add(this.NameTextBox);
            this.panel1.Controls.Add(this.WeightTextBox);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Controls.Add(this.CostLabel);
            this.panel1.Controls.Add(this.CostTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 327);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.OrangeRed;
            this.ClearButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClearButton.Location = new System.Drawing.Point(104, 278);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(99, 32);
            this.ClearButton.TabIndex = 12;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AddButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddButton.Location = new System.Drawing.Point(209, 278);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(99, 32);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 48);
            this.label1.TabIndex = 10;
            this.label1.Text = "Add a Product";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.VegetableCatTextBox);
            this.panel2.Controls.Add(this.SweetCatTextBox);
            this.panel2.Controls.Add(this.MeatCatTextBox);
            this.panel2.Controls.Add(this.StockProductTextBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.StockLabel);
            this.panel2.Location = new System.Drawing.Point(372, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 327);
            this.panel2.TabIndex = 11;
            // 
            // VegetableCatTextBox
            // 
            this.VegetableCatTextBox.Location = new System.Drawing.Point(144, 214);
            this.VegetableCatTextBox.Name = "VegetableCatTextBox";
            this.VegetableCatTextBox.ReadOnly = true;
            this.VegetableCatTextBox.Size = new System.Drawing.Size(73, 22);
            this.VegetableCatTextBox.TabIndex = 20;
            // 
            // SweetCatTextBox
            // 
            this.SweetCatTextBox.Location = new System.Drawing.Point(144, 190);
            this.SweetCatTextBox.Name = "SweetCatTextBox";
            this.SweetCatTextBox.ReadOnly = true;
            this.SweetCatTextBox.Size = new System.Drawing.Size(73, 22);
            this.SweetCatTextBox.TabIndex = 19;
            // 
            // MeatCatTextBox
            // 
            this.MeatCatTextBox.Location = new System.Drawing.Point(144, 166);
            this.MeatCatTextBox.Name = "MeatCatTextBox";
            this.MeatCatTextBox.ReadOnly = true;
            this.MeatCatTextBox.Size = new System.Drawing.Size(73, 22);
            this.MeatCatTextBox.TabIndex = 18;
            // 
            // StockProductTextBox
            // 
            this.StockProductTextBox.Location = new System.Drawing.Point(144, 57);
            this.StockProductTextBox.Name = "StockProductTextBox";
            this.StockProductTextBox.ReadOnly = true;
            this.StockProductTextBox.Size = new System.Drawing.Size(73, 22);
            this.StockProductTextBox.TabIndex = 13;
            this.StockProductTextBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(20, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Vegetable";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(20, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Sweet";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(20, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Meat";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SeaGreen;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(0, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 33);
            this.label3.TabIndex = 14;
            this.label3.Text = "By Category";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(43, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Products";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // StockLabel
            // 
            this.StockLabel.BackColor = System.Drawing.Color.SeaGreen;
            this.StockLabel.Font = new System.Drawing.Font("Tw Cen MT", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StockLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StockLabel.Location = new System.Drawing.Point(0, 0);
            this.StockLabel.Name = "StockLabel";
            this.StockLabel.Size = new System.Drawing.Size(292, 48);
            this.StockLabel.TabIndex = 13;
            this.StockLabel.Text = "In Stock";
            this.StockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AlertLabel
            // 
            this.AlertLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AlertLabel.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AlertLabel.ForeColor = System.Drawing.Color.Red;
            this.AlertLabel.Location = new System.Drawing.Point(12, 32);
            this.AlertLabel.Name = "AlertLabel";
            this.AlertLabel.Size = new System.Drawing.Size(325, 50);
            this.AlertLabel.TabIndex = 13;
            this.AlertLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AlertLabel.Click += new System.EventHandler(this.label7_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(123, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Alert";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(702, 453);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AlertLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(720, 500);
            this.MinimumSize = new System.Drawing.Size(720, 500);
            this.Name = "Form1";
            this.Text = "Store System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label ExpireDateLabel;
        private System.Windows.Forms.TextBox ExpireTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label StockLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StockProductTextBox;
        private System.Windows.Forms.TextBox MeatCatTextBox;
        private System.Windows.Forms.TextBox SweetCatTextBox;
        private System.Windows.Forms.TextBox VegetableCatTextBox;
        private System.Windows.Forms.Label AlertLabel;
        private System.Windows.Forms.Label label7;
    }
}

