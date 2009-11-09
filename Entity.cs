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
		#endregion
	}
}
