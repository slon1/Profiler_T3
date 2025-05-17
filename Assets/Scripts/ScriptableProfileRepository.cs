using System.Collections.Generic;
using System.Linq;

public class ScriptableProfileRepository : IProfileRepository {
	private readonly List<ProfileModel> models;
	private int activeId;	

	public ScriptableProfileRepository(ScriptableProfile[] Profiles) {
		models = Profiles
			.Where(p => p != null)
			.Select(p => p.ToModel())
			.ToList();

		activeId = models[0].Id;
	}

	public IReadOnlyList<ProfileModel> GetAllProfiles() => models;

	public void SetActiveProfile(int id) => activeId = id;

	public ProfileModel GetActiveProfile() => models.FirstOrDefault(p => p.Id == activeId);
}
