using MedicinalPlantApp.DataAccess.Contexts;
using MedicinalPlantApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MedicinalPlantApp.DataAccess
{
    public  class DataSeeding
    {
        public static void Seed(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                if (!context.Plants.Any())
                {
                    context.Plants.AddRange(
                            new Plant
                            {
                                Id = Guid.NewGuid(),
                                CreatedDate = DateTime.Now,
                                Name = "Karayılan Otu",
                                Description = "Ateş basması ve menopoz tedavisi için kullanılan bir bitkidir.",
                                PlantImage = new PlantImage()
                                {
                                    Id = Guid.NewGuid(),
                                    CreatedDate = DateTime.Now,
                                    FileName = "Karayılan Otu",
                                    Path = "wwwroot/PlantImage/KarayılanOtu.jpg"
                                }
                            },
                            new Plant
                            {
                                Id = Guid.NewGuid(),
                                CreatedDate = DateTime.Now,
                                Name = "Yabani Yer Elması",
                                Description = "Östrojen etkisi ile hormon tedavilerinde elzem bir bitkidir.",
                                PlantImage = new PlantImage()
                                {
                                    Id = Guid.NewGuid(),
                                    CreatedDate = DateTime.Now,
                                    FileName = "Karayılan Otu",
                                    Path = "wwwroot/PlantImage/YabaniYerElması.jpg"
                                }
                            },
                            new Plant
                            {
                                Id = Guid.NewGuid(),
                                CreatedDate = DateTime.Now,
                                Name = "Aslan Kuyruğu",
                                Description = "Sakinleştirici ve uyuşturucu etkisi ile depresyon tedavilerinde kullanılır.",
                                PlantImage = new PlantImage()
                                {
                                    Id = Guid.NewGuid(),
                                    CreatedDate = DateTime.Now,
                                    FileName = "Karayılan Otu",
                                    Path = "wwwroot/PlantImage/AslanKuyruğu.jpg"
                                }
                            },
                            new Plant
                            {
                                Id = Guid.NewGuid(),
                                CreatedDate = DateTime.Now,
                                Name = "Adaçayı",
                                Description = "Cilde olan faydaları nedeni ile modern dünyada türlü kozmetik malzemenin içeriğinde kullanılır. Şifa bitkileri arasında olan adaçayı geçmişten bugüne kötü enerjiyi temizlemek için de yakılmakta ve dumanı tütsü gibi alanlarda gezdirilmektedir."
                            },
                            new Plant
                            {
                                Id = Guid.NewGuid(),
                                CreatedDate = DateTime.Now,
                                Name = "Ginseng",
                                Description = "Merkezi sinir sistemi hastalıklarında ve yaşlanma karşıtı ilaçlarda kullanılan ginseng yüzyıllardır bilinir."
                            }

                       );
                    context.SaveChanges();
                }

            }


        }
    }
}


