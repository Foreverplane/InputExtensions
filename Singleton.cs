

using UnityEngine;
public class Singleton<T> : MonoBehaviour where T : MonoBehaviour {
	private static T _Instance;
	public static T Instance {
		get {
			if (_Instance == null) {
				_Instance = FindObjectOfType<T>();
				if (_Instance == null) {
					GameObject obj = new GameObject();
					obj.name = typeof(T).Name;
					_Instance = obj.AddComponent<T>();
					// DontDestroyOnLoad(obj);
				}
			}
			else {
				
			}
			return _Instance;
		}
	}
}
