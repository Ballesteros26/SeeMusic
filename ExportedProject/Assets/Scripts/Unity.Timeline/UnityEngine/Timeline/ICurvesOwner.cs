namespace UnityEngine.Timeline
{
	internal interface ICurvesOwner
	{
		string defaultCurvesName { get; }

		Object asset { get; }

		Object assetOwner { get; }

		TrackAsset targetTrack { get; }
	}
}
