using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ProfileItemView : MonoBehaviour {
	[SerializeField] private Image portraitImage;	
	[SerializeField] private Image level;
	private Button selectButton;

	private int profileId;
	private Action<int> onClick;

	public void Init(ProfileModel model, Action<int> onClick) {
		profileId = model.Id;
		portraitImage.sprite = model.Portrait;		
		level.fillAmount = model.Level;
		this.onClick = onClick;

		selectButton = transform.AddComponent<Button>();
		selectButton.onClick.RemoveAllListeners();
		selectButton.onClick.AddListener(() => onClick?.Invoke(profileId));
	}
}