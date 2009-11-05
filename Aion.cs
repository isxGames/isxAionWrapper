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
 
		/// <summary>
		/// If no optional parameters are used, then the given List is filled with an array 
		/// of entities visible to the client at the point of creation (sorted by distance.) 
		/// The optional parameters can be anything typically used with the entity search 
		/// routines (including 'sorting' parameters).
		/// </summary>
		public List<Entity> GetEntities(params string[] Args)
		{
			return Util.GetListFromMember<Entity>(this, "GetEntities", "entity", Args);
		}
        #endregion

		#region Methods   
        #endregion
    }
}
