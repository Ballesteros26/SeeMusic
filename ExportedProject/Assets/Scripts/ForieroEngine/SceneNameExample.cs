using UnityEngine;

public class SceneNameExample : MonoBehaviour
{
	[SceneName(true)]
	public string sceneName;

	[SceneName(false)]
	public string sceneName2;
}
