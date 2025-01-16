using LoupedeckKritaApiClient;

namespace LoupedeckClient
{
    public partial class Form1 : Form
    {
        private long dpi;
        private Client client;

        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //using var client = new Client();
            //await client.Connect();

            await client.ExecuteCall("currentCanvas", "setZoomLevel", 1.0f);
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            //using var client = new Client();
            //await client.Connect();

            var zoomLevel = (double)await client.ExecuteCall("currentCanvas", "zoomLevel");

            var zoom = (int)(zoomLevel * 72 / dpi * 100);
            label1.Text = zoom.ToString();
            trackBar1.Value = zoom;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            client = new Client();
            await client.Connect();

            dpi = (long)await client.ExecuteCall("currentDocument", "resolution");
            var zoomLevel = (double)await client.ExecuteCall("currentCanvas", "zoomLevel");

            var zoom = (int)(zoomLevel * 72 / dpi * 100);
            label1.Text = zoom.ToString();

            isRunning = true;
            trackBar1.Value = zoom;
            isRunning = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        bool isRunning = false;
        private async void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                try
                {
                    isRunning = true;

                    Thread.Sleep(20);

                    var zoom = (float)(trackBar1.Value);

                    await client.ExecuteCall("currentCanvas", "setZoomLevel", zoom / 100);

                    label1.Text = zoom.ToString();
                }
                catch(Exception ex)
                {
                    label1.Text = "Erreur : " + ex.Message;
                }
                finally
                {
                    isRunning = false;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Dispose();
        }
    }
}
