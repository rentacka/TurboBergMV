
		using System;
		using System.Collections.Generic;
		using System.Linq;
		using System.Text;
		
public static class GLOBAL
{
	public static bool waitForLoading;
	public static bool register;
	public static IDataActor[] $dataActors;
	public static IDataClass[] $dataClasses;
	public static IDataSkill[] $dataSkills;
	public static IDataItem[] $dataItems;
	public static IDataWeapon[] $dataWeapons;
	public static IDataArmor[] $dataArmors;
	public static IDataEnemy[] $dataEnemies;
	public static IDataTroop[] $dataTroops;
	public static IDataState[] $dataStates;
	public static IDataAnimation[] $dataAnimations;
	public static IDataTileset[] $dataTilesets;
	public static IDataCommonEvent[] $dataCommonEvents;
	public static IDataSystem $dataSystem;
	public static IDataMapInfo[] $dataMapInfos;
	public static IDataMap $dataMap;
	public static Game_Temp $gameTemp;
	public static Game_System $gameSystem;
	public static Game_Screen $gameScreen;
	public static Game_Timer $gameTimer;
	public static Game_Message $gameMessage;
	public static Game_Switches $gameSwitches;
	public static Game_Variables $gameVariables;
	public static Game_SelfSwitches $gameSelfSwitches;
	public static Game_Map $gameMap;
	public static Game_Actors $gameActors;
	public static Game_Party $gameParty;
	public static Game_Troop $gameTroop;
	public static Game_Player $gamePlayer;
	public static object $testEvent;
	public static type PluginParameters;
	public static string key;

		public class JsExtensions
	{
		public JsExtensions()
		{
			
		}
	}

		public class Number
	{
		protected Number()
		{
			
		}
		public float clamp(float min, float max)
		{
					}
		public float mod(float n)
		{
					}
	}

		public class String
	{
		protected String()
		{
			
		}
		public string format()
		{
					}
		public string padZero(float length)
		{
					}
		public bool contains(string @string)
		{
					}
	}

		public class Array<T>
	{
		protected Array()
		{
			
		}
		public bool equals(T array)
		{
					}
		public T clone()
		{
					}
		public bool contains()
		{
					}
	}

		public class Math
	{
		protected Math()
		{
			
		}
		public float randomInt(float max)
		{
					}
	}

		public class Utils
	{
		public Utils()
		{
			
		}
		public static string RPGMAKER_NAME;
		public static string RPGMAKER_VERSION;
		public static float _id;
		public static bool _supportPassiveEvent;
		public static bool isOptionValid(string name)
		{
					}
		public static bool isNwjs()
		{
					}
		public static bool isMobileDevice()
		{
					}
		public static bool isMobileSafari()
		{
					}
		public static bool isAndroidChrome()
		{
					}
		public static bool canReadGameFiles()
		{
					}
		public static string rgbToCssColor(float r, float g, float b)
		{
					}
		public static float generateRuntimeId()
		{
					}
		public static bool isSupportPassiveEvent()
		{
					}
	}

		public class IImageCacheItem
	{
		protected IImageCacheItem()
		{
			
		}
		public Bitmap bitmap;
		public float touch;
		public string key;
	}

		public class ImageCache
	{
		protected ImageCache()
		{
			
		}
		public static float limit;
		public void initialize()
		{
					}
		public void add(string key, Bitmap value)
		{
					}
		public Bitmap get(string key)
		{
					}
		public void reserve(string key, Bitmap value, float reservationId)
		{
					}
		public void releaseReservation(float reservationId)
		{
					}
		public bool isReady()
		{
					}
		public Bitmap getErrorBitmap()
		{
					}
		public void _truncateCache()
		{
					}
		public bool _mustBeHeld(IImageCacheItem item)
		{
					}
	}

		public class RequestQueue
	{
		public RequestQueue()
		{
			
		}
		public void initialize()
		{
					}
		public void enqueue(string key, Bitmap value)
		{
					}
		public void update()
		{
					}
		public void raisePriority(string key)
		{
					}
		public void clear()
		{
					}
	}

		public class CacheEntry
	{
		public CacheEntry(CacheMap cache, string key, Any<Bitmap, Html5Audio, WebAudio> item)
		{
			
		}
		protected CacheEntry()
		{
			
		}
		public CacheMap cache;
		public string key;
		public Any<Bitmap, Html5Audio, WebAudio> item;
		public bool cached;
		public float touchTicks;
		public float touchSeconds;
		public float ttlTicks;
		public float ttlSeconds;
		public bool freedByTTL;
		public void free(bool byTTL = default(bool))
		{
					}
		public CacheEntry allocate()
		{
					}
		public CacheEntry setTimeToLive(float ticks = default(float), float seconds = default(float))
		{
					}
		public bool isStillAlive()
		{
					}
		public void touch()
		{
					}
	}

		public class CacheMap
	{
		public CacheMap(typeof manager)
		{
			
		}
		protected CacheMap()
		{
			
		}
		public _inner_0_ _inner;
		public CacheEntry[] _lastRemovedEntries;
		public typeof manager;
		public typeof ConfigManager;
		public typeof StorageManager;
		public typeof ImageManager;
		public typeof AudioManager;
		public typeof SoundManager;
		public typeof TextManager;
		public typeof SceneManager;
		public typeof BattleManager;
		public typeof PluginManager;
		public float updateTicks;
		public float lastCheckTTL;
		public float delayCheckTTL;
		public float updateSeconds;
		public void checkTTL()
		{
					}
		public object getItem(string key)
		{
					}
		public void clear()
		{
					}
		public CacheEntry setItem(string key, object item)
		{
					}
		public void update(float ticks, float delta)
		{
					}

				public class _inner_0_
		{
			
			public CacheEntry this[string index]
			{
				get
				{
					return (CacheEntry)((dynamic)this)[index];
				}				
				set
				{
					((dynamic)this)[index] = value;
				}
			}
			
		}
	}

		public class Point : PIXI.Point
	{
		public Point(float x = default(float), float y = default(float)) : base()
		{
			
		}
		protected Point() : base()
		{
			
		}
		public void initialize(float x = default(float), float y = default(float))
		{
					}
	}

		public class Rectangle : PIXI.Rectangle
	{
		public Rectangle(float x = default(float), float y = default(float), float width = default(float), float height = default(float)) : base()
		{
			
		}
		protected Rectangle() : base()
		{
			
		}
		public static Rectangle emptyRectangle;
		public void initialize(float x = default(float), float y = default(float), float width = default(float), float height = default(float))
		{
					}
	}

		public class Bitmap
	{
		public Bitmap(float width = default(float), float height = default(float))
		{
			
		}
		protected Bitmap()
		{
			
		}
		public static HTMLImageElement[] _reuseImages;
		public string url;
		public PIXI.BaseTexture baseTexture;
		public HTMLCanvasElement canvas;
		public CanvasRenderingContext2D context;
		public float width;
		public float height;
		public Rectangle rect;
		public bool smooth;
		public float paintOpacity;
		public CacheEntry cacheEntry;
		public string fontFace;
		public float fontSize;
		public bool fontItalic;
		public string textColor;
		public string outlineColor;
		public float outlineWidth;
		public HTMLCanvasElement _canvas;
		public CanvasRenderingContext2D _context;
		public PIXI.BaseTexture _baseTexture;
		public HTMLImageElement _image;
		public string _url;
		public float _paintOpacity;
		public bool _smooth;
		public Function[] _loadListeners;
		public string _loadingState;
		public bool _decodeAfterRequest;
		public static Bitmap load(string url)
		{
					}
		public static Bitmap snap(Stage stage)
		{
					}
		public static Bitmap request(string url)
		{
					}
		public void initialize(float width = default(float), float height = default(float))
		{
					}
		public bool isReady()
		{
					}
		public bool isError()
		{
					}
		public void touch()
		{
					}
		public void resize(float width, float height)
		{
					}
		public void blt(Bitmap source, float sx, float sy, float sw, float sh, float dx, float dy, float dw = default(float), float dh = default(float))
		{
					}
		public void bltImage(Bitmap source, float sx, float sy, float sw, float sh, float dx, float dy, float dw = default(float), float dh = default(float))
		{
					}
		public string getPixel(float x, float y)
		{
					}
		public string getAlphaPixel(float x, float y)
		{
					}
		public void clearRect(float x, float y, float width, float height)
		{
					}
		public void clear()
		{
					}
		public void fillRect(float x, float y, float width, float height, String color)
		{
					}
		public void fillAll(string color)
		{
					}
		public void gradientFillRect(float x, float y, float width, float height, String color1, string color2, bool vertical)
		{
					}
		public void drawCircle(float x, float y, float radius, string color)
		{
					}
		public void drawText(string text, float x, float y, float maxWidth = default(float), float lineHeight = default(float), string align = default(string))
		{
					}
		public float measureTextWidth(string text)
		{
					}
		public void adjustTone(float r, float g, float b)
		{
					}
		public void rotateHue(float offset)
		{
					}
		public void blur()
		{
					}
		public void addLoadListener(Function listener)
		{
					}
		public void checkDirty()
		{
					}
		public bool isRequestOnly()
		{
					}
		public bool isRequestReady()
		{
					}
		public void startRequest()
		{
					}
		public string _makeFontNameText()
		{
					}
		public void _drawTextOutline(string text, float tx, float ty, float maxWidth)
		{
					}
		public void _drawTextBody(string text, float tx, float ty, float maxWidth)
		{
					}
		public void _onLoad()
		{
					}
		public void _callLoadListeners()
		{
					}
		public void _onError()
		{
					}
		public void _setDirty()
		{
					}
		public void _createCanvas(float width, float height)
		{
					}
		public void _createBaseTexture(Any<HTMLImageElement, HTMLCanvasElement, HTMLVideoElement> source)
		{
					}
		public void _clearImgInstance()
		{
					}
		public void _renewCanvas()
		{
					}
		public void _requestImage(string url)
		{
					}
	}

		public class Graphics
	{
		public Graphics()
		{
			
		}
		public static float frameCount;
		public static float BLEND_NORMAL;
		public static float BLEND_ADD;
		public static float BLEND_MULTIPLY;
		public static float BLEND_SCREEN;
		public static float width;
		public static float height;
		public static float boxWidth;
		public static float boxHeight;
		public static float scale;
		public static float _width;
		public static float _height;
		public static string _rendererType;
		public static float _boxWidth;
		public static float _boxHeight;
		public static float _scale;
		public static float _realScale;
		public static bool _errorShowed;
		public static HTMLParagraphElement _errorPrinter;
		public static HTMLCanvasElement _canvas;
		public static HTMLVideoElement _video;
		public static bool _videoUnlocked;
		public static bool _videoLoading;
		public static HTMLCanvasElement _upperCanvas;
		public static PIXI.SystemRenderer _renderer;
		public static object _fpsMeter;
		public static HTMLDivElement _modeBox;
		public static float _skipCount;
		public static float _maxSkip;
		public static bool _rendered;
		public static HTMLImageElement _loadingImage;
		public static float _loadingCount;
		public static bool _fpsMeterToggled;
		public static bool _stretchEnabled;
		public static bool _canUseDifferenceBlend;
		public static bool _canUseSaturationBlend;
		public static HTMLCanvasElement _hiddenCanvas;
		public static bool _cssFontLoading;
		public static object _fontLoaded;
		public static float _videoVolume;
		public static void initialize(float width = default(float), float height = default(float), string type = default(string))
		{
					}
		public static void tickStart()
		{
					}
		public static void tickEnd()
		{
					}
		public static void render(Stage stage)
		{
					}
		public static bool isWebGL()
		{
					}
		public static bool hasWebGL()
		{
					}
		public static bool canUseDifferenceBlend()
		{
					}
		public static bool canUseSaturationBlend()
		{
					}
		public static void setLoadingImage(string src)
		{
					}
		public static void startLoading()
		{
					}
		public static void updateLoading()
		{
					}
		public static void printError(string name, string message)
		{
					}
		public static void showFps()
		{
					}
		public static void hideFps()
		{
					}
		public static void loadFont(string name, string url)
		{
					}
		public static bool isFontLoaded(string name)
		{
					}
		public static void playVideo(string src)
		{
					}
		public static bool isVideoPlaying()
		{
					}
		public static bool canPlayVideoType(string type)
		{
					}
		public static float pageToCanvasX(float x)
		{
					}
		public static float pageToCanvasY(float y)
		{
					}
		public static bool isInsideCanvas(float x, float y)
		{
					}
		public static void callGC()
		{
					}
		public static bool canUseCssFontLoading()
		{
					}
		public static void printLoadingError(string url)
		{
					}
		public static void eraseLoadingError()
		{
					}
		public static void setVideoVolume(float value)
		{
					}
		public static void _setupCssFontLoading()
		{
					}
		public static void _onTouchEnd(TouchEvent @event)
		{
					}
		public static void _createAllElements()
		{
					}
		public static void _updateAllElements()
		{
					}
		public static void _updateRealScale()
		{
					}
		public static string _makeErrorHtml(string name, string message)
		{
					}
		public static bool _defaultStretchMode()
		{
					}
		public static void _testCanvasBlendModes()
		{
					}
		public static void _modifyExistingElements()
		{
					}
		public static void _createErrorPrinter()
		{
					}
		public static void _updateErrorPrinter()
		{
					}
		public static void _createCanvas()
		{
					}
		public static void _updateCanvas()
		{
					}
		public static void _createVideo()
		{
					}
		public static void _updateVideo()
		{
					}
		public static void _createUpperCanvas()
		{
					}
		public static void _updateUpperCanvas()
		{
					}
		public static void _clearUpperCanvas()
		{
					}
		public static void _paintUpperCanvas()
		{
					}
		public static void _createRenderer()
		{
					}
		public static void _updateRenderer()
		{
					}
		public static void _createFPSMeter()
		{
					}
		public static void _createModeBox()
		{
					}
		public static void _createGameFontLoader()
		{
					}
		public static void _createFontLoader(string name)
		{
					}
		public static void _centerElement(HTMLElement element)
		{
					}
		public static void _disableTextSelection()
		{
					}
		public static void _disableContextMenu()
		{
					}
		public static void _applyCanvasFilter()
		{
					}
		public static void _onVideoLoad()
		{
					}
		public static void _onVideoError()
		{
					}
		public static void _onVideoEnd()
		{
					}
		public static void _updateVisibility(bool videoVisible)
		{
					}
		public static bool _isVideoVisible()
		{
					}
		public static void _setupEventHandlers()
		{
					}
		public static void _onWindowResize()
		{
					}
		public static void _onKeyDown(KeyboardEvent @event)
		{
					}
		public static void _switchFPSMeter()
		{
					}
		public static void _switchStretchMode()
		{
					}
		public static void _switchFullScreen()
		{
					}
		public static bool _isFullScreen()
		{
					}
		public static void _requestFullScreen()
		{
					}
		public static void _cancelFullScreen()
		{
					}
	}

		public class Input
	{
		public Input()
		{
			
		}
		public static float keyRepeatWait;
		public static float keyRepeatInterval;
		public static KeyMapper_0_ keyMapper;
		public static GamepadMapper_0_ gamepadMapper;
		public static float dir4;
		public static float dir8;
		public static float date;
		public static _currentState_0_ _currentState;
		public static _previousState_0_ _previousState;
		public static bool[][] _gamepadStates;
		public static string _latestButton;
		public static float _pressedTime;
		public static float _dir4;
		public static float _dir8;
		public static string _preferredAxis;
		public static float _date;
		public static void initialize()
		{
					}
		public static void clear()
		{
					}
		public static void update()
		{
					}
		public static bool isPressed(string keyName)
		{
					}
		public static bool isTriggered(string keyName)
		{
					}
		public static bool isRepeated(string keyName)
		{
					}
		public static bool isLongPressed(string keyName)
		{
					}
		public static void _wrapNwjsAlert()
		{
					}
		public static void _setupEventHandlers()
		{
					}
		public static void _onKeyDown(KeyboardEvent @event)
		{
					}
		public static bool _shouldPreventDefault(float keyCode)
		{
					}
		public static void _onKeyUp(KeyboardEvent @event)
		{
					}
		public static void _onLostFocus()
		{
					}
		public static void _pollGamepads()
		{
					}
		public static void _updateGamepadState(Gamepad gamepad)
		{
					}
		public static void _updateDirection()
		{
					}
		public static float _signX()
		{
					}
		public static float _signY()
		{
					}
		public static float _makeNumpadDirection(float x, float y)
		{
					}
		public static bool _isEscapeCompatible(string keyName)
		{
					}

				public class KeyMapper_0_
		{
			
			public string this[float index]
			{
				get
				{
					return (string)((dynamic)this)[index];
				}				
				set
				{
					((dynamic)this)[index] = value;
				}
			}
			
		}

				public class GamepadMapper_0_
		{
			
			public string this[float index]
			{
				get
				{
					return (string)((dynamic)this)[index];
				}				
				set
				{
					((dynamic)this)[index] = value;
				}
			}
			
		}

				public class _currentState_0_
		{
			
			public bool this[string index]
			{
				get
				{
					return (bool)((dynamic)this)[index];
				}				
				set
				{
					((dynamic)this)[index] = value;
				}
			}
			
		}

				public class _previousState_0_
		{
			
			public bool this[string index]
			{
				get
				{
					return (bool)((dynamic)this)[index];
				}				
				set
				{
					((dynamic)this)[index] = value;
				}
			}
			
		}
	}

		public class IDataTouchInput
	{
		protected IDataTouchInput()
		{
			
		}
		public bool triggered;
		public bool cancelled;
		public bool moved;
		public bool released;
		public float wheelX;
		public float wheelY;
	}

		public class TouchInput
	{
		public TouchInput()
		{
			
		}
		public static float keyRepeatWait;
		public static float keyRepeatInterval;
		public static float wheelX;
		public static float wheelY;
		public static float x;
		public static float y;
		public static float date;
		public static bool _mousePressed;
		public static bool _screenPressed;
		public static float _pressedTime;
		public static IDataTouchInput _events;
		public static bool _triggered;
		public static bool _cancelled;
		public static bool _moved;
		public static bool _released;
		public static float _wheelX;
		public static float _wheelY;
		public static float _x;
		public static float _y;
		public static float _date;
		public static void initialize()
		{
					}
		public static void clear()
		{
					}
		public static void update()
		{
					}
		public static bool isPressed()
		{
					}
		public static bool isTriggered()
		{
					}
		public static bool isRepeated()
		{
					}
		public static bool isLongPressed()
		{
					}
		public static bool isCancelled()
		{
					}
		public static bool isMoved()
		{
					}
		public static bool isReleased()
		{
					}
		public static void _setupEventHandlers()
		{
					}
		public static void _onMouseDown(MouseEvent @event)
		{
					}
		public static void _onLeftButtonDown(MouseEvent @event)
		{
					}
		public static void _onMiddleButtonDown(MouseEvent @event)
		{
					}
		public static void _onRightButtonDown(MouseEvent @event)
		{
					}
		public static void _onMouseMove(MouseEvent @event)
		{
					}
		public static void _onMouseUp(MouseEvent @event)
		{
					}
		public static void _onWheel(WheelEvent @event)
		{
					}
		public static void _onTouchStart(TouchEvent @event)
		{
					}
		public static void _onTouchMove(TouchEvent @event)
		{
					}
		public static void _onTouchEnd(TouchEvent @event)
		{
					}
		public static void _onTouchCancel(TouchEvent @event)
		{
					}
		public static void _onPointerDown(PointerEvent @event)
		{
					}
		public static void _onTrigger(float x, float y)
		{
					}
		public static void _onCancel(float x, float y)
		{
					}
		public static void _onMove(float x, float y)
		{
					}
		public static void _onRelease(float x, float y)
		{
					}
	}

		public class Sprite : PIXI.Sprite
	{
		public Sprite(Bitmap bitmap = default(Bitmap)) : base()
		{
			
		}
		protected Sprite() : base()
		{
			
		}
		public static float _counter;
		public Bitmap bitmap;
		public float width;
		public float height;
		public float opacity;
		public Bitmap _bitmap;
		public Rectangle _frame;
		public Rectangle _realFrame;
		public Point _offset;
		public float[] _blendColor;
		public float[] _colorTone;
		public HTMLCanvasElement _canvas;
		public CanvasRenderingContext2D _context;
		public PIXI.BaseTexture _tintTexture;
		public void initialize(Bitmap bitmap = default(Bitmap))
		{
					}
		public void update()
		{
					}
		public void move(float x, float y)
		{
					}
		public void setFrame(float x, float y, float width, float height)
		{
					}
		public float[] getBlendColor()
		{
					}
		public void setBlendColor(float[] color)
		{
					}
		public float[] getColorTone()
		{
					}
		public void setColorTone(float[] tone)
		{
					}
		public void _onBitmapLoad(Bitmap bitmapLoaded)
		{
					}
		public void _refresh()
		{
					}
		public bool _isInBitmapRect(float x, float y, float w, float h)
		{
					}
		public bool _needsTint()
		{
					}
		public void _createTinter(float w, float h)
		{
					}
		public void _executeTint(float x, float y, float w, float h)
		{
					}
		public void _renderCanvas_PIXI(PIXI.CanvasRenderer renderer)
		{
					}
		public void _renderWebGL_PIXI(PIXI.WebGLRenderer renderer)
		{
					}
		public void _renderCanvas(PIXI.CanvasRenderer renderer)
		{
					}
		public void _speedUpCustomBlendModes(PIXI.CanvasRenderer renderer)
		{
					}
		public void _renderWebGL(PIXI.WebGLRenderer renderer)
		{
					}
	}

		public class Tilemap : PIXI.Container
	{
		public Tilemap() : base()
		{
			
		}
		public float width;
		public float height;
		public float tileWidth;
		public float tileHeight;
		public Bitmap[] bitmaps;
		public Point origin;
		public Flags_0_ flags;
		public float animationCount;
		public float animationFrame;
		public bool horizontalWrap;
		public bool verticalWrap;
		public float _margin;
		public float _width;
		public float _height;
		public float _tileWidth;
		public float _tileHeight;
		public float _mapWidth;
		public float _mapHeight;
		public float[] _mapData;
		public float _layerWidth;
		public float _layerHeight;
		public float[][][][] _lastTiles;
		public bool _needsRepaint;
		public float _lastAnimationFrame;
		public float _lastStartX;
		public float _lastStartY;
		public bool _frameUpdated;
		public Bitmap _lowerBitmap;
		public Bitmap _upperBitmap;
		public Sprite _lowerLayer;
		public Sprite _upperLayer;
		public static float TILE_ID_B;
		public static float TILE_ID_C;
		public static float TILE_ID_D;
		public static float TILE_ID_E;
		public static float TILE_ID_A5;
		public static float TILE_ID_A1;
		public static float TILE_ID_A2;
		public static float TILE_ID_A3;
		public static float TILE_ID_A4;
		public static float TILE_ID_MAX;
		public static float[][][] FLOOR_AUTOTILE_TABLE;
		public static float[][][] WALL_AUTOTILE_TABLE;
		public static float[][][] WATERFALL_AUTOTILE_TABLE;
		public void initialize()
		{
					}
		public void setData(float width, float height, float[] data)
		{
					}
		public bool isReady()
		{
					}
		public void update()
		{
					}
		public void refresh()
		{
					}
		public void refreshTileset()
		{
					}
		public void updateTransform()
		{
					}
		public void _createLayers()
		{
					}
		public void _updateLayerPositions(float startX, float startY)
		{
					}
		public void _paintAllTiles(float startX, float startY)
		{
					}
		public void _paintTiles(float startX, float startY, float x, float y)
		{
					}
		public float[] _readLastTiles(float i, float x, float y)
		{
					}
		public void _writeLastTiles(float i, float x, float y, float[] tiles)
		{
					}
		public void _drawTile(Bitmap bitmap, float tileId, float dx, float dy)
		{
					}
		public void _drawNormalTile(Bitmap bitmap, float tileId, float dx, float dy)
		{
					}
		public void _drawAutotile(Bitmap bitmap, float tileId, float dx, float dy)
		{
					}
		public void _drawTableEdge(Bitmap bitmap, float tileId, float dx, float dy)
		{
					}
		public void _drawShadow(Bitmap bitmap, float shadowBits, float dx, float dy)
		{
					}
		public float _readMapData(float x, float y, float z)
		{
					}
		public bool _isHigherTile(float tileId)
		{
					}
		public bool _isTableTile(float tileId)
		{
					}
		public bool _isOverpassPosition(float mx, float my)
		{
					}
		public void _sortChildren()
		{
					}
		public float _compareChildOrder(Sprite a, Sprite b)
		{
					}
		public static bool isVisibleTile(float tileId)
		{
					}
		public static bool isAutotile(float tileId)
		{
					}
		public static float getAutotileKind(float tileId)
		{
					}
		public static float getAutotileShape(float tileId)
		{
					}
		public static float makeAutotileId(float kind, float shape)
		{
					}
		public static bool isSameKindTile(float tileID1, float tileID2)
		{
					}
		public static bool isTileA1(float tileId)
		{
					}
		public static bool isTileA2(float tileId)
		{
					}
		public static bool isTileA3(float tileId)
		{
					}
		public static bool isTileA4(float tileId)
		{
					}
		public static bool isTileA5(float tileId)
		{
					}
		public static bool isWaterTile(float tileId)
		{
					}
		public static bool isWaterfallTile(float tileId)
		{
					}
		public static bool isGroundTile(float tileId)
		{
					}
		public static bool isShadowingTile(float tileId)
		{
					}
		public static bool isRoofTile(float tileId)
		{
					}
		public static bool isWallTopTile(float tileId)
		{
					}
		public static bool isWallSideTile(float tileId)
		{
					}
		public static bool isWallTile(float tileId)
		{
					}
		public static bool isFloorTypeAutotile(float tileId)
		{
					}
		public static bool isWallTypeAutotile(float tileId)
		{
					}
		public static bool isWaterfallTypeAutotile(float tileId)
		{
					}

				public class Flags_0_
		{
			
			public bool this[float index]
			{
				get
				{
					return (bool)((dynamic)this)[index];
				}				
				set
				{
					((dynamic)this)[index] = value;
				}
			}
			
		}
	}

		public class ShaderTilemap : Tilemap
	{
		public ShaderTilemap() : base()
		{
			
		}
		public bool roundPixels;
		public float animationFrame;
		public PIXI.tilemap.ZLayer lowerZLayer;
		public PIXI.tilemap.ZLayer upperZLayer;
		public float _lastBitmapLength;
		public float dx;
		public float dy;
		public void renderCanvas(PIXI.CanvasRenderer renderer)
		{
					}
		public void renderWebGL(PIXI.WebGLRenderer renderer)
		{
					}
		public void refresh()
		{
					}
		public void refreshTileset()
		{
					}
		public void updateTransform()
		{
					}
		public PIXI.WebGLRenderer.PIXI.CanvasRenderer _hackRenderer(PIXI.WebGLRenderer.PIXI.CanvasRenderer renderer)
		{
					}
		public void _createLayers()
		{
					}
		public void _updateLayerPositions(float startX, float startY)
		{
					}
		public void _paintAllTiles(float startX, float startY)
		{
					}
		public void _paintTiles(float startX, float startY, float x, float y)
		{
					}
		public void _drawTile(Bitmap bitmap, float tileId, float dx, float dy)
		{
					}
		public float _drawTile(PIXI.tilemap.RectTileLayer layer)
		{
					}
		public void _drawNormalTile(Bitmap bitmap, float tileId, float dx, float dy)
		{
					}
		public float _drawNormalTile(PIXI.tilemap.RectTileLayer layer)
		{
					}
		public void _drawAutotile(Bitmap bitmap, float tileId, float dx, float dy)
		{
					}
		public float _drawAutotile(PIXI.tilemap.RectTileLayer layer)
		{
					}
		public void _drawTableEdge(Bitmap bitmap, float tileId, float dx, float dy)
		{
					}
		public float _drawTableEdge(PIXI.tilemap.RectTileLayer layer)
		{
					}
		public void _drawShadow(Bitmap bitmap, float shadowBits, float dx, float dy)
		{
					}
		public float _drawShadow(PIXI.tilemap.RectTileLayer layer)
		{
					}
	}

		public class TilingSprite : PIXI.extras.TilingSprite
	{
		public TilingSprite(Bitmap bitmap) : base()
		{
			
		}
		protected TilingSprite() : base()
		{
			
		}
		public Bitmap bitmap;
		public float opacity;
		public float spriteId;
		public Point origin;
		public Bitmap _bitmap;
		public float _width;
		public float _height;
		public Rectangle _frame;
		public void _renderCanvas_PIXI(PIXI.CanvasRenderer renderer)
		{
					}
		public void _renderWebGL_PIXI(PIXI.WebGLRenderer renderer)
		{
					}
		public void _renderCanvas(PIXI.CanvasRenderer renderer)
		{
					}
		public void _renderWebGL(PIXI.WebGLRenderer renderer)
		{
					}
		public void _onBitmapLoad()
		{
					}
		public void _refresh()
		{
					}
		public void initialize(Bitmap bitmap)
		{
					}
		public void update()
		{
					}
		public void move(float x = default(float), float y = default(float), float width = default(float), float height = default(float))
		{
					}
		public void setFrame(float x, float y, float width, float height)
		{
					}
		public void updateTransform()
		{
					}
		public void updateTransformTS()
		{
					}
	}

		public class ScreenSprite : PIXI.Container
	{
		public ScreenSprite() : base()
		{
			
		}
		public static bool YEPWarned;
		public PIXI.Graphics _graphics;
		public float _red;
		public float _green;
		public float _blue;
		public string _colorText;
		public float opacity;
		public float anchor;
		public float blendMode;
		public static void warnYep()
		{
					}
		public void initialize()
		{
					}
		public void setBlack()
		{
					}
		public void setWhite()
		{
					}
		public void setColor(float r = default(float), float g = default(float), float b = default(float))
		{
					}
	}

		public class Window : PIXI.Container
	{
		public Window() : base()
		{
			
		}
		public bool _isWindow;
		public Bitmap _windowskin;
		public float _width;
		public float _height;
		public Rectangle _cursorRect;
		public float _openness;
		public float _animationCount;
		public float _padding;
		public float _margin;
		public float[] _colorTone;
		public PIXI.Container _windowSpriteContainer;
		public Sprite _windowBackSprite;
		public Sprite _windowCursorSprite;
		public Sprite _windowFrameSprite;
		public Sprite _windowContentsSprite;
		public Sprite[] _windowArrowSprites;
		public Sprite _windowPauseSignSprite;
		public bool active;
		public Bitmap windowskin;
		public Bitmap contents;
		public float width;
		public float height;
		public float padding;
		public float margin;
		public float opacity;
		public float backOpacity;
		public float contentsOpacity;
		public float openness;
		public Point origin;
		public bool downArrowVisible;
		public bool upArrowVisible;
		public bool pause;
		public void initialize()
		{
					}
		public void update()
		{
					}
		public void move(float x = default(float), float y = default(float), float width = default(float), float height = default(float))
		{
					}
		public bool isOpen()
		{
					}
		public bool isClosed()
		{
					}
		public void setCursorRect(float x = default(float), float y = default(float), float width = default(float), float height = default(float))
		{
					}
		public void setTone(float r, float g, float b)
		{
					}
		public PIXI.DisplayObject addChildToBack(PIXI.DisplayObject child)
		{
					}
		public void updateTransform()
		{
					}
		public void _createAllParts()
		{
					}
		public void _onWindowskinLoad()
		{
					}
		public void _refreshAllParts()
		{
					}
		public void _refreshBack()
		{
					}
		public void _refreshFrame()
		{
					}
		public void _refreshCursor()
		{
					}
		public void _refreshContents()
		{
					}
		public void _refreshArrows()
		{
					}
		public void _refreshPauseSign()
		{
					}
		public void _updateCursor()
		{
					}
		public void _updateContents()
		{
					}
		public void _updateArrows()
		{
					}
		public void _updatePauseSign()
		{
					}
	}

