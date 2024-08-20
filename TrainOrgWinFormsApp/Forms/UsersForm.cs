using System.Net.Http;
using System.Text.Json; // or using Newtonsoft.Json
using System.Threading.Tasks;
using System.Windows.Forms; // Make sure you have this namespace for Windows Forms
using TrainOrgApi.Models;
using TrainOrgApi.Dtos;

namespace TrainOrgWinFormsApp
{
    public partial class UsersForm : Form
    {
        private SessionForm _parentForm;
        private static readonly HttpClient httpClient = new HttpClient();
        public UsersForm(SessionForm parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        private async void UsersForm_Load(object sender, EventArgs e)
        {
            await GetAllUsersAsync();
        }

        private async Task GetAllUsersAsync()
        {
            string apiUrl = "https://localhost:7116/User/get_all_users";
            //var json = JsonSerializer.Serialize(user);
            //var content = new StringContent(json, Encoding.UTF8, "application/json");

            //HttpResponseMessage response = await httpClient.PostAsync(apiUrl, content);
            HttpResponseMessage response = await httpClient.GetAsync(apiUrl);
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

                // Deserialize the response content into a list of user objects
                //var users = JsonSerializer.Deserialize<List<UsersDto>>(responseContent);
                var users = JsonSerializer.Deserialize<List<User>>(responseContent);
                //var users = JsonConvert.DeserializeObject<List<User>>(responseContent);
                dataGridViewUsers.DataSource = null;
                dataGridViewUsers.DataSource = users; // Bind the list to the DataGridView
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

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Предположим, что значение, которое мы хотим передать, находится в первом столбце
                string selectedValue = dataGridViewUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
                _parentForm.SetValue(selectedValue);
                this.Close(); // Закрываем дочернюю форму
            }
        }

        private void usersDtoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewUsers_CellContentClick(sender, e);
        }
    }
}
