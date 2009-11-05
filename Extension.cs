using System;
using System.Text;
using System.Runtime.InteropServices;
using InnerSpaceAPI;
using LavishScriptAPI;
using LavishVMAPI;

namespace Aion.isxAion
{
	public class Extension
	{
		public Extension()
		{
		}

		public Aion Aion()
		{
			return new Aion();
		}

		public Character Me
		{
			get
			{
				return new Me();
			}
		}

		public Entity Entity(int ID)
		{
			return new Entity(ID);
		}

		public Entity Entity(params string[] Args)
		{
			return new Entity(Args);
		}

		public isxAion isxAion
		{
			get
			{
				return new isxAion();
			}
		}
	}
}