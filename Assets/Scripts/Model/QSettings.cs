using UnityEngine;

namespace Model
{
	public class QSettings : MonoBehaviour
	{
		private void Awake()
		{
			QualitySettings.vSyncCount = 1;
			Application.targetFrameRate = 60;
		}
	}
}