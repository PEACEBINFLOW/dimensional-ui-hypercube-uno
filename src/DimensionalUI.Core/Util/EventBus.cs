using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace DimensionalUI.Core.Util;

public class EventBus
{
    private readonly ConcurrentDictionary<string, List<Action<object?>>> _handlers = new();

    public void Subscribe(string topic, Action<object?> handler)
    {
        var list = _handlers.GetOrAdd(topic, _ => new List<Action<object?>>());
        lock (list)
        {
            list.Add(handler);
        }
    }

    public void Publish(string topic, object? payload = null)
    {
        if (!_handlers.TryGetValue(topic, out var list)) return;

        Action<object?>[] snapshot;
        lock (list)
        {
            snapshot = list.ToArray();
        }

        foreach (var h in snapshot)
        {
            h(payload);
        }
    }
}
