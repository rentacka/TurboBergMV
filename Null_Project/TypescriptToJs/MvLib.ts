///<reference path='mscorlib.ts'/>
///<reference path='TkoolCore/rpgmakermv.d.ts'/>

class MvLib_SceneManager extends NObject
{
    getActorObj(): Game_Actor
    {
        // 選択中のアクターオブジェクト取得
        return $gameParty.menuActor();
    }

    // https://raw.githubusercontent.com/triacontane/RPGMakerMV/master/MenuCommonEvent.js
    // ウィンドウオブジェクトを取得します。
    getSceneWindow(windowName: string): Window
    {
        var sceneWindow = SceneManager._scene[windowName];
        return sceneWindow instanceof Window ? sceneWindow : null;
    }

    // テスト
    getSceneWindow_Base(windowName: string): Window_Base {
        var sceneWindow = SceneManager._scene[windowName];
        return sceneWindow instanceof Window_Base ? sceneWindow : null;
    }

    // テスト2
    getSceneWindow_T<T>(windowName: string, constructor: { new(): T }): T {
        var sceneWindow = SceneManager._scene[windowName];
        return (sceneWindow instanceof constructor) ? sceneWindow : null;
    }

    getSceneWindowList(): Window[]
    {
        var windowList = [];
        for (var sceneWindow in SceneManager._scene) {
            if (SceneManager._scene.hasOwnProperty(sceneWindow) && SceneManager._scene[sceneWindow] instanceof Window) {
                windowList.push(SceneManager._scene[sceneWindow]);
            }
        }
        return windowList;
    }

	constructor()
	{
		super();
	}
}
