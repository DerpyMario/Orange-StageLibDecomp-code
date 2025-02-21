using StageLib;

public class FxController : FxBase
{
	protected float _hsTimer;

	public float SumHSTime
	{
		get
		{
			return _hsTimer;
		}
		set
		{
			_hsTimer = value;
		}
	}

	public void PauseAll()
	{
		if (ps != null && ps.isPlaying)
		{
			ps.Pause(withChildren: true);
		}
	}

	public void PlayAll()
	{
		if (ps != null && ps.isPaused)
		{
			ps.Play(withChildren: true);
		}
	}

	public void StopAll()
	{
		if (ps != null && !ps.isStopped)
		{
			ps.Stop(withChildren: true);
		}
	}

	public override void Active(params object[] p_params)
	{
		base.gameObject.SetActive(value: true);
		ps.Play(withChildren: true);
		float fTime = timeBackToPool;
		if (p_params.Length != 0 && p_params[0] is StageFXParam stageFXParam)
		{
			fTime = ((!(stageFXParam.fPlayTime > 0f)) ? timeBackToPool : stageFXParam.fPlayTime);
		}
		StartCoroutine(StageResManager.TweenFloatCoroutine(0f, 1f, fTime, null, delegate
		{
			if (SumHSTime > 0f)
			{
				StartCoroutine(StageResManager.TweenFloatCoroutine(0f, 1f, SumHSTime, null, delegate
				{
					BackToPool();
				}));
			}
			else
			{
				BackToPool();
			}
		}));
	}
}
