using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Bootstrap : MonoBehaviour {
	private IProfileSelectionView selectionView;
	private IActiveProfileView activeView;
	private IGUIManager managerGui;

	[Inject]
	public void Construct (IProfileSelectionView selectionView, IActiveProfileView activeView, IGUIManager managerGui) {
		this.selectionView = selectionView;
		this.activeView = activeView;
		this.managerGui = managerGui;
	}

	[SerializeField] private ScriptableProfile[] profiles;


	private void Start() {		

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