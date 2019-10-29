﻿using System;
using System.Diagnostics;

namespace RPGCore.Behaviour
{
	public interface IConnection
	{
		int ConnectionId { get; }

		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		Type ConnectionType { get; }

		void RegisterConverter (IConnectionTypeConverter converter);
		void RegisterInput (INodeInstance node);
		void Subscribe (INodeInstance node, Action callback);
		void Unsubscribe (INodeInstance node, Action callback);
	}

	public interface IConnection<T> : IConnection, IEventField<T>
	{
		IReadOnlyEventField<T> Mirroring { get; }
		void StartMirroring (IReadOnlyEventField<T> target);
		void StopMirroring ();
	}
}
