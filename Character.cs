using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Aion.isxAion
{
    public class Character : LavishScriptPersistentObject
	{
		#region Constructors
        public Character(LavishScriptPersistentObject Obj)
			: base(Obj)
		{
		}

		public Character()
            : base(LavishScript.Objects.GetPersistentObject("Me"))
		{
		}
		#endregion

		#region Members
        public Entity ToEntity
		{
			get
			{
				return new Entity(GetMember("ToEntity"));
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

	public class Me : Character
	{
		public Me()
			: base()
		{
		}
	}
}
