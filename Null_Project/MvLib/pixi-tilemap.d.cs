
		using System;
		using System.Collections.Generic;
		using System.Linq;
		using System.Text;
		
namespace GLOBAL
{

		public class PIXI
	{
		protected PIXI()
		{
			
		}

				public class CanvasTileRenderer
		{
			public CanvasTileRenderer(PIXI.CanvasRenderer renderer)
			{
				
			}
			protected CanvasTileRenderer()
			{
				
			}
			public PIXI.CanvasRenderer renderer;
			public float[] tileAnim;
			public bool dontUseTransform;
		}
	}
}
