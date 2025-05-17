using UnityEngine;

[CreateAssetMenu(fileName = "Profile", menuName = "Game/Profile", order = 0)]
public class ScriptableProfile : ScriptableObject {
	public int Id;
	public string DisplayName;
	[Range(0f, 1f)]
	public float Level;
	public Sprite Portrait;

	public ProfileModel ToModel() {
		return new ProfileModel(Id, DisplayName, Level, Portrait);
	}
}