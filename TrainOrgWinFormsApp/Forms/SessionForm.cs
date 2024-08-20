using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using TrainOrgApi.Models;
using TrainOrgApi.Dtos;
using static System.Windows.Forms.DataFormats;

namespace TrainOrgWinFormsApp
{
    public partial class SessionForm : Form
    {
        DateTime currentTime = DateTime.Now;
        private static readonly HttpClient httpClient = new HttpClient();
        public SessionForm()
        {
            InitializeComponent();

            //Session person = new Session
            //{
            //    Id = "John Doe",
            //     = 30,
            //    Gender = "Male"
            //};
        }

        private void SessionForm_Load(object sender, EventArgs e)
        {
            // Создаем экземпляр класса Person
            Session session = new Session();

            // Присваиваем значения элементам управления
            textBoxId.Text = session.Id.ToString();
            dateTimePickerStartTime.Text = currentTime.ToString("yyyy-MM-dd HH:mm:ss");
            dateTimePickerEndTime.Text = currentTime.AddHours(2).ToString("yyyy-MM-dd HH:mm:ss");
            //labelAge.Text = $"Age: {person.Age}";
            //labelCity.Text = $"City: {person.City}";
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            // Create a new session object and assign values from text boxes
            SessionDto session = new SessionDto
            {
                //Id = int.Parse(textBoxId.Text),
                //User =      
                StartTime = DateTime.Parse(dateTimePickerStartTime.Text).ToUniversalTime(),
                EndTime = DateTime.Parse(dateTimePickerEndTime.Text).ToUniversalTime(),
                UserId = int.Parse(textBoxUser.Text),
                TrainerId = int.Parse(textBoxTrainer.Text)
                //User = new UsersDto()
                //{

                //}

            };

            // Call the method to save the session
            await SaveSessionAsync(session);
        }

        private async Task SaveSessionAsync(SessionDto session)
        {
            string apiUrl = "https://localhost:7116/Sessions/add_session"; // replace with your actual API URL
            var json = JsonSerializer.Serialize(session);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync(apiUrl, content);

            //if (response.IsSuccessStatusCode)
            //{
            //    MessageBox.Show("Session saved successfully!");
            //}
            //else
            //{
            //    MessageBox.Show($"Error saving session: {response.StatusCode}");
            //}
            if (response.IsSuccessStatusCode)
            {
                // Process the response
                var responseContent = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Response: " + responseContent);
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
            {
                // Read the error content for more details
                var errorContent = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Bad Request. Details: " + errorContent);
            }
            else
            {
                // Handle other status codes
                Console.WriteLine($"Error: {response.StatusCode}");
            }
        }

        private async Task GetAllSessionsAsync(SessionDto session)
        {
            string apiUrl = "https://localhost:7116/Sessions/get_all_sessions";
            var json = JsonSerializer.Serialize(session);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync(apiUrl, content);

            //if (response.IsSuccessStatusCode)
            //{
            //    MessageBox.Show("Session saved successfully!");
            //}
            //else
            //{
            //    MessageBox.Show($"Error saving session: {response.StatusCode}");
            //}
            if (response.IsSuccessStatusCode)
            {
                // Process the response
                var responseContent = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Response: " + responseContent);
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
            {
                // Read the error content for more details
                var errorContent = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Bad Request. Details: " + errorContent);
            }
            else
            {
                // Handle other status codes
                Console.WriteLine($"Error: {response.StatusCode}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUser_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void buttonUserForm_Click(object sender, EventArgs e)
        {
            UsersForm form2 = new UsersForm(this, false); // Создаем экземпляр Form2
            form2.Show(); // Открываем Form2
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        public void SetValue(string UserId, bool itsTrainer)
        {
            if (itsTrainer)
            {
                textBoxTrainer.Text = UserId;
            }
            else
            {
                textBoxUser.Text = UserId;
            }                      
        }

        private void buttonTrainer_Click(object sender, EventArgs e)
        {
            UsersForm form2 = new UsersForm(this, true); // Создаем экземпляр Form2
            form2.Show(); // Открываем Form2
        }
    }
}