		public class WindowLayer : PIXI.Container
	{
		public WindowLayer() : base()
		{
			
		}
		public static PIXI.filters.VoidFilter voidFilter;
		public float _width;
		public float _height;
		public HTMLCanvasElement _tempCanvas;
		public float[] _translationMatrix;
		public PIXI.Graphics _windowMask;
		public PIXI.Rectangle _windowRect;
		public Sprite _renderSprite;
		public float width;
		public float height;
		public PIXI.Rectangle filterArea;
		public void initialize()
		{
					}
		public void move(float x, float y, float width, float height)
		{
					}
		public void update()
		{
					}
		public void renderCanvas(PIXI.CanvasRenderer renderer)
		{
					}
		public void renderWebGL(PIXI.WebGLRenderer renderer)
		{
					}
		public void onRemoveAsAChild()
		{
					}
		public Window _canvasClearWindowRect(PIXI.CanvasRenderer renderSession)
		{
					}
		public void _maskWindow(Window window, PIXI.Point shift)
		{
					}
	}

		public class Weather : PIXI.Container
	{
		public Weather() : base()
		{
			
		}
		public float _width;
		public float _height;
		public Sprite[] _sprites;
		public Bitmap _rainBitmap;
		public Bitmap _stormBitmap;
		public Bitmap _snowBitmap;
		public ScreenSprite _dimmerSprite;
		public string type;
		public float power;
		public Point origin;
		public void initialize()
		{
					}
		public void update()
		{
					}
		public void _createBitmaps()
		{
					}
		public void _createDimmer()
		{
					}
		public void _updateDimmer()
		{
					}
		public void _updateAllSprites()
		{
					}
		public void _addSprite()
		{
					}
		public void _removeSprite()
		{
					}
		public void _updateSprite(Sprite sprite)
		{
					}
		public void _updateRainSprite(Sprite sprite)
		{
					}
		public void _updateStormSprite(Sprite sprite)
		{
					}
		public void _updateSnowSprite(Sprite sprite)
		{
					}
		public void _rebornSprite(Sprite sprite)
		{
					}
	}

		public class ToneFilter : PIXI.filters.ColorMatrixFilter
	{
		public ToneFilter() : base()
		{
			
		}
		public void adjustHue(float value)
		{
					}
		public void adjustSaturation(float value = default(float))
		{
					}
		public void adjustTone(float r = default(float), float g = default(float), float b = default(float))
		{
					}
	}

		public class ToneSprite : PIXI.Container
	{
		public ToneSprite() : base()
		{
			
		}
		public float _red;
		public float _green;
		public float _blue;
		public float _gray;
		public void initialize()
		{
					}
		public void clear()
		{
					}
		public void setTone(float r = default(float), float g = default(float), float b = default(float), float gray = default(float))
		{
					}
		public void _renderCanvas(PIXI.CanvasRenderer renderer)
		{
					}
		public void _renderWebGL(PIXI.WebGLRenderer renderer)
		{
					}
	}

		public class Stage : PIXI.Container
	{
		public Stage() : base()
		{
			
		}
		public void initialize()
		{
					}
	}

		public class WebAudio
	{
		public WebAudio(string url)
		{
			
		}
		protected WebAudio()
		{
			
		}
		public static float _masterVolume;
		public static AudioContext _context;
		public static GainNode _masterGainNode;
		public static bool _initialized;
		public static bool _unlocked;
		public static bool _canPlayOgg;
		public static bool _canPlayM4a;
		public static typeof _standAlone;
		public object ResourceHandler;
		public string url;
		public float volume;
		public float pitch;
		public float pan;
		public string _url;
		public AudioBuffer _buffer;
		public AudioBufferSourceNode _sourceNode;
		public GainNode _gainNode;
		public PannerNode _pannerNode;
		public float _totalTime;
		public float _sampleRate;
		public float _loopStart;
		public float _loopLength;
		public float _startTime;
		public float _volume;
		public float _pitch;
		public float _pan;
		public float _endTimer;
		public Function[] _loadListeners;
		public Function[] _stopListeners;
		public bool _hasError;
		public bool _autoPlay;
		public static bool initialize(bool noAudio)
		{
					}
		public void initialize(string url)
		{
					}
		public static bool canPlayOgg()
		{
					}
		public static bool canPlayM4a()
		{
					}
		public static void setMasterVolume(float value)
		{
					}
		public static void _createContext()
		{
					}
		public static void _detectCodecs()
		{
					}
		public static void _createMasterGainNode()
		{
					}
		public static void _setupEventHandlers()
		{
					}
		public static void _onTouchStart()
		{
					}
		public static void _onVisibilityChange()
		{
					}
		public static void _onHide()
		{
					}
		public static void _onShow()
		{
					}
		public static bool _shouldMuteOnHide()
		{
					}
		public static void _fadeIn(float duration)
		{
					}
		public static void _fadeOut(float duration)
		{
					}
		public void clear()
		{
					}
		public bool isReady()
		{
					}
		public bool isError()
		{
					}
		public bool isPlaying()
		{
					}
		public void play(bool loop, float offset)
		{
					}
		public void stop()
		{
					}
		public void fadeIn(float duration)
		{
					}
		public void fadeOut(float duration)
		{
					}
		public float seek()
		{
					}
		public void addLoadListener(Function listener)
		{
					}
		public void addStopListener(Function listener)
		{
					}
		public void _load(string url)
		{
					}
		public void _onXhrLoad(XMLHttpRequest xhr)
		{
					}
		public void _startPlaying(bool loop, float offset)
		{
					}
		public void _createNodes()
		{
					}
		public void _connectNodes()
		{
					}
		public void _removeNodes()
		{
					}
		public void _createEndTimer()
		{
					}
		public void _removeEndTimer()
		{
					}
		public void _updatePanner()
		{
					}
		public void _onLoad()
		{
					}
		public void _readLoopComments(Bridge.Html5.Uint8Array array)
		{
					}
		public void _readOgg(Bridge.Html5.Uint8Array array)
		{
					}
		public void _readMp4(Bridge.Html5.Uint8Array array)
		{
					}
		public void _readMetaData(Bridge.Html5.Uint8Array array, float index, float size)
		{
					}
		public void _readLittleEndian(Bridge.Html5.Uint8Array array, float index)
		{
					}
		public void _readBigEndian(Bridge.Html5.Uint8Array array, float index)
		{
					}
		public void _readFourCharacters(Bridge.Html5.Uint8Array array, float index)
		{
					}
	}

		public class Html5Audio
	{
		public Html5Audio()
		{
			
		}
		public static string _url;
		public static bool _initialized;
		public static bool _unlocked;
		public static HTMLAudioElement _audioElement;
		public static float _gainTweenInterval;
		public static float _tweenGain;
		public static float _tweenTargetGain;
		public static float _tweenGainStep;
		public static string _staticSePath;
		public static bool _buffered;
		public static bool _hasError;
		public static bool _autoPlay;
		public static bool _isLoading;
		public static Function[] _loadListeners;
		public static float _volume;
		public static string url;
		public static string volume;
		public static void setup(string url)
		{
					}
		public static bool initialize()
		{
					}
		public static void clear()
		{
					}
		public static void setStaticSe(string url)
		{
					}
		public static void _setupEventHandlers()
		{
					}
		public static void _onTouchStart()
		{
					}
		public static void _onVisibilityChange()
		{
					}
		public static void _onLoadedData()
		{
					}
		public static void _onError()
		{
					}
		public static void _onEnded()
		{
					}
		public static void _onHide()
		{
					}
		public static void _onShow()
		{
					}
		public static bool isReady()
		{
					}
		public static bool isError()
		{
					}
		public static bool isPlaying()
		{
					}
		public static void play(bool loop, float offset)
		{
					}
		public static void stop()
		{
					}
		public static void fadeIn(float duration)
		{
					}
		public static void fadeOut(float duration)
		{
					}
		public static float seek()
		{
					}
		public static void addLoadListener(Function listener)
		{
					}
		public static void _load(string url)
		{
					}
		public static void _startPlaying(bool loop, float offset)
		{
					}
		public static void _onLoad()
		{
					}
		public static void _startGainTween(float duration)
		{
					}
		public static void _applyTweenValue(float volume)
		{
					}
	}

		public class JsonEx
	{
		public JsonEx()
		{
			
		}
		public static float maxDepth;
		public static float _id;
		public static string stringify(object @object)
		{
					}
		public static object parse(string json)
		{
					}
		public static object makeDeepCopy(object @object)
		{
					}
		public static object _encode(object value, object[] circular, float depth)
		{
					}
		public static object _decode(object value, object[] circular, object registry)
		{
					}
		public static object _getConstructorName(object value)
		{
					}
		public static object _resetPrototype(object value, object prototype)
		{
					}
		public static float _generateId()
		{
					}
		public static void _restoreCircularReference(object[] circulars)
		{
					}
		public static void _linkCircularReference(object contents, object[] circulars, object[] registry)
		{
					}
		public static void _cleanMetadata(object @object)
		{
					}
	}

		public class Decrypter
	{
		public Decrypter()
		{
			
		}
		public static bool hasEncryptedImages;
		public static bool hasEncryptedAudio;
		public static string SIGNATURE;
		public static string VER;
		public static string REMAIN;
		public static object[] _requestImgFile;
		public static float _headerlength;
		public static float _xhrOk;
		public static string _encryptionKey;
		public static string[] _ignoreList;
		public static bool checkImgIgnore(string url)
		{
					}
		public static void decryptImg(string url, Bitmap bitmap)
		{
					}
		public static void decryptHTML5Audio(string url, IAudioObject bgm, float pos)
		{
					}
		public static Bridge.Html5.ArrayBuffer cutArrayHeader(Bridge.Html5.ArrayBuffer arrayBuffer, float length)
		{
					}
		public static Bridge.Html5.ArrayBuffer decryptArrayBuffer(Bridge.Html5.ArrayBuffer arrayBuffer)
		{
					}
		public static string createBlobUrl(Bridge.Html5.ArrayBuffer arrayBuffer)
		{
					}
		public static string extToEncryptExt(string url)
		{
					}
		public static void readEncryptionkey()
		{
					}
	}

		public class ResourceHandler
	{
		public ResourceHandler()
		{
			
		}
		public static Function[] _reloaders;
		public static float[] _defaultRetryInterval;
		public static void createLoader(string url, Function retryMethod, Function resignMethod, float retryInterval)
		{
					}
		public static bool exists()
		{
					}
		public static void retry()
		{
					}
	}

		public class IDataSound
	{
		protected IDataSound()
		{
			
		}
		public string name;
		public float pan;
		public float pitch;
		public float volume;
	}

		public class IDataTrait
	{
		protected IDataTrait()
		{
			
		}
		public float code;
		public float dataId;
		public float value;
	}

		public class IDataEffect
	{
		protected IDataEffect()
		{
			
		}
		public float code;
		public float dataId;
		public float value1;
		public float value2;
	}

		public class IDataAction
	{
		protected IDataAction()
		{
			
		}
		public float conditionParam1;
		public float conditionParam2;
		public float conditionType;
		public float rating;
		public float skillId;
	}

		public class IDataList
	{
		protected IDataList()
		{
			
		}
		public float code;
		public float indent;
		public float[] parameters;
	}

		public class IDataMapEventPageList : IDataList
	{
		protected IDataMapEventPageList() : base()
		{
			
		}
		public object[] parameters;
	}

		public class IDataMoveRouteCommand
	{
		protected IDataMoveRouteCommand()
		{
			
		}
		public float code;
		public float[] parameters;
	}

		public class IDataMoveRoute
	{
		protected IDataMoveRoute()
		{
			
		}
		public IDataMoveRouteCommand[] list;
		public bool repeat;
		public bool skippable;
		public bool wait;
	}

		public class IDataActor
	{
		protected IDataActor()
		{
			
		}
		public float id;
		public string battlerName;
		public float characterIndex;
		public string characterName;
		public float classId;
		public float[] equips;
		public float faceIndex;
		public string faceName;
		public IDataTrait[] traits;
		public float initialLevel;
		public float maxLevel;
		public string name;
		public string nickname;
		public string note;
		public string profile;
		public object meta;
	}

		public class IDataClass
	{
		protected IDataClass()
		{
			
		}
		public float id;
		public float[] expParams;
		public IDataTrait[] traits;
		public Learnings_0_[] learnings;
		public string name;
		public string note;
				public float[][] @params;
		public object meta;

				public class Learnings_0_
		{
			public float level;
			public string note;
			public float skillId;
		}
	}

		public class IDataSkill
	{
		protected IDataSkill()
		{
			
		}
		public float id;
		public float animationId;
		public Damage_0_ damage;
		public string description;
		public IDataEffect[] effects;
		public float hitType;
		public float iconIndex;
		public string message1;
		public string message2;
		public float mpCost;
		public string name;
		public string note;
		public float occasion;
		public float repeats;
		public float requiredWtypeId1;
		public float requiredWtypeId2;
		public float scope;
		public float speed;
		public float stypeId;
		public float successRate;
		public float tpCost;
		public float tpGain;
		public object meta;

				public class Damage_0_
		{
			public bool critical;
			public float elementId;
			public string formula;
			public float type;
			public float variance;
		}
	}

		public class IDataAllItem
	{
		protected IDataAllItem()
		{
			
		}
		public float id;
		public string description;
		public string name;
		public string note;
		public float iconIndex;
		public float price;
		public object meta;
	}

		public class IDataItem : IDataAllItem
	{
		protected IDataItem() : base()
		{
			
		}
		public float animationId;
		public bool consumable;
		public Damage_1_ damage;
		public IDataEffect[] effects;
		public float hitType;
		public float itypeId;
		public float occasion;
		public float repeats;
		public float scope;
		public float speed;
		public float successRate;
		public float tpGain;

				public class Damage_1_
		{
			public bool critical;
			public float elementId;
			public string formula;
			public float type;
			public float variance;
		}
	}

		public class IDataEquipItem : IDataAllItem
	{
		protected IDataEquipItem() : base()
		{
			
		}
		public float etypeId;
		public IDataTrait[] traits;
				public float[] @params;
	}

		public class IDataWeapon : IDataEquipItem
	{
		protected IDataWeapon() : base()
		{
			
		}
		public float animationId;
		public float wtypeId;
	}

		public class IDataArmor : IDataEquipItem
	{
		protected IDataArmor() : base()
		{
			
		}
		public float atypeId;
	}

		public class IDataDropItem
	{
		protected IDataDropItem()
		{
			
		}
		public float kind;
		public float dataId;
		public float denominator;
	}

		public class IDataEnemy
	{
		protected IDataEnemy()
		{
			
		}
		public float id;
		public IDataAction[] actions;
		public float battlerHue;
		public string battlerName;
		public IDataDropItem[] dropItems;
		public float exp;
		public IDataTrait[] traits;
		public float gold;
		public string name;
		public string note;
				public float[] @params;
		public object meta;
	}

		public class IDataPage
	{
		protected IDataPage()
		{
			
		}
		public Conditions_0_ conditions;
		public List_0_[] list;
		public float span;

				public class Conditions_0_
		{
			public float actorHP;
			public float actorId;
			public bool actorValid;
			public float enemyHp;
			public float enemyIndex;
			public bool enemyValid;
			public float switchId;
			public bool switchValid;
			public float turnA;
			public float turnB;
			public bool turnEnding;
			public bool turnValid;
		}

				public class List_0_
		{
			public float code;
			public float indent;
			public float[] parameters;
		}
	}

		public class IDataTroop
	{
		protected IDataTroop()
		{
			
		}
		public float id;
		public Members_0_[] members;
		public string name;
		public IDataPage[] pages;
		public object meta;

				public class Members_0_
		{
			public float enemyId;
			public float x;
			public float y;
			public bool hidden;
		}
	}

		public class IDataState
	{
		protected IDataState()
		{
			
		}
		public float id;
		public float autoRemovalTiming;
		public float chanceByDamage;
		public float iconIndex;
		public float maxTurns;
		public string message1;
		public string message2;
		public string message3;
		public string message4;
		public float minTurns;
		public float motion;
		public string name;
		public string note;
		public float overlay;
		public float priority;
		public bool releaseByDamage;
		public bool removeAtBattleEnd;
		public bool removeByDamage;
		public bool removeByRestriction;
		public bool removeByWalking;
		public float restriction;
		public float stepsToRemove;
		public IDataTrait[] traits;
	}

		public class IDataAnimationTiming
	{
		protected IDataAnimationTiming()
		{
			
		}
		public float[] flashColor;
		public float flashDuration;
		public float flashScope;
		public float frame;
		public IDataSound se;
	}

		public class IDataAnimation
	{
		protected IDataAnimation()
		{
			
		}
		public float id;
		public float animation1Hue;
		public string animation1Name;
		public float animation2Hue;
		public string animation2Name;
		public float[][][] frames;
		public string name;
		public float position;
		public IDataAnimationTiming[] timings;
		public object meta;
	}

		public class IDataTileset
	{
		protected IDataTileset()
		{
			
		}
		public float id;
		public float[] flags;
		public float mode;
		public string name;
		public string note;
		public string[] tilesetNames;
		public object meta;
	}

		public class IDataCommonEvent
	{
		protected IDataCommonEvent()
		{
			
		}
		public float id;
		public IDataList[] list;
		public string name;
		public float switchId;
		public float trigger;
		public object meta;
	}

		public class IVehicle
	{
		protected IVehicle()
		{
			
		}
		public IDataSound bgm;
		public float characterIndex;
		public string characterName;
		public float startMapId;
		public float startX;
		public float startY;
	}

		public class IDataSystem
	{
		protected IDataSystem()
		{
			
		}
		public IVehicle airship;
		public string[] armorTypes;
		public AttackMotions_0_[] attackMotions;
		public IDataSound battleBgm;
		public string battleback1Name;
		public string battleback2Name;
		public float battlerHue;
		public string battlerName;
		public IVehicle boat;
		public string currencyUnit;
		public IDataSound defeatMe;
		public float editMapId;
		public string[] elements;
		public string[] equipTypes;
		public string gameTitle;
		public IDataSound gameoverMe;
		public string locale;
		public float[] magicSkills;
		public bool[] menuCommands;
		public bool optDisplayTp;
		public bool optDrawTitle;
		public bool optExtraExp;
		public bool optFloorDeath;
		public bool optFollowers;
		public bool optSideView;
		public bool optSlipDeath;
		public bool optTransparent;
		public float[] partyMembers;
		public IVehicle ship;
		public string[] skillTypes;
		public IDataSound[] sounds;
		public float startMapId;
		public float startX;
		public float startY;
		public string[] switches;
		public Terms_0_ terms;
		public TestBattlers_0_[] testBattlers;
		public float testTroopId;
		public string title1Name;
		public string title2Name;
		public IDataSound titleBgm;
		public string[] variables;
		public float versionId;
		public IDataSound victoryMe;
		public string weaponTypes;
		public float[] windowTone;
		public object meta;

				public class AttackMotions_0_
		{
			public float type;
			public float weaponImageId;
		}

				public class Messages_0_
		{
			public string possession;
			public string expTotal;
			public string expNext;
			public string saveMessage;
			public string loadMessage;
			public string file;
			public string partyName;
			public string emerge;
			public string preemptive;
			public string surprise;
			public string escapeStart;
			public string escapeFailure;
			public string victory;
			public string defeat;
			public string obtainExp;
			public string obtainGold;
			public string obtainItem;
			public string levelUp;
			public string obtainSkill;
			public string useItem;
			public string criticalToEnemy;
			public string criticalToActor;
			public string actorDamage;
			public string actorRecovery;
			public string actorGain;
			public string actorLoss;
			public string actorDrain;
			public string actorNoDamage;
			public string actorNoHit;
			public string enemyDamage;
			public string enemyRecovery;
			public string enemyGain;
			public string enemyLoss;
			public string enemyDrain;
			public string enemyNoDamage;
			public string enemyNoHit;
			public string evasion;
			public string magicEvasion;
			public string magicReflection;
			public string counterAttack;
			public string substitute;
			public string buffAdd;
			public string debuffAdd;
			public string buffRemove;
			public string actionFailure;
			public string bgmVolume;
			public string bgsVolume;
			public string meVolume;
			public string seVolume;
			public string alwaysDash;
			public string commandRemember;
		}

				public class Terms_0_
		{
			public string[] basic;
			public string[] commands;
			public string[] params;
			public Messages_0_ messages;
		}

				public class TestBattlers_0_
		{
			public float actorId;
			public float[] equips;
			public float level;
		}
	}

		public class IDataMapInfo
	{
		protected IDataMapInfo()
		{
			
		}
		public float id;
		public bool expanded;
		public string name;
		public float order;
		public float parentId;
		public float scrollX;
		public float scrollY;
		public object meta;
	}

		public class IDataEncounterList
	{
		protected IDataEncounterList()
		{
			
		}
		public float[] regionSet;
		public float troopId;
		public float weight;
	}

		public class IDataMapEventPage
	{
		protected IDataMapEventPage()
		{
			
		}
		public Conditions_1_ conditions;
		public bool directionFix;
		public Image_0_ image;
		public IDataMapEventPageList[] list;
		public float moveFrequency;
		public MoveRoute_0_ moveRoute;
		public float moveSpeed;
		public float moveType;
		public float priorityType;
		public bool stepAnime;
		public bool through;
		public float trigger;
		public bool walkAnime;

				public class Conditions_1_
		{
			public float actorId;
			public bool actorValid;
			public float itemId;
			public bool itemValid;
			public string selfSwitchCh;
			public bool selfSwitchValid;
			public float switch1Id;
			public bool switch1Valid;
			public float switch2Id;
			public bool switch2Valid;
			public float variableId;
			public bool variableValid;
			public float variableValue;
		}

				public class Image_0_
		{
			public float tileId;
			public string characterName;
			public float direction;
			public float pattern;
			public float characterIndex;
		}

				public class List_1_
		{
			public float code;
			public float[] parameters;
		}

				public class MoveRoute_0_
		{
			public List_1_[] list;
			public bool repeat;
			public bool skippable;
			public bool wait;
		}
	}

		public class IDataMapEvent
	{
		protected IDataMapEvent()
		{
			
		}
		public float id;
		public string name;
		public string note;
		public IDataMapEventPage[] pages;
	}

		public class IDataMap
	{
		protected IDataMap()
		{
			
		}
		public bool autoplayBgm;
		public bool autoplayBgs;
		public string battleback1Name;
		public string battleback2Name;
		public IDataSound bgm;
		public IDataSound bgs;
		public bool disableDashing;
		public string displayName;
		public IDataEncounterList[] encounterList;
		public float encounterStep;
		public float height;
		public string note;
		public bool parallaxLoopX;
		public bool parallaxLoopY;
		public string parallaxName;
		public bool parallaxShow;
		public float parallaxSx;
		public float parallaxSy;
		public float scrollType;
		public bool specifyBattleback;
		public float tilesetId;
		public float width;
		public float[] data;
		public IDataMapEvent[] events;
		public object meta;
	}

		public class ISavefileInfo
	{
		protected ISavefileInfo()
		{
			
		}
		public float globalId;
		public string title;
		public object characters;
		public object faces;
		public string playtime;
		public float timestamp;
	}

		public class ISaveContents
	{
		protected ISaveContents()
		{
			
		}
		public Game_System system;
		public Game_Screen screen;
		public Game_Timer timer;
		public Game_Switches switches;
		public Game_Variables variables;
		public Game_SelfSwitches selfSwitches;
		public Game_Actors actors;
		public Game_Party party;
		public Game_Map map;
		public Game_Player player;
	}

		public class DataManager
	{
		public DataManager()
		{
			
		}
		public static float _globalId;
		public static float _lastAccessedId;
		public static string _errorUrl;
		public static _databaseFiles_0_[] _databaseFiles;
		public static void loadDatabase()
		{
					}
		public static void loadDataFile(string name, string src)
		{
					}
		public static bool isDatabaseLoaded()
		{
					}
		public static void loadMapData(float mapId)
		{
					}
		public static void makeEmptyMap()
		{
					}
		public static bool isMapLoaded()
		{
					}
		public static void onLoad(Any<IDataActor[], IDataClass[], IDataSkill[], IDataItem[], IDataWeapon[], IDataArmor[], IDataEnemy[], IDataTroop[], IDataState[], IDataAnimation[], IDataTileset[], IDataCommonEvent[], IDataSystem[], IDataMapInfo[], IDataMap[]> @object)
		{
					}
		public static void extractMetadata(Any<IDataActor[], IDataClass[], IDataSkill[], IDataItem[], IDataWeapon[], IDataArmor[], IDataEnemy[], IDataTroop[], IDataState[], IDataAnimation[], IDataTileset[], IDataCommonEvent[], IDataSystem[], IDataMapInfo[], IDataMap[]> data)
		{
					}
		public static void checkError()
		{
					}
		public static bool isBattleTest()
		{
					}
		public static bool isEventTest()
		{
					}
		public static bool isSkill(IDataSkill item)
		{
					}
		public static bool isItem(IDataItem item)
		{
					}
		public static bool isWeapon(IDataWeapon item)
		{
					}
		public static bool isArmor(IDataArmor item)
		{
					}
		public static void createGameObjects()
		{
					}
		public static void setupNewGame()
		{
					}
		public static void setupBattleTest()
		{
					}
		public static void setupEventTest()
		{
					}
		public static void loadGlobalInfo()
		{
					}
		public static void saveGlobalInfo(ISavefileInfo[] info)
		{
					}
		public static bool isThisGameFile(float savefileId)
		{
					}
		public static bool isAnySavefileExists()
		{
					}
		public static float latestSavefileId()
		{
					}
		public static void loadAllSavefileImages()
		{
					}
		public static void loadSavefileImages(ISavefileInfo info)
		{
					}
		public static float maxSavefiles()
		{
					}
		public static bool saveGame(float savefileId)
		{
					}
		public static bool loadGame(float savefileId)
		{
					}
		public static ISavefileInfo loadSavefileInfo(float savefileId)
		{
					}
		public static float lastAccessedSavefileId()
		{
					}
		public static bool saveGameWithoutRescue(float savefileId)
		{
					}
		public static bool loadGameWithoutRescue(float savefileId)
		{
					}
		public static void selectSavefileForNewGame()
		{
					}
		public static ISavefileInfo makeSavefileInfo()
		{
					}
		public static ISaveContents makeSaveContents()
		{
					}
		public static void extractSaveContents(ISaveContents contents)
		{
					}

				public class _databaseFiles_0_
		{
			public string name;
			public string src;
		}
	}

		public class IConfig
	{
		protected IConfig()
		{
			
		}
		public bool alwaysDash;
		public bool commandRemember;
		public float bgmVolume;
		public float bgsVolume;
		public float meVolume;
		public float seVolume;
	}

		public class ConfigManager
	{
		public ConfigManager()
		{
			
		}
		public static bool alwaysDash;
		public static bool commandRemember;
		public static float bgmVolume;
		public static float bgsVolume;
		public static float meVolume;
		public static float seVolume;
		public static void load()
		{
					}
		public static void save()
		{
					}
		public static IConfig makeData()
		{
					}
		public static void applyData(IConfig config)
		{
					}
		public static bool readFlag(IConfig config, string name)
		{
					}
		public static float readVolume(IConfig config, string name)
		{
					}
	}

		public class StorageManager
	{
		public StorageManager()
		{
			
		}
		public static void save(float savefileId, object json)
		{
					}
		public static object load(float savefileId)
		{
					}
		public static bool exists(float savefileId)
		{
					}
		public static void remove(float savefileId)
		{
					}
		public static void backup(float savefileId)
		{
					}
		public static void backupExists(float savefileId)
		{
					}
		public static void cleanBackup(float savefileId)
		{
					}
		public static void restoreBackup(float savefileId)
		{
					}
		public static bool isLocalMode()
		{
					}
		public static void saveToLocalFile(float savefileId, object json)
		{
					}
		public static object loadFromLocalFile(float savefileId)
		{
					}
		public static object loadFromLocalBackupFile(float savefileId)
		{
					}
		public static bool localFileBackupExists(float savefileId)
		{
					}
		public static bool localFileExists(float savefileId)
		{
					}
		public static void removeLocalFile(float savefileId)
		{
					}
		public static void saveToWebStorage(float savefileId, object json)
		{
					}
		public static object loadFromWebStorage(float savefileId)
		{
					}
		public static object loadFromWebStorageBackup(float savefileId)
		{
					}
		public static bool webStorageBackupExists(float savefileId)
		{
					}
		public static bool webStorageExists(float savefileId)
		{
					}
		public static void removeWebStorage(float savefileId)
		{
					}
		public static string localFileDirectoryPath()
		{
					}
		public static string localFilePath(float savefileId)
		{
					}
		public static string webStorageKey(float savefileId)
		{
					}
	}

		public class ImageManager
	{
		public ImageManager()
		{
			
		}
		public static ImageCache _imageCache;
		public static float _systemReservationId;
		public static CacheMap cache;
		public static string _generateCacheKey()
		{
					}
		public static Bitmap loadAnimation(string filename, float hue = default(float))
		{
					}
		public static Bitmap loadBattleback1(string filename, float hue = default(float))
		{
					}
		public static Bitmap loadBattleback2(string filename, float hue = default(float))
		{
					}
		public static Bitmap loadEnemy(string filename, float hue = default(float))
		{
					}
		public static Bitmap loadCharacter(string filename, float hue = default(float))
		{
					}
		public static Bitmap loadFace(string filename, float hue = default(float))
		{
					}
		public static Bitmap loadParallax(string filename, float hue = default(float))
		{
					}
		public static Bitmap loadPicture(string filename, float hue = default(float))
		{
					}
		public static Bitmap loadSvActor(string filename, float hue = default(float))
		{
					}
		public static Bitmap loadSvEnemy(string filename, float hue = default(float))
		{
					}
		public static Bitmap loadSystem(string filename, float hue = default(float))
		{
					}
		public static Bitmap loadTileset(string filename, float hue = default(float))
		{
					}
		public static Bitmap loadTitle1(string filename, float hue = default(float))
		{
					}
		public static Bitmap loadTitle2(string filename, float hue = default(float))
		{
					}
		public static Bitmap loadBitmap(string folder, string filename, float hue = default(float), bool smooth = default(bool))
		{
					}
		public static Bitmap loadEmptyBitmap()
		{
					}
		public static Bitmap loadNormalBitmap(string path, float hue)
		{
					}
		public static void clear()
		{
					}
		public static bool isReady()
		{
					}
		public static bool isObjectCharacter()
		{
					}
		public static bool isBigCharacter()
		{
					}
		public static bool isZeroParallax()
		{
					}
		public static Bitmap reserveAnimation(string filename, float hue, float reservationId)
		{
					}
		public static Bitmap reserveBattleback1(string filename, float hue, float reservationId)
		{
					}
		public static Bitmap reserveBattleback2(string filename, float hue, float reservationId)
		{
					}
		public static Bitmap reserveEnemy(string filename, float hue, float reservationId)
		{
					}
		public static Bitmap reserveCharacter(string filename, float hue, float reservationId)
		{
					}
		public static Bitmap reserveFace(string filename, float hue, float reservationId)
		{
					}
		public static Bitmap reserveParallax(string filename, float hue, float reservationId)
		{
					}
		public static Bitmap reservePicture(string filename, float hue, float reservationId)
		{
					}
		public static Bitmap reserveSvActor(string filename, float hue, float reservationId)
		{
					}
		public static Bitmap reserveSvEnemy(string filename, float hue, float reservationId)
		{
					}
		public static Bitmap reserveSystem(string filename, float hue, float reservationId)
		{
					}
		public static Bitmap reserveTileset(string filename, float hue, float reservationId)
		{
					}
		public static Bitmap reserveTitle1(string filename, float hue, float reservationId)
		{
					}
		public static Bitmap reserveTitle2(string filename, float hue, float reservationId)
		{
					}
		public static Bitmap reserveBitmap(string folder, string filename, float hue, bool smooth, float reservationId)
		{
					}
		public static Bitmap reserveNormalBitmap(string path, float hue, float reservationId)
		{
					}
		public static void releaseReservation(float reservationId)
		{
					}
		public static void setDefaultReservationId(float reservationId)
		{
					}
		public static Bitmap requestAnimation(string filename, float hue)
		{
					}
		public static Bitmap requestBattleback1(string filename, float hue)
		{
					}
		public static Bitmap requestBattleback2(string filename, float hue)
		{
					}
		public static Bitmap requestEnemy(string filename, float hue)
		{
					}
		public static Bitmap requestCharacter(string filename, float hue)
		{
					}
		public static Bitmap requestFace(string filename, float hue)
		{
					}
		public static Bitmap requestParallax(string filename, float hue)
		{
					}
		public static Bitmap requestPicture(string filename, float hue)
		{
					}
		public static Bitmap requestSvActor(string filename, float hue)
		{
					}
		public static Bitmap requestSvEnemy(string filename, float hue)
		{
					}
		public static Bitmap requestSystem(string filename, float hue)
		{
					}
		public static Bitmap requestTileset(string filename, float hue)
		{
					}
		public static Bitmap requestTitle1(string filename, float hue)
		{
					}
		public static Bitmap requestTitle2(string filename, float hue)
		{
					}
		public static Bitmap requestBitmap(string folder, string filename, float hue, bool smooth)
		{
					}
		public static Bitmap requestNormalBitmap(string path, float hue)
		{
					}
		public static void update()
		{
					}
		public static void clearRequest()
		{
					}
	}

