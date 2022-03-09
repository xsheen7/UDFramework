using System;
using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace QFramework.Example
{
	// Generate Id:3926bfa9-c9c2-4697-bab0-f366192ef363
	public partial class UIMyPanel
	{
		public const string Name = "UIMyPanel";
		
		
		private UIMyPanelData mPrivateData = null;

		[SerializeField] private Button m_Btn;
		
		protected override void ClearUIComponents()
		{
			
			mData = null;
			m_Btn = null;
		}
		
		public UIMyPanelData Data
		{
			get
			{
				return mData;
			}
		}
		
		UIMyPanelData mData
		{
			get
			{
				return mPrivateData ?? (mPrivateData = new UIMyPanelData());
			}
			set
			{
				mUIData = value;
				mPrivateData = value;
			}
		}
	}
}
