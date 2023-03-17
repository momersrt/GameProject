using System;
namespace GameProject
{
    public class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Oyuncu Başarıyla Kayıt Oldu.");
            }
            else
            {
                Console.WriteLine("Bilgiler Eşleşmedi, Kayıt Başarısız.");
            }
            
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Kaydı Silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Bilgileri Güncellendi.");
        }
    }
}