		public class IAudioObject
	{
		protected IAudioObject()
		{
			
		}
		public string name;
		public float volume;
		public float pitch;
		public float pan;
		public float pos;
	}

		public class AudioManager
	{
		public AudioManager()
		{
			
		}
		public static float _masterVolume;
		public static float _bgmVolume;
		public static float _bgsVolume;
		public static float _meVolume;
		public static float _seVolume;
		public static IAudioObject _currentBgm;
		public static IAudioObject _currentBgs;
		public static Any<WebAudio, Html5Audio> _bgmBuffer;
		public static WebAudio _bgsBuffer;
		public static WebAudio _meBuffer;
		public static WebAudio[] _seBuffers;
		public static WebAudio[] _staticBuffers;
		public static float _replayFadeTime;
		public static string _path;
		public static string _blobUrl;
		public static float bgmVolume;
		public static float bgsVolume;
		public static float meVolume;
		public static float seVolume;
		public static void playBgm(IAudioObject bgm, float pos)
		{
					}
		public static void playEncryptedBgm(IAudioObject bgm, float pos)
		{
					}
		public static void createDecryptBuffer(string url, IAudioObject bgm, float pos)
		{
					}
		public static void replayBgm(IAudioObject bgm)
		{
					}
		public static bool isCurrentBgm(IAudioObject bgm)
		{
					}
		public static void updateBgmParameters(IAudioObject bgm)
		{
					}
		public static void updateCurrentBgm(IAudioObject bgm, float pos)
		{
					}
		public static void stopBgm()
		{
					}
		public static void fadeOutBgm(float duration)
		{
					}
		public static void fadeInBgm(float duration)
		{
					}
		public static void playBgs(IAudioObject bgs, float pos)
		{
					}
		public static void replayBgs(IAudioObject bgs)
		{
					}
		public static bool isCurrentBgs(IAudioObject bgs)
		{
					}
		public static void updateBgsParameters(IAudioObject bgs)
		{
					}
		public static void updateCurrentBgs(IAudioObject bgs, float pos)
		{
					}
		public static void stopBgs()
		{
					}
		public static void fadeOutBgs(float duration)
		{
					}
		public static void fadeInBgs(float duration)
		{
					}
		public static void playMe(IDataSound me)
		{
					}
		public static void updateMeParameters(IDataSound me)
		{
					}
		public static void fadeOutMe(float duration)
		{
					}
		public static void stopMe()
		{
					}
		public static void playSe(IDataSound se)
		{
					}
		public static void updateSeParameters(Any<WebAudio, Html5Audio> buffer, IDataSound se)
		{
					}
		public static void stopSe()
		{
					}
		public static void playStaticSe(IDataSound se)
		{
					}
		public static void loadStaticSe(IDataSound se)
		{
					}
		public static bool isStaticSe(IDataSound se)
		{
					}
		public static void stopAll()
		{
					}
		public static IAudioObject saveBgm()
		{
					}
		public static IAudioObject saveBgs()
		{
					}
		public static IAudioObject makeEmptyAudioObject()
		{
					}
		public static Any<Html5Audio, WebAudio> createBuffer(float folder, string name)
		{
					}
		public static void updateBufferParameters(IAudioObject buffer, float configVolume, IAudioObject audio)
		{
					}
		public static string audioFileExt()
		{
					}
		public static bool shouldUseHtml5Audio()
		{
					}
		public static void checkErrors()
		{
					}
		public static void checkWebAudioError(WebAudio webAudio)
		{
					}
	}

		public class SoundManager
	{
		public SoundManager()
		{
			
		}
		public static void preloadImportantSounds()
		{
					}
		public static void loadSystemSound(float n)
		{
					}
		public static void playSystemSound(float n)
		{
					}
		public static void playCursor()
		{
					}
		public static void playOk()
		{
					}
		public static void playCancel()
		{
					}
		public static void playBuzzer()
		{
					}
		public static void playEquip()
		{
					}
		public static void playSave()
		{
					}
		public static void playLoad()
		{
					}
		public static void playBattleStart()
		{
					}
		public static void playEscapeion()
		{
					}
		public static void playEnemyAttack()
		{
					}
		public static void playEnemyDamage()
		{
					}
		public static void playEnemyCollapse()
		{
					}
		public static void playBossCollapse1()
		{
					}
		public static void playBossCollapse2()
		{
					}
		public static void playActorDamage()
		{
					}
		public static void playActorCollapse()
		{
					}
		public static void playRecoveryion()
		{
					}
		public static void playMiss()
		{
					}
		public static void playEvasionion()
		{
					}
		public static void playMagicEvasion()
		{
					}
		public static void playReflectioni()
		{
					}
		public static void playShop()
		{
					}
		public static void playUseItem()
		{
					}
		public static void playUseSkill()
		{
					}
	}

		public class TextManager
	{
		public TextManager()
		{
			
		}
		public static string currencyUnit;
		public static string level;
		public static string levelA;
		public static string hp;
		public static string hpA;
		public static string mp;
		public static string mpA;
		public static string tp;
		public static string tpA;
		public static string exp;
		public static string expA;
		public static string fight;
		public static string escape;
		public static string attack;
		public static string guard;
		public static string item;
		public static string skill;
		public static string equip;
		public static string status;
		public static string formation;
		public static string save;
		public static string gameEnd;
		public static string options;
		public static string weapon;
		public static string armor;
		public static string keyItem;
		public static string equip2;
		public static string optimize;
		public static string clear;
		public static string newGame;
		public static string continue_;
		public static string toTitle;
		public static string cancel;
		public static string buy;
		public static string sell;
		public static string alwaysDash;
		public static string commandRemember;
		public static string bgmVolume;
		public static string bgsVolume;
		public static string meVolume;
		public static string seVolume;
		public static string possession;
		public static string expTotal;
		public static string expNext;
		public static string saveMessage;
		public static string loadMessage;
		public static string file;
		public static string partyName;
		public static string emerge;
		public static string preemptive;
		public static string surprise;
		public static string escapeStart;
		public static string escapeFailure;
		public static string victory;
		public static string defeat;
		public static string obtainExp;
		public static string obtainGold;
		public static string obtainItem;
		public static string levelUp;
		public static string obtainSkill;
		public static string useItem;
		public static string criticalToEnemy;
		public static string criticalToActor;
		public static string actorDamage;
		public static string actorRecovery;
		public static string actorGain;
		public static string actorLoss;
		public static string actorDrain;
		public static string actorNoDamage;
		public static string actorNoHit;
		public static string enemyDamage;
		public static string enemyRecovery;
		public static string enemyGain;
		public static string enemyLoss;
		public static string enemyDrain;
		public static string enemyNoDamage;
		public static string enemyNoHit;
		public static string evasion;
		public static string magicEvasion;
		public static string magicReflection;
		public static string counterAttack;
		public static string substitute;
		public static string buffAdd;
		public static string debuffAdd;
		public static string buffRemove;
		public static string actionFailure;
		public static string basic(float basicId)
		{
					}
		public static string param(float paramId)
		{
					}
		public static string command(float commandId)
		{
					}
		public static string message(float messageId)
		{
					}
		public static Function getter(Function method, float param)
		{
					}
	}

		public class SceneManager
	{
		public SceneManager()
		{
			
		}
		public static float _getTimeInMsWithoutMobileSafari;
		public static Scene_Base _scene;
		public static Scene_Base _nextScene;
		public static typeof _stack;
		public static bool _stopped;
		public static bool _sceneStarted;
		public static bool _exiting;
		public static typeof _previousClass;
		public object Scene_Base;
		public static Bitmap _backgroundBitmap;
		public static float _screenWidth;
		public static float _screenHeight;
		public static float _boxWidth;
		public static float _boxHeight;
		public static float _deltaTime;
		public static float _currentTime;
		public static float _accumulator;
		public static void run(typeof sceneClass)
		{
					}
		public static void initialize()
		{
					}
		public static void initGraphics()
		{
					}
		public static string preferableRendererType()
		{
					}
		public static bool shouldUseCanvasRenderer()
		{
					}
		public static void checkWebGL()
		{
					}
		public static void checkFileAccess()
		{
					}
		public static void initAudio()
		{
					}
		public static void initInput()
		{
					}
		public static void initNwjs()
		{
					}
		public static void checkPluginErrors()
		{
					}
		public static void setupErrorHandlers()
		{
					}
		public static void requestUpdate()
		{
					}
		public static void update()
		{
					}
		public static void terminate()
		{
					}
		public static void onError(ErrorEvent e)
		{
					}
		public static void onKeyDown(KeyboardEvent @event)
		{
					}
		public static void catchException(ErrorEvent e)
		{
					}
		public static void tickStart()
		{
					}
		public static void tickEnd()
		{
					}
		public static void updateInputData()
		{
					}
		public static void updateMain()
		{
					}
		public static void updateManagers()
		{
					}
		public static void changeScene()
		{
					}
		public static void updateScene()
		{
					}
		public static void renderScene()
		{
					}
		public static void onSceneCreate()
		{
					}
		public static void onSceneStart()
		{
					}
		public static void onSceneLoading()
		{
					}
		public static bool isSceneChanging()
		{
					}
		public static bool isCurrentSceneBusy()
		{
					}
		public static bool isCurrentSceneStarted()
		{
					}
		public static bool isNextScene(typeof sceneClass)
		{
					}
		public static bool isPreviousScene(typeof sceneClass)
		{
					}
		public static void goto(typeof sceneClass)
		{
					}
		public static void push(typeof sceneClass)
		{
					}
		public static void pop()
		{
					}
		public static void exit()
		{
					}
		public static void clearStack()
		{
					}
		public static void stop()
		{
					}
		public static void prepareNextScene()
		{
					}
		public static void snap()
		{
					}
		public static void snapForBackground()
		{
					}
		public static Bitmap backgroundBitmap()
		{
					}
		public static void resume()
		{
					}
	}

		public class IDataRewards
	{
		protected IDataRewards()
		{
			
		}
		public float gold;
		public float exp;
		public IDataAllItem[] items;
	}

		public class BattleManager
	{
		public BattleManager()
		{
			
		}
		public static string _phase;
		public static bool _canEscape;
		public static bool _canLose;
		public static bool _battleTest;
		public static Function _eventCallback;
		public static bool _preemptive;
		public static bool _surprise;
		public static float _actorIndex;
		public static Game_Battler _actionForcedBattler;
		public static IAudioObject _mapBgm;
		public static IAudioObject _mapBgs;
		public static Game_Battler[] _actionBattlers;
		public static Game_Battler _subject;
		public static Game_Action _action;
		public static Game_Battler[] _targets;
		public static Window_BattleLog _logWindow;
		public static Window_BattleStatus _statusWindow;
		public static Spriteset_Battle _spriteset;
		public static float _escapeRatio;
		public static bool _escaped;
		public static IDataRewards _rewards;
		public static void setup(float troopId, bool canEscape, bool canLose)
		{
					}
		public static void initMembers()
		{
					}
		public static bool isBattleTest()
		{
					}
		public static void setBattleTest(bool battleTest)
		{
					}
		public static void setEventCallback(Function callback)
		{
					}
		public static void setLogWindow(Window_BattleLog logWindow)
		{
					}
		public static void setStatusWindow(Window_BattleStatus statusWindow)
		{
					}
		public static void setSpriteset(Spriteset_Battle spriteset)
		{
					}
		public static void onEncounter()
		{
					}
		public static float ratePreemptive()
		{
					}
		public static float rateSurprise()
		{
					}
		public static void saveBgmAndBgs()
		{
					}
		public static void playBattleBgm()
		{
					}
		public static void playVictoryMe()
		{
					}
		public static void playDefeatMe()
		{
					}
		public static void replayBgmAndBgs()
		{
					}
		public static void makeEscapeRatio()
		{
					}
		public static void update()
		{
					}
		public static bool updateEvent()
		{
					}
		public static bool updateEventMain()
		{
					}
		public static bool isBusy()
		{
					}
		public static bool isInputting()
		{
					}
		public static bool isInTurn()
		{
					}
		public static bool isTurnEnd()
		{
					}
		public static bool isAborting()
		{
					}
		public static bool isBattleEnd()
		{
					}
		public static bool canEscape()
		{
					}
		public static bool canLose()
		{
					}
		public static bool isEscaped()
		{
					}
		public static Game_Actor actor()
		{
					}
		public static void clearActor()
		{
					}
		public static void changeActor(float newActorIndex, string lastActorActionState)
		{
					}
		public static void startBattle()
		{
					}
		public static void displayStartMessages()
		{
					}
		public static void startInput()
		{
					}
		public static Game_Action inputtingAction()
		{
					}
		public static void selectNextCommand()
		{
					}
		public static void selectPreviousCommand()
		{
					}
		public static void refreshStatus()
		{
					}
		public static void startTurn()
		{
					}
		public static void updateTurn()
		{
					}
		public static void processTurn()
		{
					}
		public static void endTurn()
		{
					}
		public static void updateTurnEnd()
		{
					}
		public static void getNextSubject()
		{
					}
		public static Game_Battler allBattleMembers()
		{
					}
		public static void makeActionOrders()
		{
					}
		public static void startAction()
		{
					}
		public static void updateAction()
		{
					}
		public static void endAction()
		{
					}
		public static void invokeAction(Game_Battler subject, Game_Battler target)
		{
					}
		public static void invokeNormalAction(Game_Battler subject, Game_Battler target)
		{
					}
		public static void invokeCounterAttack(Game_Battler subject, Game_Battler target)
		{
					}
		public static void invokeMagicReflection(Game_Battler subject, Game_Battler target)
		{
					}
		public static Game_Battler applySubstitute(Game_Battler target)
		{
					}
		public static Game_Battler checkSubstitute(Game_Battler target)
		{
					}
		public static bool isActionForced()
		{
					}
		public static void forceAction(Game_Battler battler)
		{
					}
		public static void processForcedAction()
		{
					}
		public static void abort()
		{
					}
		public static bool checkBattleEnd()
		{
					}
		public static bool checkAbort()
		{
					}
		public static bool checkAbort2()
		{
					}
		public static void processVictory()
		{
					}
		public static bool processEscape()
		{
					}
		public static void processAbort()
		{
					}
		public static void processDefeat()
		{
					}
		public static void endBattle(float result)
		{
					}
		public static void updateBattleEnd()
		{
					}
		public static void makeRewards()
		{
					}
		public static void displayVictoryMessage()
		{
					}
		public static void displayDefeatMessage()
		{
					}
		public static void makeRewadisplayEscapeSuccessMessagerds()
		{
					}
		public static void displayEscapeFailureMessage()
		{
					}
		public static void displayRewards()
		{
					}
		public static void displayExp()
		{
					}
		public static void displayGold()
		{
					}
		public static void displayDropItems()
		{
					}
		public static void gainRewards()
		{
					}
		public static void gainExp()
		{
					}
		public static void gainGold()
		{
					}
		public static void gainDropItems()
		{
					}
	}

		public class IDataPlugin
	{
		protected IDataPlugin()
		{
			
		}
		public string name;
		public bool status;
		public string description;
		public PluginParameters parameters;
	}
}

namespace GLOBAL
{

		public class PluginManager
	{
		public PluginManager()
		{
			
		}
		public static string _path;
		public static string[] _scripts;
		public static string[] _errorUrls;
		public static PluginParameters _parameters;
		public static void setup(IDataPlugin[] plugins)
		{
					}
		public static void checkErrors()
		{
					}
		public static PluginParameters parameters(string name)
		{
					}
		public static void setParameters(string name, PluginParameters parameters)
		{
					}
		public static void loadScript(string name)
		{
					}
		public static void onError(ErrorEvent e)
		{
					}
	}

		public class Game_Temp
	{
		public Game_Temp()
		{
			
		}
		public bool _isPlaytest;
		public float _commonEventId;
		public float _destinationX;
		public float _destinationY;
		public void initialize()
		{
					}
		public bool isPlaytest()
		{
					}
		public void reserveCommonEvent(float commonEventId)
		{
					}
		public void clearCommonEvent()
		{
					}
		public bool isCommonEventReserved()
		{
					}
		public IDataCommonEvent reservedCommonEvent()
		{
					}
		public void setDestination(float x, float y)
		{
					}
		public void clearDestination()
		{
					}
		public void isDestinationValid()
		{
					}
		public float destinationX()
		{
					}
		public float destinationY()
		{
					}
	}

		public class Game_System
	{
		public Game_System()
		{
			
		}
		public bool _saveEnabled;
		public bool _menuEnabled;
		public bool _encounterEnabled;
		public bool _formationEnabled;
		public float _battleCount;
		public float _winCount;
		public float _escapeCount;
		public float _saveCount;
		public float _versionId;
		public float _framesOnSave;
		public IAudioObject _bgmOnSave;
		public IAudioObject _bgsOnSave;
		public float[] _windowTone;
		public IDataSound _battleBgm;
		public IDataSound _victoryMe;
		public IDataSound _defeatMe;
		public IDataSound _savedBgm;
		public IDataSound _walkingBgm;
		public void initialize()
		{
					}
		public bool isJapanese()
		{
					}
		public bool isChinese()
		{
					}
		public bool isKorean()
		{
					}
		public bool isCJK()
		{
					}
		public bool isRussian()
		{
					}
		public bool isSideView()
		{
					}
		public bool isSaveEnabled()
		{
					}
		public void disableSave()
		{
					}
		public void enableSave()
		{
					}
		public bool isMenuEnabled()
		{
					}
		public void disableMenu()
		{
					}
		public void enableMenu()
		{
					}
		public bool isEncounterEnabled()
		{
					}
		public void disableEncounter()
		{
					}
		public void enableEncounter()
		{
					}
		public bool isFormationEnabled()
		{
					}
		public void disableFormation()
		{
					}
		public void enableFormation()
		{
					}
		public float battleCount()
		{
					}
		public float winCount()
		{
					}
		public float escapeCount()
		{
					}
		public float saveCount()
		{
					}
		public float versionId()
		{
					}
		public float[] windowTone()
		{
					}
		public void setWindowTone(float[] value)
		{
					}
		public IDataSound battleBgm()
		{
					}
		public void setBattleBgm(IDataSound value)
		{
					}
		public IDataSound victoryMe()
		{
					}
		public void setVictoryMe(IDataSound value)
		{
					}
		public IDataSound defeatMe()
		{
					}
		public void setDefeatMe(IDataSound value)
		{
					}
		public void onBattleStart()
		{
					}
		public void onBattleWin()
		{
					}
		public void onBattleEscape()
		{
					}
		public void onBeforeSave()
		{
					}
		public void onAfterLoad()
		{
					}
		public float playtime()
		{
					}
		public string playtimeText()
		{
					}
		public void saveBgm()
		{
					}
		public void replayBgm()
		{
					}
		public void saveWalkingBgm()
		{
					}
		public void replayWalkingBgm()
		{
					}
		public void saveWalkingBgm2()
		{
					}
	}

		public class Game_Timer
	{
		public Game_Timer()
		{
			
		}
		public float _frames;
		public bool _working;
		public void initialize()
		{
					}
		public void update(bool sceneActive)
		{
					}
		public void start(float count)
		{
					}
		public void stop()
		{
					}
		public bool isWorking()
		{
					}
		public float seconds()
		{
					}
		public void onExpire()
		{
					}
	}

		public class Game_Message
	{
		public Game_Message()
		{
			
		}
		public string[] _texts;
		public string[] _choices;
		public string _faceName;
		public float _faceIndex;
		public float _background;
		public float _positionType;
		public float _choiceDefaultType;
		public float _choiceCancelType;
		public float _choiceBackground;
		public float _choicePositionType;
		public float _numInputVariableId;
		public float _numInputMaxDigits;
		public float _itemChoiceVariableId;
		public float _itemChoiceItypeId;
		public bool _scrollMode;
		public float _scrollSpeed;
		public bool _scrollNoFast;
		public Function _choiceCallback;
		public void initialize()
		{
					}
		public void clear()
		{
					}
		public string[] choices()
		{
					}
		public string faceName()
		{
					}
		public float faceIndex()
		{
					}
		public float background()
		{
					}
		public float positionType()
		{
					}
		public float choiceDefaultType()
		{
					}
		public float choiceCancelType()
		{
					}
		public float choiceBackground()
		{
					}
		public float choicePositionType()
		{
					}
		public float numInputVariableId()
		{
					}
		public float numInputMaxDigits()
		{
					}
		public float itemChoiceVariableId()
		{
					}
		public float itemChoiceItypeId()
		{
					}
		public bool scrollMode()
		{
					}
		public float scrollSpeed()
		{
					}
		public bool scrollNoFast()
		{
					}
		public void add(string text)
		{
					}
		public void setFaceImage(string faceName, float faceIndex)
		{
					}
		public void setBackground(float background)
		{
					}
		public void setPositionType(float positionType)
		{
					}
		public void setChoices(string[] choices, float defaultType, float cancelType)
		{
					}
		public void setChoiceBackground(float background)
		{
					}
		public void setChoicePositionType(float positionType)
		{
					}
		public void setNumberInput(float variableId, float maxDigits)
		{
					}
		public void setItemChoice(float variableId, float itemType)
		{
					}
		public void setScroll(float speed, bool noFast)
		{
					}
		public void setChoiceCallback(Function callback)
		{
					}
		public void onChoice(float n)
		{
					}
		public bool hasText()
		{
					}
		public bool isChoice()
		{
					}
		public bool isNumberInput()
		{
					}
		public bool isItemChoice()
		{
					}
		public bool isBusy()
		{
					}
		public void newPage()
		{
					}
		public string allText()
		{
					}
	}

		public class Game_Switches
	{
		public Game_Switches()
		{
			
		}
		public bool[] _data;
		public void initialize()
		{
					}
		public void clear()
		{
					}
		public bool value(float switchId)
		{
					}
		public void setValue(float switchId, bool value)
		{
					}
		public void onChange()
		{
					}
	}

		public class Game_Variables
	{
		public Game_Variables()
		{
			
		}
		public float[] _data;
		public void initialize()
		{
					}
		public void clear()
		{
					}
		public float value(float variableId)
		{
					}
		public float setValue(float variableId, float value)
		{
					}
		public void onChange()
		{
					}
	}

		public class Game_SelfSwitches
	{
		public Game_SelfSwitches()
		{
			
		}
		public bool value;
		public _data_0_ _data;
		public void initialize()
		{
					}
		public void clear()
		{
					}
		public bool value(float[] key)
		{
					}
		public object setValue(Func<object, string> key)
		{
					}
		public void onChange()
		{
					}

				public class _data_0_
		{
			
			public bool this[string index]
			{
				get
				{
					return (bool)((dynamic)this)[index];
				}				
				set
				{
					((dynamic)this)[index] = value;
				}
			}
			
		}
	}

		public class Game_Screen
	{
		public Game_Screen()
		{
			
		}
		public float _brightness;
		public float _zoomX;
		public float _zoomY;
		public float _zoomScale;
		public float _zoomScaleTarget;
		public float _zoomDuration;
		public string _weatherType;
		public float _weatherPower;
		public float _weatherPowerTarget;
		public float _weatherDuration;
		public Game_Picture[] _pictures;
		public float _fadeOutDuration;
		public float _fadeInDuration;
		public float[] _tone;
		public float[] _toneTarget;
		public float _toneDuration;
		public float[] _flashColor;
		public float _flashDuration;
		public float _shake;
		public float _shakePower;
		public float _shakeSpeed;
		public float _shakeDuration;
		public void initialize()
		{
					}
		public void clear()
		{
					}
		public void onBattleStart()
		{
					}
		public float brightness()
		{
					}
		public float[] tone()
		{
					}
		public float[] flashColor()
		{
					}
		public float shake()
		{
					}
		public float zoomX()
		{
					}
		public float zoomY()
		{
					}
		public float zoomScale()
		{
					}
		public string weatherType()
		{
					}
		public float weatherPower()
		{
					}
		public Game_Picture picture(float pictureId)
		{
					}
		public float realPictureId(float pictureId)
		{
					}
		public void clearFade()
		{
					}
		public void clearTone()
		{
					}
		public void clearFlash()
		{
					}
		public void clearShake()
		{
					}
		public void clearZoom()
		{
					}
		public void clearWeather()
		{
					}
		public void clearPictures()
		{
					}
		public void eraseBattlePictures()
		{
					}
		public float maxPictures()
		{
					}
		public void startFadeOut(float duration)
		{
					}
		public void startFadeIn(float duration)
		{
					}
		public void startTint(float[] tone, float duration)
		{
					}
		public void startFlash(float[] color, float duration)
		{
					}
		public void startShake(float power, float speed, float duration)
		{
					}
		public void startZoom(float x, float y, float scale, float duration)
		{
					}
		public void setZoom(float x, float y, float scale)
		{
					}
		public void changeWeather(string type, float power, float duration)
		{
					}
		public void update()
		{
					}
		public void updateFadeOut()
		{
					}
		public void updateFadeIn()
		{
					}
		public void updateTone()
		{
					}
		public void updateFlash()
		{
					}
		public void updateShake()
		{
					}
		public void updateZoom()
		{
					}
		public void updateWeather()
		{
					}
		public void updatePictures()
		{
					}
		public void startFlashForDamage()
		{
					}
		public void showPicture(float pictureId, string name, float origin, float x, float y, float scaleX, float scaleY, float opacity, float blendMode)
		{
					}
		public void movePicture(float pictureId, float origin, float x, float y, float scaleX, float scaleY, float opacity, float blendMode, float duration)
		{
					}
		public void rotatePicture(float pictureId, float speed)
		{
					}
		public void tintPicture(float pictureId, float[] tone, float duration)
		{
					}
		public void erasePicture(float pictureId)
		{
					}
	}

		public class Game_Picture
	{
		public Game_Picture()
		{
			
		}
		public string _name;
		public float _origin;
		public float _x;
		public float _y;
		public float _scaleX;
		public float _scaleY;
		public float _opacity;
		public float _blendMode;
		public float[] _tone;
		public float[] _toneTarget;
		public float _toneDuration;
		public float _angle;
		public float _rotationSpeed;
		public float _targetX;
		public float _targetY;
		public float _targetScaleX;
		public float _targetScaleY;
		public float _targetOpacity;
		public float _duration;
		public void initialize()
		{
					}
		public string name()
		{
					}
		public float origin()
		{
					}
		public float x()
		{
					}
		public float y()
		{
					}
		public float scaleX()
		{
					}
		public float scaleY()
		{
					}
		public float opacity()
		{
					}
		public float blendMode()
		{
					}
		public float[] tone()
		{
					}
		public float angle()
		{
					}
		public void initBasic()
		{
					}
		public void initTarget()
		{
					}
		public void initTone()
		{
					}
		public void initRotation()
		{
					}
		public void show(string name, float origin, float x, float y, float scaleX, float scaleY, float opacity, float blendMode)
		{
					}
		public void move(float origin, float x, float y, float scaleX, float scaleY, float opacity, float blendMode, float duration)
		{
					}
		public void rotate(float speed)
		{
					}
		public void tint(float[] tone, float duration)
		{
					}
		public void erase()
		{
					}
		public void update()
		{
					}
		public void updateMove()
		{
					}
		public void updateTone()
		{
					}
		public void updateRotation()
		{
					}
	}

		public class Game_Item
	{
		public Game_Item(IDataItem item = default(IDataItem))
		{
			
		}
		protected Game_Item()
		{
			
		}
		public string _dataClass;
		public float _itemId;
		public void initialize(IDataItem item)
		{
					}
		public bool isSkill()
		{
					}
		public bool isItem()
		{
					}
		public bool isUsableItem()
		{
					}
		public bool isWeapon()
		{
					}
		public bool isArmor()
		{
					}
		public bool isEquipItem()
		{
					}
		public bool isNull()
		{
					}
		public float itemId()
		{
					}
		public IDataItem object()
		{
					}
		public void setObject(IDataItem item)
		{
					}
		public void setEquip(bool isWeapon, float itemId)
		{
					}
	}

