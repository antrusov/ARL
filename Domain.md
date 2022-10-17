```mermaid
classDiagram

    direction LR

    %%%%%%%%%%
    %% misc %%
    %%%%%%%%%%

    class Dice {
        +DiceCount : int
        +DiceSize : int
        +Addition : int
        +Next() int
    }

    class Drop {
        +Start : int
        +Interval : int
        +GetValue() int
    }

    class Event {
        +Probability : int
        +Name : string
        +Description : string
    }

    %%%%%%%%%%%
    %% Arena %%
    %%%%%%%%%%%

    class Arena {
        +Enemies : List~ArenaEnemy~
        +CurrentEnemy() ArenaEnemy
    }

    class ArenaEnemy {
        +Revard : int
        +Completed : bool

        +Name : string
        +Description : string

        +HP : int
        +Damage : Dice
        +Attack : int
        +Defence : int
        +Protection : int
    }

    %%%%%%%%%%%%%
    %% Dungeon %%
    %%%%%%%%%%%%%

    class Dungeon {
        +Name : string
        +Description : string

        +BossKilled : bool
        +CurrentLevelId : string
        +Levels : Dictionary~string, Level~
    }

    class Level {
        +Id : string

        +Name : string
        +Description : string

        +Events : List~Event~
        +GetNextEvent() Event
    }

    class LevelEnemy {
        +Kind : EnemyKind
        +Treasure : Drop

        +HP : int
        +Damage : Dice
        +Attack : int
        +Defence : int
        +Protection : int
    }

    class LevelExit {
    }

    class LevelLadder {
        +TargetLevelId : string
    }

    class LevelTrash {
    }

    class LevelTreasure {
        +Treasure : Drop
        +Message : string
    }

    %%%%%%%%%%
    %% hero %%
    %%%%%%%%%%

    class Hero {
        +Money : int
        +Equipment : List~ShopItem~
        +MaxHP : int

        +HP : int
        +Damage : Dice
        +Attack : int
        +Defence : int
        +Protection : int
    }

    %%%%%%%%%%
    %% shop %%
    %%%%%%%%%%

    class Shop {
        +Items : List~ShopItem~
    }

    class ShopItem {
        +Cost : int

        +Name : string
        +Description : string
    }

    class ShopArmor {
        +Defence : int
        +Protection : int
        +Slot : ArmorSlot
    }

    class ShopHeal {
        +Heal : int
    }

    class ShopWeapon {
        +Attack : int
        +Damage : Dice
    }

    %%%%%%%%%%
    %% town %%
    %%%%%%%%%%

    class Town {
        +Id : string

        +Name : string
        +Description : string

        +Arena : Arena
        +Shop : Shop
        +Dungeon : Dungeon
    }

    %%%%%%%%%%%
    %% world %%
    %%%%%%%%%%%

    class World {
        +Hero : Hero
        +FinalBossKilled : bool
        +CurrentTownId : string
        +Towns : Dictionary~string, Town~
        +Roads : Dictionary~string, string~
    }

    class Road {
        +SafeTravelCost : int
        +Days : int
        +Events : List~Event~
    }

    class RoadEnemy {
        +Treasure : Drop

        +HP : int
        +Damage : Dice
        +Attack : int
        +Defence : int
        +Protection : int
    }

    class RoadTrash {        
    }

    class RoadTreasure {
        +Treasure : Drop
        +Message : string
    }

    %%%%%%%%%%%
    %% links %%
    %%%%%%%%%%%

    Event ..|> IEvent
    Event ..|> INameable

    ArenaEnemy ..|> IFighter
    ArenaEnemy ..|> INameable

    Dungeon ..|> INameable
    Level ..|> IWithId~string~
    Level ..|> INameable

    LevelEnemy --|> Event
    LevelEnemy ..|> IFighter
    LevelEnemy ..|> INameable

    LevelExit --|> Event

    LevelLadder --|> Event

    LevelTrash --|> Event

    LevelTreasure --|> Event

    Hero ..|> IFighter

    ShopItem ..|> IProduct
    ShopItem ..|> INameable

    ShopArmor --|> ShopItem
    ShopArmor ..|> IArmor

    ShopHeal --|> ShopItem

    ShopWeapon --|> ShopItem
    ShopWeapon ..|> IWeapon

    Town ..|> INameable
    Town ..|> IWithId~string~

    RoadEnemy --|> Event
    RoadEnemy ..|> IFighter

    RoadTrash --|> Event

    RoadTreasur --|> Event

    %%%%%%%%%%%%%%%%
    %% interfaces %%
    %%%%%%%%%%%%%%%%

    class IWithId~T~ {
        +Id : T
    }

    class IEvent {
        <<interface>>
        +Probability : int
    }

    class IProduct {
        <<interface>>
        +Cost : int
    }

    class INameable {
        <<interface>>
        +Name : string
        +Description : string
    }

    class IWeapon {
        <<interface>>
        +Attack : int
        +Damage : Dice
    }

    class IArmor {
        <<interface>>
        +Defence : int
        +Protection : int
        +Slot : ArmorSlot
    }

    class IFighter {
        <<interface>>
        +HP : int
        +Damage : Dice
        +Attack : int
        +Defence : int
        +Protection : int
    }

    %%%%%%%%%%%
    %% enums %%
    %%%%%%%%%%%

    class ArmorSlot {
        <<enum>>
        Head
        Body
        Sheld
    }

    class EnemyKind {
        <<enum>>
        Common
        DungeonBoss
        FinalBoss
    }

```