using System;
using MeuApp.NotificationContext;

namespace MeuApp.ContentContext
{
    public abstract class Content
    {
        public Content(string title, string url)
        {
            Title = title;
            Url = url;
        }
        public string Title { get; set; }
        public string Url { get; set; }

    }
}