		public class Game_Action
	{
		public Game_Action(Game_Battler subject, bool forcing)
		{
			
		}
		public Game_Action(Game_Battler subject, bool forcing = default(bool))
		{
			
		}
		protected Game_Action()
		{
			
		}
		public static float EFFECT_RECOVER_HP;
		public static float EFFECT_RECOVER_MP;
		public static float EFFECT_GAIN_TP;
		public static float EFFECT_ADD_STATE;
		public static float EFFECT_REMOVE_STATE;
		public static float EFFECT_ADD_BUFF;
		public static float EFFECT_ADD_DEBUFF;
		public static float EFFECT_REMOVE_BUFF;
		public static float EFFECT_REMOVE_DEBUFF;
		public static float EFFECT_SPECIAL;
		public static float EFFECT_GROW;
		public static float EFFECT_LEARN_SKILL;
		public static float EFFECT_COMMON_EVENT;
		public static float SPECIAL_EFFECT_ESCAPE;
		public static float HITTYPE_CERTAIN;
		public static float HITTYPE_PHYSICAL;
		public static float HITTYPE_MAGICAL;
		public float _subjectActorId;
		public float _subjectEnemyIndex;
		public bool _forcing;
		public Game_Item _item;
		public float _targetIndex;
		public void initialize(Game_Battler subject, bool forcing)
		{
					}
		public void clear()
		{
					}
		public void setSubject(Game_Battler subject)
		{
					}
		public Game_Battler subject()
		{
					}
		public Game_Unit friendsUnit()
		{
					}
		public Game_Unit opponentsUnit()
		{
					}
		public void setEnemyAction(bool action)
		{
					}
		public void setAttack()
		{
					}
		public void setGuard()
		{
					}
		public void setSkill(float skillId)
		{
					}
		public void setItem(float itemId)
		{
					}
		public void setItemObject(IDataItem @object)
		{
					}
		public void setTarget(float targetIndex)
		{
					}
		public IDataItem item()
		{
					}
		public bool isSkill()
		{
					}
		public bool isItem()
		{
					}
		public float numRepeats()
		{
					}
		public bool checkItemScope(float[] list)
		{
					}
		public bool isForOpponent()
		{
					}
		public bool isForFriend()
		{
					}
		public bool isForDeadFriend()
		{
					}
		public bool isForUser()
		{
					}
		public bool isForOne()
		{
					}
		public bool isForRandom()
		{
					}
		public bool isForAll()
		{
					}
		public bool needsSelection()
		{
					}
		public float numTargets()
		{
					}
		public bool checkDamageType(float[] list)
		{
					}
		public bool isHpEffect()
		{
					}
		public bool isMpEffect()
		{
					}
		public bool isDamage()
		{
					}
		public bool isRecover()
		{
					}
		public bool isDrain()
		{
					}
		public bool isHpRecover()
		{
					}
		public bool isMpRecover()
		{
					}
		public bool isCertainHit()
		{
					}
		public bool isPhysical()
		{
					}
		public bool isMagical()
		{
					}
		public bool isAttack()
		{
					}
		public bool isGuard()
		{
					}
		public bool isMagicSkill()
		{
					}
		public void decideRandomTarget()
		{
					}
		public void setConfusion()
		{
					}
		public void prepare()
		{
					}
		public bool isValid()
		{
					}
		public float speed()
		{
					}
		public Game_Battler[] makeTargets()
		{
					}
		public Game_Battler[] repeatTargets(Game_Battler[] targets)
		{
					}
		public Game_Battler confusionTarget()
		{
					}
		public Game_Battler[] targetsForOpponents()
		{
					}
		public Game_Battler[] targetsForFriends()
		{
					}
		public float evaluate()
		{
					}
		public Game_Battler[] itemTargetCandidates()
		{
					}
		public float evaluateWithTarget(Game_Battler target)
		{
					}
		public bool testApply(Game_Battler target)
		{
					}
		public float hasItemAnyValidEffects(Game_Battler target)
		{
					}
		public float testItemEffect(Game_Battler target, IDataEffect effect)
		{
					}
		public float itemCnt(Game_Battler target)
		{
					}
		public float itemMrf(Game_Battler target)
		{
					}
		public float itemHit(Game_Battler target)
		{
					}
		public float itemEva(Game_Battler target)
		{
					}
		public float itemCri(Game_Battler target)
		{
					}
		public void apply(Game_Battler target)
		{
					}
		public float makeDamageValue(Game_Battler target, bool critical)
		{
					}
		public float evalDamageFormula(Game_Battler target)
		{
					}
		public float calcElementRate(Game_Battler target)
		{
					}
		public float elementsMaxRate(Game_Battler target, float[] elements)
		{
					}
		public float applyCritical(float damage)
		{
					}
		public float applyVariance(float damage, float variance)
		{
					}
		public float applyGuard(float damage, Game_Battler target)
		{
					}
		public void executeDamage(Game_Battler target, float value)
		{
					}
		public void executeHpDamage(Game_Battler target, float value)
		{
					}
		public void executeMpDamage(Game_Battler target, float value)
		{
					}
		public void gainDrainedHp(float value)
		{
					}
		public void gainDrainedMp(float value)
		{
					}
		public void applyItemEffect(Game_Battler target, IDataEffect effect)
		{
					}
		public void itemEffectRecoverHp(Game_Battler target, IDataEffect effect)
		{
					}
		public void itemEffectRecoverMp(Game_Battler target, IDataEffect effect)
		{
					}
		public void itemEffectGainTp(Game_Battler target, IDataEffect effect)
		{
					}
		public void itemEffectAddState(Game_Battler target, IDataEffect effect)
		{
					}
		public void itemEffectAddAttackState(Game_Battler target, IDataEffect effect)
		{
					}
		public void itemEffectAddNormalState(Game_Battler target, IDataEffect effect)
		{
					}
		public void itemEffectRemoveState(Game_Battler target, IDataEffect effect)
		{
					}
		public void itemEffectAddBuff(Game_Battler target, IDataEffect effect)
		{
					}
		public void itemEffectAddDebuff(Game_Battler target, IDataEffect effect)
		{
					}
		public void itemEffectRemoveBuff(Game_Battler target, IDataEffect effect)
		{
					}
		public void itemEffectRemoveDebuff(Game_Battler target, IDataEffect effect)
		{
					}
		public void itemEffectSpecial(Game_Battler target, IDataEffect effect)
		{
					}
		public void itemEffectGrow(Game_Battler target, IDataEffect effect)
		{
					}
		public void itemEffectLearnSkill(Game_Battler target, IDataEffect effect)
		{
					}
		public void itemEffectCommonEvent(Game_Battler target, IDataEffect effect)
		{
					}
		public void makeSuccess(Game_Battler target)
		{
					}
		public void applyItemUserEffect(Game_Battler target)
		{
					}
		public float lukEffectRate(Game_Battler target)
		{
					}
		public void applyGlobal()
		{
					}
	}

		public class Game_ActionResult
	{
		public Game_ActionResult()
		{
			
		}
		public bool used;
		public bool missed;
		public bool evaded;
		public bool physical;
		public bool drain;
		public bool critical;
		public bool success;
		public bool hpAffected;
		public float hpDamage;
		public float mpDamage;
		public float tpDamage;
		public IDataState[] addedStates;
		public IDataState[] removedStates;
		public float[] addedBuffs;
		public float[] addedDebuffs;
		public float[] removedBuffs;
		public void initialize()
		{
					}
		public void clear()
		{
					}
		public IDataState[] addedStateObjects()
		{
					}
		public IDataState[] removedStateObjects()
		{
					}
		public bool isStatusAffected()
		{
					}
		public bool isHit()
		{
					}
		public bool isStateAdded(float stateId)
		{
					}
		public void pushAddedState(float stateId)
		{
					}
		public bool isStateRemoved(float stateId)
		{
					}
		public void pushRemovedState(float stateId)
		{
					}
		public bool isBuffAdded(float paramId)
		{
					}
		public void pushAddedBuff(float paramId)
		{
					}
		public bool isDebuffAdded(float paramId)
		{
					}
		public void pushAddedDebuff(float paramId)
		{
					}
		public bool isBuffRemoved(float paramId)
		{
					}
		public void pushRemovedBuff(float paramId)
		{
					}
	}

		public class Game_BattlerBase
	{
		public Game_BattlerBase()
		{
			
		}
		public static float TRAIT_ELEMENT_RATE;
		public static float TRAIT_DEBUFF_RATE;
		public static float TRAIT_STATE_RATE;
		public static float TRAIT_STATE_RESIST;
		public static float TRAIT_PARAM;
		public static float TRAIT_XPARAM;
		public static float TRAIT_SPARAM;
		public static float TRAIT_ATTACK_ELEMENT;
		public static float TRAIT_ATTACK_STATE;
		public static float TRAIT_ATTACK_SPEED;
		public static float TRAIT_ATTACK_TIMES;
		public static float TRAIT_STYPE_ADD;
		public static float TRAIT_STYPE_SEAL;
		public static float TRAIT_SKILL_ADD;
		public static float TRAIT_SKILL_SEAL;
		public static float TRAIT_EQUIP_WTYPE;
		public static float TRAIT_EQUIP_ATYPE;
		public static float TRAIT_EQUIP_LOCK;
		public static float TRAIT_EQUIP_SEAL;
		public static float TRAIT_SLOT_TYPE;
		public static float TRAIT_ACTION_PLUS;
		public static float TRAIT_SPECIAL_FLAG;
		public static float TRAIT_COLLAPSE_TYPE;
		public static float TRAIT_PARTY_ABILITY;
		public static float FLAG_ID_AUTO_BATTLE;
		public static float FLAG_ID_GUARD;
		public static float FLAG_ID_SUBSTITUTE;
		public static float FLAG_ID_PRESERVE_TP;
		public static float ICON_BUFF_START;
		public static float ICON_DEBUFF_START;
		public float hp;
		public float mp;
		public float tp;
		public float mhp;
		public float mmp;
		public float atk;
		public float mat;
		public float mdf;
		public float agi;
		public float luk;
		public float hit;
		public float eva;
		public float cri;
		public float cev;
		public float mev;
		public float mrf;
		public float cnt;
		public float hrg;
		public float mrg;
		public float trg;
		public float tgr;
		public float grd;
		public float rec;
		public float pha;
		public float mcr;
		public float tcr;
		public float pdr;
		public float mdr;
		public float fdr;
		public float exr;
		public float _hp;
		public float _mp;
		public float _tp;
		public bool _hidden;
		public float[] _paramPlus;
		public float[] _states;
		public _stateTurns_0_ _stateTurns;
		public float[] _buffs;
		public float[] _buffTurns;
		public void initialize()
		{
					}
		public void initMembers()
		{
					}
		public void clearParamPlus()
		{
					}
		public void clearStates()
		{
					}
		public void eraseState(float stateId)
		{
					}
		public bool isStateAffected(float stateId)
		{
					}
		public bool isDeathStateAffected()
		{
					}
		public float deathStateId()
		{
					}
		public void deathStateId(float stateId)
		{
					}
		public void resetStateCounts(float stateId)
		{
					}
		public bool isStateExpired(float stateId)
		{
					}
		public void updateStateTurns()
		{
					}
		public void clearBuffs()
		{
					}
		public void eraseBuff(float paramId)
		{
					}
		public float buffLength()
		{
					}
		public float buff(float paramId)
		{
					}
		public bool isBuffAffected(float paramId)
		{
					}
		public bool isDebuffAffected(float paramId)
		{
					}
		public bool isBuffOrDebuffAffected(float paramId)
		{
					}
		public bool isMaxBuffAffected(float paramId)
		{
					}
		public bool isMaxDebuffAffected(float paramId)
		{
					}
		public void increaseBuff(float paramId)
		{
					}
		public void decreaseBuff(float paramId)
		{
					}
		public void overwriteBuffTurns(float paramId, float turns)
		{
					}
		public bool isBuffExpired(float paramId)
		{
					}
		public void updateBuffTurns()
		{
					}
		public void die()
		{
					}
		public void revive()
		{
					}
		public IDataState[] states()
		{
					}
		public float[] stateIcons()
		{
					}
		public float[] buffIcons()
		{
					}
		public float buffIconIndex(float buffLevel, float paramId)
		{
					}
		public float[] allIcons()
		{
					}
		public IDataState[] traitObjects()
		{
					}
		public IDataTrait[] allTraits()
		{
					}
		public IDataTrait[] traits(float code)
		{
					}
		public IDataTrait[] traitsWithId(float code, float id)
		{
					}
		public float traitsPi(float code, float id)
		{
					}
		public float traitsSum(float code, float id)
		{
					}
		public float traitsSumAll(float code)
		{
					}
		public float[] traitsSet(float code)
		{
					}
		public float paramBase(float paramId)
		{
					}
		public float paramPlus(float paramId)
		{
					}
		public float paramMin(float paramId)
		{
					}
		public float paramMax(float paramId)
		{
					}
		public float paramRate(float paramId)
		{
					}
		public float paramBuffRate(float paramId)
		{
					}
		public float param(float paramId)
		{
					}
		public float xparam(float xparamId)
		{
					}
		public float sparam(float sparamId)
		{
					}
		public float elementRate(float elementId)
		{
					}
		public float debuffRate(float paramId)
		{
					}
		public float stateRate(float stateId)
		{
					}
		public float[] stateResistSet()
		{
					}
		public bool isStateResist(float stateId)
		{
					}
		public float[] attackElements()
		{
					}
		public float[] attackStates()
		{
					}
		public float attackStatesRate(float stateId)
		{
					}
		public float attackSpeed()
		{
					}
		public float attackTimesAdd()
		{
					}
		public float[] addedSkillTypes()
		{
					}
		public bool isSkillTypeSealed(float stypeId)
		{
					}
		public float[] addedSkills()
		{
					}
		public bool isSkillSealed(float skillId)
		{
					}
		public bool isEquipWtypeOk(float wtypeId)
		{
					}
		public bool isEquipAtypeOk(float atypeId)
		{
					}
		public bool isEquipTypeLocked(float etypeId)
		{
					}
		public bool isEquipTypeSealed(float etypeId)
		{
					}
		public float slotType()
		{
					}
		public bool isDualWield()
		{
					}
		public float[] actionPlusSet()
		{
					}
		public bool specialFlag(float flagId)
		{
					}
		public float collapseType()
		{
					}
		public bool partyAbility(float abilityId)
		{
					}
		public bool isAutoBattle()
		{
					}
		public bool isGuard()
		{
					}
		public bool isSubstitute()
		{
					}
		public bool isPreserveTp()
		{
					}
		public void addParam(float paramId, float value)
		{
					}
		public void setHp(float hp)
		{
					}
		public void setMp(float mp)
		{
					}
		public void setTp(float tp)
		{
					}
		public float maxTp()
		{
					}
		public void refresh()
		{
					}
		public void recoverAll()
		{
					}
		public float hpRate()
		{
					}
		public float mpRate()
		{
					}
		public float tpRate()
		{
					}
		public void hide()
		{
					}
		public void appear()
		{
					}
		public bool isHidden()
		{
					}
		public bool isAppeared()
		{
					}
		public bool isDead()
		{
					}
		public bool isAlive()
		{
					}
		public bool isDying()
		{
					}
		public bool isRestricted()
		{
					}
		public bool canInput()
		{
					}
		public bool canMove()
		{
					}
		public bool isConfused()
		{
					}
		public float confusionLevel()
		{
					}
		public bool isActor()
		{
					}
		public bool isEnemy()
		{
					}
		public void sortStates()
		{
					}
		public float restriction()
		{
					}
		public void addNewState(float stateId)
		{
					}
		public void onRestrict()
		{
					}
		public string mostImportantStateText()
		{
					}
		public float stateMotionIndex()
		{
					}
		public float stateOverlayIndex()
		{
					}
		public bool isSkillWtypeOk(IDataSkill skill)
		{
					}
		public float skillMpCost(IDataSkill skill)
		{
					}
		public float skillTpCost(IDataSkill skill)
		{
					}
		public bool canPaySkillCost(IDataSkill skill)
		{
					}
		public void paySkillCost(IDataSkill skill)
		{
					}
		public bool isOccasionOk(IDataAllItem item)
		{
					}
		public bool meetsUsableItemConditions(IDataAllItem item)
		{
					}
		public bool meetsSkillConditions(IDataSkill skill)
		{
					}
		public bool meetsItemConditions(IDataSkill skill)
		{
					}
		public bool canUse(IDataAllItem item)
		{
					}
		public bool canEquip(IDataAllItem item)
		{
					}
		public bool canEquipWeapon(IDataAllItem item)
		{
					}
		public bool canEquipArmor(IDataAllItem item)
		{
					}
		public float attackSkillId()
		{
					}
		public float guardSkillId()
		{
					}
		public bool canAttack()
		{
					}
		public bool canGuard()
		{
					}

				public class _stateTurns_0_
		{
			
			public float this[float index]
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

		public class IGame_BattlerAnimation
	{
		protected IGame_BattlerAnimation()
		{
			
		}
		public string animationId;
		public bool mirror;
		public float delay;
	}

		public class Game_Battler : Game_BattlerBase
	{
		public Game_Battler() : base()
		{
			
		}
		public Game_Action[] _actions;
		public float _speed;
		public Game_ActionResult _result;
		public string _actionState;
		public float _lastTargetIndex;
		public IGame_BattlerAnimation[] _animations;
		public bool _damagePopup;
		public string _effectType;
		public string _motionType;
		public float _weaponImageId;
		public bool _motionRefresh;
		public bool _selected;
		public void initialize()
		{
					}
		public void initMembers()
		{
					}
		public void clearAnimations()
		{
					}
		public void clearDamagePopup()
		{
					}
		public void clearWeaponAnimation()
		{
					}
		public void clearEffect()
		{
					}
		public void clearMotion()
		{
					}
		public void requestEffect(string effectType)
		{
					}
		public void requestMotion(string motionType)
		{
					}
		public void requestMotionRefresh()
		{
					}
		public void select()
		{
					}
		public void deselect()
		{
					}
		public bool isAnimationRequested()
		{
					}
		public bool isDamagePopupRequested()
		{
					}
		public bool isEffectRequested()
		{
					}
		public bool isMotionRequested()
		{
					}
		public bool isWeaponAnimationRequested()
		{
					}
		public bool isMotionRefreshRequested()
		{
					}
		public bool isSelected()
		{
					}
		public string effectType()
		{
					}
		public string motionType()
		{
					}
		public float weaponImageId()
		{
					}
		public IGame_BattlerAnimation shiftAnimation()
		{
					}
		public void startAnimation(float animationId, bool mirror, float delay)
		{
					}
		public void startDamagePopup()
		{
					}
		public void startWeaponAnimation(float weaponImageId)
		{
					}
		public Game_Action action(float index)
		{
					}
		public void setAction(float index, Game_Action action)
		{
					}
		public float numActions()
		{
					}
		public void clearActions()
		{
					}
		public Game_ActionResult result()
		{
					}
		public void clearResult()
		{
					}
		public void refresh()
		{
					}
		public void addState(float stateId)
		{
					}
		public bool isStateAddable(float stateId)
		{
					}
		public bool isStateRestrict(float stateId)
		{
					}
		public void onRestrict()
		{
					}
		public void removeState(float stateId)
		{
					}
		public void escape()
		{
					}
		public void addBuff(float paramId, float turns)
		{
					}
		public void addDebuff(float paramId, float turns)
		{
					}
		public void removeBuff(float paramId)
		{
					}
		public void removeBattleStates()
		{
					}
		public void removeAllBuffs()
		{
					}
		public void removeStatesAuto(float timing)
		{
					}
		public void removeBuffsAuto()
		{
					}
		public void removeStatesByDamage()
		{
					}
		public float makeActionTimes()
		{
					}
		public void makeActions()
		{
					}
		public float speed()
		{
					}
		public void makeSpeed()
		{
					}
		public Game_Action currentAction()
		{
					}
		public void removeCurrentAction()
		{
					}
		public void setLastTarnget(Game_Battler target)
		{
					}
		public void forceAction(float skillId, float targetIndex)
		{
					}
		public void useItem(IDataAllItem item)
		{
					}
		public void consumeItem(IDataAllItem item)
		{
					}
		public void gainHp(float value)
		{
					}
		public void gainMp(float value)
		{
					}
		public void gainTp(float value)
		{
					}
		public void gainSilentTp(float value)
		{
					}
		public void initTp()
		{
					}
		public void clearTp()
		{
					}
		public void chargeTpByDamage(float damageRate)
		{
					}
		public void regenerateHp()
		{
					}
		public float maxSlipDamage()
		{
					}
		public void regenerateMp()
		{
					}
		public void regenerateTp()
		{
					}
		public void regenerateAll()
		{
					}
		public void onBattleStart()
		{
					}
		public void onAllActionsEnd()
		{
					}
		public void onTurnEnd()
		{
					}
		public void onBattleEnd()
		{
					}
		public void onDamage(float value)
		{
					}
		public void setActionState(string actionState)
		{
					}
		public bool isUndecided()
		{
					}
		public bool isInputting()
		{
					}
		public bool isWaiting()
		{
					}
		public bool isActing()
		{
					}
		public bool isChanting()
		{
					}
		public bool isGuardWaiting()
		{
					}
		public void performActionStart(Game_Action action)
		{
					}
		public void performAction(Game_Action action)
		{
					}
		public void performActionEnd()
		{
					}
		public void performDamage()
		{
					}
		public void performMiss()
		{
					}
		public void performRecovery()
		{
					}
		public void performEvasion()
		{
					}
		public void performMagicEvasion()
		{
					}
		public void performCounter()
		{
					}
		public void performReflection()
		{
					}
		public void performSubstitute(Game_Battler target)
		{
					}
		public void performCollapse()
		{
					}
	}

		public class Game_Actor : Game_Battler
	{
		public Game_Actor() : base()
		{
			
		}
		public float level;
		public float _actorId;
		public string _name;
		public string _nickname;
		public float _classId;
		public float _level;
		public string _characterName;
		public float _characterIndex;
		public string _faceName;
		public float _faceIndex;
		public string _battlerName;
		public _exp_0_ _exp;
		public float[] _skills;
		public Game_Item[] _equips;
		public float _actionInputIndex;
		public Game_Item _lastMenuSkill;
		public Game_Item _lastBattleSkill;
		public string _lastCommandSymbol;
		public string _profile;
		public _stateSteps_0_ _stateSteps;
		public void initialize()
		{
					}
		public void initialize(float actorId)
		{
					}
		public void initMembers()
		{
					}
		public void setup(float actorId)
		{
					}
		public float actorId()
		{
					}
		public IDataActor actor()
		{
					}
		public string name()
		{
					}
		public void setName(string name)
		{
					}
		public string nickname()
		{
					}
		public void setNickname(string nickname)
		{
					}
		public string profile()
		{
					}
		public void setProfile(string profile)
		{
					}
		public string characterName()
		{
					}
		public float characterIndex()
		{
					}
		public string faceName()
		{
					}
		public float faceIndex()
		{
					}
		public string battlerName()
		{
					}
		public void clearStates()
		{
					}
		public void eraseState(float stateId)
		{
					}
		public void resetStateCounts(float stateId)
		{
					}
		public void initImages()
		{
					}
		public float expForLevel(float level)
		{
					}
		public void initExp()
		{
					}
		public float currentExp()
		{
					}
		public float currentLevelExp()
		{
					}
		public float nextLevelExp()
		{
					}
		public float nextRequiredExp()
		{
					}
		public float maxLevel()
		{
					}
		public float isMaxLevel()
		{
					}
		public void initSkills()
		{
					}
		public void initEquips(float[] equips)
		{
					}
		public float[] equipSlots()
		{
					}
		public Game_Item[] equips()
		{
					}
		public IDataWeapon[] weapons()
		{
					}
		public IDataArmor[] armors()
		{
					}
		public bool hasWeapon(IDataWeapon weapon)
		{
					}
		public bool hasArmor(IDataArmor armor)
		{
					}
		public bool isEquipChangeOk(float slotId)
		{
					}
		public void changeEquip(float slotId, IDataEquipItem item)
		{
					}
		public void forceChangeEquip(float slotId, IDataEquipItem item)
		{
					}
		public bool tradeItemWithParty(IDataEquipItem newItem, IDataEquipItem oldItem)
		{
					}
		public void changeEquipById(float etypeId, float itemId)
		{
					}
		public bool isEquipped(IDataAllItem item)
		{
					}
		public void discardEquip(IDataEquipItem item)
		{
					}
		public void releaseUnequippableItems(bool forcing)
		{
					}
		public void clearEquipments()
		{
					}
		public void optimizeEquipments()
		{
					}
		public IDataEquipItem bestEquipItem(float slotId)
		{
					}
		public float calcEquipItemPerformance(IDataEquipItem item)
		{
					}
		public bool isSkillWtypeOk(IDataSkill skill)
		{
					}
		public bool isWtypeEquipped(float wtypeId)
		{
					}
		public void refresh()
		{
					}
		public bool isActor()
		{
					}
		public Game_Party friendsUnit()
		{
					}
		public Game_Troop opponentsUnit()
		{
					}
		public float index()
		{
					}
		public bool isBattleMember()
		{
					}
		public bool isFormationChangeOk()
		{
					}
		public IDataClass currentClass()
		{
					}
		public bool isClass(IDataClass gameClass)
		{
					}
		public IDataSkill[] skills()
		{
					}
		public IDataSkill[] usableSkills()
		{
					}
		public IDataState[] traitObjects()
		{
					}
		public float[] attackElements()
		{
					}
		public bool hasNoWeapons()
		{
					}
		public float bareHandsElementId()
		{
					}
		public float paramMax(float paramId)
		{
					}
		public float paramBase(float paramId)
		{
					}
		public float paramPlus(float paramId)
		{
					}
		public float attackAnimationId1()
		{
					}
		public float attackAnimationId2()
		{
					}
		public float bareHandsAnimationId()
		{
					}
		public void changeExp(float exp, bool show)
		{
					}
		public void levelUp()
		{
					}
		public void levelDown()
		{
					}
		public IDataSkill[] findNewSkills(IDataSkill[] lastSkills)
		{
					}
		public void displayLevelUp(IDataSkill[] newSkills)
		{
					}
		public void gainExp(float exp)
		{
					}
		public float finalExpRate()
		{
					}
		public float benchMembersExpRate()
		{
					}
		public bool shouldDisplayLevelUp()
		{
					}
		public void changeLevel(float level, bool show)
		{
					}
		public void learnSkill(float skillId)
		{
					}
		public void forgetSkill(float skillId)
		{
					}
		public bool isLearnedSkill(float skillId)
		{
					}
		public bool hasSkill(float skillId)
		{
					}
		public void changeClass(float classId, float keepExp)
		{
					}
		public void setCharacterImage(string characterName, float characterIndex)
		{
					}
		public void setFaceImage(string faceName, float faceIndex)
		{
					}
		public void setBattlerImage(string battlerName)
		{
					}
		public bool isSpriteVisible()
		{
					}
		public void startAnimation(float animationId, bool mirror, float delay)
		{
					}
		public void performActionStart(Game_Action aciton)
		{
					}
		public void performAction(Game_Action aciton)
		{
					}
		public void performActionEnd()
		{
					}
		public void performAttack()
		{
					}
		public void performDamage()
		{
					}
		public void performEvasion()
		{
					}
		public void performMagicEvasion()
		{
					}
		public void performCounter()
		{
					}
		public void performCollapse()
		{
					}
		public void performVictory()
		{
					}
		public void performEscape()
		{
					}
		public Game_Action[] makeActionList()
		{
					}
		public void makeAutoBattleActions()
		{
					}
		public void makeConfusionActions()
		{
					}
		public void makeActions()
		{
					}
		public void onPlayerWalk()
		{
					}
		public void updateStateSteps(IDataState state)
		{
					}
		public void showAddedStates()
		{
					}
		public void showRemovedStates()
		{
					}
		public float stepsForTurn()
		{
					}
		public void turnEndOnMap()
		{
					}
		public void checkFloorEffect()
		{
					}
		public void executeFloorDamage()
		{
					}
		public float basicFloorDamage()
		{
					}
		public float maxFloorDamage()
		{
					}
		public void performMapDamage()
		{
					}
		public void clearActions()
		{
					}
		public Game_Action inputtingAction()
		{
					}
		public bool selectNextCommand()
		{
					}
		public bool selectPreviousCommand()
		{
					}
		public IDataSkill lastMenuSkill()
		{
					}
		public void setLastMenuSkill(IDataSkill skill)
		{
					}
		public IDataSkill lastBattleSkill()
		{
					}
		public void setLastBattleSkill(IDataSkill skill)
		{
					}
		public string lastCommandSymbol()
		{
					}
		public void setLastCommandSymbol(string symbol)
		{
					}
		public bool testEscape(IDataAllItem item)
		{
					}
		public bool meetsUsableItemConditions(IDataAllItem item)
		{
					}

				public class _exp_0_
		{
			
			public float this[float index]
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

				public class _stateSteps_0_
		{
			
			public float this[float index]
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

		public class Game_Enemy : Game_Battler
	{
		public Game_Enemy() : base()
		{
			
		}
		public float _enemyId;
		public string _letter;
		public bool _plural;
		public float _screenX;
		public float _screenY;
		public void initialize()
		{
					}
		public void initialize(float enemyId, float x, float y)
		{
					}
		public void initMembers()
		{
					}
		public void setup(float enemyId, float x, float y)
		{
					}
		public bool isEnemy()
		{
					}
		public Game_Troop friendsUnit()
		{
					}
		public Game_Party opponentsUnit()
		{
					}
		public float index()
		{
					}
		public bool isBattleMember()
		{
					}
		public float enemyId()
		{
					}
		public IDataEnemy enemy()
		{
					}
		public IDataState[] traitObjects()
		{
					}
		public float paramBase(float paramId)
		{
					}
		public float exp()
		{
					}
		public float gold()
		{
					}
		public IDataAllItem[] makeDropItems()
		{
					}
		public float dropItemRate()
		{
					}
		public IDataAllItem itemObject(float kind, float dataId)
		{
					}
		public bool isSpriteVisible()
		{
					}
		public float screenX()
		{
					}
		public float screenY()
		{
					}
		public string battlerName()
		{
					}
		public float battlerHue()
		{
					}
		public string originalName()
		{
					}
		public string name()
		{
					}
		public string isLetterEmpty()
		{
					}
		public void setLetter(string letter)
		{
					}
		public void setPlural(string plural)
		{
					}
		public void performActionStart(Game_Action action)
		{
					}
		public void performAction(Game_Action action)
		{
					}
		public void performActionEnd()
		{
					}
		public void performDamage()
		{
					}
		public void performCollapse()
		{
					}
		public void transform(float enemyId)
		{
					}
		public bool meetsCondition(IDataAction action)
		{
					}
		public bool meetsTurnCondition(float param1, float param2)
		{
					}
		public bool meetsHpCondition(float param1, float param2)
		{
					}
		public bool meetsMpCondition(float param1, float param2)
		{
					}
		public bool meetsStateCondition(float param)
		{
					}
		public bool meetsPartyLevelCondition(float param)
		{
					}
		public bool meetsSwitchCondition(float param)
		{
					}
		public bool isActionValid(IDataAction action)
		{
					}
		public IDataAction selectAction(IDataAction[] actionList, float ratingZero)
		{
					}
		public void selectAllActions(IDataAction[] actionList)
		{
					}
		public void makeActions()
		{
					}
	}

		public class Game_Actors
	{
		public Game_Actors()
		{
			
		}
		public Game_Actor[] _data;
		public void initialize()
		{
					}
		public Game_Actor actor(float actorId)
		{
					}
	}

		public class Game_Unit
	{
		public Game_Unit()
		{
			
		}
		public bool _inBattle;
		public void initialize()
		{
					}
		public bool inBattle()
		{
					}
		public Game_Battler[] members()
		{
					}
		public Game_Battler[] aliveMembers()
		{
					}
		public Game_Battler[] deadMembers()
		{
					}
		public Game_Battler[] movableMembers()
		{
					}
		public void clearActions()
		{
					}
		public float agility()
		{
					}
		public float tgrSum()
		{
					}
		public Game_Battler randomTarget()
		{
					}
		public Game_Battler randomDeadTarget()
		{
					}
		public Game_Battler smoothTarget()
		{
					}
		public Game_Battler smoothDeadTarget()
		{
					}
		public void clearResults()
		{
					}
		public void onBattleStart()
		{
					}
		public void onBattleEnd()
		{
					}
		public void makeActions()
		{
					}
		public void select()
		{
					}
		public bool isAllDead()
		{
					}
		public Game_Battler substituteBattler()
		{
					}
	}

