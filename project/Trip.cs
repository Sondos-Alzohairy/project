using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace project
{
    public partial class Trip : Form
    {
        private string connectionString = "Server=localhost;Database=TrainStation;Trusted_Connection=True;";

        public Trip()
        {
            InitializeComponent();
            LoadStations();
        }

        // Load station names into comboBox1 (From) and comboBox2 (To)
        private void LoadStations()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT station_name FROM station";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string stationName = reader["station_name"].ToString();
                        comboBox1.Items.Add(stationName); // "From" stations
                        comboBox2.Items.Add(stationName); // "To" stations
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading stations: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Show available trips when button1 is clicked
        private void button1_Click(object sender, EventArgs e)
        {
            string fromStation = comboBox1.SelectedItem?.ToString();
            string toStation = comboBox2.SelectedItem?.ToString();
            DateTime selectedDate = dateTimePicker1.Value.Date;

            if (string.IsNullOrEmpty(fromStation) || string.IsNullOrEmpty(toStation))
            {
                MessageBox.Show("Please select both 'From' and 'To' stations.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (fromStation == toStation)
            {
                MessageBox.Show("'From' and 'To' stations cannot be the same.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT t.trip_id, t.trip_time, t.price 
                        FROM trip t
                        JOIN station s1 ON t.start_station_id = s1.station_id
                        JOIN station s2 ON t.end_station_id = s2.station_id
                        WHERE s1.station_name = @fromStation
                          AND s2.station_name = @toStation
                          AND CONVERT(DATE, t.trip_time) = @selectedDate";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@fromStation", fromStation);
                    command.Parameters.AddWithValue("@toStation", toStation);
                    command.Parameters.AddWithValue("@selectedDate", selectedDate);

                    SqlDataReader reader = command.ExecuteReader();
                    comboBox3.Items.Clear(); // Clear previous results

                    while (reader.Read())
                    {
                        string tripInfo = $"Trip ID: {reader["trip_id"]}, Time: {reader["trip_time"]}, Price: {reader["price"]}";
                        comboBox3.Items.Add(tripInfo);
                    }

                    if (comboBox3.Items.Count == 0)
                    {
                        MessageBox.Show("No available trips found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching trips: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
