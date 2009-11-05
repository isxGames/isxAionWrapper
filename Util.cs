using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using LavishScriptAPI;
using LavishScriptAPI.Interfaces;
using InnerSpaceAPI;

namespace Aion.isxAion
{
	internal class Util
	{
		private static T[] PrefixArray<T>(T First, T[] Rest)
		{
			T[] NewArray = new T[Rest.Length + 1];

			NewArray[0] = First;

			for (int i = 0; i < Rest.Length; i++)
				NewArray[i + 1] = Rest[i];

			return NewArray;
		}

		private static List<T> IndexToLavishScriptObjectList<T>(LavishScriptObject Index)
		{
			List<T> List = new List<T>();
			int Count = Index.GetMember<int>("Used");

			ConstructorInfo constructor = typeof(T).GetConstructor(new Type[] { typeof(LavishScriptObject) });

			for (int i = 1; i <= Count; i++)
				List.Add((T)constructor.Invoke(new object[] { Index.GetIndex(i.ToString()) }));

			return List;
		}

		private static List<T> IndexToStructList<T>(LavishScriptObject Index)
		{
			List<T> List = new List<T>();
			int Count = Index.GetMember<int>("Used");

			for (int i = 1; i <= Count; i++)
				List.Add(Index.GetIndex<T>(i.ToString()));

			return List;
		}

		private static List<T> IndexToList<T>(LavishScriptObject Index)
		{
			if (typeof(T).IsSubclassOf(typeof(LavishScriptObject)))
				return IndexToLavishScriptObjectList<T>(Index);
			else
				return IndexToStructList<T>(Index);
		}

		private static T IndexToLavishScriptObject<T>(LavishScriptObject Index, int number)
		{
			ConstructorInfo constructor = typeof(T).GetConstructor(new Type[] { typeof(LavishScriptObject) });

			return (T)constructor.Invoke(new object[] { Index.GetIndex(number.ToString()) });
		}

		public static T GetIndexMember<T>(LavishScriptObject Index, int number)
		{
			if (typeof(T).IsSubclassOf(typeof(LavishScriptObject)))
				return (T)typeof(T).GetConstructor(new Type[] { typeof(LavishScriptObject) }).Invoke(new object[] { Index.GetIndex(number.ToString()) });
			else
				return Index.GetIndex<T>(number.ToString());
		}

		internal static List<T> GetListFromMethod<T>(ILSObject Obj, string MethodName, string LSTypeName, params string[] Args)
		{
			if (Obj == null || !Obj.IsValid)
				return null;

			LavishScriptObject Index = LavishScript.Objects.NewObject("index:" + LSTypeName);

			string[] allargs = PrefixArray<string>(Index.LSReference, Args);

			Obj.ExecuteMethod(MethodName, allargs);

			LavishScriptObject used = Index.GetMember("Used");

			if (LavishScriptObject.IsNullOrInvalid(used))
				return null;

			return IndexToList<T>(Index);
		}

		internal static T GetFromIndexMethod<T>(ILSObject Obj, string MethodName, string LSTypeName, int number, params string[] Args)
		{
			// argument is 0-based
			number += 1;

			if (Obj == null || !Obj.IsValid || number <= 0)
				return default(T);

			LavishScriptObject Index = LavishScript.Objects.NewObject("index:" + LSTypeName);

			string[] allargs = PrefixArray<string>(Index.LSReference, Args);

			Obj.ExecuteMethod(MethodName, allargs);

			LavishScriptObject used = Index.GetMember("Used");

			// if it failed or we want one off the end, return
			if (LavishScriptObject.IsNullOrInvalid(used) || used.GetValue<int>() < number)
				return default(T);

			return GetIndexMember<T>(Index, number);
		}

		internal static List<T> GetListFromMember<T>(ILSObject Obj, string MemberName, string LSTypeName, params string[] Args)
		{
			if (Obj == null || !Obj.IsValid)
				return null;

			LavishScriptObject Index = LavishScript.Objects.NewObject("index:" + LSTypeName);

			string[] allargs = PrefixArray<string>(Index.LSReference, Args);

			LavishScriptObject retval = Obj.GetMember(MemberName, allargs);

			if (LavishScriptObject.IsNullOrInvalid(retval))
				return null;

			return IndexToList<T>(Index);
		}

		internal static T GetFromIndexMember<T>(ILSObject Obj, string MemberName, string LSTypeName, int number, params string[] Args)
		{
			// argument is 0-based
			number += 1;

			if (Obj == null || !Obj.IsValid)
				return default(T);

			LavishScriptObject Index = LavishScript.Objects.NewObject("index:" + LSTypeName);

			string[] allargs = PrefixArray<string>(Index.LSReference, Args);

			LavishScriptObject retval = Obj.GetMember(MemberName, allargs);

			if (LavishScriptObject.IsNullOrInvalid(retval) || retval.GetValue<int>() < number)
				return default(T);

			return GetIndexMember<T>(Index, number);
		}
	}
}
