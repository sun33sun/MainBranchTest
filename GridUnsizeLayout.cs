using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace HomeVisit.UI
{
	[ExecuteAlways]
	public class GridUnsizeLayout : LayoutGroup
	{
		public override void CalculateLayoutInputVertical()
		{
			throw new System.NotImplementedException();
		}

		public override void SetLayoutHorizontal()
		{
			throw new System.NotImplementedException();
		}

		public override void SetLayoutVertical()
		{
			throw new System.NotImplementedException();
		}

		protected void CalcPos()
		{
			Rect rect = rectTransform.rect;
			//��֪(0,0)��Ϊê��λ��
			//ȥ��pading��Ĵ�С�����pading������������
			Vector2 size = rect.size - new Vector2(padding.horizontal, padding.vertical);
			//Vector2 leftUpPos = rect.size 8(Vector2.up - rectTransform.pivot) - new Vector2(-padding.left, padding.top);
		}
	}
}

