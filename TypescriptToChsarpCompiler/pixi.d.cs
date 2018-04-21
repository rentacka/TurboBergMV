
		using System;
		using System.Collections.Generic;
		using System.Linq;
		using System.Text;
		
public static class GLOBAL
{
	public static Any<Uniforms_2_, object> uniforms;
	public static object glShaders;
	public static float glShaderKey;
	public static float padding;
	public static float resolution;
	public static bool enabled;
	public static string defaultVertexSrc;
	public static string defaultFragmentSrc;
	public static void apply(FilterManager filterManager, RenderTarget input, RenderTarget output, bool clear = default(bool))
	{
		throw new System.NotImplementedException();
	}

		public class WebGLState
	{
		public WebGLState(IWebGLRenderingContext gl)
		{
			
		}
		protected WebGLState()
		{
			
		}
		public float[] activeState;
		public float[] defaultState;
		public float stackIndex;
		public float[] stack;
		public IWebGLRenderingContext gl;
		public float maxAttribs;
		public glCore.IAttribState attribState;
		public object nativeVaoExtension;
		public void push()
		{
			throw new System.NotImplementedException();
		}
		public void pop()
		{
			throw new System.NotImplementedException();
		}
		public void setState(float[] state)
		{
			throw new System.NotImplementedException();
		}
		public void setBlend(float value)
		{
			throw new System.NotImplementedException();
		}
		public void setBlendMode(float value)
		{
			throw new System.NotImplementedException();
		}
		public void setDepthTest(float value)
		{
			throw new System.NotImplementedException();
		}
		public void setCullFace(float value)
		{
			throw new System.NotImplementedException();
		}
		public void setFrontFace(float value)
		{
			throw new System.NotImplementedException();
		}
		public void resetAttributes()
		{
			throw new System.NotImplementedException();
		}
		public void resetToDefault()
		{
			throw new System.NotImplementedException();
		}
	}

		public class TextureManager
	{
		public TextureManager(WebGLRenderer renderer)
		{
			
		}
		protected TextureManager()
		{
			
		}
		public WebGLRenderer renderer;
		public IWebGLRenderingContext gl;
		public protected _managedTextures;
		public void bindTexture()
		{
			throw new System.NotImplementedException();
		}
		public WebGLTexture getTexture()
		{
			throw new System.NotImplementedException();
		}
		public WebGLTexture updateTexture(Any<BaseTexture, Texture> texture)
		{
			throw new System.NotImplementedException();
		}
		public void destroyTexture(BaseTexture texture, bool _skipRemove = default(bool))
		{
			throw new System.NotImplementedException();
		}
		public void removeAll()
		{
			throw new System.NotImplementedException();
		}
		public void destroy()
		{
			throw new System.NotImplementedException();
		}
	}

		public class TextureGarbageCollector
	{
		public TextureGarbageCollector(WebGLRenderer renderer)
		{
			
		}
		protected TextureGarbageCollector()
		{
			
		}
		public WebGLRenderer renderer;
		public float count;
		public float checkCount;
		public float maxIdle;
		public float checkCountMax;
		public float mode;
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void run()
		{
			throw new System.NotImplementedException();
		}
		public void unload()
		{
			throw new System.NotImplementedException();
		}
	}

		public class ObjectRenderer : WebGLManager
	{
		public ObjectRenderer(WebGLRenderer renderer) : base()
		{
			
		}
		protected ObjectRenderer() : base()
		{
			
		}
		public void start()
		{
			throw new System.NotImplementedException();
		}
		public void stop()
		{
			throw new System.NotImplementedException();
		}
		public void flush()
		{
			throw new System.NotImplementedException();
		}
		public void render(params object[][] args)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Quad
	{
		public Quad(IWebGLRenderingContext gl)
		{
			
		}
		protected Quad()
		{
			
		}
		public IWebGLRenderingContext gl;
		public float[] vertices;
		public float[] uvs;
		public float[] interleaved;
		public float[] indices;
		public WebGLBuffer vertexBuffer;
		public glCore.VertexArrayObject vao;
		public void initVao(glCore.GLShader shader)
		{
			throw new System.NotImplementedException();
		}
		public Quad map(Rectangle targetTextureFrame, Rectangle destinationFrame)
		{
			throw new System.NotImplementedException();
		}
		public Quad upload()
		{
			throw new System.NotImplementedException();
		}
		public void destroy()
		{
			throw new System.NotImplementedException();
		}
	}

		public class RenderTarget
	{
		public RenderTarget(IWebGLRenderingContext gl, float width, float height, float scaleMode, float resolution, bool root = default(bool))
		{
			
		}
		protected RenderTarget()
		{
			
		}
		public IWebGLRenderingContext gl;
		public glCore.GLFramebuffer frameBuffer;
		public Texture texture;
		public float[] clearColor;
		public Rectangle size;
		public float resolution;
		public Matrix projectionMatrix;
		public Matrix transform;
		public Rectangle frame;
		public Rectangle defaultFrame;
		public Rectangle destinationFrame;
		public Rectangle sourceFrame;
		public glCore.GLFramebuffer stencilBuffer;
		public Graphics[] stencilMaskStack;
		public FilterData_0_ filterData;
		public float scaleMode;
		public bool root;
		public void clear(float[] clearColor = default(float[]))
		{
			throw new System.NotImplementedException();
		}
		public void attachStencilBuffer()
		{
			throw new System.NotImplementedException();
		}
		public void setFrame(Rectangle destinationFrame, Rectangle sourceFrame)
		{
			throw new System.NotImplementedException();
		}
		public void activate()
		{
			throw new System.NotImplementedException();
		}
		public void calculateProjection(Rectangle destinationFrame, Rectangle sourceFrame)
		{
			throw new System.NotImplementedException();
		}
		public void resize(float width, float height)
		{
			throw new System.NotImplementedException();
		}
		public void destroy()
		{
			throw new System.NotImplementedException();
		}

				public class Stack_0_
		{
			public RenderTarget renderTarget;
			public object[] filter;
			public Rectangle bounds;
		}

				public class FilterData_0_
		{
			public float index;
			public Stack_0_[] stack;
		}
	}

		public class BlendModeManager : WebGLManager
	{
		public BlendModeManager(WebGLRenderer renderer) : base()
		{
			
		}
		protected BlendModeManager() : base()
		{
			
		}
		public float currentBlendMode;
		public bool setBlendMode(float blendMode)
		{
			throw new System.NotImplementedException();
		}
	}

		public class FilterManager : WebGLManager
	{
		public FilterManager(WebGLRenderer renderer) : base()
		{
			
		}
		protected FilterManager() : base()
		{
			
		}
		public IWebGLRenderingContext gl;
		public Quad quad;
		public Stack_1_[] stack;
		public float stackIndex;
		public object shaderCache;
		public object filterData;
		public RenderTarget outputTarget;
		public bool clear;
		public void pushFilter(RenderTarget target, Filter[] filters)
		{
			throw new System.NotImplementedException();
		}
		public void popFilter()
		{
			throw new System.NotImplementedException();
		}
		public RenderTarget applyFilter(glCore.GLShader.Filter shader)
		{
			throw new System.NotImplementedException();
		}
		public Filter syncUniforms(glCore.GLShader shader)
		{
			throw new System.NotImplementedException();
		}
		public RenderTarget getRenderTarget(bool clear = default(bool), float resolution = default(float))
		{
			throw new System.NotImplementedException();
		}
		public RenderTarget returnRenderTarget(RenderTarget renderTarget)
		{
			throw new System.NotImplementedException();
		}
		public Matrix calculateScreenSpaceMatrix(Matrix outputMatrix)
		{
			throw new System.NotImplementedException();
		}
		public Matrix calculateNormalisedScreenSpaceMatrix(Matrix outputMatrix)
		{
			throw new System.NotImplementedException();
		}
		public Matrix calculateSpriteMatrix(Matrix outputMatrix, Sprite sprite)
		{
			throw new System.NotImplementedException();
		}
		public void destroy()
		{
			throw new System.NotImplementedException();
		}
		public void emptyPool()
		{
			throw new System.NotImplementedException();
		}
		public RenderTarget getPotRenderTarget(IWebGLRenderingContext gl, float minWidth, float minHeight, float resolution)
		{
			throw new System.NotImplementedException();
		}
		public void freePotRenderTarget(RenderTarget renderTarget)
		{
			throw new System.NotImplementedException();
		}

				public class Stack_1_
		{
			public RenderTarget renderTarget;
			public Rectangle sourceFrame;
			public Rectangle destinationFrame;
			public Filter[] filters;
			public object target;
			public float resolution;
		}
	}

		public class StencilMaskStack
	{
		protected StencilMaskStack()
		{
			
		}
		public object[] stencilStack;
		public bool reverse;
		public float count;
	}

		public class MaskManager : WebGLManager
	{
		protected MaskManager() : base()
		{
			
		}
		public bool scissor;
		public object scissorData;
		public RenderTarget scissorRenderTarget;
		public bool enableScissor;
		public float[] alphaMaskPool;
		public float alphaMaskIndex;
		public void pushMask(RenderTarget target, Any<Sprite, Graphics> maskData)
		{
			throw new System.NotImplementedException();
		}
		public void popMask(RenderTarget target, Any<Sprite, Graphics> maskData)
		{
			throw new System.NotImplementedException();
		}
		public void pushSpriteMask(RenderTarget target, Any<Sprite, Graphics> maskData)
		{
			throw new System.NotImplementedException();
		}
		public void popSpriteMask()
		{
			throw new System.NotImplementedException();
		}
		public void pushStencilMask(Any<Sprite, Graphics> maskData)
		{
			throw new System.NotImplementedException();
		}
		public void popStencilMask()
		{
			throw new System.NotImplementedException();
		}
		public void pushScissorMask(RenderTarget target, Any<Sprite, Graphics> maskData)
		{
			throw new System.NotImplementedException();
		}
		public void popScissorMask()
		{
			throw new System.NotImplementedException();
		}
	}

		public class StencilManager : WebGLManager
	{
		public StencilManager(WebGLRenderer renderer) : base()
		{
			
		}
		protected StencilManager() : base()
		{
			
		}
		public Graphics[] stencilMaskStack;
		public void setMaskStack(Graphics[] stencilMasStack)
		{
			throw new System.NotImplementedException();
		}
		public void pushStencil(Graphics graphics)
		{
			throw new System.NotImplementedException();
		}
		public void popStencil()
		{
			throw new System.NotImplementedException();
		}
		public void destroy()
		{
			throw new System.NotImplementedException();
		}
	}

		public class WebGLManager
	{
		public WebGLManager(WebGLRenderer renderer)
		{
			
		}
		protected WebGLManager()
		{
			
		}
		public SystemRenderer renderer;
		public void onContextChange()
		{
			throw new System.NotImplementedException();
		}
		public void destroy()
		{
			throw new System.NotImplementedException();
		}
	}

		public class IUniformData
	{
		protected IUniformData()
		{
			
		}
		public string type;
		public object value;
		public string name;
	}

		public class Filter
	{
		public Filter(string vertexSrc = default(string), string fragmentSrc = default(string), Uniforms_1_ uniforms = default(Uniforms_1_))
		{
			
		}
		protected Filter()
		{
			
		}
		public string vertextSrc;
		public string fragmentSrc;
		public float blendMode;
		public protected uniformData;
		public string name;

				public class Uniforms_0_
		{
			
			public IUniformData this[string index]
			{
				get
				{
					return (IUniformData)((dynamic)this)[index];
				}				
				set
				{
					((dynamic)this)[index] = value;
				}
			}
			
		}

				public class Uniforms_1_
		{
			
			public IUniformData this[string index]
			{
				get
				{
					return (IUniformData)((dynamic)this)[index];
				}				
				set
				{
					((dynamic)this)[index] = value;
				}
			}
			
		}
	}

		public class Uniforms_2_
	{
		
		public object this[string index]
		{
			get
			{
				return (object)((dynamic)this)[index];
			}				
			set
			{
				((dynamic)this)[index] = value;
			}
		}
		
	}

		public static class PIXI
	{
		public static object VERSION;
		public static object PI_2;
		public static object RAD_TO_DEG;
		public static object DEG_TO_RAD;
		public static object RENDERER_TYPE;
		public static object BLEND_MODES;
		public static object DRAW_MODES;
		public static object SCALE_MODES;
		public static object WRAP_MODES;
		public static object TRANSFORM_MODE;
		public static object PRECISION;
		public static object GC_MODES;
		public static object SHAPES;
		public static object TEXT_GRADIENT;
		public static PIXI.loaders.Loader loader;
		public static protected _backgroundColorRgba;
		public static MaskManager maskManager;
		public static StencilManager stencilManager;
		public static ObjectRenderer emptyRenderer;
		public static ObjectRenderer currentRenderer;
		public static IWebGLRenderingContext gl;
		public static float CONTEXT_UID;
		public static WebGLState state;
		public static bool renderingToScreen;
		public static Texture[] boundTextures;
		public static FilterManager filterManager;
		public static TextureManager textureManager;
		public static extract.WebGLExtract extract;
		public static protected drawModes;
		public static protected _activeShader;
		public static RenderTarget _activeRenderTarget;
		public static protected _initContext;
		public static bool clear;
		public static PIXI.Transform transform;
		public static bool skipUpdateTransform;
		public static Action<WebGLContextEvent> handleContextLost;
		public static Action handleContextRestored;
		public static Action fn;
		public static object context;
		public static bool autoDetectRenderer(float width, float height, PIXI.IRendererOptions options = default(PIXI.IRendererOptions))
		{
			throw new System.NotImplementedException();
		}
		public static PIXI.RenderTexture render(PIXI.DisplayObject displayObject)
		{
			throw new System.NotImplementedException();
		}
		public static void setObjectRenderer(ObjectRenderer objectRenderer)
		{
			throw new System.NotImplementedException();
		}
		public static void flush()
		{
			throw new System.NotImplementedException();
		}
		public static void setBlendMode(float blendMode)
		{
			throw new System.NotImplementedException();
		}
		public static void clear(float clearColor = default(float))
		{
			throw new System.NotImplementedException();
		}
		public static void setTransform(Matrix matrix)
		{
			throw new System.NotImplementedException();
		}
		public static WebGLRenderer clearRenderTexture(RenderTexture renderTexture, float clearColor = default(float))
		{
			throw new System.NotImplementedException();
		}
		public static WebGLRenderer bindRenderTexture(RenderTexture renderTexture, Transform transform)
		{
			throw new System.NotImplementedException();
		}
		public static WebGLRenderer bindRenderTarget(RenderTarget renderTarget)
		{
			throw new System.NotImplementedException();
		}
		public static WebGLRenderer bindShader(Shader shader, bool autoProject = default(bool))
		{
			throw new System.NotImplementedException();
		}
		public static float bindTexture(Any<Texture, BaseTexture> texture, float location = default(float), bool forceLocation = default(bool))
		{
			throw new System.NotImplementedException();
		}
		public static Any<WebGLRenderer, undefined> unbindTexture(Any<Texture, BaseTexture> texture)
		{
			throw new System.NotImplementedException();
		}
		public static glCore.VertexArrayObject createVao()
		{
			throw new System.NotImplementedException();
		}
		public static WebGLRenderer bindVao(glCore.VertexArrayObject vao)
		{
			throw new System.NotImplementedException();
		}
		public static WebGLRenderer reset()
		{
			throw new System.NotImplementedException();
		}
		public static void destroy(bool removeView = default(bool))
		{
			throw new System.NotImplementedException();
		}
		public static object on(object @event)
		{
			throw new System.NotImplementedException();
		}
		public static object on(string @event, Function fn, object context = default(object))
		{
			throw new System.NotImplementedException();
		}
		public static object once(object @event)
		{
			throw new System.NotImplementedException();
		}
		public static object once(string @event, Function fn, object context = default(object))
		{
			throw new System.NotImplementedException();
		}
		public static object off(string @event, Function fn, object context = default(object))
		{
			throw new System.NotImplementedException();
		}

