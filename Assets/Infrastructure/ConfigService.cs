using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigService : MonoBehaviour
{
    private Dictionary<Type, object> _services = new();

    public void Register<T>(T service)
    {
        _services[typeof(T)] = service;
    }

    public T Resolve<T>()
    {
        return (T)_services[typeof(T)];
    }

}
