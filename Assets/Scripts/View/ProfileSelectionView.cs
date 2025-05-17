using System;
using System.Collections.Generic;
using UnityEngine;

public class ProfileSelectionView : MonoBehaviour, IProfileSelectionView {
	[SerializeField] private Transform contentRoot;
	[SerializeField] private ProfileItemView itemPrefab;		

	public void ShowProfiles(IReadOnlyList<ProfileModel> profiles, Action<int> OnProfileSelected) {
		foreach (Transform child in contentRoot)
			Destroy(child.gameObject);

		foreach (var profile in profiles) {
			var item = Instantiate(itemPrefab, contentRoot);
			item.Init(profile, OnProfileSelected);
		}
	}

	
}