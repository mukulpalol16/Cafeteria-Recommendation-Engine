﻿using CafeteriaRecommendationSystem.Common;
using System.Net.Sockets;
using System.Text;

namespace CafeteriaRecommendationSystem.Client.OptionCommand
{
    public class DeleteMenuItemCommand : ICommand
    {
        private NetworkStream _stream;
        public DeleteMenuItemCommand(NetworkStream stream)
        {
            _stream = stream;
        }
        public void Execute(RoleEnum role)
        {
            Console.Write("Enter menu item id to delete: ");
            string menuItemId = Console.ReadLine();

            string optionRequest = $"option|{(int)role}|3|{menuItemId}";
            byte[] data = Encoding.ASCII.GetBytes(optionRequest);
            _stream.Write(data, 0, data.Length);

            byte[] response = new byte[256];
            int bytes = _stream.Read(response, 0, response.Length);
            string serverResponse = Encoding.ASCII.GetString(response, 0, bytes);
            Console.WriteLine("\nServer response: " + serverResponse);
        }
    }
}
