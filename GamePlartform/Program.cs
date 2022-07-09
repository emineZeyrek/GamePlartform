using GamePlartform.Abstract;
using GamePlartform.Concrete;
using GamePlartform.Entities;

namespace GamePlartform
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Oyuncuların tanımlanması ve yönetilmesi(Record,Delete,Update)

            PlayerManager playerManager1 = new PlayerManager();
            playerManager1.Record(new Player { DateOfBirth = new DateTime(2000,4,11),PlayerId=1,FirstName="Emine",LastName="Zeyrek",NationaltyId="11111111111"}) ;


            Player player1 = new Player();
            player1.PlayerId = 1;
            player1.FirstName = "Emine";
            player1.LastName = "Zeyrek";
            player1.NationaltyId = "11111111111";
            player1.DateOfBirth = new DateTime(2000, 4, 11);



            //PlayerManager playerManager2 = new PlayerManager();
            //playerManager2.Delete(new Player { DateOfBirth = new DateTime(1995, 4, 11), PlayerId = 1, FirstName = "Emine", LastName = "Zeyrek", NationaltyId = "11111111111" });


            //PlayerManager playerManager3 = new PlayerManager();
            //playerManager3.Record(new Player { DateOfBirth = new DateTime(1997, 4, 11), PlayerId = 1, FirstName = "Emine", LastName = "Zeyrek", NationaltyId = "11111111111" });


            //PlayerManager playerManager4 = new PlayerManager();
            //playerManager4.Update(new Player { DateOfBirth = new DateTime(1998, 4, 11), PlayerId = 1, FirstName = "Emine", LastName = "Zeyrek", NationaltyId = "11111111111" });



            Console.WriteLine("--------------");

            //Oyunlarn oluşturulduğu kısım

            Game game1 = new Game
            {
                GameName = "LOL",
                Category = "Action",
                GamePrice = "200"
            };


            Game game2 = new Game
            {
                GameName = "PUBG",
                Category = "Adventure",
                GamePrice = "150"
            };


            Game game3 = new Game
            {
                GameName = "XYZ",
                Category = "Action",
                GamePrice = "200"
            };


            Game game4 = new Game
            {
                GameName = "ABC",
                Category = "Adventure",
                GamePrice = "300"
            };



            //oyunların yönetildiği kısım

            GameManager gameManager = new GameManager();
            gameManager.Add(game2);
            gameManager.Delete(game4);


            //kampanlayarın tanımlanığı ve yönetildiği kısım

            CampaignService campaignService = new CampaignService();
            campaignService.Entry(new Campaigns { CampaignId = 1, CampaignName = "Bütün oynlarda geçerli Büyük Sezon İndirimi", CampaignDiscount="%30" });

            campaignService.Update(new Campaigns { });
            campaignService.Delete(new Campaigns { });


            //oyun satışı
            SalesManager salesManager = new SalesManager();
            salesManager.Record(player1,game2);
           
            


        }
    }

}