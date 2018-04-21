
		using System;
		using System.Collections.Generic;
		using System.Linq;
		using System.Text;
		
namespace GLOBAL
{

	namespace RPG
	{

				public class MetaData
		{
			protected MetaData()
			{
				
			}
			public string note;
			public Meta_0_ meta;

						public class Meta_0_
			{
				
				public object this[string index]
				{
					get
					{
						return (object)((dynamic)this)[index];
					}				
					set
					{
						((dynamic)this)[index] = value;
					}
				}
				
			}
		}

				public class Map : MetaData
		{
			protected Map() : base()
			{
				
			}
			public string displayName;
			public float tilesetId;
			public float width;
			public float height;
			public float scrollType;
			public bool specifyBattleback;
			public string battleback1Name;
			public string battleback2_name;
			public bool autoplayBgm;
			public AudioFile bgm;
			public bool autoplayBgs;
			public AudioFile bgs;
			public bool disableDashing;
			public Map.Encounter[] encounterList;
			public float encounterStep;
			public string parallaxName;
			public bool parallaxLoopX;
			public bool parallaxLoopY;
			public float parallaxSx;
			public float parallaxSy;
			public bool parallaxShow;
			public float[] data;
			public Event[] events;
		}

				public class MapInfo
		{
			protected MapInfo()
			{
				
			}
			public string name;
			public float parentId;
			public float order;
		}

				public class Event : MetaData
		{
			protected Event() : base()
			{
				
			}
			public float id;
			public string name;
			public float x;
			public float y;
			public EventPage[] pages;
		}

				public class EventPage
		{
			protected EventPage()
			{
				
			}
			public EventPage.Conditions conditions;
			public EventPage.Image image;
			public float moveType;
			public float moveSpeed;
			public float moveFrequency;
			public MoveRoute[] moveRoute;
			public bool walkAnime;
			public bool stepAnime;
			public bool directionFix;
			public bool through;
			public float priorityType;
			public float trigger;
			public EventCommand[] list;
		}

				public class BattleEventPage
		{
			protected BattleEventPage()
			{
				
			}
			public BattleEventPage.Conditions conditions;
			public EventCommand[] list;
			public float span;
		}

				public class EventCommand
		{
			protected EventCommand()
			{
				
			}
			public float code;
			public float indent;
			public object[] parameters;
		}

				public class MoveRoute
		{
			protected MoveRoute()
			{
				
			}
			public bool repeat;
			public bool skippable;
			public bool wait;
			public MoveCommand[] list;
		}

				public class MoveCommand
		{
			protected MoveCommand()
			{
				
			}
			public float code;
			public object[] parameters;
		}

				public class Actor : MetaData
		{
			protected Actor() : base()
			{
				
			}
			public float id;
			public string name;
			public string nickname;
			public float classId;
			public float initialLevel;
			public float maxLevel;
			public string characterName;
			public float characterIndex;
			public string faceName;
			public float faceIndex;
			public string battlerName;
			public float[] equips;
			public string profile;
			public Trait[] traits;
		}

				public class Class : MetaData
		{
			protected Class() : base()
			{
				
			}
			public float id;
			public string name;
			public float[] expParams;
						public float[][] @params;
			public Class.Learning[] learnings;
			public Trait[] traits;
		}

				public class BaseItem : MetaData
		{
			protected BaseItem() : base()
			{
				
			}
			public float id;
			public string name;
			public float iconIndex;
			public string description;
		}

				public class UsableItem : BaseItem
		{
			protected UsableItem() : base()
			{
				
			}
			public float scope;
			public float occasion;
			public float speed;
			public float successRate;
			public float repeats;
			public float tpGain;
			public float hitType;
			public float animationId;
			public Damage damage;
			public Effect[] effects;
		}

				public class Skill : UsableItem
		{
			protected Skill() : base()
			{
				
			}
			public float stypeId;
			public float mpCost;
			public float tpCost;
			public string message1;
			public string message2;
			public float requiredWtypeId1;
			public float requiredWtypeId2;
		}

