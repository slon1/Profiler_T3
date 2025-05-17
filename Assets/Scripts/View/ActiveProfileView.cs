using UnityEngine;
using UnityEngine.UI;

public class ActiveProfileView : MonoBehaviour, IActiveProfileView {
	[SerializeField] private Image portraitImage;
	[SerializeField] private Text nameText;
	[SerializeField] private Image level;

	[SerializeField] private Image portraitImageMenu;
	[SerializeField] private Text nameTextMenu;
	[SerializeField] private Image levelMenu;
	public void Show(ProfileModel model) {
		portraitImage.sprite = model.Portrait;
		nameText.text = model.Name;
		level.fillAmount = model.Level;

		portraitImageMenu.sprite = model.Portrait;
		nameTextMenu.text = model.Name;
		levelMenu.fillAmount = model.Level;
	}
}