				public class IApplicationOptions : IRendererOptions
		{
			protected IApplicationOptions() : base()
			{
				
			}
			public HTMLCanvasElement view;
			public bool transparent;
			public bool autoResize;
			public bool antialias;
			public float resolution;
			public bool clearBeforeRender;
			public float backgroundColor;
			public bool roundPixels;
			public IWebGLRenderingContext context;
			public bool preserveDrawingBuffer;
			public bool legacy;
		}

				public class Application
		{
			public Application(float width = default(float), float height = default(float), IApplicationOptions options = default(IApplicationOptions), bool noWebGL = default(bool), bool useSharedTicker = default(bool))
			{
				
			}
			protected Application()
			{
				
			}
			public ticker.Ticker _ticker;
			public PIXI.WebGLRenderer.PIXI.CanvasRenderer renderer;
			public Container stage;
			public ticker.Ticker ticker;
			public readonly screen;
			public readonly view;
			public void stop()
			{
				throw new System.NotImplementedException();
			}
			public void start()
			{
				throw new System.NotImplementedException();
			}
			public void render()
			{
				throw new System.NotImplementedException();
			}
			public void destroy(bool removeView = default(bool))
			{
				throw new System.NotImplementedException();
			}
		}

				public class IDestroyOptions
		{
			protected IDestroyOptions()
			{
				
			}
			public bool children;
			public bool texture;
			public bool baseTexture;
		}

				public class Bounds
		{
			protected Bounds()
			{
				
			}
			public float minX;
			public float minY;
			public float maxX;
			public float maxY;
			public Rectangle rect;
			public bool isEmpty()
			{
				throw new System.NotImplementedException();
			}
			public void clear()
			{
				throw new System.NotImplementedException();
			}
			public Rectangle getRectangle(Rectangle rect = default(Rectangle))
			{
				throw new System.NotImplementedException();
			}
			public void addPoint(Point point)
			{
				throw new System.NotImplementedException();
			}
			public Any<Bounds, undefined> addQuad(float[] vertices)
			{
				throw new System.NotImplementedException();
			}
			public void addFrame(Transform transform, float x0, float y0, float x1, float y1)
			{
				throw new System.NotImplementedException();
			}
			public void addVertices(Transform transform, float[] vertices, float beginOffset, float endOffset)
			{
				throw new System.NotImplementedException();
			}
			public void addBounds(Bounds bounds)
			{
				throw new System.NotImplementedException();
			}
			public void addBoundsMask(Bounds bounds, Bounds mask)
			{
				throw new System.NotImplementedException();
			}
			public void addBoundsArea(Bounds bounds, Rectangle area)
			{
				throw new System.NotImplementedException();
			}
		}

				public class Container : DisplayObject
		{
			protected Container() : base()
			{
				
			}
			public DisplayObject[] children;
			public float width;
			public float height;
			public protected onChildrenChange;
			public object[] args;
			public object void;
			public protected _calculateBounds;
			public protected containerUpdateTransform;
			public protected _renderWebGL;
			public CanvasRenderer renderer;
			public protected _renderCanvas;
			public Action<DisplayObject> fn;
			public object context;
			public DisplayObject getChildByName(string name)
			{
				throw new System.NotImplementedException();
			}
			public T addChild<T>(T child, params DisplayObject[] additionalChildren) where T : DisplayObject
			{
				throw new System.NotImplementedException();
			}
			public T addChildAt<T>(T child, float index) where T : DisplayObject
			{
				throw new System.NotImplementedException();
			}
			public void swapChildren(DisplayObject child, DisplayObject child2)
			{
				throw new System.NotImplementedException();
			}
			public float getChildIndex(DisplayObject child)
			{
				throw new System.NotImplementedException();
			}
			public void setChildIndex(DisplayObject child, float index)
			{
				throw new System.NotImplementedException();
			}
			public DisplayObject getChildAt(float index)
			{
				throw new System.NotImplementedException();
			}
			public DisplayObject removeChild(DisplayObject child)
			{
				throw new System.NotImplementedException();
			}
			public DisplayObject removeChildAt(float index)
			{
				throw new System.NotImplementedException();
			}
			public DisplayObject[] removeChildren(float beginIndex = default(float), float endIndex = default(float))
			{
				throw new System.NotImplementedException();
			}
			public void updateTransform()
			{
				throw new System.NotImplementedException();
			}
			public void calculateBounds()
			{
				throw new System.NotImplementedException();
			}
			public void renderWebGL(WebGLRenderer renderer)
			{
				throw new System.NotImplementedException();
			}
			public void renderAdvancedWebGL(WebGLRenderer renderer)
			{
				throw new System.NotImplementedException();
			}
			public void renderCanvas(CanvasRenderer renderer)
			{
				throw new System.NotImplementedException();
			}
			public void destroy(Any<IDestroyOptions, bool> options = default(Any<IDestroyOptions, bool>))
			{
				throw new System.NotImplementedException();
			}
			public object once(object @event)
			{
				throw new System.NotImplementedException();
			}
			public object once(string @event, Function fn, object context = default(object))
			{
				throw new System.NotImplementedException();
			}
			public object on(object @event)
			{
				throw new System.NotImplementedException();
			}
			public object on(string @event, Function fn, object context = default(object))
			{
				throw new System.NotImplementedException();
			}
			public object off(string @event, Function fn, object context = default(object))
			{
				throw new System.NotImplementedException();
			}
		}

				public class DisplayObject : utils.EventEmitter
		{
			protected DisplayObject() : base()
			{
				
			}
			public protected _cacheAsBitmap;
			public protected _cacheData;
			public bool cacheAsBitmap;
			public protected _renderCachedWebGL;
			public CanvasRenderer renderer;
			public protected _initCachedDisplayObject;
			public protected _renderCachedCanvas;
			public protected _initCachedDisplayObjectCanvas;
			public protected _calculateCachedBounds;
			public protected _getCachedLocalBounds;
			public protected _destroyCachedDisplayObject;
			public protected _cacheAsBitmapDestroy;
			public Any<string, null> name;
			public bool accessible;
			public Any<string, null> accessibleTitle;
			public Any<string, null> accessibleHint;
			public float tabIndex;
			public bool interactive;
			public bool interactiveChildren;
			public PIXI.Rectangle.PIXI.Circle.PIXI.Ellipse.PIXI.Polygon.PIXI.RoundedRectangle hitArea;
			public bool buttonMode;
			public string cursor;
			public string defaultCursor;
			public TransformBase transform;
			public float alpha;
			public bool visible;
			public bool renderable;
			public Container parent;
			public float worldAlpha;
			public Rectangle filterArea;
			public protected _filters;
			public protected _enabledFilters;
			public protected _bounds;
			public protected _boundsID;
			public protected _lastBoundsID;
			public protected _boundsRect;
			public protected _localBoundsRect;
			public protected _mask;
			public float x;
			public float y;
			public Matrix worldTransform;
			public Matrix localTransform;
			public Point position;
			public Point scale;
			public Point pivot;
			public Point skew;
			public float rotation;
			public bool worldVisible;
			public PIXI.Graphics.PIXI.Sprite mask;
			public Any<Filter[], null> filters;
			public protected displayObjectUpdateTransform;
			public protected _recursivePostUpdateTransform;
			public Point getGlobalPosition(Point point = default(Point), bool skipUpdate = default(bool))
			{
				throw new System.NotImplementedException();
			}
			public TrackedPointers_0_ trackedPointers()
			{
				throw new System.NotImplementedException();
			}
			public void updateTransform()
			{
				throw new System.NotImplementedException();
			}
			public Rectangle getBounds(bool skipUpdate = default(bool), Rectangle rect = default(Rectangle))
			{
				throw new System.NotImplementedException();
			}
			public Rectangle getLocalBounds(Rectangle rect = default(Rectangle))
			{
				throw new System.NotImplementedException();
			}
			public Point toGlobal(Point position, Point point = default(Point), bool skipUpdate = default(bool))
			{
				throw new System.NotImplementedException();
			}
			public Point toLocal(Point position, DisplayObject from = default(DisplayObject), Point point = default(Point), bool skipUpdate = default(bool))
			{
				throw new System.NotImplementedException();
			}
			public void renderWebGL(WebGLRenderer renderer)
			{
				throw new System.NotImplementedException();
			}
			public void renderCanvas(CanvasRenderer renderer)
			{
				throw new System.NotImplementedException();
			}
			public Container setParent(Container container)
			{
				throw new System.NotImplementedException();
			}
			public DisplayObject setTransform(float x = default(float), float y = default(float), float scaleX = default(float), float scaleY = default(float), float rotation = default(float), float skewX = default(float), float skewY = default(float), float pivotX = default(float), float pivotY = default(float))
			{
				throw new System.NotImplementedException();
			}
			public void destroy()
			{
				throw new System.NotImplementedException();
			}
			public object on(string @event, Function fn, object context = default(object))
			{
				throw new System.NotImplementedException();
			}
			public object once(string @event, Function fn, object context = default(object))
			{
				throw new System.NotImplementedException();
			}
			public object off(string @event, Function fn, object context = default(object))
			{
				throw new System.NotImplementedException();
			}

						public class TrackedPointers_0_
			{
				
				public interaction.InteractionTrackingData this[float index]
				{
					get
					{
						return (interaction.InteractionTrackingData)((dynamic)this)[index];
					}				
					set
					{
						((dynamic)this)[index] = value;
					}
				}
				
			}
		}

				public class TransformBase
		{
			protected TransformBase()
			{
				
			}
			public static TransformBase IDENTITY;
			public Matrix worldTransform;
			public Matrix localTransform;
			public protected _worldID;
			public void updateLocalTransform()
			{
				throw new System.NotImplementedException();
			}
			public void updateTransform(TransformBase parentTransform)
			{
				throw new System.NotImplementedException();
			}
			public void updateWorldTransform(TransformBase parentTransform)
			{
				throw new System.NotImplementedException();
			}
		}

				public class TransformStatic : TransformBase
		{
			protected TransformStatic() : base()
			{
				
			}
			public ObservablePoint position;
			public ObservablePoint scale;
			public ObservablePoint pivot;
			public ObservablePoint skew;
			public protected _rotation;
			public protected _sr;
			public protected _cr;
			public protected _cy;
			public protected _sy;
			public protected _nsx;
			public protected _cx;
			public protected _currentLocalID;
			public protected onChange;
			public float rotation;
			public void updateSkew()
			{
				throw new System.NotImplementedException();
			}
			public void updateLocalTransform()
			{
				throw new System.NotImplementedException();
			}
			public void updateTransform(TransformBase parentTransform)
			{
				throw new System.NotImplementedException();
			}
			public void setFromMatrix(Matrix matrix)
			{
				throw new System.NotImplementedException();
			}
		}

				public class Transform : TransformBase
		{
			public Transform() : base()
			{
				
			}
			public Point position;
			public Point scale;
			public ObservablePoint skew;
			public Point pivot;
			public protected _rotation;
			public protected _sr;
			public protected _cr;
			public protected _cy;
			public protected _sy;
			public protected _nsx;
			public protected _cx;
			public float rotation;
			public void updateSkew()
			{
				throw new System.NotImplementedException();
			}
			public void setFromMatrix(Matrix matrix)
			{
				throw new System.NotImplementedException();
			}
		}

				public class GraphicsData
		{
			public GraphicsData(float lineWidth, float lineColor, float lineAlpha, float fillColor, float fillAlpha, bool fill, bool nativeLines, Any<IShape, Circle, Rectangle, RoundedRectangle, Ellipse, Polygon> shape)
			{
				
			}
			protected GraphicsData()
			{
				
			}
			public float lineWidth;
			public bool nativeLines;
			public float lineColor;
			public float lineAlpha;
			public protected _lineTint;
			public float fillColor;
			public float fillAlpha;
			public protected _fillTint;
			public bool fill;
			public protected holes;
			public Any<IShape, Circle, Rectangle, RoundedRectangle, Ellipse, Polygon> shape;
			public float type;
			public GraphicsData clone()
			{
				throw new System.NotImplementedException();
			}
			public void addHole(Any<IShape, Circle, Rectangle, RoundedRectangle, Ellipse, Polygon> shape)
			{
				throw new System.NotImplementedException();
			}
			public void destroy(Any<IDestroyOptions, bool> options = default(Any<IDestroyOptions, bool>))
			{
				throw new System.NotImplementedException();
			}
		}

				public class Graphics : Container
		{
			public Graphics(bool nativeLines = default(bool)) : base()
			{
				
			}
			protected Graphics() : base()
			{
				
			}
			public float fillAlpha;
			public float lineWidth;
			public bool nativeLines;
			public float lineColor;
			public protected graphicsData;
			public float tint;
			public protected _prevTint;
			public float blendMode;
			public GraphicsData currentPath;
			public protected _webGL;
			public bool isMask;
			public float boundsPadding;
			public protected _localBounds;
			public bool dirty;
			public float fastRectDirty;
			public float clearDirty;
			public float boundsDirty;
			public protected cachedSpriteDirty;
			public protected _spriteRect;
			public protected _fastRect;
			public static Texture _SPRITE_TEXTURE;
			public protected _renderCanvas;
			public PIXI.SystemRenderer renderer;
			public protected _calculateBounds;
			public protected _renderSpriteRect;
			public protected closePath;
			public protected addHole;
			public Graphics clone()
			{
				throw new System.NotImplementedException();
			}
			public Graphics lineStyle(float lineWidth = default(float), float color = default(float), float alpha = default(float))
			{
				throw new System.NotImplementedException();
			}
			public Graphics moveTo(float x, float y)
			{
				throw new System.NotImplementedException();
			}
			public Graphics lineTo(float x, float y)
			{
				throw new System.NotImplementedException();
			}
			public Graphics quadraticCurveTo(float cpX, float cpY, float toX, float toY)
			{
				throw new System.NotImplementedException();
			}
			public Graphics bezierCurveTo(float cpX, float cpY, float cpX2, float cpY2, float toX, float toY)
			{
				throw new System.NotImplementedException();
			}
			public Graphics arcTo(float x1, float y1, float x2, float y2, float radius)
			{
				throw new System.NotImplementedException();
			}
			public Graphics arc(float cx, float cy, float radius, float startAngle, float endAngle, bool anticlockwise = default(bool))
			{
				throw new System.NotImplementedException();
			}
			public Graphics beginFill(float color, float alpha = default(float))
			{
				throw new System.NotImplementedException();
			}
			public Graphics endFill()
			{
				throw new System.NotImplementedException();
			}
			public Graphics drawRect(float x, float y, float width, float height)
			{
				throw new System.NotImplementedException();
			}
			public Graphics drawRoundedRect(float x, float y, float width, float height, float radius)
			{
				throw new System.NotImplementedException();
			}
			public Graphics drawCircle(float x, float y, float radius)
			{
				throw new System.NotImplementedException();
			}
			public Graphics drawEllipse(float x, float y, float width, float height)
			{
				throw new System.NotImplementedException();
			}
			public Graphics drawPolygon(Any<float[], Point[]> path)
			{
				throw new System.NotImplementedException();
			}
			public Graphics clear()
			{
				throw new System.NotImplementedException();
			}
			public bool isFastRect()
			{
				throw new System.NotImplementedException();
			}
			public bool containsPoint(Point point)
			{
				throw new System.NotImplementedException();
			}
			public void updateLocalBounds()
			{
				throw new System.NotImplementedException();
			}
			public GraphicsData drawShape(Any<IShape, Circle, Rectangle, Ellipse, Polygon, RoundedRectangle> shape)
			{
				throw new System.NotImplementedException();
			}
			public Texture generateCanvasTexture(float scaleMode = default(float), float resolution = default(float))
			{
				throw new System.NotImplementedException();
			}
			public void destroy(Any<IDestroyOptions, bool> options = default(Any<IDestroyOptions, bool>))
			{
				throw new System.NotImplementedException();
			}
		}

