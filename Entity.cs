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
		#endregion

		#region Methods
		#endregion
	}
}
