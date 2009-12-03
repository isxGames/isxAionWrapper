using System;
using System.Text;

using LavishVMAPI;
using InnerSpaceAPI;
using LavishScriptAPI;


namespace Aion.isxAion
{
	public class Event
	{
		#region .Net Events
        // Events that have no arguments
        public event EventHandler<LSEventArgs> StopCastAbility;

        // All other events
        public event EventHandler<IncomingTextEventArgs> IncomingText;
        public event EventHandler<CastAbilityEventArgs> CastAbility;
        public event EventHandler<EntitySpawnedEventArgs> EntitySpawned;
        public event EventHandler<EntityDespawnedEventArgs> EntityDespawned;
		
        #endregion

		#region .Net Event Raisers
        protected virtual void onIncomingText(object Sender, LSEventArgs e)
        {
            EventHandler<IncomingTextEventArgs> temp = IncomingText;
            if (temp != null)
            {
                temp(Sender, new IncomingTextEventArgs(e.Args));
            }
        }
        protected virtual void onCastAbility(object Sender, LSEventArgs e)
        {
            EventHandler<CastAbilityEventArgs> temp = CastAbility;
            if (temp != null)
            {
                temp(Sender, new CastAbilityEventArgs(e.Args));
            }
        }
        protected virtual void onStopCastAbility(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = StopCastAbility;
            if (temp != null)
            {
                temp(Sender, new LSEventArgs(e.Args));
            }
        }
        protected virtual void onEntitySpawned(object Sender, LSEventArgs e)
        {
            EventHandler<EntitySpawnedEventArgs> temp = EntitySpawned;
            if (temp != null)
            {
                temp(Sender, new EntitySpawnedEventArgs(e.Args));
            }
        }
        protected virtual void onEntityDespawned(object Sender, LSEventArgs e)
        {
            EventHandler<EntityDespawnedEventArgs> temp = EntityDespawned;
            if (temp != null)
            {
                temp(Sender, new EntityDespawnedEventArgs(e.Args));
            }
        }
		#endregion

		~Event()
		{
            Attach("Aion_onIncomingChatText", onIncomingText);
            Attach("Aion_onCastAbility", onCastAbility);
            Attach("Aion_onStopCastAbility", onStopCastAbility);
            Attach("Aion_OnEntitySpawned", onEntitySpawned);
            Attach("Aion_onEntityDespawned", onEntityDespawned);
		}

		public Event()
		{
            Detach("Aion_onIncomingChatText", onIncomingText);
            Detach("Aion_onCastAbility", onCastAbility);
            Detach("Aion_onStopCastAbility", onStopCastAbility);
            Detach("Aion_OnEntitySpawned", onEntitySpawned);
            Detach("Aion_onEntityDespawned", onEntityDespawned);
		}



        #region Smaller footprint attach/detach methods

        /// <summary>
        /// Attaches the specified event to the specified handler.
        /// </summary>
        /// <param name="eventToAttach">The event to attach.</param>
        /// <param name="handler">The handler.</param>
        public void Attach(string eventToAttach, EventHandler<LSEventArgs> handler)
        {
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent(eventToAttach), handler);
        }

        /// <summary>
        /// Detaches the specified event from the specified handler.
        /// </summary>
        /// <param name="eventToDetach">The event to detach.</param>
        /// <param name="handler">The handler.</param>
        public void Detach(string eventToDetach, EventHandler<LSEventArgs> handler)
        {
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent(eventToDetach), handler);
        }

        #endregion



	}
}