				public class CanvasGraphicsRenderer
		{
			public CanvasGraphicsRenderer(SystemRenderer renderer)
			{
				
			}
			protected CanvasGraphicsRenderer()
			{
				
			}
			public protected updateGraphicsTint;
			public Graphics graphics;
			public protected renderPolygon;
			public Point[] points;
			public bool close;
			public CanvasRenderingContext2D context;
			public void render(Graphics graphics)
			{
				throw new System.NotImplementedException();
			}
			public void destroy()
			{
				throw new System.NotImplementedException();
			}
		}

				public class GraphicsRenderer : ObjectRenderer
		{
			public GraphicsRenderer(PIXI.CanvasRenderer renderer) : base()
			{
				
			}
			protected GraphicsRenderer() : base()
			{
				
			}
			public protected graphicsDataPool;
			public protected primitiveShader;
			public IWebGLRenderingContext gl;
			public float CONTEXT_UID;
			public protected updateGraphics;
			public PIXI.Graphics graphics;
			public void destroy()
			{
				throw new System.NotImplementedException();
			}
			public void render(Graphics graphics)
			{
				throw new System.NotImplementedException();
			}
			public WebGLGraphicsData getWebGLData(IWebGLRenderingContext webGL, float type)
			{
				throw new System.NotImplementedException();
			}
		}

				public class WebGLGraphicsData
		{
			public WebGLGraphicsData(IWebGLRenderingContext gl, glCore.GLShader shader)
			{
				
			}
			protected WebGLGraphicsData()
			{
				
			}
			public IWebGLRenderingContext gl;
			public float[] color;
			public Point[] points;
			public float[] indices;
			public WebGLBuffer buffer;
			public WebGLBuffer indexBuffer;
			public bool dirty;
			public float[] glPoints;
			public float[] glIndices;
			public glCore.GLShader shader;
			public glCore.VertexArrayObject vao;
			public void reset()
			{
				throw new System.NotImplementedException();
			}
			public void upload()
			{
				throw new System.NotImplementedException();
			}
			public void destroy()
			{
				throw new System.NotImplementedException();
			}
		}

				public class PrimitiveShader : glCore.GLShader
		{
			protected PrimitiveShader() : base()
			{
				
			}
		}

				public class Matrix
		{
			public Matrix(float a = default(float), float b = default(float), float c = default(float), float d = default(float), float tx = default(float), float ty = default(float))
			{
				
			}
			protected Matrix()
			{
				
			}
			public float a;
			public float b;
			public float c;
			public float d;
			public float tx;
			public float ty;
			public static Matrix IDENTITY;
			public static Matrix TEMP_MATRIX;
			public void fromArray(float[] array)
			{
				throw new System.NotImplementedException();
			}
			public Matrix set(float a, float b, float c, float d, float tx, float ty)
			{
				throw new System.NotImplementedException();
			}
			public float[] toArray(bool transpose = default(bool), float[] out = default(float[]))
			{
				throw new System.NotImplementedException();
			}
			public Point apply(Point pos, Point newPos = default(Point))
			{
				throw new System.NotImplementedException();
			}
			public Point applyInverse(Point pos, Point newPos = default(Point))
			{
				throw new System.NotImplementedException();
			}
			public Matrix translate(float x, float y)
			{
				throw new System.NotImplementedException();
			}
			public Matrix scale(float x, float y)
			{
				throw new System.NotImplementedException();
			}
			public Matrix rotate(float angle)
			{
				throw new System.NotImplementedException();
			}
			public Matrix append(Matrix matrix)
			{
				throw new System.NotImplementedException();
			}
			public PIXI.Matrix setTransform(float x, float y, float pivotX, float pivotY, float scaleX, float scaleY, float rotation, float skewX, float skewY)
			{
				throw new System.NotImplementedException();
			}
			public Matrix prepend(Matrix matrix)
			{
				throw new System.NotImplementedException();
			}
			public Matrix invert()
			{
				throw new System.NotImplementedException();
			}
			public Matrix identity()
			{
				throw new System.NotImplementedException();
			}
			public TransformBase decompose(TransformBase transform)
			{
				throw new System.NotImplementedException();
			}
			public Matrix clone()
			{
				throw new System.NotImplementedException();
			}
			public Matrix copy(Matrix matrix)
			{
				throw new System.NotImplementedException();
			}
		}

				public class ObservablePoint
		{
			public ObservablePoint(Function cb, object scope = default(object), float x = default(float), float y = default(float))
			{
				
			}
			protected ObservablePoint()
			{
				
			}
			public float x;
			public float y;
			public Func<, object> cb;
			public object scope;
			public void set(float x = default(float), float y = default(float))
			{
				throw new System.NotImplementedException();
			}
			public void copy(Any<Point, ObservablePoint> point)
			{
				throw new System.NotImplementedException();
			}
		}

				public class Point
		{
			public Point(float x = default(float), float y = default(float))
			{
				
			}
			protected Point()
			{
				
			}
			public float x;
			public float y;
			public Point clone()
			{
				throw new System.NotImplementedException();
			}
			public void copy(Point p)
			{
				throw new System.NotImplementedException();
			}
			public bool equals(Point p)
			{
				throw new System.NotImplementedException();
			}
			public void set(float x = default(float), float y = default(float))
			{
				throw new System.NotImplementedException();
			}
		}

				public class IShape
		{
			protected IShape()
			{
				
			}
		}

				public class IHitArea : IShape
		{
			protected IHitArea() : base()
			{
				
			}
			public bool contains(float x, float y)
			{
				throw new System.NotImplementedException();
			}
		}

				public class Circle
		{
			public Circle(float x = default(float), float y = default(float), float radius = default(float))
			{
				
			}
			protected Circle()
			{
				
			}
			public float x;
			public float y;
			public float radius;
			public float type;
			public Circle clone()
			{
				throw new System.NotImplementedException();
			}
			public bool contains(float x, float y)
			{
				throw new System.NotImplementedException();
			}
			public Rectangle getBounds()
			{
				throw new System.NotImplementedException();
			}
		}

				public class Ellipse
		{
			public Ellipse(float x = default(float), float y = default(float), float width = default(float), float height = default(float))
			{
				
			}
			protected Ellipse()
			{
				
			}
			public float x;
			public float y;
			public float width;
			public float height;
			public float type;
			public Ellipse clone()
			{
				throw new System.NotImplementedException();
			}
			public bool contains(float x, float y)
			{
				throw new System.NotImplementedException();
			}
			public Rectangle getBounds()
			{
				throw new System.NotImplementedException();
			}
		}

				public class Polygon
		{
			public Polygon(Any<Point[], float[]> points)
			{
				
			}
			public Polygon(params Point[] points)
			{
				
			}
			public Polygon(params float[] points)
			{
				
			}
			protected Polygon()
			{
				
			}
			public bool closed;
			public float[] points;
			public float type;
			public Polygon clone()
			{
				throw new System.NotImplementedException();
			}
			public bool contains(float x, float y)
			{
				throw new System.NotImplementedException();
			}
			public void close()
			{
				throw new System.NotImplementedException();
			}
		}

				public class Rectangle
		{
			public Rectangle(float x = default(float), float y = default(float), float width = default(float), float height = default(float))
			{
				
			}
			protected Rectangle()
			{
				
			}
			public float x;
			public float y;
			public float width;
			public float height;
			public float type;
			public float left;
			public float right;
			public float top;
			public float bottom;
			public static Rectangle EMPTY;
			public Rectangle clone()
			{
				throw new System.NotImplementedException();
			}
			public Rectangle copy(Rectangle rectangle)
			{
				throw new System.NotImplementedException();
			}
			public bool contains(float x, float y)
			{
				throw new System.NotImplementedException();
			}
			public void pad(float paddingX, float paddingY)
			{
				throw new System.NotImplementedException();
			}
			public void fit(Rectangle rectangle)
			{
				throw new System.NotImplementedException();
			}
			public void enlarge(Rectangle rectangle)
			{
				throw new System.NotImplementedException();
			}
		}

				public class RoundedRectangle
		{
			public RoundedRectangle(float x = default(float), float y = default(float), float width = default(float), float height = default(float), float radius = default(float))
			{
				
			}
			protected RoundedRectangle()
			{
				
			}
			public float x;
			public float y;
			public float width;
			public float height;
			public float radius;
			public float type;
			public RoundedRectangle clone()
			{
				throw new System.NotImplementedException();
			}
			public bool contains(float x, float y)
			{
				throw new System.NotImplementedException();
			}
		}

				public class IRendererOptions
		{
			protected IRendererOptions()
			{
				
			}
			public HTMLCanvasElement view;
			public bool transparent;
			public bool autoResize;
			public bool antialias;
			public float resolution;
			public bool clearBeforeRender;
			public float backgroundColor;
			public bool roundPixels;
			public IWebGLRenderingContext context;
		}

				public class SystemRenderer : utils.EventEmitter
		{
			public SystemRenderer(string system, float screenWidth = default(float), float screenHeight = default(float), IRendererOptions options = default(IRendererOptions)) : base()
			{
				
			}
			protected SystemRenderer() : base()
			{
				
			}
			public float type;
			public Rectangle screen;
			public readonly width;
			public readonly height;
			public HTMLCanvasElement view;
			public float resolution;
			public bool transparent;
			public bool autoResize;
			public object blendModes;
			public bool preserveDrawingBuffer;
			public bool clearBeforeRender;
			public bool roundPixels;
			public protected _backgroundColor;
			public protected _backgroundColorRgba;
			public protected _backgroundColorString;
			public protected _tempDisplayObjectParent;
			public protected _lastObjectRendered;
			public float backgroundColor;
			public void resize(float screenWidth, float screenHeight)
			{
				throw new System.NotImplementedException();
			}
			public RenderTexture generateTexture(DisplayObject displayObject, float scaleMode = default(float), float resolution = default(float))
			{
				throw new System.NotImplementedException();
			}
			public void render(params object[][] args)
			{
				throw new System.NotImplementedException();
			}
			public void destroy(bool removeView = default(bool))
			{
				throw new System.NotImplementedException();
			}
		}

				public class CanvasRenderer : SystemRenderer
		{
			public CanvasRenderer(float screenWidth = default(float), float screenHeight = default(float), IRendererOptions options = default(IRendererOptions)) : base()
			{
				
			}
			protected CanvasRenderer() : base()
			{
				
			}
			public static Object __plugins;
			public object plugins;
			public interaction.InteractionManager interaction;
			public CanvasRenderingContext2D rootContext;
			public float rootResolution;
			public bool refresh;
			public CanvasMaskManager maskManager;
			public string smoothProperty;
			public extract.CanvasExtract extract;
			public object context;
			public bool clear;
			public PIXI.Transform transform;
			public bool skipUpdateTransform;
			public Action fn;
			public static void registerPlugin(string pluginName, Function ctor)
			{
				throw new System.NotImplementedException();
			}
			public void initPlugins()
			{
				throw new System.NotImplementedException();
			}
			public void destroyPlugins()
			{
				throw new System.NotImplementedException();
			}
			public PIXI.RenderTexture render(PIXI.DisplayObject displayObject)
			{
				throw new System.NotImplementedException();
			}
			public void setBlendMode(float blendMode)
			{
				throw new System.NotImplementedException();
			}
			public void destroy(bool removeView = default(bool))
			{
				throw new System.NotImplementedException();
			}
			public void clear(string clearColor = default(string))
			{
				throw new System.NotImplementedException();
			}
			public object on(object @event)
			{
				throw new System.NotImplementedException();
			}
			public object on(string @event, Function fn, object context = default(object))
			{
				throw new System.NotImplementedException();
			}
			public object once(object @event)
			{
				throw new System.NotImplementedException();
			}
			public object once(string @event, Function fn, object context = default(object))
			{
				throw new System.NotImplementedException();
			}
			public object off(string @event, Function fn, object context = default(object))
			{
				throw new System.NotImplementedException();
			}
		}

				public class CanvasMaskManager
		{
			public CanvasMaskManager(CanvasRenderer renderer)
			{
				
			}
			protected CanvasMaskManager()
			{
				
			}
			public protected renderGraphicsShape;
			public Graphics graphics;
			public void pushMask(object maskData)
			{
				throw new System.NotImplementedException();
			}
			public void popMask(Any<WebGLRenderer, CanvasRenderer> renderer)
			{
				throw new System.NotImplementedException();
			}
			public void destroy()
			{
				throw new System.NotImplementedException();
			}
		}

				public class CanvasRenderTarget
		{
			public CanvasRenderTarget(float width, float height, float resolution)
			{
				
			}
			protected CanvasRenderTarget()
			{
				
			}
			public HTMLCanvasElement canvas;
			public CanvasRenderingContext2D context;
			public float resolution;
			public float width;
			public float height;
			public void clear()
			{
				throw new System.NotImplementedException();
			}
			public void resize(float width, float height)
			{
				throw new System.NotImplementedException();
			}
			public void destroy()
			{
				throw new System.NotImplementedException();
			}
		}

				public class IWebGLRendererOptions
		{
			protected IWebGLRendererOptions()
			{
				
			}
			public HTMLCanvasElement view;
			public bool transparent;
			public bool autoResize;
			public bool antialias;
			public bool forceFXAA;
			public float resolution;
			public bool clearBeforeRender;
			public bool preserveDrawingBuffer;
			public bool roundPixels;
			public bool legacy;
		}

