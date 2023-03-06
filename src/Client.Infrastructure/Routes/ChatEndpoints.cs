﻿namespace Inventory.Client.Infrastructure.Routes
{
    public static class ChatEndpoint
    {
        public const string GetAvailableUsers = "api/chats/users";
        public const string SaveMessage = "api/chats";

        public static string GetChatHistory(string userId)
        {
            return $"api/chats/{userId}";
        }
    }
}