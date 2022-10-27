using ARL.Core.Models;
using ARL.Core.Models.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARL.Con.Builder;

public class RoadEnemyBuilder : RoadBuilder
{
    RoadEnemy _enemy;

    public RoadEnemyBuilder(World world, Road road, RoadEnemy enemy): base(world, road)
    {
        _enemy = enemy;
    }

    public RoadEnemyBuilder SetHP(int hp)
    {
        _enemy.HP = hp;
        return this;
    }

    public RoadEnemyBuilder SetTreasure(int start, int size)
    {
        _enemy.Treasure = new Drop() { Start = start, Interval = size };
        return this;
    }

    public RoadEnemyBuilder SetAttack(int attack, Dice damage)
    {
        _enemy.Attack = attack;
        _enemy.Damage = damage;
        return this;
    }

    public RoadEnemyBuilder SetDeffence(int defence, int protection)
    {
        _enemy.Defence = defence;
        _enemy.Protection = protection;
        return this;
    }
}