				public class WebGLRenderer : SystemRenderer
		{
			public WebGLRenderer(float screenWidth = default(float), float screenHeight = default(float), IWebGLRendererOptions options = default(IWebGLRendererOptions)) : base()
			{
				
			}
			protected WebGLRenderer() : base()
			{
				
			}
			public static Object __plugins;
			public object plugins;
			public interaction.InteractionManager interaction;
			public protected _contextOptions;
			public bool alpha;
			public bool antiAlias;
			public bool premultipliedAlpha;
			public bool stencil;
			public bool preseveDrawingBuffer;
			public static void registerPlugin(string pluginName, Function ctor)
			{
				throw new System.NotImplementedException();
			}
			public void initPlugins()
			{
				throw new System.NotImplementedException();
			}
			public void destroyPlugins()
			{
				throw new System.NotImplementedException();
			}
		}

				public static class settings
		{
			public static float TARGET_FPMS;
			public static bool MIPMAP_TEXTURES;
			public static float RESOLUTION;
			public static float FILTER_RESOLUTION;
			public static float SPRITE_MAX_TEXTURES;
			public static float SPRITE_BATCH_SIZE;
			public static RegExp RETINA_PREFIX;
			public static RENDER_OPTIONS_0_ RENDER_OPTIONS;
			public static float TRANSFORM_MODE;
			public static float GC_MODE;
			public static float GC_MAX_IDLE;
			public static float GC_MAX_CHECK_COUNT;
			public static float WRAP_MODE;
			public static float SCALE_MODE;
			public static string PRECISION;
			public static float UPLOADS_PER_FRAME;
			public static bool CAN_UPLOAD_SAME_BUFFER;

						public class RENDER_OPTIONS_0_
			{
				public Any<HTMLCanvasElement, null> view;
				public bool antialias;
				public bool forceFXAA;
				public bool autoResize;
				public bool transparent;
				public float backgroundColor;
				public bool clearBeforeRender;
				public bool preserveDrawingBuffer;
				public bool roundPixels;
			}
		}

				public static class accessibility
		{

						public class AccessibilityManager
			{
				public AccessibilityManager(Any<CanvasRenderer, WebGLRenderer> renderer)
				{
					
				}
				protected AccessibilityManager()
				{
					
				}
				public protected div;
				public protected pool;
				public protected renderId;
				public bool debug;
				public SystemRenderer renderer;
				public protected children;
				public protected isActive;
				public protected activate;
				public protected deactivate;
				public protected updateAccessibleObjects;
				public DisplayObject displayObject;
				public protected update;
				public protected capHitArea;
				public IHitArea hitArea;
				public protected addChild;
				public protected _onClick;
				public interaction.InteractionEvent e;
				public protected _onFocus;
				public protected _onFocusOut;
				public protected _onKeyDown;
				public protected _onMouseMove;
				public void destroy()
				{
					throw new System.NotImplementedException();
				}
			}

						public class IAccessibleTarget
			{
				protected IAccessibleTarget()
				{
					
				}
				public bool accessible;
				public Any<string, null> accessibleTitle;
				public Any<string, null> accessibleHint;
				public float tabIndex;
			}
		}

				public static class CONST
		{
			public static string VERSION;
			public static float PI_2;
			public static float RAD_TO_DEG;
			public static float DEG_TO_RAD;
			public static float TARGET_FPMS;
			public static RENDERER_TYPE_0_ RENDERER_TYPE;
			public static BLEND_MODES_0_ BLEND_MODES;
			public static DRAW_MODES_0_ DRAW_MODES;
			public static SCALE_MODES_0_ SCALE_MODES;
			public static GC_MODES_0_ GC_MODES;
			public static WRAP_MODES_0_ WRAP_MODES;
			public static TRANSFORM_MODE_0_ TRANSFORM_MODE;
			public static Any<RegExp, string> URL_FILE_EXTENSION;
			public static Any<RegExp, string> DATA_URI;
			public static Any<RegExp, string> SVG_SIZE;
			public static SHAPES_0_ SHAPES;
			public static PRECISION_0_ PRECISION;
			public static TEXT_GRADIENT_0_ TEXT_GRADIENT;

						public class RENDERER_TYPE_0_
			{
				public float UNKNOWN;
				public float WEBGL;
				public float CANVAS;
			}

						public class BLEND_MODES_0_
			{
				public float NORMAL;
				public float ADD;
				public float MULTIPLY;
				public float SCREEN;
				public float OVERLAY;
				public float DARKEN;
				public float LIGHTEN;
				public float COLOR_DODGE;
				public float COLOR_BURN;
				public float HARD_LIGHT;
				public float SOFT_LIGHT;
				public float DIFFERENCE;
				public float EXCLUSION;
				public float HUE;
				public float SATURATION;
				public float COLOR;
				public float LUMINOSITY;
			}

						public class DRAW_MODES_0_
			{
				public float POINTS;
				public float LINES;
				public float LINE_LOOP;
				public float LINE_STRIP;
				public float TRIANGLES;
				public float TRIANGLE_STRIP;
				public float TRIANGLE_FAN;
			}

						public class SCALE_MODES_0_
			{
				public float LINEAR;
				public float NEAREST;
			}

						public class GC_MODES_0_
			{
				public float AUTO;
				public float MANUAL;
			}

						public class WRAP_MODES_0_
			{
				public float CLAMP;
				public float MIRRORED_REPEAT;
				public float REPEAT;
			}

						public class TRANSFORM_MODE_0_
			{
				public float DEFAULT;
				public float DYNAMIC;
				public float STATIC;
			}

						public class SHAPES_0_
			{
				public float POLY;
				public float RECT;
				public float CIRC;
				public float ELIP;
				public float RREC;
			}

						public class PRECISION_0_
			{
				public string LOW;
				public string MEDIUM;
				public string HIGH;
			}

						public class TEXT_GRADIENT_0_
			{
				public float LINEAR_VERTICAL;
				public float LINEAR_HORIZONTAL;
			}
		}

				public static class GroupD8
		{
			public static float E;
			public static float SE;
			public static float S;
			public static float SW;
			public static float W;
			public static float NW;
			public static float N;
			public static float NE;
			public static float MIRROR_HORIZONTAL;
			public static float MIRROR_VERTICAL;
			public static float uX(float ind)
			{
				throw new System.NotImplementedException();
			}
			public static float uY(float ind)
			{
				throw new System.NotImplementedException();
			}
			public static float vX(float ind)
			{
				throw new System.NotImplementedException();
			}
			public static float vY(float ind)
			{
				throw new System.NotImplementedException();
			}
			public static float inv(float rotation)
			{
				throw new System.NotImplementedException();
			}
			public static float add(float rotationSecond, float rotationFirst)
			{
				throw new System.NotImplementedException();
			}
			public static float sub(float rotationSecond, float rotationFirst)
			{
				throw new System.NotImplementedException();
			}
			public static float rotate180(float rotation)
			{
				throw new System.NotImplementedException();
			}
			public static bool isSwapWidthHeight(float rotation)
			{
				throw new System.NotImplementedException();
			}
			public static float byDirection(float dx, float dy)
			{
				throw new System.NotImplementedException();
			}
			public static void matrixAppendRotationInv(Matrix matrix, float rotation, float tx, float ty)
			{
				throw new System.NotImplementedException();
			}
		}
	}
}

public static class GLOBAL
{
	public static protected _canvasRenderTarget;
	public static float n;

		public class SpriteMaskFilter : Filter
	{
		public SpriteMaskFilter(Sprite sprite) : base()
		{
			
		}
		protected SpriteMaskFilter() : base()
		{
			
		}
		public Sprite maskSprite;
		public Matrix maskMatrix;
		public void apply(FilterManager filterManager, RenderTarget input, RenderTarget output)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Sprite : Container
	{
		public Sprite(Texture texture = default(Texture)) : base()
		{
			
		}
		protected Sprite() : base()
		{
			
		}
		public protected _anchor;
		public ObservablePoint anchor;
		public protected _texture;
		public protected _transformTrimmedID;
		public protected _textureTrimmedID;
		public protected _width;
		public protected _height;
		public float tint;
		public protected _tint;
		public protected _tintRGB;
		public float blendMode;
		public string pluginName;
		public protected cachedTint;
		public Texture texture;
		public protected textureDirty;
		public protected _textureID;
		public protected _transformID;
		public protected vertexTrimmedData;
		public Bridge.Html5.Float32Array vertexData;
		public float width;
		public float height;
		public protected _onTextureUpdate;
		public protected _calculateBounds;
		public protected calculateTrimmedVertices;
		public protected onAnchorUpdate;
		public protected _renderWebGL;
		public CanvasRenderer renderer;
		public protected _renderCanvas;
		public void calculateVertices()
		{
			throw new System.NotImplementedException();
		}
		public Rectangle getLocalBounds()
		{
			throw new System.NotImplementedException();
		}
		public bool containsPoint(Point point)
		{
			throw new System.NotImplementedException();
		}
		public void destroy(Any<IDestroyOptions, bool> options = default(Any<IDestroyOptions, bool>))
		{
			throw new System.NotImplementedException();
		}
		public static Sprite from(Any<float, string, BaseTexture, HTMLImageElement, HTMLCanvasElement, HTMLVideoElement> source)
		{
			throw new System.NotImplementedException();
		}
		public static Sprite fromFrame(string frameId)
		{
			throw new System.NotImplementedException();
		}
		public static Sprite fromImage(string imageId, bool crossorigin = default(bool), float scaleMode = default(float))
		{
			throw new System.NotImplementedException();
		}
	}

		public class BatchBuffer
	{
		protected BatchBuffer()
		{
			
		}
		public Bridge.Html5.ArrayBuffer vertices;
		public float[] float32View;
		public float[] uint32View;
		public void destroy()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SpriteRenderer : ObjectRenderer
	{
		public SpriteRenderer(PIXI.WebGLRenderer renderer) : base()
		{
			
		}
		protected SpriteRenderer() : base()
		{
			
		}
		public float vertSize;
		public float vertByteSize;
		public float size;
		public BatchBuffer[] buffers;
		public float[] indices;
		public Shader[] shaders;
		public float currentIndex;
		public float tick;
		public object[] groups;
		public Sprite[] sprites;
		public float[] vertexBuffers;
		public glCore.VertexArrayObject vaos;
		public float vaoMax;
		public float vertexCount;
		public protected onContextChanged;
		public object void;
		public protected onPrerender;
		public void render(Sprite sprite)
		{
			throw new System.NotImplementedException();
		}
		public void flush()
		{
			throw new System.NotImplementedException();
		}
		public void start()
		{
			throw new System.NotImplementedException();
		}
		public void stop()
		{
			throw new System.NotImplementedException();
		}
		public void destroy()
		{
			throw new System.NotImplementedException();
		}
	}

		public class CanvasSpriteRenderer : ObjectRenderer
	{
		public CanvasSpriteRenderer(WebGLRenderer renderer) : base()
		{
			
		}
		protected CanvasSpriteRenderer() : base()
		{
			
		}
		public void render(Sprite sprite)
		{
			throw new System.NotImplementedException();
		}
		public void destroy()
		{
			throw new System.NotImplementedException();
		}
	}

		public class TextStyleOptions
	{
		protected TextStyleOptions()
		{
			
		}
		public string align;
		public bool breakWords;
		public bool dropShadow;
		public float dropShadowAlpha;
		public float dropShadowAngle;
		public float dropShadowBlur;
		public Any<string, float> dropShadowColor;
		public float dropShadowDistance;
		public Any<string, string[], float, float[], CanvasGradient, CanvasPattern> fill;
		public float fillGradientType;
		public float[] fillGradientStops;
		public Any<string, string[]> fontFamily;
		public Any<float, string> fontSize;
		public string fontStyle;
		public string fontVariant;
		public string fontWeight;
		public float letterSpacing;
		public float lineHeight;
		public string lineJoin;
		public float miterLimit;
		public float padding;
		public Any<string, float> stroke;
		public float strokeThickness;
		public string textBaseline;
		public bool trim;
		public bool wordWrap;
		public float wordWrapWidth;
	}

		public class TextStyle : TextStyleOptions
	{
		public TextStyle(TextStyleOptions style)
		{
			
		}
		protected TextStyle()
		{
			
		}
		public float styleID;
		public protected _align;
		public string align;
		public protected _breakWords;
		public bool breakWords;
		public protected _dropShadow;
		public bool dropShadow;
		public protected _dropShadowAlpha;
		public float dropShadowAlpha;
		public protected _dropShadowAngle;
		public float dropShadowAngle;
		public protected _dropShadowBlur;
		public float dropShadowBlur;
		public protected _dropShadowColor;
		public Any<string, float> dropShadowColor;
		public protected _dropShadowDistance;
		public float dropShadowDistance;
		public protected _fill;
		public Any<string, string[], float, float[], CanvasGradient, CanvasPattern> fill;
		public protected _fillGradientType;
		public float fillGradientType;
		public protected _fillGradientStops;
		public float[] fillGradientStops;
		public protected _fontFamily;
		public Any<string, string[]> fontFamily;
		public protected _fontSize;
		public Any<float, string> fontSize;
		public protected _fontStyle;
		public string fontStyle;
		public protected _fontVariant;
		public string fontVariant;
		public protected _fontWeight;
		public string fontWeight;
		public protected _letterSpacing;
		public float letterSpacing;
		public protected _lineHeight;
		public float lineHeight;
		public protected _lineJoin;
		public string lineJoin;
		public protected _miterLimit;
		public float miterLimit;
		public protected _padding;
		public float padding;
		public protected _stroke;
		public Any<string, float> stroke;
		public protected _strokeThickness;
		public float strokeThickness;
		public protected _textBaseline;
		public string textBaseline;
		public protected _trim;
		public bool trim;
		public protected _wordWrap;
		public bool wordWrap;
		public protected _wordWrapWidth;
		public float wordWrapWidth;
		public TextStyle clone()
		{
			throw new System.NotImplementedException();
		}
		public void reset()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Text : Sprite
	{
		public Text(string text = default(string), TextStyleOptions style = default(TextStyleOptions), HTMLCanvasElement canvas = default(HTMLCanvasElement)) : base()
		{
			
		}
		protected Text() : base()
		{
			
		}
		public HTMLCanvasElement canvas;
		public CanvasRenderingContext2D context;
		public float resolution;
		public protected _text;
		public protected _style;
		public protected _styleListener;
		public protected _font;
		public protected localStyleID;
		public static object fontPropertiesCache;
		public static HTMLCanvasElement fontPropertiesCanvas;
		public static CanvasRenderingContext2D fontPropertiesContext;
		public float width;
		public float height;
		public TextStyle style;
		public string text;
		public protected updateText;
		public bool respectDirty;
		public protected drawLetterSpacing;
		public float x;
		public float y;
		public bool isStroke;
		public protected updateTexture;
		public protected _renderCanvas;
		public CanvasRenderer renderer;
		public protected wordWrap;
		public protected _calculateBounds;
		public protected _onStyleChange;
		public object void;
		public protected _generateFillStyle;
		public string[] lines;
		public bool dirty;
		public static string getFontStyle(TextStyleOptions style)
		{
			throw new System.NotImplementedException();
		}
		public static object calculateFontProperties(string style)
		{
			throw new System.NotImplementedException();
		}
		public void renderWebGL(WebGLRenderer renderer)
		{
			throw new System.NotImplementedException();
		}
		public Rectangle getLocalBounds(Rectangle rect = default(Rectangle))
		{
			throw new System.NotImplementedException();
		}
		public void destroy(Any<IDestroyOptions, bool> options = default(Any<IDestroyOptions, bool>))
		{
			throw new System.NotImplementedException();
		}
	}

