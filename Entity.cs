using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Aion.isxAion
{
    public class Entity : LavishScriptObject
    {
        #region Constructors
        public Entity(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public Entity(int ID)
            : base(LavishScript.Objects.GetObject("Entity", ID.ToString()))
        {
        }

        public Entity(string name)
            : base(LavishScript.Objects.GetObject("Entity", name))
        {
        }

        public Entity(params string[] Args)
            : base(LavishScript.Objects.GetObject("Entity", Args))
        {
        }
        #endregion


        #region Members
        #region isxAion-1.5.1.4.0137
        /// <summary>
        /// Used primarily to indicate PCs on your faction 
        /// </summary>
        public bool IsFriendly
        {
            get
            {
                return GetMember<bool>("IsFriendly");
            }
        }

        public bool InCombat
        {
            get
            {
                return GetMember<bool>("InCombat");
            }
        }

        public bool IsResting
        {
            get
            {
                return GetMember<bool>("IsResting");
            }
        }

        /// <summary>
        /// This primarily refers to PC flying
        /// </summary>
        public bool IsFlying
        {
            get
            {
                return GetMember<bool>("IsFlying");
            }
        }

        /// <summary>
        /// The single blue/yellow arrow indicating new quest available
        /// </summary>
        public bool OffersNewQuest
        {
            get
            {
                return GetMember<bool>("OffersNewQuest");
            }
        }

        /// <summary>
        /// Quest icon is visible, but greyed out
        /// </summary>
        public bool OffersNewQuestNextLevel
        {
            get
            {
                return GetMember<bool>("OffersNewQuestNextLevel");
            }
        }

        /// <summary>
        /// The double blue/yellow arrow indicating that the quest step is completed
        /// </summary>
        public bool QuestInProgress
        {
            get
            {
                return GetMember<bool>("QuestInProgress");
            }
        }

        /// <summary>
        /// The 'star' blue/yellow icon indicating quest is finished
        /// </summary>
        public bool QuestComplete
        {
            get
            {
                return GetMember<bool>("QuestComplete");
            }
        }

        public string Class
        {
            get
            {
                return GetMember<string>("Class");
            }
        }
        #endregion

        #region isxAion-1.5.1.4.0116
        /// <summary>
        /// 'FALSE' on non-gatherables and gatherables for which your skill is too low 
        /// </summary>
        public bool CanGather
        {
            get
            {
                return GetMember<bool>("CanGather");
            }
        }

        public bool IsCorpse
        {
            get
            {
                return GetMember<bool>("IsCorpse");
            }
        }

        /// <summary>
        ///  i.e., a corpse that is lootable for you
        /// </summary>
        public bool IsLootable
        {
            get
            {
                return GetMember<bool>("IsLootable");
            }
        }

        /// <summary>
        /// Only useful for NPCs
        /// </summary>
        public bool CanChat
        {
            get
            {
                return GetMember<bool>("CanChat");
            }
        }

        /// <summary>
        /// Only useful for NPCs
        /// </summary>
        public bool CanShop
        {
            get
            {
                return GetMember<bool>("CanShop");
            }
        }

        public bool CanAttack
        {
            get
            {
                return GetMember<bool>("CanAttack");
            }
        }

        /// <summary>
        /// i.e., has the "gear" icon for interaction
        /// </summary>
        public bool IsUsable
        {
            get
            {
                return GetMember<bool>("IsUsable");
            }
        }

        #endregion
        #region isxAion-1.5.1.4.0074
        /// <summary>
        /// 
        /// </summary>
        public bool IsAggro
        {
            get
            {
                return GetMember<bool>("IsAggro");
            }
        }
        #endregion

        #region isxAion-1.0.5.11.0601
        /// <summary>
        /// This is a signed integer!  Most NPCs/PCs have negative EntityIDs. All entities have an "EntityID" while only spawns capable of true interaction have an "ID".
        /// </summary>
        public int EntityID
        {
            get
            {
                return GetMember<int>("EntityID");
            }
        }
        #endregion

        public uint ID
        {
            get
            {
                return GetMember<uint>("ID");
            }
        }
        public string Name
        {
            get
            {
                return GetMember<string>("Name");
            }
        }
        /// <summary>
        /// Possible Types (as of 11/2009):  Me, NPC, PC, Resource, Special, Unknown, Chair, Birds, SoundSpot, Random Ambient Sound, Bugs, Portal, Fish, Object, Milestone
        /// </summary>
        public string Type
        {
            get
            {
                return GetMember<string>("Type");
            }
        }
        public float X
        {
            get
            {
                return GetMember<float>("X");
            }
        }
        public float Y
        {
            get
            {
                return GetMember<float>("Y");
            }
        }
        public float Z
        {
            get
            {
                return GetMember<float>("Z");
            }
        }
        public Point3f Location
        {
            get
            {
                return GetMember<Point3f>("Location");
            }
        }
        public float Distance
        {
            get
            {
                return GetMember<float>("Distance");
            }
        }
        public float Radius
        {
            get
            {
                return GetMember<float>("Radius");
            }
        }
        /// <summary>
        /// Please note that for PCs, HP is returned as a percentage.  However, for NPCs and "Me" (the current player), it is returned as actual health points.
        /// </summary>
        public int HP
        {
            get
            {
                return GetMember<int>("HP");
            }
        }
        /// <summary>
        /// Please note that for PCs, MaxHP is returned as a percentage.  However, for NPCs and "Me" (the current player), it is returned as actual health points.
        /// </summary>
        public int MaxHP
        {
            get
            {
                return GetMember<int>("MaxHP");
            }
        }
        public int Level
        {
            get
            {
                return GetMember<int>("Level");
            }
        }
        /// <summary>
        /// The speed at which an entity will travel when moving
        /// </summary>
        public float Speed
        {
            get
            {
                return GetMember<float>("Speed");
            }
        }
        /// <summary>
        /// The distance from which you can travel from the entity and still have access to it via isxAion
        /// </summary>
        public float ValidDistance
        {
            get
            {
                return GetMember<float>("ValidDistance");
            }
        }
        public float Heading
        {
            get
            {
                return GetMember<float>("Heading");
            }
        }
        /// <summary>
        /// The heading from you TO the entity
        /// </summary>
        public float HeadingTo
        {
            get
            {
                return GetMember<float>("HeadingTo");
            }
        }
        /// <summary>
        /// currently only works for PCs
        /// </summary>
        public string Legion
        {
            get
            {
                return GetMember<string>("Legion");
            }
        }
        public Entity Target
        {
            get
            {
                return new Entity(GetMember("Target"));
            }
        }
        #endregion

        #region Methods
        #region isxAion-1.5.1.4.0116
        public bool DoTarget()
        {
            return ExecuteMethod("DoTarget");
        }
        #endregion
        #endregion
    }
}