		public class Game_Party : Game_Unit
	{
		public Game_Party() : base()
		{
			
		}
		public static float ABILITY_ENCOUNTER_HALF;
		public static float ABILITY_ENCOUNTER_NONE;
		public static float ABILITY_CANCEL_SURPRISE;
		public static float ABILITY_RAISE_PREEMPTIVE;
		public static float ABILITY_GOLD_DOUBLE;
		public static float ABILITY_DROP_ITEM_DOUBLE;
		public float _gold;
		public float _steps;
		public Game_Item _lastItem;
		public float _menuActorId;
		public float _targetActorId;
		public float[] _actors;
		public _items_0_ _items;
		public _weapons_0_ _weapons;
		public _armors_0_ _armors;
		public void initialize()
		{
					}
		public void initAllItems()
		{
					}
		public bool exists()
		{
					}
		public float size()
		{
					}
		public bool isEmpty()
		{
					}
		public Game_Actor[] members()
		{
					}
		public Game_Actor[] allMembers()
		{
					}
		public Game_Actor[] battleMembers()
		{
					}
		public float maxBattleMembers()
		{
					}
		public Game_Actor leader()
		{
					}
		public Game_Actor[] reviveBattleMembers()
		{
					}
		public IDataItem[] items()
		{
					}
		public IDataWeapon[] weapons()
		{
					}
		public IDataArmor[] armors()
		{
					}
		public IDataEquipItem[] equipItems()
		{
					}
		public IDataAllItem[] allItems()
		{
					}
		public Any<IDataItem[], IDataWeapon[], IDataArmor[]> itemContainer(IDataAllItem item)
		{
					}
		public void setupStartingMembers()
		{
					}
		public string name()
		{
					}
		public void setupBattleTest()
		{
					}
		public void setupBattleTestMembers()
		{
					}
		public void setupBattleTestItems()
		{
					}
		public float highestLevel()
		{
					}
		public void addActor(float actorId)
		{
					}
		public void removeActor(float actorId)
		{
					}
		public float gold()
		{
					}
		public void gainGold(float amount)
		{
					}
		public void loseGold(float amount)
		{
					}
		public float maxGold()
		{
					}
		public float steps()
		{
					}
		public void increaseSteps()
		{
					}
		public float numItems(IDataAllItem item)
		{
					}
		public float maxItems(IDataAllItem item)
		{
					}
		public bool hasMaxItems(IDataAllItem item)
		{
					}
		public bool hasItem(IDataAllItem item, bool includeEquip = default(bool))
		{
					}
		public bool isAnyMemberEquipped(IDataAllItem item)
		{
					}
		public void gainItem(IDataAllItem item, float amount, bool includeEquip)
		{
					}
		public void discardMembersEquip(IDataAllItem item, float amount)
		{
					}
		public void loseItem(IDataAllItem item, float amount, bool includeEquip)
		{
					}
		public void consumeItem(IDataAllItem item)
		{
					}
		public bool canUse(IDataAllItem item)
		{
					}
		public bool canInput()
		{
					}
		public bool isAllDead()
		{
					}
		public void onPlayerWalk()
		{
					}
		public Game_Actor menuActor()
		{
					}
		public void setMenuActor(Game_Actor actor)
		{
					}
		public void makeMenuActorNext()
		{
					}
		public void makeMenuActorPrevious()
		{
					}
		public Game_Actor targetActor()
		{
					}
		public void setTargetActor(Game_Actor actor)
		{
					}
		public IDataAllItem lastItem()
		{
					}
		public void setLastItem(IDataAllItem item)
		{
					}
		public void swapOrder(float index1, float index2)
		{
					}
		public object charactersForSavefile()
		{
					}
		public object facesForSavefile()
		{
					}
		public bool partyAbility(float abilityId)
		{
					}
		public bool hasEncounterHalf()
		{
					}
		public bool hasEncounterNone()
		{
					}
		public bool hasCancelSurprise()
		{
					}
		public bool hasRaisePreemptive()
		{
					}
		public bool hasGoldDouble()
		{
					}
		public bool hasDropItemDouble()
		{
					}
		public float ratePreemptive(float troopAgi)
		{
					}
		public float rateSurprise(float troopAgi)
		{
					}
		public void performVictory()
		{
					}
		public void performEscape()
		{
					}
		public void removeBattleStates()
		{
					}
		public void requestMotionRefresh()
		{
					}

				public class _items_0_
		{
			
			public float this[float index]
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

				public class _weapons_0_
		{
			
			public float this[float index]
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

				public class _armors_0_
		{
			
			public float this[float index]
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

		public class Game_Troop : Game_Unit
	{
		public Game_Troop() : base()
		{
			
		}
		public static string[] LETTER_TABLE_HALF;
		public static string[] LETTER_TABLE_FULL;
		public Game_Interpreter _interpreter;
		public float _turnCount;
		public Game_Enemy[] _enemies;
		public float _troopId;
		public _eventFlags_0_ _eventFlags;
		public _namesCount_0_ _namesCount;
		public void initialize()
		{
					}
		public bool isEventRunning()
		{
					}
		public void updateInterpreter()
		{
					}
		public float turnCount()
		{
					}
		public Game_Enemy[] members()
		{
					}
		public void clear()
		{
					}
		public IDataTroop troop()
		{
					}
		public void setup(float troopId)
		{
					}
		public void makeUniqueNames()
		{
					}
		public string[] letterTable()
		{
					}
		public string[] enemyNames()
		{
					}
		public bool meetsConditions(IDataPage page)
		{
					}
		public void setupBattleEvent()
		{
					}
		public void increaseTurn()
		{
					}
		public float expTotal()
		{
					}
		public float goldTotal()
		{
					}
		public float goldRate()
		{
					}
		public IDataItem[] makeDropItems()
		{
					}

				public class _eventFlags_0_
		{
			
			public bool this[float index]
			{
				get
				{
					return (bool)((dynamic)this)[index];
				}				
				set
				{
					((dynamic)this)[index] = value;
				}
			}
			
		}

				public class _namesCount_0_
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

		public class Game_Map
	{
		public Game_Map()
		{
			
		}
		public Game_Interpreter _interpreter;
		public float _mapId;
		public float _tilesetId;
		public Game_Event[] _events;
		public Game_CommonEvent[] _commonEvents;
		public Game_Vehicle[] _vehicles;
		public float _displayX;
		public float _displayY;
		public bool _nameDisplay;
		public float _scrollDirection;
		public float _scrollRest;
		public float _scrollSpeed;
		public string _parallaxName;
		public bool _parallaxZero;
		public bool _parallaxLoopX;
		public bool _parallaxLoopY;
		public float _parallaxSx;
		public float _parallaxSy;
		public float _parallaxX;
		public float _parallaxY;
		public string _battleback1Name;
		public string _battleback2Name;
		public bool _needsRefresh;
		public void initialize()
		{
					}
		public void setup(float mapId)
		{
					}
		public bool isEventRunning()
		{
					}
		public float tileWidth()
		{
					}
		public float tileHeight()
		{
					}
		public float mapId()
		{
					}
		public float tilesetId()
		{
					}
		public float displayX()
		{
					}
		public float displayY()
		{
					}
		public string parallaxName()
		{
					}
		public string battleback1Name()
		{
					}
		public string battleback2Name()
		{
					}
		public void requestRefresh(float mapId)
		{
					}
		public bool isNameDisplayEnabled()
		{
					}
		public void disableNameDisplay()
		{
					}
		public void enableNameDisplay()
		{
					}
		public void createVehicles()
		{
					}
		public void refereshVehicles()
		{
					}
		public Game_Vehicle[] vehicles()
		{
					}
		public Game_Vehicle vehicle(string type)
		{
					}
		public Game_Vehicle boat()
		{
					}
		public Game_Vehicle ship()
		{
					}
		public Game_Vehicle airship()
		{
					}
		public void setupEvents()
		{
					}
		public Game_Event[] events()
		{
					}
		public Game_Event event(float eventId)
		{
					}
		public void eraseEvent(float eventId)
		{
					}
		public Game_CommonEvent[] parallelCommonEvents()
		{
					}
		public void setupScroll()
		{
					}
		public void setupParallax()
		{
					}
		public void setupBattleback()
		{
					}
		public void setDisplayPos(float x, float y)
		{
					}
		public float parallaxOx()
		{
					}
		public float parallaxOy()
		{
					}
		public IDataTileset tileset()
		{
					}
		public float[] tilesetFlags()
		{
					}
		public string displayName()
		{
					}
		public float width()
		{
					}
		public float height()
		{
					}
		public float[] data()
		{
					}
		public bool isLoopHorizontal()
		{
					}
		public bool isLoopVertical()
		{
					}
		public bool isDashDisabled()
		{
					}
		public IDataEncounterList encounterList()
		{
					}
		public float encounterStep()
		{
					}
		public bool isOverworld()
		{
					}
		public float screenTileX()
		{
					}
		public float screenTileY()
		{
					}
		public float adjustX(float x)
		{
					}
		public float adjustY(float y)
		{
					}
		public float roundX(float x)
		{
					}
		public float roundY(float y)
		{
					}
		public float xWithDirection(float x, float d)
		{
					}
		public float yWithDirection(float y, float d)
		{
					}
		public float roundXWithDirection(float x, float d)
		{
					}
		public float roundYWithDirection(float y, float d)
		{
					}
		public float deltaX(float x1, float x2)
		{
					}
		public float deltaY(float y1, float y2)
		{
					}
		public float distance(float x1, float y1, float x2, float y2)
		{
					}
		public float canvasToMapX(float x)
		{
					}
		public float canvasToMapY(float y)
		{
					}
		public void autoplay()
		{
					}
		public void refreshIfNeeded()
		{
					}
		public void refresh()
		{
					}
		public void refreshTileEvents()
		{
					}
		public Game_Event[] eventsXy(float x, float y)
		{
					}
		public Game_Event[] eventsXyNt(float x, float y)
		{
					}
		public Game_Event[] tileEventsXy(float x, float y)
		{
					}
		public float eventIdXy(float x, float y)
		{
					}
		public void scrollDown(float distance)
		{
					}
		public void scrollLeft(float distance)
		{
					}
		public void scrollRight(float distance)
		{
					}
		public void scrollUp(float distance)
		{
					}
		public bool isValid(float x, float y)
		{
					}
		public bool checkPassage(float x, float y)
		{
					}
		public float tileId(float x, float y, float z)
		{
					}
		public float[] layeredTiles(float x, float y)
		{
					}
		public float[] allTiles(float x, float y)
		{
					}
		public float autotileType(float x, float y, float z)
		{
					}
		public bool isPassable(float x, float y, float d)
		{
					}
		public bool isBoatPassable(float x, float y)
		{
					}
		public bool isShipPassable(float x, float y)
		{
					}
		public bool isAirshipLandOk(float x, float y)
		{
					}
		public bool checkLayeredTilesFlags(float x, float y, float bit)
		{
					}
		public bool isLadder(float x, float y)
		{
					}
		public bool isBush(float x, float y)
		{
					}
		public bool isCounter(float x, float y)
		{
					}
		public bool isDamageFloor(float x, float y)
		{
					}
		public float terrainTag(float x, float y)
		{
					}
		public float regionId(float x, float y)
		{
					}
		public void startScroll(float direction, float distance, float speed)
		{
					}
		public bool isScrolling()
		{
					}
		public void update(bool sceneActive)
		{
					}
		public void updateScroll()
		{
					}
		public float scrollDistance()
		{
					}
		public void doScroll(float direction, float distance)
		{
					}
		public void updateEvents()
		{
					}
		public void updateVehicles()
		{
					}
		public void updateParallax()
		{
					}
		public void changeTileset(float tilesetId)
		{
					}
		public void changeBattleback(string battleback1Name, string battleback2Name)
		{
					}
		public void changeParallax(string name, float loopX, float loopY, float sx, float sy)
		{
					}
		public void updateInterpreter()
		{
					}
		public void unlockEvent(float eventId)
		{
					}
		public bool setupStartingEvent()
		{
					}
		public bool setupTestEvent()
		{
					}
		public bool setupStartingMapEvent()
		{
					}
		public bool setupAutorunCommonEvent()
		{
					}
		public bool isAnyEventStarting()
		{
					}
	}

		public class Game_CommonEvent
	{
		public Game_CommonEvent(float commonEventId)
		{
			
		}
		protected Game_CommonEvent()
		{
			
		}
		public float _commonEventId;
		public Game_Interpreter _interpreter;
		public void initialize(float commonEventId)
		{
					}
		public IDataCommonEvent event()
		{
					}
		public IDataList list()
		{
					}
		public void refresh()
		{
					}
		public bool isActive()
		{
					}
		public void update()
		{
					}
	}

		public class Game_CharacterBase
	{
		public Game_CharacterBase()
		{
			
		}
		public float x;
		public float y;
		public float _x;
		public float _y;
		public float _realX;
		public float _realY;
		public float _moveSpeed;
		public float _moveFrequency;
		public float _opacity;
		public float _blendMode;
		public float _direction;
		public float _pattern;
		public float _priorityType;
		public float _tileId;
		public string _characterName;
		public float _characterIndex;
		public bool _isObjectCharacter;
		public bool _walkAnime;
		public bool _stepAnime;
		public bool _directionFix;
		public bool _through;
		public bool _transparent;
		public float _bushDepth;
		public float _animationId;
		public float _balloonId;
		public bool _animationPlaying;
		public bool _balloonPlaying;
		public float _animationCount;
		public float _stopCount;
		public float _jumpCount;
		public float _jumpPeak;
		public bool _movementSuccess;
		public void initialize()
		{
					}
		public void initMembers()
		{
					}
		public bool pos(float x, float y)
		{
					}
		public bool posNt(float x, float y)
		{
					}
		public float moveSpeed()
		{
					}
		public void setMoveSpeed(float moveSpeed)
		{
					}
		public float moveFrequency()
		{
					}
		public void setMoveFrequency(float moveFrequency)
		{
					}
		public float opacity()
		{
					}
		public void setOpacity(float opacity)
		{
					}
		public float blendMode()
		{
					}
		public void setBlendMode(float blendMode)
		{
					}
		public bool isNormalPriority()
		{
					}
		public void setPriorityType(float priorityType)
		{
					}
		public bool isMoving()
		{
					}
		public bool isJumping()
		{
					}
		public float jumpHeight()
		{
					}
		public bool isStopping()
		{
					}
		public bool checkStop(float threshold)
		{
					}
		public void resetStopCount()
		{
					}
		public float realMoveSpeed()
		{
					}
		public float distancePerFrame()
		{
					}
		public bool isDashing()
		{
					}
		public bool isDebugThrough()
		{
					}
		public void straighten()
		{
					}
		public float reverseDir(float d)
		{
					}
		public bool canPass(float x, float y, float d)
		{
					}
		public bool canPassDiagonally(float x, float y, float horz, float vert)
		{
					}
		public bool isMapPassable(float x, float y, float d)
		{
					}
		public bool isCollidedWithCharacters(float x, float y)
		{
					}
		public bool isCollidedWithEvents(float x, float y)
		{
					}
		public bool isCollidedWithVehicles(float x, float y)
		{
					}
		public void setPosition(float x, float y)
		{
					}
		public void copyPosition(Game_CharacterBase character)
		{
					}
		public void locate(float x, float y)
		{
					}
		public float direction()
		{
					}
		public void setDirection(float d)
		{
					}
		public bool isTile()
		{
					}
		public bool isObjectCharacter()
		{
					}
		public float shiftY()
		{
					}
		public float scrolledX()
		{
					}
		public float scrolledY()
		{
					}
		public float screenX()
		{
					}
		public float screenY()
		{
					}
		public float screenZ()
		{
					}
		public bool isNearTheScreen()
		{
					}
		public void update()
		{
					}
		public void updateStop()
		{
					}
		public void updateJump()
		{
					}
		public void updateMove()
		{
					}
		public void updateAnimation()
		{
					}
		public float animationWait()
		{
					}
		public void updateAnimationCount()
		{
					}
		public void updatePattern()
		{
					}
		public float maxPattern()
		{
					}
		public float pattern()
		{
					}
		public void setPattern(float pattern)
		{
					}
		public bool isOriginalPattern()
		{
					}
		public void resetPattern()
		{
					}
		public void refreshBushDepth()
		{
					}
		public bool isOnLadder()
		{
					}
		public bool isOnBush()
		{
					}
		public bool terrainTag()
		{
					}
		public bool regionId()
		{
					}
		public void increaseSteps()
		{
					}
		public void tileId()
		{
					}
		public string characterName()
		{
					}
		public float characterIndex()
		{
					}
		public void setImage(string characterName, float characterIndex)
		{
					}
		public void setTileImage(float tileId)
		{
					}
		public void checkEventTriggerTouchFront(float d)
		{
					}
		public bool checkEventTriggerTouch(float x, float y)
		{
					}
		public bool isMovementSucceeded(float x, float y)
		{
					}
		public void setMovementSuccess(bool success)
		{
					}
		public void moveStraight(float d)
		{
					}
		public void moveDiagonally(float horz, float vert)
		{
					}
		public void jump(float xPlus, float yPlus)
		{
					}
		public bool hasWalkAnime()
		{
					}
		public void setWalkAnime(bool walkAnime)
		{
					}
		public bool hasStepAnime()
		{
					}
		public void setStepAnime(bool stepAnime)
		{
					}
		public bool isDirectionFixed()
		{
					}
		public void setDirectionFix(bool directionFix)
		{
					}
		public bool isThrough()
		{
					}
		public void setThrough(bool through)
		{
					}
		public bool isTransparent()
		{
					}
		public float bushDepth()
		{
					}
		public void setTransparent(bool transparent)
		{
					}
		public void requestAnimation(float animationId)
		{
					}
		public void requestBalloon(float balloonId)
		{
					}
		public float animationId()
		{
					}
		public float balloonId()
		{
					}
		public void startAnimation()
		{
					}
		public void startBalloon()
		{
					}
		public bool isAnimationPlaying()
		{
					}
		public bool isBalloonPlaying()
		{
					}
		public void endAnimation()
		{
					}
		public void endBalloon()
		{
					}
	}

		public class Game_Character : Game_CharacterBase
	{
		public Game_Character() : base()
		{
			
		}
		public static float ROUTE_END;
		public static float ROUTE_MOVE_DOWN;
		public static float ROUTE_MOVE_LEFT;
		public static float ROUTE_MOVE_RIGHT;
		public static float ROUTE_MOVE_UP;
		public static float ROUTE_MOVE_LOWER_L;
		public static float ROUTE_MOVE_LOWER_R;
		public static float ROUTE_MOVE_UPPER_L;
		public static float ROUTE_MOVE_UPPER_R;
		public static float ROUTE_MOVE_RANDOM;
		public static float ROUTE_MOVE_TOWARD;
		public static float ROUTE_MOVE_AWAY;
		public static float ROUTE_MOVE_FORWARD;
		public static float ROUTE_MOVE_BACKWARD;
		public static float ROUTE_JUMP;
		public static float ROUTE_WAIT;
		public static float ROUTE_TURN_DOWN;
		public static float ROUTE_TURN_LEFT;
		public static float ROUTE_TURN_RIGHT;
		public static float ROUTE_TURN_UP;
		public static float ROUTE_TURN_90D_R;
		public static float ROUTE_TURN_90D_L;
		public static float ROUTE_TURN_180D;
		public static float ROUTE_TURN_90D_R_L;
		public static float ROUTE_TURN_RANDOM;
		public static float ROUTE_TURN_TOWARD;
		public static float ROUTE_TURN_AWAY;
		public static float ROUTE_SWITCH_ON;
		public static float ROUTE_SWITCH_OFF;
		public static float ROUTE_CHANGE_SPEED;
		public static float ROUTE_CHANGE_FREQ;
		public static float ROUTE_WALK_ANIME_ON;
		public static float ROUTE_WALK_ANIME_OFF;
		public static float ROUTE_STEP_ANIME_ON;
		public static float ROUTE_STEP_ANIME_OFF;
		public static float ROUTE_DIR_FIX_ON;
		public static float ROUTE_DIR_FIX_OFF;
		public static float ROUTE_THROUGH_ON;
		public static float ROUTE_THROUGH_OFF;
		public static float ROUTE_TRANSPARENT_ON;
		public static float ROUTE_TRANSPARENT_OFF;
		public static float ROUTE_CHANGE_IMAGE;
		public static float ROUTE_CHANGE_OPACITY;
		public static float ROUTE_CHANGE_BLEND_MODE;
		public static float ROUTE_PLAY_SE;
		public static float ROUTE_SCRIPT;
		public bool _moveRouteForcing;
		public IDataMoveRoute _moveRoute;
		public float _moveRouteIndex;
		public IDataMoveRoute _originalMoveRoute;
		public float _originalMoveRouteIndex;
		public float _waitCount;
		public void initialize()
		{
					}
		public void initMembers()
		{
					}
		public void memorizeMoveRoute()
		{
					}
		public void restoreMoveRoute()
		{
					}
		public bool isMoveRouteForcing()
		{
					}
		public void setMoveRoute(IDataMoveRoute moveRoute)
		{
					}
		public void forceMoveRoute(IDataMoveRoute moveRoute)
		{
					}
		public void updateStop()
		{
					}
		public void updateRoutineMove()
		{
					}
		public void processMoveCommand(IDataMoveRouteCommand command)
		{
					}
		public float deltaXFrom(float x)
		{
					}
		public float deltaYFrom(float y)
		{
					}
		public void moveRandom()
		{
					}
		public void moveTowardCharacter(Game_CharacterBase character)
		{
					}
		public void moveAwayFromCharacter(Game_CharacterBase character)
		{
					}
		public void turnTowardCharacter(Game_CharacterBase character)
		{
					}
		public void turnAwayFromCharacter(Game_CharacterBase character)
		{
					}
		public void turnTowardPlayer()
		{
					}
		public void turnAwayFromPlayer()
		{
					}
		public void moveTowardPlayer()
		{
					}
		public void moveAwayFromPlayer()
		{
					}
		public void moveForward()
		{
					}
		public void moveBackward()
		{
					}
		public void processRouteEnd()
		{
					}
		public void advanceMoveRouteIndex()
		{
					}
		public void turnRight90()
		{
					}
		public void turnLeft90()
		{
					}
		public void turn180()
		{
					}
		public void turnRightOrLeft90()
		{
					}
		public void turnRandom()
		{
					}
		public float findDirectionTo(float goalX, float goalY)
		{
					}
		public float searchLimit()
		{
					}
	}

		public class Game_Player : Game_Character
	{
		public Game_Player() : base()
		{
			
		}
		public string _vehicleType;
		public bool _vehicleGettingOn;
		public bool _vehicleGettingOff;
		public bool _dashing;
		public bool _needsMapReload;
		public bool _transferring;
		public float _newMapId;
		public float _newX;
		public float _newY;
		public float _newDirection;
		public float _fadeType;
		public Game_Followers _followers;
		public float _encounterCount;
		public void initialize()
		{
					}
		public void initMembers()
		{
					}
		public void clearTransferInfo()
		{
					}
		public Game_Followers followers()
		{
					}
		public void refresh()
		{
					}
		public bool isStopping()
		{
					}
		public void reserveTransfer(float mapId, float x, float y, float d, float fadeType)
		{
					}
		public void requestMapReload()
		{
					}
		public bool isTransferring()
		{
					}
		public float newMapId()
		{
					}
		public float fadeType()
		{
					}
		public void performTransfer()
		{
					}
		public bool isMapPassable(float x, float y, float d)
		{
					}
		public IVehicle vehicle()
		{
					}
		public bool isInBoat()
		{
					}
		public bool isInShip()
		{
					}
		public bool isInAirship()
		{
					}
		public bool isInVehicle()
		{
					}
		public bool isNormal()
		{
					}
		public bool isDashing()
		{
					}
		public bool isDebugThrough()
		{
					}
		public bool isCollided(float x, float y)
		{
					}
		public float centerX()
		{
					}
		public float centerY()
		{
					}
		public void center(float x, float y)
		{
					}
		public void locate(float x, float y)
		{
					}
		public void increaseSteps()
		{
					}
		public void makeEncounterCount()
		{
					}
		public float makeEncounterTroopId()
		{
					}
		public bool meetsEncounterConditions(IDataEncounterList encounter)
		{
					}
		public bool executeEncounter()
		{
					}
		public void startMapEvent(float x, float y, float[] triggers, bool normal)
		{
					}
		public void moveByInput()
		{
					}
		public bool canMove()
		{
					}
		public float getInputDirection()
		{
					}
		public void executeMove(float direction)
		{
					}
		public void update()
		{
					}
		public void update(bool sceneActive)
		{
					}
		public void updateDashing()
		{
					}
		public bool isDashButtonPressed()
		{
					}
		public void updateScroll(float lastScrolledX, float lastScrolledY)
		{
					}
		public void updateVehicle()
		{
					}
		public void updateVehicleGetOn()
		{
					}
		public void updateVehicleGetOff()
		{
					}
		public void updateNonmoving(bool wasMoving)
		{
					}
		public bool triggerAction()
		{
					}
		public bool triggerButtonAction()
		{
					}
		public bool triggerTouchAction()
		{
					}
		public bool triggerTouchActionD1(float x1, float y1)
		{
					}
		public bool triggerTouchActionD2(float x2, float y2)
		{
					}
		public bool triggerTouchActionD3(float x2, float y2)
		{
					}
		public void updateEncounterCount()
		{
					}
		public bool canEncounter()
		{
					}
		public float encounterProgressValue()
		{
					}
		public void checkEventTriggerHere(float[] triggers)
		{
					}
		public void checkEventTriggerThere(float[] triggers)
		{
					}
		public bool checkEventTriggerTouch(float x, float y)
		{
					}
		public bool canStartLocalEvents()
		{
					}
		public bool getOnOffVehicle()
		{
					}
		public bool getOnVehicle()
		{
					}
		public bool getOffVehicle()
		{
					}
		public void forceMoveForward()
		{
					}
		public bool isOnDamageFloor()
		{
					}
		public void moveStraight()
		{
					}
		public void moveDiagonally()
		{
					}
		public void jump(float xPlus, float yPlus)
		{
					}
		public void showFollowers()
		{
					}
		public void hideFollowers()
		{
					}
		public void gatherFollowers()
		{
					}
		public bool areFollowersGathering()
		{
					}
		public bool areFollowersGathered()
		{
					}
	}

		public class Game_Follower : Game_Character
	{
		public Game_Follower() : base()
		{
			
		}
		public float _memberIndex;
		public void initialize()
		{
					}
		public void refresh()
		{
					}
		public Game_Actor actor()
		{
					}
		public bool isVisible()
		{
					}
		public void update()
		{
					}
		public void chaseCharacter(Game_CharacterBase character)
		{
					}
	}

		public class Game_Followers : Game_Character
	{
		public Game_Followers() : base()
		{
			
		}
		public bool _visible;
		public bool _gathering;
		public Game_Follower[] _data;
		public void initialize()
		{
					}
		public bool isVisible()
		{
					}
		public void show()
		{
					}
		public void hide()
		{
					}
		public Game_Follower follower(float index)
		{
					}
		public void forEach(Function callback, object thisObject)
		{
					}
		public void reverseEach(Function callback, object thisObject)
		{
					}
		public void refresh()
		{
					}
		public void update()
		{
					}
		public void updateMove()
		{
					}
		public void jumpAll()
		{
					}
		public void synchronize(float x, float y, float d)
		{
					}
		public void gather()
		{
					}
		public bool areGathering()
		{
					}
		public bool visibleFollowers()
		{
					}
		public bool areMoving()
		{
					}
		public bool areGathered()
		{
					}
		public bool isSomeoneCollided()
		{
					}
	}

		public class Game_Vehicle : Game_Character
	{
		public Game_Vehicle() : base()
		{
			
		}
		public string _type;
		public float _mapId;
		public float _altitude;
		public bool _driving;
		public IAudioObject _bgm;
		public bool isAirship;
		public void initialize()
		{
					}
		public void initMembers()
		{
					}
		public bool isBoat()
		{
					}
		public bool isShip()
		{
					}
		public void resetDirection()
		{
					}
		public void initMoveSpeed()
		{
					}
		public Game_Vehicle vehicle()
		{
					}
		public void loadSystemSettings()
		{
					}
		public void refresh()
		{
					}
		public void setLocation(float mapId, float x, float y)
		{
					}
		public bool pos(float x, float y)
		{
					}
		public bool isMapPassable(float x, float y, float d)
		{
					}
		public void getOn()
		{
					}
		public void getOff()
		{
					}
		public void setBgm(IAudioObject bgm)
		{
					}
		public void playBgm()
		{
					}
		public void syncWithPlayer()
		{
					}
		public float screenY()
		{
					}
		public float shadowX()
		{
					}
		public float shadowY()
		{
					}
		public float shadowOpacity()
		{
					}
		public bool canMove()
		{
					}
		public void update()
		{
					}
		public void updateAirship()
		{
					}
		public void updateAirshipAltitude()
		{
					}
		public float maxAltitude()
		{
					}
		public bool isLowest()
		{
					}
		public bool isHighest()
		{
					}
		public bool isTakeoffOk()
		{
					}
		public bool isLandOk(float x, float y, float d)
		{
					}
	}

		public class Game_Event : Game_Character
	{
		public Game_Event() : base()
		{
			
		}
		public Game_Event(float mapId, float eventId) : base()
		{
			
		}
		public float _mapId;
		public float _eventId;
		public float _moveType;
		public float _trigger;
		public bool _starting;
		public bool _erased;
		public float _pageIndex;
		public float _originalPattern;
		public float _originalDirection;
		public float _prelockDirection;
		public bool _locked;
		public Game_Interpreter _interpreter;
		public void initialize()
		{
					}
		public void initialize(float mapId, float eventId)
		{
					}
		public void initMembers()
		{
					}
		public float eventId()
		{
					}
		public IDataMapEvent event()
		{
					}
		public IDataMapEventPage page()
		{
					}
		public IDataMapEventPageList list()
		{
					}
		public bool isCollidedWithCharacters()
		{
					}
		public bool isCollidedWithEvents()
		{
					}
		public bool isCollidedWithPlayerCharacters()
		{
					}
		public void lock()
		{
					}
		public void unlock()
		{
					}
		public void updateStop()
		{
					}
		public void updateSelfMovement()
		{
					}
		public float stopCountThreshold()
		{
					}
		public void moveTypeRandom()
		{
					}
		public void moveTypeTowardPlayer()
		{
					}
		public float isNearThePlayer()
		{
					}
		public void moveTypeCustom()
		{
					}
		public bool isStarting()
		{
					}
		public void clearStartingFlag()
		{
					}
		public bool isTriggerIn(float[] triggers)
		{
					}
		public void start()
		{
					}
		public void erase()
		{
					}
		public void refresh()
		{
					}
		public float findProperPageIndex()
		{
					}
		public bool meetsConditions(IDataMapEventPage page)
		{
					}
		public void setupPage()
		{
					}
		public void clearPageSettings()
		{
					}
		public void setupPageSettings()
		{
					}
		public bool isOriginalPattern()
		{
					}
		public void resetPattern()
		{
					}
		public void checkEventTriggerTouch(float x, float y)
		{
					}
		public void checkEventTriggerAuto()
		{
					}
		public void update()
		{
					}
		public void updateParallel()
		{
					}
		public void locate(float x, float y)
		{
					}
		public void forceMoveRoute(IDataMoveRoute moveRoute)
		{
					}
	}

