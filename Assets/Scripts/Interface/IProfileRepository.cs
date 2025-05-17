using System.Collections.Generic;

public interface IProfileRepository {
	IReadOnlyList<ProfileModel> GetAllProfiles();
	void SetActiveProfile(int id);
	ProfileModel GetActiveProfile();
}