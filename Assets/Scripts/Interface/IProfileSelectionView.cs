using System;
using System.Collections.Generic;

public interface IProfileSelectionView {
	void ShowProfiles(IReadOnlyList<ProfileModel> profiles, Action<int> OnProfileSelected);	
}