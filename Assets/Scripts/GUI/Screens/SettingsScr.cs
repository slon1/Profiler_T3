using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsScr : ScrAbs {
	protected override void Start() {
		base.Start();
	}
	public override void Execute(PageActionId action) {
		var off= GetButton(ButtonId.SoundOff).gameObject;
		var on = GetButton(ButtonId.SoundOn).gameObject;

		if (action== PageActionId.SoundOn) {
			off.SetActive(true);
			on.SetActive(false);
		} else if (action== PageActionId.SoundOff) {
			off.SetActive(false);
			on.SetActive(true);
		}
	}
}
