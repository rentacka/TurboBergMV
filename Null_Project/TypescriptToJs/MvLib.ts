///<reference path='mscorlib.ts'/>
///<reference path='TkoolCore/rpgmakermv.d.ts'/>

class MvLib_SceneManager extends NObject
{
    getActorObj(): Game_Actor
    {
        // �I�𒆂̃A�N�^�[�I�u�W�F�N�g�擾
        return $gameParty.menuActor();
    }

    // https://raw.githubusercontent.com/triacontane/RPGMakerMV/master/MenuCommonEvent.js
    // �E�B���h�E�I�u�W�F�N�g���擾���܂��B
    getSceneWindow(windowName: string): Window
    {
        var sceneWindow = SceneManager._scene[windowName];
        return sceneWindow instanceof Window ? sceneWindow : null;
    }

    // �e�X�g
    getSceneWindow_Base(windowName: string): Window_Base {
        var sceneWindow = SceneManager._scene[windowName];
        return sceneWindow instanceof Window_Base ? sceneWindow : null;
    }

    // �e�X�g2
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
