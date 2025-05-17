using System.Collections.Generic;
using UnityEngine;

public class Bootstrap : MonoBehaviour {
	private IProfileSelectionView selectionView;
	private IActiveProfileView activeView;
	private IGUIManager managerGui
		;

	[SerializeField] private ScriptableProfile[] profiles;


	private void Start() {
		selectionView = Installer.GetService<IProfileSelectionView>();
		activeView = Installer.GetService<IActiveProfileView>();
		managerGui = Installer.GetService<IGUIManager>();

		InitProfile();
	}

	private void InitProfile() {
		if (profiles.Length > 0) {

			var repository = new ScriptableProfileRepository(profiles); 			
			var presenter = new ProfileSelectionPresenter(repository, selectionView, activeView);

			presenter.Init();
		}
		managerGui.Initialize();
	}
	private void OnDestroy() {
		selectionView = null;
		activeView = null;
	}
}