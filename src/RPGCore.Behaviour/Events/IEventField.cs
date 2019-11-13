﻿using System;

namespace RPGCore.Behaviour
{
	public interface IEventField : IDisposable
	{
		EventFieldHandlerCollection Handlers { get; }

		public object GetValue ();
		public void SetValue (object value);
	}

	public interface IReadOnlyEventField<T> : IEventField
	{
		T Value { get; }
	}

	public interface IEventField<T> : IReadOnlyEventField<T>
	{
		new T Value { get; set; }
	}
}