				public class Item : UsableItem
		{
			protected Item() : base()
			{
				
			}
			public float itypeId;
			public float price;
			public bool consumable;
		}

				public class EquipItem : BaseItem
		{
			protected EquipItem() : base()
			{
				
			}
			public float price;
			public float etypeId;
						public float[] @params;
			public Trait[] traits;
		}

				public class Weapon : EquipItem
		{
			protected Weapon() : base()
			{
				
			}
			public float wtypeId;
			public float animationId;
		}

				public class Armor : EquipItem
		{
			protected Armor() : base()
			{
				
			}
			public float atypeId;
		}

				public class Enemy : MetaData
		{
			protected Enemy() : base()
			{
				
			}
			public string battlerName;
			public float battlerHue;
						public float[] @params;
			public float exp;
			public float gold;
			public Enemy.DropItem[] dropItems;
			public Enemy.Action[] actions;
		}

				public class State : MetaData
		{
			protected State() : base()
			{
				
			}
			public float id;
			public string name;
			public float restriction;
			public float priority;
			public bool removeAtBattleEnd;
			public bool removeByRestriction;
			public float autoRemovalTiming;
			public float minTurns;
			public float maxTurns;
			public bool removeByDamage;
			public float chanceByDamage;
			public bool removeByWalking;
			public float stepToRemove;
			public float iconIndex;
			public string message1;
			public string message2;
			public string message3;
			public string message4;
			public float motion;
			public float overlay;
			public Trait[] traits;
			public bool releaseByDamage;
			public string description;
		}

				public class Trait
		{
			protected Trait()
			{
				
			}
			public float code;
			public float dataId;
			public float value;
			public bool expanded;
			public float scrollX;
			public float scrollY;
		}

				public class Damage
		{
			protected Damage()
			{
				
			}
			public float type;
			public float elementId;
			public string formula;
			public float variance;
			public bool critical;
		}

				public class Effect
		{
			protected Effect()
			{
				
			}
			public float code;
			public float dataId;
			public float value1;
			public float value2;
		}

				public class Troop
		{
			protected Troop()
			{
				
			}
			public float id;
			public string name;
			public RPG.Troop.Member[] members;
			public RPG.Troop.Page[] pages;
		}

				public class Animation
		{
			protected Animation()
			{
				
			}
			public float id;
			public string name;
			public string animation1Name;
			public float animation1Hue;
			public string animation2Name;
			public float animation2Hue;
			public float position;
			public float frameMax;
			public float[][][] frames;
			public Animation.Timing[] timings;
		}

				public class Tileset : MetaData
		{
			protected Tileset() : base()
			{
				
			}
			public float id;
			public string name;
			public float mode;
			public string[] tilesetNames;
			public float[] flags;
		}

				public class CommonEvent
		{
			protected CommonEvent()
			{
				
			}
			public float id;
			public string name;
			public float trigger;
			public float switchId;
			public EventCommand[] list;
		}

				public class System
		{
			protected System()
			{
				
			}
			public string gameTitle;
			public float versionId;
			public string locale;
			public float[] partyMembers;
			public string currencyUnit;
			public float[] windowTone;
			public System.AttackMotion[] attackMotions;
			public string[] elements;
			public string[] equipTypes;
			public string[] skillTypes;
			public string[] weaponTypes;
			public string[] armorTypes;
			public string[] switches;
			public string[] variables;
			public System.Vehicle boat;
			public System.Vehicle ship;
			public System.Vehicle airship;
			public string title1Name;
			public string title2Name;
			public bool optDrawTitle;
			public bool optTransparent;
			public bool optFollowers;
			public bool optSlipDeath;
			public bool optFloorDeath;
			public bool optDisplayTp;
			public bool optExtraExp;
			public bool optSideView;
			public AudioFile titleBgm;
			public AudioFile battleBgm;
			public AudioFile battleEndMe;
			public AudioFile gameoverMe;
			public AudioFile[] sounds;
			public float startMapId;
			public float startX;
			public float startY;
			public System.Terms terms;
			public System.TestBattler[] testBattlers;
			public float testTroopId;
			public string battleback1Name;
			public string battleback2Name;
			public string battlerName;
			public float battlerHue;
			public float editMapId;
		}