		public class Game_Interpreter
	{
		public Game_Interpreter(float depth = default(float))
		{
			
		}
		protected Game_Interpreter()
		{
			
		}
		public float _depth;
		public _branch_0_ _branch;
		public object[] _params;
		public float _indent;
		public float _frameCount;
		public float _freezeChecker;
		public float _mapId;
		public float _eventId;
		public IDataMapEventPageList[] _list;
		public float _index;
		public Game_Interpreter _childInterpreter;
		public Game_Character _character;
		public void initialize(float depth = default(float))
		{
					}
		public void checkOverflow()
		{
					}
		public void clear()
		{
					}
		public void setup(IDataMapEventPageList[] list, float eventId = default(float))
		{
					}
		public float eventId()
		{
					}
		public bool isOnCurrentMap()
		{
					}
		public bool setupReservedCommonEvent()
		{
					}
		public bool isRunning()
		{
					}
		public void update()
		{
					}
		public bool updateChild()
		{
					}
		public bool updateWait()
		{
					}
		public bool updateWaitCount()
		{
					}
		public bool updateWaitMode()
		{
					}
		public void setWaitMode(string waitMode)
		{
					}
		public void wait(float duration)
		{
					}
		public float fadeSpeed()
		{
					}
		public bool executeCommand()
		{
					}
		public bool checkFreeze()
		{
					}
		public void terminate()
		{
					}
		public void skipBranch()
		{
					}
		public IDataMapEventPageList currentCommand()
		{
					}
		public float nextEventCode()
		{
					}
		public void iterateActorId(float param, Function callback)
		{
					}
		public void iterateActorEx(float param1, float param2, Function callback)
		{
					}
		public void iterateActorIndex(float param, Function callback)
		{
					}
		public void iterateEnemyIndex(float param, Function callback)
		{
					}
		public void iterateBattler(float param1, float param2, Function callback)
		{
					}
		public Game_Character character(float param)
		{
					}
		public float operateValue(float operation, float operandType, float operand)
		{
					}
		public void changeHp(Game_Battler target, float value, bool allowDeath)
		{
					}
		public bool command101()
		{
					}
		public bool command102()
		{
					}
		public object setupChoices(Func<object, string> @params)
		{
					}
		public bool command402()
		{
					}
		public bool command403()
		{
					}
		public bool command103()
		{
					}
		public object setupNumInput(Func<object, string> @params)
		{
					}
		public bool command104()
		{
					}
		public object setupItemChoice(Func<object, string> @params)
		{
					}
		public bool command105()
		{
					}
		public bool command108()
		{
					}
		public bool command111()
		{
					}
		public bool command411()
		{
					}
		public bool command112()
		{
					}
		public bool command413()
		{
					}
		public bool command113()
		{
					}
		public bool command115()
		{
					}
		public bool command117()
		{
					}
		public void setupChild(IDataMapEventPageList[] list, float eventId)
		{
					}
		public bool command118()
		{
					}
		public bool command119()
		{
					}
		public void jumpTo(float index)
		{
					}
		public bool command121()
		{
					}
		public bool command122()
		{
					}
		public float gameDataOperand(float type, float param1, float param2)
		{
					}
		public void operateVariable(float variableId, float operationType, float value)
		{
					}
		public bool command123()
		{
					}
		public bool command124()
		{
					}
		public bool command125()
		{
					}
		public bool command126()
		{
					}
		public bool command127()
		{
					}
		public bool command128()
		{
					}
		public bool command129()
		{
					}
		public bool command132()
		{
					}
		public bool command133()
		{
					}
		public bool command134()
		{
					}
		public bool command135()
		{
					}
		public bool command136()
		{
					}
		public bool command137()
		{
					}
		public bool command138()
		{
					}
		public bool command139()
		{
					}
		public bool command140()
		{
					}
		public bool command201()
		{
					}
		public bool command202()
		{
					}
		public bool command203()
		{
					}
		public bool command204()
		{
					}
		public bool command205()
		{
					}
		public bool command206()
		{
					}
		public bool command211()
		{
					}
		public bool command212()
		{
					}
		public bool command213()
		{
					}
		public bool command214()
		{
					}
		public bool command216()
		{
					}
		public bool command217()
		{
					}
		public bool command221()
		{
					}
		public bool command222()
		{
					}
		public bool command223()
		{
					}
		public bool command224()
		{
					}
		public bool command225()
		{
					}
		public bool command230()
		{
					}
		public bool command231()
		{
					}
		public bool command232()
		{
					}
		public bool command233()
		{
					}
		public bool command234()
		{
					}
		public bool command235()
		{
					}
		public bool command236()
		{
					}
		public bool command241()
		{
					}
		public bool command242()
		{
					}
		public bool command243()
		{
					}
		public bool command244()
		{
					}
		public bool command245()
		{
					}
		public bool command246()
		{
					}
		public bool command249()
		{
					}
		public bool command250()
		{
					}
		public bool command251()
		{
					}
		public bool command261()
		{
					}
		public string videoFileExt()
		{
					}
		public bool command281()
		{
					}
		public bool command282()
		{
					}
		public bool command283()
		{
					}
		public bool command284()
		{
					}
		public bool command285()
		{
					}
		public bool command301()
		{
					}
		public bool command601()
		{
					}
		public bool command602()
		{
					}
		public bool command603()
		{
					}
		public bool command302()
		{
					}
		public bool command311()
		{
					}
		public bool command312()
		{
					}
		public bool command326()
		{
					}
		public bool command313()
		{
					}
		public bool command314()
		{
					}
		public bool command315()
		{
					}
		public bool command316()
		{
					}
		public bool command317()
		{
					}
		public bool command318()
		{
					}
		public bool command319()
		{
					}
		public bool command320()
		{
					}
		public bool command321()
		{
					}
		public bool command322()
		{
					}
		public bool command323()
		{
					}
		public bool command324()
		{
					}
		public bool command325()
		{
					}
		public bool command331()
		{
					}
		public bool command332()
		{
					}
		public bool command342()
		{
					}
		public bool command333()
		{
					}
		public bool command334()
		{
					}
		public bool command335()
		{
					}
		public bool command336()
		{
					}
		public bool command337()
		{
					}
		public bool command339()
		{
					}
		public bool command340()
		{
					}
		public bool command351()
		{
					}
		public bool command352()
		{
					}
		public bool command353()
		{
					}
		public bool command354()
		{
					}
		public bool command355()
		{
					}
		public bool command356()
		{
					}
		public void pluginCommand(string command, string[] args)
		{
					}
		public void requestImages(object list, object commonList)
		{
					}

				public class _branch_0_
		{
			
			public float this[float index]
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

		public class Scene_Base : Stage
	{
		public Scene_Base() : base()
		{
			
		}
		public bool _active;
		public float _fadeSign;
		public float _fadeDuration;
		public ScreenSprite _fadeSprite;
		public WindowLayer _windowLayer;
		public Spriteset_Base _spriteset;
		public void initialize()
		{
					}
		public void create()
		{
					}
		public bool isActive()
		{
					}
		public bool isReady()
		{
					}
		public void start()
		{
					}
		public void update()
		{
					}
		public void stop()
		{
					}
		public bool isBusy()
		{
					}
		public void terminate()
		{
					}
		public void createWindowLayer()
		{
					}
		public void addWindow(Window_Base window)
		{
					}
		public void startFadeIn(float duration = default(float), bool white = default(bool))
		{
					}
		public void startFadeOut(float duration = default(float), bool white = default(bool))
		{
					}
		public void createFadeSprite(bool white = default(bool))
		{
					}
		public void updateFade()
		{
					}
		public void updateChildren()
		{
					}
		public void popScene()
		{
					}
		public void checkGameover()
		{
					}
		public void fadeOutAll()
		{
					}
		public float fadeSpeed()
		{
					}
		public float slowFadeSpeed()
		{
					}
		public void attachReservation()
		{
					}
		public void detachReservation()
		{
					}
	}

		public class Scene_Boot : Scene_Base
	{
		public Scene_Boot() : base()
		{
			
		}
		public float _startDate;
		public static void loadSystemImages()
		{
					}
		public void initialize()
		{
					}
		public void create()
		{
					}
		public void loadSystemWindowImage()
		{
					}
		public bool isReady()
		{
					}
		public bool isGameFontLoaded()
		{
					}
		public void start()
		{
					}
		public void updateDocumentTitle()
		{
					}
		public void checkPlayerLocation()
		{
					}
	}

		public class Scene_Title : Scene_Base
	{
		public Scene_Title() : base()
		{
			
		}
		public Window_TitleCommand _commandWindow;
		public Sprite _backSprite1;
		public Sprite _backSprite2;
		public Sprite _gameTitleSprite;
		public void initialize()
		{
					}
		public void create()
		{
					}
		public void start()
		{
					}
		public void update()
		{
					}
		public bool isBusy()
		{
					}
		public void terminate()
		{
					}
		public void createBackground()
		{
					}
		public void createForeground()
		{
					}
		public void drawGameTitle()
		{
					}
		public void centerSprite(Sprite_Base sprite)
		{
					}
		public void createCommandWindow()
		{
					}
		public void commandNewGame()
		{
					}
		public void commandContinue()
		{
					}
		public void commandOptions()
		{
					}
		public void playTitleMusic()
		{
					}
	}

		public class Scene_Map : Scene_Base
	{
		public Scene_Map() : base()
		{
			
		}
		public float _waitCount;
		public float _encounterEffectDuration;
		public bool _mapLoaded;
		public Window_MapName _mapNameWindow;
		public Window_Message _messageWindow;
		public Window_ScrollText _scrollTextWindow;
		public Spriteset_Map _spriteset;
		public float _touchCount;
		public bool _transfer;
		public bool menuCalling;
		public void initialize()
		{
					}
		public void create()
		{
					}
		public bool isReady()
		{
					}
		public void onMapLoaded()
		{
					}
		public void start()
		{
					}
		public void update()
		{
					}
		public void updateMainMultiply()
		{
					}
		public void updateMain()
		{
					}
		public bool isFastForward()
		{
					}
		public void stop()
		{
					}
		public bool isBusy()
		{
					}
		public void terminate()
		{
					}
		public bool needsFadeIn()
		{
					}
		public bool needsSlowFadeOut()
		{
					}
		public bool updateWaitCount()
		{
					}
		public void updateDestination()
		{
					}
		public bool isMapTouchOk()
		{
					}
		public void processMapTouch()
		{
					}
		public bool isSceneChangeOk()
		{
					}
		public void updateScene()
		{
					}
		public void createDisplayObjects()
		{
					}
		public void createSpriteset()
		{
					}
		public void createAllWindows()
		{
					}
		public void createMapNameWindow()
		{
					}
		public void createMessageWindow()
		{
					}
		public void createScrollTextWindow()
		{
					}
		public void updateTransferPlayer()
		{
					}
		public void updateEncounter()
		{
					}
		public void updateCallMenu()
		{
					}
		public bool isMenuEnabled()
		{
					}
		public bool isMenuCalled()
		{
					}
		public void callMenu()
		{
					}
		public void updateCallDebug()
		{
					}
		public bool isDebugCalled()
		{
					}
		public void fadeInForTransfer()
		{
					}
		public void fadeOutForTransfer()
		{
					}
		public void launchBattle()
		{
					}
		public void stopAudioOnBattleStart()
		{
					}
		public void startEncounterEffect()
		{
					}
		public void updateEncounterEffect()
		{
					}
		public void snapForBattleBackground()
		{
					}
		public void startFlashForEncounter(float duration)
		{
					}
		public float encounterEffectSpeed()
		{
					}
	}

		public class Scene_MenuBase : Scene_Base
	{
		public Scene_MenuBase() : base()
		{
			
		}
		public Game_Actor _actor;
		public Sprite _backgroundSprite;
		public Window_Help _helpWindow;
		public void initialize()
		{
					}
		public void create()
		{
					}
		public Game_Actor actor()
		{
					}
		public void updateActor()
		{
					}
		public void createBackground()
		{
					}
		public void setBackgroundOpacity(float opacity)
		{
					}
		public void createHelpWindow()
		{
					}
		public void nextActor()
		{
					}
		public void previousActor()
		{
					}
		public void onActorChange()
		{
					}
	}

		public class Scene_Menu : Scene_MenuBase
	{
		public Scene_Menu() : base()
		{
			
		}
		public Window_MenuStatus _statusWindow;
		public Window_Gold _goldWindow;
		public Window_MenuCommand _commandWindow;
		public void initialize()
		{
					}
		public void create()
		{
					}
		public void start()
		{
					}
		public void createCommandWindow()
		{
					}
		public void createGoldWindow()
		{
					}
		public void createStatusWindow()
		{
					}
		public void commandItem()
		{
					}
		public void commandPersonal()
		{
					}
		public void commandFormation()
		{
					}
		public void commandOptions()
		{
					}
		public void commandSave()
		{
					}
		public void commandGameEnd()
		{
					}
		public void onPersonalOk()
		{
					}
		public void onPersonalCancel()
		{
					}
		public void onFormationOk()
		{
					}
		public void onFormationCancel()
		{
					}
	}

		public class Scene_ItemBase : Scene_MenuBase
	{
		public Scene_ItemBase() : base()
		{
			
		}
		public Window_MenuActor _actorWindow;
		public Window_Selectable _itemWindow;
		public void initialize()
		{
					}
		public void create()
		{
					}
		public void createActorWindow()
		{
					}
		public IDataAllItem item()
		{
					}
		public Game_Actor user()
		{
					}
		public bool isCursorLeft()
		{
					}
		public void showSubWindow(Window_Base window)
		{
					}
		public void hideSubWindow(Window_Base window)
		{
					}
		public void onActorOk()
		{
					}
		public void onActorCancel()
		{
					}
		public void determineItem()
		{
					}
		public void useItem()
		{
					}
		public void activateItemWindow()
		{
					}
		public void itemTargetActors()
		{
					}
		public bool canUse()
		{
					}
		public bool isItemEffectsValid()
		{
					}
		public void applyItem()
		{
					}
		public void checkCommonEvent()
		{
					}
	}

		public class Scene_Item : Scene_ItemBase
	{
		public Scene_Item() : base()
		{
			
		}
		public Window_ItemCategory _categoryWindow;
		public Window_ItemList _itemWindow;
		public void initialize()
		{
					}
		public void create()
		{
					}
		public void createCategoryWindow()
		{
					}
		public void createItemWindow()
		{
					}
		public Game_Actor user()
		{
					}
		public void onCategoryOk()
		{
					}
		public void onItemOk()
		{
					}
		public void onItemCancel()
		{
					}
		public void playSeForItem()
		{
					}
		public void useItem()
		{
					}
	}

		public class Scene_Skill : Scene_ItemBase
	{
		public Scene_Skill() : base()
		{
			
		}
		public Window_SkillType _skillTypeWindow;
		public Window_SkillStatus _statusWindow;
		public Window_SkillList _itemWindow;
		public void initialize()
		{
					}
		public void create()
		{
					}
		public void start()
		{
					}
		public void createSkillTypeWindow()
		{
					}
		public void createStatusWindow()
		{
					}
		public void createItemWindow()
		{
					}
		public void refreshActor()
		{
					}
		public Game_Actor user()
		{
					}
		public void commandSkill()
		{
					}
		public void onItemOk()
		{
					}
		public void onItemCancel()
		{
					}
		public void playSeForItem()
		{
					}
		public void useItem()
		{
					}
		public void onActorChange()
		{
					}
	}

		public class Scene_Equip : Scene_MenuBase
	{
		public Scene_Equip() : base()
		{
			
		}
		public Window_EquipStatus _statusWindow;
		public Window_EquipCommand _commandWindow;
		public Window_EquipSlot _slotWindow;
		public Window_EquipItem _itemWindow;
		public void initialize()
		{
					}
		public void create()
		{
					}
		public void createStatusWindow()
		{
					}
		public void createCommandWindow()
		{
					}
		public void createSlotWindow()
		{
					}
		public void createItemWindow()
		{
					}
		public void refreshActor()
		{
					}
		public void commandEquip()
		{
					}
		public void commandOptimize()
		{
					}
		public void commandClear()
		{
					}
		public void onSlotOk()
		{
					}
		public void onSlotCancel()
		{
					}
		public void onItemOk()
		{
					}
		public void onItemCancel()
		{
					}
		public void onActorChange()
		{
					}
	}

		public class Scene_Status : Scene_MenuBase
	{
		public Scene_Status() : base()
		{
			
		}
		public Window_Status _statusWindow;
		public void initialize()
		{
					}
		public void create()
		{
					}
		public void refreshActor()
		{
					}
		public void onActorChange()
		{
					}
	}

		public class Scene_Options : Scene_MenuBase
	{
		public Scene_Options() : base()
		{
			
		}
		public Window_Options _optionsWindow;
		public void initialize()
		{
					}
		public void create()
		{
					}
		public void terminate()
		{
					}
		public void createOptionsWindow()
		{
					}
	}

		public class Scene_File : Scene_MenuBase
	{
		public Scene_File() : base()
		{
			
		}
		public Window_SavefileList _listWindow;
		public Window_Help _helpWindow;
		public void initialize()
		{
					}
		public void create()
		{
					}
		public void start()
		{
					}
		public float savefileId()
		{
					}
		public void createHelpWindow()
		{
					}
		public void createListWindow()
		{
					}
		public string mode()
		{
					}
		public void activateListWindow()
		{
					}
		public string helpWindowText()
		{
					}
		public float firstSavefileIndex()
		{
					}
		public void onSavefileOk()
		{
					}
	}

		public class Scene_Save : Scene_File
	{
		public Scene_Save() : base()
		{
			
		}
		public void initialize()
		{
					}
		public string mode()
		{
					}
		public string helpWindowText()
		{
					}
		public float firstSavefileIndex()
		{
					}
		public void onSavefileOk()
		{
					}
		public void onSaveSuccess()
		{
					}
		public void onSaveFailure()
		{
					}
	}

		public class Scene_Load : Scene_File
	{
		public Scene_Load() : base()
		{
			
		}
		public bool _loadSuccess;
		public void initialize()
		{
					}
		public void terminate()
		{
					}
		public string mode()
		{
					}
		public string helpWindowText()
		{
					}
		public float firstSavefileIndex()
		{
					}
		public void onSavefileOk()
		{
					}
		public void onSaveSuccess()
		{
					}
		public void onSaveFailure()
		{
					}
		public void reloadMapIfUpdated()
		{
					}
	}

		public class Scene_GameEnd : Scene_MenuBase
	{
		public Scene_GameEnd() : base()
		{
			
		}
		public Window_GameEnd _commandWindow;
		public void initialize()
		{
					}
		public void create()
		{
					}
		public void stop()
		{
					}
		public void createBackground()
		{
					}
		public void createCommandWindow()
		{
					}
		public void commandToTitle()
		{
					}
	}

		public class Scene_Shop : Scene_MenuBase
	{
		public Scene_Shop() : base()
		{
			
		}
		public object[][] _goods;
		public bool _purchaseOnly;
		public IDataAllItem _item;
		public Window_Gold _goldWindow;
		public Window_ShopCommand _commandWindow;
		public Window_Base _dummyWindow;
		public Window_ShopNumber _numberWindow;
		public Window_ShopStatus _statusWindow;
		public Window_ShopBuy _buyWindow;
		public Window_ItemCategory _categoryWindow;
		public Window_ShopSell _sellWindow;
		public void initialize()
		{
					}
		public void prepare(object[][] goods, bool purchaseOnly)
		{
					}
		public void create()
		{
					}
		public void createGoldWindow()
		{
					}
		public void createCommandWindow()
		{
					}
		public void createDummyWindow()
		{
					}
		public void createNumberWindow()
		{
					}
		public void createStatusWindow()
		{
					}
		public void createBuyWindow()
		{
					}
		public void createCategoryWindow()
		{
					}
		public void createSellWindow()
		{
					}
		public void activateBuyWindow()
		{
					}
		public void activateSellWindow()
		{
					}
		public void commandBuy()
		{
					}
		public void commandSell()
		{
					}
		public void onBuyOk()
		{
					}
		public void onBuyCancel()
		{
					}
		public void onCategoryOk()
		{
					}
		public void onCategoryCancel()
		{
					}
		public void onSellOk()
		{
					}
		public void onSellCancel()
		{
					}
		public void onNumberOk()
		{
					}
		public void onNumberCancel()
		{
					}
		public void doBuy(float number)
		{
					}
		public void doSell(float number)
		{
					}
		public void endNumberInput()
		{
					}
		public float maxBuy()
		{
					}
		public float maxSell()
		{
					}
		public float money()
		{
					}
		public string currencyUnit()
		{
					}
		public float buyingPrice()
		{
					}
		public float sellingPrice()
		{
					}
	}

		public class Scene_Name : Scene_MenuBase
	{
		public Scene_Name() : base()
		{
			
		}
		public Game_Actor _actor;
		public float _actorId;
		public float _maxLength;
		public Window_NameEdit _editWindow;
		public Window_NameInput _inputWindow;
		public void initialize()
		{
					}
		public void prepare(float actorId, float maxLength)
		{
					}
		public void create()
		{
					}
		public void start()
		{
					}
		public void createEditWindow()
		{
					}
		public void createInputWindow()
		{
					}
		public void onInputOk()
		{
					}
	}

		public class Scene_Debug : Scene_MenuBase
	{
		public Scene_Debug() : base()
		{
			
		}
		public Window_DebugEdit _editWindow;
		public Window_DebugRange _rangeWindow;
		public Window_Base _debugHelpWindow;
		public void initialize()
		{
					}
		public void create()
		{
					}
		public void createRangeWindow()
		{
					}
		public void createEditWindow()
		{
					}
		public void createDebugHelpWindow()
		{
					}
		public void onRangeOk()
		{
					}
		public void onEditCancel()
		{
					}
		public void refreshHelpWindow()
		{
					}
		public string helpText()
		{
					}
	}

		public class Scene_Battle : Scene_Base
	{
		public Scene_Battle() : base()
		{
			
		}
		public Window_PartyCommand _partyCommandWindow;
		public Window_ActorCommand _actorCommandWindow;
		public Window_BattleSkill _skillWindow;
		public Window_BattleItem _itemWindow;
		public Window_BattleActor _actorWindow;
		public Window_BattleEnemy _enemyWindow;
		public Window_Help _helpWindow;
		public Window_BattleStatus _statusWindow;
		public Spriteset_Battle _spriteset;
		public Window_BattleLog _logWindow;
		public Window_Message _messageWindow;
		public Window_ScrollText _scrollTextWindow;
		public void initialize()
		{
					}
		public void create()
		{
					}
		public void start()
		{
					}
		public void update()
		{
					}
		public void updateBattleProcess()
		{
					}
		public bool isAnyInputWindowActive()
		{
					}
		public void changeInputWindow()
		{
					}
		public void stop()
		{
					}
		public void terminate()
		{
					}
		public bool needsSlowFadeOut()
		{
					}
		public void updateStatusWindow()
		{
					}
		public void updateWindowPositions()
		{
					}
		public void createDisplayObjects()
		{
					}
		public void createSpriteset()
		{
					}
		public void createAllWindows()
		{
					}
		public void createLogWindow()
		{
					}
		public void createStatusWindow()
		{
					}
		public void createPartyCommandWindow()
		{
					}
		public void createActorCommandWindow()
		{
					}
		public void createHelpWindow()
		{
					}
		public void createSkillWindow()
		{
					}
		public void createItemWindow()
		{
					}
		public void createActorWindow()
		{
					}
		public void createEnemyWindow()
		{
					}
		public void createMessageWindow()
		{
					}
		public void createScrollTextWindow()
		{
					}
		public void refreshStatus()
		{
					}
		public void startPartyCommandSelection()
		{
					}
		public void commandFight()
		{
					}
		public void commandEscape()
		{
					}
		public void startActorCommandSelection()
		{
					}
		public void commandAttack()
		{
					}
		public void commandSkill()
		{
					}
		public void commandGuard()
		{
					}
		public void commandItem()
		{
					}
		public void selectNextCommand()
		{
					}
		public void selectPreviousCommand()
		{
					}
		public void selectActorSelection()
		{
					}
		public void onActorOk()
		{
					}
		public void onActorCancel()
		{
					}
		public void selectEnemySelection()
		{
					}
		public void onEnemyOk()
		{
					}
		public void onEnemyCancel()
		{
					}
		public void onSkillOk()
		{
					}
		public void onSkillCancel()
		{
					}
		public void onItemOk()
		{
					}
		public void onItemCancel()
		{
					}
		public void onSelectAction()
		{
					}
		public void endCommandSelection()
		{
					}
	}

		public class Scene_Gameover : Scene_Base
	{
		public Scene_Gameover() : base()
		{
			
		}
		public Sprite _backSprite;
		public void initialize()
		{
					}
		public void create()
		{
					}
		public void start()
		{
					}
		public void update()
		{
					}
		public void stop()
		{
					}
		public void terminate()
		{
					}
		public void playGameoverMusic()
		{
					}
		public void createBackground()
		{
					}
		public bool isTriggered()
		{
					}
		public void gotoTitle()
		{
					}
	}

		public class Sprite_Base : Sprite
	{
		public Sprite_Base() : base()
		{
			
		}
		public Sprite_Animation[] _animationSprites;
		public Sprite_Base _effectTarget;
		public bool _hiding;
		public bool visible;
		public void initialize()
		{
					}
		public void update()
		{
					}
		public void hide()
		{
					}
		public void show()
		{
					}
		public void updateVisibility()
		{
					}
		public void updateAnimationSprites()
		{
					}
		public void startAnimation(IDataAnimation animation, bool mirror, float delay)
		{
					}
		public bool isAnimationPlaying()
		{
					}
	}

		public class Sprite_Button : Sprite
	{
		public Sprite_Button() : base()
		{
			
		}
		public bool _touching;
		public Rectangle _coldFrame;
		public Rectangle _hotFrame;
		public Function _clickHandler;
		public void initialize()
		{
					}
		public void update()
		{
					}
		public void updateFrame()
		{
					}
		public void setColdFrame(float x, float y, float width, float height)
		{
					}
		public void setHotFrame(float x, float y, float width, float height)
		{
					}
		public void setClickHandler(Function method)
		{
					}
		public void callClickHandler()
		{
					}
		public void processTouch()
		{
					}
		public bool isActive()
		{
					}
		public bool isButtonTouched()
		{
					}
		public float canvasToLocalX(float x)
		{
					}
		public float canvasToLocalY(float y)
		{
					}
		public void reserveFaceImages()
		{
					}
	}

		public class Sprite_Character : Sprite_Base
	{
		public Sprite_Character(Game_CharacterBase character = default(Game_CharacterBase)) : base()
		{
			
		}
		protected Sprite_Character() : base()
		{
			
		}
		public Game_Character _character;
		public Sprite_Balloon _balloonSprite;
		public float _balloonDuration;
		public float _tilesetId;
		public float _tileId;
		public string _characterName;
		public float _characterIndex;
		public Sprite _upperBody;
		public Sprite _lowerBody;
		public bool _isBigCharacter;
		public float _bushDepth;
		public void initialize(Game_CharacterBase character = default(Game_CharacterBase))
		{
					}
		public void initMembers()
		{
					}
		public void setCharacter(Game_CharacterBase character)
		{
					}
		public void update()
		{
					}
		public void updateVisibility()
		{
					}
		public bool isTile()
		{
					}
		public Bitmap tilesetBitmap(float tileId)
		{
					}
		public void updateBitmap()
		{
					}
		public bool isImageChanged()
		{
					}
		public void setTileBitmap()
		{
					}
		public void setCharacterBitmap()
		{
					}
		public void updateFrame()
		{
					}
		public void updateTileFrame()
		{
					}
		public void updateCharacterFrame()
		{
					}
		public float characterBlockX()
		{
					}
		public float characterBlockY()
		{
					}
		public float characterPatternX()
		{
					}
		public float characterPatternY()
		{
					}
		public float patternWidth()
		{
					}
		public float patternHeight()
		{
					}
		public void updateHalfBodySprites()
		{
					}
		public void createHalfBodySprites()
		{
					}
		public void updatePosition()
		{
					}
		public void updateAnimation()
		{
					}
		public void updateOther()
		{
					}
		public void setupAnimation()
		{
					}
		public void setupBalloon()
		{
					}
		public void startBalloon()
		{
					}
		public void updateBalloon()
		{
					}
		public void endBalloon()
		{
					}
		public bool isBalloonPlaying()
		{
					}
	}

		public class Sprite_Battler : Sprite_Base
	{
		public Sprite_Battler() : base()
		{
			
		}
		public Game_Battler _battler;
		public Sprite_Damage[] _damages;
		public float _homeX;
		public float _homeY;
		public float _offsetX;
		public float _offsetY;
		public float _targetOffsetX;
		public float _targetOffsetY;
		public float _movementDuration;
		public float _selectionEffectCount;
		public void initialize(Game_Battler battler = default(Game_Battler))
		{
					}
		public void initMembers()
		{
					}
		public void setBattler(Game_Battler battler)
		{
					}
		public void setHome(float x, float y)
		{
					}
		public void update()
		{
					}
		public void updateVisibility()
		{
					}
		public void updateMain()
		{
					}
		public void updateBitmap()
		{
					}
		public void updateFrame()
		{
					}
		public void updateMove()
		{
					}
		public void updatePosition()
		{
					}
		public void updateAnimation()
		{
					}
		public void updateDamagePopup()
		{
					}
		public void updateSelectionEffect()
		{
					}
		public void setupAnimation()
		{
					}
		public void setupDamagePopup()
		{
					}
		public float damageOffsetX()
		{
					}
		public float damageOffsetY()
		{
					}
		public void startMove(float x, float y, float duration)
		{
					}
		public void onMoveEnd()
		{
					}
		public bool isEffecting()
		{
					}
		public bool isMoving()
		{
					}
		public bool inHomePosition()
		{
					}
	}

		public class IMotion
	{
		protected IMotion()
		{
			
		}
		public float index;
		public bool loop;
	}

		public class Sprite_Actor : Sprite_Battler
	{
		public Sprite_Actor() : base()
		{
			
		}
		public static MOTIONS_0_ MOTIONS;
		public string _battlerName;
		public IMotion _motion;
		public float _motionCount;
		public float _pattern;
		public Sprite_Base _mainSprite;
		public Sprite_Base _effectTarget;
		public Sprite _shadowSprite;
		public Sprite_Weapon _weaponSprite;
		public Sprite_StateOverlay _stateSprite;
		public void initialize(Game_Actor battler = default(Game_Actor))
		{
					}
		public void initMembers()
		{
					}
		public void createMainSprite()
		{
					}
		public void createShadowSprite()
		{
					}
		public void createWeaponSprite()
		{
					}
		public void createStateSprite()
		{
					}
		public void setBattler(Game_Actor battler)
		{
					}
		public void moveToStartPosition()
		{
					}
		public void setActorHome(float index)
		{
					}
		public void update()
		{
					}
		public void updateShadow()
		{
					}
		public void updateMain()
		{
					}
		public void setupMotion()
		{
					}
		public void setupWeaponAnimation()
		{
					}
		public void startMotion(string motionType)
		{
					}
		public void updateTargetPosition()
		{
					}
		public void updateBitmap()
		{
					}
		public void updateFrame()
		{
					}
		public void updateMove()
		{
					}
		public void updateMotion()
		{
					}
		public void updateMotionCount()
		{
					}
		public float motionSpeed()
		{
					}
		public void refreshMotion()
		{
					}
		public void startEntryMotion()
		{
					}
		public void stepForward()
		{
					}
		public void stepBack()
		{
					}
		public void retreat()
		{
					}
		public void onMoveEnd()
		{
					}
		public float damageOffsetX()
		{
					}
		public float damageOffsetY()
		{
					}

				public class MOTIONS_0_
		{
			
			public IMotion this[string index]
			{
				get
				{
					return (IMotion)((dynamic)this)[index];
				}				
				set
				{
					((dynamic)this)[index] = value;
				}
			}
			
		}
	}

		public class Sprite_Enemy : Sprite_Battler
	{
		public Sprite_Enemy() : base()
		{
			
		}
		public Game_Enemy _enemy;
		public bool _appeared;
		public string _battlerName;
		public float _battlerHue;
		public string _effectType;
		public float _effectDuration;
		public float _shake;
		public Sprite_StateIcon _stateIconSprite;
		public void initialize(Game_Enemy battler = default(Game_Enemy))
		{
					}
		public void initMembers()
		{
					}
		public void createStateIconSprite()
		{
					}
		public void setBattler(Game_Enemy battler)
		{
					}
		public void update()
		{
					}
		public void updateBitmap()
		{
					}
		public void loadBitmap(string name, float hue)
		{
					}
		public void updateFrame()
		{
					}
		public void updatePosition()
		{
					}
		public void updateStateSprite()
		{
					}
		public void initVisibility()
		{
					}
		public void setupEffect()
		{
					}
		public void startEffect(string effectType)
		{
					}
		public void startAppear()
		{
					}
		public void startDisappear()
		{
					}
		public void startWhiten()
		{
					}
		public void startBlink()
		{
					}
		public void startCollapse()
		{
					}
		public void startBossCollapse()
		{
					}
		public void startInstantCollapse()
		{
					}
		public void updateEffect()
		{
					}
		public bool isEffecting()
		{
					}
		public void revertToNormal()
		{
					}
		public void updateWhiten()
		{
					}
		public void updateBlink()
		{
					}
		public void updateAppear()
		{
					}
		public void updateDisappear()
		{
					}
		public void updateCollapse()
		{
					}
		public void updateBossCollapse()
		{
					}
		public void updateInstantCollapse()
		{
					}
		public float damageOffsetX()
		{
					}
		public float damageOffsetY()
		{
					}
	}

