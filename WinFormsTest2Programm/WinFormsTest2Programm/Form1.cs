using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Text.Unicode;
using System.Windows.Forms;
using Yandex.Geocoder;

namespace WinFormsTest2Programm
{
    public partial class Form1 : Form
    {
        private DaDataService _daDataService;
        private const string _NotFindAdressError = "Не найден адресс";

        public Form1(DaDataService daDataService)
        {
            InitializeComponent();
            _daDataService = daDataService;
        }

        private async void Recognize(object sender, EventArgs e)
        {
            var text = textBox.Text;
            var adress = await _daDataService.AddressStandardizite(text);
            if (adress == null)
            {
                MessageBox.Show(_NotFindAdressError, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var coordinations = $"{adress.geo_lat}, {adress.geo_lon}";
            coordinates.Text = coordinations;
            textBox.Text = $"{adress.postal_code},{adress.city},{adress.street},{adress.flat}";
        }

        private void FindOnMap(object sender, EventArgs e)
        {
            try
            {
                var lat = coordinates.Text.Split(',')[0];
                var lon = coordinates.Text.Split(',')[1];

                OpenMap(lat,lon);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void OpenMap(string lat, string lon)
        {
            string url = $"https://yandex.ru/maps/?pt={lat},{lon}&z=12&l=map";
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = $"/c start {url}",
                UseShellExecute = false,
                CreateNoWindow = true
            });
        }

    }
}
