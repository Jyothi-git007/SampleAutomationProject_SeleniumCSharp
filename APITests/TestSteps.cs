using APITests.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITests
{
    public class TestSteps
    {
        private Helper helper;

        public TestSteps()
        {
            helper = new Helper();
        }
        public Users GetUsers()
        {
            var client = helper.SetUrl();
            var request = helper.CreateGetRequset("api/users?page=2");
            request.RequestFormat = DataFormat.Json;
            var response = helper.GetResponse(client, request);
            var users = helper.GetContent<Users>(response);
            return users;
        }

        public CreateUserResponse CreateNewUser(string payload)
        {
            var client = helper.SetUrl();
            var request = helper.CreatePostRequest("api/users", payload);
            var response = helper.GetResponse(client, request);
            var createuser = helper.GetContent<CreateUserResponse>(response);
            return createuser;
        }

        public UpdateUserResponse UpdateUser(string payload)
        {
            var client = helper.SetUrl();
            var request = helper.CreatePutRequest("api/users/2", payload);
            var response = helper.GetResponse(client, request);
            var updateuser = helper.GetContent<UpdateUserResponse>(response);
            return updateuser;
        }
    }
}