		public class Sprite_Animation : Sprite
	{
		public Sprite_Animation() : base()
		{
			
		}
		public bool _reduceArtifacts;
		public Sprite_Base _target;
		public IDataAnimation _animation;
		public bool _mirror;
		public float _delay;
		public float _rate;
		public float _duration;
		public float[] _flashColor;
		public float _flashDuration;
		public float _screenFlashDuration;
		public float _hidingDuration;
		public Bitmap _bitmap1;
		public Bitmap _bitmap2;
		public Sprite[] _cellSprites;
		public ScreenSprite _screenFlashSprite;
		public bool _duplicated;
		public void initialize()
		{
					}
		public void initMembers()
		{
					}
		public void setup(Sprite_Base target, IDataAnimation animation, bool mirror, float delay)
		{
					}
		public void remove()
		{
					}
		public void setupRate()
		{
					}
		public void setupDuration()
		{
					}
		public void update()
		{
					}
		public void updateFlash()
		{
					}
		public void updateScreenFlash()
		{
					}
		public float absoluteX()
		{
					}
		public float absoluteY()
		{
					}
		public void updateHiding()
		{
					}
		public bool isPlaying()
		{
					}
		public void loadBitmaps()
		{
					}
		public bool isReady()
		{
					}
		public void createSprites()
		{
					}
		public void createCellSprites()
		{
					}
		public void createScreenFlashSprite()
		{
					}
		public void updateMain()
		{
					}
		public void updatePosition()
		{
					}
		public void updateFrame()
		{
					}
		public void currentFrameIndex()
		{
					}
		public void updateAllCellSprites(float[][] frame)
		{
					}
		public void updateCellSprite(Sprite sprite, float[] cell)
		{
					}
		public void processTimingData(IDataAnimationTiming timing)
		{
					}
		public void startFlash(float[] color, float duration)
		{
					}
		public void startScreenFlash(float[] color, float duration)
		{
					}
		public void startHiding(float duration)
		{
					}
	}

		public class Sprite_Damage : Sprite
	{
		public Sprite_Damage() : base()
		{
			
		}
		public float _duration;
		public float[] _flashColor;
		public float _flashDuration;
		public Bitmap _damageBitmap;
		public void initialize()
		{
					}
		public void setup(Game_Battler target)
		{
					}
		public float digitWidth()
		{
					}
		public float digitHeight()
		{
					}
		public void createMiss()
		{
					}
		public void createDigits(float baseRow, float value)
		{
					}
		public Sprite createChildSprite()
		{
					}
		public void update()
		{
					}
		public void updateChild(Sprite sprite)
		{
					}
		public void updateFlash()
		{
					}
		public void updateOpacity()
		{
					}
		public bool isPlaying()
		{
					}
	}

		public class Sprite_StateIcon : Sprite
	{
		public Sprite_StateIcon() : base()
		{
			
		}
		public static float _iconWidth;
		public static float _iconHeight;
		public Game_Battler _battler;
		public float _iconIndex;
		public float _animationCount;
		public float _animationIndex;
		public void initialize()
		{
					}
		public void initMembers()
		{
					}
		public void setup(Game_Battler battler)
		{
					}
		public void update()
		{
					}
		public float animationWait()
		{
					}
		public void updateIcon()
		{
					}
		public void updateFrame()
		{
					}
	}

		public class Sprite_StateOverlay : Sprite_Base
	{
		public Sprite_StateOverlay() : base()
		{
			
		}
		public Game_Battler _battler;
		public float _overlayIndex;
		public float _animationCount;
		public float _pattern;
		public void initialize()
		{
					}
		public void initMembers()
		{
					}
		public void loadBitmap()
		{
					}
		public void setup(Game_Battler battler)
		{
					}
		public void update()
		{
					}
		public float animationWait()
		{
					}
		public void updatePattern()
		{
					}
		public void updateFrame()
		{
					}
	}

		public class Sprite_Weapon : Sprite_Base
	{
		public Sprite_Weapon() : base()
		{
			
		}
		public float _weaponImageId;
		public float _animationCount;
		public float _pattern;
		public void initialize()
		{
					}
		public void initMembers()
		{
					}
		public void setup(float weaponImageId)
		{
					}
		public void update()
		{
					}
		public float animationWait()
		{
					}
		public void updatePattern()
		{
					}
		public void loadBitmap()
		{
					}
		public void updateFrame()
		{
					}
		public bool isPlaying()
		{
					}
	}

		public class Sprite_Balloon : Sprite_Base
	{
		public Sprite_Balloon() : base()
		{
			
		}
		public float _balloonId;
		public float _duration;
		public void initialize()
		{
					}
		public void initMembers()
		{
					}
		public void loadBitmap()
		{
					}
		public void setup(float balloonId)
		{
					}
		public void update()
		{
					}
		public void updateFrame()
		{
					}
		public float speed()
		{
					}
		public float waitTime()
		{
					}
		public float frameIndex()
		{
					}
		public bool isPlaying()
		{
					}
	}

		public class Sprite_Picture : Sprite
	{
		public Sprite_Picture(float pictureId) : base()
		{
			
		}
		protected Sprite_Picture() : base()
		{
			
		}
		public float _pictureId;
		public string _pictureName;
		public bool _isPicture;
		public void initialize()
		{
					}
		public void initialize(float pictureId)
		{
					}
		public Game_Picture picture()
		{
					}
		public void update()
		{
					}
		public void updateBitmap()
		{
					}
		public void updateOrigin()
		{
					}
		public void updatePosition()
		{
					}
		public void updateScale()
		{
					}
		public void updateTone()
		{
					}
		public void updateOther()
		{
					}
		public void loadBitmap()
		{
					}
	}

		public class Sprite_Timer : Sprite
	{
		public Sprite_Timer() : base()
		{
			
		}
		public float _seconds;
		public void initialize()
		{
					}
		public void createBitmap()
		{
					}
		public void update()
		{
					}
		public void updateBitmap()
		{
					}
		public void redraw()
		{
					}
		public string timerText()
		{
					}
		public void updatePosition()
		{
					}
		public void updateVisibility()
		{
					}
	}

		public class Sprite_Destination : Sprite
	{
		public Sprite_Destination() : base()
		{
			
		}
		public float _frameCount;
		public void initialize()
		{
					}
		public void update()
		{
					}
		public void createBitmap()
		{
					}
		public void updatePosition()
		{
					}
		public void updateAnimation()
		{
					}
	}

		public class Spriteset_Base : Sprite
	{
		public Spriteset_Base() : base()
		{
			
		}
		public float[] _tone;
		public Sprite _baseSprite;
		public ToneSprite _toneSprite;
		public ToneFilter _toneFilter;
		public Sprite _pictureContainer;
		public Sprite_Timer _timerSprite;
		public ScreenSprite _flashSprite;
		public ScreenSprite _fadeSprite;
		public bool opaque;
		public void initialize()
		{
					}
		public void createLowerLayer()
		{
					}
		public void createUpperLayer()
		{
					}
		public void update()
		{
					}
		public void createBaseSprite()
		{
					}
		public void createToneChanger()
		{
					}
		public void createCanvasToneChanger()
		{
					}
		public void createPictures()
		{
					}
		public void createTimer()
		{
					}
		public void createScreenSprites()
		{
					}
		public void updateScreenSprites()
		{
					}
		public void updateToneChanger()
		{
					}
		public void updateWebGLToneChanger()
		{
					}
		public void updateCanvasToneChanger()
		{
					}
		public void updatePosition()
		{
					}
	}

		public class Spriteset_Map : Spriteset_Base
	{
		public Spriteset_Map() : base()
		{
			
		}
		public TilingSprite _parallax;
		public string _parallaxName;
		public Tilemap _tilemap;
		public IDataTileset _tileset;
		public Sprite_Character[] _characterSprites;
		public Sprite _shadowSprite;
		public Sprite_Destination _destinationSprite;
		public Weather _weather;
		public void initialize()
		{
					}
		public void createLowerLayer()
		{
					}
		public void update()
		{
					}
		public void hideCharacters()
		{
					}
		public void createParallax()
		{
					}
		public void createTilemap()
		{
					}
		public void loadTileset()
		{
					}
		public void createCharacters()
		{
					}
		public void createShadow()
		{
					}
		public void createDestination()
		{
					}
		public void createWeather()
		{
					}
		public void updateTileset()
		{
					}
		public void _canvasReAddParallax()
		{
					}
		public void updateParallax()
		{
					}
		public void updateTilemap()
		{
					}
		public void updateShadow()
		{
					}
		public void updateWeather()
		{
					}
	}

		public class Spriteset_Battle : Spriteset_Base
	{
		public Spriteset_Battle() : base()
		{
			
		}
		public bool _battlebackLocated;
		public Sprite _backgroundSprite;
		public Sprite _battleField;
		public TilingSprite _back1Sprite;
		public TilingSprite _back2Sprite;
		public Sprite_Enemy[] _enemySprites;
		public Sprite_Actor[] _actorSprites;
		public void initialize()
		{
					}
		public void createLowerLayer()
		{
					}
		public void createBackground()
		{
					}
		public void update()
		{
					}
		public void createBattleField()
		{
					}
		public void createBattleback()
		{
					}
		public void updateBattleback()
		{
					}
		public void locateBattleback()
		{
					}
		public Bitmap battleback1Bitmap()
		{
					}
		public Bitmap battleback2Bitmap()
		{
					}
		public string battleback1Name()
		{
					}
		public string battleback2Name()
		{
					}
		public string overworldBattleback1Name()
		{
					}
		public string overworldBattleback2Name()
		{
					}
		public string normalBattleback1Name()
		{
					}
		public string normalBattleback2Name()
		{
					}
		public string terrainBattleback1Name(float type)
		{
					}
		public string terrainBattleback2Name(float type)
		{
					}
		public string defaultBattleback1Name()
		{
					}
		public string defaultBattleback2Name()
		{
					}
		public string shipBattleback1Name()
		{
					}
		public string shipBattleback2Name()
		{
					}
		public float autotileType(float z)
		{
					}
		public void createEnemies()
		{
					}
		public float compareEnemySprite(Sprite_Enemy a, Sprite_Enemy b)
		{
					}
		public void createActors()
		{
					}
		public void updateActors()
		{
					}
		public Sprite_Battler[] battlerSprites()
		{
					}
		public bool isAnimationPlaying()
		{
					}
		public bool isEffecting()
		{
					}
		public bool isAnyoneMoving()
		{
					}
		public bool isBusy()
		{
					}
	}

		public class ITextState
	{
		protected ITextState()
		{
			
		}
		public float index;
		public float x;
		public float y;
		public float left;
		public string text;
		public float height;
	}

		public class Window_Base : Window
	{
		public Window_Base(float x = default(float), float y = default(float), float width = default(float), float height = default(float)) : base()
		{
			
		}
		protected Window_Base() : base()
		{
			
		}
		public static float _iconWidth;
		public static float _iconHeight;
		public static float _faceWidth;
		public static float _faceHeight;
		public bool _opening;
		public bool _closing;
		public Sprite _dimmerSprite;
		public void initialize()
		{
					}
		public void initialize(float x = default(float), float y = default(float), float width = default(float), float height = default(float))
		{
					}
		public float lineHeight()
		{
					}
		public string standardFontFace()
		{
					}
		public float standardFontSize()
		{
					}
		public float standardPadding()
		{
					}
		public float textPadding()
		{
					}
		public float standardBackOpacity()
		{
					}
		public void loadWindowskin()
		{
					}
		public void updatePadding()
		{
					}
		public void updateBackOpacity()
		{
					}
		public float contentsWidth()
		{
					}
		public float contentsHeight()
		{
					}
		public float fittingHeight(float numLines)
		{
					}
		public void updateTone()
		{
					}
		public void createContents()
		{
					}
		public void resetFontSettings()
		{
					}
		public void resetTextColor()
		{
					}
		public void update()
		{
					}
		public void updateOpen()
		{
					}
		public void updateClose()
		{
					}
		public void open()
		{
					}
		public void close()
		{
					}
		public bool isOpening()
		{
					}
		public bool isClosing()
		{
					}
		public void show()
		{
					}
		public void hide()
		{
					}
		public void activate()
		{
					}
		public void deactivate()
		{
					}
		public string textColor(float n)
		{
					}
		public string normalColor()
		{
					}
		public string systemColor()
		{
					}
		public string crisisColor()
		{
					}
		public string deathColor()
		{
					}
		public string gaugeBackColor()
		{
					}
		public string hpGaugeColor1()
		{
					}
		public string hpGaugeColor2()
		{
					}
		public string mpGaugeColor1()
		{
					}
		public string mpGaugeColor2()
		{
					}
		public string mpCostColor()
		{
					}
		public string powerUpColor()
		{
					}
		public string powerDownColor()
		{
					}
		public string tpGaugeColor1()
		{
					}
		public string tpGaugeColor2()
		{
					}
		public string tpCostColor()
		{
					}
		public string pendingColor()
		{
					}
		public float translucentOpacity()
		{
					}
		public void changeTextColor(string color)
		{
					}
		public void changePaintOpacity(bool enabled)
		{
					}
		public void drawText(string text, float x, float y, float maxWidth = default(float), string align = default(string))
		{
					}
		public float textWidth(string text)
		{
					}
		public float drawTextEx(string text, float x, float y)
		{
					}
		public string convertEscapeCharacters(string text)
		{
					}
		public string actorName(float n)
		{
					}
		public string partyMemberName(float n)
		{
					}
		public void processCharacter(ITextState textState)
		{
					}
		public void processNormalCharacter(ITextState textState)
		{
					}
		public void processNewLine(ITextState textState)
		{
					}
		public void processNewPage(ITextState textState)
		{
					}
		public string obtainEscapeCode(ITextState textState)
		{
					}
		public string obtainEscapeParam(ITextState textState)
		{
					}
		public void processEscapeCharacter(string code, ITextState textState)
		{
					}
		public void processDrawIcon(float iconIndex, ITextState textState)
		{
					}
		public void makeFontBigger()
		{
					}
		public void makeFontSmaller()
		{
					}
		public float calcTextHeight(ITextState textState, bool all)
		{
					}
		public void drawIcon(float iconIndex, float x, float y)
		{
					}
		public void drawFace(string faceName, float faceIndex, float x, float y, float width = default(float), float height = default(float))
		{
					}
		public void drawCharacter(string characterName, float characterIndex, float x, float y)
		{
					}
		public void drawGauge(float x, float y, float width, float rate, string color1, string color2)
		{
					}
		public string hpColor(Game_Battler actor)
		{
					}
		public string mpColor(Game_Battler actor)
		{
					}
		public string tpColor(Game_Battler actor)
		{
					}
		public void drawActorCharacter(Game_Actor actor, float x, float y)
		{
					}
		public void drawActorFace(Game_Actor actor, float x, float y, float width = default(float), float height = default(float))
		{
					}
		public void drawActorName(Game_Actor actor, float x, float y, float width = default(float))
		{
					}
		public void drawActorClass(Game_Actor actor, float x, float y, float width = default(float))
		{
					}
		public void drawActorNickname(Game_Actor actor, float x, float y, float width = default(float))
		{
					}
		public void drawActorLevel(Game_Actor actor, float x, float y)
		{
					}
		public void drawActorIcons(Game_Actor actor, float x, float y, float width = default(float))
		{
					}
		public void drawCurrentAndMax(float current, float max, float x, float y, float width, string color1, string color2)
		{
					}
		public void drawActorHp(Game_Actor actor, float x, float y, float width = default(float))
		{
					}
		public void drawActorMp(Game_Actor actor, float x, float y, float width = default(float))
		{
					}
		public void drawActorTp(Game_Actor actor, float x, float y, float width = default(float))
		{
					}
		public void drawActorSimpleStatus(Game_Actor actor, float x, float y, float width)
		{
					}
		public void drawItemName(IDataAllItem item, float x, float y, float width = default(float))
		{
					}
		public void drawCurrencyValue(float value, string unit, float x, float y, float width)
		{
					}
		public string paramchangeTextColor(float change)
		{
					}
		public void setBackgroundType(float type)
		{
					}
		public void showBackgroundDimmer()
		{
					}
		public void hideBackgroundDimmer()
		{
					}
		public void updateBackgroundDimmer()
		{
					}
		public void refreshDimmerBitmap()
		{
					}
		public string dimColor1()
		{
					}
		public string dimColor2()
		{
					}
		public float canvasToLocalX(float x)
		{
					}
		public float canvasToLocalY(float y)
		{
					}
	}

		public class Window_Selectable : Window_Base
	{
		public Window_Selectable(float x = default(float), float y = default(float), float width = default(float), float height = default(float)) : base()
		{
			
		}
		protected Window_Selectable() : base()
		{
			
		}
		public float _index;
		public bool _cursorFixed;
		public bool _cursorAll;
		public float _stayCount;
		public Window_Help _helpWindow;
		public _handlers_0_ _handlers;
		public bool _touching;
		public float _scrollX;
		public float _scrollY;
		public bool downArrowVisible;
		public bool upArrowVisible;
		public void initialize()
		{
					}
		public void initialize(float x = default(float), float y = default(float), float width = default(float), float height = default(float))
		{
					}
		public float index()
		{
					}
		public bool cursorFixed()
		{
					}
		public void setCursorFixed(bool cursorFixed)
		{
					}
		public bool cursorAll()
		{
					}
		public void setCursorAll(bool cursorAll)
		{
					}
		public float maxCols()
		{
					}
		public float maxItems()
		{
					}
		public float spacing()
		{
					}
		public float itemWidth()
		{
					}
		public float itemHeight()
		{
					}
		public float maxRows()
		{
					}
		public void activate()
		{
					}
		public void deactivate()
		{
					}
		public void select(float index)
		{
					}
		public void deselect()
		{
					}
		public void reselect()
		{
					}
		public float row()
		{
					}
		public float topRow()
		{
					}
		public float maxTopRow()
		{
					}
		public void setTopRow(float row)
		{
					}
		public void resetScroll()
		{
					}
		public float maxPageRows()
		{
					}
		public float maxPageItems()
		{
					}
		public bool isHorizontal()
		{
					}
		public float bottomRow()
		{
					}
		public void setBottomRow(float row)
		{
					}
		public float topIndex()
		{
					}
		public Rectangle itemRect(float index)
		{
					}
		public Rectangle itemRectForText(float index)
		{
					}
		public void setHelpWindow(Window_Help helpWindow)
		{
					}
		public void showHelpWindow()
		{
					}
		public void hideHelpWindow()
		{
					}
		public void setHandler(string symbol, Function method)
		{
					}
		public bool isHandled(string symbol)
		{
					}
		public void callHandler(string symbol)
		{
					}
		public bool isOpenAndActive()
		{
					}
		public bool isCursorMovable()
		{
					}
		public void cursorDown(bool wrap)
		{
					}
		public void cursorUp(bool wrap)
		{
					}
		public void cursorRight(bool wrap)
		{
					}
		public void cursorLeft(bool wrap)
		{
					}
		public void cursorPagedown()
		{
					}
		public void cursorPageup()
		{
					}
		public void scrollDown()
		{
					}
		public void scrollUp()
		{
					}
		public void update()
		{
					}
		public void updateArrows()
		{
					}
		public void processCursorMove()
		{
					}
		public void processHandling()
		{
					}
		public void processWheel()
		{
					}
		public void processTouch()
		{
					}
		public bool isTouchedInsideFrame()
		{
					}
		public void onTouch(bool triggered)
		{
					}
		public float hitTest(float x, float y)
		{
					}
		public bool isContentsArea(float x, float y)
		{
					}
		public bool isTouchOkEnabled()
		{
					}
		public bool isOkEnabled()
		{
					}
		public bool isCancelEnabled()
		{
					}
		public bool isOkTriggered()
		{
					}
		public bool isCancelTriggered()
		{
					}
		public void processOk()
		{
					}
		public void playOkSound()
		{
					}
		public void playBuzzerSound()
		{
					}
		public void callOkHandler()
		{
					}
		public void processCancel()
		{
					}
		public void callCancelHandler()
		{
					}
		public void processPageup()
		{
					}
		public void processPagedown()
		{
					}
		public void updateInputData()
		{
					}
		public void updateCursor()
		{
					}
		public bool isCursorVisible()
		{
					}
		public void ensureCursorVisible()
		{
					}
		public void callUpdateHelp()
		{
					}
		public void updateHelp()
		{
					}
		public void setHelpWindowItem(IDataAllItem item)
		{
					}
		public bool isCurrentItemEnabled()
		{
					}
		public void drawAllItems()
		{
					}
		public void drawItem(float index)
		{
					}
		public void clearItem(float index)
		{
					}
		public void redrawItem(float index)
		{
					}
		public void redrawCurrentItem()
		{
					}
		public void refresh()
		{
					}

				public class _handlers_0_
		{
			
			public Function this[string index]
			{
				get
				{
					return (Function)((dynamic)this)[index];
				}				
				set
				{
					((dynamic)this)[index] = value;
				}
			}
			
		}
	}

		public class IDataCommandList
	{
		protected IDataCommandList()
		{
			
		}
		public string name;
		public string symbol;
		public bool enabled;
		public float ext;
	}

		public class Window_Command : Window_Selectable
	{
		public Window_Command(float x = default(float), float y = default(float)) : base()
		{
			
		}
		protected Window_Command() : base()
		{
			
		}
		public IDataCommandList[] _list;
		public void initialize()
		{
					}
		public void initialize(float x = default(float), float y = default(float))
		{
					}
		public float windowWidth()
		{
					}
		public float windowHeight()
		{
					}
		public float numVisibleRows()
		{
					}
		public float maxItems()
		{
					}
		public void clearCommandList()
		{
					}
		public void makeCommandList()
		{
					}
		public void addCommand(string name, string symbol, bool enabled = default(bool), float ext = default(float))
		{
					}
		public string commandName(float index)
		{
					}
		public string commandSymbol(float index)
		{
					}
		public bool isCommandEnabled(float index)
		{
					}
		public IDataCommandList currentData()
		{
					}
		public bool isCurrentItemEnabled()
		{
					}
		public string currentSymbol()
		{
					}
		public float currentExt()
		{
					}
		public float findSymbol(string symbol)
		{
					}
		public void selectSymbol(string symbol)
		{
					}
		public float findExt(float ext)
		{
					}
		public void selectExt(float ext)
		{
					}
		public void drawItem(float index)
		{
					}
		public string itemTextAlign()
		{
					}
		public bool isOkEnabled()
		{
					}
		public void callOkHandler()
		{
					}
		public void refresh()
		{
					}
	}

		public class Window_HorzCommand : Window_Command
	{
		public Window_HorzCommand(float x = default(float), float y = default(float)) : base()
		{
			
		}
		protected Window_HorzCommand() : base()
		{
			
		}
		public void initialize()
		{
					}
		public void initialize(float x = default(float), float y = default(float))
		{
					}
		public float numVisibleRows()
		{
					}
		public float maxCols()
		{
					}
		public string itemTextAlign()
		{
					}
	}

		public class Window_Help : Window_Base
	{
		public Window_Help(float numLines = default(float)) : base()
		{
			
		}
		protected Window_Help() : base()
		{
			
		}
		public string _text;
		public void initialize()
		{
					}
		public void initialize(float numLines = default(float))
		{
					}
		public void setText(string text)
		{
					}
		public void clear()
		{
					}
		public void setItem(IDataAllItem item)
		{
					}
		public void refresh()
		{
					}
	}

		public class Window_Gold : Window_Base
	{
		public Window_Gold(float x = default(float), float y = default(float)) : base()
		{
			
		}
		protected Window_Gold() : base()
		{
			
		}
		public void initialize()
		{
					}
		public void initialize(float x = default(float), float y = default(float))
		{
					}
		public float windowWidth()
		{
					}
		public float windowHeight()
		{
					}
		public void refresh()
		{
					}
		public float value()
		{
					}
		public string currencyUnit()
		{
					}
		public void open()
		{
					}
	}

		public class Window_MenuCommand : Window_Command
	{
		public Window_MenuCommand(float x = default(float), float y = default(float)) : base()
		{
			
		}
		protected Window_MenuCommand() : base()
		{
			
		}
		public static string _lastCommandSymbol;
		public static void initCommandPosition()
		{
					}
		public void initialize()
		{
					}
		public void initialize(float x = default(float), float y = default(float))
		{
					}
		public float windowWidth()
		{
					}
		public float numVisibleRows()
		{
					}
		public void makeCommandList()
		{
					}
		public void addMainCommands()
		{
					}
		public void addFormationCommand()
		{
					}
		public void addOriginalCommands()
		{
					}
		public void addOptionsCommand()
		{
					}
		public void addSaveCommand()
		{
					}
		public void addGameEndCommand()
		{
					}
		public bool needsCommand(string name)
		{
					}
		public bool areMainCommandsEnabled()
		{
					}
		public bool isFormationEnabled()
		{
					}
		public bool isOptionsEnabled()
		{
					}
		public bool isSaveEnabled()
		{
					}
		public bool isGameEndEnabled()
		{
					}
		public void processOk()
		{
					}
		public void selectLast()
		{
					}
	}

		public class Window_MenuStatus : Window_Selectable
	{
		public Window_MenuStatus(float x = default(float), float y = default(float)) : base()
		{
			
		}
		protected Window_MenuStatus() : base()
		{
			
		}
		public bool _formationMode;
		public float _pendingIndex;
		public void initialize()
		{
					}
		public void initialize(float x = default(float), float y = default(float))
		{
					}
		public float windowWidth()
		{
					}
		public float windowHeight()
		{
					}
		public float maxItems()
		{
					}
		public float itemHeight()
		{
					}
		public float numVisibleRows()
		{
					}
		public void loadImages()
		{
					}
		public void drawItem(float index)
		{
					}
		public void drawItemBackground(float index)
		{
					}
		public void drawItemImage(float index)
		{
					}
		public void drawItemStatus(float index)
		{
					}
		public void processOk()
		{
					}
		public bool isCurrentItemEnabled()
		{
					}
		public void selectLast()
		{
					}
		public bool formationMode()
		{
					}
		public void setFormationMode(bool formationMode)
		{
					}
		public float pendingIndex()
		{
					}
		public void setPendingIndex(float index)
		{
					}
	}

		public class Window_MenuActor : Window_MenuStatus
	{
		public Window_MenuActor() : base()
		{
			
		}
		public void initialize()
		{
					}
		public void processOk()
		{
					}
		public void selectLast()
		{
					}
		public void selectForItem(IDataAllItem item)
		{
					}
	}

		public class Window_ItemCategory : Window_HorzCommand
	{
		public Window_ItemCategory() : base()
		{
			
		}
		public Window_ItemList _itemWindow;
		public void initialize()
		{
					}
		public float windowWidth()
		{
					}
		public float maxCols()
		{
					}
		public void update()
		{
					}
		public void makeCommandList()
		{
					}
		public void setItemWindow(Window_ItemList itemWindow)
		{
					}
	}

		public class Window_ItemList : Window_Selectable
	{
		public Window_ItemList(float x = default(float), float y = default(float), float width = default(float), float height = default(float)) : base()
		{
			
		}
		protected Window_ItemList() : base()
		{
			
		}
		public string _category;
		public IDataAllItem[] _data;
		public void initialize()
		{
					}
		public void initialize(float x = default(float), float y = default(float), float width = default(float), float height = default(float))
		{
					}
		public void setCategory(string category)
		{
					}
		public float spacing()
		{
					}
		public float maxItems()
		{
					}
		public IDataAllItem item()
		{
					}
		public bool isCurrentItemEnabled()
		{
					}
		public bool includes(IDataAllItem item)
		{
					}
		public float needsNumber()
		{
					}
		public bool isEnabled(IDataAllItem item)
		{
					}
		public void makeItemList()
		{
					}
		public void selectLast()
		{
					}
		public void drawItem(float index)
		{
					}
		public float numberWidth()
		{
					}
		public void drawItemNumber(IDataAllItem item, float x, float y, float width)
		{
					}
		public void updateHelp()
		{
					}
		public void refresh()
		{
					}
	}

		public class Window_SkillType : Window_Command
	{
		public Window_SkillType(float x = default(float), float y = default(float)) : base()
		{
			
		}
		protected Window_SkillType() : base()
		{
			
		}
		public Game_Actor _actor;
		public Window_SkillList _skillWindow;
		public void initialize()
		{
					}
		public void initialize(float x = default(float), float y = default(float))
		{
					}
		public float windowWidth()
		{
					}
		public void setActor(Game_Actor actor)
		{
					}
		public float numVisibleRows()
		{
					}
		public void makeCommandList()
		{
					}
		public void update()
		{
					}
		public void setSkillWindow(Window_SkillList skillWindow)
		{
					}
		public void selectLast()
		{
					}
	}

		public class Window_SkillStatus : Window_Base
	{
		public Window_SkillStatus(float x = default(float), float y = default(float), float width = default(float), float height = default(float)) : base()
		{
			
		}
		protected Window_SkillStatus() : base()
		{
			
		}
		public Game_Actor _actor;
		public void initialize()
		{
					}
		public void initialize(float x = default(float), float y = default(float), float width = default(float), float height = default(float))
		{
					}
		public void setActor(Game_Actor actor)
		{
					}
		public void refresh()
		{
					}
	}

		public class Window_SkillList : Window_Selectable
	{
		public Window_SkillList(float x = default(float), float y = default(float), float width = default(float), float height = default(float)) : base()
		{
			
		}
		protected Window_SkillList() : base()
		{
			
		}
		public Game_Actor _actor;
		public float _stypeId;
		public IDataAllItem[] _data;
		public void initialize()
		{
					}
		public void initialize(float x = default(float), float y = default(float), float width = default(float), float height = default(float))
		{
					}
		public void setActor(Game_Actor actor)
		{
					}
		public void setStypeId(float stypeId)
		{
					}
		public float maxCols()
		{
					}
		public float spacing()
		{
					}
		public float maxItems()
		{
					}
		public IDataAllItem item()
		{
					}
		public bool isCurrentItemEnabled()
		{
					}
		public bool includes(IDataAllItem item)
		{
					}
		public bool isEnabled(IDataAllItem item)
		{
					}
		public void makeItemList()
		{
					}
		public void selectLast()
		{
					}
		public void drawItem(float index)
		{
					}
		public float costWidth()
		{
					}
		public void drawSkillCost(IDataSkill skill, float x, float y, float width)
		{
					}
		public void updateHelp()
		{
					}
		public void refresh()
		{
					}
	}

		public class Window_EquipStatus : Window_Base
	{
		public Window_EquipStatus(float x = default(float), float y = default(float)) : base()
		{
			
		}
		protected Window_EquipStatus() : base()
		{
			
		}
		public Game_Actor _actor;
		public Game_Actor _tempActor;
		public void initialize()
		{
					}
		public void initialize(float x = default(float), float y = default(float))
		{
					}
		public float windowWidth()
		{
					}
		public float windowHeight()
		{
					}
		public float numVisibleRows()
		{
					}
		public void setActor(Game_Actor actor)
		{
					}
		public void refresh()
		{
					}
		public void setTempActor(Game_Actor tempActor)
		{
					}
		public void drawItem(float x, float y, float paramId)
		{
					}
		public void drawParamName(float x, float y, float paramId)
		{
					}
		public void drawCurrentParam(float x, float y, float paramId)
		{
					}
		public void drawRightArrow(float x, float y)
		{
					}
		public void drawNewParam(float x, float y, float paramId)
		{
					}
	}

		public class Window_EquipCommand : Window_HorzCommand
	{
		public Window_EquipCommand(float x = default(float), float y = default(float), float width = default(float)) : base()
		{
			
		}
		protected Window_EquipCommand() : base()
		{
			
		}
		public float _windowWidth;
		public void initialize()
		{
					}
		public void initialize(float x = default(float), float y = default(float), float width = default(float))
		{
					}
		public float windowWidth()
		{
					}
		public float maxCols()
		{
					}
		public void makeCommandList()
		{
					}
	}

