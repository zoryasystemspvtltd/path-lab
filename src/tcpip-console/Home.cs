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

        // For threading
        private Dictionary<int, Thread> analyserThreads = new Dictionary<int, Thread>();
        private Dictionary<int, bool> analyserCancels = new Dictionary<int, bool>();

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
                HeaderText = "Model",
                DataPropertyName = "EquipmentModel",
                Name = "EquipmentModel",
                DataSource = new List<string> { "DXH900", "DXI800", "Cobas" }
            };
            dataGridView1.Columns.Add(comboColumn);

            // Textbox column
            var textColumn1 = new DataGridViewTextBoxColumn
            {
                HeaderText = "Analyser Name",
                DataPropertyName = "EquipmentName",
                Name = "EquipmentName",
                Width = 200
            };
            dataGridView1.Columns.Add(textColumn1);

            // Textbox column
            var textColumn2 = new DataGridViewTextBoxColumn
            {
                HeaderText = "IP Address",
                DataPropertyName = "IPAddress",
                Name = "IPAddress",
                Width = 100
            };
            dataGridView1.Columns.Add(textColumn2);

            // Textbox column
            var textColumn3 = new DataGridViewTextBoxColumn
            {
                HeaderText = "Port No",
                DataPropertyName = "PortNo",
                Name = "PortNo",
                Width = 50
            };
            dataGridView1.Columns.Add(textColumn3);
            // Image column to display status
            var imageColumn = new DataGridViewImageColumn
            {
                HeaderText = "Status",
                Name = "AnalyserStatus",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 50
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

            this.panel1.Controls.Add(dataGridView1);           
        }

        // Data model for each row
        public class AnalyserModel
        {
            public string EquipmentModel { get; set; }
            public string EquipmentName { get; set; }
            public string IPAddress { get; set; }
            public string PortNo { get; set; }
            public bool IsConnected { get; set; }
        }

        private BindingList<AnalyserModel> dataList;

        private Image connectedImage = Properties.Resources.connected; // replace with your image resource or file
        private Image disconnectedImage = Properties.Resources.notconnected; // replace with your image resource or file

        private void LoadData()
        {
            // Sample data
            dataList = new BindingList<AnalyserModel>
            {
                new() { EquipmentModel = "DXH900",EquipmentName = "DXH 800 Hematology", IPAddress = "192.1.0.182",PortNo="80", IsConnected = false },
                new() { EquipmentModel = "DXI800",EquipmentName = "DXI 800 Powerlink", IPAddress = "192.1.0.181",PortNo="90", IsConnected = true },
                new() { EquipmentModel = "Cobas",EquipmentName = "Cobas E411 Biochemistry", IPAddress = "192.1.0.183",PortNo="70", IsConnected = false }
            };

            dataGridView1.Rows.Clear();
            foreach (var item in dataList)
            {
                int rowIndex = dataGridView1.Rows.Add(item.EquipmentModel, item.EquipmentName, item.IPAddress, item.PortNo, item.IsConnected ? connectedImage : disconnectedImage);
                // Keep buttons blank, text set via UseColumnTextForButtonValue                
            }

            // Update ComboBox and TextBox values bindings manually since we used DataPropertyName for clarity
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Header row           
            var row = dataGridView1.Rows[e.RowIndex];
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnConnect")
            {
                //UpdateRowStatus
                dataList[e.RowIndex].IsConnected = true;
                row.Cells["AnalyserStatus"].Value = dataList[e.RowIndex].IsConnected ? connectedImage : disconnectedImage;
                dataGridView1.Refresh(); // Updates button appearance
                OnConnect(e.RowIndex);
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "btnDisconnect")
            {
                //UpdateRowStatus
                dataList[e.RowIndex].IsConnected = false;
                row.Cells["AnalyserStatus"].Value = dataList[e.RowIndex].IsConnected ? connectedImage : disconnectedImage;
                dataGridView1.Refresh(); // Updates button appearance
                OnDisconnect(e.RowIndex);
            }
        }

        private void OnConnect(int rowIndex)
        {
            analyserCancels[rowIndex] = false; // Reset cancel flag
            Thread t = new Thread(() => AnalyserWorker(rowIndex));
            analyserThreads[rowIndex] = t; // Save analyser thread 
            t.IsBackground = true;
            t.Start();
        }
        private void OnDisconnect(int rowIndex)
        {
            if (analyserCancels.ContainsKey(rowIndex))
                analyserCancels[rowIndex] = true; // Signal thread to stop

            // Optionally wait for thread to finish and cleanup thread dictionary elsewhere
        }
        private void AnalyserWorker(int rowIndex)
        {
            // Mark connected on UI
            RunOnUI(() => {
                dataList[rowIndex].IsConnected = true;
            });

            // Replace this loop with your own analyser-processing logic
            while (!analyserCancels[rowIndex])
            {
                // Do analyser work here...
                Thread.Sleep(100); // Simulate work
            }

            // Clean up and update UI when stopping
            RunOnUI(() => {
                dataList[rowIndex].IsConnected = false;
            });
        }

        private void RunOnUI(System.Windows.Forms.MethodInvoker action)
        {
            if (this.InvokeRequired)
                this.Invoke(action);
            else
                action();
        }


    }
}
