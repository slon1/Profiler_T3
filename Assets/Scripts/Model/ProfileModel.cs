using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfileModel {
	public int Id { get; }
	public string Name { get; }
	public float Level { get; }
	public Sprite Portrait { get; }

	public ProfileModel(int id, string name, float level, Sprite portrait) {
		Id = id;
		Name = name;
		Level = level;
		Portrait = portrait;
	}
}