namespace ImageGallery.Model;

public sealed class ImageForUpdate
{
    [Required]
    [MaxLength(150)]
    public string Title { get; set; }

    public ImageForUpdate(string title)
    {
        Title = title;
    }
}
