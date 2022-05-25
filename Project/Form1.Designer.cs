namespace Project
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
            this.tabDrinks = new System.Windows.Forms.TabControl();
            this.tabMainMenu = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.lblSoda1 = new System.Windows.Forms.Button();
            this.lblTitleSoda1 = new System.Windows.Forms.Label();
            this.lblPriceSoda1 = new System.Windows.Forms.Label();
            this.lstItemList = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblPriceSoda2 = new System.Windows.Forms.Label();
            this.lblTitleSoda2 = new System.Windows.Forms.Label();
            this.lblSoda2 = new System.Windows.Forms.Button();
            this.tabDrinks.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabDrinks
            // 
            this.tabDrinks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabDrinks.Controls.Add(this.tabMainMenu);
            this.tabDrinks.Controls.Add(this.tabPage2);
            this.tabDrinks.Location = new System.Drawing.Point(12, 12);
            this.tabDrinks.Name = "tabDrinks";
            this.tabDrinks.SelectedIndex = 0;
            this.tabDrinks.Size = new System.Drawing.Size(805, 667);
            this.tabDrinks.TabIndex = 0;
            // 
            // tabMainMenu
            // 
            this.tabMainMenu.Location = new System.Drawing.Point(4, 22);
            this.tabMainMenu.Name = "tabMainMenu";
            this.tabMainMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainMenu.Size = new System.Drawing.Size(817, 641);
            this.tabMainMenu.TabIndex = 0;
            this.tabMainMenu.Text = "Main Menu";
            this.tabMainMenu.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblPriceSoda2);
            this.tabPage2.Controls.Add(this.lblTitleSoda2);
            this.tabPage2.Controls.Add(this.lblSoda2);
            this.tabPage2.Controls.Add(this.lblPriceSoda1);
            this.tabPage2.Controls.Add(this.lblTitleSoda1);
            this.tabPage2.Controls.Add(this.lblSoda1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(797, 641);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(819, 12);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(261, 663);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.lstItemList);
            this.tabPage3.Controls.Add(this.btnCheckOut);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(253, 637);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Order";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(192, 74);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCheckOut.Location = new System.Drawing.Point(7, 589);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(75, 23);
            this.btnCheckOut.TabIndex = 0;
            this.btnCheckOut.Text = "Check Out\r\n";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // lblSoda1
            // 
            this.lblSoda1.Location = new System.Drawing.Point(46, 34);
            this.lblSoda1.Name = "lblSoda1";
            this.lblSoda1.Size = new System.Drawing.Size(115, 102);
            this.lblSoda1.TabIndex = 0;
            this.lblSoda1.Text = "button1";
            this.lblSoda1.UseVisualStyleBackColor = true;
            this.lblSoda1.Click += new System.EventHandler(this.lblSoda1_Click);
            // 
            // lblTitleSoda1
            // 
            this.lblTitleSoda1.AutoSize = true;
            this.lblTitleSoda1.Location = new System.Drawing.Point(52, 18);
            this.lblTitleSoda1.Name = "lblTitleSoda1";
            this.lblTitleSoda1.Size = new System.Drawing.Size(32, 13);
            this.lblTitleSoda1.TabIndex = 1;
            this.lblTitleSoda1.Text = "Soda";
            // 
            // lblPriceSoda1
            // 
            this.lblPriceSoda1.AutoSize = true;
            this.lblPriceSoda1.Location = new System.Drawing.Point(55, 143);
            this.lblPriceSoda1.Name = "lblPriceSoda1";
            this.lblPriceSoda1.Size = new System.Drawing.Size(28, 13);
            this.lblPriceSoda1.TabIndex = 2;
            this.lblPriceSoda1.Text = "2.99";
            // 
            // lstItemList
            // 
            this.lstItemList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstItemList.FormattingEnabled = true;
            this.lstItemList.Location = new System.Drawing.Point(7, 7);
            this.lstItemList.Name = "lstItemList";
            this.lstItemList.Size = new System.Drawing.Size(240, 576);
            this.lstItemList.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Location = new System.Drawing.Point(88, 589);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Clear All";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.Location = new System.Drawing.Point(169, 589);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete Item";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lblPriceSoda2
            // 
            this.lblPriceSoda2.AutoSize = true;
            this.lblPriceSoda2.Location = new System.Drawing.Point(55, 312);
            this.lblPriceSoda2.Name = "lblPriceSoda2";
            this.lblPriceSoda2.Size = new System.Drawing.Size(28, 13);
            this.lblPriceSoda2.TabIndex = 5;
            this.lblPriceSoda2.Text = "3.99";
            // 
            // lblTitleSoda2
            // 
            this.lblTitleSoda2.AutoSize = true;
            this.lblTitleSoda2.Location = new System.Drawing.Point(52, 187);
            this.lblTitleSoda2.Name = "lblTitleSoda2";
            this.lblTitleSoda2.Size = new System.Drawing.Size(26, 13);
            this.lblTitleSoda2.TabIndex = 4;
            this.lblTitleSoda2.Text = "Diet";
            // 
            // lblSoda2
            // 
            this.lblSoda2.Location = new System.Drawing.Point(46, 203);
            this.lblSoda2.Name = "lblSoda2";
            this.lblSoda2.Size = new System.Drawing.Size(115, 102);
            this.lblSoda2.TabIndex = 3;
            this.lblSoda2.Text = "button4";
            this.lblSoda2.UseVisualStyleBackColor = true;
            this.lblSoda2.Click += new System.EventHandler(this.lblSoda2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 821);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabDrinks);
            this.Name = "Form1";
            this.Text = "a";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabDrinks.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDrinks;
        private System.Windows.Forms.TabPage tabMainMenu;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button lblSoda1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblPriceSoda2;
        private System.Windows.Forms.Label lblTitleSoda2;
        private System.Windows.Forms.Button lblSoda2;
        private System.Windows.Forms.Label lblPriceSoda1;
        private System.Windows.Forms.Label lblTitleSoda1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lstItemList;
    }
}

