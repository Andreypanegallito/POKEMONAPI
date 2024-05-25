using Microsoft.VisualBasic.ApplicationServices;
using RestSharp;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;

namespace _7DAYSOFCODE
{
    public partial class Initial : Form
    {

        public Initial()
        {
            InitializeComponent();

            ShowInitial();
        }

        private void ShowInitial()
        {
            UserControlInitial ucInitial = new UserControlInitial(this);
            ucInitial.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(ucInitial);
        }


        public  void RemoverTela()
        {
            this.Controls.Clear();
        }

    }

}