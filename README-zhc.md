# GF-Core

GameFramework框架核心

[EnglishDoc](README.md)

## 前言

某一天，我只想使用GF其中的某个功能，但是我又不想使用整个GF，然后这个GF模块化就出来了。

得益于[GameFramework](https://github.com/EllanJiang/GameFramework) 本身的优秀模块化设计，与应用层的剥离，使得这个模块化工作变得异常简单。

其实我做的东西也不多，大部分是ctrl cv，然后便是把一些接口进行暴露，最后使得每个模块都能独自运行。

## 第一件事情

在你做你想做的事情之前，前瞧瞧 [GameFramework](https://github.com/EllanJiang/GameFramework) 这个仓库。

感谢E大 [EllanJiang](https://github.com/EllanJiang)。

## 核心模块

该核心模块不提供任何功能，但所有功能模块都依赖此核心模块，所以你必须先安装该核心模块后再添加各种功能模块。

- [GF-EventSystem](https://github.com/shaun-he/GF-EventSystem) 强大的事件系统

- [GF-Debugger](https://github.com/shaun-he/GF-Debugger) GF的调试器，功能非常全的调试器。

- [GF-ObjectPoolSystem](https://github.com/shaun-he/GF-ObjectPoolSystem) GF的对象池系统。

- [GF-FsmSystem](https://github.com/shaun-he/GF-FsmSystem) GF的状态机系统。如GF的流程功能就是运用了该状态机，但扩展功能绝不仅于此。

## 安装

### 通过Git链接安装

安装需要支持PackageManager的Unity版本 (Unity >= 2019.3.4f1, Unity >= 2020.1a21). 

然后在unity中依次打开 Window -> Package Manager -> Add package from git URL

然后把下方的连接粘贴进去，然后点击Add

 `https://github.com/shaun-he/GF-Core.git` 

### 通过本地安装

1. 点击页面绿色的按钮，然后点击**Download Zip**下载

2. 解压到一个地方，你随意

3. 然后在Unity中依次打开 Window -> Package Manager -> Add package from disk

4. 在弹出窗口中找到解压文件夹里的 **package.json**.
