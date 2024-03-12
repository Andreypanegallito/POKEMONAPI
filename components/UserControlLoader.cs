using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ProgressBar = System.Windows.Forms.ProgressBar;

namespace _7DAYSOFCODE.components
{
    public partial class UserControlLoader : UserControl
    {

        public UserControlLoader()
        {
            InitializeComponent();

            panelLoader.Dock = DockStyle.Fill;
            this.Controls.Add(panelLoader);
            panelLoader.Controls.Add(labelTextLoader);

            // Configure a label
            //labelTextLoader.Top = (panelLoader.Height - labelTextLoader.Height) / 2;
            //labelTextLoader.Left = (panelLoader.Width - labelTextLoader.Width) / 2;
        }
    }
}
