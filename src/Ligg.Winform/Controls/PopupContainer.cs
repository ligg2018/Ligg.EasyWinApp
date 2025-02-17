﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ligg.Winform.Controls
{
    public partial class PopupContainer : UserControl
    {
        public PopupContainer()
        {
            InitializeComponent();
            shadowPanel.BorderColor = StyleSet.PopupContainerBorderColor;
            BackColor = StyleSet.PopupContainerBackColor;
            closeButton.Width = 18;
            closeButton.Height = 18;
            closeButton.Location = new Point(this.Width - 18 - 7, 3);
        }
        public void Close()
        {
            this.Visible = false;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }


        private void PopupContainer_Load(object sender, EventArgs e)
        {
            BackColor = StyleSet.PopupContainerBackColor; ;
            closeButton.Location = new Point(this.Width - 18 - 7, 3);
        }

        private void PopupContainer_Paint(object sender, PaintEventArgs e)
        {
            BackColor = StyleSet.PopupContainerBackColor; ;
            closeButton.Location = new Point(this.Width - 18 - 7, 3);
        }


    }
}
