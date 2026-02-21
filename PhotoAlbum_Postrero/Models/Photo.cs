namespace PhotoAlbum_Postrero.Models
{
    public class Photo
    {
        // Relative path to the image file in wwwroot/images/
        // Example: "~/images/grave_of_the_fireflies/scene1.jpg"
        public string ImagePath { get; set; } = string.Empty;

        // Scene description / caption displayed under each photo
        public string Description { get; set; } = string.Empty;

        // Movie/album title (e.g. "Grave of the Fireflies")
        public string MovieTitle { get; set; } = string.Empty;
    }
}
