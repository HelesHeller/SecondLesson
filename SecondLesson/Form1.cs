namespace SecondLesson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public class User
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public double Weight { get; set; }
            public string Country { get; set; }
        }
        private List<User> users = new List<User>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            string name = txtName.Text;
            int age = Convert.ToInt32(txtAge.Text);
            double weight = Convert.ToDouble(txtWeight.Text);
            string country = txtCountry.Text;

            
            User newUser = new User
            {
                Name = name,
                Age = age,
                Weight = weight,
                Country = country
            };

            
            users.Add(newUser);
            UpdateUserList();
        }

        private void UpdateUserList()
        {
            
            lstUsers.Items.Clear();
            foreach (User user in users)
            {
                lstUsers.Items.Add($"Имя: {user.Name}, Возраст: {user.Age}, Вес: {user.Weight}, Страна: {user.Country}");
            }
        }


    }
}