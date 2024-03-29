﻿namespace Fishing
{
    partial class Shop
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
            this.itemBox = new System.Windows.Forms.PictureBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.powerBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.RoadsList = new System.Windows.Forms.ListBox();
            this.ReelsList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FLineList = new System.Windows.Forms.ListBox();
            this.moneyBox = new System.Windows.Forms.TextBox();
            this.baitsList = new System.Windows.Forms.ListBox();
            this.shopTab = new System.Windows.Forms.TabControl();
            this.RoadPage = new System.Windows.Forms.TabPage();
            this.FLinePage = new System.Windows.Forms.TabPage();
            this.ReelsPage = new System.Windows.Forms.TabPage();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemBox)).BeginInit();
            this.shopTab.SuspendLayout();
            this.RoadPage.SuspendLayout();
            this.FLinePage.SuspendLayout();
            this.ReelsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemBox
            // 
            this.itemBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemBox.Location = new System.Drawing.Point(524, 57);
            this.itemBox.Name = "itemBox";
            this.itemBox.Size = new System.Drawing.Size(232, 214);
            this.itemBox.TabIndex = 11;
            this.itemBox.TabStop = false;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(576, 287);
            this.nameBox.Name = "nameBox";
            this.nameBox.ReadOnly = true;
            this.nameBox.Size = new System.Drawing.Size(180, 20);
            this.nameBox.TabIndex = 12;
            // 
            // powerBox
            // 
            this.powerBox.Location = new System.Drawing.Point(576, 313);
            this.powerBox.Name = "powerBox";
            this.powerBox.ReadOnly = true;
            this.powerBox.Size = new System.Drawing.Size(180, 20);
            this.powerBox.TabIndex = 13;
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(576, 339);
            this.priceBox.Name = "priceBox";
            this.priceBox.ReadOnly = true;
            this.priceBox.Size = new System.Drawing.Size(180, 20);
            this.priceBox.TabIndex = 14;
            // 
            // typeBox
            // 
            this.typeBox.Location = new System.Drawing.Point(576, 365);
            this.typeBox.Name = "typeBox";
            this.typeBox.ReadOnly = true;
            this.typeBox.Size = new System.Drawing.Size(180, 20);
            this.typeBox.TabIndex = 15;
            // 
            // RoadsList
            // 
            this.RoadsList.FormattingEnabled = true;
            this.RoadsList.Location = new System.Drawing.Point(0, 0);
            this.RoadsList.Name = "RoadsList";
            this.RoadsList.Size = new System.Drawing.Size(498, 459);
            this.RoadsList.TabIndex = 16;
            this.RoadsList.SelectedIndexChanged += new System.EventHandler(this.RoadsList_SelectedIndexChanged);
            this.RoadsList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.RoadsList_MouseDoubleClick);
            // 
            // ReelsList
            // 
            this.ReelsList.FormattingEnabled = true;
            this.ReelsList.Location = new System.Drawing.Point(0, 0);
            this.ReelsList.Name = "ReelsList";
            this.ReelsList.Size = new System.Drawing.Size(498, 459);
            this.ReelsList.TabIndex = 17;
            this.ReelsList.SelectedIndexChanged += new System.EventHandler(this.ReelsList_SelectedIndexChanged);
            this.ReelsList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ReelsList_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(664, 561);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 18;
            // 
            // FLineList
            // 
            this.FLineList.FormattingEnabled = true;
            this.FLineList.Location = new System.Drawing.Point(0, 0);
            this.FLineList.Name = "FLineList";
            this.FLineList.Size = new System.Drawing.Size(498, 459);
            this.FLineList.TabIndex = 19;
            this.FLineList.SelectedIndexChanged += new System.EventHandler(this.FLinesList_SelectedIndexChanged);
            this.FLineList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FLinesList_MouseDoubleClick);
            // 
            // moneyBox
            // 
            this.moneyBox.Location = new System.Drawing.Point(555, 31);
            this.moneyBox.Name = "moneyBox";
            this.moneyBox.Size = new System.Drawing.Size(162, 20);
            this.moneyBox.TabIndex = 20;
            // 
            // baitsList
            // 
            this.baitsList.FormattingEnabled = true;
            this.baitsList.Location = new System.Drawing.Point(156, 169);
            this.baitsList.Name = "baitsList";
            this.baitsList.Size = new System.Drawing.Size(162, 225);
            this.baitsList.TabIndex = 21;
            // 
            // shopTab
            // 
            this.shopTab.Controls.Add(this.RoadPage);
            this.shopTab.Controls.Add(this.FLinePage);
            this.shopTab.Controls.Add(this.ReelsPage);
            this.shopTab.Location = new System.Drawing.Point(53, 37);
            this.shopTab.Name = "shopTab";
            this.shopTab.SelectedIndex = 0;
            this.shopTab.Size = new System.Drawing.Size(465, 451);
            this.shopTab.TabIndex = 22;
            // 
            // RoadPage
            // 
            this.RoadPage.Controls.Add(this.RoadsList);
            this.RoadPage.Location = new System.Drawing.Point(4, 22);
            this.RoadPage.Name = "RoadPage";
            this.RoadPage.Padding = new System.Windows.Forms.Padding(3);
            this.RoadPage.Size = new System.Drawing.Size(457, 425);
            this.RoadPage.TabIndex = 0;
            this.RoadPage.Text = "Удочки";
            this.RoadPage.UseVisualStyleBackColor = true;
            // 
            // FLinePage
            // 
            this.FLinePage.Controls.Add(this.FLineList);
            this.FLinePage.Location = new System.Drawing.Point(4, 22);
            this.FLinePage.Name = "FLinePage";
            this.FLinePage.Padding = new System.Windows.Forms.Padding(3);
            this.FLinePage.Size = new System.Drawing.Size(498, 444);
            this.FLinePage.TabIndex = 1;
            this.FLinePage.Text = "Леска";
            this.FLinePage.UseVisualStyleBackColor = true;
            // 
            // ReelsPage
            // 
            this.ReelsPage.Controls.Add(this.ReelsList);
            this.ReelsPage.Location = new System.Drawing.Point(4, 22);
            this.ReelsPage.Name = "ReelsPage";
            this.ReelsPage.Padding = new System.Windows.Forms.Padding(3);
            this.ReelsPage.Size = new System.Drawing.Size(498, 444);
            this.ReelsPage.TabIndex = 2;
            this.ReelsPage.Text = "Катушки";
            this.ReelsPage.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(723, 26);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(33, 23);
            this.closeButton.TabIndex = 23;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fishing.Resource1.layer10;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 612);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.shopTab);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.powerBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.itemBox);
            this.Controls.Add(this.baitsList);
            this.Controls.Add(this.moneyBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Shop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Shop_Load);
            this.Leave += new System.EventHandler(this.Shop_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.itemBox)).EndInit();
            this.shopTab.ResumeLayout(false);
            this.RoadPage.ResumeLayout(false);
            this.FLinePage.ResumeLayout(false);
            this.ReelsPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox itemBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox powerBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.ListBox RoadsList;
        private System.Windows.Forms.ListBox ReelsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox FLineList;
        private System.Windows.Forms.TextBox moneyBox;
        private System.Windows.Forms.ListBox baitsList;
        private System.Windows.Forms.TabControl shopTab;
        private System.Windows.Forms.TabPage RoadPage;
        private System.Windows.Forms.TabPage FLinePage;
        private System.Windows.Forms.TabPage ReelsPage;
        private System.Windows.Forms.Button closeButton;
    }
}