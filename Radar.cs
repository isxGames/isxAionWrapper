using System;
using System.Collections.Generic;
using System.Text;
using InnerSpaceAPI;
using LavishScriptAPI;

namespace Aion.isxAion
{
    public class Radar : LavishScriptObject
    {
        #region Constructors
        public Radar(LavishScriptObject obj) :
            base(obj)
        {
        }

        /// <summary>
        /// by index where # is between 1 and Aion.NumRadars
        /// </summary>
        /// <param name="index"></param>
        public Radar(int index) :
            base(LavishScript.Objects.GetObject("Radar", index.ToString()))
        {
        }

        /// <summary>
        /// by Radar Name
        /// </summary>
        /// <param name="name"></param>
        public Radar(string name) :
            base(LavishScript.Objects.GetObject("Radar", name))
        {
        }
        #endregion

        #region Members
        #region isxAion-1.5.1.4.0074
        /// <summary>
        /// Red dots show AgroNPCs on the radar
        /// </summary>
        public bool ShowingAggroNPCs
        {
            get
            {
                return GetMember<bool>("ShowingAggroNPCs");
            }
        }
        #endregion
        public bool ShowingMe
        {
            get
            {
                return GetMember<bool>("ShowingMe");
            }
        }

        public bool ShowingNPCs
        {
            get
            {
                return GetMember<bool>("ShowingNPCs");
            }
        }

        public bool ShowingPCs
        {
            get
            {
                return GetMember<bool>("ShowingPCs");
            }
        }

        public bool ShowingSpecials
        {
            get
            {
                return GetMember<bool>("ShowingSpecials");
            }
        }

        public bool ShowingResources
        {
            get
            {
                return GetMember<bool>("ShowingResources");
            }
        }

        public bool ShowingBirds
        {
            get
            {
                return GetMember<bool>("ShowingBirds");
            }
        }

        public bool ShowingChairs
        {
            get
            {
                return GetMember<bool>("ShowingChairs");
            }
        }

        public bool ShowingSoundSpots
        {
            get
            {
                return GetMember<bool>("ShowingSoundSpots");
            }
        }

        public bool ShowingObjects
        {
            get
            {
                return GetMember<bool>("ShowingObjects");
            }
        }

        public bool ShowingMilestones
        {
            get
            {
                return GetMember<bool>("ShowingMilestones");
            }
        }

        public bool ShowingRandomAmbientSounds
        {
            get
            {
                return GetMember<bool>("ShowingRandomAmbientSounds");
            }
        }

        public bool ShowingBugs
        {
            get
            {
                return GetMember<bool>("ShowingBugs");
            }
        }

        public bool ShowingPortals
        {
            get
            {
                return GetMember<bool>("ShowingPortals");
            }
        }

        public bool ShowingFish
        {
            get
            {
                return GetMember<bool>("ShowingFish");
            }
        }

        public bool ShowingUnknowns
        {
            get
            {
                return GetMember<bool>("ShowingUnknowns");
            }
        }

        public int NumCustomFilters
        {
            get
            {
                return GetMember<int>("NumCustomFilters");
            }
        }

        public string CustomFilter(int index)
        {
            return GetMember<string>("CustomFilter", index.ToString());
        }

        public bool CustomFilter(string name)
        {
            return GetMember<bool>("CustomFilter", name);
        }

        public int Size
        {
            get
            {
                return GetMember<int>("Size");
            }
        }

        public bool ShowingLabels
        {
            get
            {
                return GetMember<bool>("ShowingLabels");
            }
        }

        public bool ZAxisClippingOn
        {
            get
            {
                return GetMember<bool>("ZAxisClippingOn");
            }
        }

        public bool ClipRadiusOn
        {
            get
            {
                return GetMember<bool>("ClipRadiusOn");
            }
        }

        public bool ClippingTextOn
        {
            get
            {
                return GetMember<bool>("ClippingTextOn");
            }
        }

        public bool RotationOn
        {
            get
            {
                return GetMember<bool>("RotationOn");
            }
        }

        public string Name
        {
            get
            {
                return GetMember<string>("Name");
            }
        }
        #endregion

        #region Methods
        #region isxAion-1.5.1.4.0074
        public bool FilterAggroNPCs()
        {
            return ExecuteMethod("FilterAggroNPCs");
        }
        #endregion

        public bool FilterMe()
        {
            return ExecuteMethod("FilterMe");
        }

        public bool FilterNPCs()
        {
            return ExecuteMethod("FilterNPCs");
        }

        public bool FilterPCs()
        {
            return ExecuteMethod("FilterPCs");
        }

        public bool FilterSpecials()
        {
            return ExecuteMethod("FilterSpecials");
        }

        public bool FilterResources()
        {
            return ExecuteMethod("FilterResources");
        }

        public bool FilterBirds()
        {
            return ExecuteMethod("FilterBirds");
        }

        public bool FilterChairs()
        {
            return ExecuteMethod("FilterChairs");
        }

        public bool FilterSoundSpots()
        {
            return ExecuteMethod("FilterSoundSpots");
        }

        public bool FilterObjects()
        {
            return ExecuteMethod("FilterObjects");
        }

        public bool FilterMilestones()
        {
            return ExecuteMethod("FilterMilestones");
        }

        public bool FilterRandomAmbientSounds()
        {
            return ExecuteMethod("FilterRandomAmbientSounds");
        }

        public bool FilterBugs()
        {
            return ExecuteMethod("FilterBugs");
        }

        public bool FilterPortals()
        {
            return ExecuteMethod("FilterPortals");
        }

        public bool FilterFish()
        {
            return ExecuteMethod("FilterFish");
        }

        public bool FilterUnknowns()
        {
            return ExecuteMethod("FilterUnknowns");
        }

        public bool SetSize(int size)
        {
            return ExecuteMethod("SetSize", size.ToString());
        }

        public bool ShowLabels()
        {
            return ExecuteMethod("ShowLabels");
        }

        public bool ZAxisClipping()
        {
            return ExecuteMethod("ZAxisClipping");
        }

        public bool ClipText()
        {
            return ExecuteMethod("ClipText");
        }

        public bool ClipRadius()
        {
            return ExecuteMethod("ClipRadius");
        }

        public bool Rotation()
        {
            return ExecuteMethod("Rotation");
        }

        public bool SetCustomFilter(string filter)
        {
            return ExecuteMethod("SetCustomFilter", filter);
        }

        /// <summary>
        /// Min Size: 3
        /// </summary>
        /// <param name="distance"></param>
        /// <returns></returns>
        public bool ZoomIn(int distance)
        {
            return ExecuteMethod("ZoomIn", distance.ToString());
        }

        /// <summary>
        /// Max Size: 1000
        /// </summary>
        /// <param name="distance"></param>
        /// <returns></returns>
        public bool ZoomOut(int distance)
        {
            return ExecuteMethod("ZoomOut", distance.ToString());
        }
        #endregion
    }
}
