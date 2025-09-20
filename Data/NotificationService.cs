using Avalonia.Controls.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Data
{
    public class NotificationService
    {
        public static INotificationManager Manager { get; set; }

        public static void ShowError(string message)
        {
            Manager?.Show(new Notification("Lỗi", message, NotificationType.Error));
        }

        public static void ShowInfo(string message)
        {
            Manager?.Show(new Notification("Thông báo", message, NotificationType.Information));
        }
    }
}
