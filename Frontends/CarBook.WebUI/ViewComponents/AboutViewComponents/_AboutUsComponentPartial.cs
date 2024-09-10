using Carbook.Dto.AboutDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.ViewComponents.AboutViewComponents
{
    public class _AboutUsComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _client;

        public _AboutUsComponentPartial(IHttpClientFactory client)
        {
            _client = client;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _client.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7210/api/Abouts");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAboutDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
