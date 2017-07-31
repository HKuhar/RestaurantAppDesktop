namespace RestaurantAppDesktop
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
            this.ordersButton = new System.Windows.Forms.Button();
            this.dishesButton = new System.Windows.Forms.Button();
            this.addDishButton = new System.Windows.Forms.Button();
            this.deleteDishButton = new System.Windows.Forms.Button();
            this.editDishButton = new System.Windows.Forms.Button();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ordersButton
            // 
            this.ordersButton.Location = new System.Drawing.Point(13, 13);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.Size = new System.Drawing.Size(75, 23);
            this.ordersButton.TabIndex = 0;
            this.ordersButton.Text = "Orders";
            this.ordersButton.UseVisualStyleBackColor = true;
            this.ordersButton.Click += new System.EventHandler(this.ordersButton_Click);
            // 
            // dishesButton
            // 
            this.dishesButton.Location = new System.Drawing.Point(13, 64);
            this.dishesButton.Name = "dishesButton";
            this.dishesButton.Size = new System.Drawing.Size(75, 23);
            this.dishesButton.TabIndex = 2;
            this.dishesButton.Text = "Dishes";
            this.dishesButton.UseVisualStyleBackColor = true;
            this.dishesButton.Click += new System.EventHandler(this.dishesButton_Click);
            // 
            // addDishButton
            // 
            this.addDishButton.Location = new System.Drawing.Point(13, 93);
            this.addDishButton.Name = "addDishButton";
            this.addDishButton.Size = new System.Drawing.Size(75, 23);
            this.addDishButton.TabIndex = 3;
            this.addDishButton.Text = "Add Dish";
            this.addDishButton.UseVisualStyleBackColor = true;
            this.addDishButton.Click += new System.EventHandler(this.addDishButton_Click);
            // 
            // deleteDishButton
            // 
            this.deleteDishButton.Location = new System.Drawing.Point(13, 122);
            this.deleteDishButton.Name = "deleteDishButton";
            this.deleteDishButton.Size = new System.Drawing.Size(75, 23);
            this.deleteDishButton.TabIndex = 5;
            this.deleteDishButton.Text = "Delete Dish";
            this.deleteDishButton.UseVisualStyleBackColor = true;
            this.deleteDishButton.Click += new System.EventHandler(this.deleteDishButton_Click);
            // 
            // editDishButton
            // 
            this.editDishButton.Location = new System.Drawing.Point(13, 151);
            this.editDishButton.Name = "editDishButton";
            this.editDishButton.Size = new System.Drawing.Size(75, 23);
            this.editDishButton.TabIndex = 6;
            this.editDishButton.Text = "Edit Dish";
            this.editDishButton.UseVisualStyleBackColor = true;
            this.editDishButton.Click += new System.EventHandler(this.editDishButton_Click);
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.HorizontalScrollbar = true;
            this.ListBox.Location = new System.Drawing.Point(108, 13);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(289, 290);
            this.ListBox.TabIndex = 7;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(403, 13);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(219, 290);
            this.TextBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 323);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.editDishButton);
            this.Controls.Add(this.deleteDishButton);
            this.Controls.Add(this.addDishButton);
            this.Controls.Add(this.dishesButton);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.ordersButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ordersButton;
        private System.Windows.Forms.Button dishesButton;
        private System.Windows.Forms.Button addDishButton;
        private System.Windows.Forms.Button deleteDishButton;
        private System.Windows.Forms.Button editDishButton;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.TextBox TextBox;
    }
}

