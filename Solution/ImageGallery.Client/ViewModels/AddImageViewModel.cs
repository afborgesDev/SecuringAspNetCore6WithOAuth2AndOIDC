using System.ComponentModel.DataAnnotations;

namespace ImageGallery.Client.ViewModels;

public sealed class AddImageViewModel
{
    public List<IFormFile> Files { get; set; } = new ();

    [Required]
    public string Title { get; set; }

    public AddImageViewModel(string title, List<IFormFile> files)
    {
        Title = title;
        Files = files;
    }

    public AddImageViewModel()
    {
    }
}
