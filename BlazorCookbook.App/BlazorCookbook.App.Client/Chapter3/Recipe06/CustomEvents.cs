using Microsoft.AspNetCore.Components;

namespace BlazorCookbook.App.Client.Chapter3.Recipe06
{
    [EventHandler("onpreventcopy", typeof(PreventedCopyEventArgs))] /*the EventHandler attribute informs Razor of our custom onpreventcopy event*/
    public static class EventHandlers { }

    public class PreventedCopyEventArgs : EventArgs
    {
        public DateTime Stamp { get; init; }
    }
}
