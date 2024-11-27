using Microsoft.EntityFrameworkCore;
using Pronia.BL.Services.Abstractions;
using Pronia.DAL.Contexts;
using Pronia.DAL.Models;

namespace Pronia.BL.Services.Concretes;

public class SliderItemService : ISliderItemService
{
    private readonly ProniaDBContext _context;

    public SliderItemService(ProniaDBContext context)
    {
        _context = context;
    }

    public async Task CreateSliderItemAsync(SliderItem item)
    {
        await _context.SliderItems.AddAsync(item);
        _context.SaveChanges();
    }
    public async Task SoftDeleteSliderItemAsync(int id)
    {
        SliderItem sliderItems = await _context.SliderItems.FindAsync(id);
        if (sliderItems is null) { throw new Exception("Id is found"); }
        if (sliderItems.IsDeleted) { throw new Exception("Id is not found"); }
        sliderItems.IsDeleted = true;
        _context.SaveChangesAsync();
    }
    public async Task HardDeleteSliderItemAsync(int id)
    {
        SliderItem sliderItems = _context.SliderItems.Where(x => x.Id == id).FirstOrDefault();
        if (sliderItems is null) { throw new Exception("Id is found"); }
        if (!sliderItems.IsDeleted) { throw new Exception("IId Soft Delete olunub kimisinden ;)"); }
        _context.SliderItems.Remove(sliderItems);
        _context.SaveChangesAsync();

    }

    public async Task<List<SliderItem>> GetAllSliderItemsAsync()
    {
        List<SliderItem> sliderItems = await _context.SliderItems.ToListAsync();
        return sliderItems;
    }

    public SliderItem GetSliderItem(int id)
    {
        throw new NotImplementedException();
    }

    public void UpdateSliderItem(int id, SliderItem sliderItem)
    {
        throw new NotImplementedException();
    }

    public Task UpdateSliderItemAsync(int id, SliderItem sliderItem)
    {
        throw new NotImplementedException();
    }

    public Task CreateSliderItemAsync(SliderItem sliderItem, SliderItem vm)
    {
        throw new NotImplementedException();
    }
}
