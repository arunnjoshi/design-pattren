﻿using System.Threading;

namespace Singleton;

public class ConfigManager
{
	private static ConfigManager instance;
	private ConfigManager()
	{

	}

	private Dictionary<string, Object> _config = [];

	public void Set(string key, object value)
	{
		_config[key] = value;
	}

	public object Get(string key)
	{
		if (_config.TryGetValue(key, out object? value))
		{
			return value;
		}
		return string.Empty;
	}


	public static ConfigManager GetInstance()
	{
		var semaphoreSlim = new SemaphoreSlim(1, 1);
		try
		{
			semaphoreSlim.Wait();
			instance ??= new ConfigManager();
			return instance;
		}
		finally
		{
			semaphoreSlim.Release();
		}
	}
}
