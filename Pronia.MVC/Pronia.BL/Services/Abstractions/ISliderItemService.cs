using Pronia.DAL.Models;

namespace Pronia.BL.Services.Abstractions;

public interface ISliderItemService
{
    SliderItem GetSliderItem(int id);
    Task<List<SliderItem>> GetAllSliderItemsAsync();

    Task CreateSliderItemAsync(SliderItem sliderItem);
    Task CreateSliderItemAsync(SliderItem sliderItem, SliderItem vm);
    Task UpdateSliderItemAsync(int id, SliderItem sliderItem);
    Task SoftDeleteSliderItemAsync(int id);
    Task HardDeleteSliderItemAsync(int id);
}
