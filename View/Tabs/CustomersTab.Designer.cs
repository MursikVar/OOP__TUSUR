namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            Customers = new GroupBox();
            RemoveCustomerButtton = new Button();
            AddCustomerbutton = new Button();
            CustomersListBox = new ListBox();
            SelectedCustomer = new GroupBox();
            panel1 = new Panel();
            AddressBox = new TextBox();
            FullNameBox = new TextBox();
            IDcustomerBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Customers.SuspendLayout();
            SelectedCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // Customers
            // 
            Customers.Controls.Add(RemoveCustomerButtton);
            Customers.Controls.Add(AddCustomerbutton);
            Customers.Controls.Add(CustomersListBox);
            Customers.Dock = DockStyle.Left;
            Customers.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Customers.Location = new Point(0, 0);
            Customers.Name = "Customers";
            Customers.Size = new Size(395, 614);
            Customers.TabIndex = 0;
            Customers.TabStop = false;
            Customers.Text = "Customers";
            // 
            // RemoveCustomerButtton
            // 
            RemoveCustomerButtton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveCustomerButtton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RemoveCustomerButtton.Location = new Point(136, 560);
            RemoveCustomerButtton.Name = "RemoveCustomerButtton";
            RemoveCustomerButtton.Size = new Size(124, 41);
            RemoveCustomerButtton.TabIndex = 1;
            RemoveCustomerButtton.Text = "Remove";
            RemoveCustomerButtton.UseVisualStyleBackColor = true;
            RemoveCustomerButtton.Click += RemoveCustomerButton_Click;
            // 
            // AddCustomerbutton
            // 
            AddCustomerbutton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddCustomerbutton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddCustomerbutton.Location = new Point(6, 560);
            AddCustomerbutton.Name = "AddCustomerbutton";
            AddCustomerbutton.Size = new Size(124, 41);
            AddCustomerbutton.TabIndex = 0;
            AddCustomerbutton.Text = "Add";
            AddCustomerbutton.UseVisualStyleBackColor = true;
            AddCustomerbutton.Click += AddCustomerButton_Click;
            // 
            // CustomersListBox
            // 
            CustomersListBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 15;
            CustomersListBox.Location = new Point(6, 22);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(368, 499);
            CustomersListBox.TabIndex = 0;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // SelectedCustomer
            // 
            SelectedCustomer.Controls.Add(panel1);
            SelectedCustomer.Controls.Add(AddressBox);
            SelectedCustomer.Controls.Add(FullNameBox);
            SelectedCustomer.Controls.Add(IDcustomerBox);
            SelectedCustomer.Controls.Add(label3);
            SelectedCustomer.Controls.Add(label2);
            SelectedCustomer.Controls.Add(label1);
            SelectedCustomer.Dock = DockStyle.Right;
            SelectedCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SelectedCustomer.Location = new Point(467, 0);
            SelectedCustomer.Name = "SelectedCustomer";
            SelectedCustomer.Size = new Size(473, 614);
            SelectedCustomer.TabIndex = 1;
            SelectedCustomer.TabStop = false;
            SelectedCustomer.Text = "SelectedCustomer";
            // 
            // panel1
            // 
            panel1.Location = new Point(10, 183);
            panel1.Name = "panel1";
            panel1.Size = new Size(457, 399);
            panel1.TabIndex = 7;
            // 
            // AddressBox
            // 
            AddressBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddressBox.Location = new Point(81, 92);
            AddressBox.Multiline = true;
            AddressBox.Name = "AddressBox";
            AddressBox.Size = new Size(386, 85);
            AddressBox.TabIndex = 6;
            AddressBox.TextChanged += AddressBox_TextChanged;
            // 
            // FullNameBox
            // 
            FullNameBox.Location = new Point(81, 63);
            FullNameBox.Name = "FullNameBox";
            FullNameBox.Size = new Size(386, 23);
            FullNameBox.TabIndex = 5;
            FullNameBox.TextChanged += FullNameBox_TextChanged;
            // 
            // IDcustomerBox
            // 
            IDcustomerBox.Location = new Point(81, 34);
            IDcustomerBox.Name = "IDcustomerBox";
            IDcustomerBox.ReadOnly = true;
            IDcustomerBox.Size = new Size(140, 23);
            IDcustomerBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(10, 64);
            label3.Name = "label3";
            label3.Size = new Size(65, 17);
            label3.TabIndex = 2;
            label3.Text = "FullName:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(10, 93);
            label2.Name = "label2";
            label2.Size = new Size(59, 17);
            label2.TabIndex = 1;
            label2.Text = "Address:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(10, 35);
            label1.Name = "label1";
            label1.Size = new Size(23, 17);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SelectedCustomer);
            Controls.Add(Customers);
            Name = "CustomersTab";
            Size = new Size(940, 614);
            Load += CustomersTab_Load;
            Customers.ResumeLayout(false);
            SelectedCustomer.ResumeLayout(false);
            SelectedCustomer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Customers;
        private GroupBox SelectedCustomer;
        private ListBox CustomersListBox;
        private Button AddCustomerbutton;
        private Button RemoveCustomerButtton;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox IDcustomerBox;
        private TextBox FullNameBox;
        private TextBox AddressBox;
        private Panel panel1;
    }
}
