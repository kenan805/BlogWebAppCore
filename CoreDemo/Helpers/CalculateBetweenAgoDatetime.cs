using System;

namespace CoreDemo.Helpers
{
    public static class CalculateBetweenAgoDatetime
    {
        public static string GetDifferenceMessage(DateTime sendedDateTime)
        {
            var betweenDT = DateTime.Now.Subtract(sendedDateTime);
            string message = "";


            if (betweenDT.Days >= 1)
            {
                message = sendedDateTime.ToString("dd-MMM-yyyy");
            }
            else if (betweenDT.Hours >= 1)
            {
                message = $"{betweenDT.Hours} saat əvvəl";
            }
            else if (betweenDT.Minutes >= 1)
            {
                message = $"{betweenDT.Minutes} dəqiqə əvvəl";
            }
            else if (betweenDT.Seconds >= 1)
            {
                message = $"{betweenDT.Seconds} saniyə əvvəl";
            }
            return message;
        }
    }
}
