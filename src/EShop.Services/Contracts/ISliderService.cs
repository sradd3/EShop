using System.Collections.Generic;
using System.Threading.Tasks;
using EShop.Entities;
using EShop.ViewModels.Sliders;

namespace EShop.Services.Contracts
{
    public interface ISliderService : IGenericService<Slider>
    {
        Task<List<ShowSliderViewModel>> GetPreviewAsync();

        Task<EditSliderViewModel> GetForEdit(int id);

        Task<List<ShowSliderInFrontViewModel>> GetSlidersForFront();
    }
}