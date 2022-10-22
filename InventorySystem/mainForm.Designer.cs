
namespace InventorySystem
{
    partial class mainForm
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
            this.viewStocks = new System.Windows.Forms.Button();
            this.addUser = new System.Windows.Forms.Button();
            this.logOut = new System.Windows.Forms.Button();
            this.viewOrders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewStocks
            // 
            this.viewStocks.BackColor = System.Drawing.Color.Tan;
            this.viewStocks.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.viewStocks.FlatAppearance.BorderSize = 0;
            this.viewStocks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewStocks.Font = new System.Drawing.Font("Dutch801 Rm BT", 25F, System.Drawing.FontStyle.Bold);
            this.viewStocks.Location = new System.Drawing.Point(198, 12);
            this.viewStocks.Name = "viewStocks";
            this.viewStocks.Size = new System.Drawing.Size(178, 127);
            this.viewStocks.TabIndex = 0;
            this.viewStocks.Text = "View Stocks";
            this.viewStocks.UseVisualStyleBackColor = false;
            this.viewStocks.Click += new System.EventHandler(this.viewStocks_Click);
            // 
            // addUser
            // 
            this.addUser.BackColor = System.Drawing.Color.Tan;
            this.addUser.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.addUser.FlatAppearance.BorderSize = 0;
            this.addUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addUser.Font = new System.Drawing.Font("Dutch801 Rm BT", 13F, System.Drawing.FontStyle.Bold);
            this.addUser.Location = new System.Drawing.Point(12, 145);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(178, 48);
            this.addUser.TabIndex = 1;
            this.addUser.Text = "Add User";
            this.addUser.UseVisualStyleBackColor = false;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // logOut
            // 
            this.logOut.BackColor = System.Drawing.Color.Tan;
            this.logOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOut.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.logOut.FlatAppearance.BorderSize = 0;
            this.logOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logOut.Font = new System.Drawing.Font("Dutch801 Rm BT", 13F, System.Drawing.FontStyle.Bold);
            this.logOut.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.logOut.Location = new System.Drawing.Point(198, 145);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(178, 48);
            this.logOut.TabIndex = 1;
            this.logOut.Text = "Log Out";
            this.logOut.UseVisualStyleBackColor = false;
            this.logOut.Click += new System.EventHandler(this.button4_Click);
            // 
            // viewOrders
            // 
            this.viewOrders.BackColor = System.Drawing.Color.Tan;
            this.viewOrders.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.viewOrders.FlatAppearance.BorderSize = 0;
            this.viewOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewOrders.Font = new System.Drawing.Font("Dutch801 Rm BT", 25F, System.Drawing.FontStyle.Bold);
            this.viewOrders.Location = new System.Drawing.Point(12, 12);
            this.viewOrders.Name = "viewOrders";
            this.viewOrders.Size = new System.Drawing.Size(178, 127);
            this.viewOrders.TabIndex = 0;
            this.viewOrders.Text = "View Orders";
            this.viewOrders.UseVisualStyleBackColor = false;
            this.viewOrders.Click += new System.EventHandler(this.viewOrders_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(388, 205);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.addUser);
            this.Controls.Add(this.viewOrders);
            this.Controls.Add(this.viewStocks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewStocks;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Button viewOrders;
    }
}