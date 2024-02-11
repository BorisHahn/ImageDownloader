namespace ImageDownloader;

public class Store
{
    private Dictionary<string, string> _images = new Dictionary<string, string>()
    {
        {
            "bigImage1.jpg",
            "https://img2.akspic.ru/attachments/originals/8/6/4/5/7/175468-seealpsee-gora-oblako-rastenie-zelenyj-8170x5338.jpg"
        },
        {
            "bigImage2.jpg",
            "https://img2.akspic.ru/attachments/originals/8/6/4/5/7/175468-seealpsee-gora-oblako-rastenie-zelenyj-8170x5338.jpg"
        },
        {
            "bigImage3.jpg",
            "https://img2.akspic.ru/attachments/originals/8/6/4/5/7/175468-seealpsee-gora-oblako-rastenie-zelenyj-8170x5338.jpg"
        },
        {
            "bigImage4.jpg",
            "https://img2.akspic.ru/attachments/originals/8/6/4/5/7/175468-seealpsee-gora-oblako-rastenie-zelenyj-8170x5338.jpg"
        },
        {
            "bigImage5.jpg",
            "https://img2.akspic.ru/attachments/originals/8/6/4/5/7/175468-seealpsee-gora-oblako-rastenie-zelenyj-8170x5338.jpg"
        },
        {
            "bigImage6.jpg",
            "https://img2.akspic.ru/attachments/originals/8/6/4/5/7/175468-seealpsee-gora-oblako-rastenie-zelenyj-8170x5338.jpg"
        },
        {
            "bigImage7.jpg",
            "https://img2.akspic.ru/attachments/originals/8/6/4/5/7/175468-seealpsee-gora-oblako-rastenie-zelenyj-8170x5338.jpg"
        },
        {
            "bigImage8.jpg",
            "https://img2.akspic.ru/attachments/originals/8/6/4/5/7/175468-seealpsee-gora-oblako-rastenie-zelenyj-8170x5338.jpg"
        },
        {
            "bigImage9.jpg",
            "https://img2.akspic.ru/attachments/originals/8/6/4/5/7/175468-seealpsee-gora-oblako-rastenie-zelenyj-8170x5338.jpg"
        },
        {
            "bigImage10.jpg",
            "https://img2.akspic.ru/attachments/originals/8/6/4/5/7/175468-seealpsee-gora-oblako-rastenie-zelenyj-8170x5338.jpg"
        },
    };

    public Dictionary<string, string> Images
    {
        get { return _images; }
    }
}