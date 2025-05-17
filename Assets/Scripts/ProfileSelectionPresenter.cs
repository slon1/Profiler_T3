public class ProfileSelectionPresenter {
	private readonly IProfileRepository profileRepository;
	private readonly IProfileSelectionView selectionView;
	private readonly IActiveProfileView activeView;

	public ProfileSelectionPresenter(IProfileRepository profileService, IProfileSelectionView selectionView, IActiveProfileView activeView) {
		this.profileRepository = profileService;
		this.selectionView = selectionView;
		this.activeView = activeView;
		
	}

	public void Init() {		
		selectionView.ShowProfiles(profileRepository.GetAllProfiles(), OnProfileSelected);
		activeView.Show(profileRepository.GetActiveProfile());
	}

	public void OnProfileSelected(int id) {
		profileRepository.SetActiveProfile(id);		
		activeView.Show(profileRepository.GetActiveProfile());
	}
}
