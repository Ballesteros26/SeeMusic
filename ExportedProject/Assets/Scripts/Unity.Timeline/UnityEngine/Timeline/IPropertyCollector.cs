namespace UnityEngine.Timeline
{
	public interface IPropertyCollector
	{
		void PushActiveGameObject(GameObject gameObject);

		void PopActiveGameObject();

		void AddFromClip(AnimationClip clip);

		void AddObjectProperties(Object obj, AnimationClip clip);
	}
}
