using System;
using System.Collections.Generic;
using System.Text;
using InnerSpaceAPI;
using LavishScriptAPI;

namespace Aion.isxAion
{
    public class ISXAion : LavishScriptObject
	{
		#region Constructors
        public ISXAion(LavishScriptObject Obj)
			: base(Obj)
		{
		}

		public ISXAion()
            : base(LavishScript.Objects.GetObject("ISXAion"))
		{
		}
		#endregion

		#region Members
		public string Version
		{
			get
			{
				return GetMember<string>("Version");
			}
		}

		/// <summary>
		/// Note: All scripts should check to make sure that this is true before running.
		/// </summary>
		public bool IsReady
		{
			get
			{
				return GetMember<bool>("IsReady");
			}
		}

		/// <summary>
		/// Returns true if the extension is currently in the authentication/patching phase of loading
		/// </summary>
		public bool IsLoading
		{
			get
			{
				return GetMember<bool>("IsLoading");
			}
		}

        public int NumRadars
        {
            get
            {
                return GetMember<int>("NumRadars");
            }
        }

		#endregion

		#region Methods
        /// <summary>
        ///***
        ///*** When isxAion is first executed, it extracts several data files from the Aion client and creates an SQLite database file.  These files
        ///*** are located in /innerspace/Extensions/isxAion/ClientData.  The first method above, "RefreshDataFiles", will delete the xml files and
        ///*** retrieve new copies from the installed Aion client.  The second method will delete the SQLite Database and recreate it.
        ///***
        ///*** These two methods are typically used in unison either when there have been changes made to the Aion client (at which point BOTH
        ///*** methods should be used), or when changes have been made to isxAion and users are instructed to "rebuild the isxAion database" (at which
        ///*** point only "RebuildDB" needs to be issued.)  
        ///***
        ///*** Both methods are safe to use at any point; however, users are encouraged to "RefreshDataFiles" before "RebuildDB" unless they're sure 
        ///*** that the current xml files are up-to-date.
        ///***
        /// </summary>
        public bool RefreshDataFiles()
        {
            return ExecuteMethod("RefreshDataFiles");
        }
        /// <summary>
        ///***
        ///*** When isxAion is first executed, it extracts several data files from the Aion client and creates an SQLite database file.  These files
        ///*** are located in /innerspace/Extensions/isxAion/ClientData.  The first method above, "RefreshDataFiles", will delete the xml files and
        ///*** retrieve new copies from the installed Aion client.  The second method will delete the SQLite Database and recreate it.
        ///***
        ///*** These two methods are typically used in unison either when there have been changes made to the Aion client (at which point BOTH
        ///*** methods should be used), or when changes have been made to isxAion and users are instructed to "rebuild the isxAion database" (at which
        ///*** point only "RebuildDB" needs to be issued.)  
        ///***
        ///*** Both methods are safe to use at any point; however, users are encouraged to "RefreshDataFiles" before "RebuildDB" unless they're sure 
        ///*** that the current xml files are up-to-date.
        ///***
        /// </summary>
        public bool RebuildDB()
        {
            return ExecuteMethod("RebuildDB");
        }
		#endregion
	}
}
