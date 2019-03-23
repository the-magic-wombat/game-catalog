using Data;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class GameBusiness
    {
        private GameContext gameContext;
        private Game game;

        public List<Game> GetAll()
        {
            using (gameContext = new GameContext())
            {
                return gameContext.Game.ToList();
            }
        }

        public void Add(Game game)
        {
            using (gameContext = new GameContext())
            {
                gameContext.Game.Add(game);
                gameContext.SaveChanges();
            }
        }
        public void Update(Game game)
        {
            using (gameContext = new GameContext())
            {
                var item = gameContext.Game.Find(game.Id);
                if(item!=null)
                {
                    gameContext.Entry(item).CurrentValues.SetValues(game);
                    gameContext.SaveChanges();
                }

            }
        }
        public void Delete(string name)
        {
            using (gameContext = new GameContext())
            {
                var game = gameContext.Game.Find(name);
                if(game!=null)
                {
                    gameContext.Game.Remove(game);
                    gameContext.SaveChanges();
                }
            }
        }

        public Game FindByName(string name)
        {
            using (gameContext = new GameContext())
            {
                return gameContext.Game.Find(name);
            }
        }

        public List<Game> FindByDeveloper(string developer)
        {
            using (gameContext = new GameContext())
            {
                return gameContext.Game.SqlQuery("SELECT * FROM GameContext WHERE Developer = @developer", developer).ToList();
            }
        }
        public List<Game> FindByGenre(string genre)
        {
            using (gameContext = new GameContext())
            {
                return gameContext.Game.SqlQuery("SELECT * FROM GameContext WHERE Genre LIKE %@genre%", genre).ToList();
            }
        }
    }
}
