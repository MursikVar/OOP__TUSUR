using ObjectOrientedPractics.View;

namespace ObjectOrientedPractics
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            items = new TabPage();
            userControl11 = new UserControl1();
            сustomers = new TabPage();
            customersTab1 = new View.Tabs.CustomersTab();
            tabControl1.SuspendLayout();
            items.SuspendLayout();
            сustomers.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(items);
            tabControl1.Controls.Add(сustomers);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(903, 556);
            tabControl1.TabIndex = 0;
            // 
            // items
            // 
            items.Controls.Add(userControl11);
            items.Location = new Point(4, 29);
            items.Margin = new Padding(3, 4, 3, 4);
            items.Name = "items";
            items.Padding = new Padding(3, 4, 3, 4);
            items.Size = new Size(895, 523);
            items.TabIndex = 0;
            items.Text = "Items";
            items.UseVisualStyleBackColor = true;
            // 
            // userControl11
            // 
            userControl11.Dock = DockStyle.Fill;
            userControl11.Location = new Point(3, 4);
            userControl11.Margin = new Padding(3, 5, 3, 5);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(889, 515);
            userControl11.TabIndex = 0;
            userControl11.Load += userControl11_Load;
            // 
            // сustomers
            // 
            сustomers.Controls.Add(customersTab1);
            сustomers.Location = new Point(4, 29);
            сustomers.Margin = new Padding(3, 4, 3, 4);
            сustomers.Name = "сustomers";
            сustomers.Padding = new Padding(3, 4, 3, 4);
            сustomers.Size = new Size(1043, 533);
            сustomers.TabIndex = 1;
            сustomers.Text = "Customers";
            сustomers.UseVisualStyleBackColor = true;
            // 
            // customersTab1
            // 
            customersTab1.Dock = DockStyle.Fill;
            customersTab1.Location = new Point(3, 4);
            customersTab1.Margin = new Padding(3, 5, 3, 5);
            customersTab1.Name = "customersTab1";
            customersTab1.Size = new Size(1037, 525);
            customersTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 556);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Object Oriented Practics";
            tabControl1.ResumeLayout(false);
            items.ResumeLayout(false);
            сustomers.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private View.UserControl1 userControl1;
        private TabControl tabControl1;
        private TabPage items;
        private UserControl1 userControl11;
        private TabPage сustomers;
        private View.Tabs.CustomersTab customersTab1;
    }
}