				public class AudioFile
		{
			protected AudioFile()
			{
				
			}
			public string name;
			public float pan;
			public float pitch;
			public float volume;
		}

		namespace Map
		{

						public class Encounter
			{
				protected Encounter()
				{
					
				}
				public float troopId;
				public float weight;
				public float[] regionSet;
			}
		}

		namespace EventPage
		{

						public class Conditions
			{
				protected Conditions()
				{
					
				}
				public bool switch1Valid;
				public bool switch2Valid;
				public bool variableValid;
				public bool selfSwitchValid;
				public bool itemValid;
				public bool actorValid;
				public float switch1Id;
				public float switch2Id;
				public float variableId;
				public float variableValue;
				public string selfSwitchCh;
				public float itemId;
				public float actorId;
			}

						public class Image
			{
				protected Image()
				{
					
				}
				public float tileId;
				public string characterName;
				public float characterIndex;
				public float direction;
				public float pattern;
			}
		}

		namespace BattleEventPage
		{

						public class Conditions
			{
				protected Conditions()
				{
					
				}
				public float actorHp;
				public float actorId;
				public bool actorValid;
				public float enemyHp;
				public float enemyIndex;
				public bool enemyValid;
				public float switchId;
				public bool switchValid;
				public float turnA;
				public float turnB;
				public bool turnEnding;
				public bool turnValid;
			}
		}

		namespace Class
		{

						public class Learning : MetaData
			{
				protected Learning() : base()
				{
					
				}
				public float level;
				public float skillId;
			}
		}

		namespace Enemy
		{

						public class DropItem
			{
				protected DropItem()
				{
					
				}
				public float kind;
				public float dataId;
				public float denominator;
			}

						public class Action
			{
				protected Action()
				{
					
				}
				public float skillId;
				public float conditionType;
				public float conditionParam1;
				public float conditionParam2;
				public float rating;
			}
		}

		namespace Troop
		{

						public class Member
			{
				protected Member()
				{
					
				}
				public float enemyId;
				public float x;
				public float y;
				public bool hidden;
			}

						public class Page
			{
				protected Page()
				{
					
				}
				public Page.Condition condition;
				public float span;
				public EventCommand[] list;
			}

			namespace Page
			{

								public class Condition
				{
					protected Condition()
					{
						
					}
					public bool turnEnding;
					public bool turnValid;
					public bool enemyValid;
					public bool actorValid;
					public bool switchValid;
					public float turnA;
					public float turnB;
					public float enemyIndex;
					public float enemyHp;
					public float actorId;
					public float actorHp;
					public float switchId;
				}
			}
		}

		namespace Animation
		{

						public class Timing
			{
				protected Timing()
				{
					
				}
				public float frame;
				public AudioFile se;
				public float flashScope;
				public float[] flashColor;
				public float flashDuration;
			}
		}

		namespace System
		{

						public class Vehicle
			{
				protected Vehicle()
				{
					
				}
				public string characterName;
				public float characterIndex;
				public AudioFile bgm;
				public float startMapId;
				public float startX;
				public float startY;
			}

						public class Terms
			{
				protected Terms()
				{
					
				}
				public string[] basic;
								public string[] @params;
				public string[] commands;
				public Messages_0_ messages;

								public class Messages_0_
				{
					
					public string this[string index]
					{
						get
						{
							return (string)((dynamic)this)[index];
						}				
						set
						{
							((dynamic)this)[index] = value;
						}
					}
					
				}
			}

						public class TestBattler
			{
				protected TestBattler()
				{
					
				}
				public float actorId;
				public float level;
				public float[] equips;
			}

						public class AttackMotion
			{
				protected AttackMotion()
				{
					
				}
				public float type;
				public float weaponImageId;
			}
		}
	}
}