		public class BaseRenderTexture : BaseTexture
	{
		public BaseRenderTexture(float width = default(float), float height = default(float), float scaleMode = default(float), float resolution = default(float)) : base()
		{
			
		}
		protected BaseRenderTexture() : base()
		{
			
		}
		public float height;
		public float width;
		public float realHeight;
		public float realWidth;
		public float resolution;
		public float scaleMode;
		public bool hasLoaded;
		public protected _glRenderTargets;
		public float n;
	}

		public static class CanvasTinter
	{
		public static float cacheStepsPerColorChannel;
		public static bool convertTintToImage;
		public static bool canUseMultiply;
		public static Function tintMethod;
		public static HTMLCanvasElement getTintedTexture(Sprite sprite, float color)
		{
			throw new System.NotImplementedException();
		}
		public static void tintWithMultiply(Texture texture, float color, HTMLCanvasElement canvas)
		{
			throw new System.NotImplementedException();
		}
		public static void tintWithOverlay(Texture texture, float color, HTMLCanvasElement canvas)
		{
			throw new System.NotImplementedException();
		}
		public static void tintWithPerPixel(Texture texture, float color, HTMLCanvasElement canvas)
		{
			throw new System.NotImplementedException();
		}
		public static float roundColor(float color)
		{
			throw new System.NotImplementedException();
		}
	}
}

public static class GLOBAL
{
	public static bool valid;
	public static Action<BaseRenderTexture> fn;
	public static object context;
	public static void resize(float width, float height)
	{
		throw new System.NotImplementedException();
	}
	public static void destroy()
	{
		throw new System.NotImplementedException();
	}
	public static object once(object @event)
	{
		throw new System.NotImplementedException();
	}
	public static object once(string @event, Function fn, object context = default(object))
	{
		throw new System.NotImplementedException();
	}
	public static object on(object @event)
	{
		throw new System.NotImplementedException();
	}
	public static object on(string @event, Function fn, object context = default(object))
	{
		throw new System.NotImplementedException();
	}
	public static object off(string @event, Function fn, object context = default(object))
	{
		throw new System.NotImplementedException();
	}
}

namespace GLOBAL
{

		public class BaseTexture : utils.EventEmitter
	{
		public BaseTexture(Any<HTMLImageElement, HTMLCanvasElement, HTMLVideoElement> source = default(Any<HTMLImageElement, HTMLCanvasElement, HTMLVideoElement>), float scaleMode = default(float), float resolution = default(float)) : base()
		{
			
		}
		protected BaseTexture() : base()
		{
			
		}
		public protected uuid;
		public protected touched;
		public float resolution;
		public float width;
		public float height;
		public float realWidth;
		public float realHeight;
		public float scaleMode;
		public bool hasLoaded;
		public bool isLoading;
		public float wrapMode;
		public Any<HTMLImageElement, HTMLCanvasElement, HTMLVideoElement> source;
		public Any<HTMLImageElement, null> origSource;
		public Any<string, null> imageType;
		public float sourceScale;
		public bool premultipliedAlpha;
		public Any<string, null> imageUrl;
		public protected isPowerOfTwo;
		public bool mipmap;
		public bool wrap;
		public protected _glTextures;
		public protected _enabled;
		public protected _id;
		public protected _updateDimensions;
		public protected _updateImageType;
		public protected _loadSvgSource;
		public protected _loadSvgSourceUsingDataUri;
		public string dataUri;
		public protected _loadSvgSourceUsingXhr;
		public protected _loadSvgSourceUsingString;
		public string svgString;
		public protected loadSource;
		public protected _sourceLoaded;
		public Action<BaseTexture> fn;
		public object context;
		public static BaseTexture from(Any<string, HTMLImageElement, HTMLCanvasElement> source, float scaleMode = default(float), float sourceScale = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void destroy()
		{
			throw new System.NotImplementedException();
		}
		public void dispose()
		{
			throw new System.NotImplementedException();
		}
		public void updateSourceImage(string newSrc)
		{
			throw new System.NotImplementedException();
		}
		public static BaseTexture fromImage(string imageUrl, bool crossorigin = default(bool), float scaleMode = default(float), float sourceScale = default(float))
		{
			throw new System.NotImplementedException();
		}
		public static BaseTexture fromCanvas(HTMLCanvasElement canvas, float scaleMode = default(float))
		{
			throw new System.NotImplementedException();
		}
		public object on(object @event)
		{
			throw new System.NotImplementedException();
		}
		public object on(string @event, Function fn, object context = default(object))
		{
			throw new System.NotImplementedException();
		}
		public object once(object @event)
		{
			throw new System.NotImplementedException();
		}
		public object once(string @event, Function fn, object context = default(object))
		{
			throw new System.NotImplementedException();
		}
		public object off(string @event, Function fn, object context = default(object))
		{
			throw new System.NotImplementedException();
		}
	}

		public class RenderTexture : Texture
	{
		public RenderTexture(BaseRenderTexture baseRenderTexture, Rectangle frame = default(Rectangle)) : base()
		{
			
		}
		protected RenderTexture() : base()
		{
			
		}
		public protected legacyRenderer;
		public bool valid;
		public void resize(float width, float height, bool doNotResizeBaseTexture = default(bool))
		{
			throw new System.NotImplementedException();
		}
		public static RenderTexture create(float width = default(float), float height = default(float), float scaleMode = default(float), float resolution = default(float))
		{
			throw new System.NotImplementedException();
		}
	}

		public class Texture : utils.EventEmitter
	{
		public Texture(BaseTexture baseTexture, Rectangle frame = default(Rectangle), Rectangle orig = default(Rectangle), Rectangle trim = default(Rectangle), float rotate = default(float)) : base()
		{
			
		}
		protected Texture() : base()
		{
			
		}
		public bool noFrame;
		public BaseTexture baseTexture;
		public protected _frame;
		public Rectangle trim;
		public bool valid;
		public bool requiresUpdate;
		public protected _uvs;
		public Rectangle orig;
		public protected _updateID;
		public object transform;
		public protected onBaseTextureLoaded;
		public protected onBaseTextureUpdated;
		public protected _updateUvs;
		public Rectangle frame;
		public protected _rotate;
		public float rotate;
		public float width;
		public float height;
		public static Texture EMPTY;
		public Action<Texture> fn;
		public object context;
		public static Texture from(Any<float, string, HTMLImageElement, HTMLCanvasElement, HTMLVideoElement, PIXI.BaseTexture> source)
		{
			throw new System.NotImplementedException();
		}
		public static Texture from(Any<string, BaseTexture, HTMLImageElement, HTMLCanvasElement, HTMLVideoElement> source)
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void destroy(bool destroyBase = default(bool))
		{
			throw new System.NotImplementedException();
		}
		public Texture clone()
		{
			throw new System.NotImplementedException();
		}
		public static Texture fromImage(string imageUrl, bool crossOrigin = default(bool), float scaleMode = default(float), float sourceScale = default(float))
		{
			throw new System.NotImplementedException();
		}
		public static Texture fromFrame(string frameId)
		{
			throw new System.NotImplementedException();
		}
		public static Texture fromCanvas(HTMLCanvasElement canvas, float scaleMode = default(float))
		{
			throw new System.NotImplementedException();
		}
		public static Texture fromVideo(Any<HTMLVideoElement, string> video, float scaleMode = default(float))
		{
			throw new System.NotImplementedException();
		}
		public static Texture fromVideoUrl(string videoUrl, float scaleMode = default(float))
		{
			throw new System.NotImplementedException();
		}
		public static Texture fromLoader(Any<HTMLImageElement, HTMLCanvasElement> source, string imageUrl, string name = default(string))
		{
			throw new System.NotImplementedException();
		}
		public static void addTextureToCache(Texture texture, string id)
		{
			throw new System.NotImplementedException();
		}
		public static Any<Texture, undefined> removeTextureFromCache(string id)
		{
			throw new System.NotImplementedException();
		}
		public object on(object @event)
		{
			throw new System.NotImplementedException();
		}
		public object on(string @event, Function fn, object context = default(object))
		{
			throw new System.NotImplementedException();
		}
		public object once(object @event)
		{
			throw new System.NotImplementedException();
		}
		public object once(string @event, Function fn, object context = default(object))
		{
			throw new System.NotImplementedException();
		}
		public object off(string @event, Function fn, object context = default(object))
		{
			throw new System.NotImplementedException();
		}
	}

		public class TextureUvs
	{
		protected TextureUvs()
		{
			
		}
		public float x0;
		public float y0;
		public float x1;
		public float y1;
		public float x2;
		public float y2;
		public float x3;
		public float y3;
		public Bridge.Html5.Uint32Array uvsUint32;
		public protected set;
		public Rectangle frame;
		public Rectangle baseFrame;
		public float rotate;
	}

		public class Spritesheet
	{
		public Spritesheet(BaseTexture baseTexture, object data, string resolutionFilename = default(string))
		{
			
		}
		protected Spritesheet()
		{
			
		}
		public static float BATCH_SIZE;
		public BaseTexture baseTexture;
		public Textures_1_ textures;
		public object data;
		public float resolution;
		public protected _frames;
		public protected _frameKeys;
		public protected _batchIndex;
		public protected _callback;
		public object spriteSheet;
		public object void;
		public protected _updateResolution;
		public string resolutionFilename;
		public protected _processFrames;
		public float initialFrameIndex;
		public protected _parseComplete;
		public protected _nextBatch;
		public void parse(Action<object, Textures_3_> callback)
		{
			throw new System.NotImplementedException();
		}
		public void destroy(bool destroyBase = default(bool))
		{
			throw new System.NotImplementedException();
		}

				public class Textures_0_
		{
			
			public Texture this[string index]
			{
				get
				{
					return (Texture)((dynamic)this)[index];
				}				
				set
				{
					((dynamic)this)[index] = value;
				}
			}
			
		}

				public class Textures_1_
		{
			
			public Texture this[string index]
			{
				get
				{
					return (Texture)((dynamic)this)[index];
				}				
				set
				{
					((dynamic)this)[index] = value;
				}
			}
			
		}

				public class Textures_2_
		{
			
			public Texture this[string index]
			{
				get
				{
					return (Texture)((dynamic)this)[index];
				}				
				set
				{
					((dynamic)this)[index] = value;
				}
			}
			
		}

				public class Textures_3_
		{
			
			public Texture this[string index]
			{
				get
				{
					return (Texture)((dynamic)this)[index];
				}				
				set
				{
					((dynamic)this)[index] = value;
				}
			}
			
		}
	}

		public class VideoBaseTexture : BaseTexture
	{
		public VideoBaseTexture(HTMLVideoElement source, float scaleMode = default(float)) : base()
		{
			
		}
		protected VideoBaseTexture() : base()
		{
			
		}
		public bool autoUpdate;
		public bool autoPlay;
		public protected _isAutoUpdating;
		public protected _onCanPlay;
		public protected _onPlayStart;
		public protected _onPlayStop;
		public protected _isSourcePlaying;
		public protected _isSourceReady;
		public HTMLVideoElement source;
		public protected loadSource;
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void destroy()
		{
			throw new System.NotImplementedException();
		}
		public static VideoBaseTexture fromVideo(HTMLVideoElement video, float scaleMode = default(float))
		{
			throw new System.NotImplementedException();
		}
		public static VideoBaseTexture fromUrl(Any<string, object, string[], object[]> videoSrc)
		{
			throw new System.NotImplementedException();
		}
		public static VideoBaseTexture fromUrls(Any<string, object, string[], object[]> videoSrc)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Shader : glCore.GLShader
	{
		protected Shader() : base()
		{
			
		}
	}

