using homework2.Methods;
using homework2.Models;


SeoLink seoLink = new SeoLink();


phone phone1 = new()
{
    ID = 1,
    Name = "IPhone 11",
    Price = 544.00M,
    SeoUrl = seoLink.Seo("IPhone 11"),
};

phone phone2 = new()
{
    ID = 2,
    Name = "Samsung A70",
    Price = 800M,
    SeoUrl = seoLink.Seo("Samsung A70"),
};


phone phone3 = new()
{
    ID = 3,
    Name = "Xiomi",
    Price = 400M,
    SeoUrl = seoLink.Seo("Xiomi"),
};


notebook notebook1 = new()
{
    ID = 1,
    Name = "Hp",
    Price = 1900M,
    SeoUrl = seoLink.Seo("Hp"),
};

notebook notebook2 = new()
{
    ID = 2,
    Name = "Acer",
    Price = 1500M,
    SeoUrl = seoLink.Seo("Acer"),
};


List<string>phonee = new();


phonee.Add(phone1.Name + " - " + phone1.Price);
phonee.Add(phone2.Name + " - " + phone2.Price);
phonee.Add(phone3.Name + " - " + phone3.Price);

Console.WriteLine(phonee);



List<string> noteebook = new();


noteebook.Add(notebook1.Name + " - " + notebook1.Price);
noteebook.Add(notebook2.Name + " - " + notebook2.Price);