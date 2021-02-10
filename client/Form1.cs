using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using client.Models;
using client.Managers;
using System.Security.Claims;

namespace client
{
    public partial class Form1 : Form
    {
        String URL = "http://localhost:4000/users";
        String ROUTE = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GetAll_Click(object sender, EventArgs e)
        {
            var client = new RestClient(URL);
            String ROUTE = "";
            var request = new RestRequest(ROUTE, Method.GET);
            request.RequestFormat = DataFormat.Json;

            IRestResponse<List<User>> response = client.Execute<List<User>>(request);
            foreach (User user in response.Data)
            {
                InfoConsole.Items.Add(user.id + " " + user.firstName + " " + user.lastName);
            }
        }

        private void GetId_Click(object sender, EventArgs e)
        {
            var client = new RestClient(URL);
            String ROUTE = IdBox.Text;
            var request = new RestRequest(ROUTE, Method.GET);  //read by id
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            IdBox.Text = content;
        }

        private void UpdateId_Click(object sender, EventArgs e)
        {
            var client = new RestClient(URL);
            var request = new RestRequest(ROUTE, Method.PUT);  //Update
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(new User
            {
                id = int.Parse(IdBox.Text),
                firstName = FirstName.Text,
                lastName = LastName.Text,
                username = Username.Text,
                password = Password.Text
            });
            IRestResponse response = client.Execute(request);

        }

        private void DeleteId_Click(object sender, EventArgs e)
        {
            var client = new RestClient(URL);
            String ROUTE = IdBox.Text;
            var request = new RestRequest(ROUTE, Method.DELETE);  //Delete by id
            IRestResponse response = client.Execute(request);

        }

        private void Authenticate_Click(object sender, EventArgs e)
        {
            String ROUTE = "/authenticate";
            var client = new RestClient(URL);
            var request = new RestRequest(ROUTE, Method.POST);  //Login
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(new User
            {
                username = userNameLogin.Text,
                password = passwordLogin.Text,
            });
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            InfoConsole.Items.Add(content);


        }

        private void Register_Click(object sender, EventArgs e)
        {
            String ROUTE = "/register";
            var client = new RestClient(URL);
            var request = new RestRequest(ROUTE, Method.POST);
            request.RequestFormat = DataFormat.Json;

            request.AddJsonBody(new User
            {
                firstName = FirstName.Text,
                lastName = LastName.Text,
                username = Username.Text,
                password = Password.Text,
            });
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            InfoConsole.Items.Add(content);
        }
    }

    public class User
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
