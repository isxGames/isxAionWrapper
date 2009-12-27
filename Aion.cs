using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Aion.isxAion
{
    public class Aion : LavishScriptPersistentObject
	{
		#region Constructors
        public Aion(LavishScriptPersistentObject Obj)
			: base(Obj)
		{
		}

		public Aion()
            : base(LavishScript.Objects.GetPersistentObject("Aion"))
		{
		}
		#endregion

		#region Members
        public bool BlockingAntiAFK
        {
            get
            {
                return GetMember<bool>("BlockingAntiAFK");
            }
        }
        /// <summary>
        /// The heading from you to (ToX,ToY,...)
        /// </summary>
        public float HeadingTo(float ToX, float ToY)
        {
            return GetMember<float>("HeadingTo",ToX.ToString(),ToY.ToString());
        }
        /// <summary>
        /// The heading from you to (ToX,ToY,...)
        /// </summary>
        public float Bearing(float ToX, float ToY)
        {
            return GetMember<float>("Bearing", ToX.ToString(), ToY.ToString());
        }
        /// <summary>
        /// The heading from (FromX,FromY,...) to (ToX,ToY,...)
        /// </summary>
        public float HeadingTo(float FromX, float FromY, float ToX, float ToY)
        {
            return GetMember<float>("HeadingTo", FromX.ToString(), FromY.ToString(), ToX.ToString(), ToY.ToString());
        }
        /// <summary>
        /// The heading from (FromX,FromY,...) to (ToX,ToY,...)
        /// </summary>
        public float Bearing(float FromX, float FromY, float ToX, float ToY)
        {
            return GetMember<float>("Bearing", FromX.ToString(), FromY.ToString(), ToX.ToString(), ToY.ToString());
        }
        #endregion

		#region Methods 
        /// <summary>
        /// *TOGGLE*  This setting is persistant.
        /// </summary>
        public bool BlockAntiAFK()
        {
            return ExecuteMethod("BlockAntiAFK");
        }
        /// <summary>
        /// If no optional parameters are used, then the given List is filled with an array 
        /// of entities visible to the client at the point of creation (sorted by distance.) 
        /// The optional parameters can be anything typically used with the entity search 
        /// routines (including 'sorting' parameters).
        /// </summary>
        public List<Entity> GetEntities(params string[] Args)
        {
            return Util.GetListFromMethod<Entity>(this, "GetEntities", "entity", Args);
        }
        #endregion
    }
}