		public class Window_EquipSlot : Window_Selectable
	{
		public Window_EquipSlot(float x = default(float), float y = default(float), float width = default(float), float height = default(float)) : base()
		{
			
		}
		protected Window_EquipSlot() : base()
		{
			
		}
		public Game_Actor _actor;
		public Window_EquipItem _itemWindow;
		public Window_EquipStatus _statusWindow;
		public void initialize()
		{
					}
		public void initialize(float x = default(float), float y = default(float), float width = default(float), float height = default(float))
		{
					}
		public void setActor(Game_Actor actor)
		{
					}
		public void update()
		{
					}
		public float maxItems()
		{
					}
		public IDataAllItem item()
		{
					}
		public void drawItem(float index)
		{
					}
		public string slotName(float index)
		{
					}
		public bool isEnabled(float index)
		{
					}
		public bool isCurrentItemEnabled()
		{
					}
		public void setStatusWindow(Window_EquipStatus statusWindow)
		{
					}
		public void setItemWindow(Window_EquipItem itemWindow)
		{
					}
		public void updateHelp()
		{
					}
	}

		public class Window_EquipItem : Window_ItemList
	{
		public Window_EquipItem(float x = default(float), float y = default(float), float width = default(float), float height = default(float)) : base()
		{
			
		}
		protected Window_EquipItem() : base()
		{
			
		}
		public Game_Actor _actor;
		public float _slotId;
		public Window_EquipStatus _statusWindow;
		public void initialize()
		{
					}
		public void initialize(float x = default(float), float y = default(float), float width = default(float), float height = default(float))
		{
					}
		public void setActor(Game_Actor actor)
		{
					}
		public void setSlotId(float slotId)
		{
					}
		public bool includes(IDataAllItem item)
		{
					}
		public bool isEnabled(IDataAllItem item)
		{
					}
		public void selectLast()
		{
					}
		public void setStatusWindow(Window_EquipStatus statusWindow)
		{
					}
		public void updateHelp()
		{
					}
		public void playOkSound()
		{
					}
	}

		public class Window_Status : Window_Selectable
	{
		public Window_Status() : base()
		{
			
		}
		public Game_Actor _actor;
		public void initialize()
		{
					}
		public void setActor(Game_Actor actor)
		{
					}
		public void refresh()
		{
					}
		public void drawBlock1(float y)
		{
					}
		public void drawBlock2(float y)
		{
					}
		public void drawBlock3(float y)
		{
					}
		public void drawBlock4(float y)
		{
					}
		public void drawHorzLine(float y)
		{
					}
		public string lineColor()
		{
					}
		public void drawBasicInfo(float x, float y)
		{
					}
		public void drawParameters(float x, float y)
		{
					}
		public void drawExpInfo(float x, float y)
		{
					}
		public void drawEquipments(float x, float y)
		{
					}
		public void drawProfile(float x, float y)
		{
					}
		public float maxEquipmentLines()
		{
					}
	}

		public class Window_Options : Window_Command
	{
		public Window_Options() : base()
		{
			
		}
		public void initialize()
		{
					}
		public float windowWidth()
		{
					}
		public float windowHeight()
		{
					}
		public void updatePlacement()
		{
					}
		public void makeCommandList()
		{
					}
		public void addGeneralOptions()
		{
					}
		public void addVolumeOptions()
		{
					}
		public void drawItem(float index)
		{
					}
		public float statusWidth()
		{
					}
		public string statusText(float index)
		{
					}
		public bool isVolumeSymbol(string symbol)
		{
					}
		public string booleanStatusText(float value)
		{
					}
		public string volumeStatusText(float value)
		{
					}
		public void processOk()
		{
					}
		public void cursorRight(bool wrap)
		{
					}
		public void cursorLeft(bool wrap)
		{
					}
		public float volumeOffset()
		{
					}
		public void changeValue(string symbol, float value)
		{
					}
		public Any<float, bool> getConfigValue(string symbol)
		{
					}
		public void setConfigValue(string symbol, Any<float, bool> volume)
		{
					}
	}

		public class Window_SavefileList : Window_Selectable
	{
		public Window_SavefileList(float x = default(float), float y = default(float), float width = default(float), float height = default(float)) : base()
		{
			
		}
		protected Window_SavefileList() : base()
		{
			
		}
		public string _mode;
		public void initialize()
		{
					}
		public void initialize(float x = default(float), float y = default(float), float width = default(float), float height = default(float))
		{
					}
		public void setMode(string mode)
		{
					}
		public float maxItems()
		{
					}
		public float maxVisibleItems()
		{
					}
		public float itemHeight()
		{
					}
		public void drawItem(float index)
		{
					}
		public void drawFileId(float id, float x, float y)
		{
					}
		public void drawContents(ISavefileInfo info, Rectangle rect, bool valid)
		{
					}
		public void drawGameTitle(ISavefileInfo info, float x, float y, float width)
		{
					}
		public void drawPartyCharacters(ISavefileInfo info, float x, float y)
		{
					}
		public void drawPlaytime(ISavefileInfo info, float x, float y, float width)
		{
					}
		public void playOkSound()
		{
					}
	}

		public class Window_ShopCommand : Window_HorzCommand
	{
		public Window_ShopCommand(float width = default(float), bool purchaseOnly = default(bool)) : base()
		{
			
		}
		protected Window_ShopCommand() : base()
		{
			
		}
		public float _windowWidth;
		public bool _purchaseOnly;
		public void initialize()
		{
					}
		public void initialize(float width = default(float), bool purchaseOnly = default(bool))
		{
					}
		public float windowWidth()
		{
					}
		public float maxCols()
		{
					}
		public void makeCommandList()
		{
					}
	}

		public class Window_ShopBuy : Window_Selectable
	{
		public Window_ShopBuy(float x = default(float), float y = default(float), float height = default(float), object[][] shopGoods = default(object[][])) : base()
		{
			
		}
		protected Window_ShopBuy() : base()
		{
			
		}
		public object[][] _shopGoods;
		public float _money;
		public IDataAllItem[] _data;
		public float[] _price;
		public Window_EquipStatus _statusWindow;
		public void initialize()
		{
					}
		public void initialize(float x = default(float), float y = default(float), float height = default(float), object[][] shopGoods = default(object[][]))
		{
					}
		public float windowWidth()
		{
					}
		public float maxItems()
		{
					}
		public IDataAllItem item()
		{
					}
		public void setMoney(float money)
		{
					}
		public bool isCurrentItemEnabled()
		{
					}
		public float price(IDataAllItem item)
		{
					}
		public bool isEnabled(IDataAllItem item)
		{
					}
		public void refresh()
		{
					}
		public void makeItemList()
		{
					}
		public void drawItem(float index)
		{
					}
		public void setStatusWindow(Window_EquipStatus statusWindow)
		{
					}
		public void updateHelp()
		{
					}
	}

		public class Window_ShopSell : Window_ItemList
	{
		public Window_ShopSell(float x = default(float), float y = default(float), float width = default(float), float height = default(float)) : base()
		{
			
		}
		protected Window_ShopSell() : base()
		{
			
		}
		public void initialize()
		{
					}
		public void initialize(float x = default(float), float y = default(float), float width = default(float), float height = default(float))
		{
					}
		public bool isEnabled(IDataAllItem item)
		{
					}
	}

		public class Window_ShopNumber : Window_Selectable
	{
		public Window_ShopNumber(float x = default(float), float y = default(float), float height = default(float)) : base()
		{
			
		}
		protected Window_ShopNumber() : base()
		{
			
		}
		public IDataAllItem _item;
		public float _max;
		public float _price;
		public float _number;
		public string _currencyUnit;
		public Sprite_Button[] _buttons;
		public void initialize()
		{
					}
		public void initialize(float x = default(float), float y = default(float), float height = default(float))
		{
					}
		public float windowWidth()
		{
					}
		public float number()
		{
					}
		public void setup(IDataAllItem item, float max, float price)
		{
					}
		public void setCurrencyUnit(string currencyUnit)
		{
					}
		public void createButtons()
		{
					}
		public void placeButtons()
		{
					}
		public void updateButtonsVisiblity()
		{
					}
		public void showButtons()
		{
					}
		public void hideButtons()
		{
					}
		public void refresh()
		{
					}
		public void drawMultiplicationSign()
		{
					}
		public void drawNumber()
		{
					}
		public void drawTotalPrice()
		{
					}
		public float itemY()
		{
					}
		public float priceY()
		{
					}
		public float buttonY()
		{
					}
		public float cursorWidth()
		{
					}
		public float cursorX()
		{
					}
		public float maxDigits()
		{
					}
		public void update()
		{
					}
		public bool isOkTriggered()
		{
					}
		public void playOkSound()
		{
					}
		public void processNumberChange()
		{
					}
		public void changeNumber(float amount)
		{
					}
		public void updateCursor()
		{
					}
		public void onButtonUp()
		{
					}
		public void onButtonUp2()
		{
					}
		public void onButtonDown()
		{
					}
		public void onButtonDown2()
		{
					}
		public void onButtonOk()
		{
					}
	}

		public class Window_ShopStatus : Window_Base
	{
		public Window_ShopStatus(float x = default(float), float y = default(float), float width = default(float), float height = default(float)) : base()
		{
			
		}
		protected Window_ShopStatus() : base()
		{
			
		}
		public IDataAllItem _item;
		public float _pageIndex;
		public void initialize()
		{
					}
		public void initialize(float x = default(float), float y = default(float), float width = default(float), float height = default(float))
		{
					}
		public void refresh()
		{
					}
		public void setItem(IDataAllItem item)
		{
					}
		public bool isEquipItem()
		{
					}
		public void drawPossession(float x, float y)
		{
					}
		public void drawEquipInfo(float x, float y)
		{
					}
		public Game_Actor[] statusMembers()
		{
					}
		public float pageSize()
		{
					}
		public float maxPages()
		{
					}
		public void drawActorEquipInfo(float x, float y, Game_Actor actor)
		{
					}
		public void drawActorParamChange(float x, float y, Game_Actor actor, IDataAllItem item1)
		{
					}
		public IDataAllItem currentEquippedItem(Game_Actor actor, float etypeId)
		{
					}
		public void update()
		{
					}
		public void updatePage()
		{
					}
		public bool isPageChangeEnabled()
		{
					}
		public bool isPageChangeRequested()
		{
					}
		public bool isTouchedInsideFrame()
		{
					}
		public void changePage()
		{
					}
	}

		public class Window_NameEdit : Window_Base
	{
		public Window_NameEdit(Game_Actor actor = default(Game_Actor), float maxLength = default(float)) : base()
		{
			
		}
		protected Window_NameEdit() : base()
		{
			
		}
		public Game_Actor _actor;
		public string _name;
		public float _index;
		public float _maxLength;
		public string _defaultName;
		public void initialize()
		{
					}
		public void initialize(Game_Actor actor = default(Game_Actor), float maxLength = default(float))
		{
					}
		public float windowWidth()
		{
					}
		public float windowHeight()
		{
					}
		public bool restoreDefault()
		{
					}
		public bool add(string ch)
		{
					}
		public bool back()
		{
					}
		public float faceWidth()
		{
					}
		public float charWidth()
		{
					}
		public float left()
		{
					}
		public ItemRect_0_ itemRect(float index)
		{
					}
		public UnderlineRect_0_ underlineRect(float index)
		{
					}
		public void underlineColor()
		{
					}
		public void drawUnderline(float index)
		{
					}
		public void drawChar(float index)
		{
					}
		public void refresh()
		{
					}

				public class ItemRect_0_
		{
			public float x;
			public float y;
			public float width;
			public float height;
		}

				public class UnderlineRect_0_
		{
			public float x;
			public float y;
			public float width;
			public float height;
		}
	}

		public class Window_NameInput : Window_Selectable
	{
		public Window_NameInput(Window_NameEdit editWindow = default(Window_NameEdit)) : base()
		{
			
		}
		protected Window_NameInput() : base()
		{
			
		}
		public static string[] LATIN1;
		public static string[] LATIN2;
		public static string[] RUSSIA;
		public static string[] JAPAN1;
		public static string[] JAPAN2;
		public static string[] JAPAN3;
		public Window_NameEdit _editWindow;
		public float _page;
		public float _index;
		public void initialize()
		{
					}
		public void initialize(Window_NameEdit editWindow = default(Window_NameEdit))
		{
					}
		public float windowHeight()
		{
					}
		public string[][] table()
		{
					}
		public float maxCols()
		{
					}
		public float maxItems()
		{
					}
		public string character()
		{
					}
		public bool isPageChange()
		{
					}
		public bool isOk()
		{
					}
		public Rectangle itemRect(float index)
		{
					}
		public void refresh()
		{
					}
		public void updateCursor()
		{
					}
		public bool isCursorMovable()
		{
					}
		public void cursorDown(bool wrap)
		{
					}
		public void cursorUp(bool wrap)
		{
					}
		public void cursorRight(bool wrap)
		{
					}
		public void cursorLeft(bool wrap)
		{
					}
		public void cursorPagedown()
		{
					}
		public void cursorPageup()
		{
					}
		public void processCursorMove()
		{
					}
		public void processHandling()
		{
					}
		public bool isCancelEnabled()
		{
					}
		public void processCancel()
		{
					}
		public void processJump()
		{
					}
		public void processBack()
		{
					}
		public void processOk()
		{
					}
		public void onNameAdd()
		{
					}
		public void onNameOk()
		{
					}

				public class ItemRect_1_
		{
			public float x;
			public float y;
			public float width;
			public float height;
		}
	}

		public class Window_ChoiceList : Window_Command
	{
		public Window_ChoiceList(Window_Message messageWindow = default(Window_Message)) : base()
		{
			
		}
		protected Window_ChoiceList() : base()
		{
			
		}
		public Window_Message _messageWindow;
		public float _background;
		public void initialize()
		{
					}
		public void initialize(Window_Message messageWindow = default(Window_Message))
		{
					}
		public void start()
		{
					}
		public void selectDefault()
		{
					}
		public void updatePlacement()
		{
					}
		public void updateBackground()
		{
					}
		public float windowWidth()
		{
					}
		public float numVisibleRows()
		{
					}
		public float maxChoiceWidth()
		{
					}
		public float textWidthEx(string text)
		{
					}
		public float contentsHeight()
		{
					}
		public void makeCommandList()
		{
					}
		public void drawItem(float index)
		{
					}
		public bool isCancelEnabled()
		{
					}
		public bool isOkTriggered()
		{
					}
		public void callOkHandler()
		{
					}
		public void callCancelHandler()
		{
					}
	}

		public class Window_NumberInput : Window_Selectable
	{
		public Window_NumberInput(Window_Message messageWindow = default(Window_Message)) : base()
		{
			
		}
		protected Window_NumberInput() : base()
		{
			
		}
		public Window_Message _messageWindow;
		public float _number;
		public float _maxDigits;
		public Sprite_Button[] _buttons;
		public void initialize()
		{
					}
		public void initialize(Window_Message messageWindow = default(Window_Message))
		{
					}
		public void start()
		{
					}
		public void updatePlacement()
		{
					}
		public float windowWidth()
		{
					}
		public float windowHeight()
		{
					}
		public float maxCols()
		{
					}
		public float maxItems()
		{
					}
		public float spacing()
		{
					}
		public float itemWidth()
		{
					}
		public void createButtons()
		{
					}
		public void placeButtons()
		{
					}
		public void updateButtonsVisiblity()
		{
					}
		public void showButtons()
		{
					}
		public void hideButtons()
		{
					}
		public float buttonY()
		{
					}
		public void update()
		{
					}
		public void processDigitChange()
		{
					}
		public void changeDigit(bool up)
		{
					}
		public bool isTouchOkEnabled()
		{
					}
		public bool isOkEnabled()
		{
					}
		public bool isCancelEnabled()
		{
					}
		public bool isOkTriggered()
		{
					}
		public void processOk()
		{
					}
		public void drawItem(float index)
		{
					}
		public void onButtonUp()
		{
					}
		public void onButtonDown()
		{
					}
		public void onButtonOk()
		{
					}
	}

		public class Window_EventItem : Window_ItemList
	{
		public Window_EventItem(Window_Message messageWindow = default(Window_Message)) : base()
		{
			
		}
		protected Window_EventItem() : base()
		{
			
		}
		public Window_Message _messageWindow;
		public void initialize()
		{
					}
		public void initialize(Window_Message messageWindow = default(Window_Message))
		{
					}
		public float windowHeight()
		{
					}
		public float numVisibleRows()
		{
					}
		public void start()
		{
					}
		public void updatePlacement()
		{
					}
		public bool includes(IDataAllItem item)
		{
					}
		public bool isEnabled(IDataAllItem item)
		{
					}
		public void onOk()
		{
					}
		public void onCancel()
		{
					}
	}

		public class Window_Message : Window_Base
	{
		public Window_Message() : base()
		{
			
		}
		public float _background;
		public float _positionType;
		public float _waitCount;
		public Bitmap _faceBitmap;
		public ITextState _textState;
		public Window_Gold _goldWindow;
		public Window_ChoiceList _choiceWindow;
		public Window_NumberInput _numberWindow;
		public Window_EventItem _itemWindow;
		public bool _showFast;
		public bool _lineShowFast;
		public bool _pauseSkip;
		public void initialize()
		{
					}
		public void initMembers()
		{
					}
		public Window_Base[] subWindows()
		{
					}
		public void createSubWindows()
		{
					}
		public float windowWidth()
		{
					}
		public float windowHeight()
		{
					}
		public void clearFlags()
		{
					}
		public float numVisibleRows()
		{
					}
		public void update()
		{
					}
		public void checkToNotClose()
		{
					}
		public bool canStart()
		{
					}
		public void startMessage()
		{
					}
		public void updatePlacement()
		{
					}
		public void updateBackground()
		{
					}
		public void terminateMessage()
		{
					}
		public void updateWait()
		{
					}
		public void updateLoading()
		{
					}
		public void updateInput()
		{
					}
		public bool isAnySubWindowActive()
		{
					}
		public bool updateMessage()
		{
					}
		public void onEndOfText()
		{
					}
		public bool startInput()
		{
					}
		public bool isTriggered()
		{
					}
		public bool doesContinue()
		{
					}
		public bool areSettingsChanged()
		{
					}
		public void updateShowFast()
		{
					}
		public void newPage(ITextState textState)
		{
					}
		public void loadMessageFace()
		{
					}
		public void drawMessageFace()
		{
					}
		public float newLineX()
		{
					}
		public void processNewLine(ITextState textState)
		{
					}
		public void processNewPage(ITextState textState)
		{
					}
		public bool isEndOfText(ITextState textState)
		{
					}
		public bool needsNewPage(ITextState textState)
		{
					}
		public void processEscapeCharacter(string code, ITextState textState)
		{
					}
		public void startWait(float count)
		{
					}
		public void startPause()
		{
					}
	}

		public class Window_ScrollText : Window_Base
	{
		public Window_ScrollText() : base()
		{
			
		}
		public string _text;
		public float _allTextHeight;
		public void initialize()
		{
					}
		public void update()
		{
					}
		public void startMessage()
		{
					}
		public void refresh()
		{
					}
		public float contentsHeight()
		{
					}
		public void updateMessage()
		{
					}
		public float scrollSpeed()
		{
					}
		public bool isFastForward()
		{
					}
		public float fastForwardRate()
		{
					}
		public void terminateMessage()
		{
					}
	}

		public class Window_MapName : Window_Base
	{
		public Window_MapName() : base()
		{
			
		}
		public float _showCount;
		public void initialize()
		{
					}
		public float windowWidth()
		{
					}
		public float windowHeight()
		{
					}
		public void update()
		{
					}
		public void updateFadeIn()
		{
					}
		public void updateFadeOut()
		{
					}
		public void open()
		{
					}
		public void close()
		{
					}
		public void refresh()
		{
					}
		public void drawBackground(float x, float y, float width, float height)
		{
					}
	}

		public class Window_BattleLog : Window_Selectable
	{
		public Window_BattleLog() : base()
		{
			
		}
		public string[] _lines;
		public _methods_0_[] _methods;
		public float _waitCount;
		public string _waitMode;
		public float[] _baseLineStack;
		public Spriteset_Battle _spriteset;
		public Bitmap _backBitmap;
		public Sprite _backSprite;
		public void initialize()
		{
					}
		public void setSpriteset(Spriteset_Battle spriteset)
		{
					}
		public float windowWidth()
		{
					}
		public float windowHeight()
		{
					}
		public float maxLines()
		{
					}
		public void createBackBitmap()
		{
					}
		public void createBackSprite()
		{
					}
		public float numLines()
		{
					}
		public float messageSpeed()
		{
					}
		public bool isBusy()
		{
					}
		public void update()
		{
					}
		public float updateWait()
		{
					}
		public float updateWaitCount()
		{
					}
		public float updateWaitMode()
		{
					}
		public void setWaitMode(string waitMode)
		{
					}
		public void callNextMethod()
		{
					}
		public bool isFastForward()
		{
					}
		public void push(string methodName, params object[][] args)
		{
					}
		public void clear()
		{
					}
		public void wait()
		{
					}
		public void waitForEffect()
		{
					}
		public void waitForMovement()
		{
					}
		public void addText(string text)
		{
					}
		public void pushBaseLine()
		{
					}
		public void popBaseLine()
		{
					}
		public void waitForNewLine()
		{
					}
		public void popupDamage(Game_Battler target)
		{
					}
		public void performActionStart(Game_Battler subject, Game_Action action)
		{
					}
		public void performAction(Game_Battler subject, Game_Action action)
		{
					}
		public void performActionEnd(Game_Battler subject)
		{
					}
		public void performDamage(Game_Battler target)
		{
					}
		public void performMiss(Game_Battler target)
		{
					}
		public void performRecovery(Game_Battler target)
		{
					}
		public void performEvasion(Game_Battler target)
		{
					}
		public void performMagicEvasion(Game_Battler target)
		{
					}
		public void performCounter(Game_Battler target)
		{
					}
		public void performReflection(Game_Battler target)
		{
					}
		public void performSubstitute(Game_Battler substitute, Game_Battler target)
		{
					}
		public void performCollapse(Game_Battler target)
		{
					}
		public void showAnimation(Game_Battler subject, Game_Battler[] targets, float animationId)
		{
					}
		public void showAttackAnimation(Game_Battler subject, Game_Battler[] targets)
		{
					}
		public void showActorAttackAnimation(Game_Battler subject, Game_Battler[] targets)
		{
					}
		public void showEnemyAttackAnimation(Game_Battler subject, Game_Battler[] targets)
		{
					}
		public void showNormalAnimation(Game_Battler[] targets, float animationId, bool mirror)
		{
					}
		public float animationBaseDelay()
		{
					}
		public float animationNextDelay()
		{
					}
		public void refresh()
		{
					}
		public void drawBackground()
		{
					}
		public BackRect_0_ backRect()
		{
					}
		public string backColor()
		{
					}
		public float backPaintOpacity()
		{
					}
		public void drawLineText(float index)
		{
					}
		public void startTurn()
		{
					}
		public void startAction(Game_Battler subject, Game_Action action, Game_Battler[] targets)
		{
					}
		public void endAction(Game_Battler subject)
		{
					}
		public void displayCurrentState(Game_Battler subject)
		{
					}
		public void displayRegeneration(Game_Battler subject)
		{
					}
		public void displayAction(Game_Battler subject, IDataItem item)
		{
					}
		public void displayCounter(Game_Battler target)
		{
					}
		public void displayReflection(Game_Battler target)
		{
					}
		public void displaySubstitute(Game_Battler substitute, Game_Battler target)
		{
					}
		public void displayActionResults(Game_Battler substitute, Game_Battler target)
		{
					}
		public void displayFailure(Game_Battler target)
		{
					}
		public void displayCritical(Game_Battler target)
		{
					}
		public void displayDamage(Game_Battler target)
		{
					}
		public void displayMiss(Game_Battler target)
		{
					}
		public void displayEvasion(Game_Battler target)
		{
					}
		public void displayHpDamage(Game_Battler target)
		{
					}
		public void displayMpDamage(Game_Battler target)
		{
					}
		public void displayTpDamage(Game_Battler target)
		{
					}
		public void displayAffectedStatus(Game_Battler target)
		{
					}
		public void displayAutoAffectedStatus(Game_Battler target)
		{
					}
		public void displayChangedStates(Game_Battler target)
		{
					}
		public void displayAddedStates(Game_Battler target)
		{
					}
		public void displayRemovedStates(Game_Battler target)
		{
					}
		public void displayChangedBuffs(Game_Battler target)
		{
					}
		public void displayBuffs(Game_Battler target, float[] buffs, string fmt)
		{
					}
		public void makeHpDamageText(Game_Battler target)
		{
					}
		public void makeMpDamageText(Game_Battler target)
		{
					}
		public void makeTpDamageText(Game_Battler target)
		{
					}

				public class _methods_0_
		{
			public string name;
			public object[] params;
		}

				public class BackRect_0_
		{
			public float x;
			public float y;
			public float width;
			public float height;
		}
	}

		public class Window_PartyCommand : Window_Command
	{
		public Window_PartyCommand() : base()
		{
			
		}
		public void initialize()
		{
					}
		public float windowWidth()
		{
					}
		public float numVisibleRows()
		{
					}
		public void makeCommandList()
		{
					}
		public void setup()
		{
					}
	}

		public class Window_ActorCommand : Window_Command
	{
		public Window_ActorCommand() : base()
		{
			
		}
		public Game_Actor _actor;
		public void initialize()
		{
					}
		public float windowWidth()
		{
					}
		public float numVisibleRows()
		{
					}
		public void makeCommandList()
		{
					}
		public void addAttackCommand()
		{
					}
		public void addSkillCommands()
		{
					}
		public void addGuardCommand()
		{
					}
		public void addItemCommand()
		{
					}
		public void setup(Game_Actor actor)
		{
					}
		public void processOk()
		{
					}
		public void selectLast()
		{
					}
	}

		public class Window_BattleStatus : Window_Selectable
	{
		public Window_BattleStatus() : base()
		{
			
		}
		public void initialize()
		{
					}
		public float windowWidth()
		{
					}
		public float windowHeight()
		{
					}
		public float numVisibleRows()
		{
					}
		public float maxItems()
		{
					}
		public void refresh()
		{
					}
		public void drawItem(float index)
		{
					}
		public void basicAreaRect(float index)
		{
					}
		public void gaugeAreaRect(float index)
		{
					}
		public float gaugeAreaWidth()
		{
					}
		public void drawBasicArea(Rect_1_ rect, Game_Actor actor)
		{
					}
		public void drawGaugeArea(Rect_3_ rect, Game_Actor actor)
		{
					}
		public void drawGaugeAreaWithTp(Rect_5_ rect, Game_Actor actor)
		{
					}
		public void drawGaugeAreaWithoutTp(Rect_7_ rect, Game_Actor actor)
		{
					}

				public class Rect_0_
		{
			public float x;
			public float y;
			public float width;
			public float height;
		}

				public class Rect_1_
		{
			public float x;
			public float y;
			public float width;
			public float height;
		}

				public class Rect_2_
		{
			public float x;
			public float y;
			public float width;
			public float height;
		}

				public class Rect_3_
		{
			public float x;
			public float y;
			public float width;
			public float height;
		}

				public class Rect_4_
		{
			public float x;
			public float y;
			public float width;
			public float height;
		}

				public class Rect_5_
		{
			public float x;
			public float y;
			public float width;
			public float height;
		}

				public class Rect_6_
		{
			public float x;
			public float y;
			public float width;
			public float height;
		}

				public class Rect_7_
		{
			public float x;
			public float y;
			public float width;
			public float height;
		}
	}

		public class Window_BattleActor : Window_BattleStatus
	{
		public Window_BattleActor(float x = default(float), float y = default(float)) : base()
		{
			
		}
		protected Window_BattleActor() : base()
		{
			
		}
		public void initialize()
		{
					}
		public void initialize(float x = default(float), float y = default(float))
		{
					}
		public void show()
		{
					}
		public void hide()
		{
					}
		public void select(float index)
		{
					}
		public Game_Actor actor()
		{
					}
	}

		public class Window_BattleEnemy : Window_Selectable
	{
		public Window_BattleEnemy(float x = default(float), float y = default(float)) : base()
		{
			
		}
		protected Window_BattleEnemy() : base()
		{
			
		}
		public Game_Enemy[] _enemies;
		public void initialize()
		{
					}
		public void initialize(float x = default(float), float y = default(float))
		{
					}
		public float windowWidth()
		{
					}
		public float windowHeight()
		{
					}
		public float numVisibleRows()
		{
					}
		public float maxCols()
		{
					}
		public float maxItems()
		{
					}
		public Game_Enemy enemy()
		{
					}
		public float enemyIndex()
		{
					}
		public void drawItem(float index)
		{
					}
		public void show()
		{
					}
		public void hide()
		{
					}
		public void refresh()
		{
					}
		public void select(float index)
		{
					}
	}

		public class Window_BattleSkill : Window_SkillList
	{
		public Window_BattleSkill(float x = default(float), float y = default(float), float width = default(float), float height = default(float)) : base()
		{
			
		}
		protected Window_BattleSkill() : base()
		{
			
		}
		public void initialize()
		{
					}
		public void initialize(float x = default(float), float y = default(float), float width = default(float), float height = default(float))
		{
					}
		public void show()
		{
					}
		public void hide()
		{
					}
	}

		public class Window_BattleItem : Window_ItemList
	{
		public Window_BattleItem(float x = default(float), float y = default(float), float width = default(float), float height = default(float)) : base()
		{
			
		}
		protected Window_BattleItem() : base()
		{
			
		}
		public void initialize()
		{
					}
		public void initialize(float x = default(float), float y = default(float), float width = default(float), float height = default(float))
		{
					}
		public bool includes(IDataAllItem item)
		{
					}
		public void show()
		{
					}
		public void hide()
		{
					}
	}

		public class Window_TitleCommand : Window_Command
	{
		public Window_TitleCommand() : base()
		{
			
		}
		public static string _lastCommandSymbol;
		public static void initCommandPosition()
		{
					}
		public void initialize()
		{
					}
		public float windowWidth()
		{
					}
		public void updatePlacement()
		{
					}
		public void makeCommandList()
		{
					}
		public bool isContinueEnabled()
		{
					}
		public void processOk()
		{
					}
		public void selectLast()
		{
					}
	}

		public class Window_GameEnd : Window_Command
	{
		public Window_GameEnd() : base()
		{
			
		}
		public void initialize()
		{
					}
		public float windowWidth()
		{
					}
		public void updatePlacement()
		{
					}
		public void makeCommandList()
		{
					}
	}

		public class Window_DebugRange : Window_Selectable
	{
		public Window_DebugRange(float x = default(float), float y = default(float)) : base()
		{
			
		}
		protected Window_DebugRange() : base()
		{
			
		}
		public float _maxSwitches;
		public float _maxVariables;
		public Window_DebugEdit _editWindow;
		public void initialize()
		{
					}
		public void initialize(float x = default(float), float y = default(float))
		{
					}
		public float windowWidth()
		{
					}
		public float windowHeight()
		{
					}
		public float maxItems()
		{
					}
		public void update()
		{
					}
		public string mode()
		{
					}
		public float topId()
		{
					}
		public void refresh()
		{
					}
		public void drawItem(float index)
		{
					}
		public bool isCancelTriggered()
		{
					}
		public void processCancel()
		{
					}
		public void setEditWindow(Window_DebugEdit editWindow)
		{
					}
	}

		public class Window_DebugEdit : Window_Selectable
	{
		public Window_DebugEdit(float x = default(float), float y = default(float), float width = default(float)) : base()
		{
			
		}
		protected Window_DebugEdit() : base()
		{
			
		}
		public string _mode;
		public float _topId;
		public void initialize()
		{
					}
		public void initialize(float x = default(float), float y = default(float), float width = default(float))
		{
					}
		public float maxItems()
		{
					}
		public void refresh()
		{
					}
		public void drawItem(float index)
		{
					}
		public string itemName(float dataId)
		{
					}
		public void itemStatus(float dataId)
		{
					}
		public void setMode(string mode)
		{
					}
		public void setTopId(float id)
		{
					}
		public float currentId()
		{
					}
		public void update()
		{
					}
		public void updateSwitch()
		{
					}
		public void updateVariable()
		{
					}
	}
}
