using System.ComponentModel;

namespace tcpip_console
{
    public partial class Home : Form
    {
        private DataGridView dataGridView1;
        public Home()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadData();
        }

        private void InitializeDataGridView()
        {
            dataGridView1 = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoGenerateColumns = false,
                AllowUserToAddRows = false
            };

            // Dropdown column (ComboBox)
            var comboColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = "Analyser",
                DataPropertyName = "EquipmentName",
                Name = "EquipmentName",
                DataSource = new List<string> { "DXH900", "DXI800", "Cobas" }
            };
            dataGridView1.Columns.Add(comboColumn);

            // Textbox column
            var textColumn1 = new DataGridViewTextBoxColumn
            {
                HeaderText = "IP Address",
                DataPropertyName = "IPAddress",
                Name = "IPAddress"
            };
            dataGridView1.Columns.Add(textColumn1);

            // Textbox column
            var textColumn2 = new DataGridViewTextBoxColumn
            {
                HeaderText = "Port No",
                DataPropertyName = "PortNo",
                Name = "PortNo"
            };
            dataGridView1.Columns.Add(textColumn2);
            // Image column to display status
            var imageColumn = new DataGridViewImageColumn
            {
                HeaderText = "Status",
                Name = "AnalyserStatus",
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dataGridView1.Columns.Add(imageColumn);

            // Action column with two buttons
            var actionColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Action",
                Name = "btnConnect",
                Text = "Connect",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(actionColumn);

            var disconnectColumn = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Name = "btnDisconnect",
                Text = "Disconnect",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(disconnectColumn);

            dataGridView1.CellClick += DataGridView1_CellClick;

            this.Controls.Add(dataGridView1);
        }

        // Data model for each row
        public class RowData
        {
            public string EquipmentName { get; set; }
            public string IPAddress { get; set; }
            public string PortNo { get; set; }
            public bool IsConnected { get; set; }
        }

        private BindingList<RowData> dataList;

        private Image connectedImage = Properties.Resources.connected; // replace with your image resource or file
        private Image disconnectedImage = Properties.Resources.notconnected; // replace with your image resource or file

        private void LoadData()
        {
            // Sample data
            dataList = new BindingList<RowData>
            {
                new RowData { EquipmentName = "DXH900", IPAddress = "192.1.0.182",PortNo="80", IsConnected = false },
                new RowData { EquipmentName = "DXI800", IPAddress = "192.1.0.181",PortNo="90", IsConnected = true },
                new RowData { EquipmentName = "Cobas", IPAddress = "192.1.0.183",PortNo="70", IsConnected = false }
            };

            dataGridView1.Rows.Clear();
            foreach (var item in dataList)
            {
                int rowIndex = dataGridView1.Rows.Add(item.EquipmentName, item.IPAddress, item.PortNo, item.IsConnected ? connectedImage : disconnectedImage);
                // Keep buttons blank, text set via UseColumnTextForButtonValue
            }

            // Update ComboBox and TextBox values bindings manually since we used DataPropertyName for clarity
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Header row

            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnConnect")
            {
                dataList[e.RowIndex].IsConnected = true;
                UpdateRowStatus(e.RowIndex);
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "btnDisconnect")
            {
                dataList[e.RowIndex].IsConnected = false;
                UpdateRowStatus(e.RowIndex);
            }
        }

        private void UpdateRowStatus(int rowIndex)
        {
            var row = dataGridView1.Rows[rowIndex];
            row.Cells["AnalyserStatus"].Value = dataList[rowIndex].IsConnected ? connectedImage : disconnectedImage;

            var threadParameters = new ThreadStart(delegate { WriteTextSafe(dataList[rowIndex].IsConnected == true ? "Connect" : "Disconnect"); }); 
            var thread2 = new Thread(threadParameters);
            thread2.Start();
        }

        private void WriteTextSafe(string text)
        {
            //connect_button.Text = "Disconnect";
            var connect_button = (Button)this.Controls.Find(string.Concat("btnConnect"), true)[0];
            if (connect_button.InvokeRequired)
            {
                // Call this same method but append THREAD2 to the text
                Action safeWrite = delegate { WriteTextSafe($"{text}"); };
                connect_button.Invoke(safeWrite);
            }
            else
                connect_button.Text = text;
        }
    }
}
