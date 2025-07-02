using System;
using UnityEngine;

public class CharacterMaterialChildPass : MonoBehaviour
{
	private CharacterMaterial parent;

	private Renderer _renderer;

	private MaterialPropertyBlock mpb;

	private int AppeartweenUid = -1;

	private int DisAppeartweenUid = -1;

	public MaterialPropertyBlock Mpb
	{
		set
		{
			mpb = value;
		}
	}

	public void Init(Renderer p_renderer, MaterialPropertyBlock p_mpb, CharacterMaterial p_parent)
	{
		_renderer = p_renderer;
		mpb = p_mpb;
		parent = p_parent;
	}

	public void Appear(float DissolveTime)
	{
		if (DissolveTime == 0f)
		{
			base.gameObject.SetActive(value: true);
			return;
		}
		OrangeMaterialProperty prop = MonoBehaviourSingleton<OrangeMaterialProperty>.Instance;
		float num = 1f;
		mpb.SetFloat(prop.i_DissolveValue, num);
		_renderer.SetPropertyBlock(mpb);
		base.gameObject.SetActive(value: true);
		AppeartweenUid = LeanTween.value(base.gameObject, num, 0f, DissolveTime).setOnUpdate(delegate(float val)
		{
			mpb.SetFloat(prop.i_DissolveValue, val);
			_renderer.SetPropertyBlock(mpb);
		}).setOnComplete((Action)delegate
		{
			AppeartweenUid = -1;
			parent.UpdateProperty(setProperty: false);
		})
			.uniqueId;
	}

	public void Disappear(float DissolveTime)
	{
		if (DissolveTime == 0f)
		{
			base.gameObject.SetActive(value: false);
			return;
		}
		OrangeMaterialProperty prop = MonoBehaviourSingleton<OrangeMaterialProperty>.Instance;
		float num = 0f;
		mpb.SetFloat(prop.i_DissolveValue, num);
		_renderer.SetPropertyBlock(mpb);
		base.gameObject.SetActive(value: true);
		DisAppeartweenUid = LeanTween.value(base.gameObject, num, 1f, DissolveTime).setOnUpdate(delegate(float val)
		{
			mpb.SetFloat(prop.i_DissolveValue, val);
			_renderer.SetPropertyBlock(mpb);
		}).setOnComplete((Action)delegate
		{
			DisAppeartweenUid = -1;
			parent.UpdateProperty(setProperty: false);
		})
			.uniqueId;
	}

	private void OnDisable()
	{
		if (parent != null)
		{
			parent.UpdateProperty(setProperty: false);
		}
		if (AppeartweenUid != -1)
		{
			LeanTween.cancel(base.gameObject, AppeartweenUid);
		}
		if (DisAppeartweenUid != -1)
		{
			LeanTween.cancel(base.gameObject, DisAppeartweenUid);
		}
	}
}
