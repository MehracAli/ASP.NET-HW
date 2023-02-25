using APS_HomeWork1.Models;
using Microsoft.AspNetCore.Mvc;

namespace APS_HomeWork1.Controllers
{
	public class HomeController:Controller
	{
		public List<Game> Games;
		public List<Category> Categories;
		public HomeController()
		{
			Games = new List<Game>()
			{
				new Game()
				{
					Id = 1,
					Poster = "https://itorrents-igruha.org/uploads/posts/2022-10/1665253061_cover.jpg",
					Name = "Red Dead Redemption 2",
					Describtion = "Developed by the creators of Grand Theft Auto V and Red Dead Redemption, Red Dead Redemption 2 is an epic tale of life in America’s unforgiving heartland. The game’s vast and atmospheric world also provides the foundation for a brand new online multiplayer experience. America, 1899. The end of the Wild West era has begun. After a robbery goes badly wrong in the western town of Blackwater, Arthur Morgan and the Van der Linde gang are forced to flee. With federal agents and the best bounty hunters in the nation massing on their heels, the gang has to rob, steal and fight their way across the rugged heartland of America in order to survive. As deepening internal fissures threaten to tear the gang apart, Arthur must make a choice between his own ideals and loyalty to the gang that raised him.",
					Price = 69.99,
					Metascore = 97
				},

				new Game()
				{
					Id = 2,
					Poster = "https://itorrents-igruha.org/uploads/posts/2021-05/1620958738_cover.jpg",
					Name = "Star Wars Jedi: Fallen Order",
					Describtion = "A third-person action-adventure Star Wars title from Respawn Entertainment. The Empire seeks to eradicate all Jedi after the execution of Order 66. You, a Jedi Padawan-turned-fugitive, must fight for your survival as you explore the mysteries of a long-extinct civilization in hopes of rebuilding the Jedi Order. After narrowly escaping the Jedi purge, you’re on a quest to rebuild your fallen Order. Pick up the pieces of your shattered past and complete your Jedi training, all while staying one step ahead of the Empire and its deadly Inquisitors. Utilize your Jedi training to overcome your opponents and solve the mysteries that lay in your path. Use the Force to augment the way you explore, allowing you to traverse new paths and discover parts of locations you’ve been to before. Move quickly, though. The Empire is on your trail and won’t stop until every Jedi is exterminated.",
					Price = 39.99,
					Metascore = 81
				},

				new Game()
				{
					Id = 3,
					Poster = "https://itorrents-igruha.org/uploads/posts/2022-12/1670951934_cover.jpg",
					Name = "High On Life",
					Describtion = "Fresh out of high school with no job and no ambition, you've really got nothing going for you until an alien cartel that wants to get high off humanity invades Earth. Now, you and a team of charismatic talking guns must answer the hero's call and become the deadliest intergalactic bounty hunter the cosmos has ever seen.\r\n\r\nTravel to various planets and locations across the cosmos, go up against the nefarious Garmantuous and his gang of goons, collect loot, meet unique characters, and more, in the latest comedy adventure from Justin Roiland!\r\n\r\nNavigate dynamic and changing worlds that range from a jungle paradise, to a city built inside an asteroid, the hub of the cosmos.\r\n\r\nLeverage the distinct skills of each gun to defeat a variety of diabolical alien enemies and track down Garmantuous.\r\n\r\nComplete hunter challenges, meet weird, fun, and hilarious characters, collect an array of alien technology, and more!",
					Price = 27.99,
					Metascore = 69
				},

				new Game()
				{
					Id = 4,
					Poster = "https://itorrents-igruha.org/uploads/posts/2022-05/1652791148_cover.png",
					Name = "Marvel's Guardians of the Galaxy",
					Describtion = "Fire up Star-Lord’s jet boots for a wild ride across the cosmos in this third-person action-adventure game, a fresh take on Marvel’s Guardians of the Galaxy. With the unpredictable Guardians at your side, blast your way from one explosive situation to another, with original and iconic Marvel characters caught in a struggle for the fate of the universe. You got this. Probably.", 
					Price = 49.99,
					Metascore = 80
				},

				new Game()
				{
					Id = 5,
					Poster = "https://itorrents-igruha.org/uploads/posts/2022-12/1670560415_library_600x900_2x.jpg",
					Name = "The Last Of Us: Part 1",
					Describtion = "In a ravaged civilization, where infected and hardened survivors run rampant, Joel, a weary protagonist, is hired to smuggle 14-year-old Ellie out of a military quarantine zone. However, what starts as a small job soon transforms into a brutal cross-country journey. Includes the complete The Last of Us single-player story and celebrated prequel chapter, Left Behind, which explores the events that changed the lives of Ellie and her best friend Riley forever.",
					Price = 49.99,
					Metascore = 88
				},

				new Game()
				{
					Id = 6,
					Poster = "https://itorrents-igruha.org/uploads/posts/2023-01/1673544990_wallpapersden.com_call-of-duty-modern-warfare-2-campaign-remastered_2048x2732.jpg",
					Name = "Call Of Duty: Modern Warfare 2",
					Describtion = "Modern Warfare 2 continues the gripping and heart-racing action as players face off against a new threat dedicated to bringing the world to the brink of collapse. An entirely new gameplay mode which supports 2-player co-operative play online that is unique from the single player story campaign. Special Ops pits players into a gauntlet of time-trial and objective-based missions. Rank-up as players unlock new Special Ops missions, each more difficult. Missions include highlights from the single player campaign, fan favorites from Call of Duty 4: Modern Warfare and all new, exclusive missions. Setting a new bar for online multiplayer, Modern Warfare 2 multiplayer delivers new capabilities, customization, gamestates and modes, including: Create-a-Class Evolved. Secondary Weapons - Machine Pistols, Shotguns, Handguns, Launchers. Riot Shields. Equipment - Throwing Knives, Blast Shield, Tactical Insertion. Perk Upgrades. Bling (Dual Attachments). Customizable Killstreaks - AC130, Sentry Gun, Predator Missile, Counter-UAV, Care Package. Accolades (Post match reports).",
					Price = 14.99,
					Metascore = 94
				},
			};
			Categories = new List<Category>()
			{
				new Category()
				{
					Id = 1,
					Name = "Sandbox"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Shooters (FPS and TPS)"
                },
                new Category()
                {
                    Id = 3,
                    Name = "Role-playing (RPG, ARPG, and More)"
                },
                new Category()
                {
                    Id = 4,
                    Name = "Action-adventure"
                },
            };
		}
		public ViewResult Index()
		{
			ViewBag.Categories = Categories;
			return View(Games);
		}
	}
}
