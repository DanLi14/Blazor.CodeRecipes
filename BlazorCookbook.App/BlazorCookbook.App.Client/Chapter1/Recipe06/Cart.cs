namespace BlazorCookbook.App.Client.Recipe06
{
    // Cart requires an Action delegate, because adding to the cart happens at the Ticket component, which invokes StateHasChanged()
    // Normally this wouldn't impact the parent component, but an Action delegate allows the Cart object to persist 
    // and therefore trigger a DOM update at any level of the component tree. 
    public class Cart(Action onStateHasChanged)
    {
        public List<string> Content { get; set; } = [];
        public decimal Value { get; set; }
        public int Volume => Content.Count;
        public void Add(string tariff, decimal price)
        {
            Content.Add(tariff);
            Value += price;
            onStateHasChanged.Invoke(); // communicates state change to external objects
        }
    }
}
