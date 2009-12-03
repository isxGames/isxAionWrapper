using System;
using LavishScriptAPI;

namespace Aion.isxAion
{

    #region Input Related
    public class IncomingTextEventArgs : LSEventArgs
    {
        /// <summary>
        /// Aion_onIncomingChatText(int Type, string From, string Channel, string Text)
        /// </summary>
        /// <param name="args"></param>
        internal IncomingTextEventArgs(params string[] args) : base(args) { }

        public int Type { get { return Convert.ToInt32(Args[0]); } }
        public string From { get { return Args[1]; } }
        public string Channel { get { return Args[2]; } }
        public string Text { get { return Args[3]; } }
    }
    #endregion

    #region Abilites/Spell Casting
    public class CastAbilityEventArgs : LSEventArgs
    {
        /// <summary>
        /// Aion_onCastAbility(float TotalCastTime)
        /// </summary>
        /// <param name="args"></param>
        internal CastAbilityEventArgs(params string[] args) : base(args) { }

        public float TotalCastTime { get { return float.Parse(Args[0]); } }
    }
    #endregion

    #region Entity Related
    public class EntitySpawnedEventArgs : LSEventArgs
    {
        /// <summary>
        /// Aion_OnEntitySpawned(int ID, string Name, int Level, string Type)
        /// </summary>
        /// <param name="args"></param>
        internal EntitySpawnedEventArgs(params string[] args) : base(args) { }

        public int ID { get { return Convert.ToInt32(Args[0]); } }
        public string Name { get { return Args[1]; } }
        public int Level { get { return Convert.ToInt32(Args[2]); } }
        public string Type { get { return Args[3]; } }
    }
    public class EntityDespawnedEventArgs : LSEventArgs
    {
        /// <summary>
        /// Aion_onEntityDespawned(int ID)
        /// </summary>
        /// <param name="args"></param>
        internal EntityDespawnedEventArgs(params string[] args) : base(args) { }

        public int ID { get { return Convert.ToInt32(Args[0]); } }
    }
    #endregion
}