using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Aion.isxAion
{
    public class Character : LavishScriptObject
	{
		#region Constructors
        public Character(LavishScriptObject Obj)
			: base(Obj)
		{
		}

		public Character()
            : base(LavishScript.Objects.GetObject("Me"))
		{
		}
		#endregion

		#region Members
        #region isxAion-1.5.1.4.0194
        /// <summary>
        /// Seconds remaining on the current spell/ability cast
        /// </summary>
        public float CastTimeRemaining
        {
            get
            {
                return GetMember<float>("CastTimeRemaining");
            }
        }

        /// <summary>
        /// Seconds you have been casting the current spell/ability
        /// </summary>
        public float CastTimeSoFar
        {
            get
            {
                return GetMember<float>("CastTimeSoFar");
            }
        }
        #endregion
        #region isxAion-1.5.1.4.0074
        public int HP
        {
            get
            {
                return GetMember<int>("HP");
            }
        }

        public int MaxHP
        {
            get
            {
                return GetMember<int>("MaxHP");
            }
        }

        public int MP
        {
            get
            {
                return GetMember<int>("MP");
            }
        }

        public int MaxMP
        {
            get
            {
                return GetMember<int>("MaxMP");
            }
        }

        public int DP
        {
            get
            {
                return GetMember<int>("DP");
            }
        }

        public int MaxDP
        {
            get
            {
                return GetMember<int>("MaxDP");
            }
        }

        public int XP
        {
            get
            {
                return GetMember<int>("XP");
            }
        }
        /// <summary>
        /// XP to next level would be Me.MaxXP-Me.XP
        /// </summary>
        public int MaxXP
        {
            get
            {
                return GetMember<int>("MaxXP");
            }
        }

        /// <summary>
        /// in seconds
        /// </summary>
        public float FlightTime
        {
            get
            {
                return GetMember<float>("FlightTime");
            }
        }

        /// <summary>
        /// in seconds
        /// </summary>
        public float MaxFlightTime
        {
            get
            {
                return GetMember<float>("MaxFlightTime");
            }
        }

        public int Level
        {
            get
            {
                return GetMember<int>("Level");
            }
        }

        public int Kinah
        {
            get
            {
                return GetMember<int>("Kinah");
            }
        }

        public int OpenCubeSlots
        {
            get
            {
                return GetMember<int>("OpenCubeSlots");
            }
        }

        public int UsedCubeSlots
        {
            get
            {
                return GetMember<int>("UsedCubeSlots");
            }
        }

        public int MaxCubeSlots
        {
            get
            {
                return GetMember<int>("MaxCubeSlots");
            }
        }

        public bool IsCasting
        {
            get
            {
                return GetMember<bool>("IsCasting");
            }
        }
        #endregion

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
        #region isxAion-1.5.1.4.0236
        public bool ToggleResting()
        {
            return ExecuteMethod("ToggleResting");
        }

        public bool ToggleCombat()
        {
            return ExecuteMethod("ToggleCombat");
        }

        public bool ChangeWeapon()
        {
            return ExecuteMethod("ChangeWeapon");
        }
        #endregion
        #region isxAion-1.5.1.4.0116
        public bool ClearTarget()
        {
            return ExecuteMethod("ClearTarget");
        }

        /// <summary>
        /// Start Riseing. Or use Rise("tap") to just tap the Raise key
        /// </summary>
        public bool Rise(string tap)
        {
            if (tap == "tap")
                return ExecuteMethod("Rise", "tap");

            return ExecuteMethod("Rise");
        }

        /// <summary>
        /// Start Falling. Or use Fall("tap") to just tap the Fall key
        /// </summary>
        public bool Fall(string tap)
        {
            if (tap == "tap")
                return ExecuteMethod("Fall", "tap");

            return ExecuteMethod("Fall");
        }

        /// <summary>
        /// Move(direction) Continuous Movement in that direction
        /// Move(direction,"tap") one single tap of the "movement key"
        /// 'direction' can be:  Forward, Backward, Left, Right, LeftForward, RightForward, LeftBackward, RightBackward
        /// </summary>
        public bool Move(string direction, string tap)
        {
            if (tap == "tap")
                return ExecuteMethod("Move", direction, "tap");

            return ExecuteMethod("Move", direction);
        }

        /// <summary>
        /// Stop all movement
        /// </summary>
        /// <returns></returns>
        public bool StopMoving()
        {
            return ExecuteMethod("StopMoving");
        }

        /// <summary>
        /// Spread wings and take flight
        /// </summary>
        public bool TakeOff()
        {
            return ExecuteMethod("TakeOff");
        }

        /// <summary>
        /// Stop flying/Put your wings away
        /// </summary>
        public bool Land()
        {
            return ExecuteMethod("Land");
        }
        #endregion
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
