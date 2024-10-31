namespace ObjectOrientedPractics.View
{
    partial class UserControl1
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            Items = new GroupBox();
            AddButton = new Button();
            RemoveButton = new Button();
            ItemsListBox = new ListBox();
            groupBoxRight = new GroupBox();
            DescriptionBox = new TextBox();
            label4 = new Label();
            NameBox = new TextBox();
            label3 = new Label();
            CostBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            IDbox = new TextBox();
            Items.SuspendLayout();
            groupBoxRight.SuspendLayout();
            SuspendLayout();
            // 
            // Items
            // 
            Items.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Items.Controls.Add(AddButton);
            Items.Controls.Add(RemoveButton);
            Items.Controls.Add(ItemsListBox);
            Items.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Items.Location = new Point(0, 0);
            Items.Margin = new Padding(3, 4, 3, 4);
            Items.Name = "Items";
            Items.Padding = new Padding(3, 4, 3, 4);
            Items.Size = new Size(451, 682);
            Items.TabIndex = 2;
            Items.TabStop = false;
            Items.Text = "Items";
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddButton.Location = new Point(7, 619);
            AddButton.Margin = new Padding(3, 4, 3, 4);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(142, 55);
            AddButton.TabIndex = 3;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RemoveButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RemoveButton.Location = new Point(155, 619);
            RemoveButton.Margin = new Padding(3, 4, 3, 4);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(142, 55);
            RemoveButton.TabIndex = 2;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.Location = new Point(7, 29);
            ItemsListBox.Margin = new Padding(3, 4, 3, 4);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(420, 524);
            ItemsListBox.TabIndex = 0;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // groupBoxRight
            // 
            groupBoxRight.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxRight.BackColor = SystemColors.ButtonHighlight;
            groupBoxRight.Controls.Add(DescriptionBox);
            groupBoxRight.Controls.Add(label4);
            groupBoxRight.Controls.Add(NameBox);
            groupBoxRight.Controls.Add(label3);
            groupBoxRight.Controls.Add(CostBox);
            groupBoxRight.Controls.Add(label2);
            groupBoxRight.Controls.Add(label1);
            groupBoxRight.Controls.Add(IDbox);
            groupBoxRight.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxRight.Location = new Point(458, 0);
            groupBoxRight.Margin = new Padding(3, 4, 3, 4);
            groupBoxRight.Name = "groupBoxRight";
            groupBoxRight.Padding = new Padding(3, 4, 3, 4);
            groupBoxRight.Size = new Size(541, 682);
            groupBoxRight.TabIndex = 3;
            groupBoxRight.TabStop = false;
            groupBoxRight.Text = "Selected Item";
            // 
            // DescriptionBox
            // 
            DescriptionBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DescriptionBox.Location = new Point(11, 376);
            DescriptionBox.Margin = new Padding(3, 4, 3, 4);
            DescriptionBox.Multiline = true;
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.Size = new Size(522, 177);
            DescriptionBox.TabIndex = 7;
            DescriptionBox.TextChanged += DescriptionBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(11, 349);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 6;
            label4.Text = "Description:";
            label4.Click += label4_Click;
            // 
            // NameBox
            // 
            NameBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameBox.Location = new Point(11, 176);
            NameBox.Margin = new Padding(3, 4, 3, 4);
            NameBox.Multiline = true;
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(522, 147);
            NameBox.TabIndex = 5;
            NameBox.TextChanged += NameBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(11, 149);
            label3.Name = "label3";
            label3.Size = new Size(60, 23);
            label3.TabIndex = 4;
            label3.Text = "Name:";
            // 
            // CostBox
            // 
            CostBox.Location = new Point(73, 97);
            CostBox.Margin = new Padding(3, 4, 3, 4);
            CostBox.Name = "CostBox";
            CostBox.Size = new Size(159, 27);
            CostBox.TabIndex = 3;
            CostBox.TextChanged += CostBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(11, 99);
            label2.Name = "label2";
            label2.Size = new Size(48, 23);
            label2.TabIndex = 2;
            label2.Text = "Cost:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(11, 47);
            label1.Name = "label1";
            label1.Size = new Size(31, 23);
            label1.TabIndex = 1;
            label1.Text = "ID:";
            // 
            // IDbox
            // 
            IDbox.Location = new Point(73, 45);
            IDbox.Margin = new Padding(3, 4, 3, 4);
            IDbox.Name = "IDbox";
            IDbox.ReadOnly = true;
            IDbox.Size = new Size(159, 27);
            IDbox.TabIndex = 0;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxRight);
            Controls.Add(Items);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControl1";
            Size = new Size(999, 718);
            Load += ItemsTab_Load;
            Items.ResumeLayout(false);
            groupBoxRight.ResumeLayout(false);
            groupBoxRight.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Items;
        private Button AddButton;
        private Button RemoveButton;
        private ListBox ItemsListBox;
        private GroupBox groupBoxRight;
        private TextBox DescriptionBox;
        private Label label4;
        private TextBox NameBox;
        private Label label3;
        private TextBox CostBox;
        private Label label2;
        private Label label1;
        private TextBox IDbox;
    }
}
