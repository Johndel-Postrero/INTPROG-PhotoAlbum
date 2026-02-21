using Microsoft.AspNetCore.Mvc;
using PhotoAlbum_Postrero.Models;

namespace PhotoAlbum_Postrero.Controllers
{
    public class AlbumController : Controller
    {
        private readonly IWebHostEnvironment _env;

        public AlbumController(IWebHostEnvironment env)
        {
            _env = env;
        }

        private List<Photo> BuildPhotoList(string folder, string title, string[] captions)
        {
            var photos = new List<Photo>();
            string[] supportedExtensions = { ".jpg", ".jpeg", ".png", ".webp", ".avif", ".gif" };

            for (int i = 0; i < captions.Length; i++)
            {
                string fileName = $"scene{i + 1}";
                string extension = ".jpg";

                foreach (var ext in supportedExtensions)
                {
                    var filePath = Path.Combine(_env.WebRootPath, "images", folder, fileName + ext);
                    if (System.IO.File.Exists(filePath))
                    {
                        extension = ext;
                        break;
                    }
                }

                photos.Add(new Photo
                {
                    ImagePath = $"~/images/{folder}/{fileName}{extension}",
                    Description = captions[i],
                    MovieTitle = title
                });
            }
            return photos;
        }
        public IActionResult GraveOfTheFireflies()
        {
            var photos = BuildPhotoList("grave_of_the_fireflies", "Grave of the Fireflies", new[]
            {
                "Seita carrying Setsuko through the burning city",
                "Setsuko smiling while playing with fireflies at night",
                "The siblings sheltering in the hillside cave",
                "Seita cooking rice for Setsuko by the pond",
                "Fireflies illuminating the dark cave entrance",
                "Setsuko making mud rice balls in the rain",
                "The devastating firebombing of Kobe city",
                "Seita watching over sleeping Setsuko gently",
                "The siblings walking through destroyed neighborhoods",
                "Setsuko chasing butterflies in the meadow",
                "Seita scavenging for food in abandoned homes",
                "The haunting opening scene at the train station",
                "Setsuko playing with her beloved fruit drop tin",
                "The siblings bathing in the river together",
                "Seita carrying water buckets up the hillside",
                "Night sky filled with glowing fireflies",
                "Setsuko sleeping peacefully in the shelter",
                "The mother wrapped in bandages at the school",
                "Seita running through the burning streets alone",
                "The final scene with spirits of the siblings"
            });
            return View(photos);
        }


        public IActionResult YourName()
        {
            var photos = BuildPhotoList("your_name", "Your Name", new[]
            {
                "Taki and Mitsuha reaching for each other at twilight",
                "The Tiamat comet streaking across the night sky",
                "Mitsuha performing the Miyamizu shrine ritual",
                "Taki sketching the Itomori landscape from memory",
                "The body-swap morning confusion scene",
                "Mitsuha braiding the kumihimo cord carefully",
                "Taki standing on the Tokyo overpass at sunset",
                "The crater lake of Itomori from above",
                "Mitsuha cutting her hair with scissors",
                "Taki and Mitsuha writing on each other's hands",
                "The magical katawaredoki twilight meeting moment",
                "Taki exploring rural Itomori town for the first time",
                "Mitsuha running through Tokyo streets excitedly",
                "The comet splitting apart above the mountains",
                "Taki on his date at the Italian restaurant",
                "The Miyamizu shrine hidden cave with sake",
                "Mitsuha and Yotsuha performing the ritual dance",
                "Taki desperately searching for Itomori's location",
                "The staircase reunion scene in Tokyo",
                "The breathtaking Itomori town panoramic view"
            });
            return View(photos);
        }


        public IActionResult ASilentVoice()
        {
            var photos = BuildPhotoList("a_silent_voice", "A Silent Voice", new[]
            {
                "Shoya meeting Shoko at the bridge for the first time",
                "Shoko signing friend with a warm smile",
                "Shoya with blue X marks over peoples faces",
                "The notebook conversation between Shoya and Shoko",
                "Shoko feeding the koi fish at the pond",
                "Shoya standing alone on the bridge at sunset",
                "The elementary school classroom flashback scene",
                "Shoko's hearing aids on the school desk",
                "Yuzuru taking photographs at the riverbank",
                "Shoya and Shoko at the fireworks festival",
                "The emotional hospital rooftop scene",
                "Shoko practicing sign language with determination",
                "Shoko falling from the balcony dramatically",
                "The friend group reunion at the bridge",
                "Shoko playing with her little sister Yuzuru",
                "Shoya removing the X marks and seeing faces again",
                "The school festival with everyone together",
                "Shoko standing in the rain looking down",
                "Shoya reaching out his hand to Shoko",
                "The final scene with Shoya crying tears of joy"
            });
            return View(photos);
        }


        public IActionResult WeatheringWithYou()
        {
            var photos = BuildPhotoList("weathering_with_you", "Weathering With You", new[]
            {
                "Hina praying and the clouds parting to reveal sunshine",
                "Hodaka arriving in Tokyo on the ferry in rain",
                "Hina floating above the clouds in the sky",
                "Hodaka and Hina running through rainy streets",
                "The rooftop shrine where Hina gained her powers",
                "Sunshine breaking through clouds over Tokyo skyline",
                "Hodaka working at Keisuke's small publishing office",
                "Hina and Nagi creating a sunshine business plan",
                "The fireworks festival with clear weather overhead",
                "Rain pouring endlessly over Tokyo's neon streets",
                "Hina beginning to turn transparent and fade away",
                "Hodaka running desperately through flooded streets",
                "The sky fish swimming through clouds above Tokyo",
                "Nagi playing with his friends at the park",
                "Hodaka and Hina sharing McDonald's french fries",
                "The abandoned building rooftop torii gate scene",
                "Tokyo submerged underwater in the dramatic climax",
                "Hina falling through the sky reaching for Hodaka",
                "The reunion scene on the Tokyo hillside steps",
                "The sun breaking through over the flooded city"
            });
            return View(photos);
        }


        public IActionResult YourLieInApril()
        {
            var photos = BuildPhotoList("your_lie_in_april", "Your Lie in April", new[]
            {
                "Kaori playing violin under cherry blossom trees",
                "Kousei sitting frozen at the grand piano on stage",
                "Kaori and Kousei performing their duet together",
                "Cherry blossoms falling in the spring sunlight",
                "Kousei practicing piano alone in the dark room",
                "Kaori laughing while eating caneles at the cafe",
                "The competition stage with spotlight on the piano",
                "Tsubaki watching Kousei from the school hallway",
                "Kousei remembering his mother at the piano bench",
                "Kaori standing on the bridge with her violin case",
                "The rooftop scene with Kaori and Kousei talking",
                "Musical notes floating across the spring sky",
                "Kousei's hands trembling above the piano keys",
                "Kaori collapsing on stage during her performance",
                "Watari playing soccer while Kaori watches and cheers",
                "Kousei Arima's visits to Kaori Miyazono in the hospital",
                "Kousei performing his final competition piece alone",
                "Kaori's letter being read by Kousei in tears",
                "The imaginary final duet between Kousei and Kaori",
                "Cherry blossoms in April — the bittersweet ending"
            });
            return View(photos);
        }
    }
}