		public class MiniSignalBinding
	{
		public MiniSignalBinding(Function fn, bool once = default(bool), object thisArg = default(object))
		{
			
		}
		protected MiniSignalBinding()
		{
			
		}
		public protected _fn;
		public protected _once;
		public protected _thisArg;
		public protected _next;
		public protected _prev;
		public protected _owner;
		public bool detach()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MiniSignal
	{
		public MiniSignal()
		{
			
		}
		public protected _head;
		public protected _tail;
		public Any<MiniSignalBinding[], bool> handlers(bool exists = default(bool))
		{
			throw new System.NotImplementedException();
		}
		public bool handlers(true exists = default(true))
		{
			throw new System.NotImplementedException();
		}
		public MiniSignalBinding[] handlers(false exists = default(false))
		{
			throw new System.NotImplementedException();
		}
		public bool has(MiniSignalBinding node)
		{
			throw new System.NotImplementedException();
		}
		public bool dispatch()
		{
			throw new System.NotImplementedException();
		}
		public object add(Function fn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public object once(Function fn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public MiniSignal detach(MiniSignalBinding node)
		{
			throw new System.NotImplementedException();
		}
		public MiniSignal detachAll()
		{
			throw new System.NotImplementedException();
		}
	}

		public class CanvasMeshRenderer
	{
		public CanvasMeshRenderer(CanvasRenderer renderer)
		{
			
		}
		protected CanvasMeshRenderer()
		{
			
		}
		public CanvasRenderer renderer;
		public protected _renderTriangleMesh;
		public Mesh mesh;
		public protected _renderTriangles;
		public protected _renderDrawTriangle;
		public float index0;
		public float index1;
		public float index2;
		public protected renderMeshFlat;
		public void render(Mesh mesh)
		{
			throw new System.NotImplementedException();
		}
		public void destroy()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MeshRenderer : ObjectRenderer
	{
		public MeshRenderer(WebGLRenderer renderer) : base()
		{
			
		}
		protected MeshRenderer() : base()
		{
			
		}
		public Shader shader;
		public void render(Mesh mesh)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Plane : Mesh
	{
		public Plane(Texture texture, float verticesX = default(float), float verticesY = default(float)) : base()
		{
			
		}
		protected Plane() : base()
		{
			
		}
		public protected _ready;
		public float verticesX;
		public float verticesY;
		public float drawMode;
		public protected _onTexureUpdate;
		public void refresh()
		{
			throw new System.NotImplementedException();
		}
	}

		public class NineSlicePlane : Plane
	{
		public NineSlicePlane(Texture texture, float leftWidth = default(float), float topHeight = default(float), float rightWidth = default(float), float bottomHeight = default(float)) : base()
		{
			
		}
		protected NineSlicePlane() : base()
		{
			
		}
		public float width;
		public float height;
		public float leftWidth;
		public float rightWidth;
		public float topHeight;
		public float bottomHeight;
		public protected _leftWidth;
		public protected _rightWidth;
		public protected _topHeight;
		public protected _bottomHeight;
		public protected _height;
		public protected _width;
		public protected _origHeight;
		public protected _origWidth;
		public protected _uvh;
		public protected _uvw;
		public protected drawSegment;
		public Any<CanvasRenderingContext2D, IWebGLRenderingContext> context;
		public object textureSource;
		public float w;
		public float h;
		public float x1;
		public float y1;
		public float x2;
		public float y2;
		public void updateHorizontalVertices()
		{
			throw new System.NotImplementedException();
		}
		public void updateVerticalVertices()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Rope : Mesh
	{
		public Rope(Texture texture, Point[] points) : base()
		{
			
		}
		protected Rope() : base()
		{
			
		}
		public Point[] points;
		public float[] colors;
		public protected _ready;
		public protected _onTextureUpdate;
		public void refresh()
		{
			throw new System.NotImplementedException();
		}
		public void updateTransform()
		{
			throw new System.NotImplementedException();
		}
	}

		public static class ticker
	{
		public static Ticker shared;

				public class Ticker
		{
			protected Ticker()
			{
				
			}
			public protected _tick;
			public float time;
			public protected _emitter;
			public protected _requestId;
			public protected _maxElapsedMS;
			public protected _requestIfNeeded;
			public protected _cancelIfNeeded;
			public protected _startIfPossible;
			public bool autoStart;
			public float deltaTime;
			public float elapsedMS;
			public float lastTime;
			public float speed;
			public bool started;
			public float FPS;
			public float minFPS;
			public Ticker add(Action<float> fn, object context = default(object))
			{
				throw new System.NotImplementedException();
			}
			public Ticker addOnce(Action<float> fn, object context = default(object))
			{
				throw new System.NotImplementedException();
			}
			public Ticker remove(Action<float> fn, object context = default(object))
			{
				throw new System.NotImplementedException();
			}
			public void start()
			{
				throw new System.NotImplementedException();
			}
			public void stop()
			{
				throw new System.NotImplementedException();
			}
			public void update()
			{
				throw new System.NotImplementedException();
			}
		}
	}

	namespace extract
	{

				public class CanvasExtract
		{
			public CanvasExtract(CanvasRenderer renderer)
			{
				
			}
			protected CanvasExtract()
			{
				
			}
			public protected renderer;
			public HTMLImageElement image(Any<DisplayObject, RenderTexture> target = default(Any<DisplayObject, RenderTexture>))
			{
				throw new System.NotImplementedException();
			}
			public string base64(Any<DisplayObject, RenderTexture> target = default(Any<DisplayObject, RenderTexture>))
			{
				throw new System.NotImplementedException();
			}
			public HTMLCanvasElement canvas(Any<DisplayObject, RenderTexture> target = default(Any<DisplayObject, RenderTexture>))
			{
				throw new System.NotImplementedException();
			}
			public float[] pixels(Any<DisplayObject, RenderTexture> renderTexture = default(Any<DisplayObject, RenderTexture>))
			{
				throw new System.NotImplementedException();
			}
			public void destroy()
			{
				throw new System.NotImplementedException();
			}
		}

				public class WebGLExtract
		{
			public WebGLExtract(WebGLRenderer renderer)
			{
				
			}
			protected WebGLExtract()
			{
				
			}
			public protected renderer;
			public HTMLImageElement image(Any<DisplayObject, RenderTexture> target = default(Any<DisplayObject, RenderTexture>))
			{
				throw new System.NotImplementedException();
			}
			public string base64(Any<DisplayObject, RenderTexture> target = default(Any<DisplayObject, RenderTexture>))
			{
				throw new System.NotImplementedException();
			}
			public HTMLCanvasElement canvas(Any<DisplayObject, RenderTexture> target = default(Any<DisplayObject, RenderTexture>))
			{
				throw new System.NotImplementedException();
			}
			public float[] pixels(Any<DisplayObject, RenderTexture> renderTexture = default(Any<DisplayObject, RenderTexture>))
			{
				throw new System.NotImplementedException();
			}
			public void destroy()
			{
				throw new System.NotImplementedException();
			}
		}
	}

	namespace extras
	{

				public class IBitmapTextStyle
		{
			protected IBitmapTextStyle()
			{
				
			}
			public Any<string, Font_0_> font;
			public string align;
			public float tint;

						public class Font_0_
			{
				public string name;
				public float size;
			}
		}

				public class BitmapText : Container
		{
			public BitmapText(string text, IBitmapTextStyle style = default(IBitmapTextStyle)) : base()
			{
				
			}
			protected BitmapText() : base()
			{
				
			}
			public protected _textWidth;
			public protected _textHeight;
			public float textWidth;
			public float textHeight;
			public protected _glyphs;
			public protected _font;
			public Any<string, Font_1_> font;
			public protected _text;
			public float maxWidth;
			public float maxLineHeight;
			public protected _anchor;
			public bool dirty;
			public float tint;
			public string align;
			public string text;
			public PIXI.Point.number anchor;
			public protected updateText;
			public protected validate;
			public static object fonts;
			public static object registerFont(XMLDocument xml, Texture texture)
			{
				throw new System.NotImplementedException();
			}
			public void updateTransform()
			{
				throw new System.NotImplementedException();
			}
			public Rectangle getLocalBounds()
			{
				throw new System.NotImplementedException();
			}

						public class _font_0_
			{
				public string name;
				public float size;
			}

						public class Font_1_
			{
				public string name;
				public float size;
			}
		}

				public class AnimatedSprite : Sprite
		{
			public AnimatedSprite(Any<Texture[], Textures_5_[]> textures, bool autoUpdate = default(bool)) : base()
			{
				
			}
			protected AnimatedSprite() : base()
			{
				
			}
			public protected _autoUpdate;
			public protected _textures;
			public protected _durations;
			public Any<Texture[], Textures_6_[]> textures;
			public float animationSpeed;
			public bool loop;
			public Action onComplete;
			public Action<float> onFrameChange;
			public protected _currentTime;
			public bool playing;
			public float totalFrames;
			public float currentFrame;
			public protected update;
			public float deltaTime;
			public void stop()
			{
				throw new System.NotImplementedException();
			}
			public void play()
			{
				throw new System.NotImplementedException();
			}
			public void gotoAndStop(float frameNumber)
			{
				throw new System.NotImplementedException();
			}
			public void gotoAndPlay(float frameNumber)
			{
				throw new System.NotImplementedException();
			}
			public void destroy()
			{
				throw new System.NotImplementedException();
			}
			public static AnimatedSprite fromFrames(string[] frame)
			{
				throw new System.NotImplementedException();
			}
			public static AnimatedSprite fromImages(string[] images)
			{
				throw new System.NotImplementedException();
			}

						public class Textures_4_
			{
				public Texture texture;
				public float time;
			}

						public class Textures_5_
			{
				public Texture texture;
				public float time;
			}

						public class Textures_6_
			{
				public Texture texture;
				public float time;
			}
		}

				public class TextureTransform
		{
			public TextureTransform(Texture texture, float clampMargin = default(float))
			{
				
			}
			protected TextureTransform()
			{
				
			}
			public protected _texture;
			public protected mapCoord;
			public protected uClampFrame;
			public protected uClampOffset;
			public protected _lastTextureID;
			public float clampOffset;
			public float clampMargin;
			public Texture texture;
			public void update(bool forceUpdate = default(bool))
			{
				throw new System.NotImplementedException();
			}
		}

				public class TilingSprite : Sprite
		{
			public TilingSprite(Texture texture, float width = default(float), float height = default(float)) : base()
			{
				
			}
			protected TilingSprite() : base()
			{
				
			}
			public TransformStatic tileTransform;
			public protected _width;
			public protected _height;
			public protected _canvasPattern;
			public TextureTransform uvTransform;
			public bool uvRespectAnchor;
			public float clampMargin;
			public Any<Point, ObservablePoint> tileScale;
			public Any<Point, ObservablePoint> tilePosition;
			public protected _onTextureUpdate;
			public protected _renderWebGL;
			public CanvasRenderer renderer;
			public protected _renderCanvas;
			public protected _calculateBounds;
			public float width;
			public float height;
			public Rectangle getLocalBounds(Rectangle rect = default(Rectangle))
			{
				throw new System.NotImplementedException();
			}
			public bool containsPoint(Point point)
			{
				throw new System.NotImplementedException();
			}
			public void destroy()
			{
				throw new System.NotImplementedException();
			}
			public static TilingSprite from(Any<float, string, BaseTexture, HTMLCanvasElement, HTMLVideoElement> source, float width = default(float), float height = default(float))
			{
				throw new System.NotImplementedException();
			}
			public static TilingSprite fromFrame(string frameId, float width = default(float), float height = default(float))
			{
				throw new System.NotImplementedException();
			}
			public static Sprite fromImage(string imageId, bool crossorigin = default(bool), float scaleMode = default(float))
			{
				throw new System.NotImplementedException();
			}
			public static TilingSprite fromImage(string imageId, float width = default(float), float height = default(float), bool crossorigin = default(bool), float scaleMode = default(float))
			{
				throw new System.NotImplementedException();
			}
		}

				public class TilingSpriteRenderer : ObjectRenderer
		{
			public TilingSpriteRenderer(WebGLRenderer renderer) : base()
			{
				
			}
			protected TilingSpriteRenderer() : base()
			{
				
			}
			public void render(TilingSprite ts)
			{
				throw new System.NotImplementedException();
			}
		}
	}

	namespace filters
	{

				public class FXAAFilter : Filter
		{
			protected FXAAFilter() : base()
			{
				
			}
		}

				public class BlurFilter : Filter
		{
			public BlurFilter(float strength = default(float), float quality = default(float), float resolution = default(float), float kernelSize = default(float)) : base()
			{
				
			}
			protected BlurFilter() : base()
			{
				
			}
			public BlurXFilter blurXFilter;
			public BlurYFilter blurYFilter;
			public float resolution;
			public float padding;
			public float passes;
			public float blur;
			public float blurX;
			public float blurY;
			public float quality;
		}

				public class BlurXFilter : Filter
		{
			public BlurXFilter(float strength = default(float), float quality = default(float), float resolution = default(float), float kernelSize = default(float)) : base()
			{
				
			}
			protected BlurXFilter() : base()
			{
				
			}
			public protected _quality;
			public float quality;
			public float passes;
			public float resolution;
			public float strength;
			public bool firstRun;
			public float blur;
		}

				public class BlurYFilter : Filter
		{
			public BlurYFilter(float strength = default(float), float quality = default(float), float resolution = default(float), float kernelSize = default(float)) : base()
			{
				
			}
			protected BlurYFilter() : base()
			{
				
			}
			public protected _quality;
			public float quality;
			public float passes;
			public float resolution;
			public float strength;
			public bool firstRun;
			public float blur;
		}

				public class ColorMatrixFilter : Filter
		{
			public ColorMatrixFilter() : base()
			{
				
			}
			public protected _loadMatrix;
			public float[] matrix;
			public bool multiply;
			public protected _multiply;
			public float[] out;
			public float[] a;
			public float[] b;
			public protected _colorMatrix;
			public void brightness(float b, bool multiply = default(bool))
			{
				throw new System.NotImplementedException();
			}
			public void greyscale(float scale, bool multiply = default(bool))
			{
				throw new System.NotImplementedException();
			}
			public void blackAndWhite(bool multiply = default(bool))
			{
				throw new System.NotImplementedException();
			}
			public void hue(float rotation, bool multiply = default(bool))
			{
				throw new System.NotImplementedException();
			}
			public void contrast(float amount, bool multiply = default(bool))
			{
				throw new System.NotImplementedException();
			}
			public void saturate(float amount, bool multiply = default(bool))
			{
				throw new System.NotImplementedException();
			}
			public void desaturate(bool multiply = default(bool))
			{
				throw new System.NotImplementedException();
			}
			public void negative(bool multiply = default(bool))
			{
				throw new System.NotImplementedException();
			}
			public void sepia(bool multiply = default(bool))
			{
				throw new System.NotImplementedException();
			}
			public void technicolor(bool multiply = default(bool))
			{
				throw new System.NotImplementedException();
			}
			public void polaroid(bool multiply = default(bool))
			{
				throw new System.NotImplementedException();
			}
			public void toBGR(bool multiply = default(bool))
			{
				throw new System.NotImplementedException();
			}
			public void kodachrome(bool multiply = default(bool))
			{
				throw new System.NotImplementedException();
			}
			public void browni(bool multiply = default(bool))
			{
				throw new System.NotImplementedException();
			}
			public void vintage(bool multiply = default(bool))
			{
				throw new System.NotImplementedException();
			}
			public void colorTone(float desaturation, float toned, string lightColor, string darkColor, bool multiply = default(bool))
			{
				throw new System.NotImplementedException();
			}
			public void night(float intensity, bool multiply = default(bool))
			{
				throw new System.NotImplementedException();
			}
			public void predator(float amount, bool multiply = default(bool))
			{
				throw new System.NotImplementedException();
			}
			public void lsd(bool multiply = default(bool))
			{
				throw new System.NotImplementedException();
			}
			public void reset()
			{
				throw new System.NotImplementedException();
			}
		}

				public class DisplacementFilter : Filter
		{
			public DisplacementFilter(Sprite sprite, float scale = default(float)) : base()
			{
				
			}
			protected DisplacementFilter() : base()
			{
				
			}
			public Point scale;
			public Texture map;
		}

				public class VoidFilter : Filter
		{
			protected VoidFilter() : base()
			{
				
			}
			public float glShaderKey;
		}

				public class NoiseFilter : Filter
		{
			protected NoiseFilter() : base()
			{
				
			}
			public float noise;
		}
	}

	namespace interaction
	{

				public class InteractiveTarget
		{
			protected InteractiveTarget()
			{
				
			}
			public bool interactive;
			public bool interactiveChildren;
			public PIXI.Rectangle.PIXI.Circle.PIXI.Ellipse.PIXI.Polygon.PIXI.RoundedRectangle hitArea;
			public bool buttonMode;
			public string cursor;
			public string defaultCursor;
			public TrackedPointers_1_ trackedPointers()
			{
				throw new System.NotImplementedException();
			}

						public class TrackedPointers_1_
			{
				
				public InteractionTrackingData this[float index]
				{
					get
					{
						return (InteractionTrackingData)((dynamic)this)[index];
					}				
					set
					{
						((dynamic)this)[index] = value;
					}
				}
				
			}
		}

				public class InteractionTrackingData
		{
			protected InteractionTrackingData()
			{
				
			}
			public readonly pointerId;
			public float flags;
			public float none;
			public bool over;
			public bool rightDown;
			public bool leftDown;
		}

				public class InteractionEvent
		{
			protected InteractionEvent()
			{
				
			}
			public bool stopped;
			public DisplayObject target;
			public DisplayObject currentTarget;
			public string type;
			public InteractionData data;
			public void stopPropagation()
			{
				throw new System.NotImplementedException();
			}
		}

				public class InteractionData
		{
			protected InteractionData()
			{
				
			}
			public Point global;
			public DisplayObject target;
			public Event originalEvent;
			public float identifier;
			public Point getLocalPosition(DisplayObject displayObject, Point point = default(Point), Point globalPos = default(Point))
			{
				throw new System.NotImplementedException();
			}
		}

				public class InteractionManagerOptions
		{
			protected InteractionManagerOptions()
			{
				
			}
			public bool autoPreventDefault;
			public float interactionFrequency;
		}

				public class InteractionManager : utils.EventEmitter
		{
			public InteractionManager(Any<CanvasRenderer, WebGLRenderer, SystemRenderer> renderer, InteractionManagerOptions options = default(InteractionManagerOptions)) : base()
			{
				
			}
			protected InteractionManager() : base()
			{
				
			}
			public SystemRenderer renderer;
			public bool autoPreventDefault;
			public float interactionFrequency;
			public InteractionData mouse;
			public ActiveInteractionData_0_ activeInteractionData;
			public InteractionData[] interactionDataPool;
			public object eventData;
			public protected interactionDOMElement;
			public bool moveWhenInside;
			public bool eventsAdded;
			public protected mouseOverRenderer;
			public readonly supportsTouchEvents;
			public readonly supportsPointerEvents;
			public protected onPointerUp;
						public Any<TouchEvent, MouseEvent, PointerEvent> @event;
			public object void;
			public protected processPointerUp;
			public InteractionEvent interactionEvent;
			public PIXI.Container.PIXI.Sprite.PIXI.extras.TilingSprite displayObject;
			public bool hit;
			public protected onPointerCancel;
			public protected processPointerCancel;
			public protected onPointerDown;
			public protected processPointerDown;
			public protected onPointerMove;
			public protected processPointerMove;
			public protected onPointerOut;
			public protected processPointerOverOut;
			public protected onPointerOver;
			public CursorStyles_0_ cursorStyles;
			public string currentCursorMode;
			public string cursor;
			public protected _tempPoint;
			public float resolution;
			public protected setTargetElement;
			public HTMLCanvasElement element;
			public protected addEvents;
			public protected removeEvents;
			public protected dispatchEvent;
			public string eventString;
			public protected processInteractive;
			public Function func;
			public bool hitTest;
			public bool interactive;
			public protected onPointerComplete;
			public PointerEvent originalEvent;
			public bool cancelled;
			public protected getInteractionDataForPointerId;
			public float pointerId;
			public protected releaseInteractionDataForPointerId;
			public protected configureInteractionEventForDOMEvent;
			public PointerEvent pointerEvent;
			public InteractionData interactionData;
			public protected normalizeToPointerData;
			public string defaultCursorStyle;
			public string currentCursorStyle;
			public void update(float deltaTime = default(float))
			{
				throw new System.NotImplementedException();
			}
			public void setCursorMode(string mode)
			{
				throw new System.NotImplementedException();
			}
			public void mapPositionToPoint(Point point, float x, float y)
			{
				throw new System.NotImplementedException();
			}
			public void destroy()
			{
				throw new System.NotImplementedException();
			}

						public class ActiveInteractionData_0_
			{
				
				public InteractionData this[float index]
				{
					get
					{
						return (InteractionData)((dynamic)this)[index];
					}				
					set
					{
						((dynamic)this)[index] = value;
					}
				}
				
			}

						public class CursorStyles_0_
			{
				public string default;
				public string pointer;
			}
		}
	}

	namespace loaders
	{

				public class ILoaderOptions
		{
			protected ILoaderOptions()
			{
				
			}
			public Any<bool, string> crossOrigin;
			public float loadType;
			public string xhrType;
			public object metaData;
			public Any<HTMLImageElement, HTMLAudioElement, HTMLVideoElement> loadElement;
			public bool skipSource;
		}

				public class IResourceDictionary
		{
			protected IResourceDictionary()
			{
				
			}
			public string index;
		}

				public class Loader : utils.EventEmitter
		{
			public Loader(string baseUrl = default(string), float concurrency = default(float)) : base()
			{
				
			}
			protected Loader() : base()
			{
				
			}
			public static object Resource;
			public static object async;
			public static object base64;
			public string baseUrl;
			public float progress;
			public bool loading;
			public string defaultQueryString;
			public protected _beforeMiddleware;
			public protected _afterMiddleware;
			public protected _resourcesParsing;
			public protected _boundLoadResource;
			public Resource r;
			public Function d;
			public object void;
			public protected _queue;
			public IResourceDictionary resources;
			public MiniSignal onProgress;
			public MiniSignal onError;
			public MiniSignal onLoad;
			public MiniSignal onStart;
			public MiniSignal onComplete;
			public protected _prepareUrl;
			public string url;
			public protected _loadResource;
			public Resource resource;
			public Function dequeue;
			public protected _onComplete;
			public protected _onLoad;
			public Action<loaders.Loader> fn;
			public object context;
			public static void addPixiMiddleware(Function fn)
			{
				throw new System.NotImplementedException();
			}
			public object add(params object[][] @params)
			{
				throw new System.NotImplementedException();
			}
			public object add(string name, string url, ILoaderOptions options = default(ILoaderOptions), Function cb = default(Function))
			{
				throw new System.NotImplementedException();
			}
			public object add(string url, ILoaderOptions options = default(ILoaderOptions), Function cb = default(Function))
			{
				throw new System.NotImplementedException();
			}
			public object add(Any<object, object[]> obj, ILoaderOptions options = default(ILoaderOptions), Function cb = default(Function))
			{
				throw new System.NotImplementedException();
			}
			public object pre(Function fn)
			{
				throw new System.NotImplementedException();
			}
			public object use(Function fn)
			{
				throw new System.NotImplementedException();
			}
			public object reset()
			{
				throw new System.NotImplementedException();
			}
			public object load(Function cb = default(Function))
			{
				throw new System.NotImplementedException();
			}
			public object on(object @event)
			{
				throw new System.NotImplementedException();
			}
			public object on(string @event, Function fn, object context = default(object))
			{
				throw new System.NotImplementedException();
			}
			public object once(object @event)
			{
				throw new System.NotImplementedException();
			}
			public object once(string @event, Function fn, object context = default(object))
			{
				throw new System.NotImplementedException();
			}
		}

				public class ITextureDictionary
		{
			protected ITextureDictionary()
			{
				
			}
			public string index;
		}

				public class Resource
		{
			public Resource(string name, Any<string, string[]> url, ILoaderOptions options = default(ILoaderOptions))
			{
				
			}
			protected Resource()
			{
				
			}
			public protected _flags;
			public string name;
			public string url;
			public string extension;
			public object data;
			public Any<bool, string> crossOrigin;
			public float loadType;
			public string xhrType;
			public object metadata;
			public Error error;
			public Any<XMLHttpRequest, null> xhr;
			public Resource[] children;
			public float type;
			public float progressChunk;
			public protected _dequeue;
			public protected _onLoadBinding;
			public protected _boundComplete;
			public protected _boundOnError;
			public protected _boundOnProgress;
			public protected _boundXhrOnError;
			public protected _boundXhrOnAbort;
			public protected _boundXhrOnLoad;
			public protected _boundXdrOnTimeout;
			public MiniSignal onStart;
			public MiniSignal onProgress;
			public MiniSignal onComplete;
			public MiniSignal onAfterMiddleware;
			public bool isDataUrl;
			public bool isComplete;
			public bool isLoading;
			public protected _hasFlag;
			public float flag;
			public protected _setFlag;
			public bool value;
			public protected _loadElement;
			public protected _loadSourceElement;
			public protected _loadXhr;
			public protected _loadXdr;
			public protected _createSource;
			public string mime;
			public protected _onError;
						public object @event;
			public protected _onProgress;
			public protected _xhrOnError;
			public protected _xhrOnAbort;
			public protected _xdrOnTimeout;
			public protected _xhrOnLoad;
			public protected _determineCrossOrigin;
			public object loc;
			public protected _determineXhrType;
			public protected _determineLoadType;
			public protected _getExtension;
			public protected _getMimeXhrType;
			public static STATUS_FLAGS_0_ STATUS_FLAGS;
			public static TYPE_0_ TYPE;
			public static LOAD_TYPE_0_ LOAD_TYPE;
			public static XHR_RESPONSE_TYPE_0_ XHR_RESPONSE_TYPE;
			public static string EMPTY_GIF;
			public Texture texture;
			public object spineAtlas;
			public object spineData;
			public ITextureDictionary textures;
			public static void setExtensionLoadType(string extname, float loadType)
			{
				throw new System.NotImplementedException();
			}
			public static void setExtensionXhrType(string extname, string xhrType)
			{
				throw new System.NotImplementedException();
			}
			public void complete()
			{
				throw new System.NotImplementedException();
			}
			public void abort(string message = default(string))
			{
				throw new System.NotImplementedException();
			}
			public void load(Function cb = default(Function))
			{
				throw new System.NotImplementedException();
			}

						public class STATUS_FLAGS_0_
			{
				public float NONE;
				public float DATA_URL;
				public float COMPLETE;
				public float LOADING;
			}

						public class TYPE_0_
			{
				public float UNKNOWN;
				public float JSON;
				public float XML;
				public float IMAGE;
				public float AUDIO;
				public float VIDEO;
				public float TEXT;
			}

						public class LOAD_TYPE_0_
			{
				public float XHR;
				public float IMAGE;
				public float AUDIO;
				public float VIDEO;
			}

						public class XHR_RESPONSE_TYPE_0_
			{
				public string DEFAULT;
				public string BUFFER;
				public string BLOB;
				public string DOCUMENT;
				public string JSON;
				public string TEXT;
			}
		}
	}

		public static class mesh
	{
		public static protected _renderWebGL;
		public static CanvasRenderer renderer;
		public static protected _renderCanvas;
		public static protected _onTextureUpdate;
		public static protected _calculateBounds;
		public static float tint;
		public static DRAW_MODES_1_ DRAW_MODES;
		public static bool containsPoint(Point point)
		{
			throw new System.NotImplementedException();
		}

				public class Mesh : Container
		{
			public Mesh(Texture texture, Bridge.Html5.Float32Array vertices = default(Bridge.Html5.Float32Array), Bridge.Html5.Float32Array uvs = default(Bridge.Html5.Float32Array), Bridge.Html5.Uint16Array indices = default(Bridge.Html5.Uint16Array), float drawMode = default(float)) : base()
			{
				
			}
			protected Mesh() : base()
			{
				
			}
			public protected _texture;
			public Bridge.Html5.Float32Array uvs;
			public Bridge.Html5.Float32Array vertices;
			public Bridge.Html5.Uint16Array indices;
			public float dirty;
			public float indexDirty;
			public bool dirtyVertex;
			public protected _geometryVersion;
			public float blendMode;
			public string pluginName;
			public float canvasPadding;
			public float drawMode;
			public Texture texture;
			public Bridge.Html5.Float32Array tintRgb;
			public protected _glDatas;
			public float n;
		}

				public class DRAW_MODES_1_
		{
			public float TRIANGLE_MESH;
			public float TRIANGLES;
		}
	}
}

namespace GLOBAL
{

		public class ParticleBuffer
	{
		public ParticleBuffer(IWebGLRenderingContext gl, object properties, object[] dynamicPropertyFlags, float size)
		{
			
		}
		protected ParticleBuffer()
		{
			
		}
		public IWebGLRenderingContext gl;
		public float vertSize;
		public float vertByteSize;
		public float size;
		public object[] dynamicProperties;
		public object[] staticProperties;
		public float staticStride;
		public object staticBuffer;
		public object staticData;
		public float dynamicStride;
		public object dynamicBuffer;
		public object dynamicData;
		public void destroy()
		{
			throw new System.NotImplementedException();
		}
	}

		public class IParticleRendererProperty
	{
		protected IParticleRendererProperty()
		{
			
		}
		public float attribute;
		public float size;
		public Action<PIXI.DisplayObject> uploadFunction;
		public float amount;
		public float[] array;
		public float stride;
		public float offset;
		public object void;
	}

		public class ParticleRenderer : ObjectRenderer
	{
		public ParticleRenderer(WebGLRenderer renderer) : base()
		{
			
		}
		protected ParticleRenderer() : base()
		{
			
		}
		public glCore.GLShader shader;
		public WebGLBuffer indexBuffer;
		public IParticleRendererProperty[] properties;
		public protected tempMatrix;
		public Bridge.Html5.Uint16Array indices;
		public void start()
		{
			throw new System.NotImplementedException();
		}
		public ParticleBuffer[] generateBuffers(ParticleContainer container)
		{
			throw new System.NotImplementedException();
		}
		public void uploadVertices(DisplayObject[] children, float startIndex, float amount, float[] array, float stride, float offset)
		{
			throw new System.NotImplementedException();
		}
		public void uploadPosition(DisplayObject[] children, float startIndex, float amount, float[] array, float stride, float offset)
		{
			throw new System.NotImplementedException();
		}
		public void uploadRotation(DisplayObject[] children, float startIndex, float amount, float[] array, float stride, float offset)
		{
			throw new System.NotImplementedException();
		}
		public void uploadUvs(DisplayObject[] children, float startIndex, float amount, float[] array, float stride, float offset)
		{
			throw new System.NotImplementedException();
		}
		public void uploadAlpha(DisplayObject[] children, float startIndex, float amount, float[] array, float stride, float offset)
		{
			throw new System.NotImplementedException();
		}
		public void destroy()
		{
			throw new System.NotImplementedException();
		}
	}

		public class IParticleShader : glCore.GLShader
	{
		protected IParticleShader() : base()
		{
			
		}
	}

		public static class particles
	{
		public static protected _bufferToUpdate;
		public static bool interactiveChildren;
		public static float blendMode;
		public static bool roundPixels;
		public static BaseTexture baseTexture;
		public static protected onChildrenChange;
		public static float smallestChildIndex;
		public static object void;
		public static void setProperties(IParticleContainerProperties properties)
		{
			throw new System.NotImplementedException();
		}
		public static void destroy(Any<IDestroyOptions, bool> options = default(Any<IDestroyOptions, bool>))
		{
			throw new System.NotImplementedException();
		}

				public class IParticleContainerProperties
		{
			protected IParticleContainerProperties()
			{
				
			}
			public bool scale;
			public bool position;
			public bool rotation;
			public bool uvs;
			public bool alpha;
		}

				public class ParticleContainer : Container
		{
			public ParticleContainer(float size = default(float), IParticleContainerProperties properties = default(IParticleContainerProperties), float batchSize = default(float)) : base()
			{
				
			}
			protected ParticleContainer() : base()
			{
				
			}
			public protected _properties;
			public protected _maxSize;
			public protected _batchSize;
			public protected _glBuffers;
			public float n;
		}
	}
}

namespace GLOBAL
{

		public class IDecomposedDataUri
	{
		protected IDecomposedDataUri()
		{
			
		}
		public string mediaType;
		public string subType;
		public string encoding;
		public object data;
	}

	namespace prepare
	{

				public class AddHook
		{
			protected AddHook()
			{
				
			}
			public object item;
			public object[] queue;
		}

				public class UploadHook<UploadHookSource>
		{
			protected UploadHook()
			{
				
			}
			public UploadHookSource prepare;
			public object item;
		}

				public class BasePrepare<UploadHookSource>
		{
			public BasePrepare(SystemRenderer renderer)
			{
				
			}
			protected BasePrepare()
			{
				
			}
			public Any<CountLimiter, TimeLimiter> limiter;
			public protected renderer;
			public protected uploadHookHelper;
			public protected queue;
			public protected addHooks;
			public protected uploadHooks;
			public protected completes;
			public protected ticking;
			public protected delayedTick;
			public object void;
			public protected tick;
			public protected prepareItems;
			public void upload(Any<Function, DisplayObject, Container, BaseTexture, Texture, Graphics, Text, object> item, Action done = default(Action))
			{
				throw new System.NotImplementedException();
			}
			public object register(AddHook addHook = default(AddHook), UploadHook<UploadHookSource> uploadHook = default(UploadHook<UploadHookSource>))
			{
				throw new System.NotImplementedException();
			}
			public object add(PIXI.DisplayObject.PIXI.Container.PIXI.BaseTexture.PIXI.Texture.PIXI.Graphics.PIXI.Text.any item)
			{
				throw new System.NotImplementedException();
			}
			public void destroy()
			{
				throw new System.NotImplementedException();
			}
		}

				public class CanvasPrepare : BasePrepare<CanvasPrepare>
		{
			public CanvasPrepare(CanvasRenderer renderer) : base()
			{
				
			}
			protected CanvasPrepare() : base()
			{
				
			}
			public protected canvas;
			public protected ctx;
		}

				public class WebGLPrepare : BasePrepare<WebGLRenderer>
		{
			public WebGLPrepare(WebGLRenderer renderer) : base()
			{
				
			}
			protected WebGLPrepare() : base()
			{
				
			}
		}

				public class CountLimiter
		{
			public CountLimiter(float maxItemsPerFrame)
			{
				
			}
			protected CountLimiter()
			{
				
			}
			public protected maxItemsPerFrame;
			public protected itemsLeft;
		}

				public class TimeLimiter
		{
			public TimeLimiter(float maxMilliseconds)
			{
				
			}
			protected TimeLimiter()
			{
				
			}
			public protected maxMilliseconds;
			public protected frameStart;
		}
	}

		public static class glCore
	{
		public static IWebGLRenderingContext createContext(HTMLCanvasElement view, IContextOptions options = default(IContextOptions))
		{
			throw new System.NotImplementedException();
		}
		public static Any<IWebGLRenderingContext, undefined> setVertexAttribArrays(IWebGLRenderingContext gl, IAttrib[] attribs, WebGLState state = default(WebGLState))
		{
			throw new System.NotImplementedException();
		}

				public class IContextOptions
		{
			protected IContextOptions()
			{
				
			}
			public bool alpha;
			public bool depth;
			public bool stencil;
			public bool antialias;
			public bool premultipliedAlpha;
			public bool preserveDrawingBuffer;
			public bool failIfMajorPerformanceCaveat;
		}

				public class GLBuffer
		{
			public GLBuffer(IWebGLRenderingContext gl, float type, Any<Bridge.Html5.ArrayBuffer, Bridge.Html5.ArrayBufferView, object> data, float drawType)
			{
				
			}
			protected GLBuffer()
			{
				
			}
			public protected _updateID;
			public IWebGLRenderingContext gl;
			public WebGLBuffer buffer;
			public float type;
			public float drawType;
			public Any<Bridge.Html5.ArrayBuffer, Bridge.Html5.ArrayBufferView, object> data;
			public void upload(Any<Bridge.Html5.ArrayBuffer, Bridge.Html5.ArrayBufferView, object> data, float offset = default(float), bool dontBind = default(bool))
			{
				throw new System.NotImplementedException();
			}
			public void bind()
			{
				throw new System.NotImplementedException();
			}
			public static GLBuffer createVertexBuffer(IWebGLRenderingContext gl, Any<Bridge.Html5.ArrayBuffer, Bridge.Html5.ArrayBufferView, object> data, float drawType)
			{
				throw new System.NotImplementedException();
			}
			public static GLBuffer createIndexBuffer(IWebGLRenderingContext gl, Any<Bridge.Html5.ArrayBuffer, Bridge.Html5.ArrayBufferView, object> data, float drawType)
			{
				throw new System.NotImplementedException();
			}
			public static GLBuffer create(IWebGLRenderingContext gl, float type, Any<Bridge.Html5.ArrayBuffer, Bridge.Html5.ArrayBufferView, object> data, float drawType)
			{
				throw new System.NotImplementedException();
			}
			public void destroy()
			{
				throw new System.NotImplementedException();
			}
		}

				public class GLFramebuffer
		{
			public GLFramebuffer(IWebGLRenderingContext gl, float width, float height)
			{
				
			}
			protected GLFramebuffer()
			{
				
			}
			public IWebGLRenderingContext gl;
			public WebGLFramebuffer frameBuffer;
			public WebGLRenderbuffer stencil;
			public GLTexture texture;
			public float width;
			public float height;
			public void enableTexture(GLTexture texture)
			{
				throw new System.NotImplementedException();
			}
			public void enableStencil()
			{
				throw new System.NotImplementedException();
			}
			public void clear(float r, float g, float b, float a)
			{
				throw new System.NotImplementedException();
			}
			public void bind()
			{
				throw new System.NotImplementedException();
			}
			public void unbind()
			{
				throw new System.NotImplementedException();
			}
			public void resize(float width, float height)
			{
				throw new System.NotImplementedException();
			}
			public void destroy()
			{
				throw new System.NotImplementedException();
			}
			public static GLFramebuffer createRGBA(IWebGLRenderingContext gl, float width, float height, Any<Bridge.Html5.ArrayBuffer, Bridge.Html5.ArrayBufferView, object> data)
			{
				throw new System.NotImplementedException();
			}
			public static GLFramebuffer createFloat32(IWebGLRenderingContext gl, float width, float height, Any<Bridge.Html5.ArrayBuffer, Bridge.Html5.ArrayBufferView, object> data)
			{
				throw new System.NotImplementedException();
			}
		}

				public class GLShader
		{
			public GLShader(IWebGLRenderingContext gl, Any<string, string[]> vertexSrc, Any<string, string[]> fragmentSrc, string precision, AttributeLocations_1_ attributeLocations)
			{
				
			}
			protected GLShader()
			{
				
			}
			public IWebGLRenderingContext gl;
			public Any<WebGLProgram, null> program;
			public object uniformData;
			public object uniforms;
			public object attributes;
			public void bind()
			{
				throw new System.NotImplementedException();
			}
			public void destroy()
			{
				throw new System.NotImplementedException();
			}

						public class AttributeLocations_0_
			{
				
				public float this[string index]
				{
					get
					{
						return (float)((dynamic)this)[index];
					}				
					set
					{
						((dynamic)this)[index] = value;
					}
				}
				
			}

						public class AttributeLocations_1_
			{
				
				public float this[string index]
				{
					get
					{
						return (float)((dynamic)this)[index];
					}				
					set
					{
						((dynamic)this)[index] = value;
					}
				}
				
			}
		}

				public class GLTexture
		{
			public GLTexture(IWebGLRenderingContext gl, float width = default(float), float height = default(float), float format = default(float), float type = default(float))
			{
				
			}
			protected GLTexture()
			{
				
			}
			public IWebGLRenderingContext gl;
			public WebGLTexture texture;
			public bool mipmap;
			public bool premultiplyAlpha;
			public float width;
			public float height;
			public float format;
			public float type;
			public void upload(Any<HTMLImageElement, ImageData, HTMLVideoElement, HTMLCanvasElement> source)
			{
				throw new System.NotImplementedException();
			}
			public void uploadData(float data, float width, float height)
			{
				throw new System.NotImplementedException();
			}
			public void bind(float location = default(float))
			{
				throw new System.NotImplementedException();
			}
			public void unbind()
			{
				throw new System.NotImplementedException();
			}
			public void minFilter(bool linear)
			{
				throw new System.NotImplementedException();
			}
			public void magFilter(bool linear)
			{
				throw new System.NotImplementedException();
			}
			public void enableMipmap()
			{
				throw new System.NotImplementedException();
			}
			public void enableLinearScaling()
			{
				throw new System.NotImplementedException();
			}
			public void enableNearestScaling()
			{
				throw new System.NotImplementedException();
			}
			public void enableWrapClamp()
			{
				throw new System.NotImplementedException();
			}
			public void enableWrapRepeat()
			{
				throw new System.NotImplementedException();
			}
			public void enableWrapMirrorRepeat()
			{
				throw new System.NotImplementedException();
			}
			public void destroy()
			{
				throw new System.NotImplementedException();
			}
			public static GLTexture fromSource(IWebGLRenderingContext gl, Any<HTMLImageElement, ImageData, HTMLVideoElement, HTMLCanvasElement> source, bool premultipleAlpha = default(bool))
			{
				throw new System.NotImplementedException();
			}
			public static GLTexture fromData(IWebGLRenderingContext gl, float[] data, float width, float height)
			{
				throw new System.NotImplementedException();
			}
		}

				public class IAttrib
		{
			protected IAttrib()
			{
				
			}
			public Attribute_0_ attribute;
			public bool normalized;
			public float stride;
			public float start;
			public Bridge.Html5.ArrayBuffer buffer;

						public class Attribute_0_
			{
				public bool location;
				public float size;
			}
		}

				public class IWebGLRenderingContextAttribute
		{
			protected IWebGLRenderingContextAttribute()
			{
				
			}
			public WebGLBuffer buffer;
			public object attribute;
			public float type;
			public bool normalized;
			public float stride;
			public float start;
		}

				public class IAttribState
		{
			protected IAttribState()
			{
				
			}
			public IAttrib[] tempAttribState;
			public IAttrib[] attribState;
		}

				public class VertexArrayObject
		{
			public VertexArrayObject(IWebGLRenderingContext gl, WebGLState state)
			{
				
			}
			protected VertexArrayObject()
			{
				
			}
			public static bool FORCE_NATIVE;
			public protected nativeVaoExtension;
			public protected nativeState;
			public protected nativeVao;
			public IWebGLRenderingContext gl;
			public IAttrib[] attributes;
			public GLBuffer indexBuffer;
			public bool dirty;
			public VertexArrayObject bind()
			{
				throw new System.NotImplementedException();
			}
			public VertexArrayObject unbind()
			{
				throw new System.NotImplementedException();
			}
			public VertexArrayObject activate()
			{
				throw new System.NotImplementedException();
			}
			public VertexArrayObject addAttribute(GLBuffer buffer, IAttrib attribute, float type, bool normalized, float stride, float start)
			{
				throw new System.NotImplementedException();
			}
			public VertexArrayObject addIndex(GLBuffer buffer, object options = default(object))
			{
				throw new System.NotImplementedException();
			}
			public VertexArrayObject clear()
			{
				throw new System.NotImplementedException();
			}
			public VertexArrayObject draw(float type, float size, float start)
			{
				throw new System.NotImplementedException();
			}
			public void destroy()
			{
				throw new System.NotImplementedException();
			}
		}
	}

		public static class utils
	{
		public static object TextureCache;
		public static object BaseTextureCache;
		public static float uid()
		{
			throw new System.NotImplementedException();
		}
		public static float[] hex2rgb(float hex, float[] out = default(float[]))
		{
			throw new System.NotImplementedException();
		}
		public static string hex2string(float hex)
		{
			throw new System.NotImplementedException();
		}
		public static float rgb2hex(Number[] rgb)
		{
			throw new System.NotImplementedException();
		}
		public static bool canUseNewCanvasBlendModes()
		{
			throw new System.NotImplementedException();
		}
		public static float getResolutionOfUrl(string url, float defaultValue = default(float))
		{
			throw new System.NotImplementedException();
		}
		public static object getSvgSize(string svgString)
		{
			throw new System.NotImplementedException();
		}
		public static Any<IDecomposedDataUri, void> decomposeDataUri(string dataUri)
		{
			throw new System.NotImplementedException();
		}
		public static Any<string, void> getUrlFileExtension(string url)
		{
			throw new System.NotImplementedException();
		}
		public static void sayHello(string type)
		{
			throw new System.NotImplementedException();
		}
		public static void skipHello()
		{
			throw new System.NotImplementedException();
		}
		public static bool isWebGLSupported()
		{
			throw new System.NotImplementedException();
		}
		public static float sign(float n)
		{
			throw new System.NotImplementedException();
		}
		public static void removeItems<T>(T[] arr, float startIdx, float removeCount)
		{
			throw new System.NotImplementedException();
		}

				public class EventEmitter
		{
			protected EventEmitter()
			{
				
			}
			public Function[] listeners(string @event, bool exists = default(bool))
			{
				throw new System.NotImplementedException();
			}
			public bool emit(string @event, params object[][] args)
			{
				throw new System.NotImplementedException();
			}
			public object on(string @event, Function fn, object context = default(object))
			{
				throw new System.NotImplementedException();
			}
			public object once(string @event, Function fn, object context = default(object))
			{
				throw new System.NotImplementedException();
			}
			public object removeListener(string @event, Function fn, object context = default(object), bool once = default(bool))
			{
				throw new System.NotImplementedException();
			}
			public object removeAllListeners(string @event = default(string))
			{
				throw new System.NotImplementedException();
			}
			public string[] eventNames()
			{
				throw new System.NotImplementedException();
			}
			public object off(string @event, Function fn, object context = default(object), bool once = default(bool))
			{
				throw new System.NotImplementedException();
			}
			public object addListener(string @event, Function fn, object context = default(object))
			{
				throw new System.NotImplementedException();
			}
		}

				public static class isMobile
		{
			public static Apple_0_ apple;
			public static Android_0_ android;
			public static Amazon_0_ amazon;
			public static Windows_0_ windows;
			public static bool seven_inch;
			public static Other_0_ other;
			public static bool any;
			public static bool phone;
			public static bool tablet;

						public class Apple_0_
			{
				public bool phone;
				public bool ipod;
				public bool tablet;
				public bool device;
			}

						public class Android_0_
			{
				public bool phone;
				public bool tablet;
				public bool device;
			}

						public class Amazon_0_
			{
				public bool phone;
				public bool tablet;
				public bool device;
			}

						public class Windows_0_
			{
				public bool phone;
				public bool tablet;
				public bool device;
			}

						public class Other_0_
			{
				public bool blackberry10;
				public bool blackberry;
				public bool opera;
				public bool firefox;
				public bool chrome;
				public bool device;
			}
		}
	}

		public static class core
	{
		public static type SpriteBatch;
		public static type AssetLoader;
		public static type Stage;
		public static type DisplayObjectContainer;
		public static type Strip;
		public static type Rope;
		public static type ParticleContainer;
		public static type MovieClip;
		public static type TilingSprite;
		public static type BitmapText;
		public static type math;
		public static type AbstractFilter;
		public static type TransformManual;
		public static type TARGET_FPMS;
		public static type FILTER_RESOLUTION;
		public static type RESOLUTION;
		public static type MIPMAP_TEXTURES;
		public static type SPRITE_BATCH_SIZE;
		public static type SPRITE_MAX_TEXTURES;
		public static type RETINA_PREFIX;
		public static type DEFAULT_RENDER_OPTIONS;
	}

		public static class extras
	{
		public static type MovieClip;
	}
}

namespace GLOBAL
{

		public class "
	{
		protected "()
		{
			
		}
	}

		public static class pixi
	{
		public static typeof gl;
		public static object glCore;
	}
}
