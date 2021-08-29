using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericSingleton<T> : MonoBehaviour where T : Component
{
	private static T _instance;
	public static T Instance 
	{
		get
		{
			if (_instance == null)
			{
				_instance = (T)FindObjectOfType(typeof(T));
				if (_instance == null)
				{
					GameObject obj = new GameObject();
					//obj.hideFlags = HideFlags.HideAndDontSave;
                    _instance = obj.AddComponent<T>();
				}
			}
			return _instance;
		}
	}

	public virtual void Awake()
	{
		if (_instance == null)
		{
			_instance = this as T;
			DontDestroyOnLoad(this);
		}
		else
		{
			Clone(_instance, gameObject.GetComponent<T>());
			DontDestroyOnLoad(this);
			Destroy(_instance.gameObject);			
		}
	}

	public virtual void Clone(T oldCp, T newCp) { 
		
	}
}
