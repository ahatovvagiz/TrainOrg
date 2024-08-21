using System.Text;
using System.Text.Json;
using TrainOrgApi.Dtos;
using TrainOrgApi.Models;

namespace TrainOrgWinFormsApp.Forms
{
    public partial class UserForm : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public UserForm()
        {
            InitializeComponent();
        }
        private async void SaveUser()
        {
            string apiUrl = "https://localhost:7116/User/add_user";
            var username = textName.Text;
            var password = textPassword.Text;

            if (int.TryParse(comboBoxRole.Text, out int roleid) == false)
            {
                labelStatus.Text = "Некорректно заполнена роль.";
                return;
            }
            //var roleid = int.Parse();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                labelStatus.Text = "Пожалуйста, заполните все поля.";
                return;
            }

            var user = new UserDto { Name = username, Password = password, RoleId = (RoleIdDto)roleid };
            var json = JsonSerializer.Serialize(user);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var response = await client.PostAsync(apiUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    labelStatus.Text = "Пользователь успешно зарегистрирован!";
                }
                else
                {
                    labelStatus.Text = $"Ошибка: {response.ReasonPhrase}";
                }
            }
            catch (Exception ex)
            {
                labelStatus.Text = $"Ошибка: {ex.Message}";
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            SaveUser();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            comboBoxRole.Items.Add(0);
            comboBoxRole.Items.Add(1);
        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
