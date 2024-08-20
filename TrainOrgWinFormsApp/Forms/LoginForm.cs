using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TrainOrgApi.Dtos;

namespace TrainOrgWinFormsApp.Forms
{
    public partial class LoginForm : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            UserForm userform = new UserForm(); // Создаем экземпляр Form2
            userform.Show(); // Открываем Form2
        }

        private async void buttonOk_Click(object sender, EventArgs e)
        {
            string username = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            var result = await AuthenticateUser(username, password);
            if (result)
            {
                MessageBox.Show("Вход выполнен успешно!");
                MainMenuForm mainmenuform = new MainMenuForm(); // Создаем экземпляр Form2
                mainmenuform.Show();

                //this.Close();
                this.Hide();
                // Здесь можно перейти на главную форму приложения
            }
            else
            {
                labelStatus.Text = "Неверное имя пользователя или пароль.";
            }
        }
        private async Task<bool> AuthenticateUser(string username, string password)
        {
            string apiUrl = "https://localhost:7116/User/check_user";
            var user = new LoginDto { Name = username, Password = password };
            //var user = new { Username = username, Password = password };
            var json = JsonSerializer.Serialize(user);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(apiUrl, content); 

            return response.IsSuccessStatusCode;
            //return true;
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
