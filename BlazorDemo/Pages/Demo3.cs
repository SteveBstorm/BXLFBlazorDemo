using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorDemo.Pages
{
    public partial class Demo3
    {
        [Inject]
        private IJSRuntime _js { get; set; }

        public int Valeur { get; set; } = 5;

        public void Increment()
        {
            Valeur++;
        }

        public void Decrement()
        {
            Valeur--;
        }

        public bool stopIncrement()
        {
            return Valeur >= 10;
        }

       // public async Task<int> StockValue()
        public void StockValue()
        {
            //int s;
            _js.InvokeVoidAsync("localStorage.setItem", "mavaleur", Valeur);
            //return await _js.InvokeAsync<int>("Math.Random", 1, 100);
        }
    }
}
