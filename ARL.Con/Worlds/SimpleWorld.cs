using ARL.Con.Builder;
using ARL.Core.Models.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARL.Con.Worlds;

public class SimpleWorld
{
    const string TOWN1 = "town1";
    const string TOWN2 = "town2";

    public static World Create() =>
        new WorldBuilder()
            .SetupWorld()
                .SetCurrentTown(TOWN1)
            .SetupHero()
            .AddTown(TOWN1, "Деревня дальняя", "Унылая деревенька на краю обжитых земель")
            .AddTown(TOWN2, "Речной поселок", "Поселок на берегу реки быстрой")
            .AddRoad(TOWN1, TOWN2, cost: 5, days: 3, twoway: true)
                .AddTrash    (15, "Лесная опушка",      "Обычная лесная опушка. И вдоль леса - дорога.")
                .AddTrash    (15, "Дорога",             "Дорога тянется по равнине от горизонта до горизонта.")
                .AddTreasure ( 1, "Придорожный камень", "У дороги лежит здоровенный камень. Который, похоже, недавно двигали.", "Под камнем вы нашли {0} золотых!", 2, 3)
                .AddTreasure ( 2, "Дорога",             "Обычная пыльная дорога", "Прямо в пыли вы нашли золотой!", 1, 1)
                .AddTreasure ( 1, "Дорожная стоянка",   "Похоже, это удобное место для стоянки.", "Кто-то выронил тут кошелек с {0} золотыми!", 5, 10)
                .AddEnemy    (10, "Лесная чаща",        "Похоже, вы забрели куда-то не туда. В такой чаще легко встретить диких лесных животных.")
            .Build();
}
