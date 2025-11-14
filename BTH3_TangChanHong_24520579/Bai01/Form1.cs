using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai01
{
    public partial class Form1 : Form
    {
        private ListBox lstEvents;
        private int eventCounter = 1;

        public Form1()
        {
            InitializeComponent();

            this.Text = "Demo Vòng Đời Form";
            this.Size = new Size(500, 400);

            lstEvents = new ListBox();
            lstEvents.Dock = DockStyle.Fill;
            lstEvents.Font = new Font("Segoe UI", 10F);
            this.Controls.Add(lstEvents);

            SubscribeToEvents();

            LogEvent("Constructor (Form1())");
        }

        private void SubscribeToEvents()
        {
            this.HandleCreated += Form1_HandleCreated;
            this.Load += Form1_Load;
            this.Activated += Form1_Activated;
            this.Shown += Form1_Shown;
            this.Deactivate += Form1_Deactivate;
            this.FormClosing += Form1_FormClosing;
            this.FormClosed += Form1_FormClosed;
            this.HandleDestroyed += Form1_HandleDestroyed;
        }

        private void LogEvent(string eventName)
        {
            if (lstEvents != null && !lstEvents.IsDisposed)
            {
                lstEvents.Items.Add($"{eventCounter++}. {eventName}");
                lstEvents.TopIndex = lstEvents.Items.Count - 1;
            }
            else
            {
                System.Diagnostics.Debug.WriteLine($"[LOG]: {eventCounter++}. {eventName}");
            }
        }

        private void Form1_HandleCreated(object sender, EventArgs e)
        {
            LogEvent("HandleCreated");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LogEvent("Load");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            LogEvent("Activated (Đã nhận focus)");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            LogEvent("Shown (Đã hiển thị)");
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            LogEvent("Deactivate (Đã mất focus)");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogEvent("FormClosing (Đang đóng...)");

            MessageBox.Show("Form chuẩn bị đóng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            LogEvent("FormClosed (Đã đóng)");
        }

        private void Form1_HandleDestroyed(object sender, EventArgs e)
        {
            LogEvent("HandleDestroyed");
        }
    }
}